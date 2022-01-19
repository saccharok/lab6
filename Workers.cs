using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Workers
    {
        public Workers() { }
        public void Set (Name _name, int _code, int _number, int _payroll)
        {
            Workers worker = new Workers();
            worker.name = _name;
            worker.code = _code;
            worker.number = _number;
            worker.payroll = _payroll;
        }
        public void Get (Name _name, Workers worker)
        {
            int _code;
            do
            {
                Console.WriteLine("Код сотрудника: ");
                _code = Convert.ToInt32(Console.ReadLine());
            } while (_code < 100000 || _code > 999999);
            int _number;
            do
            {
                Console.WriteLine("Номер вольера: ");
                _number = Convert.ToInt32(Console.ReadLine());
            } while (_number < 1 || _number > 7);
            int _payroll;
            do
            {
                Console.WriteLine("Заработная плата: ");
                _payroll = Convert.ToInt32(Console.ReadLine());
            } while (_payroll <= 8000);
            worker.name = _name;
            worker.code = _code;
            worker.number = _number;
            worker.payroll = _payroll;
        }
        public void Print ()
        {
            name.Print();
            Console.WriteLine($"Код сотрудника: {code}. Номер вольера: {number}. Заработная плата: {payroll}\n");
        }
        ~Workers() { }
        public class Name
        {
            public Name() { }
            public void Set(string _lastName, string _name, string _patronymic)
            {
                Name name = new Name();
                name.lastName = _lastName;
                name.name = _name;
                name.patronymic = _patronymic;
            }
            public void Get(Name name)
            {
                string _lastName;
                string _name;
                string _patronymic;
                Console.WriteLine("Фамилия: ");
                _lastName = Console.ReadLine();
                Console.WriteLine("Имя: ");
                _name = Console.ReadLine();
                Console.WriteLine("Отчество: ");
                _patronymic = Console.ReadLine();
                name.lastName = _lastName;
                name.name = _name;
                name.patronymic = _patronymic;
            }
            public void Print()
            {
                Console.WriteLine($"\nФамилия: {lastName}. Имя: {name}. Отчество: {patronymic}.\n");
            }
            ~Name() { }
            private string lastName { set; get; }
            private string name { set; get; }
            private string patronymic { set; get; }
        }
        private Name name { set; get; }
        private int code { set; get; }
        private int number { set; get; }
        private int payroll { set; get; }
    }
}
