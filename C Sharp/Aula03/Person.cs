namespace Aula03
{
    internal class Person
    {
        // 1º construtor
        public Person()
        {
            Console.WriteLine("Olá, Mundo!");
        }

        // 2º construtor
        public Person(string name)
        {
            Console.WriteLine($"Olá, {name}!");
        }

        // 3º construtor
        public Person(string name, int age)
        {
            Console.WriteLine($"Olá, {name}! Você tem {age} anos.");
        }
    }
}
