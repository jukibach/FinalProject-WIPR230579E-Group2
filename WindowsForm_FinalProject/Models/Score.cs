using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsForm_FinalProject.Models
{
    class Score
    {

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=DBProject;Integrated Security=True");
        public bool createScoreTable()
        {
            try
            {
                con.Open();
                SqlCommand cmds = new SqlCommand("CREATE table Score(ID varchar(MAX), PID int not null primary key, score float, comment varchar(MAX))", con);

                if (cmds.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool insertScore(string ID, int PID, double score, string comment)
        {
            con.Open();
            SqlCommand cmds = new SqlCommand("INSERT INTO Score(ID, PID, score, comment) VALUES ('"+ID+"','" + PID + "','" + score + "','" +comment +"')", con);
        
            
            if (cmds.ExecuteNonQuery() == 1)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
