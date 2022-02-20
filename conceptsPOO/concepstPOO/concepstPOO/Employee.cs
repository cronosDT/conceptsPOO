namespace concepstPOO
{
    public abstract class Employee : IPay
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }

        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"\n\t{Id} - {FirstName} {LastName}, Birth: {BirthDate:00}, Hiring: {HiringDate:00}, Is active: {IsActive}";
        }

    }
}
