﻿using System;

static bool IsSquare(int n)
{
    if(n < 0)
    {
        return false; 
    }
        
    if(n == (int)Math.Sqrt(n) * (int)Math.Sqrt(n))
    {
        return true;
    }
    else
    {
        return false;
    }
}