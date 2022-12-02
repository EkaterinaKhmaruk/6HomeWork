/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,
 k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Write("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
/* Сделала методом Крамера, ибо не поняла каким еще способом это сделать,
я, наверное, усложняю?:D   */

int[,] Delta = new int[2,2];
Delta[0,0] = k1; 
Delta[0,1] = -1;
Delta[1,0] = k2;
Delta[1,1] = -1;  

Console.WriteLine("Дельта матрица: ");
PrintArray(Delta);


int[,] DeltaX = new int[2,2];
DeltaX[0,0] = -b1; 
DeltaX[0,1] = -1;
DeltaX[1,0] = -b2;
DeltaX[1,1] = -1; 

Console.WriteLine();
Console.WriteLine("Дельта X матрица: ");
PrintArray(DeltaX);

int[,] DeltaY = new int[2,2];
DeltaY[0,0] = k1; 
DeltaY[0,1] = -b1;
DeltaY[1,0] = k2;
DeltaY[1,1] = -b2; 

Console.WriteLine();
Console.WriteLine("Дельта Y матрица: ");
PrintArray(DeltaY);

double determinant = 0;
determinant = k1 * -1 - (k2*(-1));
Console.WriteLine($"Детерминант первой матрицы: {determinant}");

double determinantX = 0;
determinantX = -b1 * -1 - (-b2*(-1));
Console.WriteLine($"Детерминант матрицы X: {determinantX}");

double determinantY = 0;
determinantY = k1 * -b2 - (k2*(-b1));
Console.WriteLine($"Детерминант матрицы Y: {determinantY}");

double x = determinantX/determinant;
double y = determinantY/determinant;

Console.WriteLine($"Точка пересечения с координатами: X = {x}, Y = {y}");

void PrintArray(int[,] matr)
{
   for (int i =0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
Console.WriteLine();
}
}