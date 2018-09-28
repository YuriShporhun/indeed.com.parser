using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace indeed.com.models
{
    public class TaskPanelModel
    {
        /// <summary>
        /// Represents possible task states
        /// </summary>
        public enum TaskState
        {
            /// <summary>
            /// A task is ready to be launched
            /// </summary>
            Ready,

            /// <summary>
            /// A task is processing an operation 
            /// </summary>
            Runned,

            /// <summary>
            /// A task is paused
            /// </summary>
            Paused,

            /// <summary>
            /// A task was cancelled
            /// </summary>
            Cancelled,

            /// <summary>
            /// A task completed na operation successfuly
            /// </summary>
            Completed
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
            switch (State)
            {
                case TaskState.Ready:
                case TaskState.Paused:
                    State = TaskState.Runned;
                    Parser parser = new Parser();
                    IEnumerable<JobInfo> parsedData = await parser.Parse(Request);
                    OnComplete?.Invoke($"The parser finished the {Name} task successfully");
                    State = TaskState.Completed;
                    break;
                case TaskState.Runned:
                    OnError?.Invoke($"The parser is already processing the {Name} task");
                    break;
                case TaskState.Cancelled:
                    break;
                case TaskState.Completed:
                    break;
                default:
                    throw new NotImplementedException();
            }
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
