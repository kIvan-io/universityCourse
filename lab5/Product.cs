using System;
namespace ProductNamespace
{
    public class Product
    {
        private string name;
        private decimal price;
        private int quantity;
        private string sku;
        private string category;

        public string GetName() => name;
        public decimal GetPrice() => price;
        public int GetQuantity() => quantity;
        public string GetSku() => sku;
        public string GetCategory() => category;
        public void SetName(string name) => this.name = name;
        public void SetPrice(decimal price) => this.price = price;
        public void SetQuantity(int quantity) => this.quantity = quantity;
        public void SetCategory(string category) => this.category = category;

        public Product(string name, decimal price, int quantity, string category)
        {
            if (ValidateInput(name, price, quantity, category) == true)
            {
                this.name = name;
                this.price = price;
                this.quantity = quantity;
                this.category = category;
                sku = GenerateSku();
            }
            else
            {
                this.name = "INVALID";
                this.price = 0;
                this.quantity = 0;
                this.category = "INVALID";
                sku = "INVALID";
            }
        }

        private bool ValidateInput(string name, decimal price, int quantity, string category)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine(("Название товара не может быть пустым"));
                return false;
            }             
            if (price <= 0)
            {
                Console.WriteLine(("Цена должна быть положительной"));
                return false;
            }                
            if (quantity <= 0)
            {
                Console.WriteLine(("Количество не может быть отрицательным"));
                return false;
            }               
            if (string.IsNullOrWhiteSpace(category))
            {
                Console.WriteLine(("Категория не может быть пустой"));
                return false;
            }
            return true;
        }

        private string GenerateSku()
        {
            return DateTime.Now.ToString("yyMMddHHmmssfff");
        }

        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice >= 0)
            {
                SetPrice(newPrice);
            }
            else
            {
                Console.WriteLine("цена < 0");
            }
        }
        public bool IncreaseQuantity(int amount)
        {
            if(amount >= 0)
            {
                SetQuantity(amount + GetQuantity());
                return true;
            }
            return false;
        }

        public bool DecreaseQuantity(int amount)
        {

            if (amount >= 0)
            {
                SetQuantity(GetQuantity() - amount);
                return true;
            }
            return false;
        }
        public void ApplyDiscount(decimal percent)
        {
            if (percent <= 0 || percent > 100)
            {
                Console.WriteLine("скидка должны быть в диапазоне от 0 до 100%");
                return;
            }
            decimal discountAmount = price * (percent / 100);
            UpdatePrice(GetPrice() - discountAmount);
        }

        public void print()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("название: " + name);
            Console.WriteLine("цена: " + price);
            Console.WriteLine("количество: " + quantity);
            Console.WriteLine("артикул: " + sku);
            Console.WriteLine("категория: " + category);
            Console.WriteLine("==================================");
        }
    }
}



