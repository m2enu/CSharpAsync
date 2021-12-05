using System;
using System.Threading;

namespace CSharpAsync
{
    public class DoWithEvent
    {
        public int Do()
        {
            var thread = new Thread(() =>
            {
                HeavyTask();
            });
            thread.Start();
            thread.Join();
            return 0;
        }

        private void HeavyTask()
        {
            Console.WriteLine("begin");
            Thread.Sleep(2000);
            Console.WriteLine("end");
        }
    }
}
