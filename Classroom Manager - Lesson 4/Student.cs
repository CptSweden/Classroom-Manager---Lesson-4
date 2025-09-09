
namespace Classroom_Manager___Lesson_4
{
    public class Student
    {
        public string Name;
        public int ProgramingLevel;
        public bool IsPresent;
        public List<Tool> Tools;

        public void LearnTool(Tool tool)
        {
            bool alreadyHas = false;

            foreach (Tool t in Tools)
            { 
                if (t.Name == tool.Name)
                {
                    alreadyHas = true;
                    break;
                }
            }

            if (!alreadyHas)
            {
                Tools.Add(tool);
            }
        }

    }
}
