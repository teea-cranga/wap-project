using System;

public class Year
{
    #region Attributes
    private DateTime _startingYear;
	private DateTime _endingYear;
	private string _subjectName;
	private list<Student> _studentsFromYear;
    #endregion
    //
    #region getSet
    public list<Subject> StudentsFromYear { 
		get { return _studentsFromYear; }
		set { _studentsFromYear = StudentsFromYear; }
	}
    public DateTime StartingYear 
    {
        get { return _startingYear; }
        set 
        {
            if (_startingYear.Year < 2021 || _startingYear.Year > 2024)
            {
                throw Exception("Invalid year. Try again.");
            }
            _startingYear = StartingYear; 
        }  
    }

    public DateTime EndYear
    {
        get { return _endingYear; }
        set
        {
            if (_endingYear.Year < 2024 || _endingYear.Year >= 2050)
            {
                throw Exception("Invalid year. Try again.");
            }
            _endingYear = EndYear;
        }
    }
    #endregion
    //
    public Year()
	{
		
	}

}//END CLASS
