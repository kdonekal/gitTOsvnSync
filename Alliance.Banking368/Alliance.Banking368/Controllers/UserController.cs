// <copyright file="UserController.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is UserController Class.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Alliance.Banking368.Data.Repositories;
using Alliance.Banking368.Domain;
namespace Alliance.Banking368.Controllers
{   
    ///<summary>Controller to handle Users 
    ///</summary>
    public class UserController : ApiController
    {
        /// <summary>
        /// Variable for User repository
        /// </summary>
        private UserRepository repo;
        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        public UserController()
        {
            this.repo = new UserRepository();
        }
        /// <summary>
        /// Method to support Http Get
        /// </summary>
        /// <returns>
        /// returns Users 
        /// </returns>
        public IList<User> Get()
        {
            IList<User> users = this.repo.Get();
            return users;
        }
        /// <summary>
        /// Method to support Http Get by id
        /// </summary>
        /// <param name="id">id to get user</param>
        /// <returns> returns user  based on id</returns>
        public User GetByID(int id)
        {
            var user = this.repo.GetByID(id);
            return user;
        }
        /// <summary>
        /// Method to Check User
        /// </summary>
        /// <param name="user">user to add</param>
        /// <returns>returns user</returns>
       [HttpPost]
        public User Check(User user)
        {
            IList<User> users = this.repo.Get();
           foreach(User user_check in users)
           { 
               if(user_check.EmailId == user.EmailId && user_check.Password == user.Password)
               {
                   return user_check;
               }
           }
           return null;
        }  
    }
}
