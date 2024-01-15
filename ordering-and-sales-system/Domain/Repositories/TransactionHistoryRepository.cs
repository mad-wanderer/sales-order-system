using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;
using System.Data;

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

        public DatabaseHelper<TransactionHistory> Get_databaseHelper()
        {
            return _databaseHelper;
        }

        public TransactionHistory GetTransactionHistoryByID(string transactionId)
        {
            string constraints = "ProductID = " + ProductID;
            DataTable dataTable = databaseHelper.SelectAllRecordWith(tableName, constraints);
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
