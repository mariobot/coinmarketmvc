using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Chsword;
using CoinMarketMVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CoinmarketcapAPIv2.DataContracts;

namespace CoinMarketMVC.Controllers
{
    public class CryptocurrencyController : Controller
    {
        CoinmarketcapAPIv2.CoinmarketcapAPI API = new CoinmarketcapAPIv2.CoinmarketcapAPI();

        public async Task<ActionResult> Index()
        {
            CoinmarketcapAPIv2.DataContracts.Ticker.Ticker _ticker = await API.GetTicker(0, 100, null);

            return View(_ticker);
        }

        public async Task<ActionResult> Listing()
        {
            CoinmarketcapAPIv2.DataContracts.Listings.Listings _listings = await API.GetListings();

            return View(_listings);
        }

        public async Task<ActionResult> Global() {
            
            CoinmarketcapAPIv2.DataContracts.Global.Global _global = await API.GetGlobal();
            
            return View(_global);
        }

        public async Task<ActionResult> Currency(string id) {

            CoinmarketcapAPIv2.DataContracts.Ticker.TickerSpecific _tickerSpecific = await API.GetTickerSecific(id);

            return View(_tickerSpecific);
        }
    }
}