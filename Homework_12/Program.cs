namespace СonstantCustomer
{
    class Program
    {
        private static void Main()
        {
            var shop = new Shop();

            shop.product.CollectionChanged += ChangeProduct;
            while (true)
            {
                var key = Console.ReadLine();
                switch (key.ToString())
                {
                    case "A" or "a":
                        var item = new Item(shop.product.Count, $"Товар от {DateTime.Now}");
                        shop.Add(item);
                        break;
                    case "D" or "d":
                        Console.WriteLine("Какой товар нужно удалить? Введите идентификатор:");
                        var id = Console.ReadLine();
                        shop.Remove(Convert.ToInt32(id));
                        break;
                    case "X" or "x":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static void ChangeProduct(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Customer.OnItemChanged(sender, e);
        }
    }
}