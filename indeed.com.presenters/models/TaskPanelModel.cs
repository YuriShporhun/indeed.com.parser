using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace indeed.com.models
{
    public class TaskPanelModel
    {
        public enum TaskState
        {
            Ready,
            Runned,
            Paused,
            Cancelled
        }

        private CancellableTask<ICollection<JobInfo>, JobInfo> jobTasks;

        public string Name { get; internal set; }
        public ParserRequest Request { get; internal set; }
        public string Description { get; internal set; }
        public TaskState State { get; internal set; }

        public event Action<string> OnComplete;
        public event Action<string> OnError;

        public bool IsReady() => State == TaskState.Ready ? true : false;

        public async Task Run()
        {
            if(State == TaskState.Ready || State == TaskState.Paused)
            {
                State = TaskState.Runned;
                Parser parser = new Parser();
                IEnumerable<JobInfo> parsedData = await parser.Parse(Request);
                OnComplete?.Invoke($"The parser finished the {Name} task successfully");
            }
            OnError?.Invoke($"The parser failed the {Name} task");
        }

        public bool Cancel()
        {
            if (State != TaskState.Cancelled)
            {
                State = TaskState.Cancelled;
                return true;
            }
            return false;
        }

        public bool Pause()
        {
            if(State == TaskState.Runned)
            {
                State = TaskState.Paused;
                return true;
            }
            return false;
        }
    }
}
