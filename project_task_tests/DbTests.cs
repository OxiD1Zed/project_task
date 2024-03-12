using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using project_task.DateBase;
using project_task.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace project_task_tests
{
    [TestClass]
    public class DbTests
    {
        private DB db;

        [TestInitialize]
        public void Init()
        {
            db = DB.Instance();
        }

        [TestMethod]
        public void CreateTableProject_without_exception()
        {
            db.CreateTableProject();
        }

        [TestMethod]
        public void CreateTableTask_without_exception()
        {
            db.CreateTableTask();
        }

        [TestMethod]
        public void SelectProjects_returning_true()
        {
            long count = db.SelectProjects().Count;
            Project project = new Project();
            long id = db.InsertProject(project);

            List<Project> projects = db.SelectProjects();

            Assert.IsTrue(count < projects.Count);
            db.DeleteProject(id);
        }

        [TestMethod]
        public void UpdateProject_returning_true()
        {
            Project project = new Project();
            project.Id = db.InsertProject(project);
            db.UpdateProject(new Project(project.Id, project.CreateDateTime, DateTime.Now));
            Project getProject = db.SelectProjects().Where((pr) => pr.Id == project.Id).First();

            Assert.IsTrue(getProject.LastModifiedDateTime != project.LastModifiedDateTime);
            db.DeleteProject(getProject.Id);
        }

        [TestMethod]
        public void DeleteProject_returning_true()
        {
            Project project = new Project();
            project.Id = db.InsertProject(project);
            Project getProject = db.SelectProjects().Where((pr) => pr.Id == project.Id).First();
            db.DeleteProject(project.Id);

            Assert.ThrowsException<ArgumentException>(() => db.UpdateProject(getProject));
        }

        [TestMethod]
        public void InsertProject_returning_true()
        {
            Project project = new Project();
            project.Id = db.InsertProject(project);
            Project getProject = db.SelectProjects().Where((pr) => pr.Id == project.Id).First();

            Assert.IsNotNull(getProject);
        }
    }
}
