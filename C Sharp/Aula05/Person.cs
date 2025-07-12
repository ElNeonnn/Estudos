namespace Aula05
{
    internal class Person
    {
        // Campos protegidos
        private string name = String.Empty;
        private int age;

        // Construtor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Método para apresentar os dados
        public void IntroducePerson()
        {
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Idade: {age}");
        }
    }
}
