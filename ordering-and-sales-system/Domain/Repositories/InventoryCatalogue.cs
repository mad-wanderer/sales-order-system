using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;
using System.Data;

namespace ordering_and_sales_system.Domain.Repositories
{
    public class InventoryCatalogue : IInventoryCatalogueRepository, IDisposable
    {
        private DatabaseHelper<InventoryCatalogue> _databaseHelper;
        private readonly string tableName = "inventory catalogue";

        public InventoryCatalogueRepository()
        {
            _databaseHelper = new DatabaseHelper<InventoryCatalogue>();
        }

        public void Add(InventoryCatalogue inventoryCatalogue) 
        {
            _databaseHelper.InsertRecord(tableName, new InventoryCatalogue(inventoryCatalogue));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remove(InventoryCatalogue inventoryCatalogue)
        {
            throw new NotImplementedException();
        }

        public void Update(InventoryCatalogue inventoryCatalogue)
        {
            throw new NotImplementedException();
        }

        public InventoryCatalogue Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
