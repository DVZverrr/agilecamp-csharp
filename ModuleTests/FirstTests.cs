using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ModuleTests
{
   public class FirstTests
   {
      [Test]
      public void SuccessTest()
      {
         Assert.AreEqual(10,10);
      }

//      [Test]
//      public void FailTest()
//      {
//         Assert.AreSame(new List<string>(), new object() );
//      }
//
      [Test]
      public void AnotherOneTest()
      {
         int a = 5, b = 10;
         a = a + b;
         b = a - b;
         a = a - b;
         Assert.AreEqual(a,10);
         Assert.AreEqual(b,5);
      }

      [Test]
      public void FailTest2()
      {
         var s = string.Format("{0} isequil {1}", 10, 20); // 10 isequil 20
         Assert.False(s=="10 is equil 10");
      }

      [Test]
      public void SplitTest()
      {
         var s = string.Format("{0} {1} {2}", 10, 20, 30);
         var arr = s.Split(' ');
         Assert.True(arr.Length == 3);
      }

//      [Test]
//      public void RandomTest()
//      {
//         var a = new Random(5);
//         Assert.True(a.Next()==1);
//      }

      [Test]
      public void IfHabitHasNoNameThenException()
      {
         Assert.Throws<NullReferenceException>(() => new Habit());
      }

//      [Test]
//      public void DateTest()
//      {
//         var d = new DateTime(DateTime.Now.Year,2,29);
//         Assert.True(GetType(d));
//      }
   }
}
