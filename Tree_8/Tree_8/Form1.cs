using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_8
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
            root.deserialize(textBoxIn.Text);
            List<int[]> elements = new List<int[]>();
            elements = parse(root, elements);
            textBoxOut.Text = order(elements);
        }

        private List<int[]> parse(Node root, List<int[]> elements, int depth = 0, int side = 0)
        {
            int[] element = { root.value, depth, side};
            elements.Add(element);
            if(root.left != null)
            {
                elements = parse(root.left, elements, depth + 1, side - 1);
            }
            if(root.right != null)
            {
                elements = parse(root.right, elements, depth + 1, side + 1);
            }
            return elements;
        }

        //потрібна функція
        private string order(List<int[]> elements)
        {
            string result = "[";

            List<int[]> sorted = sortByValue(sortByWidth(sortByDepth(elements)));
            int currentSide = sorted[0][2];
            string tempResult = "[";
            for(int i = 0; i < sorted.Count; i++)
            {
                if(sorted[i][2] != currentSide)
                {
                    if(tempResult.Length > 2)
                    {
                        tempResult = tempResult.Substring(0, tempResult.Length - 2);
                    }
                    tempResult += "]";
                    result += tempResult + ", ";
                    tempResult = "[";
                    currentSide = sorted[i][2];
                }
                tempResult += sorted[i][0] + ", ";
            }
            result = result.Substring(0, result.Length - 2);
            result += "]";
            return result;
        }

        private List<int[]> sortByDepth(List<int[]> elements)
        {
            int depthMax = elements[0][1];
            for (int i = 1; i < elements.Count; i++)
            {
                if (elements[i][1] > depthMax)
                {
                    depthMax = elements[i][1];
                }
            }

            List<int[]> sorted = new List<int[]>();
            int j;
            for (int i = 0; i <= depthMax; i++)
            {
                for (j = 0; j < elements.Count; j++)
                {
                    if (elements[j][1] == i)
                    {
                        sorted.Add(elements[j]);
                    }
                }
            }
            return sorted;
        }

        private List<int[]> sortByWidth(List<int[]> elements)
        {
            int sideMin = elements[0][2];
            int sideMax = elements[0][2];
            for (int i = 1; i < elements.Count; i++)
            {
                if (elements[i][2] < sideMin)
                {
                    sideMin = elements[i][2];
                }
                if (elements[i][2] > sideMax)
                {
                    sideMax = elements[i][2];
                }
            }

            List<int[]> sorted = new List<int[]>();
            int j;
            for (int i = sideMin; i <= sideMax; i++)
            {
                for (j = 0; j < elements.Count; j++)
                {
                    if (elements[j][2] == i)
                    {
                        sorted.Add(elements[j]);
                    }
                }
            }
            return sorted;
        }

        private List<int[]> sortByValue(List<int[]> elements)
        {
            List<int[]> temp = new List<int[]>();
            List<int> indexes = new List<int>();
            for (int i = 0; i < elements.Count; i++)
            {
                for(int j = i; j < elements.Count; j++)
                {
                    if(j != i)
                    {
                        if(elements[j][1] == temp.Last()[1] && elements[j][2] == temp.Last()[2])
                        {
                            temp.Add(elements[j]);
                            indexes.Add(j);
                        }
                        else
                        {
                            if(temp.Count > 1)
                            {
                                temp = sort(temp);
                                for(int l = 0; l < temp.Count; l++)
                                {
                                    elements[indexes[l]] = temp[l];
                                }
                            }
                            temp.Clear();
                            indexes.Clear();
                            break;
                        }
                    }
                    else if(j == elements.Count - 1)
                    {
                        if (temp.Count > 1)
                        {
                            temp = sort(temp);
                            for (int l = 0; l < temp.Count; l++)
                            {
                                elements[indexes[l]] = temp[l];
                            }
                            temp.Clear();
                            indexes.Clear();
                        }
                    }
                    else
                    {
                        temp.Add(elements[j]);
                        indexes.Add(j);
                    }
                }
            }
            return elements;
        }

        private List<int[]> sort(List<int[]> elements)
        {
            List<int[]> sorted = new List<int[]>();
            while(elements.Count != 0)
            {
                int min = elements[0][0];
                int index = 0;
                for(int i = 0; i < elements.Count; i++)
                {
                    if(elements[i][0] < min)
                    {
                        min = elements[i][0];
                        index = i;
                    }
                }
                sorted.Add(elements[index]);
                elements.RemoveAt(index);
            }
            return sorted;
        }
    }
}
