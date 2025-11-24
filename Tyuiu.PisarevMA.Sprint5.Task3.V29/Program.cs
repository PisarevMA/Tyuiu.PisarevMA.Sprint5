using Tyuiu.PisarevMA.Sprint5.Task3.V29.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 5 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #29                                                             *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение, вычислить его значение при x = 3, результат сохранить в *");
Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до    *");
Console.WriteLine("* трёх знаков после запятой.                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 3;
Console.WriteLine($"x = {x}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string path = ds.SaveToFileTextData(x);

Console.WriteLine($"Файл: {path}");
Console.WriteLine("Создан");

Console.ReadKey();

