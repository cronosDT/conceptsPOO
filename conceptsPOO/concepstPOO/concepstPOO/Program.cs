

using concepstPOO;

Console.WriteLine("Hello, World!");

Console.WriteLine("------------------------------------");

try
{
    Console.WriteLine(new Date(1998, 1, 3));
    Console.WriteLine(new Date(1554, 12, 30));
    Console.WriteLine(new Date(1887, 2, 30));
    Console.WriteLine(new Date(1999, 11, 10));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}