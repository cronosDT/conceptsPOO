namespace concepstPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HoursValue { get; set; }

        public override decimal GetValueToPay()
        {
            return HoursValue * (decimal)Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + 
                $"\n\tHours................: {$"{Hours:N2}",18}" +
                $"\n\tHour value...........: {$"{HoursValue:c2}",18}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay()}",18}";
        }

    }
}
