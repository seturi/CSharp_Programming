using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Tree
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

    // 테스트 예제
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(1);
            btree.Root.Left = new BinaryTreeNode<int>(2);
            btree.Root.Right = new BinaryTreeNode<int>(3);
            btree.Root.Left.Left = new BinaryTreeNode<int>(4);

            btree.PreOrderTraversal(btree.Root);
        }
    }
}
