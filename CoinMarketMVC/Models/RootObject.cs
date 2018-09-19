using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinMarketMVC.Models
{
    public class USD
    {
        public double price { get; set; }
        public long volume_24h { get; set; }
        public double percent_change_1h { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_7d { get; set; }
        public long market_cap { get; set; }
        public DateTime last_updated { get; set; }
    }

    public class BTC
    {
        public int price { get; set; }
        public int volume_24h { get; set; }
        public int percent_change_1h { get; set; }
        public int percent_change_24h { get; set; }
        public int percent_change_7d { get; set; }
        public int market_cap { get; set; }
        public DateTime last_updated { get; set; }
    }

    public class Quote
    {
        public USD USD { get; set; }
        public BTC BTC { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public int? cmc_rank { get; set; }
        public int? num_market_pairs { get; set; }
        public Int64? circulating_supply { get; set; }
        public Int64? total_supply { get; set; }
        public Int64? max_supply { get; set; }
        public DateTime last_updated { get; set; }
        public DateTime date_added { get; set; }
        public Quote quote { get; set; }
    }

    public class Status
    {
        public DateTime timestamp { get; set; }
        public int error_code { get; set; }
        public string error_message { get; set; }
        public int elapsed { get; set; }
        public int credit_count { get; set; }
    }

    public class RootObject
    {
        public List<Datum> data { get; set; }
        public Status status { get; set; }
    }
}