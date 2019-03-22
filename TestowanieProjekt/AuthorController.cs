using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestowanieProjekt;

namespace TestowanieProjekt
{
    class AuthorController
    {
        public static List<AuthorModel> Authors = new List<AuthorModel>();
        public static bool AddAuthor(string FirstName, string LastName, string DateOfBirth)
        {
            var Author = new AuthorModel(FirstName, LastName, DateOfBirth);

            if (!Authors.Contains(Author))
            {
                Authors.Add(Author);
                Console.WriteLine("{0} {1} has been already added to the system", Author.FirstName, Author.LastName);
                return true;

            }
            else
            {
                Console.WriteLine("This Author has been already launched!");
                return false;
            }

        }

        public static bool DeleteAuthor(string LastName)
        {
            
            var Author = FindAuthor(LastName);
            if (Authors.Contains(Author))
            {
                Authors.Remove(Author);
                Console.WriteLine("{0} {1} has been already removed from the system", Author.FirstName, Author.LastName);
                return true;

            }
            else
            {
                Console.WriteLine("There isn't such Author in database!");
                return false;
            }

        }

        //public static bool UpdateAuthor(string LastName, string[] newData)
        //{

        //    var Author = FindAuthor(LastName);
        //    if (AuthorModel.Authors.Contains(Author))
        //    {
        //        Console.WriteLine("Which parametr you want to update?\n[1] - First Name\n[2] - Last Name\n[3] - Date of Birth");
        //        int number = Convert.ToInt32(Console.ReadLine());
        //        switch (number)
        //        {
        //            case 1:
        //                AuthorModel.Authors.
        //                break;
        //            case 2:
        //                break;
        //            case 3:
        //                break;
                   
        //        }
        //        return true;

        //    }
        //    else
        //    {
        //        Console.WriteLine("There isn't such Author in database!");
        //        return false;
        //    }

        //}



        public static void DisplayAuthors(IEnumerable<AuthorModel> items)
        {
            foreach (AuthorModel input in Authors)
            {
                Console.WriteLine(input.LastName.ToString() + " " + input.FirstName.ToString());
            }
        }

        public static int CountAuthors()
        {
            return Authors.Count;
        }

        public static List<AuthorModel> FindAuthors(string[] lastnameList)
        {
            var items = new List<AuthorModel>();
            foreach (string input in lastnameList)
            {
                items.AddRange(Authors.FindAll(
                    x => x.FirstName.ToLower().Contains(input.ToString().ToLower())));
            }
            var result = items.Distinct().ToList();
            return result;
        }

        public static AuthorModel FindAuthor(string lastnameList)
        {
            AuthorModel item = null;
            var itemTmp = Authors.Find(
                x => x.LastName.ToLower().Contains(lastnameList.ToString().ToLower()));
            if (item == null)
            {
                item = itemTmp;
            }
            else
                return null;
            return item;
        }


    }
}
