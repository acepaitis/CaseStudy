using System;

namespace KPMG.Interview.CaseStudy2
{
    public class NotReallyBinaryTree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public NotReallyBinaryTree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.Root = new TreeNode<T>(value);
        }

        public NotReallyBinaryTree(T value, params TreeNode<T>[] children) : this(value)
        {
            foreach (TreeNode<T> child in children)
            {
                this.Root.AddChild(child);
            }
        }
    }
}
