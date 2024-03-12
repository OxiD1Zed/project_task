using Npgsql;
using project_task.Entity;
using System;
using System.Collections.Generic;

namespace project_task.DateBase
{
    public class DB
    {
        private static readonly DB instance = new DB();
        private readonly NpgsqlConnection connection;

        private DB() 
        {
            this.connection = new NpgsqlConnection(Connections.ProjectTask);
        }

        public static DB Instance()
        {
            return instance;
        }

        #region Действия с задачами

        public void CreateTableTask()
        {
            connection.Open();
            using(NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "create table if not exists task " +
                    "(id bigserial not null primary key, " +
                    "id_project bigint not null references project(id) on delete cascade, " +
                    "name text not null, " +
                    "description text not null, " +
                    "is_completed boolean not null)";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public List<Task> SelectTasksByIdProject(long idProject)
        {
            connection.Open();
            using(NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "select * from task where id_project = @IdProject";
                command.Parameters.AddWithValue("@IdProject", idProject);
                
                using(NpgsqlDataReader reader = command.ExecuteReader())
                {
                    List<Task> tasks = new List<Task>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tasks.Add(TaskFromReader(reader));
                        }
                    }

                    connection.Close();
                    return tasks;
                }
            }
        }

        private Task TaskFromReader(NpgsqlDataReader reader)
        {
            long id = reader.GetInt64(reader.GetOrdinal("id"));
            long idProject = reader.GetInt64(reader.GetOrdinal("id_project"));
            string name = reader.GetString(reader.GetOrdinal("name"));
            string description = reader.GetString(reader.GetOrdinal("description"));
            bool isComleted = reader.GetBoolean(reader.GetOrdinal("is_completed"));

            return new Task(id, idProject, name, description, isComleted);
        }

        public long InsertTask(Task task)
        {
            connection.Open();
            using(NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "insert into task (id_project, name, description, is_completed) values (@IdProject, @Name, @Description, @IsCompleted) returning id";
                command.Parameters.AddWithValue("@IdProject", task.IdProject);
                command.Parameters.AddWithValue("@Name", task.Name);
                command.Parameters.AddWithValue("@Description", task.Description);
                command.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
                object result = command.ExecuteScalar();

                connection.Close();
                return (long)result;
            }
        }

        public bool UpdateTask(Task task)
        {
            connection.Open();
            using (NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "update task set name = @Name, description = @Description, is_completed = @IsCompleted, id_project = @IdProject where id = @Id";
                command.Parameters.AddWithValue("@Id", task.Id);
                command.Parameters.AddWithValue("@IdProject", task.IdProject);
                command.Parameters.AddWithValue("@Name", task.Name);
                command.Parameters.AddWithValue("@Description", task.Description);
                command.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
                int result = command.ExecuteNonQuery();

                connection.Close();
                return result > 0;
            }
        }

        public bool DeleteTask(long idTask)
        {
            connection.Open();
            using (NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "delete from task where id = @Id";
                int result = command.ExecuteNonQuery();

                connection.Close();
                return result > 0;
            }
        }

        #endregion

        #region Действия с проектами

        public void CreateTableProject()
        {
            connection.Open();
            using (NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "create table if not exists project (id bigserial not null primary key, create_date_time timestamptz not null, last_modified_date_time timestamptz not null)";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public List<Project> SelectProjects()
        {
            connection.Open();
            using(NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "select * from project";
                using(NpgsqlDataReader reader = command.ExecuteReader())
                {
                    List<Project> projects = new List<Project>();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            projects.Add(ProjectFromReader(reader));
                        }
                    }

                    connection.Close();
                    return projects;
                }
            }
        }

        private Project ProjectFromReader(NpgsqlDataReader reader)
        {
            long id = reader.GetInt64(reader.GetOrdinal("id"));
            DateTime createDateTime = reader.GetDateTime(reader.GetOrdinal("create_date_time"));
            DateTime lastModifiedDateTime = reader.GetDateTime(reader.GetOrdinal("last_modified_date_time"));

            return new Project(id, createDateTime, lastModifiedDateTime);
        }

        public long InsertProject(Project project)
        {
            connection.Open();
            using(NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "insert into project (create_date_time, last_modified_date_time) values (@CreateDateTime, @LastModifiedDateTime) returning id";
                command.Parameters.AddWithValue("@CreateDateTime", project.CreateDateTime);
                command.Parameters.AddWithValue("@LastModifiedDateTime", project.LastModifiedDateTime);
                object result = command.ExecuteScalar();

                connection.Close();
                return (long)result;
            }
        }

        public bool UpdateProject(Project project)
        {
            connection.Open();
            using (NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "update project set last_modified_date_time = @LastModifiedDateTime where id = @Id";
                command.Parameters.AddWithValue("@LastModifiedDateTime", project.LastModifiedDateTime);
                command.Parameters.AddWithValue("@Id", project.Id);
                int result = command.ExecuteNonQuery();

                connection.Close();
                return result > 0;
            }
        }

        public bool DeleteProject(long idProject)
        {
            connection.Open();
            using(NpgsqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "delete from project where id = @Id";
                command.Parameters.AddWithValue("@Id", idProject);
                int result = command.ExecuteNonQuery();

                connection.Close();
                return result > 0;
            }
        }

        #endregion
    }
}
