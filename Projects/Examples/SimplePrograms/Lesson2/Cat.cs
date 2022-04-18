﻿using System;

namespace Lesson2
{
    // клас Cat наслідується від батьківсього класу Animal - принцип ООП наслідування.
    // Клас нащадок успадковує від батьківського класу усі (protected + public) поля і методи.
    public class Cat : Animal
    {
        public string voise;

        //конструктор без параметрів
        public Cat()
        {
            SetAge();
            CatsAmount++;
            Animal.IncreaseCountOfAnimals();
        }

        private static int CatsAmount { get; set; }

        //конструктор з параметрами  можемо викликати будь з яких оголошених конструкторів
        public Cat(int age, int speed, int weight)
        {
            //передаємо параметри у батьківський конструктор через ключове слово base
            base.age = age;
            base.speed = speed;
            base.weight = weight;

            this.voise = "Meow!";
            //виклик статичного методу, що належить класу Animals
            Animal.IncreaseCountOfAnimals();

            CatsAmount++;
        }

        //переписали (override) метод move в нащадку 
        //тобто змінили поведінку нащадка - принцип поліморфізму
        public override int Move(int a, int b)
        {
            Console.WriteLine("Call overriden method move() from the Cats class");
            return base.Move(a, b) * 2;
        }

        public string move(int a)
        {
            Console.WriteLine("Call overriden method move() from the Cats class");
            return "move method";
        }
    }
}
