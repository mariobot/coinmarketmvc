using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinMarketMVC.Models
{
    public class Coins
    {
        public List<Coin> data { get; set; }
    }

    public class Coin
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("symbol")]
        public string symbol { get; set; }
        [JsonProperty("rank")]
        public Int16? rank { get; set; }
        [JsonProperty("price_usd")]
        public Double? price_usd { get; set; }
        [JsonProperty("price_btc")]
        public Double? price_btc { get; set; }
        [JsonProperty("percent_change_1h")]
        public Double? percent_change_1h { get; set; }
        [JsonProperty("percent_change_24h")]
        public Double? percent_change_24h { get; set; }
        [JsonProperty("percent_change_7d")]
        public Double? percent_change_7d { get; set; }
        [JsonProperty("last_updated")]
        public Double? last_updated { get; set; }

        /*
        "id": "bitcoin", 
        "name": "Bitcoin", 
        "symbol": "BTC", 
        "rank": "1", 
        "price_usd": "6314.64252561", 
        "price_btc": "1.0", 
        "24h_volume_usd": "3881979173.88", 
        "market_cap_usd": "109015590740", 
        "available_supply": "17263937.0", 
        "total_supply": "17263937.0", 
        "max_supply": "21000000.0", 
        "percent_change_1h": "0.09", 
        "percent_change_24h": "0.44", 
        "percent_change_7d": "-9.77", 
        "last_updated": "1536769704"
        */

    }

    public class Coin2
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("symbol")]
        public string symbol { get; set; }
        [JsonProperty("rank")]
        public Int16? rank { get; set; }
        [JsonProperty("price_usd")]
        public Double? price_usd { get; set; }
        [JsonProperty("price_btc")]
        public Double? price_btc { get; set; }
        [JsonProperty("percent_change_1h")]
        public Double? percent_change_1h { get; set; }
        [JsonProperty("percent_change_24h")]
        public Double? percent_change_24h { get; set; }
        [JsonProperty("percent_change_7d")]
        public Double? percent_change_7d { get; set; }
        [JsonProperty("last_updated")]
        public string last_updated { get; set; }
        public List<quote> quote { get; set; }

        /*
        "id": "bitcoin", 
        "name": "Bitcoin", 
        "symbol": "BTC", 
        "rank": "1", 
        "price_usd": "6314.64252561", 
        "price_btc": "1.0", 
        "24h_volume_usd": "3881979173.88", 
        "market_cap_usd": "109015590740", 
        "available_supply": "17263937.0", 
        "total_supply": "17263937.0", 
        "max_supply": "21000000.0", 
        "percent_change_1h": "0.09", 
        "percent_change_24h": "0.44", 
        "percent_change_7d": "-9.77", 
        "last_updated": "1536769704"
        */

    }

    public class quote
    {
        [JsonProperty("price")]
        public Double? price { get; set; }
        [JsonProperty("volume_24h")]
        public Double? volume_24h { get; set; }
        
    }

}