using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SQL_Connection;
using SQL_Connection.DAL;

namespace SQL_Connection.DAL
{
    class Program
    {



        static void Main(string[] args)
        {


            Agent agent = new Agent("123", "david", "asdod", "Active", 1);
            AgentDal agentDal = new AgentDal();
            agentDal.DeleteAgent(4);

            var agents = agentDal.GetAllAgents();
            foreach (var row in agents)
            {
                foreach (var col in row)
                    Console.WriteLine($"{col.Key}: {col.Value}");
                Console.WriteLine("---");
            }

            // Update
            agentDal.UpdateAgentLocation(1, "Jerusalem");

            // Delete
            agentDal.DeleteAgent(1);
        }
    }




}







