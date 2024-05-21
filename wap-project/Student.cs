using System;

public class Student
{

	#region Attributes
	private int _id;
	private string _firstName;
	private string _lastName;
	private string _email;
	private bool _isPayingTax;

    #endregion

    #region propertiesForAtrributes
    public int Id
	{ 
		get { return _id; }
		set { _id = Id; }
	}
	//
	public string FirstName 
	{ 
		get { return _firstName; }
		set {
			if (string.IsNullOrEmpty(_firstName))
				throw Exception("This field is mandatory.");
			else if (_firstName.Length > 30 && _firstName.Length < 3)
				throw Exception("The value you entered is invalid.");
			else
				_firstName = FirstName;
        }; 
	}
	//
	public string LastName 
	{
		get { return _lastName; }
		set {
			if (string.IsNullOrEmpty(_lastName))
				throw Exception("This field is mandatory.");
			else if (_lastName.Length > 30 && _lastName.Length < 3)
				throw Exception("The value you entered is invalid.");
			else 
				_lastName = LastName;
		}; 
	}
	//
	public string Email { get; set; }
	//
    #endregion



    public Student()
	{
		this.Id = 0;	
	}//end constructor without parameters
	//



	public Student(int id, string FirstName, string LastName, string Email) 
	{
		_id = id;
		_firstName = FirstName;
		_lastName = LastName;
		_email = Email;
	}//end constructor
	//
}//end class
