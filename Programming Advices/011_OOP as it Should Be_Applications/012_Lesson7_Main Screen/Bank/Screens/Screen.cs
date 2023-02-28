using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Bank.Screens
{
    public class Screen
    {
        protected static void _DrawScreenHeader(string Title, string SubTitle = "")
        {
            Console.Write("\t\t\t\t\t______________________________________");
            Console.Write("\n\n\t\t\t\t\t  " + Title);
            if (SubTitle != "")
            {
                Console.Write("\n\t\t\t\t\t  " + SubTitle);
            }
            Console.Write("\n\t\t\t\t\t______________________________________\n\n");
        }

    }
}
