using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concepstPOO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; } //Amount of products
        public decimal price { get; set; }
        public decimal GetValueToPay()
        {
            return price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"\n\tQuantity..........: {$"{Quantity:N2}",18}" +
                $"\n\tPrice.............: {$"{price:C2}",18}" +
                $"\n\tQuantity..........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
