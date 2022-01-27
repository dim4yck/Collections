using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var arrayList = new ArrayList();
            var linkedList = new LinkedList<int>();

            // Add 1000000 items to each collection.
            // Measure the duration of filling each collection and display the values on the screen.

            Stopwatch stopWatch = new Stopwatch();
            TimeSpan ts;
            string elapsedTime;


            stopWatch.Start();
            for (int i = 0; i < 10000000; i++)
                list.Add(i);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"Время заполнения List 10000000-ом элементов составило: {elapsedTime} секунд");


            stopWatch.Start();
            for (int i = 0; i < 10000000; i++)
                arrayList.Add(i);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"Время заполнения ArrayList 10000000-ом элементов составило: {elapsedTime} секунд");


            stopWatch.Start();
            for (int i = 0; i < 10000000; i++)
                linkedList.AddLast(i);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"Время заполнения LinkedList 10000000-ом элементов составило: {elapsedTime} секунд");

            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();


            // Find the 496753rd element, measure the duration of this search and display it on the screen.

            stopWatch.Start();
            Console.WriteLine(list[496753]);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"Время выполнения поиска элемента List: {elapsedTime} секунд");


            stopWatch.Start();
            Console.WriteLine(arrayList[496753]);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"Время выполнения поиска элемента ArrayList: {elapsedTime} секунд");


            stopWatch.Start();
            Console.WriteLine(linkedList.Find(496753).Value);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"Время выполнения поиска элемента LinkedList: {elapsedTime} секунд");


            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();


            // Display each element of the collection, which is divided into 777 without remainder.
            // Print the duration of this operation for each collection.

            stopWatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                if (list[i] % 777 == 0)
                    Console.WriteLine(list[i]);
            }
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"Время выполнения поиска каждого элемента List, который без остатка делится на 777: {elapsedTime} секунд");


            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();


            stopWatch.Start();
            for (int i = 0; i < 10000000; i++)
            {
                if (int.Parse($"{arrayList[i]}") % 777 == 0)
                    Console.WriteLine(arrayList[i]);
            }
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"Время выполнения поиска каждого элемента ArrayList, который без остатка делится на 777: {elapsedTime} секунд");


            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();


            stopWatch.Start();
            foreach (var item in linkedList)
            {
                if (item % 777 == 0)
                    Console.WriteLine(item);
            }
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:0}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"Время выполнения поиска каждого элемента LinkedList, который без остатка делится на 777: {elapsedTime} секунд");
        }
    }
}