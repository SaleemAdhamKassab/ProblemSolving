using Lab.Bank.Db;
using Lab.Bank.Models;
using Lab.Classes;

namespace Lab.Bank.Controllers
{
    internal class CurrenciesController : FileDbContext
    {
        static clsCurrency _getEmptyCurrencyObject() => new clsCurrency("", "", "", 0);
        public List<Object> Get() => convertFileDataToList(currenciesDbConnectionString, fileRowSeparator, enConvertLineToObjetTypes.Currency);
        public clsCurrency Get(string userChoose)
        {
            List<object> curriences = Get();

            foreach (clsCurrency currency in curriences)
            {
                if (SaleemString.ToLower(currency.Code) == SaleemString.ToLower(userChoose) || SaleemString.ToLower(currency.Country) == SaleemString.ToLower(userChoose))
                    return currency;
            }
            return _getEmptyCurrencyObject();
        }
        public bool IsCurrencyExsist(string code) => Get(code).Code == "" ? false : true;
        public void Update(string code, double newRate)
        {
            List<object> currenciesList = Get();
            List<object> currenciesListAfterUpdateCurrency = new List<object>();

            foreach (clsCurrency currency in currenciesList)
            {
                if (SaleemString.ToLower(currency.Code) == SaleemString.ToLower(code))
                    currency.ExchangeRateUSD = newRate;

                currenciesListAfterUpdateCurrency.Add(currency);
            }
            saveListToFile(currenciesListAfterUpdateCurrency, currenciesDbConnectionString, false);
        }
        public double currencyCalculater(string currency1Code, string currency2Code, double amountToExchange) =>(amountToExchange / Get(currency1Code).ExchangeRateUSD) * Get(currency2Code).ExchangeRateUSD;
    }
}
