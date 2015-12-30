using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection;
using System.Text;
using System.Linq;
using Alliance.Banking368.Data;
using Alliance.Banking368.Data.Repositories;
using Alliance.Banking368.Data.Repositories.Interfaces;
using Alliance.Banking368.Domain; 
namespace Alliance.Banking368.RepositoryTests
{
    [TestClass]
    public class CardRepositoryTests
    {
        ICardRepository repo = new CardRepository();
        int id = 1;
        private Card _getCard()
        {
            UserRepository userrepo = new UserRepository();
            UserRepository userrepo1 = new UserRepository();
            return new Card
            {
                Number = 5196,
                AccountNumber = 2026,
                Type = "Debit",
                User = userrepo.GetByID(1)
            };
            return new Card
            {
                Number = 5497,
                AccountNumber = 5223,
                Type = "Credit",
                User = userrepo1.GetByID(2)
            };  
        }
        [TestMethod]
        public void GetCards_ReturnsCards()
        {
            IList<Card> Cards = repo.Get();
            Assert.IsNotNull(Cards);
        }
        [TestMethod]
        public void Create_WithValidInputs_CardInTable()
        {
            var Card = _getCard();
            repo.Add(Card);
            var CardsList = repo.Get();
            var success = CardsList.SingleOrDefault(_ => _.ID.Equals(Card.ID));
            Assert.IsNotNull(success);
        }
        [TestMethod]
        public void Get_ByID_CardInTable()
        {
            var CardsList = repo.Get();
            var isId = CardsList.Last();
            var success = repo.GetByID(isId.ID);
            Assert.IsNotNull(success);
        }
        [TestMethod]
        public void Delete_WithValidInput_CardInTable()
        {
            var CardsList = repo.Get();
            var firstCard = CardsList.First();
            var res = repo.Delete(firstCard.ID);
            //var result = repo.GetByID(firstCard.ID);
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Update_WithValidInput_CardInTable()
        {
            Assert.IsFalse(repo.Update(_getCard()));
        }
    }
}