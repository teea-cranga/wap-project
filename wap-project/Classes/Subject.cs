using System;

namespace wap_project.Classes
{

    public class Subject
    {
        public string SubjectName { get; set; }
        public int Credits { get; set; }
        //
        public Subject(){}
        //
        public Subject(string subjectName, int credits)
        {
            SubjectName = subjectName;
            Credits = credits;
        }
        //
    }//end class
}

