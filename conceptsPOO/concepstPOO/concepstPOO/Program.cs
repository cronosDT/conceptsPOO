

using concepstPOO;

Console.WriteLine("Hello, World!");

Console.WriteLine("------------------------------------");


// First part about the Date class
//try
//{
//    Console.WriteLine(new Date(1998, 1, 3));
//    Console.WriteLine(new Date(1554, 12, 30));
//    Console.WriteLine(new Date(1887, 2, 30));
//    Console.WriteLine(new Date(1999, 11, 10));
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}
//----------------------------------------------------------------------------
// Second paret about Abstract class

Employee employee4 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Harrison",
    LastName = "Arroyave",
    BirthDate = new Date(1995, 5, 5),
    HiringDate = new Date(1990, 10, 15),
    IsActive = true,
    Salary = 19897.15M
};
//--------------------------------------------------------------------
// Class CommissionEmpoyee
Employee employee3 = new CommissionEmployee()
{
    Id = 1,
    FirstName = "Harrison",
    LastName = "Arroyave",
    BirthDate = new Date(1995, 5, 5),
    HiringDate = new Date(1990, 10, 15),
    IsActive = true,
    CommissionPercentaje = 10F,
    Sale = 34539204.5432M
};
// Class HourlyEmployee
Employee employee2 = new HourlyEmployee()
{
    Id = 1,
    FirstName = "Harrison",
    LastName = "Arroyave",
    BirthDate = new Date(1995, 5, 5),
    HiringDate = new Date(1990, 10, 15),
    IsActive = true,
    Hours = 2.5F,
    HoursValue = 1500.142M
};
// Class BaseCommissionEmploye
Employee employee1 = new BaseCommissionEmploye()
{
    Id = 1,
    FirstName = "Harrison",
    LastName = "Arroyave",
    BirthDate = new Date(1995, 5, 5),
    HiringDate = new Date(1990, 10, 15),
    IsActive = true,
    CommissionPercentaje = 10F,
    Base = 1200M,
    Sale = 34539204.5432M
};

//Console.WriteLine(employee1);

ICollection<Employee> employees = new List<Employee>()
//Second form
{
    employee1, employee2, employee3
};

//First form
//employees.Add(employee1);


//To print all list let´s use the bucle for each

decimal payroll = 0;
foreach (Employee employee in employees)
{ 
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay(); 
}
Console.WriteLine("                                ================");
Console.WriteLine($"TOTAL:                        {$"{payroll}",18}");


Invoice invoice1 = new Invoice()
{
    Description = "Laptop new generation",
    Id = 123242,
    Quantity = 15F,
    price = 2302332.1233M
};
Invoice invoice2 = new Invoice()
{
    Description = "Meat",
    Id = 1293983,
    Quantity = 15.5F,
    price = 15500.00M
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);