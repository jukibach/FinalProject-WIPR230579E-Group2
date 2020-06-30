using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Controllers
{
     public class ProjectController
    {
        public claData data = new claData();
        public static bool checkExistProject(int PID)
        {
            using (var _context = new DBProjectsEntities())
            {
                var student = from u in _context.Projects
                              where u.PID == PID
                              select u;
                if (student.Count() == 1)
                {
                    return true;
                }

                return false;

            }
        }
        public static Project getExistProject(int PID)
        {
            using (var _context = new DBProjectsEntities())
            {
                var student = from u in _context.Projects
                              where u.PID == PID
                              select u;
                if (student.Count() == 1)
                {
                    return student.Single();
                }

                return null;

            }
        }
        public static bool AddProject(Project project)
        {
          
                using (var _context = new DBProjectsEntities())
                {
                    foreach(var u in project.Students)
                    {
                        var student = (from x in _context.Students
                                       where x.ID == u.ID
                                       select x).SingleOrDefault();
                        student.Projects.Add(project);
                    }
                    project.Students.Clear();
                    _context.Projects.AddOrUpdate(project);
                    _context.SaveChanges();
                    return true;
                }
           
        }
        public static List<Project> getAllProject()
        {
            using (var _context = new DBProjectsEntities())
            {
                var projects = (from u in _context.Projects.AsEnumerable()
                                select new
                                {
                                    PID = u.PID,
                                    PName = u.PName,
                                    PContent = u.PContent,
                                    PType = u.PType,
                                    PBegin = u.PBegin,
                                    PEnd = u.PEnd,
                                     //
                                    Students = u.Students,

                                })
                            .Select(x => new Project
                            {
                                PID = x.PID,
                                PName = x.PName,
                                PContent = x.PContent,
                                PType = x.PType,
                                PBegin = x.PBegin,
                                PEnd = x.PEnd,
                                //
                                Students = x.Students,
                            });
                return projects.ToList();


            }
        }
        public static bool DeleteProject(int PID)
        {

            using (var _context = new DBProjectsEntities())
            {
                var project = (from u in _context.Projects
                                where u.PID == PID
                               select u).SingleOrDefault();

                _context.Projects.Remove(project);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool UpdateProject(Project projectadd, ListBox list)
        {
            using (var _context = new DBProjectsEntities())
            {
                var project = (from u in _context.Projects
                               where u.PID == projectadd.PID
                               select u).SingleOrDefault();
                project.PName = projectadd.PName;
                project.PContent = projectadd.PContent;
                project.PType = projectadd.PType;
                project.PBegin = projectadd.PBegin;
                project.PEnd = projectadd.PEnd;

                //project.Students.Clear();
                //bool IsListIDClicked = IsEventFired(lstIDs_DoubleClick);
                for (int i = 0; i < list.Items.Count; i++)
                {
                    project.Students.Add(list.Items[i] as Student); //ID
                }
                //project.Score = projectadd.Score;
                //project.Comment = projectadd.Comment;
                //_context.Projects.AddOrUpdate(project);
                _context.SaveChanges();
                return true;
            }
        }
        //}
        //     catch (Exception ex)
        //    {
        //        return false;
        //    }
public static int getIDfromDB()
        {
            using (var _context = new DBProjectsEntities())
            {
                var listid = (from t in _context.Projects
                              select t.PID).ToList();

                //return int.Parse(listid.Max()) + 1;

                int maxID = listid.Max() + 1;
                int i;
                for (i = 1; i <= maxID; i++)
                {
                    if (listid.Where(x => x == i).Count() <= 0)
                    { return i; }
                }
                return i + 1;
            }
        }
        public static bool UpdateScore(Project projectadd, string student_id)
        {

            using (var _context = new DBProjectsEntities())
            {
                //_context.Database.ExecuteSqlCommand("update ScoreProject set ScoreProject.score = '" + projectadd.Score + "', ScoreProject.comment = '" + projectadd.Comment + "' where ScoreProject.PID = '" + projectadd.PID + "';");
                try {
                    
                    _context.Database.ExecuteSqlCommand("delete from Score where Score.PID = " + projectadd.PID + ";" +
                "\ninsert Score(Score.ID, Score.PID,Score.score,Score.comment) values ('" + student_id + "'," + projectadd.PID + ", "+ Decimal.Parse(projectadd.Score.ToString()) + ",NULL); " +
                "\nupdate Score set Score.score = case when Score.score = 0.0 then 0.0 else "+ Decimal.Parse(projectadd.Score.ToString()) + " end, Score.comment = '" + projectadd.Comment + "' where Score.PID = " + projectadd.PID + ";");

                    //project.Students.Clear();
                    //bool IsListIDClicked = IsEventFired(lstIDs_DoubleClick);
                    //project.Score = projectadd.Score;
                    //project.Comment = projectadd.Comment;
                    //_context.Projects.AddOrUpdate(project);
                    //_context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            //DataTable dt = data.readdata("update Score set '" + projectadd.Score + "', '" + projectadd.Comment + "'" +
            //    "where PID='" + projectadd.PID + "';)");
            //return dt;
        }
    }
}
