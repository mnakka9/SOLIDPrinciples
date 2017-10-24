using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class LSV
    {
        /*
        A Subclass should behave in such a way that it should not cause any problems
        if it is replaced with base class.

        */

        public void Main()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new PermanentEmployee());
            employeeList.Add(new ContractualEmployee());

            foreach(var employee in employeeList)
            {
                employee.GetUserDetails();
            }
        }
    }

    

    public abstract class Employee
    {
        public abstract void GetUserDetails();
        public abstract void GetProjectDetails();
    }

    public class PermanentEmployee : Employee
    {
        public override void GetProjectDetails()
        {
            //Get Details
        }

        public override void GetUserDetails()
        {
            // Get Details
        }
    }

    public class ContractualEmployee : Employee
    {
        public override void GetProjectDetails()
        {
            //Get Details
        }

        public override void GetUserDetails()
        {
            throw new NotSupportedException("Contractual users data will not be stored in database");
        }
    }
}
