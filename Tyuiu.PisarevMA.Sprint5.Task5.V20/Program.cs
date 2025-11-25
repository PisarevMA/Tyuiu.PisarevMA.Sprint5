using Tyuiu.PisarevMA.Sprint5.Task5.V20.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 5 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл в котором есть набор значений. Найти среднее значение всех     *");
Console.WriteLine("* целых чисел в файле, которые находятся в промежутке от -10 до 10.       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask5V20.txt";

Console.WriteLine($"Данные находятся в файле: {path}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);

Console.WriteLine(res);

Console.ReadKey();
