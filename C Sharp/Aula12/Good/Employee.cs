namespace Aula12.Good
{
    public interface ISalaryCalculator
    {
        void CalculateSalary();
    }

    public interface IBenefitsCalculator
    {
        void CalculateBenefits();
    }

    public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
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

    public class ContractEmployee : ISalaryCalculator
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Calculate salary.");
        }
    }
}
