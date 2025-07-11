using System;
public class Resume
{

    public string _firstName;
    public string _lastName;
    public string _givenNames;
    public List<Job> _jobs = new List<Job>();//Create a list of the custom Job data type
    public void DisplayResume()
    {
      Console.WriteLine($"Name: {_firstName} {_givenNames} {_lastName}");
      Console.WriteLine("Jobs:");
      foreach (Job myjob in _jobs)
      {
        myjob.DisplayMyInfo();
      }
    }
}