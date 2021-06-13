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
    public class LegacyClient : ILegacyEmployeeService
    {
        public void GetEmployeeDetails()
        {
            // Uses only this method
        }

        public void GetProjectDetails()
        {
            throw new NotImplementedException();
        }
    }

    public class NewClient : ILegacyEmployeeService
    {
        public void GetEmployeeDetails()
        {
            // new client require one more method

        }

        public void GetProjectDetails()
        {
            // this method only used in here
        }
    }

    interface ILegacyEmployeeService
    {
        void GetEmployeeDetails();
        void GetProjectDetails();
    }

    interface IEmployeeService
    {
        void GetEmployeeDetails();
    }

    interface IEmployeeProjectService
    {
        void GetProjectDetails();

    }

    public class NewClientISP : IEmployeeService, IEmployeeProjectService
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

    public class LegacyCln :  IEmployeeProjectService
    {

        public void GetProjectDetails()
        {
            // get prok
        }
    }
}
