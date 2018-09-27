using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoinMarketMVC.DataContracts.Microlink
{


    public class Microlink
    {
        public string status { get; set; }
        public Data data { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string type { get; set; }
        public int size { get; set; }
        public string size_pretty { get; set; }
    }

    public class Data
    {
        public object author { get; set; }
        public string title { get; set; }
        public string publisher { get; set; }
        public Image image { get; set; }
        public string description { get; set; }
        [Key]
        public string url { get; set; }
    }
}