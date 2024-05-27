using System;

namespace StudentApp
{
    struct STUDENT
    {
        public string FullName; // Фамилия и инициалы
        public int GroupNumber; // Номер группы
        public int[] Grades; // Успеваемость

        // Конструктор структуры STUDENT
        public STUDENT(string fullName, int groupNumber, int[] grades)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
            Grades = grades;
        }

        // Метод для вывода информации о студенте
        public void DisplayInfo()
        {
            Console.WriteLine($"{FullName}, группа {GroupNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            STUDENT[] students = new STUDENT[10];
            Console.WriteLine("Введите информацию о студентах:");

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Студент {i + 1} - Фамилия и инициалы: ");
                string fullName = Console.ReadLine();
                Console.Write("Номер группы: ");
                int groupNumber = int.Parse(Console.ReadLine());
                Console.Write("Успеваемость (5 оценок через пробел): ");
                int[] grades = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                students[i] = new STUDENT(fullName, groupNumber, grades);
            }

            // Сортировка массива студентов по фамилии
            Array.Sort(students, (s1, s2) => string.Compare(s1.FullName, s2.FullName));

            // Поиск и вывод студентов с оценкой 2
            bool found = false;
            foreach (STUDENT student in students)
            {
                if (Array.Exists(student.Grades, grade => grade == 2))
                {
                    student.DisplayInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Студенты с оценкой '2' не найдены.");
            }
        }
    }
}
