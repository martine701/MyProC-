using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithBitwiseOperations
{
    [Flags]    
    public enum ContactPreferenceEnum
    {
    None = 0,
    Email = 1,
    Text = 2,
    Phone = 4,
    Mail = 8,
    All = Email | Text | Phone | Mail
    }
}
