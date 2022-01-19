using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Bear
    {
        public Bear() { }
        public void Set(string _name, double _weight, double _high)
        {
            Bear bear = new Bear();
            bear.name = _name;
            bear.weight = _weight;
            bear.high = _high;
            bear.number = 8;
        }
        public void Get(Bear bear)
        {
            string _name;
            double _weight;
            double _high;
            Console.WriteLine("Имя медведя: ");
            _name = Console.ReadLine();
            do
            {
                Console.WriteLine("Вес медведя в кг: ");
                _weight = Convert.ToDouble(Console.ReadLine());
            } while (_weight < 1);
            do
            {
                Console.WriteLine("Рост медведя в см: ");
                _high = Convert.ToDouble(Console.ReadLine());
            } while (_high < 10);
            bear.name = _name;
            bear.weight = _weight;
            bear.high = _high;
            bear.number = 8;
        }
        public void Print ()
        {
            Console.WriteLine($"\nИмя медведя: {name}. Вес медведя в кг: {weight}. Рост медведя в см: {high}. Номер вольера: {number}\n");
        }
        private string name { set; get; }
        private double weight { set; get; }
        private double high { set; get; }
        private int number { set; get; }
    }
}
