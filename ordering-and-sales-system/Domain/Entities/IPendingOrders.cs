namespace ordering_and_sales_system.Domain.Entities
{
    public interface IPendingOrders
    {
        public string? OrderID { get; set; }
        public string? ProductID { get; set; }
        public string? CustomerID { get; set; }
        public string? ProductName { get; set; }
        public string? Color { get; set; }
        public string? Quantity { get; set; }
        public string? Price { get; set; }
        public string? TransactionDate { get; set; }
        public string? Status { get; set; }
        public string? Total { get; set; }
    }
}
