using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirstProgram.ViewModel;

namespace TheFirstProgram.Model
{
    public static class CryptingUpService
    {
        public static async Task<List<CryptingUpCurrency>> GetAll()
        {
            var result = await HttpWorker.GET("https://cryptingup.com/api/assets");
            return CryptingUpCurrency.CreateFromJson(result);
        }
    }
}
