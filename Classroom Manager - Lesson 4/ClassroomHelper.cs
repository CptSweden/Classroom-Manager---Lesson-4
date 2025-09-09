

namespace Classroom_Manager___Lesson_4
{
    public static class ClassroomHelper
    {
        //case 1
        public static void AddStudent(List<Student> students)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter startlevel: ");
            int level = int.Parse(Console.ReadLine());

            Student studentToAdd = new Student
            {
                Name = name,
                ProgramingLevel = level,
                IsPresent = false,
                Tools = new List<Tool>()
            };

            students.Add(studentToAdd);
            Console.WriteLine($"Student {name} was added to the list");

        }

        //case 2
        public static void MarkAttendance(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students in the list, press any key to continue");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Is the student present? Yes/No");
            for (int i = 0; i < students.Count; i++)
            {
                Console.Write($"{i + 1}. {students[i].Name}: ");
                string response = Console.ReadLine();
                students[i].IsPresent = (response == "YES" || response == "Yes" || response == "yes" || response == "Y" || response == "y");
            }
            Console.WriteLine("Attendance updated, press any key to continue");
            Console.ReadKey();  
            
        }
        //case 3
        public static void  RunLesson(List<Student> students, Tool[] toolList)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No student in the list, press any key to continue");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Choose todays topic");
            for (int i = 0; i < toolList.Length; i++)
            {
                Tool t = toolList[i];
                Console.WriteLine($"[{i + 1}]. {t.Name} | {t.Difficulty} | {t.Description}");
            }

            Console.Write("Topic number: ");
            int choice = int.Parse( Console.ReadLine());

            Tool chosenTool = toolList[choice - 1];
            int level = 5;
            int presentCount = 0;

            foreach (Student s in students)
            {
                if (s.IsPresent)
                {
                    presentCount++;
                    s.ProgramingLevel += level;
                    s.LearnTool(chosenTool);
                }
            }
            if (presentCount > 0)
            {
                Console.WriteLine($"Lecture is finished in {chosenTool.Name}, {presentCount} was taught. All attended students have been updated");
            }
            else
            {
                Console.WriteLine("No students attended");
            }
            Console.WriteLine();
        }

            
        //case 4
        public static void PrintRoster(List<Student> students)
        {
            if(students.Count == 0)
            {
                Console.WriteLine("No students in the list, press any key to continue");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("---Classlist---");
            
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].Name} | Level: {students[i].ProgramingLevel}/100 | Present: {students[i].IsPresent}");
            }

        }

        //case 5
        public static void 

        //case 6
        public static void ResetAttendance(List<Student> students)
        {
            foreach (Student student in students)
            {
                student.IsPresent = false;
            }
            Console.WriteLine("Attandance was reset, press any key to continue");
            Console.ReadKey();
        }

    }
}
