namespace Aula05
{
    internal class Collaborator : Person
    {
        // Campos privados
        private string position = String.Empty;
        private double wage;

        // Construtor
        public Collaborator(string name, int age, string position, double wage) : base(name, age)
        {
            this.position = position;
            this.wage = wage;

            IntroducePerson();
            IntroduceCollaborator();
        }

        // Método para apresentar os dados
        private void IntroduceCollaborator()
        {
            Console.WriteLine($"Cargo: {position}");
            Console.WriteLine($"Salário: {wage}");
        }
    }
}
