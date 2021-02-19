using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAttributeIssue.Shared
{
    public class BreaksDebuggingAttribute : System.Attribute
    {
        public BreaksDebuggingAttribute(MyEnum myEnum)
        {
 
        }
    }

    public enum  MyEnum
    {
        One,
        Two,
        Three,
        Four,
        Five
    }
}
