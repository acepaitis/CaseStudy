using System.Collections.Generic;

namespace KPMG.Interview.CaseStudy2
{

    public class NotReallyBinaryTreeManager
    {
        private readonly NotReallyBinaryTree<string> treeCache;

        public NotReallyBinaryTreeManager()
        {
            treeCache = GetDefaultDummyTree();
        }

        public NotReallyBinaryTreeManager(NotReallyBinaryTree<string> tree)
        {
            treeCache = tree;
        }

        public NotReallyBinaryTree<string> GetDefaultDummyTree()
        {
            NotReallyBinaryTree<string> tree =
            new NotReallyBinaryTree<string>("A",
                new TreeNode<string>("B",
                    new TreeNode<string>("D",
                        new TreeNode<string>("F"))),
                new TreeNode<string>("C",
                    new TreeNode<string>("E",
                        new TreeNode<string>("G")))
            );

            return tree;
        }

        public Dictionary<int, List<string>> FindSiblings()
        {
            var result = new Dictionary<int, List<string>>();
            Queue<TreeNode<string>> queue = new Queue<TreeNode<string>>();
            queue.Enqueue(treeCache.Root);
            queue.Enqueue(null);
            int countLevel = 0;
            result.Add(countLevel, new List<string>());

            while (queue.Count > 0)
            {
                TreeNode<string> current = queue.Dequeue();

                if (current == null)
                {
                    if (queue.Count > 0)
                    {
                        countLevel++;
                        result.Add(countLevel, new List<string>());
                        queue.Enqueue(null);
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    result[countLevel].Add(current.Value);
                }

                if (current.LeftChild != null)
                {
                    queue.Enqueue(current.LeftChild);
                }
                if (current.RightChild != null)
                {
                    queue.Enqueue(current.RightChild);
                }
            }

            return result;
        }
    }
}
