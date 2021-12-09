namespace DepthFirstSearch
{
    public class Node
    {
        public bool Visited { get; set; }
        public List<Node> Children { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            Children = new List<Node>();
            Value = value;
            Visited = false;
        }

        public void Visit()
        {
            Visited = true;
        }
    }
    public class DFS
    {
        public List<int> Search(Node root, List<int> result)
        {
            if (root == null)
            {
                return result;
            }
            root.Visit();
            result.Add(root.Value);
            for (int i = 0; i < root.Children.Count; i++)
            {
                if (!root.Children[i].Visited)
                {
                    Search(root.Children[i], result);
                }
            }
            return result;
        }
    }
}