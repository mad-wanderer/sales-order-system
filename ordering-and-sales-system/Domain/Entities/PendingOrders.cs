namespace ordering_and_sales_system.Domain.Entities
{
    public class PendingOrders : IPendingOrders
    {
        public PendingOrders() { }

        public PendingOrders (string? orderID, string? productID, string? customerID, string? productName, string? color, string? quantity, string? price, string? transactionDate, string? status, string? total)
        {
            OrderID = orderID;
            ProductID = productID;
            CustomerID = customerID;
            ProductName = productName;
            Color = color;
            Quantity = quantity;
            Price = price;
            TransactionDate = transactionDate;
            Status = status;
            Total = total;
        }
        public PendingOrders(IPendingOrders PendingOrders)
        {
            OrderID = PendingOrders.OrderID;
            ProductID = PendingOrders.ProductID;
            CustomerID = PendingOrders.CustomerID;
            ProductName = PendingOrders.ProductName;
            Color = PendingOrders.Color;
            Quantity = PendingOrders.Quantity;
            Price = PendingOrders.Price;
            TransactionDate = PendingOrders.TransactionDate;
            Status = PendingOrders.Status;
            Total = PendingOrders.Total;
        }
       

        public string? Order_ID { get; set; }
        public string? Product_ID { get; set; }
        public string? Customer_ID { get; set; }
        public string? Product_Name { get; set; }
        public string? Color { get; set; }
        public string? Quantity { get; set; }
        public string? Price { get; set; }
        public string? Transaction_Date { get; set; }
        public string? Status { get; set; }
    }
}
