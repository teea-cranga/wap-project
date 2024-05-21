using System;
using System.Collections.Generic;

namespace wap_project.Classes
{
    [Serializable]
    public class Year
    {
        #region Attributes
        public DateTime StartingYear { get; set; }
        public DateTime EndingYear { get; set; }
        public List<Student> StudentsFromYear { get; set; }
        #endregion

        public Year()
        {
            StartingYear = DateTime.Now;
            StudentsFromYear = new List<Student>();
            EndingYear = DateTime.Now.AddYears(3);
        }

        public Year(DateTime startingYear, List<Student> studentsFromYear)
        {
            StartingYear = startingYear;
            EndingYear = startingYear;
            EndingYear.AddYears(3);
            StudentsFromYear = studentsFromYear;
        }

        public int returnYear(DateTime startOrEnd) 
        {
            return startOrEnd.Year;
        }

        public override string ToString()
        {
            return returnYear(StartingYear) + " - " + returnYear(EndingYear); 
        }
    }//END CLASS
}

