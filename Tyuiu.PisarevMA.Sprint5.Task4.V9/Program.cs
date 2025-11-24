using Tyuiu.PisarevMA.Sprint5.Task4.V9.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 5 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл в котором есть вещественное значение. Прочитать значение из    *");
Console.WriteLine("* файла и подставить вместо Х в формуле. Вычислить значение по формуле.   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";

Console.WriteLine($"Данные находятся в файле: {path}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);

Console.WriteLine(res);

Console.ReadKey();
