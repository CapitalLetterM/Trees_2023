using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_9
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

            public Node()
            {
                left = null;
                right = null;
            }

            public Node(int val)
            {
                value = val;
                left = null;
                right = null;
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            int pointer = 0;
            Node root = new Node(getNumber(textBoxIn.Text, ref pointer));
            int depth = 0;
            root = recover(root, textBoxIn.Text, ref pointer, depth);
            string result = "[" + prepareOut(root, root.value.ToString());
            result.Remove(1);
            result += "]";
            textBoxOut.Text = result;
        }

        //потрібна функція
        private Node recover(Node root, string line, ref int pointer, int depth)
        {
            int level = countLines(line, ref pointer);
            if(level == depth + 1)
            {
                root.left = new Node(getNumber(line, ref pointer));
                root.left = recover(root.left, line, ref pointer, depth + 1);
            }
            else
            {
                pointer -= level;
            }

            level = countLines(line, ref pointer);
            if (level == depth + 1)
            {
                root.right = new Node(getNumber(line, ref pointer));
                root.right = recover(root.right, line, ref pointer, depth + 1);
            }
            else
            {
                pointer -= level;
            }
            return root;
        }

        private int getNumber(string line, ref int pointer)
        {
            string temp = "";
            for (int i = pointer; i < line.Length; i++)
            {
                if(char.IsNumber(line[i]))
                {
                    temp += line[i];
                }
                else
                {
                    pointer = i;
                    break;
                }
            }
            return Convert.ToInt32(temp);
        }

        private int countLines(string line, ref int pointer)
        {
            int counter = 0;
            for (int i = pointer; i < line.Length; i++)
            {
                if (line[i] == '-')
                {
                    counter++;
                }
                else
                {
                    pointer = i;
                    break;
                }
            }
            return counter;
        }

        private string prepareOut(Node root, string result)
        {
            if (root.left != null)
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
