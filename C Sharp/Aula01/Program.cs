using Aula01;

// Exemplo 1
Person pessoa1 = new Person();

pessoa1.Name = "Joanderson";
pessoa1.Age = 16;

pessoa1.Apresentation();
Console.WriteLine(pessoa1.VerifyAge());

// Exemplo 2
Person pessoa2 = new();

pessoa2.Name = "Carina";
pessoa2.Age = 1400096;

pessoa2.Apresentation();
Console.WriteLine(pessoa2.VerifyAge());

// Exemplo 3
Person pessoa3 = new()
{
    Name = "José",
    Age = 2
};

pessoa3.Apresentation();
Console.WriteLine(pessoa3.VerifyAge());