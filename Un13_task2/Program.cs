using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Un13_task2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string book = File.ReadAllText(@"C:\Users\udav\Desktop\cdev_Text.txt"); //Считываем текст в строку
            char[] chars = new char[] { ' ', '\n', '\r', '.', ',', '-', '-' };

            string[] words = book.Split(chars, StringSplitOptions.RemoveEmptyEntries); //Разделяем на массив строк


            var selectedWords = words.GroupBy(x => x).             //Группируем объекты
                                OrderByDescending(x => x.Count()).  //Сортируем по убыванию по колличеству в группе
                                Take(10).                           //берем первых 10 обектов 
                                ToList();                           //Помещаем в коллекцию

            foreach (var word in selectedWords)
            {

                Console.WriteLine($"Наиболее встречающееся слово в тексте (по убыванию) -  {word.Key}, колличество -  {word.Count()}");
            }
        }
    }
}
