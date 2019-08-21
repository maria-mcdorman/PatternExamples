using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class Context
    {
        private Strategy _strategy;
        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }
        public int ExecuteStrategy(int num1, int num2)
        {
            return _strategy.DoOperation(num1, num2);
        }
    }
}
