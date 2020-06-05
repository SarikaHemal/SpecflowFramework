using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.Base
{
    public class FrameworkHooks
    {
        public void IntialSetup(IObjectContainer objectContainer)
        {
            _ = new WebDriverContext(objectContainer);
            _ = new ExtendReportContext();
        }
    }
}


