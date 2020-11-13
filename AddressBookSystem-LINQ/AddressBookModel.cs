﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookModel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem_LINQ
{ /// <summary>
  /// Class to map the relational data base model to a entity.
  /// </summary>
    public class AddressBookModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string AddressBookType { get; set; }
        public string AddressBookName { get; set; }
    }
}
