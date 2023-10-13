using System.Collections.ObjectModel;

namespace СonstantCustomer
{
    internal class Shop
    {
        public ObservableCollection<Item> product = new();

        public void Add(Item item)
        {
            product.Add(
                new Item(item.Id, item.Name));
        }

        public void Remove(int id) 
        {
            try
            {
                if (product.Count == 0)
                {
                    Console.WriteLine("Нет товаров для удаления");
                }
                else
                {
                    product.RemoveAt(id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Не найден товар с идентификатором {id}", e);
            }
            
        }
    }
}
