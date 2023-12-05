using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int val)
            {
                value = val;
                left = null;
                right = null;
            }
        }

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            Node root;
            if(radioButton1.Checked == true)
            {
                root = new Node(4);
                root.left = new Node(2);
                root.right = new Node(7);
                root.left.left = new Node(1);
                root.left.right = new Node(3);
                root.right.left = new Node(6);
                root.right.right = new Node(9);
            }
            else
            {
                root = new Node(2);
                root.left = new Node(1);
                root.right = new Node(3);
            }
            string result = "[" + prepareOut(invert(root), root.value.ToString());
            result.Remove(1);
            result += "]";
            textBoxOut.Text = result;
        }

        private Node invert(Node node)
        {
            Node temp = node.left;
            node.left = node.right;
            node.right = temp;
            if(node.left != null)
            {
                node.left = invert(node.left);
            }
            if(node.right != null)
            {
                node.right = invert(node.right);
            }
            return node;

        }

        private string prepareOut(Node root, string result)
        {
            if(root.left != null)
            {
                result += "," + root.left.value;
            }
            if (root.right != null)
            {
                result += "," + root.right.value;
            }
            if (root.left != null)
            {
                result = prepareOut(root.left, result);
            }
            if (root.right != null)
            {
                result = prepareOut(root.right, result);
            }
            return result;
        }
    }
}
