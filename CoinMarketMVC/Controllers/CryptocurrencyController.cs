using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chsword;
using CoinMarketMVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoinMarketMVC.Controllers
{
    public class CryptocurrencyController : Controller
    {
        // GET: Cryptocurrency
        public ActionResult Index()
        {


            // https://pro-api.coinmarketcap.com/v1/cryptocurrency/info
            //  https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest             
            string result = Util.Services.GET_V2("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");
            string result2 = Util.Services.GET_V2("https://pro-api.coinmarketcap.com/v1/cryptocurrency/info?id=2");
            

            //var _coins = (List<Coin>)JsonConvert.DeserializeObject<List<Coin>>(result, typeof(List<Coin>)));

            //List<Coin> myDeserializedObjList = (List<Coin>)Newtonsoft.Json.JsonConvert.DeserializeObject(result, typeof(List<Coin>));

            //dynamic results = JsonConvert.DeserializeObject<dynamic>(result);
            //var _data = results.data;
            //List<dynamic> myDeserializedObjList = (List<dynamic>)Newtonsoft.Json.JsonConvert.DeserializeObject(_data, typeof(List<dynamic>));

            RootObject rex = (RootObject)Newtonsoft.Json.JsonConvert.DeserializeObject(result, typeof(RootObject));
            dynamic rex2 = new JDynamic(result2);            
            //List<Coin2> rex = CastDataToList<Coin2>(result);

            return View(rex);
        }

        private static List<T> CastDataToList<T>(string result) //where T : System.IComparable<T>
        {
            JObject resultObject = JObject.Parse(result);

            // get JSON result objects into a list
            List<JToken> results = resultObject["data"].Children().ToList();

            // serialize JSON results into .NET objects
            List<T> ListaEntidades = new List<T>();
            foreach (JToken item in results)
            {
                // JToken.ToObject is a helper method that uses JsonSerializer internally
                T Entidad = item.ToObject<T>();
                ListaEntidades.Add(Entidad);
            }

            return ListaEntidades;
        }
    }
}