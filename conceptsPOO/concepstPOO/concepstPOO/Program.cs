

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

//Employee employee1 = new SalaryEmployee()
//{
//    Id = 1,
//    FirstName = "Harrison",
//    LastName = "Arroyave",
//    BirthDate = new Date(1995, 5, 5),
//    HiringDate = new Date(1990,10, 15),
//    IsActive = true,
//    Salary = 19897.15M
//};
//--------------------------------------------------------------------
// Class CommissionEmpoyee
Employee employee1 = new CommissionEmployee()
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

Console.WriteLine(employee1);