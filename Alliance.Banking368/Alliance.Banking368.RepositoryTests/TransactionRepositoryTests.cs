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
    public class  TransactionRepositoryTests
    {

        ITransactionRepository _repo = new TransactionRepository();
        int _id =1;
        private Transaction _getTransaction()
        {
           UserRepository _userrepo = new UserRepository();
            return new Transaction 
            {
                 Description = "ATM Withdrawl from CITI ATM at Madhapur",
                 Date = DateTime.Today.Date,
                 User = _userrepo.GetByID(1)
            };
        }

       
        [TestMethod]
        public void GetTransactions_ReturnsTransactions()
        {
            IList<Transaction> Transactions = _repo.Get();
            Assert.IsNotNull(Transactions);
        }
        [TestMethod]
        public void Create_WithValidInputs_UserInTable()
        {
            var Transaction = _getTransaction();
            _repo.Add(Transaction);
            var TransactionList = _repo.Get();
            var success = TransactionList.SingleOrDefault(_ => _.ID.Equals(Transaction.ID));
            Assert.IsNotNull(success);

        }
        [TestMethod]
        public void Get_ByID_TransactionInTable()
        {
            var TransactionList = _repo.Get();
            var isId = TransactionList.Last();
            var success = _repo.GetByID(isId.ID);
            Assert.IsNotNull(success);


        }
        [TestMethod]
        public void Delete_WithValidInput_UserInTable()
        {
            var TransactionList = _repo.Get();
            var firstTransaction = TransactionList.First();
            _repo.Delete(firstTransaction.ID);
            var result = _repo.GetByID(firstTransaction.ID);
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Update_WithValidInput_UserInTable()
        {
            Assert.IsFalse(_repo.Update(_getTransaction()));
        }
    }
}
