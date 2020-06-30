using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_FinalProject.Models;
namespace WindowsForm_FinalProject.Controllers
{
    class StudentProjectController
    {
        public claData data = new claData();
        public DataTable getproject(string IDStudent)
        {
            //DataTable check = data.readdata("select * from Project WHERE PID in ( SELECT Project_PID FROM StudentProjects WHERE Student_ID='" + IDStudent + "');");
            DataTable check = data.readdata("Select distinct(Project.PID), Project.PName, Project.PContent, Project.PType, Project.PBegin, Project.PEnd, Score.score, Score.comment " +
                "from Project Left Join Score ON(Project.PID = Score.PID)"+
                "Where Project.PID in (SELECT Project_PID FROM StudentProjects WHERE Student_ID = '" + IDStudent + "');");

            return check;
        }
        public DataTable getInfoProjectName(string IDStudent)
        {
            DataTable dt = data.readdata("select * from Project WHERE PID in ( SELECT Project_PID FROM StudentProjects WHERE Student_ID='" + IDStudent + "');");
            return dt;
        }

        //public int getIDProject(string PName)
        //{
        //    DataTable dt = data.readdata("select PID from Project WHERE PName ='" + PName + "');");
        //    return dt;
        //}
    }
}
