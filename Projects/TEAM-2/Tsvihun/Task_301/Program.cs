// 301
// Написати клас Товар. Також реалізувати клас магазин. Передбачити можливість отримання товару на баланс і продажу товару.
using System;

namespace Task_301
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making Task 301...");
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

            Shop shop = new Shop();

            shop.AddItem("Cup", 40, 20);
            shop.AddItem("Knife", 65, 10);
            shop.ShowItems();


        }
    }
}
