using System;
using System.Drawing;

namespace wap_project.Classes
{
    [Serializable]
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
            return SubjectName + " -> Number of years the subject has: " + Years;
        }

        public int stringToNumber(string subjectName)
        {
            switch (subjectName.Length)
            {
                case (10):
                    return 1;
                case(11):
                    return 2;
                case (20):
                    return 3;
                case (32):
                    return 4;
                default:
                    return 4;
            }
        }
    }//end class
}

