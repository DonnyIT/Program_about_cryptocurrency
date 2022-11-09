using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirstProgram.Model
{
    public class CryptingUpJsonRoot
    {
        public List<CryptingUpCurrency> assets { get; set; }       
    }

    public class CryptingUpCurrency
    {
        public string asset_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string website { get; set; }
        public string pegged { get; set; }
        public decimal price { get; set; }
        public decimal volume_24h { get; set; }
        public decimal change_1h { get; set; }
        public decimal change_24h { get; set; }
        public decimal change_7d { get; set; }
        public decimal total_supply { get; set; }
        public decimal circulating_supply { get; set; }
        public long max_supply { get; set; }
        public decimal market_cap { get; set; }
        public decimal fully_diluted_market_cap { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public static List<CryptingUpCurrency> CreateFromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<CryptingUpJsonRoot>(json);

            if (obj == null)
                return new List<CryptingUpCurrency>();

            return obj.assets;
        }
    }

  
}
