using _301;

//Написати клас Товар. Також реалізувати клас магазин. 
//Передбачити можливість отримання товару на баланс і продажу товару.

class Program
{
    public static void Main(string[] args)
    {
        List<Item> items = new List<Item>();
        items.Add(new Item("name1", 123.6, "Creator1", 5));
        items.Add(new Item("name2", 190, "Creator2", 1));
        Shop shop = new Shop(items);

        foreach(Item item in shop.Items)
        {
            Console.WriteLine(item);
        }

        shop.Buy("name1");
        shop.Buy("name2");

        Console.WriteLine("---------------------------------------------------------------------------");

        foreach (Item item in shop.Items)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------------------------------------------------------------------");

        shop.Add(new Item("name2", 190, "Creator2", 1));
        shop.Add(new Item("name1", 123.6, "Creator1", 5));
        shop.Add(new Item("name1", 123.6, "Creator3", 5));
        
        foreach (Item item in shop.Items)
        {
            Console.WriteLine(item);
        }
    }
}