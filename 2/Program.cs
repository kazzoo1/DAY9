using System;

namespace EmployeeHours
{
    // Определение перечисления для должностей сотрудников
    enum Position
    {
        Manager = 160,      // Менеджер
        Developer = 160,    // Разработчик
        Designer = 150,     // Дизайнер
        Secretary = 160,    // Секретарь
        Intern = 120        // Стажер
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования перечисления
            Position employeePosition = Position.Developer;

            Console.WriteLine($"Должность: {employeePosition}");
            Console.WriteLine($"Необходимое количество часов в месяц: {(int)employeePosition}");

            // Можно также перебрать все значения перечисления
            Console.WriteLine("\nВсе должности и требуемые часы:");
            foreach (Position position in Enum.GetValues(typeof(Position)))
            {
                Console.WriteLine($"{position} : {(int)position} часов");
            }
        }
    }
}
