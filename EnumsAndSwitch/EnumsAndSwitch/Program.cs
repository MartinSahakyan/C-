using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> todos = new List<ToDo>()
            {
                new ToDo { Description = "Task 1", EstimatedHours = 6, Status = Status.Completed },
                new ToDo { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress },
                new ToDo { Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted },
                new ToDo { Description = "Task 4", EstimatedHours = 12,Status = Status.Deleted },
                new ToDo { Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress },
                new ToDo { Description = "Task 6", EstimatedHours = 2, Status = Status.NotStarted },
                new ToDo { Description = "Task 7", EstimatedHours = 14, Status = Status.OnHold },
                new ToDo { Description = "Task 8", EstimatedHours = 8, Status = Status.Completed },
               
            };
            Console.ForegroundColor = ConsoleColor.DarkRed;

            PrintAssessment(todos);
            Console.ReadLine();
        }
        private static void PrintAssessment(List<ToDo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);


            }
        }
    }
}
