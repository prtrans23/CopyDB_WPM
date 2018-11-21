using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Util.TaskExample
{
    class TaskExample
    {
        public async Task Test1()
        {
            await Task.CompletedTask;
        }

        public async Task<object> Test2()
        {
            return await Task.FromResult<object>(null);
        }

        public async Task<object> Test3()
        {
            return await Task.FromException<object>(new NotImplementedException());
        }


        public async Task DoTask()
        {
            var State = TaskStates.InProgress;
            await RunTimer();
        }

        public Task RunTimer()
        {
            return new Task(new Action(() =>
            {
                using (var t = new time.Timer(RequiredTime.Milliseconds))
                {
                    t.Elapsed += ((x, y) => State = TaskStates.Completed);
                    t.Start();
                }
            }));
        }
    }
}
