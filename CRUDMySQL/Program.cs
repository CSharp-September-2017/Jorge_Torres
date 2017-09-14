using System;
using System.Collections.Generic;
using DbConnection; 

namespace CRUDMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            dataInsert();

        }
        static void  display(){
            string query = "select  * from Users;";
            List<Dictionary<string, object>> result = DbConnector.Query(query);
           
        }
        static void dataInsert(){
            Console.Write("Please enter First Name:");
            string Fname = Console.ReadLine();
            Console.Write("Lastname: ");
            string Lname = Console.ReadLine();
            Console.Write("Favorite Number:");
            string FavNum = Console.ReadLine();

            string insert =$"insert into Users (firstName, lastName, favoriteNumber) values ('{Fname}','{Lname}','{FavNum}');";
            DbConnector.Execute(insert);
        }
        /*static void updateRaw(){
            Console.Write("Provide id to update the User:");
            string UserId = Console.ReadLine();
            string queryID = "select id from Users";
            if(){

            }
            string updateData = $"update ";

        }*/
    }
}
