// <copyright file="ICardRepository.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is ICardRepository interface.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alliance.Banking368.Domain;

namespace Alliance.Banking368.Data.Repositories.Interfaces
{
    /// <summary>
    /// Interface for Card repository
    /// </summary>
    public interface ICardRepository
    {
        /// <summary>
        /// Method to get List of Cards 
        /// </summary>
        /// <returns>returns list of cards</returns>
        IList<Card> Get();
        /// <summary>
        /// Method to get list of Cards  based on User ID
        /// </summary>
        /// <param name="id">Cards to get </param>
        /// <returns>returns list of cards based on id</returns>
        IList<Card> GetByID(int id);
        /// <summary>
        /// Method to Add Card Object 
        /// </summary>
        /// <param name="card">Card to Add</param>
        /// <returns>returns a bool value</returns>
        bool Add(Card card);
        /// <summary>
        /// Method to delete Card Object based on User id
        /// </summary>
        /// <param name="id">Card to delete</param>
        /// <returns>returns a bool value</returns>
        bool Delete(int id);
        /// <summary>
        /// Method to update Card object
        /// </summary>
        /// <param name="card">Card to Update</param>
        /// <returns>returns a bool value</returns>
        bool Update(Card card);
    }
}
