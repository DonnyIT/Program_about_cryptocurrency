using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirstProgram.Model;
using TheFirstProgram.View;

namespace TheFirstProgram.ViewModel
{
    public class CurrencyViewModel
    {
        private List<Currency> _Currencies = new List<Currency>();

        public List<Currency> GetAllCurencies()
        {
            return _Currencies;
        }
        
        public void Add(Currency currency)
        {
            _Currencies.Add(currency);   
        }
        
        public void FillModel(List<CryptingUpCurrency> data)
        {
            foreach(CryptingUpCurrency currency in data)
            {
                Add(new Currency(currency));
            }
        }

        public async void LoadData()
        {
            var list = await CryptingUpService.GetAll();
            _Currencies.Clear();
            FillModel(list.GetRange(0, 10));
            CryptingUpTopPage.GetInstance().SetContext(_Currencies);
        }
    }
}
