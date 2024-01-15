using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;

namespace ordering_and_sales_system.Domain.Repositories
{
    public class PendingOrdersRepository
    {
        private DatabaseHelper<TransactionHistory> _databaseHelper;
        private readonly string tableName = "pendingorders";
    }
}
