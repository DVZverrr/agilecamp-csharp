using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace ModuleTests
{
    public class MembershipServiceTests
    {
       private Mock<IDataBaseContext> _dataBaseContext;

       public MembershipServiceTests()
       {
        _dataBaseContext = new Mock<IDataBaseContext>();
      }

      [Test]
       public void IfUserNotFound_ThrowArgumentException()
       {
         _dataBaseContext.Setup(x => x.Query<User>()).Returns(new List<User>().AsQueryable());

          var membershipService = new MembershipService(_dataBaseContext.Object);
          Assert.Throws<ArgumentException>(() => membershipService.FindContextUser(1));
//         dataBaseContext.Verify(x => x.Query<>());
       }

       [Test]
       public void IfUserFound_ThrowArgumentException()
       {
         _dataBaseContext.Setup(x => x.Query<User>()).Returns(new List<User>() {new User() {Id = 1} }.AsQueryable());
        
         var membershipService = new MembershipService(_dataBaseContext.Object);
          var findContextUser = membershipService.FindContextUser(1);
          Assert.NotNull(findContextUser);
      }
    }
}
