// 301
// Написати клас Товар. Також реалізувати клас магазин. Передбачити можливість отримання товару на баланс і продажу товару.
//using System;

namespace Task_301
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Description
            //1. Написати клас Товар - Goods
            // Поля: name, quantity, price
            // Методи: 

            //2. Реалізувати клас Магазин - Shop
            // Колекція товарів (List)
            // Методи: ShowItems(), AddItem(), SellItem()

            //3. Main
            // Наповнити колекцію товарів
            // Додати товар
            // Продати товар
            // Показати товари
            #endregion


            Shop shop = new Shop();

            shop.AddItem("Cup", 40, 20);
            shop.AddItem("Knife", 65, 10);
            shop.AddItem("Plate", 30, 50);
            shop.AddItem("Deep plate", 50, 20);
            shop.AddItem("Coffee Cup", 45, 50);
            shop.AddItem("Spoon", 15, 100);
            shop.AddItem("Fork", 15, 100);
            shop.AddItem("Tea spoon", 10, 200);
            shop.ShowItems();

            shop.SellItem("Knife", 6);

            shop.ShowItems();

            shop.AddItem("Tea spoon", 100, 100);
            shop.AddItem("Tea spoon", 100, 100);
            shop.AddItem("Tea spoon", 100, 100);
            shop.AddItem("Napkin", 2, 1000);

            shop.ShowItems();
        }
    }
}
