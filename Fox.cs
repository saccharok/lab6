using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Fox
    {
        public Fox() { }
        public void Set(string _name, double _weight, int _age, int _number)
        {
            Fox fox = new Fox();
            fox.name = _name;
            fox.weight = _weight;
            fox.age = _age;
            fox.number = _number;
        }
        public void Get(Fox fox)
        {
            string _name;
            double _weight;
            int _age;
            int _number;
            Console.WriteLine("Имя лисы: ");
            _name = Console.ReadLine();
            do
            {
                Console.WriteLine("Вес лисы в кг: ");
                _weight = Convert.ToDouble(Console.ReadLine());
            } while (_weight < 1);
            do
            {
                Console.WriteLine("Возраст лисы: ");
                _age = Convert.ToInt32(Console.ReadLine());
            } while (_age < 0);
            do
            {
                Console.WriteLine("Номер вольера: ");
                _number = Convert.ToInt32(Console.ReadLine());
            } while (_number < 5 || _number > 6);
            fox.name = _name;
            fox.weight = _weight;
            fox.age = _age;
            fox.number = _number;
        }
        public void Print()
        {
            Console.WriteLine($"\nИмя лисы: {name}. Вес лисы в кг: {weight}. Возраст лисы: {age}. Номер вольера: {number}.\n");
        }
        private string name { set; get; }
        private double weight { set; get; }
        private int age { set; get; }
        private int number { set; get; }
    }
}
