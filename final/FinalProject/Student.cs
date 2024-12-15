using System.Reflection;
using System.Runtime.CompilerServices;

public class Student
{
    //Private variables include a list of courses, all assignments,
    //as a list of assignments that is updated after they have been organized
    private string _name;
    private List<Course> _allCourses = new List<Course>();
    private List<Assignment> _allAssignments = new List<Assignment>();
    private List<Assignment> _organizedAssignments = new List<Assignment>();

    //Constructor
    public Student(string name)
    {
        _name = name;
    }

    //Standard student information to be printed upon starting the program
    public override string ToString()
    {
        return $"Hello {_name}! We are glad you are a Student here!";
    }

    //Adds a course to the Courses list
    public void AddCourse(Course course)
    {
        _allCourses.Add(course);
    }

    //Creates a new assignment based on user input and adds it to
    //an already-existing course
    public void CreateAssignment(string courseName)
    {
        foreach(Course c in _allCourses)
        {
            if(c.GetCourseName() == courseName)
            {
                Console.WriteLine("Here are the assignment types: \n1. Writing Assignment"+
                "\n2. Discussion\n3. Submission\n4. Quiz\n5. Test");
                Console.Write("Which type of Assignment would you like to create? Enter 1-5: ");
                int type = int.Parse(Console.ReadLine());
                Console.Write("Enter the name of this assignment: ");
                string name = Console.ReadLine();
                Console.Write("How much is this assignment worth? ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("How long in minutes will it take to complete this assignment? ");
                int duration = int.Parse(Console.ReadLine());
                Console.Write("When is this assignment due? Enter how many days from now it is due: ");
                double days = int.Parse(Console.ReadLine());

                //Asks for more input based on the type of Assignment being created
                switch(type)
                {
                    //Writing assignment
                    case 1:
                        Console.Write("Enter a short description of this assignment: ");
                        string des = Console.ReadLine();
                        Console.Write("How many words are you required to write for this? ");
                        int words = int.Parse(Console.ReadLine());
                        c.AddAssignment(new WritingAssignment(name, points, duration, DateTime.Now.AddDays(days), des, words));
                        break;

                    //Discussion assignment
                    case 2:
                        Console.Write("Enter a short description of this assignment: ");
                        string desc = Console.ReadLine();
                        Console.Write("How many words are you required to write for this? ");
                        int wordss = int.Parse(Console.ReadLine());
                        Console.Write("How many responses are you required to have? ");
                        int response = int.Parse(Console.ReadLine());
                        c.AddAssignment(new Discussion(name,points,duration,DateTime.Now.AddDays(days),desc,wordss,response));
                        break;

                    //Submission assignment
                    case 3:
                        Console.Write("What type of document is this? Enter with . format: ");
                        c.AddAssignment(new Submission(name,points,duration,DateTime.Now.AddDays(days),Console.ReadLine()));
                        break;

                    //Quiz assignment
                    case 4:
                        Console.Write("How many questions are in this quiz? ");
                        c.AddAssignment(new Quiz(name,points,duration,DateTime.Now.AddDays(days),int.Parse(Console.ReadLine())));
                        break;
                    
                    //Test
                    case 5:
                        Console.Write("How long in minutes will you have to complete this test? ");
                        int time = int.Parse(Console.ReadLine());
                        Console.Write("How many questions are in this test? ");
                        int ques = int.Parse(Console.ReadLine());
                        c.AddAssignment(new Test(name,points,duration,DateTime.Now.AddDays(days),time,ques));
                        break;

                    default:
                        Console.WriteLine("Invalid entry!");
                        break;
                }
                UpdateAssignmentsList();
                Console.WriteLine("\nAssignment created successfully!");
            }
        }
    }

    //prints list of all courses the Student is currently enrolled in
    public void ViewCourses()
    {
        Console.WriteLine("\nHere are the courses you are currently enrolled in: ");
        int i = 1;
        foreach(Course c in _allCourses)
        {
            Console.WriteLine($"{i}. {c.GetCourseName()}");
            i++;
        }
        Thread.Sleep(3000);
    }

    //Prints all assignments for a specific course that haven't
    //already been completed
    public void ViewCourseAssignments(string courseName)
    {
        bool ran = false;
        foreach (Course c in _allCourses)
        {
            if(c.GetCourseName() == courseName)
            {
                int i = 1;
                foreach(Assignment a in c.GetCourseAssignments())
                {
                    if(!a.IsComplete())
                    {
                        Console.Write($"\n{i}. {a.GetName()} - ");
                        a.PrintAssignmentInfo();
                        i++;
                    }
                }
                ran = true;
            }
        }
        if (!ran)
        {
            Console.WriteLine("You are not currently enrolled in a course with "+
            "that title. Please try again!");
        }
    }

    //Prints percentage and letter grade for a specific course
    public void ViewCourseGrade(string courseName)
    {
        foreach(Course c in _allCourses)
        {
            if(c.GetCourseName() == courseName)
            {
                double percentage = c.CalculateCourseGrade();
                Console.Write($"Here is your grade for this class: ");
                if(percentage > 90) 
                {
                    Console.WriteLine($"{percentage}% - A");
                } 
                else if(percentage > 80) 
                {
                    Console.WriteLine($"{percentage}% - B");
                } 
                else if(percentage > 70) 
                {
                    Console.WriteLine($"{percentage}% - C");
                } 
                else if(percentage > 60) 
                {
                    Console.WriteLine($"{percentage}% - D");
                } 
                else 
                {
                    Console.WriteLine($"{percentage}% - F");
                }
            }
        }
        Thread.Sleep(3000);
    }

    //Prints grade based off all course grades
    public void ViewGPA()
    {
        double totalPercentage = 0;
        foreach(Course c in _allCourses)
        {
            totalPercentage += c.CalculateCourseGrade();
        }
        double average = totalPercentage / _allCourses.Count();
        Console.WriteLine($"Here is your GPA: {average / 25}");
        Thread.Sleep(3000);
    }

    //Empties list to ensure there are no duplicates created,
    //then repopulates it with all incomplete assignments
    private void UpdateAssignmentsList()
    {
        _allAssignments.Clear();
        foreach (Course c in _allCourses)
        {
            foreach(Assignment a in c.GetCourseAssignments())
            {
                if(!a.IsComplete())
                {
                    _allAssignments.Add(a);
                }
            }
        }
    }

    //Allows user to complete assignment and marks complete in course class
    public void MarkAssignmentComplete(string course, string assignment)
    {
        bool ran = false;
        foreach (Course c in _allCourses)
        {
            if(c.GetCourseName() == course)
            {
                foreach(Assignment a in c.GetCourseAssignments())
                {
                    if(a.GetName() == assignment)
                    {
                        a.CompleteAssignment();
                        a.MarkComplete(a.GetDueDate(), c.GetLatePenalty());
                        ran = true;
                        Console.WriteLine($"You have completed this assignment: "+
                        $"{a.GetName()}");
                    }
                }
            }
        }
        if (!ran)
        {
            Console.WriteLine("You are not currently enrolled in a course with "+
            "that title. Please try again!");
        }
    }

    //prints list of all assignments organized by due date
    public void GetCloseAssignments()
    {
        UpdateAssignmentsList();
        _organizedAssignments = _allAssignments.OrderBy(a => a.GetDueDate()).ToList();
        int i = 1;
        foreach (Assignment a in _organizedAssignments)
        {
            Console.WriteLine($"{i}. {a.GetName()} - Due on: {a.GetDueDate().ToShortDateString()}");
            i++;
        }
    }

    //Prints Assignments organized by Priority- calculated first by number,
    //then by a second function that checks certain values, before printing
    public void ShowPriorityList()
    {
        UpdateAssignmentsList();
        foreach(Assignment a in _allAssignments)
        {
            a.CalculateInitialPriority(a);
        }
        _organizedAssignments = _allAssignments.OrderByDescending(a => a.GetPriority()).ToList();

        CalculateFinalPriority(_organizedAssignments);

        int i = 1;
        foreach(Assignment a in _organizedAssignments)
        {
            Console.WriteLine($"{i}. {a.GetName()} - Priority number: {a.GetPriority()}");
            Console.WriteLine($"Points: {a.GetPoints()}, Due Date: {a.GetDueDate().ToString("d")}");
            i++;
        }
    }

    //Swaps two values in a List
    private void Swap(List<Assignment> list, int one, int two)
    {
        (list[one], list[two]) = (list[two], list[one]);
    }

    //Checks values of list to make sure they are where they are supposed to be
    private void CalculateFinalPriority(List<Assignment> all)
    {
        for(int i = 0; i < all.Count - 1; i++)
        {
            //If next assignments' points are higher within a few days from now,
            //move it up
            if((all[i+1].GetPoints() > all[i].GetPoints()) &&
            (all[i+1].GetDueDate() - all[i].GetDueDate()).Days < 2)
            {
                Swap(all, i, i+1);
            }

            //Currently needed, but I'm not sure if it will stay
            //Just for tests to ensure they are ordered by due date correctly
            if((all[i+1].GetType().ToString() == "Test") && (all[i].GetType().ToString() == "Test")
            && ((all[i+1].GetDueDate() - DateTime.Now) < (all[i].GetDueDate() - DateTime.Now)))
            {
                Swap(all, i, i+1);
            }
        }
    }
}