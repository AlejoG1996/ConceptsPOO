using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("=========");

try
{
    Console.WriteLine(new Date(2024, 02, 29));
    Console.WriteLine(new Date(1974, 9, 07));
    Console.WriteLine(new Date(1985, 11, 31));
}
catch (Exception Error)
{
    Console.WriteLine(Error.Message);
}