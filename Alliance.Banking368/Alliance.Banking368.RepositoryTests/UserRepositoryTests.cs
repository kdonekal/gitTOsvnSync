using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alliance.Banking368.Data.Repositories;
using Alliance.Banking368.Domain;
using Alliance.Banking368.Data.Repositories.Interfaces;
using Alliance.Banking368.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection;
using System.Text;
using System.Linq;


namespace Alliance.Banking368.RepositoryTests
{
    [TestClass]
    public class UserRepositoryTests
    {
      IUserRepository _repo = new UserRepository();
     

      User user = new User
       {
           
           Name = "Chanakya Kumar Somireddy",
           Password = "Chanakya448$",
           AccountNumber = 2026,
           EmailId = "csomiredddy@allianceglobalservices.com",
           MobileNumber = 7396,
           Balance = 24938
       };
       User user1 = new User
       {
            
            Name = "Gautam Reddy Abbavaram",
            Password = "Gautam502$",
            AccountNumber = 2027,
            EmailId = "gabbavaram@allianceglobalservices.com",
            MobileNumber = 7386,
            Balance = 24938
       };
       [TestMethod]
       public void GetUser_ReturnsUsers()
       {
           IList<User> User = _repo.Get();
           Assert.IsNotNull(User);
       }
       [TestMethod]
       public void Create_WithValidInputs_UserInTable()
       {
           _repo.Add(user);
           var userList = _repo.Get();
           var success = userList.SingleOrDefault(_ => _.ID.Equals(user.ID));
           Assert.IsNotNull(success);

       }
        [TestMethod]
       public void Get_ByID_UserInTable()
       {
           var userList = _repo.Get();
           var isId = userList.Last();
           var success = _repo.GetByID(isId.ID);
           Assert.IsNotNull(success);
           

       }
         [TestMethod]
         public void Delete_WithValidInput_UserInTable()
         {
             var userList = _repo.Get();
             var firstUser = userList.First();
             _repo.Delete(firstUser.ID);
             var result = _repo.GetByID(firstUser.ID);
             Assert.IsNull(result);
         }
         [TestMethod]
         public void Update_WithValidInput_UserInTable()
         {
             Assert.IsFalse(_repo.Update(user));
         }



           



        }
    }

