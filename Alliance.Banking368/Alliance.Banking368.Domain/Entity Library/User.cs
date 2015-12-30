// <copyright file="User.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is User class.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alliance.Banking368.Domain
{
    /// <summary>
    /// Model class for table User
    /// </summary>
    public class User
    {
        /// <summary>
        /// Primary key for table.
        /// </summary>
        /// <value>ID for User</value>
        public int ID { get; set; }
        /// <summary>
        /// property for User Name
        /// </summary>
        /// <value>Name for User</value>
        public string Name { get; set; }
        /// <summary>
        /// property for User Password
        /// </summary>
        /// <value>Password for User</value>
        public string Password { get; set; }
        /// <summary>
        /// property for User AccountNumber
        /// </summary>
        /// <value>AccountNumber for User</value>
        public int AccountNumber { get; set; }
        /// <summary>
        /// property for User Balance
        /// </summary>
        /// <value>Balance for User</value>
        public float Balance { get; set; }
        /// <summary>
        /// property for User EmailId
        /// </summary>
        /// <value>EmailId for User</value>
        public string EmailId { get; set; }
        /// <summary>
        /// property for User MobileNumber
        /// </summary>
        /// <value>MobileNumber for User</value>
        public int MobileNumber { get; set; }
        /// <summary>
        /// property for mapping User table to Transactions table
        /// </summary>
        /// <value>Member for User</value>
        public virtual ICollection<Transaction> Transactions { get; set; }
        /// <summary>
        /// property for mapping User table to Cards table
        /// </summary>
        /// <value>Member for User</value>
        public virtual ICollection<Card> Cards { get; set; }   
    }
}
