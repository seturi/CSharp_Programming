using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BinarySearchTree
{
    // 이진 트리 노드 클래스
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T data)
        {
            this.Data = data;
        }
    }

    // 이진 트리 클래스
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        // 트리 데이터 출력 예
        public void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node == null) return;

            Console.WriteLine(node.Data);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
    }

    // 이진검색트리 클래스
    public class BST<T>
    {
        private BinaryTreeNode<T> root = null;
        private Comparer<T> comparer = Comparer<T>.Default;

        public void Insert(T val)
        {
            BinaryTreeNode<T> node = root;
            if (node == null)
            {
                root = new BinaryTreeNode<T>(val);
                return;
            }

            while (node != null)
            {
                int result = comparer.Compare(node.Data, val);
                if (result == 0)
                {
                    //throw new InvalidDataException("Duplicate value");
                    return;
                }
                else if (result > 0)
                {
                    if (node.Left == null)
                    {
                        node.Left = new BinaryTreeNode<T>(val);
                        return;
                    }
                    node = node.Left;
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new BinaryTreeNode<T>(val);
                        return;
                    }
                    node = node.Right;
                }
            }
        }

        public void PreOrderTraversal()
        {
            PreOrderRecursive(root);
        }

        private void PreOrderRecursive(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            Console.WriteLine(node.Data);
            PreOrderRecursive(node.Left);
            PreOrderRecursive(node.Right);
        }
    }

    // 이진검색트리 테스트
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1. BST 구현
            BST<int> bst = new BST<int>();
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(6);
            bst.Insert(1);
            bst.Insert(7);

            bst.PreOrderTraversal();


            // 2. SortedDictionary<Tkey,TValue> 클래스
            SortedDictionary<int, string> tmap = new SortedDictionary<int, string>();
            tmap.Add(1001, "Tom");
            tmap.Add(1003, "John");
            tmap.Add(1010, "Irina");

            // Key 1010의 데이타 읽기
            string name1010 = tmap[1010];

            // Iterator 사용
            foreach (KeyValuePair<int, string> kv in tmap)
            {
                Console.WriteLine("{0}:{1}", kv.Key, kv.Value);
            }
        }
    }
}
