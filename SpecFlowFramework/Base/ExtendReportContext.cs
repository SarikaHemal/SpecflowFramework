using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using SpecFlowFramework.Utils;

namespace SpecFlowFramework.Base
{
    public class ExtendReportContext
    {
        public static AventStack.ExtentReports.ExtentReports ExtentReports { get; set; }
        public static ExtentTest test { get; set; }
        public ExtendReportContext()
        {
            ExtentReports = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(ConstantUtils.ReportsPath);
            htmlReporter.LoadConfig(ConstantUtils.ReportXMLPath);
            ExtentReports.AttachReporter(htmlReporter);
           
        }
    }
}