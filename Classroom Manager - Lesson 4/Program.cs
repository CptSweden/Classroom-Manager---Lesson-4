namespace Classroom_Manager___Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of tools that should be taught during the education
            Tool[] toolCatalog = new Tool[]
            {
                new Tool {Name = "C#", Description = "Basic programing", Difficulty = 5},
                new Tool {Name = "Git", Description = "Source control", Difficulty = 5},
                new Tool {Name = "SQL", Description = "Relation database", Difficulty = 5},
                new Tool {Name = "Debugging", Description = "Solve problems", Difficulty = 5},
                new Tool {Name = "JavaScipt", Description = "Poop", Difficulty = 5},
            };

            //List of student, empty for now
            List<Student> students = new List<Student>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("---Classroom Simulator---");
                Console.WriteLine("[1] Add student");
                Console.WriteLine("[2] Take attendance");
                Console.WriteLine("[3] Run lecture (Choose tool)");
                Console.WriteLine("[4] Show student list");
                Console.WriteLine("[5] Show induvidual student details");
                Console.WriteLine("[6] Reset attendece list");
                Console.WriteLine("[7] Exit program");
                Console.Write("Option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ClassroomHelper.AddStudent(students);
                        break;
                    case 2: 
                        ClassroomHelper.MarkAttendance(students);
                        break;
                    case 3: 
                        ClassroomHelper.RunLesson(students); 
                        break;
                    case 4: ClassroomHelper.PrintRoster(students);
                        break;
                    case 5: 
                        Console.WriteLine("Show individual student");
                        break;
                    case 6:
                        ClassroomHelper.ResetAttendance(students);
                        break;
                    case 7: 
                        Console.WriteLine("Exit");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }


        }
    }
}
