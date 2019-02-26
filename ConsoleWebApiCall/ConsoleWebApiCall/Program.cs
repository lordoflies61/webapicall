using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWebApiCall
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = new Services().GetTodos("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(JsonConvert.SerializeObject(resultado));
            Console.ReadKey();

        }
    }
}
