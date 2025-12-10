using System.Xml.Linq;

namespace Utilities
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(int[] array)
        {
            if (array.Length > 0)
            {
                val = array[0];
                if (array.Length == 1)
                    next = null;
                else
                    next = new ListNode(array[1..]);
            }
        }

       
        public override string ToString()
        {
            var list = ToList();

            return string.Join("", list);
        }

        private List<int> ToList()
        {
            var result = new List<int>();

            result.Add(val);

            var head = next;

            while (head != null)
            {

                result.Add(head.val);
                head = head.next;

                if (head.next == null)
                {
                    result.Add(head.val);
                    break;
                }
            }

            return result;
        }
    }
}
