using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleProject
{
    public class Bottles
    {
        public String song()
        {
            return verses(99, 0);
        }
        public String verses(int upperBound, int lowerBound)
        {
            String lyrics = "";
            for (int i = upperBound; i >= lowerBound; i--)
            {
                lyrics += verse(i);
            }
            return lyrics;
        }

        public String verse(int lineNumber)
        {
            String lyrics = "";
            switch (lineNumber)
            {
                case 0:
                    lyrics += "No more bottles of beer on the wall , no more bottles of beer.\n" +
                                "Go to the store and buy some more , 99 bottlesof beer on the wall.\n";
                    break;

                case 1:
                    lyrics += "1 bottle of beer on the wall , 1 bottle ofbeer.\n" +
                               " Take it down and pass it around , no more bottles of beer on the wall .\n";
                    break;

                default:
                    lyrics += $"{lineNumber} bottles of beer on the wall , {lineNumber} bottles of beer .\n" +
                              $" Take one down and pass it around , {lineNumber - 1} bottles of beer on the wall .\n";
                    break;
            }
            return lyrics;
        }
    }

}

