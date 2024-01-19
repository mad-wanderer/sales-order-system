﻿namespace ordering_and_sales_system.Domain.Entities
{
    public interface ICustomer
    {
        public string? CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}
