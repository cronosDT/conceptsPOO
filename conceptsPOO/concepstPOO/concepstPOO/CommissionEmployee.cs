using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concepstPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sale { get; set; }

        public override decimal GetValueToPay()
        {
            return Sale * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommision percentaje: {$"{CommissionPercentaje:p2}", 15}" +
                $"\n\tSales...............: {$"{Sale:c2}" ,15}" +
                $"\n\tValue to pay........: {$"{GetValueToPay():c2}" ,15}";

        }

    }
}
