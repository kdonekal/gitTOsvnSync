// <copyright file="TransactionRepository.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is TransactionRepository class.</summary>  
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
    /// class to implement Transaction repository interface
    /// </summary>
    public class TransactionRepository : ITransactionRepository
    {
        /// <summary>
        /// Object to connect Transaction model class to database
        /// </summary>
        private Banking368Context context;
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRepository"/> class.
        /// </summary>
        public TransactionRepository()
        {
            context = new Banking368Context();
        }
        /// <summary>
        /// Method to get list of Transactions 
        /// </summary>
        /// <returns>returns list</returns>
        public IList<Transaction> Get()
        {
            try
            {
                return context.Transactions.ToList<Transaction>();
            }
            catch 
            {
                throw;
            }
        }
        /// <summary>
        /// Method to get Transaction object based on User id 
        /// </summary>
        /// <param name="id">Transaction to Get</param>
        /// <returns>returns transaction</returns>
        public Transaction GetByID(int id)
        {
            try
            {
                return context.Transactions.Find(id);
            }
            catch 
            {
                throw;
            }
        }
        /// <summary>
        /// Method to get five Transactions  based on User id 
        /// </summary>
        /// <param name="id">Five Transactions to Get</param>
        /// <returns>returns transactions</returns>
        public IList<Transaction> GetFive(int id)
        {
            try
            {
                IList<Transaction> lastfive = context.Transactions.Where(userid => userid.User.ID.Equals(id)).Take(5).ToList();
                return lastfive;
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Method to Add Transaction object 
        /// </summary>
        /// <param name="transaction">Transaction to Add</param> 
        /// <returns>returns bool value</returns>
        public bool Add(Transaction transaction)
        {
            try
            {
                context.Transactions.Add(transaction);
                return context.SaveChanges() == 1; 
            }
            catch 
            {
                throw;
            }
        }
        /// <summary>
        /// Method to Delete Transaction object based on User id
        /// </summary>
        /// <param name="id">Transaction to Delete</param>
        /// <returns>returns bool value</returns>
        public bool Delete(int id)
        {
            try
            {
                context.Transactions.Remove(context.Transactions.Find(id));
                return context.SaveChanges() == 1;
            }
            catch 
            {
                throw;
            }
        }
        /// <summary>
        /// Method to update Transaction object
        /// </summary>
        /// <param name="transaction">Transaction to Update</param>
        /// <returns>returns bool value</returns>
        public bool Update(Transaction transaction)
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