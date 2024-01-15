using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Domain.Repositories
{
    public interface IPendingOrdersRepository
    {
        public void GetAllPendingOrdersAsync(PendingOrders pendingorder);
        public void GetPendingOrdersAsync();
        public void UpdatePendingOrdersAsync();
        public void DeletePendingOrdersAsync();
        public void AddPendingOrderAsync();
        public void RemovePendingOrderAsync();
        public void GetPendingOrderByIdAsync(string orderId);
    }
}
