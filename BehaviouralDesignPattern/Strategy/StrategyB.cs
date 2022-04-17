using System.Collections.Generic;

namespace DesignPatterns
{
    public class StrategyB : IStrategy
    {
        public List<string> Algorithm(List<string> data)
        {
            var list = data;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}