using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    interface ICost
    {
        void Calculate(int numberOne, int numberTwo);
    }
}