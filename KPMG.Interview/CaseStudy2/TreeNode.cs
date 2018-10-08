using System;

namespace KPMG.Interview.CaseStudy2
{
    public class TreeNode<T>
    {
        public T Value { get; private set; }
        public TreeNode<T> LeftChild { get; private set; }
        public TreeNode<T> RightChild { get; private set; }

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.Value = value;
        }

        public TreeNode(T value, params TreeNode<T>[] children) : this(value)
        {
            foreach (TreeNode<T> child in children)
            {
                this.AddChild(child);
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            if (LeftChild == null)
            {
                LeftChild = child;
            }
            else if (RightChild == null)
            {
                RightChild = child;
            }
            else
            {
                throw new InvalidOperationException("You cannot add more when two childs into this fancy tree");
            }
        }
    }
}
