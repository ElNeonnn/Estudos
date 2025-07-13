namespace Aula12.Bad
{
    public interface IEmployee
    {
        void CalculateSalary();
        void CalculateBenefits();
    }

    public class FullTimeEmployee : IEmployee
    {
        public void CalculateBenefits()
        {
            Console.WriteLine("Calculate benefits.");
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Calculate salary.");
        }
    }

    public class ContractEmployee : IEmployee
    {
        public void CalculateBenefits()
        {
            throw new NotImplementedException();
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Calculate salary.");
        }
    }
}
