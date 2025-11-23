using Tyuiu.PisarevMA.Sprint5.Task1.V23.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 5 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана функция. (произвести табулирование) f(x) на заданном диапазоне     *");
Console.WriteLine("* [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на  *");
Console.WriteLine("* ноль вернуть значение 0. Результат сохранить в текстовый файл           *"); 
Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу. Значения округлить  *");
Console.WriteLine("* до двух знаков после запятой.                                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine($"* Стартовое значение x: {startValue}                                     *");
Console.WriteLine($"* Конечное значение x: {stopValue}                                       *");
Console.WriteLine($"* Шаг: 1                                                                 *");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string filePath = ds.SaveToFileTextData(startValue, stopValue);

Console.WriteLine($"Результат сохранен в файл: {filePath}");
Console.WriteLine("***************************************************************************");

Console.WriteLine(" +-----------+-----------+");
Console.WriteLine(" |     X     |    F(x)   |");
Console.WriteLine(" +-----------+-----------+");

string[] lines = File.ReadAllLines(filePath);
int x = startValue;
foreach (string line in lines)
{
    Console.WriteLine($" |{x}         | \t{line}    |");
    x++;
}
Console.WriteLine(" +-----------+-----------+");

Console.WriteLine("***************************************************************************");

Console.ReadKey();
