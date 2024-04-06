using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer
{
    public class LogicClass
    {
    }
    public static class EmailGenerator
    {
        public static string GenerateEmail(string name, string surname)
        {
            string firstLetter = name.Substring(0, 1);
            return $"{firstLetter}{surname}@uj.ac.za".ToLower();
        }
    }
    public static class AgeGenerator
    {
        public static int GenerateAge(string idNumber)
        {
            int firstTwoDigits = int.Parse(idNumber.Substring(0, 2));
            int birthYear;

            if (firstTwoDigits < 22)
            {
                birthYear = 2000 + firstTwoDigits;
            }
            else
            {
                birthYear = 1900 + firstTwoDigits;
            }

            DateTime birthdate = new DateTime(birthYear, int.Parse(idNumber.Substring(2, 2)), int.Parse(idNumber.Substring(4, 2)));
            int age = DateTime.Today.Year - birthdate.Year;

            if (birthdate > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }


}
