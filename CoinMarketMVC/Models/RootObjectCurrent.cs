using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinMarketMVC.Models
{
    public class RootObjectCurrent
    {
        public Status status { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public T T { get; set; }
    }

    public class Urls
    {
        public List<string> website { get; set; }
        public List<string> twitter { get; set; }
        public List<string> reddit { get; set; }
        public List<string> message_board { get; set; }
        public List<string> announcement { get; set; }
        public List<string> chat { get; set; }
        public List<string> explorer { get; set; }
        public List<string> source_code { get; set; }
    }

    public class T
    {
        public Urls urls { get; set; }
        public string logo { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public DateTime date_added { get; set; }
        public List<string> tags { get; set; }
        public string category { get; set; }
    }

    
   
}