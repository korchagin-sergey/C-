Console.Write("В Ведите имя пользоватеья: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура это же МаШа!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
