public class Student
{
    private List<Course> _allCourses = new List<Course>();
    //not sure yet if I need this? The courses would have all the assignments
    //but it does make sense to add them to a masterlist of sorts
    //private List<Assignment> _allAssignments = new List<Assignment>();


    //prints list of all courses the Student is currently enrolled in
    public void ViewCourses()
    {
        int i = 1;
        foreach(Course c in _allCourses)
        {
            Console.WriteLine($"{i}. {c.GetCourseName()}");
            i++;
        }
    }

    //prints list of assignments with due dates in the next week
    //I don't need to save this list for any reason, so I just print it here
    public void ShowCloseAssignments()
    {
        //prints assignments from all courses that are due
        //within the next week
    }





    //Prioritize assignments in following order?
    //Closest to farthest due date of course
    //Tests should always go on top
    //Assignments with high priority will be just beneath any tests - i think this could be removed
    //Assignments worth more points should trump low points
    //if due within three days of each other
    //Assignments that take longer to complete should trump
    //assignments with similar points/due dates
    //Assignments from the course with the lower overall grade
    //should trump any short, low-point assignments

    //Example implementing the above logic
    //1- quiz due on 12/8 worth 40 points, takes 15 minutes
    //2- writing due on 12/5 worth 100 points, takes five hours
    //3- submit pic due on 12/6 worth 20 points, takes 5 minutes
    //4- writing due on 12/9 worth 50 points, takes 2 hours
    //5- discussion due on 12/6 worth 40 points, takes 30 minutes
    //6- test due 12/7 worth 100 points, takes an hour
    //7- submit doc due on 12/5 worth 30 points, takes 20 minutes
    //8- discussion due on 12/7 worth 20 points, takes 20 minutes
    //9- test due 12/5 worth 50 points, takes an hour

    //initial step- order by due dates?
    //due dates- 2,7,9,3,5,6,8,1,4
    //tests move to top - 9,6,2,7,3,5,8,1,4
    //move up assignments on same day worth more points
    //6,9,2,7,5,3,8,1,4
    //if next day (or two days out) assignment is worth more, move it up
    //- 6,9,2,5,7,1,3,4,8
    //if assignment takes a lot longer to complete, move it up
    //- 6,9,2,5,7,1,4,3,8
    //if assignment comes from a course with a lower grade, it moves up

}