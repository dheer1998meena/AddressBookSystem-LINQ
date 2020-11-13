// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookDataTable.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookSystem_LINQ
{
    public class AddressBookDataTable
    {
        /// <summary>
        ///  UC1 Created new address book table list.
        ///List to store the instances of address book model or records of address book
        /// </summary>
        public static List<AddressBookModel> addressBookModels = new List<AddressBookModel>();
        /// <summary>
        ///  UC2 Adds the data into table.
        /// Parameterised constructor intended to add the data to the DB Model
        /// </summary>
        public AddressBookDataTable()
        {
            /// Inserting the data into the list using add operation
            addressBookModels.Add(new AddressBookModel { FirstName = "Rajat ",    LastName = "Sharma",   Address = "Sec-1", City = "Delhi",     State = "Delhi",   Zip = 220245, PhoneNumber = 6585656235, EmailId = "rajat@gmail.com",    AddressBookType = "Friends",   AddressBookName = "DheerRecord" });
            addressBookModels.Add(new AddressBookModel { FirstName = "Navya",     LastName = "Upadhyay", Address = "Sec-2", City = "Sonipat",   State = "Haryana", Zip = 220022, PhoneNumber = 9639556235, EmailId = "Navya@gmail.com",    AddressBookType = "Family",    AddressBookName = "DheerRecord" });
            addressBookModels.Add(new AddressBookModel { FirstName = "Venkatesh", LastName = "Tiwari",   Address = "Sec-3", City = "Kanpur",    State = "UP",      Zip = 226123, PhoneNumber = 8525656235, EmailId = "venkatesh@gmail.com",AddressBookType = "Profession",AddressBookName = "DheerRecord" });
            addressBookModels.Add(new AddressBookModel { FirstName = "Shubham",   LastName = "Rajput",   Address = "Sec-4", City = "Gorakhpur", State = "UP",      Zip = 264365, PhoneNumber = 9653656235, EmailId = "shubham@gmail.com",  AddressBookType = "Family",    AddressBookName = "DheerRecord" });
            addressBookModels.Add(new AddressBookModel { FirstName = "Tarun",     LastName = "Solanki",  Address = "Sec-4", City = "Delhi",     State = "Delhi",   Zip = 126445, PhoneNumber = 7896656235, EmailId = "tarun@gmail.com",    AddressBookType = "Friends",   AddressBookName = "DheerRecord" });
            addressBookModels.Add(new AddressBookModel { FirstName = "Archana",   LastName = "Gri",      Address = "Sec-3", City = "Gorakhpur", State = "UP",      Zip = 223304, PhoneNumber = 6750656235, EmailId = "arhana@gmail.com",   AddressBookType = "Family",    AddressBookName = "DheerRecord" });
            addressBookModels.Add(new AddressBookModel { FirstName = "Prankur",   LastName = "Upadhyay", Address = "Sec-8", City = "Chandigarh",State = "Punjab",  Zip = 162330, PhoneNumber = 8745656235, EmailId = "Prankur@gmail.com",  AddressBookType = "Family",    AddressBookName = "DheerRecord" });
            addressBookModels.Add(new AddressBookModel { FirstName = "Richa",     LastName = "Sharma",   Address = "Sec-7", City = "Delhi",     State = "Delhi",   Zip = 123235, PhoneNumber = 9658741200, EmailId = "Richa@gmail.com",    AddressBookType = "Friends",   AddressBookName = "DheerRecord" });
        }  
    }
}
