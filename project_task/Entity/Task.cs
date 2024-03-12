using System.Collections.Generic;
using System.Linq;

namespace project_task.Entity
{
    public class Task
    {
        private static readonly List<Task> tasks = new List<Task>();

        public long Id;
        public long IdProject;
        public string Name;
        public string Description;
        public bool IsCompleted;

        public Task(long id, long idProject, string name, string description, bool isComleted) 
        {
            this.Id = id;
            this.IdProject = idProject;
            this.Name = name;
            this.Description = description;
            this.IsCompleted = isComleted;
        }

        public Task(long idProject)
        {
            Id = -1;
            IdProject = idProject;
            Name = "";
            Description = "";
            IsCompleted = false;
        }

        public static Task[] SelectAllFromIdProject(long idProject)
        {
            IEnumerable<Task> temp = tasks.Where((task) => task.IdProject == idProject);
            return temp.ToArray();
        }

        public static void Insert(Task task)
        {
            tasks.Add(task);
        }

        public static void InsertRange(Task[] arrayTasks)
        {
            tasks.AddRange(arrayTasks);
        }

        public static void Delete(Task task)
        {
            tasks.Remove(task);
        }
    }
}
