// <copyright file="ITransactionRepository.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is ITransactionRepository interface.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alliance.Banking368.Data;
using Alliance.Banking368.Domain;

namespace Alliance.Banking368.Data.Repositories.Interfaces
{
    /// <summary>
    /// Interface for Transaction repository
    /// </summary>
    public interface ITransactionRepository
    {
        /// <summary>
        /// Method to get Transaction object based on User id
        /// </summary>
        /// <returns> returns list of transactions</returns>
        IList<Transaction> Get();
        /// <summary>
        /// Method to get Transaction based on id
        /// </summary>
        /// <param name="id">Transaction to get</param>
        /// <returns> returns transactions based on id</returns>
        Transaction GetByID(int id);
        /// <summary>
        /// Method to get five transactions based on User id
        /// </summary>
        /// <param name="id">Transactions to Get</param>
        /// <returns> returns transactions based on id</returns>
        IList<Transaction> GetFive(int id);
        /// <summary>
        /// Method to Add Transaction object
        /// </summary>
        /// <param name="transaction">Transaction to Add</param>
        /// <returns> returns a bool value</returns>
        bool Add(Transaction transaction);
        /// <summary>
        /// Method to Delete Transaction object based on User Id
        /// </summary>
        /// <param name="id">Transaction to Delete</param>
        /// <returns> returns a bool value</returns>
        bool Delete(int id);
        /// <summary>
        /// Method to Update Transaction object
        /// </summary>
        /// <param name="transaction">Transaction to Update</param>
        /// <returns> returns a transaction</returns>
        bool Update(Transaction transaction);
         
    }
}
