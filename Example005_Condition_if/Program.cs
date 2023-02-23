Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "поля"){
    Console.WriteLine("Толстенькая дрочила Привет!");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}