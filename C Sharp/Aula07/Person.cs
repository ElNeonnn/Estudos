namespace Aula07
{
    internal class Person : Actions
    {
        public override void ToSpeak()
        {
            Console.WriteLine($"Estou falando!");
        }

        public override void ToWalk()
        {
            Console.WriteLine($"Estou andando!");
        }
    }
}
