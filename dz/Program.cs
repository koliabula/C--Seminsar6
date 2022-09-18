void PrintArray (int[] ar){
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]} ");
    }
    Console.WriteLine();
}

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


Console.Clear();
// -----------РЕШЕНИЕ 1--------------//

Console.WriteLine("Введите количество чисел");
int col = Convert.ToInt32(Console.ReadLine());
int [] arraynumbers = new int [col];
Console.WriteLine("Введите числа");
int positivenumbers = 0;
for (int i = 0; i < col; i++)
{
    arraynumbers[i] = Convert.ToInt32(Console.ReadLine());
    if(arraynumbers[i] > 0) {
        positivenumbers++;
    }
}
Console.WriteLine($"Количество цифр больше 0 = {positivenumbers}");

//----------РЕШЕНИЕ 2---------------//

int [] CreateArrayUser (){
    Console.WriteLine("Введите количество элементов массива");
    int col = Convert.ToInt32(Console.ReadLine());
    int [] arraynumbers = new int [col];
    Console.WriteLine("Введите числа");
    for (int i = 0; i < col; i++)
    {
        arraynumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arraynumbers;
}

int Positive (int [] ar){
    int positive = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] > 0){
            positive++;
         }
    }
    return positive;
}

int [] array41 = CreateArrayUser();
PrintArray(array41);
Console.WriteLine(Positive(array41));




/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/*
    y = k1*x + b1
    y = k2*x + b2

    y- k1*x = b1
    y = k2*x + b2

    k2*x + b2 - k1*x = b1
    y = k2*x + b2

    k2*x - k1*x = b1 - b2
    y = k2*x + b2

    (k2 - k1)x = b1 - b2
    y = k2*x + b2

    x = (b1-b2)/(k2 - k1)    -2/4 = -0.5
    y = k2*x + b2              9*(-0.5)+4=-0,5
*/

string PointX(double b1, double k1, double b2, double k2){
    string pointX = "";
    if(k1 == k2 && b1 == b2){
        return pointX = "Прямые совпадают, каждая точка является решением";
    }
    else if (k1 == k2){
        return pointX = "Прямые параллельны, точек пересечения нет";
    }
    else {
        double x, y;
        x = (b1 - b2)/(k2 - k1);
        Console.WriteLine(x);
        y = k2*x + b2;
        Console.WriteLine(y);
        pointX ="("+Convert.ToString(x) +"; "+ Convert.ToString(y)+")"; 
        return pointX;
    }
}


Console.WriteLine("Введите значения b1, k1, b2 и k2 последовательно через enter");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Точка пересечения прямых {PointX(b1, k1, b2, k2)}");