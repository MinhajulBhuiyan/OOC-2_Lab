using System;

class Bottles
{
    public string verse(int bottles)
    {
        if (bottles == 0)
        {
            return "No more bottles of beer on the wall, no more bottles of beer.\n" +
                   "Go to the store and buy some more, 99 bottles of beer on the wall.\n";
        }
        else if (bottles == 1)
        {
            return "1 bottle of beer on the wall, 1 bottle of beer.\n" +
                   "Take one down and pass it around, no more bottles of beer on the wall.\n";
        }
        else
        {
            return $"{bottles} bottles of beer on the wall, {bottles} bottles of beer.\n" +
                   $"Take one down and pass it around, {bottles - 1} bottles of beer on the wall.\n";
        }
    }
}