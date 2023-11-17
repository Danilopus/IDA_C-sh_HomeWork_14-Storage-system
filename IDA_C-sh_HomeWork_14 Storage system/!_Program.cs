// HomeWork template 1.4 // date: 17.10.2023

using IDA_C_sh_HomeWork_14_Storage_system;
using Service;
using System;
using System.Linq.Expressions;
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
        /* Задание */
        { Console.WriteLine("\n***\t{0}\n\n", work_name);
        
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
        /* Задание */
        { Console.WriteLine("\n***\t{0}\n\n", work_name); }


    }// class Program
}// namespace