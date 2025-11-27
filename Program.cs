

using ProductNamespace;
public class Program
{
    public static void Main(string[] args)
    {
        Product[] products =
            {
                new Product("Вишня", 45, 50, "Фрукты"),
                new Product("Морковь", 30, 100, "Овощи"),
                new Product("Молоко", 80, 30, "Молочные продукты"),
                new Product("Хлеб", 25, 40, "Выпечка"),
                new Product("Сок", 120, 20, "Напитки"),
                new Product("Вишня444", 45, -50, "Фрукты"),
            };

        //        void UpdatePrice(decimal newPrice)     ->  Изменить цену
        //    bool IncreaseQuantity(int amount)      -> Увеличить количество
        //    bool DecreaseQuantity(int amount)   -> Уменьшить количество
        //void ApplyDiscount(decimal percent)    ->  Применить скидку

        products[1].print();

        products[1].UpdatePrice(1);
        products[1].IncreaseQuantity(100);
        products[1].DecreaseQuantity(2);
        products[1].ApplyDiscount(50);
        //products[5].


        products[5].print();

    }
}