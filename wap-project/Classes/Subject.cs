using System;

namespace wap_project.Classes
{

    public class Subject
    {
        public string SubjectName { get; set; }
        public int Years { get; set; }
        //
        public Subject(){}
        //
        public Subject(string subjectName, int years)
        {
            SubjectName = subjectName;
            Years = years;
        }
        //
        override public string ToString()
        { 
            return SubjectName + " no. Years: " + Years;
        }
    }//end class
}

