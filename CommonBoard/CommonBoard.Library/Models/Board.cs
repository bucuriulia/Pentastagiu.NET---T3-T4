using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoard.Library.Models
{
    public class Board
    {
        public List<Post> Posts { get; private set; }
        private List<UserAccount> users;
        public Board()
        {
            users = new List<UserAccount>
            {
                new UserAccount { FirstName = "Homer", LastName = "Simpson", Birthdate = new DateTime(1956, 5, 12) },
                new UserAccount { FirstName = "Nathan", LastName = "Explosion", Birthdate = new DateTime(1985, 4, 27) },
                new UserAccount { FirstName = "Peter", LastName = "Griffin", Birthdate = new DateTime(1997, 10, 13) },
                new UserAccount { FirstName = "Linda", LastName = "Belcher", Birthdate = new DateTime(1976, 6, 2) },
                new UserAccount { FirstName = "Eric", LastName = "Cartman", Birthdate = new DateTime(1969, 11, 2) }

            };


            Posts = new List<Post>
            {
                new Post{ Author = users[0], Content = "Hello! This is my first post ever on this message board! :)", Title = "Hello", PostDate = new DateTime(2019, 12, 27, 21, 8, 0)},
                new Post{ Author = users[1], Content = "Hello! Welcome to the board! :D", Title = "RE: Hello", PostDate = new DateTime(2019, 12, 27, 21, 30, 0)},
                new Post{ Author = users[2], Content = "Idk what else to say", Title = "Idk", PostDate = new DateTime(2019, 5, 15, 13, 8, 0)},
                new Post{ Author = users[3], Content = "I'm bored.", Title = "bored", PostDate = new DateTime(2019, 1, 15, 22, 0, 0)},
                new Post{ Author = users[4], Content = "Another post bites the dust", Title = "Funny", PostDate = new DateTime(2018, 12, 27, 21, 8, 0)},
                new Post{ Author = users[3], Content = "Down with the sickness by Disturbed", Title = "Song suggestion", PostDate = new DateTime(2019, 1, 3, 13, 8, 0)},
                new Post{ Author = users[1], Content = "What is your favorite color?", Title = "Question", PostDate = new DateTime(2015, 10, 10, 10, 10, 0)},
                new Post{ Author = users[2], Content = "How's your family?", Title = "Fam", PostDate = new DateTime(2019, 12, 27, 21, 10, 0)},
                new Post{ Author = users[0], Content = "Why are you here?", Title = "Title", PostDate = new DateTime(2017, 3, 12, 21, 34, 0)},
                new Post{ Author = users[4], Content = "Another message yay", Title = "Hello", PostDate = new DateTime(2019, 1, 23, 21, 12, 0)},
                new Post{ Author = users[2], Content = "Hello!", Title = "Hello", PostDate = new DateTime(2019, 5, 5, 5, 5, 0)},
                new Post{ Author = users[1], Content = "fewrfewrfewrf", Title = "ferferfewrf", PostDate = new DateTime(2019, 3, 3, 3, 3, 3)}
            };


        }

        public void AddUser(UserAccount user)
        {
            try
            {
                var findResult = users.SingleOrDefault(a => user.Equals(a));

                if (findResult != null)
                    throw new Exception("The user already exists in the message board!");

                users.Add(user);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void AddPost(Post post)
        {
            try
            {
                var findResult = Posts.SingleOrDefault(a => post.Equals(a));

                if (findResult != null)
                    throw new Exception("The post already exists in the message board!");

                Posts.Add(post);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void DisplayPosts()
        {
            Posts = Posts.OrderByDescending(a => a.PostDate).ToList();

            foreach (var post in Posts)
            {
                Console.WriteLine(post.ToString());
            }
        }
    }
}
