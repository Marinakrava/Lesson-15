using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Арифметическая прогрессия
            //ArithProgression arith = new ArithProgression();
            //arith.SetStart (10);
            //arith.SetStep(2);
            //Console.WriteLine(arith.GetNext());
            //Console.WriteLine(arith.GetNext());
            //Console.WriteLine(arith.GetNext());
            //arith.Reset();
            //Console.WriteLine(arith.GetNext());
            //Console.WriteLine(arith.GetNext());
            //Console.ReadKey();  

            //Геометрическая прогрессия
            GeomProgression geom = new GeomProgression(); //Создаем экземпляр класса
            geom.SetStart(15);// Устанавливаем начальное значение
            geom.SetStep(2);// Устанавливаем шаг
            Console.WriteLine(geom.GetNext());// Выводим значение
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            geom.Reset();// Сброс до начального значения
            Console.WriteLine(geom.GetNext());// Выводим значение
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.ReadKey();

        }
    }
}
