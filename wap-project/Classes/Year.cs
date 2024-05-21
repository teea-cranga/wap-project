using System;
using System.Collections.Generic;

namespace wap_project.Classes
{

    public class Year
    {
        #region Attributes
        public DateTime StartingYear { get; set; }
        public DateTime EndingYear { get; set; }
        public List<Student> StudentsFromYear { get; set; }
        #endregion

        public Year()
        {
            StudentsFromYear = new List<Student>();        
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
    }//END CLASS
}

