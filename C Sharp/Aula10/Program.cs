using Aula10.Good;

EletronicsDiscount eletronicsDiscount = new();
eletronicsDiscount.Calculate(100m);

Discount discount2;
discount2 = new BeautyDiscount();
discount2.Calculate(50m);