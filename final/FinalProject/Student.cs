using System.Reflection;
using System.Runtime.CompilerServices;

public class Student
{
    private string _name;
    private List<Course> _allCourses = new List<Course>();
    private List<Assignment> _allAssignments = new List<Assignment>();
    private List<Assignment> _organizedAssignments = new List<Assignment>();

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
                        Console.Write($"\n{i}. ");
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

    public void ViewCourseGrade(string courseName)
    {
        foreach(Course c in _allCourses)
        {
            if(c.GetCourseName() == courseName)
            {
                Console.WriteLine($"Here is your grade for this class: "+
                $"{c.CalculateCourseGrade()}");
            }
        }
        Thread.Sleep(3000);
    }

    //Empties list to ensure there are no duplicates created
    //Maybe in future I create thing that just checks new assignments
    //against existing list??
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

    public void MarkAssignmentComplete(string course, int i)
    {
        bool ran = false;
        foreach (Course c in _allCourses)
        {
            if(c.GetCourseName() == course)
            {
                c.GetCourseAssignments()[i-1].MarkComplete();
                ran = true;
                Console.WriteLine($"You have completed this assignment: "+
                $"{c.GetCourseAssignments()[i-1].GetName()}");
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

    private void Swap(List<Assignment> list, int one, int two)
    {
        (list[one], list[two]) = (list[two], list[one]);
    }

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

            //Probably need one for if assignment is due way more days than a test

            //also one for if a course grade is lower in one class than in another
        }

    }


}