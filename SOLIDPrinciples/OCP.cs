using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    class OCP
    {
        /*
     A class should be closed for modification and open for extension

      */
    }

    public class ReportServiceNOCP
    {
        public virtual void GenerateReport(User user)
        {
            // Generates report crystal report
        }
    }

    public class ExcelReportService : ReportServiceNOCP
    {
        public override void GenerateReport(User user)
        {
            // Generate excel report
        }
    }

    public class PDFReportService : ReportServiceNOCP
    {
        public override void GenerateReport(User user)
        {
            // Generate PDF report
        }
    }
}
