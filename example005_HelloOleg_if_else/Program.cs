Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "олег" )
{
    Console.WriteLine("Ха реально Олег кто тебе имя такое придумал. Ржомба");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}