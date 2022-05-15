namespace designpatterns.iterator_pattern
{
    public interface Iterator
    {
         bool HasNext();

         MenuItem Next();
    }
}