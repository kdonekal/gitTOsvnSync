// <copyright file="IUserRepository.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is IUserRepository interface.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alliance.Banking368.Data.Repositories;
using Alliance.Banking368.Domain;
namespace Alliance.Banking368.Data.Repositories.Interfaces
{
    /// <summary>
    /// Interface for User repository
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Method to get List of  Users 
        /// </summary>
        /// <returns> returns list of users</returns>
       IList<User> Get();
       /// <summary>
       /// Method to get Single User object based on User ID
       /// </summary>
       /// <param name="id"> User to Add</param>
       /// <returns>returns user</returns>
       User GetByID(int id);
       /// <summary>
       /// Method to add User object 
       /// </summary>
       /// <param name="user">User to Add</param>
       /// <returns>returns a bool value</returns>
       bool Add(User user);
       /// <summary>
       /// Method to delete User object based on User id
       /// </summary>
       /// <param name="id">id to Delete</param>
       /// <returns> returns a bool value</returns>
       bool Delete(int id);
       /// <summary>
       /// Method to update User object
       /// </summary>
       /// <param name="user">User to Update</param>
       /// <returns>returns a user</returns>
       bool Update(User user);
       
    }
}
