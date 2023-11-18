using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork_14_Storage_system
{
    internal class Student
    {
        enum gender { female, male };
        enum major { бухгалтер, менеджер, программист, инженер };

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Major { get; set; }
        public List<string> Subjects { get; set; }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////
        /// </summary>

        List<string> list_male_names = new List<string> { "Иван", "Сергей", "Андрей", "Михаил", "Пётр", "Максим", "Евгений", "Дмитрий", "Леонид", "Игорь", "Олег", "Николай" };
        List<string> list_female_names = new List<string> { "Ирина", "Светлана", "Анна", "Мария", "Полина", "Маргарита", "Евгения", "Диана", "Лида", "Инна", "Ольга", "Нина" };
        List<string> list_male_surnames = new List<string> {"Иванов", "Петров", "Сидоров", "Петухов", "Смирнов", "Семёнов", "Григорьев",
                                                                    "Тарасов", "Терентьев", "Валынкин", "Зернов", "Тетерин", "Марков", "Пухов", "Ларин", "Борисов", "Белов",
                                                                    "Найденов", "Луконин", "Крылов", "Кротов", "Кудряшов", "Соловьёв", "Солодов", "Филиппов", "Цветков", "Чернов"};
        List<string> list_female_surnames = new List<string> { "Попова", "Полякова", "Волкова", "Викторова", "Бобова", "Карандашова", "Краснова", "Степанова", "Быкова",
                                                                   "Балашова", "Егорова", "Дружинина", "Абрамова", "Александрова", "Алексеева", "Воробьёва", "Воронина",
                                                                    "Лебедева", "Ершова", "Медведева", "Прокофьева", "Павлова", "Осипова", "Денисова", "Козлова", "Ковалёва",
                                                                    "Носкова" };

        List<string> subjectsOfAccountants = new List<string>() { "математика", "русский язык", "литература", "бухгалтерия" };
        List<string> subjectsOfProgrammers = new List<string>() { "математика", "русский язык", "литература", "программирование" };
        List<string> subjectsOfMenegments = new List<string>() { "математика", "русский язык", "литература", "менеджмент" };
        List<string> subjectsOfIngeners = new List<string>() { "математика", "русский язык", "литература", "инженеринг" };
        List<string> subjects = new List<string>();

        public Student()
        {
            Random rnd = new Random();
                major m = (major)rnd.Next(4);
                gender g = (gender)rnd.Next(2);
                
                string name;
                string surname;

                switch (m)
                {
                    case major.бухгалтер:
                        subjects = new List<string>(subjectsOfAccountants);
                        break;
                    case major.менеджер:
                        subjects = new List<string>(subjectsOfMenegments);
                        break;
                    case major.программист:
                        subjects = new List<string>(subjectsOfProgrammers);
                        break;
                    case major.инженер:
                        subjects = new List<string>(subjectsOfIngeners);
                        break;
                }

                if (g == gender.female)
                {
                    name = list_female_names[rnd.Next(list_female_names.Count)];
                    surname = list_female_surnames[rnd.Next(list_female_names.Count)];
                }
                else
                {
                    name = list_male_names[rnd.Next(list_male_names.Count)];
                    surname = list_male_surnames[rnd.Next(list_male_surnames.Count)];
                }          

            Name = name + " " + surname;
            Age = rnd.Next(12) + 18;
            Gender = g.ToString();
            Major = m.ToString();
            Subjects = subjects;
    }
        public override string ToString()
        {     
            return Name + " " + Age + " лет " + Major;
        }









    }//c
}//ns
