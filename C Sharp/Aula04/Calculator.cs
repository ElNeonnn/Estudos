namespace Aula04
{
    internal class Calculator
    {
        // Propriedade numérica
        public static int Number { get; set; } = 10;

        // Método para somar dois valores
        public static void Add(int n1, int n2)
        {
            Console.WriteLine($"A soma dos valores é: {n1 + n2}");
        }
    }
}
