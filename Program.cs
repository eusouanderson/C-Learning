﻿Console.WriteLine("Digite seu nome: ");

string name = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome: ");

string lastname = Console.ReadLine();

Console.Write("Digite o ano de nascimento: ");

int year = int.Parse(Console.ReadLine());

int age = 2023 - year;

Console.WriteLine($"Você nasceu no ano: {year} e seu nome é: {name} {lastname} e sua idade é: {age}");

if (age >= 18 && age <= 60)
{
    Console.WriteLine("Você é maior de idade e voto é obrigatório");
}
else if (age < 18 && age > 15)
{
    Console.WriteLine("Você é menor de idade e seu voto não é obrigatório");
}
else
{
    Console.WriteLine("Você é menor de idade e você ainda não vota ");
}