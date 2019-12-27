using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoard.Library.Models
{
    public class Post : IComparable
    {
        public UserAccount Author { get; set; }
        public string Title { get; set; }
        public DateTime PostDate { get; set; }
        public string Content { get; set; }

        public Post()
        {
            Author = new UserAccount();
        }
         

        public int CompareTo(object obj)
        {
            return PostDate.CompareTo((DateTime)obj);
        }

        public override string ToString()
        {
            return $"Created by {Author.ToString()} {Environment.NewLine}" +
                $"Post title: {Title} {Environment.NewLine}" +
                $"Post content: {Content} {Environment.NewLine}" +
                $"Created on: {PostDate}" +
                $"{Environment.NewLine}" +
                $"{Environment.NewLine}";
        }
    }
}
 