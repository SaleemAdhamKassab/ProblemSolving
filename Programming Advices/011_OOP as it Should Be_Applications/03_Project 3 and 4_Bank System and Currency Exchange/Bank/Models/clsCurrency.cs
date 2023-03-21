namespace Lab.Bank.Models
{
    public class clsCurrency
    {
        public clsCurrency(string country, string code, string name, double exchangeRateUSD)
        {
            Country = country;
            Code = code;
            Name = name;
            ExchangeRateUSD = exchangeRateUSD;
        }
        public string Country { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double ExchangeRateUSD { get; set; }
    }
}