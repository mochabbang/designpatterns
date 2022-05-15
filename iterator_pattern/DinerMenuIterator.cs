namespace designpatterns.iterator_pattern
{
    public class DinerMenuIterator: Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items) {
            this.items = items;
        }

        public MenuItem Next() {
            MenuItem menuItem = items[position];
            position += 1;
            return menuItem;
        }

        public bool HasNext() {
            if(position >= items.Length || items[position] == null) 
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