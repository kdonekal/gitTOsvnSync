// <copyright file="Card.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is Card class.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alliance.Banking368.Domain
{
    /// <summary>
    /// Model class for table Card
    /// </summary>
   public class Card
    {
        /// <summary>
        /// Primary key for table.
        /// </summary>
        /// <value>ID for Card</value>
       public int ID { get; set; }
       /// <summary>
       /// property for Card Number
       /// </summary>
       /// <value>Number for Card</value>
       public short Number { get; set; }
       /// <summary>
       /// property for Card AccountNumber
       /// </summary>
       /// <value>AccountNumber for Card</value>
       public int AccountNumber { get; set; }
       /// <summary>
       /// property for Card Type
       /// </summary>
       /// <value>Type for Card</value>
       public string Type { get; set; }
       /// <summary>
       /// property for mapping Card table to User table
       /// </summary>
       /// <value>Member for Card</value>
       public User User { get; set; }
    }
}
