using System;
using System.Collections.Generic;


namespace project_task.Entity
{
    public class Project
    {
        private static readonly List<Project> projects = new List<Project>();

        private DateTime lastModifiedDateTime;

        public long Id;
        public readonly DateTime CreateDateTime;
        public DateTime LastModifiedDateTime
        {
            get { return lastModifiedDateTime; }
            set
            {
                if (value >= CreateDateTime) lastModifiedDateTime = value;
                else throw new ArgumentException("Последнее исправление не может быть раньше создания");
            }
        }

        public Project(long id, DateTime createDateTime, DateTime lastModifiedDateTime)
        {
            Id = id;
            CreateDateTime = createDateTime;
            LastModifiedDateTime = lastModifiedDateTime;
        }

        public Project()
        {
            Id = -1;
            CreateDateTime = DateTime.Now;
            LastModifiedDateTime = DateTime.Now;
        }

        public static Project[] SelectAll()
        {
            Project[] temp = new Project[projects.Count];
            projects.CopyTo(temp);
            return temp;
        }

        public static void Insert(Project project)
        {
            projects.Add(project);
        }

        public static void InsertRange(Project[] arrayProjects)
        {
            projects.AddRange(arrayProjects);
        }

        public static void Delete(Project project) 
        {
            projects.Remove(project);
        }
    }
}
