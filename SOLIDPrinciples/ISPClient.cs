using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    /*
     Clients should not be forced to depend upon the interfaces that they do not need
         */
    public class LegacyClient : IEmployeeService
    {
        public void GetEmployeeDetails()
        {
            // Uses only this method
            
        }
    }

    public class NewClient : IEmployeeService
    {
        public void GetEmployeeDetails()
        {
            // new client require one more method 

        }
    }

    interface IEmployeeService
    {
        void GetEmployeeDetails();
    }

    interface IEmployeeProjectService
    {
        void GetProjectDetails();

    }

    public class FulltimeEmployee : IEmployeeService, IEmployeeProjectService
    {
        public void GetEmployeeDetails()
        {
            //
        }

        public void GetProjectDetails()
        {
            // get prok
        }
    }

    public class ParttimeEmployee :  IEmployeeProjectService
    {

        public void GetProjectDetails()
        {
            // get prok
        }
    }
}
