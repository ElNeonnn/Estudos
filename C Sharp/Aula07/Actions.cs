namespace Aula07
{
    internal abstract class Actions
    {
        // Métodos obrigatórios
        public abstract void ToSpeak();
        public abstract void ToWalk();

        // Métodos opcionais
        public void ToJump()
        {
            Console.WriteLine($"Estou pulando!");
        }
    }
}
