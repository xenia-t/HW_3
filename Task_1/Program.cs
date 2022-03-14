// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int Prompt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int N = Prompt("Введите пятизначное число: ");

bool Palindrom(string str)
{

    int length = str.Length;

    for (int i = 0; i < length/2; i++)
    {
        if(str[i] != str[length-i-1])
        {
            return false; 
        }
    }
    return true;
}



if (N > 9999 && N < 100000)
{
    string strNew = N.ToString();
    if(Palindrom(strNew)) 
    {
        Console.WriteLine("Палиндром");
    }
    else Console.WriteLine("Не палиндром");
}

else Console.WriteLine("Число не является пятизначным");

