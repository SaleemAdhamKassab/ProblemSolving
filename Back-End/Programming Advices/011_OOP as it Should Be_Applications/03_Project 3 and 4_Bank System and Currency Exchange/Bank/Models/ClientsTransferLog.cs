namespace Lab.Bank.Models
{
    public class ClientsTransferLog
    {
        public ClientsTransferLog(string transferDate,
                                  string accountNumber,
                                  string toAccountNumber,
                                  int transferAmount,
                                  int accountBalanceAfterTransfer,
                                  int destinationBalanceAfterTransfer,
                                  string name)
        {
            TransferDate = transferDate;
            AccountNumber = accountNumber;
            ToAccountNumber = toAccountNumber;
            TransferAmount = transferAmount;
            AccountBalanceAfterTransfer = accountBalanceAfterTransfer;
            DestinationBalanceAfterTransfer = destinationBalanceAfterTransfer;
            Name = name;
        }
        public string TransferDate { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string ToAccountNumber { get; set; }
        public int TransferAmount { get; set; }
        public int AccountBalanceAfterTransfer { get; set; }
        public int DestinationBalanceAfterTransfer { get; set; }
    }
}