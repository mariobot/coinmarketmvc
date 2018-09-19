using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using CoinMarketMVC.Models;
using Newtonsoft.Json;

namespace CoinMarketMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //https://api.coinmarketcap.com/v1/ticker/bitcoin/
            //https://api.coinmarketcap.com/v2/listings/
            string result = Util.Services.GET_V1("https://api.coinmarketcap.com/v1/ticker/");
            
            //var _coins = (List<Coin>)JsonConvert.DeserializeObject<List<Coin>>(result, typeof(List<Coin>)));

            List<Coin> myDeserializedObjList = (List<Coin>)Newtonsoft.Json.JsonConvert.DeserializeObject(result, typeof(List<Coin>));

            return View(myDeserializedObjList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }       
    }
}