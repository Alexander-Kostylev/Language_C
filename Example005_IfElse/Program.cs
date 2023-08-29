Console.Write("Введите имя пользователя ");
string userName=Console.ReadLine();

if(userName.ToLower() == "alex")
{
    Console.WriteLine("Ура, это же Alex");
}

else 
{
    Console.Write("Привет ");
    Console.Write(userName);
}