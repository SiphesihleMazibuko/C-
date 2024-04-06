using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace Data_Layer
{
    public class DataClass
    {
    }
    public static class AccesFile
    {
        private const string filepath = "Staff.txt";

        public static void SaveStaffMember(string data)
        {
             File.AppendAllText(filepath, data + "\n");
        }
        public static string ReadStaffMembers()
        {
            return File.ReadAllText(filepath );
        }
    }

   

}


