using System.Security.Cryptography.X509Certificates;

namespace Aula10.Good
{
    public enum EProductType
    {
        Eletronics = 1,
        Health = 2,
        Beauty = 3,
        Fashion = 4
    }

    internal abstract class Discount
    {
        public abstract decimal Calculate(decimal price);
    }

    public class EletronicsDiscount : Discount
    {
        public override decimal Calculate(decimal price)
        {
            return price * 0.5m;
        }
    }

    public class HealthDiscount : Discount
    {
        public override decimal Calculate(decimal price)
        {
            return price * 0.5m;
        }
    }

    public class BeautyDiscount : Discount
    {
        public override decimal Calculate(decimal price)
        {
            return price * 0.5m;
        }
    }
    
    public class FashionDiscount : Discount
    {
        public override decimal Calculate(decimal price)
        {
            return price * 0.5m;
        }
    }
}
