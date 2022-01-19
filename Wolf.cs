using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    public class Wolf
    {
        public Wolf() { }
        public void Set (string _name, int _age, int _number)
        {
            Wolf wolf1 = new Wolf();
            wolf1.name = _name;
            wolf1.age = _age;
            wolf1.number = _number;
        }
        public void Get (Wolf wolf) 
        {
            string _name;
            int _age;
            int _number;
            Console.WriteLine("Имя волка: ");
            _name = Console.ReadLine();
            do
            {
                Console.WriteLine("Возраст волка: ");
                _age = Convert.ToInt32(Console.ReadLine());
            } while (_age < 0);
            do
            {
                Console.WriteLine("Номер вольера: ");
                _number = Convert.ToInt32(Console.ReadLine());
            } while (_number < 1 || _number > 3);            
            wolf.name = _name;
            wolf.age = _age;
            wolf.number = _number;
        }
        public void Print ()
        {
            Console.WriteLine($"\nВолк. Имя: {name}. Возраст: {age}. Номер вольера: {number}.\n");
        }
        ~Wolf() { }
        private string name { get; set; }
        private int age { get; set; }
        private int number { get; set; }
    }
}
