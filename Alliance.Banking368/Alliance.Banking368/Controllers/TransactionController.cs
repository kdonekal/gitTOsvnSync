// <copyright file="TransactionController.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is TransactionController Class.</summary>
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
    /// <summary>
    /// Controller to add Transactions
    /// </summary>
    public class TransactionController : ApiController
    {
        /// <summary>
        /// Variable for Transaction repository
        /// </summary>
        private TransactionRepository repo;
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionController"/> class.
        /// </summary>
        public TransactionController()
        {
            this.repo = new TransactionRepository();
        }
        /// <summary>
        /// Method to support Http Get
        /// </summary>
        /// <returns>returns transaction</returns>
        public IList<Transaction> Get()
        {
            var transactions = this.repo.Get();
            return transactions;
        }
        /// <summary>
        /// Method to support Http Get based on user id
        /// </summary>
        /// <param name="id">id to get transactions based on id</param>
        /// <returns>returns transaction based on id</returns>
        public Transaction GetByID(int id)
        {
            var transaction = this.repo.GetByID(id);
            return transaction;
        }
        /// <summary>
        /// Method to support Http Post to Get transactions
        /// </summary>
        /// <param name="user">transactions to get in from database</param>
        /// <returns>returns last five transactions</returns>
        [HttpPost]
        public IList<Transaction> GetFive(User user)
        {
            IList<Transaction> five_transactions = this.repo.GetFive(user.ID);
            return five_transactions;
        }
    }
}
