using System;
using System.Collections;
using System.Collections.Generic;

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
DynamicList<T> на языке C#*/

namespace NinthTask
{
    public class DynamicList<T> : IEnumerable<T>
    {

       
        public int Count { get; set; }
        private T[] Items { get; set; }
        private const int Capacity = 9;


        public DynamicList()
        {
            Items = new T[Capacity];
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < Count; i++)
            {
                yield return Items[i];
            }
        }

        public void Add(T element)
        {
            Resize();
            Items[Count++] = element;
        }

        public void RemoveAt(int index)
        {
            var newContainer = new T[Items.Length - 1];
            Array.Copy(Items, newContainer, index);
            Array.Copy(Items, index + 1, newContainer, index, Items.Length - index - 1);
            Items = newContainer;
            Count--;
        }

        public void Remove(T element)
        {
            RemoveAt(Array.IndexOf(Items, element));
        }
        private void Resize()
        {
            if (Count != Items.Length)
            {
                return;
            }

            T[] newContainer = new T[Items.Length + Capacity];
            Array.Copy(Items, newContainer, Items.Length);
            Items = newContainer;
        }

        public void Clear()
        {
            Items = Array.Empty<T>();
            Count = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()//метод спрятанный от внешнего пользователя
        {
            return GetEnumerator();
        }
    }
}