using ordering_and_sales_system.Domain.Entities;
namespace ordering_and_sales_system.Domain.Repositories
{
    public interface IInventoryCatalogueRepository
    {
        public void Add(InventoryCatalogue inventoryCatalogue);
        public void Remove(InventoryCatalogue inventoryCatalogue);
        public void Update(InventoryCatalogue inventoryCatalogue);
        public InventoryCatalogue Get(int id);
    }
}
