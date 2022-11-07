// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество элементов массива: ");
int ElementsCount = int.Parse(Console.ReadLine());
    int [] matr  = new int [ElementsCount];
    for (int i = 0; i < matr.Length; i ++)
    {
          Console.Write("Введите число: ");
          matr [i] = int.Parse(Console.ReadLine());
    }
  

int count = 0;
int Number (int [] matr)
{
for (int i = 0; i < matr.Length; i++)
{
    if (matr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во элементов больше нуля: {count}");
return count;
}

Number(matr);
