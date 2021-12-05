using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharpAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Do with event");
            var withEvent = new DoWithEvent();
            withEvent.Do();

            Console.WriteLine("Do with async");
            var withAsync = new DoWithAsync();
            await withAsync.Do();

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
