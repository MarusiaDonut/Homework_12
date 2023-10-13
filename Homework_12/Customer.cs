using System.Collections.Specialized;

namespace СonstantCustomer
{
    internal class Customer
    {
        public static void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
           
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Item listNew = (Item)e.NewItems[0];
                    Console.WriteLine($"Добавлен {listNew.Name} с идентификатором {listNew.Id}");
                    break; 
                case NotifyCollectionChangedAction.Remove:
                    Item listOld = (Item)e.OldItems[0];
                    Console.WriteLine($"Удален товар {listOld.Name} с идентификатором {listOld.Id}");
                    break;
            }
        }
    }
}
