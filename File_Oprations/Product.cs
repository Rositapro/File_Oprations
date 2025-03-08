using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Oprations
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, int quantity, decimal price)
        {
            ID = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ID},{Name},{Quantity},{Price}";
        }

        public static Product FromString(string data)
        {
            var parts = data.Split(',');
            if (parts.Length == 4 &&
                int.TryParse(parts[0], out int id) &&
                int.TryParse(parts[2], out int quantity) &&
                decimal.TryParse(parts[3], out decimal price))
            {
                return new Product(id, parts[1], quantity, price);
            }
            return null;
        }
    }
}
