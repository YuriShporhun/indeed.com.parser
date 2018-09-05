using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace indeed.com.models
{
    public class CancellableTask<Result, Part>
        where Part : class
        where Result : ICollection<Part>
    {
        private Task<Result> task;
        private CancellationTokenSource source = new CancellationTokenSource();
        private CancellationToken token;
        private Func<Part> job;

        private CancellableTask(Func<Part> func)
        {
            token = source.Token;
            job = func;
            task = new Task<Result>(Wrapper, source.Token);
            task.Start();
        }

        private Result Wrapper()
        {
            token.ThrowIfCancellationRequested();
            ICollection<Part> result = new List<Part>();
            Part part;
            while ((part = job()) != null)
            {
                token.ThrowIfCancellationRequested();
                result.Add(part);
            }
            return (Result)result;
        }

        public class Factory
        {
            public CancellableTask<ICollection<JobInfo>, JobInfo> JobInfoTask(Func<JobInfo> func) =>
                new CancellableTask<ICollection<JobInfo>, JobInfo>(func);
        }
    }
}
