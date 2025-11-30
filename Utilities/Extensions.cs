namespace Utilities
{
    public static class Extensions
    {
        public static string ToMyString(this int[] arr)
        {
            var result = string.Join(',', arr);
            return result;
        }

        public static void Apply<T>(this IEnumerable<T> array, Action<T> action)
        {
            foreach (var item in array)
            {
                action(item);
            }
        }

        public static bool IsEqual(this ListNode first, ListNode second)
        {
            var firstString = first == null  ? "" : first.ToString();
            var secondString = second == null  ? "" : second.ToString();

            return firstString.Equals(secondString);
        }
    }
}
