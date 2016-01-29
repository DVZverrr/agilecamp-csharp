using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTests
{
   public interface IDataBaseContext
   {
      IQueryable<T> Query<T>();
   }

   public class User
   {
      public int Id { get; set; }
   }

   public class MembershipService
   {
      private readonly IDataBaseContext _dbContext;

      public MembershipService(IDataBaseContext dbContext)
      {
         _dbContext = dbContext;
      }

      public User FindContextUser(int userId)
      {
         User user = _dbContext.Query<User>().SingleOrDefault();

         if(user == null) throw new ArgumentException();

         return user;
      }
   }
}
