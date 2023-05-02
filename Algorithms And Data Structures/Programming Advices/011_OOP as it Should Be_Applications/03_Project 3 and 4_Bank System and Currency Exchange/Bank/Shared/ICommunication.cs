namespace Lab.Bank.Shared
{
    internal interface ICommunication
    {
        public abstract void sendEmail(string title, string body);
        public abstract void sendFax(string title, string body);
        public abstract void sendSms(string title, string body);
    }
}