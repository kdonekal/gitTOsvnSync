// <copyright file="CardController.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is CardController Class.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Alliance.Banking368.Data.Repositories.Interfaces;
using Alliance.Banking368.Domain;

namespace Alliance.Banking368.Controllers
{
    /// <summary>
    /// Controller to handle Cards
    /// </summary>
    public class CardController : ApiController
    {
        /// <summary>
        /// Variable for Card Repository
        /// </summary>
        private CardRepository repo;
        /// <summary>
        /// Initializes a new instance of the <see cref="CardController"/> class.
        /// </summary>
        public CardController()
        {
            this.repo = new CardRepository();
        }
        /// <summary>
        /// Method to support Http Get
        /// </summary>
        /// <returns>returns list of cards</returns>
        public object Get()
        {
            var cards = this.repo.Get().OrderBy(x => x.ID).ToList();
            return cards;
        }
        /// <summary>
        /// Method to support Http Get by id
        /// </summary>
        /// <param name="id">id to get list of cards</param>
        /// <returns>returns user object based on id</returns>
        public object GetByID(int id)
        {
            var card = this.repo.GetByID(id);
            return card;
        }
       /// <summary>
       /// Method to support Http Post to add card
       /// </summary>
       /// <param name="card">card to insert</param>
        public void Post(Card card)
        {
        }
    }
}
