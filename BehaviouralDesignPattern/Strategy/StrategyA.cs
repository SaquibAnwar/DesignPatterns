using System.Collections.Generic;

namespace DesignPatterns
{
    public class StrategyA : IStrategy
    {
        public List<string> Algorithm(List<string> data)
        {
            var list = data;
            list.Sort();

            return list;
        }
    }
}