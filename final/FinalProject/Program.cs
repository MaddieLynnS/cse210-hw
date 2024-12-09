using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine(english.GetType().ToString());

        // if (english.GetType().ToString() == "Course")
        // {
        //     Console.WriteLine("Hooray- you did it.");

        // }
        //Have student enter name, retrieve proper txt file
         //Student file will resave itself upon learner quitting,
        //ensuring any assignment updates will be saved

        List<int> ints = new List<int>
        {1, 4, 60, 44, 20, 12, 33};

        List<int> sortedInts = ints.OrderByDescending(i => i).ToList();

        foreach(int i in sortedInts)
        {
            Console.Write($"{i}, ");
        }

        // for (int i = 0; i < ints.Count(); i++)
        // {
        //     if(ints[i+1] > ints[i])
        //     {

        //     }
        // }



        Student user = new Student("Bob");
        Course english = new Course("Eng 101");
        Course science = new Course("Sci 220");
        Course coding = new Course("Intro to Programming 101");
        Course math = new Course("Math for Dummies");
        user.AddCourse(english);
        user.AddCourse(science);
        user.AddCourse(coding);
        user.AddCourse(math);

        //EXAMPLE ASSIGNMENTS CREATED BY CHATGPT, then tailored and added by me
        english.AddAssignment(new WritingAssignment("Essay on Climate Change", 100, 120, DateTime.Now.AddDays(7), "Climate change in Malaysia in the 1500s", 500));
        english.AddAssignment(new WritingAssignment("Book Analysis: '1984' by George Orwell", 75, 90, DateTime.Now.AddDays(10), "Explain your thoughts on this book", 1000));
        english.AddAssignment(new Submission("Portfolio Submission: Creative Writing Samples", 120, 150, DateTime.Now.AddDays(12), "docx"));
        english.AddAssignment(new Test("Midterm Exam: English Literature", 200, 120, DateTime.Now.AddDays(20), 120, 60));

        science.AddAssignment(new Discussion("Peer Discussion: Impact of Globalization on Culture", 40, 30, DateTime.Now.AddDays(6), "Respond to others' comments on this topic", 50, 3));
        science.AddAssignment(new Submission("Submit Lab Report: Chemical Reactions", 90, 60, DateTime.Now.AddDays(4), ".jpg"));
        science.AddAssignment(new Quiz("Quiz: World Geography", 25, 25, DateTime.Now.AddDays(3), 45));
        science.AddAssignment(new Test("Final Test: Physics Principles", 250, 180, DateTime.Now.AddDays(30), 120, 50));

        coding.AddAssignment(new WritingAssignment("Research Paper: Artificial Intelligence in Healthcare", 150, 180, DateTime.Now.AddDays(14), "Describe what you found while studying this topic and your opinions", 400));
        coding.AddAssignment(new Discussion("Forum Discussion: Ethical Dilemmas in Technology", 50, 45, DateTime.Now.AddDays(3), "Discuss one of the ethical dilemmas you've noticed", 100, 3));
        coding.AddAssignment(new Discussion("Class Debate: Should Social Media Be Regulated?", 60, 60, DateTime.Now.AddDays(5), "Take a side, cite evidence, and stick with it!", 300, 2));
        coding.AddAssignment(new Submission("Art Project: Digital Poster Design", 100, 120, DateTime.Now.AddDays(9), ".jpg"));
        coding.AddAssignment(new Quiz("Quiz: Introduction to Programming", 30, 20, DateTime.Now.AddDays(5), 20));
        
        math.AddAssignment(new Quiz("Pop Quiz: Basic Algebra", 20, 15, DateTime.Now.AddDays(2), 15));
        math.AddAssignment(new Test("Comprehensive Test: Math in all Forms", 180, 150, DateTime.Now.AddDays(25), 90, 45));

        //Console.Clear();
        Console.WriteLine(user.ToString());
        Console.WriteLine("Welcome to your account! Here you can view grades,"+
        " check assignment due dates, and turn in assignments! \nYou can also"+
        " see a list of all your assignments in order of which you should do first!");
        Thread.Sleep(3000);

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //Main Loop
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        int userInput = 0;
        while (userInput != 9)
        {

            //Standard menu options
            Console.WriteLine("\nHere are the options you can choose from: ");
            Console.WriteLine("1. See courses");
            Console.WriteLine("2. See assignments for a certain course");
            Console.WriteLine("3. See all assignments (ordered by due date)");
            Console.WriteLine("4. See PRIORITIZED list of assignments");
            Console.WriteLine("5. See grades for a certain course");
            Console.WriteLine("6. See overall GPA");
            Console.WriteLine("7. Complete an assignment");
            Console.WriteLine("8. Create a new assignment");
            Console.WriteLine("9. Quit");

            Console.Write("What would you like to do? Enter a number 1-9: ");
            string input = Console.ReadLine();

            //Error handling- makes user enter a number
            while(true)
            {
                if(int.TryParse(input, out userInput))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Try again! ");
                    input = Console.ReadLine();
                }
            }


            //Switch case for all menu options    
            switch(userInput)
            {
                //Allows user to see all courses they are currently in
                case 1:
                    user.ViewCourses();
                    break;

                //Shows user what assignments they have for a certain class
                case 2:
                    Console.Write("Enter the course containing the assignments you "+
                    "would like to see: ");
                    string courseInput = Console.ReadLine();
                    user.ViewCourseAssignments(courseInput);
                    break;
                
                //Show user all assignments for all classes, ordered by due date
                case 3:
                    user.ShowCloseAssignments();
                    break;

                //Shows user all assignments ordered by priority
                case 4:
                    user.ShowPriorityList();
                    break;

                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                //This is maybe needing to be fixed I guess?? Just so menu doesn't reprint
                    Console.WriteLine("Your entry was outside the indicated range. Try again!");
                    break;
            }
        }
    }
}