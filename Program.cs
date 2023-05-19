/*
int a = 6;
int b = 9;
int c = a * b;
Console.WriteLine(c);
*/
Console.WriteLine("Введите ваше имя: ");
string Username = Console.ReadLine();
if (Username.ToLower() == "bebrik")
{ 
Console.WriteLine("Дарова, " + Username);
}
else
{
    Console.WriteLine("Здравствуйте, " + Username);
}

