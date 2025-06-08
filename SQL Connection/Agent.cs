using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Connection
{
    class Agent
    {
        public int Id { get; set; }
        public string CodeName { get; set; }
        public string RealName { get; set; }
        public string Location { get; set; }
        public string AStatus { get; set; }
        public int MissionsCompleted { get; set; }

        public Agent(string codeName, string realName, string location, string status, int missionsCompleted)
        {
            
            CodeName = codeName;
            RealName = realName;
            Location = location;
            AStatus = status;
            MissionsCompleted = missionsCompleted;
        }
    }

}