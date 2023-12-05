using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_1
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

            public void addLeft(Node node)
            {
                left = node;
            }

            public void addRight(Node node)
            {
                right = node;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Node tree1;
            Node tree2;
            if(radioButton1.Checked == true)
            {
                tree1 = new Node(1);
                tree1.addLeft(new Node(2));
                tree1.addRight(new Node(3));
                tree2 = new Node(1);
                tree2.addLeft(new Node(2));
                tree2.addRight(new Node(3));
            }
            else if(radioButton2.Checked == true)
            {
                tree1 = new Node(1);
                tree1.addLeft(new Node(2));
                tree2 = new Node(1);
                tree2.addRight(new Node(2));
            }
            else
            {
                tree1 = new Node(1);
                tree1.addLeft(new Node(2));
                tree1.addRight(new Node(1));
                tree2 = new Node(1);
                tree2.addLeft(new Node(1));
                tree2.addRight(new Node(2));
            }
            if(checkTree(tree1, tree2) == true)
            {
                textBoxResult.Text = "Дерева однакові";
            }
            else
            {
                textBoxResult.Text = "Дерева різні";
            }
        }

        private bool checkTree(Node tree1, Node tree2)
        {
            bool thisCorrect = false;
            bool leftCorrect = false;
            bool rightCorrect = false;
            if(tree1.value == tree2.value)
            {
                thisCorrect = true;
                if(tree1.left == null)
                {
                    if(tree2.left == null)
                    {
                        leftCorrect = true;
                    }
                    else
                    {
                        leftCorrect = false;
                    }
                }
                else
                {
                    if (tree2.left == null)
                    {
                        leftCorrect = false;
                    }
                    else
                    {
                        leftCorrect = checkTree(tree1.left, tree2.left);
                    }
                }
                if (tree1.right == null)
                {
                    if (tree2.right == null)
                    {
                        rightCorrect = true;
                    }
                    else
                    {
                        rightCorrect = false;
                    }
                }
                else
                {
                    if (tree2.right == null)
                    {
                        rightCorrect = false;
                    }
                    else
                    {
                        rightCorrect = checkTree(tree1.right, tree2.right);
                    }
                }
            }
            if(thisCorrect == true && leftCorrect == true && rightCorrect == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
