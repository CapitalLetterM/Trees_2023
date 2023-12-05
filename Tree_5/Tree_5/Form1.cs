using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_5
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

            //1. записує в рядок своє значення, якщо це перший виклик
            //2. записує в рядок ліве значення(число або null)
            //3. записує в рядок ліве значення лівого(число або null), і так поки ліве значення не буде null
            //4. коли ліві значення закінчились, записує праве(число або null)
            //5. якщо праве значення не null => пункт 2
            //6. якщо праве значення null, повертаєтсья на рівень вище => пункт 5
            //7. коли закінчились ноди, повертає рядок
            public string serialize(string result = "")
            {
                bool first = false;
                if(result == "")
                {
                    first = true;
                    result = "[" + value;
                }
                result += ",";
                if(left == null)
                {
                    result += "null";
                }
                else
                {
                    result += left.value;
                    result = left.serialize(result);
                }
                result += ",";
                if (right == null)
                {
                    result += "null";
                }
                else
                {
                    result += right.value;
                    result = right.serialize(result);
                }
                if(first == true)
                {
                    result += "]";
                }
                return result;
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
                if(line[position + 1] == ']')
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
                if(line[position + 1] != 'n')
                {
                    left = new Node();
                    position = left.deserialize(line, position);
                }
                else
                {
                    position += 5;
                }
                if(line[position + 1] != 'n')
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

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            Node root = new Node();
            root.deserialize(textBoxIn.Text);
            textBoxOut.Text = root.serialize();
        }
    }
}
