using System.Collections.Generic;

namespace DesignPatterns
{
    public interface IStrategy
    {
        List<string> Algorithm(List<string> data);
    }
}