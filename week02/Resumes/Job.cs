using System;
public class Job
{
    //Declare the member variaboes of the Job class
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _endYear;
    //Declare the method of the Job class
    public void DisplayMyInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear} - {_endYear}");
    }
}