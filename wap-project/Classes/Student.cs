using System;
using System.Collections.Generic;

namespace wap_project.Classes
{
    [Serializable]

    public class Student
    {
        #region Attributes
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public Subject Subject { get; set; }    
        #endregion

        public Student()
        {
        }//end constructor without parameters
         //
        public Student(int id, string firstName, string lastName, Subject subject)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }//end constructor with all parameters
         //

    }//end class
}

