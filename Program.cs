
using csharp_lista_indirizzi;

var addresses = Parser.Read();

foreach (var address in addresses)
{
    Console.WriteLine(address);
}