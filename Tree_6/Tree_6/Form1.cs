using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_6
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

            //1. якщо рядок "[]" завершує роботу
            //2. записує своє число
            //3. перевіряє наступне число, якщо не null, додає лівий нод та в ньому рекурсивно запускає цей код
            //4. якщо null, переступає його
            //5. перевіряє наступне число, якщо не null, додає правий нод та в ньому рекурсивно запускає цей код
            //6. якщо null, переступає його
            //7. повертає позицію поточну позицію в line
            public int deserialize(string line, int position = 0)
            {
                if (line[position + 1] == ']')
                {
                    return 0;
                }
                string number = "";
                position++;
                while (line[position] != ',')
                {
                    number += line[position];
                    position++;
                }
                value = Convert.ToInt32(number);
                if (line[position + 1] != 'n')
                {
                    left = new Node();
                    position = left.deserialize(line, position);
                }
                else
                {
                    position += 5;
                }
                if (line[position + 1] != 'n')
                {
                    right = new Node();
                    position = right.deserialize(line, position);
                }
                else
                {
                    position += 5;
                }
                return position;
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            Node root = new Node();
            int total = -9999;
            root.deserialize(textBoxIn.Text);
            findSum(root, ref total);
            textBoxOut.Text = total.ToString();
        }

        private int findSum(Node root, ref int total)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                int left = findSum(root.left, ref total);
                int right = findSum(root.right, ref total);
                int max = root.value;
                if(left >= 0 || right >= 0)
                {
                    if(max + left + right > max)
                    {
                        max += left + right; 
                    }
                    else if (left + root.value > right + root.value)
                    {
                        max += left;
                    }
                    else
                    {
                        max += right;
                    }
                }
                if(max > total)
                {
                    total = max;
                }
                int temp = root.value;
                if(left > right)
                {
                    temp += left;
                }
                else
                {
                    temp += right;
                }
                if(root.value > temp)
                {
                    return root.value;
                }
                else
                {
                    return temp;
                }
            }
        }
    }
}
