namespace ordering_and_sales_system.Domain.Entities
{
    public class InventoryCatalogue : IInventoryCatalogue
    {
        public InventoryCatalogue() { }

        public InventoryCatalogue(string? productID, string? productName, string? category, string? quantity, string? price, string? productCost, string? status)
        {
            ProductID = productID;
            ProductName = productName;
            Category = category;
            Quantity = quantity;
            Price = price;
            ProductCost = productCost;
            Status = status;
        }

        public InventoryCatalogue(IInventoryCatalogue inventoryCatalogue)
        {
            ProductID = inventoryCatalogue.ProductID;
            ProductName = inventoryCatalogue.ProductName;
            Category = inventoryCatalogue.Category;
            Quantity = inventoryCatalogue.Quantity;
            Price = inventoryCatalogue.Price;
            ProductCost = inventoryCatalogue.ProductCost;
            Status = inventoryCatalogue.Status;
        }

        public string? ProductID { get; set; }
        public string? ProductName { get; set; } 
        public string? Category { get; set; }
        public string? Quantity { get; set; }
        public string? Price { get; set; }
        public string? ProductCost { get; set; }
        public string? Status { get; set; }
    }
}
