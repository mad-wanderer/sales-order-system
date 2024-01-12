using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Domain.Repositories
{
    public interface ICustomerRepository
    {
        public void AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);
        public Customer GetCustomerById(string id);
    }
}
