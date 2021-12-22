namespace MergeTwoBinaryTrees
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode(int _value)
        {
            Value = _value;
        }
    }

    public class MergeTwoBinaryTrees
    {
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2;
            }

            if (t2 == null)
            {
                return t1;
            }

            t1.Value += t2.Value;
            t1.Left = MergeTrees(t1.Left, t2.Left);
            t1.Right = MergeTrees(t1.Right, t2.Right);
            return t1;
        }

        public static List<int?> ConvertToList(TreeNode t1, List<int?> arr)
        {
            if (t1 == null)
            {
                return arr;
            }

            arr.Add(t1.Value);
            ConvertToList(t1.Left, arr);
            ConvertToList(t1.Right, arr);
            return arr;
        }
    }
}