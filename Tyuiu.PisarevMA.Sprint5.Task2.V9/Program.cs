using Tyuiu.PisarevMA.Sprint5.Task2.V9.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 5 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] mtrx = new int[3, 3] { { 6, 8, 3 }, { 2, 6, 8 }, { 1, 7, 1 } };

int rows = mtrx.GetUpperBound(0) + 1;
int columns = mtrx.Length / rows;

Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(mtrx);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");

Console.ReadKey();

