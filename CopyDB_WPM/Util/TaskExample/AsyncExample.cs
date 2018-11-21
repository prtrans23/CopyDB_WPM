using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Util.TaskExample
{
    class AsyncExample
    {

        async Task Callback()
        {
            Console.WriteLine("I'm in callback");
        }

        async Task DoSomething(Func<Task> callback)
        {
            Console.WriteLine("I'm in DoSomething");
            await callback();
        }

        public async void TestMain()
        {
            Console.WriteLine("I'm in Main");
            await DoSomething(Callback);
            Console.WriteLine("Execution completed");

            await test1(Write);
        }


        
        async Task test1(Func<int> callback)
        {
            Console.WriteLine("I'm in DoSomething");
        }

        public int Write()
        {
            return 1;
        }
    }
}
