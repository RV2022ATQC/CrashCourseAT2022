namespace _301
{
    public class Shop
    {
        public Shop() { items = null; }

        public Shop(List<Item> items)
        {
            this.items = new List<Item>(items);
        }

        private List<Item> items;
        public List<Item> Items
        {
            get { return items; }
            set { items = new List<Item>(value); }
        }
        
        public void Add(Item item)
        {
            if (Items.Any(el => (el.Name == item.Name)&&(el.Creator == item.Creator)))
            {
                var el = items.FindIndex(el => (el.Name == item.Name) && (el.Creator == item.Creator));
                Items[el].Quantity++;
            }
            else
                items.Add(item);
        }

        public void Buy(string name)
        {
            var el = items.FindIndex(el => el.Name == name);
            if (items[el].Quantity > 1)
                items[el].Quantity--;
            else
                items.RemoveAt(el);
        }
    }
}
