using CommonBoard.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            board.DisplayPosts();

            Console.ReadKey();
        }
    }
}
