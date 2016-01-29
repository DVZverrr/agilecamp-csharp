using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTests
{
   public class Habit
   {
      public string Name { get; set; }

      public Habit()
      {
         throw new NullReferenceException();
      }

      public Habit(string s)
      {
         if (s.Length == 0) throw new NullReferenceException();
         if (s.Length <= 2) throw new ArgumentException();
         Name = string.Format("Привычка: {0}", s);
      }
   }
}
