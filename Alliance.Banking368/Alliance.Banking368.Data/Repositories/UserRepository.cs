// <copyright file="UserRepository.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is UserRepository class.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alliance.Banking368.Data.Context;
using Alliance.Banking368.Data.Repositories.Interfaces;
using Alliance.Banking368.Domain;

namespace Alliance.Banking368.Data.Repositories
{
    /// <summary>
    /// class to implement User repository interface
    /// </summary>
   public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Object to connect User model class to database
        /// </summary>
       private Banking368Context context;
       /// <summary>
       /// Initializes a new instance of the <see cref="UserRepository"/> class.
       /// </summary>
        public UserRepository()
        {
            context = new Banking368Context();
        }
        /// <summary>
        /// Method returns list of Users
        /// </summary>
        /// <returns>returns list of users</returns>
        public IList<User> Get()
        {
             return context.Users.ToList<User>();
        }
        /// <summary>
        /// Method to get User object based on User id 
        /// </summary>
        /// <param name="id">User to Get</param>
        /// <returns>reeturns user based on id</returns>
        public User GetByID(int id)
        {
             User user = context.Users.Find(id);
             return user;
        }
        /// <summary>
        /// Method to Add User object 
        /// </summary>
        /// <param name="user">User to Add</param>
        /// <returns>returns a bool value</returns>
       public bool Add(User user)
        {
            try
            {
                context.Users.Add(user);
                return context.SaveChanges() == 1;
            }
            catch
            {
                throw;
            }
        }
       /// <summary>
       /// Method to Delete User object based on User id
       /// </summary>
       /// <param name="id">User to Delete</param>
       /// <returns>returns a bool value</returns>
       public bool Delete(int id)
       {
           try
           {
               context.Users.Remove(context.Users.Find(id));
               return context.SaveChanges() == 1; 
           }
           catch
           {
               throw;
           }
       }
       /// <summary>
       /// Method to update User object
       /// </summary>
       /// <param name="user">User to Update</param>
       /// <returns>returns a bool value</returns>
       public bool Update(User user)
       {
        try
            {
                return false;
            }
            catch
            {
                throw;
            }   
       }
    }
}