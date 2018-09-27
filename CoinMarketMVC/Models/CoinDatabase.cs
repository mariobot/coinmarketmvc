using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CoinMarketMVC.DataContracts.Microlink;

namespace CoinMarketMVC.Models
{
    public class CoinDatabase : DbContext
    {
        public CoinDatabase() : base("name=ConnString") { }

        public DbSet<Data> DataMicrolinks { get; set; }
    }
}