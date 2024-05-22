using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_new3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int objectsInRow = 3;
            int numberOfPictures = 52;
            int numberOfRow = 52 / 3;
            int picturesOutOfRange = 52 % 3;

            Console.WriteLine("Количество рядов - " + (numberOfRow) + ". Картинки вне ряда - " + (picturesOutOfRange) + ".");
        }
    }
}