// <copyright file="CardRepository.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is CardRepository class.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alliance.Banking368.Data.Context;
using Alliance.Banking368.Domain;

namespace Alliance.Banking368.Data.Repositories.Interfaces
{
    /// <summary>
    /// class to implement Card repository interface
    /// </summary>
   public class CardRepository : ICardRepository
    {
        /// <summary>
        /// Object to connect Card model class to database
        /// </summary>
       private Banking368Context context;
       /// <summary>
       /// Initializes a new instance of the <see cref="CardRepository"/> class.
       /// </summary>
        public CardRepository()
        {
            context = new Banking368Context();
        }
        /// <summary>
        /// Method to get list of Cards
        /// </summary>
        /// <returns> returns list of cards</returns>
        public IList<Card> Get()
        {
            try
            {
                return context.Cards.ToList();
            }
            catch
            {
                throw;
            }
        }
         /// <summary>
        /// Method to get list of Cards object based on User id 
        /// </summary>
        /// <param name="id">Card to Get</param>
        /// <returns>returns list of cards based on id</returns>
        public IList<Card> GetByID(int id)
        {
            try
            {
               return context.Cards.Where(x => x.ID.Equals(id)).ToList();
                
            }
            catch 
            {
                throw;
            }
        }
        /// <summary>
        /// Method to Add Card object 
        /// </summary>
        /// <param name="card">Card to Add</param>
        /// <returns>returns bool value</returns>
        public bool Add(Card card)
        {
            try
            {
                context.Cards.Add(card);
                return context.SaveChanges() == 1;
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Method to Delete Card object based on User id
        /// </summary>
        /// <param name="id">Card to Delete</param>
        /// <returns>returns a bool value</returns>
        public bool Delete(int id)
        {
            try
            {
                context.Cards.Remove(context.Cards.Find(id));
                 return context.SaveChanges() == 1;
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Method to update Card object
        /// </summary>
        /// <param name="card">Card to Update</param>
        /// <returns>returns a bool value</returns>
        public bool Update(Card card)
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