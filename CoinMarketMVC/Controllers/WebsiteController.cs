using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using CoinMarketMVC.Util;

namespace CoinMarketMVC.Controllers
{
    public class WebsiteController : Controller
    {
        

        // GET: Website
        public ActionResult Index(string url)
        {
            if (string.IsNullOrEmpty(url))
                url = "www.coinmarketcap.com";

            DataContracts.Microlink.Microlink _microlink = new DataContracts.Microlink.Microlink();

            bool isUri = IsUrlValid(url);

            if (isUri)
            {
                string jSon = Util.Services.GET_V1(string.Format("https://api.microlink.io/?url=https://{0}&filter=author,title,publisher,image,description,url", url));
                _microlink = (DataContracts.Microlink.Microlink)Newtonsoft.Json.JsonConvert.DeserializeObject(jSon, typeof(DataContracts.Microlink.Microlink));
                ViewBag.Message = "";
            }
            else {
                ViewBag.Message = "Incorrect format, you need to insert www.website.com format";
            }
            
            return View(_microlink);
        }

        private bool IsUrlValid(string url)
        {
            string pattern = @"^(www.|[a-zA-Z].)[a-zA-Z0-9\-\.]+\.(com|edu|gov|mil|net|org|biz|info|name|museum|us|ca|uk)(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\;\?\'\\\+&amp;%\$#\=~_\-]+))*$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(url);
        }
    }
}