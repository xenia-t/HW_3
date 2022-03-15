// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

void InputArray(double[] array)
{

    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите координату {i+1}: ");
        string strArray = Console.ReadLine();
        array[i] = double.Parse(strArray);
    }
}

Console.WriteLine($"Введите координаты точки А: ");
double[] A = new double[3];
InputArray(A);

Console.WriteLine($"Введите координаты точки B: ");
double[] B = new double[3];
InputArray(B);



double distance = Math.Sqrt(Math.Pow((A[0]-B[0]),2) + Math.Pow((A[1]-B[1]),2) + Math.Pow((A[2]-B[2]),2));

Console.WriteLine($"{distance}");