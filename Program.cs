using System;
using System.Threading.Tasks;

namespace ApiWebserviceHttpSoap
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ServiceReference1.SOAPDemoSoapClient client = new ServiceReference1.SOAPDemoSoapClient();

            var numero1 = 11;
            var numero2 = 4;
            var soma = await client.AddIntegerAsync(numero1, numero2);
            Console.WriteLine($"{numero1} + {numero2} = {soma}\r\n");

            var divisor = 27;
            var dividendo = 9;
            var resultDivide = await client.DivideIntegerAsync(divisor, dividendo);
            Console.WriteLine($"{divisor} / {dividendo} = {resultDivide}\r\n");

            var idPerson = 13;
            var person = await client.FindPersonAsync($"{idPerson}");
            Console.WriteLine($"Name: {person.Name}, Idade: {person.Age}\r\n");
        }
    }
}
