namespace Aula01
{
    internal class Person
    {
        // Campos
        public string name = String.Empty;
        public int age;

        // Método sem retorno
        public void Apresentation()
        {
            Console.WriteLine($"Olá! Meu nome é {name} e eu tenho {age} anos.");
        }

        // Método com retorno
        public string VerifyAge()
        {
            return age >= 18 ? "Esta pessoa é maior de idade." : "Esta pessoa é menor de idade.";
        }
    }
}
