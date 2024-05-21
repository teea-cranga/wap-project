using System;
using System.Collections.Generic;

namespace wap_project.Classes
{
    [Serializable]

    public class Student
    {
        #region Attributes
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public Subject Subjects { get; set; }    
        #endregion

        public Student()
        {
        }//end constructor without parameters
         //
        public Student(string firstName, string lastName, Subject subjects)
        {
            FirstName = firstName;
            LastName = lastName;
            Subjects = subjects;
        }//end constructor with all parameters
         //

    }//end class
}

