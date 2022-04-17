using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        {
            
        }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void BusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            List<string> result = this._strategy.Algorithm(new List<string> { "c", "a", "b", "e", "d" });

            string resultStr = string.Empty;
            foreach (var element in result)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}