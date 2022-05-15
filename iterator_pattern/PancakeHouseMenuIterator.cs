namespace designpatterns.iterator_pattern
{
    public class PancakeHouseMenuIterator: Iterator
    {
        List<MenuItem> items;
        int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public MenuItem Next()
        {
            MenuItem item = items[position];
            position += 1;
            return item;
        }

        public bool HasNext() 
        {
            if(position >= items.Count || items[position] == null) 
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}