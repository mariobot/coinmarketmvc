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

            // https://pro-api.coinmarketcap.com/v1/cryptocurrency/info
            //  https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest             
            // string result = Util.Services.GET_V2("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");
            // string result2 = Util.Services.GET_V2("https://pro-api.coinmarketcap.com/v1/cryptocurrency/info?id=2");


            //var _coins = (List<Coin>)JsonConvert.DeserializeObject<List<Coin>>(result, typeof(List<Coin>)));

            //List<Coin> myDeserializedObjList = (List<Coin>)Newtonsoft.Json.JsonConvert.DeserializeObject(result, typeof(List<Coin>));

            //dynamic results = JsonConvert.DeserializeObject<dynamic>(result);
            //var _data = results.data;
            //List<dynamic> myDeserializedObjList = (List<dynamic>)Newtonsoft.Json.JsonConvert.DeserializeObject(_data, typeof(List<dynamic>));

            //RootObject rex = (RootObject)Newtonsoft.Json.JsonConvert.DeserializeObject(result, typeof(RootObject));
            //dynamic rex2 = new JDynamic(result2);
            //List<Coin2> rex = CastDataToList<Coin2>(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var conString = System.Configuration.ConfigurationManager.ConnectionStrings["SQLSERVER_CONNECTION_STRING"];
            var conString2 = System.Configuration.ConfigurationManager.ConnectionStrings["SQLSERVER_URI"];

            ViewBag.Message = conString;
            ViewBag.Message2 = conString2;

            return View();
        }       
    }
}