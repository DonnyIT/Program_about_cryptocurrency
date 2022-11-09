using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirstProgram.Model
{
    public class Currency
    {
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }
        public decimal Change1h { get; set; }
        public decimal Change1d { get; set; }       
        public decimal Change7d { get; set; }
        public string Status { get; set; }

        public Currency() { } 

        public Currency(CryptingUpCurrency cur)
        {
            Name = cur.name;
            CurrencyCode = cur.asset_id;
            Price = cur.price;
            Volume = cur.volume_24h;
            Change1h = cur.change_1h;
            Change1d = cur.change_24h;
            Change7d = cur.change_7d;
            Status = cur.status;
        }            
    }
}
