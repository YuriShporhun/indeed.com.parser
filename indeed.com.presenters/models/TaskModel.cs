using System.Collections.Generic;

namespace indeed.com.models
{
    public class TaskModel
    {
        public enum TaskState
        {
            Ready,
            Runned,
            Paused,
            Cancelled
        }

        private CancellableTask<ICollection<JobInfo>, JobInfo> jobTasks;

        public string Name { get; set; }
        public string Description { get; set; }
        public TaskState State { get; private set; }

        public bool IsReady() => State == TaskState.Ready ? true : false;

        public bool Run()
        {
            if(State == TaskState.Ready || State == TaskState.Paused)
            {

                State = TaskState.Runned;
                return true;
            }
            return false;
        }

        public bool Cancell()
        {
            if (State != TaskState.Cancelled)
            {
                State = TaskState.Cancelled;
                return true;
            }
            return false; ;
        }
    }
}
