// <copyright file="Banking368Context.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is Banking368Context class.</summary>
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alliance.Banking368.Domain;

namespace Alliance.Banking368.Data.Context
{
    /// <summary>
    /// Class to connect model classes to database
    /// </summary>
   public class Banking368Context : DbContext
    {
        /// <summary>
        /// creating User entity using DbSet
        /// </summary>
        /// <value>collection of User entities</value>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// creating Transaction entity using DbSet
        /// </summary>
        /// <value>collection of Transaction entities</value> 
        public DbSet<Transaction> Transactions { get; set; }
        /// <summary>
        /// creating Card entity using DbSet
        /// </summary>
        /// <value>collection of Card entities</value>  
        public DbSet<Card> Cards { get; set; }
    
   }
}
