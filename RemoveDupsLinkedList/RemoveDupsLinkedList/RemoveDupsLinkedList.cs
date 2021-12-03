namespace RemoveDupsLinkedList
{
    public class RemoveDupsLinkedList
    {
        public static LinkedList<int> RemoveDups(LinkedList<int> ll)
        {
            if (ll.First == null) { return ll; }
            LinkedListNode<int>? n = ll.First;

            // Store the values in a set. If we see any duplicates, remove from
            // linked list. (Set the next node to n.Next.Next)
            var tracked = new HashSet<int>();
            while (n != null)
            {
                if (tracked.Contains(n.Value))
                {
                    var temp = n.Next;

                    // C#'s built-in Remove function reassigns the currentNodes next element to the node
                    // which is next to the one we're removing
                    ll.Remove(n);
                    n = temp;
                    continue;
                }
                tracked.Add(n.Value);
                n = n.Next;
            }

            return ll;
        }
    }
}

