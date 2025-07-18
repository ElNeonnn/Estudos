﻿namespace Aula10.Bad
{
    public enum EProductType
    {
        Eletronics = 1,
        Health = 2,
        Beauty = 3,
        Fashion = 4
    }

    internal class Discount
    {
        public decimal Calculate(EProductType type, decimal price)
        {
            if (type == EProductType.Eletronics)
            {
                return price * 0.2m;
            }

            if (type == EProductType.Health)
            {
                return price * 0.3m;
            }

            if (type == EProductType.Beauty)
            {
                return price * 0.4m;
            }

            if (type == EProductType.Fashion)
            {
                return price * 0.5m;
            }

            return price;
        }
    }
}
