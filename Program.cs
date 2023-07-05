Console.WriteLine("Digite seu nome: ");

string name = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome: ");

string lastname = Console.ReadLine();

Console.Write("Digite o ano de nascimento: ");

int year = int.Parse(Console.ReadLine());

int age = 2023 - year;

Console.WriteLine($"Você nasceu no ano: {year} e seu nome é: {name} {lastname} e sua idade é: {age}");
