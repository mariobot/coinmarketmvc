using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using CoinMarketMVC.Util;
using CoinMarketMVC.DataContracts.Microlink;

namespace CoinMarketMVC.Controllers
{
    public class WebsiteController : Controller
    {
        CoinMarketMVC.Models.CoinDatabase db = new CoinMarketMVC.Models.CoinDatabase();

        // GET: Website
        public ActionResult Index(string url)
        {
            if (string.IsNullOrEmpty(url))
                url = "www.coinmarketcap.com";

            Microlink _microlink = new Microlink();

            bool isUri = IsUrlValid(url);

            if (isUri)
            {
                string jSon = Util.Services.GET_V1(string.Format("https://api.microlink.io/?url=https://{0}&filter=author,title,publisher,image,description,url", url));
                _microlink = (Microlink)Newtonsoft.Json.JsonConvert.DeserializeObject(jSon, typeof(Microlink));
                ViewBag.Message = "";
                
                Data _result = db.DataMicrolinks.Find(_microlink.data.url);
                if (_result == null)
                {
                    db.DataMicrolinks.Add(_microlink.data);
                    db.SaveChanges();
                }                    
                
            }
            else {
                ViewBag.Message = "Incorrect format, you need to insert www.website.com format";
            }
            
            return View(_microlink);
        }

        public ActionResult AllWebsites() {

            List<Data> _websites = db.DataMicrolinks.ToList();

            return View(_websites);
        }

        public ActionResult DeleteWebsite(string url)
        {
            Data _itemToDelete = db.DataMicrolinks.Find(url);

            if (_itemToDelete != null)
            {
                db.DataMicrolinks.Remove(_itemToDelete);
                db.SaveChanges();
            }           

            List<Data> _websites = db.DataMicrolinks.ToList();

            return View("AllWebsites",_websites);
        }


        private bool IsUrlValid(string url)
        {
            string pattern = @"^(www.|[a-zA-Z].)[a-zA-Z0-9\-\.]+\.(com|edu|gov|mil|net|org|biz|info|name|museum|us|ca|uk)(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\;\?\'\\\+&amp;%\$#\=~_\-]+))*$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(url);
        }
    }
}