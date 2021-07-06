using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Classes
{
    public static class StringHelpers
    {
public static string SplitCamelCase(this string sender) => 
    Regex.Replace(Regex.Replace(sender, 
        "(\\P{Ll})(\\P{Ll}\\p{Ll})", "$1 $2"), 
        "(\\p{Ll})(\\P{Ll})", "$1 $2");
    }
}
