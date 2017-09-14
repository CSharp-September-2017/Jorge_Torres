using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
 
            Artist FromVernon = Artists.Where(artist =>artist.Hometown =="Mount Vernon").Single();
            Console.WriteLine($"{FromVernon.RealName} is from Mount Vernon, is {FromVernon.Age} years old");

            //Who is the youngest artist in our collection of artists?
            Artist Young  = Artists.OrderBy(ages => ages.Age).First();
            Console.WriteLine($"\nThe Youngest artist is {Young.RealName} he is {Young.Age} years old ");

            //Display all artists with 'William' somewhere in their real name
            List<Artist> LastName =  Artists.Where(lastname => lastname.RealName.Contains("Will")).ToList();
            Console.WriteLine("\nThe William's artist:");
            foreach(var artist in LastName){
                Console.WriteLine(artist.RealName);
            }
            //Display the 3 oldest artist from Atlanta
            List<Artist> OldArtist = Artists.Where(artist => artist.Hometown =="Atlanta").OrderBy(artist => artist.Age)
                                    .Take(3)
                                    .ToList();
            Console.WriteLine("\nThe First three oldest artist from Atlanta");
            foreach(var artist in OldArtist){
                Console.WriteLine(artist.ArtistName + " with " + artist.Age +" years old ");
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City
               List<string> GroupMembers = Artists
                                .Join(Groups, artist => artist.GroupId, group => group.Id, 
                                (artist, group) => { artist.Group = group; return artist;})
                                .Where(artist => (artist.Hometown != "New York City" && artist.Group != null))
                                .Select(artist => artist.Group.GroupName)
                                .Distinct()
                                .ToList();
            Console.WriteLine("\nAll groups with members not from New York City:");
            foreach(var group in GroupMembers){
                Console.WriteLine(group);
            }

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            
        }
    }
}
