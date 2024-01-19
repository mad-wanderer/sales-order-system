namespace ordering_and_sales_system.Domain.Entities
{
    public class Inventory
    {
        private string v1;
        private string v2;
        private string v3;
        private int v4;
        private int v5;
        private int v6;

        public Inventory() { }

        public Inventory(string? productID, string? productName, string? category, string? quantity, string? price, string? productCost, string? status)
        {
            ProductID = productID;
            ProductName = productName;
            Category = category;
            Quantity = quantity;
            Price = price;
            ProductCost = productCost;
            Status = status;
        }

        public Inventory(Inventory inventory)
        {
            ProductID = inventory.ProductID;
            ProductName = inventory.ProductName;
            Category = inventory.Category;
            Quantity = inventory.Quantity;
            Price = inventory.Price;
            ProductCost = inventory.ProductCost;
            Status = inventory.Status;
        }

        public Inventory(string v1, string v2, string v3, int v4, int v5, int v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
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

