using System.Linq;
using System;

static bool XO(string input)
    {
        int oCount = 0;
        int xCount = 0;

        foreach (var character in input.ToLower()) { 
            if(character == 'o')
            {
                 oCount++;
            }
            else if(character == 'x')
            {
                xCount++;
            }
        }

        if (oCount == xCount)
        {
            return true;
        }

        return false;
    }