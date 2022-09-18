int [] CreateArray (int n, int x, int y){ // n - size;  x - min element; y - max+1 element
    int [] array = new int [n];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(x, y);
    }
    return array;
}

void PrintArray (int[] ar){
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]} ");
    }
    Console.WriteLine();
}


/*void PrintArray2 (int[,] ar){
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($"{ar[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}*/

int MaxElementArray (int[] ar){
    int max = ar[0];
    for (int i = 0; i < ar.Length; i++)
    {
        if (max < ar[i]){
            max = ar[i];
        }
    }
    return max;
}

int MinElementArray (int[] ar){
    int min = ar[0];
    for (int i = 0; i < ar.Length; i++)
    {
        if (min > ar[i]){
            min = ar[i];
        }
    }
    return min;
}

int Metod34 (int[] ar){
    int help = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if(ar[i] % 2 == 0){
            help +=1;
        }
    }
    return help;
}

int Metod36 (int[] ar){
    int sum = 0;
    for (int i = 1; i < ar.Length; i +=2 )
    {
        sum += ar[i];
    }
    return sum;
}


/*Задача 39:** Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

Console.Clear();
Console.WriteLine("Задача 39");
int [] ArrayRevers(int [] ar){
    int help = 0;
    for (int i = 0; i < ar.Length/2; i++)
    {
        help = ar[i];
        ar[i] = ar[ar.Length - 1 - i];
        ar[ar.Length - 1 - i] = help;
    }
    return ar;
}

int [] array39 = CreateArray(6, 0, 10);
PrintArray(array39);
ArrayRevers(array39);
PrintArray(array39);
Console.WriteLine("------------------");



/*Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.*/
Console.WriteLine("Задача 40");
int a = 10, 
    b = 10, 
    c = 10;
if(a < b + c && b < a + c && c < b + a){
    Console.WriteLine("треугольник существует");
}
else Console.WriteLine("треугольник НЕ существует");
Console.WriteLine("------------------");

/*Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

Console.WriteLine("Задача 42");
String Dvoich (int n){
    string dvoich = "";
    while (n > 0){
        dvoich =  Convert.ToString(n%2) + dvoich;
        n=n/2;
    }
    return dvoich;
}

Console.WriteLine("Введите число");
int number42 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Dvoich(number42));
Console.WriteLine("------------------");




/*Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

Console.WriteLine("Задача 44");
int [] Fibonacci(int n, int a, int b)  //n колличество чисел, a - первое число, b - второе число
{   if(n == 1 || n == 0) {
        int [] nul = {0};
        return nul;
    }   
    int [] fibonacci = new int [n];
    fibonacci[0] = a;
    fibonacci[1] = b;
    for (int i = 2; i < n; i++){
        fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
    }
    return fibonacci;
}

PrintArray(Fibonacci(10, 0, 1));
Console.WriteLine("------------------");



/*Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования*/
Console.WriteLine("Задача 45");
int [] CoppyArray( int [] ar){
    int [] coppyar = new int [ar.Length];
    for (int i = 0; i < ar.Length; i++)
    {
        coppyar[i] = ar[i];
    }
    return coppyar;
}

int [] array45 = CreateArray(10, 0, 100);
PrintArray(array45);
PrintArray(CoppyArray(array45));
Console.WriteLine("------------------");