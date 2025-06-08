using MySql.Data.MySqlClient;
using SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Connection.DAL
{
    internal class AgentDal
    {




        public void AddAgent(Agent agent)
        {
            try
            {
                using MySqlConnection conn = DBConnection.Connect();
                string sql = $"INSERT INTO agents (codeName, realName, location, Astatus, missionsCompleted)" +
                    $" VALUES ('{agent.CodeName}', '{agent.RealName}', '{agent.Location}', '{agent.AStatus}', {agent.MissionsCompleted})";
                DBConnection.ExecuteNonQuery(sql, conn);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ADD ERROR] Could not add agent: {ex.Message}");
            }
        }


        public List<Dictionary<string, object?>> GetAllAgents()
        {
            using MySqlConnection conn = DBConnection.Connect();
            string sql = "SELECT * FROM agents";
            var rows = DBConnection.Execute(sql, conn); 
            return rows;
        }




        public void UpdateAgentLocation(int agentId, string newLocation)
        {
            using MySqlConnection conn = DBConnection.Connect();
            string sql = $"UPDATE agents\r\nSET location ='{newLocation}' WHERE id ='{agentId}'";
            DBConnection.ExecuteNonQuery (sql, conn);

            
        }

        public void DeleteAgent(int agentId)
        {
            using MySqlConnection conn = DBConnection.Connect();
            string sql = $"DELETE from agents WHERE id ='{agentId}'";
            DBConnection.ExecuteNonQuery(sql, conn);

        }
    }


}

