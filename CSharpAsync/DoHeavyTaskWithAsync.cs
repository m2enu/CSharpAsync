using System;
using System.Threading.Tasks;

namespace CSharpAsync
{
    public class DoWithAsync
    {
        public async Task<int> Do()
        {
            Console.WriteLine("begin");
            await Task.Delay(2000);
            Console.WriteLine("end");
            return 0;
        }
    }
}
