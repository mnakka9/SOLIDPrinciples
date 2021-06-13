using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    /*

        A Class should have single responsibility and should be changed only
        for single reason.

     */

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class NoSRP
    {
        public bool Add(User user)
        {
            // adds user to database
            return true;
        }

        public void GenerateReport(User user)
        {
            //generate report
        }
    }


    public class UserSRP
    {
        public bool Add(User user)
        {
            // adds user to database
            return true;
        }

    }

    public class ReportSRP
    {
        public void GenerateReport(User user)
        {
            //generate report
        }
    }
}
