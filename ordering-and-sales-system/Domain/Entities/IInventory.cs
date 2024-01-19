namespace ordering_and_sales_system.Domain.Entities
{
    public interface IInventory
    {
        public string? ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Category { get; set; }
        public string? Quantity { get; set; }
        public string? Price { get; set; }
        public string? ProductCost { get; set; }
        public string? Status { get; set; }
    }
}
