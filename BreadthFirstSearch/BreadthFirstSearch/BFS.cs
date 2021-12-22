namespace BreadthFirstSearch
{
    public class Node<T>
    {
        public Node<T>? Left { get; set; }
        public Node<T>? Right { get; set; }
        public T? Value { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }

    public class BFS
    {
        public static List<int> PrintNodesToList(Node<int> root)
        {
            var queue = new Queue<Node<int>>();
            var result = new List<int>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                result.Add(node.Value);
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
            return result;
        }
    }
}
