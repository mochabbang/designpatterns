using System.Collections;
using System.Collections.Generic;
namespace designpatterns.iterator_pattern
{
    public interface IMenu
    {
         Iterator createIterator();
    }
}