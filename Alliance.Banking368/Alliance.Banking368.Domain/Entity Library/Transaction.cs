// <copyright file="Transaction.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is Transaction class.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alliance.Banking368.Domain
{
    /// <summary>
    /// Model class for table Transaction
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Primary key for table.
        /// </summary>
        /// <value>ID for Transactions</value>
        public int ID { get; set; }
        /// <summary>
        /// property for Transactions Description
        /// </summary>
        /// <value>Description for Transactions</value>
        public string Description { get; set; }
        /// <summary>
        /// property for Transactions Date
        /// </summary>
        /// <value>Date for Transactions</value>
        public DateTime Date { get; set; }
        /// <summary>
        /// property for mapping Transactions table to User table
        /// </summary>
        /// <value>Member for Transaction</value>
        public User User { get; set; }
        
    }
}
