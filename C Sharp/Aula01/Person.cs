namespace Aula01
{
    internal class Person
    {
        // Propriedades
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }

        // Método sem retorno
        public void Apresentation()
        {
            Console.WriteLine($"Olá! Meu nome é {Name} e eu tenho {Age} anos.");
        }

        // Método com retorno
        public string VerifyAge()
        {
            return Age >= 18 ? "Esta pessoa é maior de idade." : "Esta pessoa é menor de idade.";
        }
    }
}
