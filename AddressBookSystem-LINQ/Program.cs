// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace AddressBookSystem_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Data LINQ Operartion Program");
            ///Creating the instance of the address book repository
            AddressBookDataTable.AddDataIntoTable();
            /// UC4 Editing exiting Contact Details.
            AddressBookDataTable.EditExistingContactDetails("Mansingh", "Meena", 322514);
            /// UC5 Delete Person Contact Using Name.
            AddressBookDataTable.DeleteContactUsingName();
            /// UC6 Retrieving Contact Details By State Or City Name.
            AddressBookDataTable.RetrievingContactDetailsByCityOrState();
            /// UC7 Get the count of number of contacts as per the state or city.
            AddressBookDataTable.GetCountOfContactInCityOrState();
            Console.ReadLine();
        }
    }
}
