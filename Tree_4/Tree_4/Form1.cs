using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_4
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

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Node root;
            if(radioButton1.Checked == true)
            {
                root = new Node(3);
                root.left = new Node(1);
                root.right = new Node(4);
                root.left.right = new Node(2);
            }
            else
            {
                root = new Node(5);
                root.left = new Node(3);
                root.right = new Node(6);
                root.left.left = new Node(2);
                root.left.right = new Node(4);
                root.left.left.left = new Node(1);
            }
            textBoxOut.Text = minK(root, Convert.ToInt32(textBoxK.Text)).ToString();
        }

        private int minK(Node root, int k)
        {
            int min = -1;
            for(int i = 0; i < k; i++)
            {
                min = findMin(root, 10001, min);
            }
            return min;
        }

        private int findMin(Node root, int currentMin, int ignore)
        {
            if(root.value < currentMin && root.value > ignore)
            {
                currentMin = root.value;
            }
            if(root.left != null)
            {
                currentMin = findMin(root.left, currentMin, ignore);
            }
            if(root.right != null)
            {
                currentMin = findMin(root.right, currentMin, ignore);
            }
            return currentMin;
        }
    }
}
