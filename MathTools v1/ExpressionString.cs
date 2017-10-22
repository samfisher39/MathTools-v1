using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotting_Try
{
    public class ExpressionString
    {
        public string expression { get; set; }

        public ExpressionString()
        {
            expression = "";
        }

        public ExpressionString(string str)
        {
            expression = str;
        }
    }
}
