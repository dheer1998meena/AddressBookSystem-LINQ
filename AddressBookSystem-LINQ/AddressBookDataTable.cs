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
        /// UC1 Created new address book table
        /// </summary>
        public static DataTable table = new DataTable();

        /// <summary>
        /// UC2 Adds the data into table.
        /// </summary>
        public static void AddDataIntoTable()
        {
            ///Adding columns 
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(int));
            table.Columns.Add("PhoneNumber", typeof(double));
            table.Columns.Add("Email", typeof(string));

            ///Adding First Name and Last name as primary key
            DataColumn[] primaryKeys = new DataColumn[2];
            primaryKeys[0] =table.Columns["FirstName"];
            primaryKeys[1] = table.Columns["LastName"];
            table.PrimaryKey = primaryKeys;
            ///Adding rows
            table.Rows.Add("Rahul", "Ranjan", "Street1", "Faridabad", "Haryana", 121001, "9650925666", "Rahul@gmail.com");
            table.Rows.Add("Retesh", "Gupta", "Street2", "Jhansi", "UP", 878001, "890925666", "reetesh@gmail.com");
            table.Rows.Add("kajal", "Meena", "Street3", "Imartapura", "Rajasthan", 841001, "7412925666", "kajal@gmail.com");
            table.Rows.Add("Rammurti", "Jhangid", "Street4", "Paris", "France", 7894551, "4569925666", "Rammurti@gmail.com");
            table.Rows.Add("Mansingh", "Meena", "Street5", "Dhans", "Rajasthan", 2394551, "9859925666", "mansingh@gmail.com");
            //Printing data
            Console.WriteLine("\nDataTable contents:");
            foreach (var record in table.AsEnumerable())
            {
                Console.WriteLine("FirstName: " +"\t" + record.Field<string>("FirstName") + "\t" + "LastName: " + "\t" + record.Field<string>("LastName") + "\t" + "Address: " + record.Field<string>("Address") + "\t" + "City: " + record.Field<string>("City") + "\t" + " State: " + record.Field<string>("State") + "\t" + "Zip: " + record.Field<int>("Zip") + "\t" + " PhoneNumber: " + record.Field<double>("PhoneNumber") + "\t" + "EmailID: " + record.Field<string>("Email"));
            }
        }
    }
}
