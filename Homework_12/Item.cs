namespace СonstantCustomer
{
    internal class Item
    {
        public Item(int _id, string _name) 
        {
            Id = _id;
            Name = _name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
