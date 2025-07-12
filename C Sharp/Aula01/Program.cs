using Aula01;

// Exemplo 1
Person pessoa1 = new Person();

pessoa1.name = "Joanderson";
pessoa1.age = 16;

pessoa1.Apresentation();
Console.WriteLine(pessoa1.VerifyAge());

// Exemplo 2
Person pessoa2 = new();

pessoa2.name = "Carina";
pessoa2.age = 1400096;

pessoa2.Apresentation();
Console.WriteLine(pessoa2.VerifyAge());

// Exemplo 3
Person pessoa3 = new()
{
    name = "José",
    age = 2
};

pessoa3.Apresentation();
Console.WriteLine(pessoa3.VerifyAge());