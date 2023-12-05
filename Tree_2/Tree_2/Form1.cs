using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_2
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

        private void buttonDetermine_Click(object sender, EventArgs e)
        {
            Node tree;
            if(radioButton1.Checked == true)
            {
                tree = new Node(1);
                tree.left = new Node(2);
                tree.left.left = new Node(3);
                tree.left.right = new Node(4);
                tree.right = new Node(2);
                tree.right.left = new Node(4);
                tree.right.right = new Node(3);
            }
            else
            {
                tree = new Node(1);
                tree.left = new Node(2);
                tree.left.right = new Node(3);
                tree.right = new Node(2);
                tree.right.right = new Node(3);
            }
            if(check(tree) == true)
            {
                textBoxOut.Text = "Дерево дзеркальне";
            }
            else
            {
                textBoxOut.Text = "Дерево не дзеркальне";
            }
        }

        private bool check(Node tree)
        {
            List<string> left = checkLeft(new List<string>(), tree.left);
            List<string> right = checkRight(new List<string>(), tree.right);
            if(left.Count == right.Count)
            {
                for(int i = 0; i < left.Count; i++)
                {
                    if(left[i] != right[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<string> checkLeft(List<string> list, Node leaf)
        {
            if(leaf == null)
            {
                list.Add("null");
            }
            else
            {
                list.Add(leaf.value.ToString());
                list = checkLeft(list, leaf.left);
                list = checkLeft(list, leaf.right);
            }
            return list;
        }

        private List<string> checkRight(List<string> list, Node leaf)
        {
            if (leaf == null)
            {
                list.Add("null");
            }
            else
            {
                list.Add(leaf.value.ToString());
                list = checkRight(list, leaf.right);
                list = checkRight(list, leaf.left);
            }
            return list;
        }
    }
}
