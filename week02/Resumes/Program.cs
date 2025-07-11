
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); //Create a new Job object
        //Assign values to the member variables
        Console.Write("What was your job title?  ");
        job1._jobTitle = Console.ReadLine();
        Console.Write("What was the name of your company?  ");
        job1._companyName = Console.ReadLine();
        Console.Write("Enter the start year.  ");
        job1._startYear = int.Parse(Console.ReadLine());
        Console.Write("Enter the end year.  ");
        job1._endYear = int.Parse(Console.ReadLine());
        Job job2 = new Job();//Create another object of the Job class
        //Assign values to the member variables of the Job object
        Console.Write("What was your job title?  ");
        job2._jobTitle = Console.ReadLine();
        Console.Write("What was the name of your company?  ");
        job2._companyName = Console.ReadLine();
        Console.Write("Enter the start year.  ");
        job2._startYear = int.Parse(Console.ReadLine());
        Console.Write("Enter the end year.  ");
        job2._endYear = int.Parse(Console.ReadLine());
        Resume freshResume = new Resume();//Create an object of the Resume class
        //Assign values to the member variables of the Rusumen class
        Console.Write("Enter your first name  ");
        freshResume._firstName = Console.ReadLine();
        Console.Write("Enter your last name  ");
        freshResume._lastName = Console.ReadLine();
        Console.Write("Enter your given names  ");
        freshResume._givenNames = Console.ReadLine();
        freshResume._jobs.Add(job1);//Add the job1 object to the job list
        freshResume._jobs.Add(job2);//Add the job2 object to the job list
        freshResume.DisplayResume();//Call the DisplayResume method of the Resume class
        

    }
}