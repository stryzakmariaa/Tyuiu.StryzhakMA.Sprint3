using Tyuiu.StryzhakMA.Sprint3.Task4.V24.Lib;

namespace Tyuiu.StryzhakMA.Sprint3.Task4.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Стрыжак Мария Андреевна | АСОиУб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                               *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=(sin(x)/x)+2 При х = 0 прервать цикл. Полученные              *");
            Console.WriteLine("* Полученные значения перемножать.                                        *");

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");


            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
