// HomeWork template 1.4 // date: 17.10.2023

using IDA_C_sh_HomeWork_14_Storage_system;
using Service;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

/// QUESTIONS ///
/// 1. 

// HomeWork 14 : [{Storage system}] --------------------------------

namespace IDA_C_sh_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainMenu.MainMenu mainMenu = new MainMenu.MainMenu();

            do
            {
                Console.Clear();
                mainMenu.Show_menu();
                if (mainMenu.User_Choice_Handle() == 0) break;
                Console.ReadKey();
            } while (true);
            // Console.ReadKey();
        }

        public static void Task_1(string work_name)
        /* Задание 1: Система хранения данных
        Вам необходимо разработать простую систему хранения данных, которая позволит хранить и обрабатывать различные типы данных. В рамках данной системы будет использоваться обобщенные типы для достижения гибкости и повторного использования кода.

        Описание задания
        Создайте обобщенный класс DataStorage<T>, который будет представлять систему хранения данных. В этом классе должны быть следующие методы:

        void AddData(T data): метод для добавления данных в систему.
        void RemoveData(T data): метод для удаления данных из системы.
        bool ContainsData(T data): метод для проверки наличия данных в системе.
        void PrintData(): метод для печати всех данных в системе.
        Реализуйте классы Person и Product, которые представляют сущности для хранения. Классы должны иметь свойства и конструкторы по умолчанию. Например:
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
        Создайте несколько экземпляров классов Person и Product.

        Создайте экземпляр класса DataStorage<T>, где T - это тип данных, который вы хотите хранить.

        Добавьте созданные экземпляры в систему хранения данных при помощи метода AddData().

        Проверьте наличие данных в системе при помощи метода ContainsData().

        Удалите некоторые данные из системы при помощи метода RemoveData().

        Напечатайте все данные в системе при помощи метода PrintData(). */
        {
            Console.WriteLine("\n***\t{0}\n\n", work_name);
        
        Person person_1 = new Person();
            person_1.Name = "Vasya";
        Person person_2 = new Person();
            person_2.Name = "Petr";

        Product product_1 = new Product();
            product_1.Name = "auto";
        Product product_2 = new Product();
            product_2.Name = "moto";

            // Вот такое  решение, шоб хранить в данном списке любые ссылочные типы
            DataStorage<Object> dataStorage = new DataStorage<Object>();

            dataStorage.AddData(product_1);
            dataStorage.AddData(person_1);
            dataStorage.AddData(product_2);
            dataStorage.AddData(person_2);

            Console.WriteLine("Список имен хранимых объектов в DataStorage");
            dataStorage.PrintData();

            Console.WriteLine("\nПроверка есть ли в списке объект person_1");
            Console.WriteLine(dataStorage.ContainsData(person_1));
            Console.WriteLine("\nПроверка есть ли в списке объект product_1");
            Console.WriteLine(dataStorage.ContainsData(product_1));

            Console.WriteLine("\nСписок имен хранимых объектов в DataStorage после удаления person_1");
            dataStorage.RemoveData(person_1);
            dataStorage.PrintData();

        }
        public static void Task_2(string work_name)
        /* Задание 2:
        У тебя есть список студентов. Каждый студент представлен объектом класса Student, содержащего следующие свойства:

        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string Major { get; set; }
            public List<string> Subjects { get; set; }
        }
        Твоя задача:

        Создать список студентов, содержащий не менее 10 элементов.
        Найти и вывести на экран всех студентов мужского пола.
        Найти и вывести на экран всех студентов, чья возрастная категория попадает в диапазон от 20 до 25 лет.
        Найти и вывести на экран количество студентов по каждой специальности (Major).
        Найти и вывести на экран все уникальные предметы, которые изучают студенты.
        Найти и вывести на экран студента с наибольшим количеством изучаемых предметов.
        Требования:

        Используй LINQ-запросы или методы расширений LINQ для решения каждой подзадачи.
        Не забудь добавить пример заполнения списка студентов для проверки решения. */
        {
            Console.WriteLine("\n***\t{0}\n\n", work_name);

            List<Student> students_list = new List<Student>();
            for (int i = 0; i < 10; i++) students_list.Add(new Student());

            Console.WriteLine("\n*** " + "Найти и вывести на экран всех студентов мужского пола" + ":");
            foreach (var item in students_list.Where(s => s.Gender == "male"))
                Console.WriteLine(item);

            Console.WriteLine("\n*** " + "Найти и вывести на экран всех студентов, чья возрастная категория попадает в диапазон от 20 до 25 лет" + ":");
            foreach (var item in students_list.Where(s => (s.Age < 25 && s.Age > 20)))
                Console.WriteLine(item);

            Console.WriteLine("\n*** " + "Найти и вывести на экран количество студентов по каждой специальности (Major)" + ":");
            foreach (var item in students_list.OrderBy(s => s.Major).GroupBy(s => s.Major))
            {
                Console.Write($"{item.Key}: {item.Count()}\t");
                foreach (var student in item)
                    Console.Write(student.Name + " | ");
                Console.WriteLine("\b\b ");
            }
            /*  var groupsByAge = from ageGroup in students_list
                                orderby ageGroup.Age
                                group ageGroup by ageGroup.Age;*/

            Console.WriteLine("\n*** " + "Найти и вывести на экран все уникальные предметы, которые изучают студенты" + ":");
            
            var hz = (students_list.GroupBy(s => s.Subjects)).GroupBy(s => s);

            //foreach (var item in (students_list.GroupBy(s => s.Subjects)).GroupBy(s => s)
            foreach (var item in hz)
            {
                Console.WriteLine(item.Key.Key.Count());
                //Console.Write($"{item.Key.Count}: {item.Count()}\t");

            }

            Console.WriteLine("\n*** " + "Найти и вывести на экран студента с наибольшим количеством изучаемых предметов" + ":");
            foreach (var item in students_list.Where(s => s.Subjects.Count == students_list.Max(s => s.Subjects.Count())))            
                Console.WriteLine(item);
            
        }










    }// class Program
}// namespace