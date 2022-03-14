// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int Prompt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int N = Prompt("Введите пятизначное число: ");

bool Polindrom(string str)
{

    int lengh = str.Length;

    for (int i = 0; i < lengh/2; i++)
    {
        if(str[i] != str[lengh-i-1])
        {
            return false; 
        }
    }
    return true;
}



if (Math.Abs(N) > 9999 && Math.Abs(N) < 100000)
{
    string strNew = Math.Abs(N).ToString();
    if(Polindrom(strNew)) 
    {
        Console.WriteLine("Полиндром");
    }
    else Console.WriteLine("Не полиндром");
}

else Console.WriteLine("Число не является пятизначным");

