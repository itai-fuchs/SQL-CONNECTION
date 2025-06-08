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
            

            
        }
    }




}







