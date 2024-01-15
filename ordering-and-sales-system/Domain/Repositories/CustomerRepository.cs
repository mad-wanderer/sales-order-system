using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;
using System.Data;

namespace ordering_and_sales_system.Domain.Repositories
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private DatabaseHelper<Customer> _databaseHelper;
        private readonly string tableName = "customer";

        public CustomerRepository() 
        {
            _databaseHelper = new DatabaseHelper<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            _databaseHelper.InsertRecord(tableName, new Customer(customer));
        }

        /*public void DeleteCustomer(Customer customer)
        {
            _databaseHelper.Delete(tableName, new Customer(customer));
        }*/

        public void Dispose()
        {
            _databaseHelper.Dispose();
        }

        public Customer GetCustomerByID(string id)
        {
            string constraints = "CustomerID = " + id;
            DataTable dataTable = _databaseHelper.SelectRecord(this.tableName, constraints);
        }

        public void UpdateCustomer(Customer customer)
        {
            _databaseHelper.UpdateRecord(tableName, new Customer(customer));
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
