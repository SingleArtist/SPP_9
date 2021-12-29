using System;

//Задание 9
/*Создать на языке C# обобщенный (generic-) класс DynamicList<T>,
который:
-реализует динамический массив с помощью обычного массива
T[];
-имеет свойство Count, показывающее количество элементов;
-имеет свойство Items для доступа к элементам по индексу;
-имеет методы Add, Remove, RemoveAt, Clear для соответственно
добавления, удаления, удаления по индексу и удаления всех
элементов;
-реализует интерфейс IEnumerable<T>.
Реализовать простейший пример использования класса
DynamicList<T> на языке C#.
*/

namespace NinthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList<int> list = new DynamicList<int>();

            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }

            Console.Write("{");
            foreach (int element in list)
            {
                Console.Write(element + ",");
            }
            Console.Write("}\n");
            Console.WriteLine(list.Count);

            list.Remove(1);
            Console.Write("{");
            foreach (int element in list)
            {
                Console.Write(element + ",");
            }
            Console.Write("}\n");
            Console.WriteLine(list.Count);

            list.Clear();

            Console.Write("{");
            foreach (int element in list)
            {
                Console.Write(element + ",");
            }
            Console.Write("}\n");
            Console.WriteLine(list.Count);
        }
    }
}