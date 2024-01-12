using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;

namespace ordering_and_sales_system.Domain.Repositories
{
    public class TransactionHistoryRepository : ITransactionHistoryRepository, IDisposable
    {
        private DatabaseHelper<TransactionHistory> _databaseHelper;
        private readonly string tableName = "transactionhistory";

        public TransactionHistoryRepository()
        {
            _databaseHelper = new DatabaseHelper<TransactionHistory>();
        }

        public void AddTransactionHistory(ITransactionHistory transactionHistory)
        {
            _databaseHelper.InsertRecord(tableName, new TransactionHistory(transactionHistory));
        }

        public TransactionHistory GetTransactionHistoryByID(string transactionId)
        {
            _databaseHelper.SelectRecord(tableName, new TransactionHistory(tr))
        }

        public List<TransactionHistory> GetAllTransactionHistory()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
