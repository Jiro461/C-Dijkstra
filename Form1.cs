using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        static int kc = 0;
        List<Point1> Way = new List<Point1>();
        Graph g = new Graph(20);
        static List<Point1> points; // Tọa độ các điểm
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Painting(panel1.CreateGraphics(), button20.Left + button20.Width / 2, button20.Top + button20.Height / 2, button21.Left + button21.Width / 2, button21.Top + button21.Height / 2);
            //Painting(panel1.CreateGraphics(), button20.Left + button20.Width / 2, button20.Top + button20.Height / 2, button21.Left + button21.Width / 2, button21.Top + button21.Height / 2);
            //Painting(panel1.CreateGraphics(), button15.Left + button15.Width / 2, button15.Top + button15.Height / 2, button21.Left + button21.Width / 2, button21.Top + button21.Height / 2);
            //Painting(panel1.CreateGraphics(), button15.Left + button15.Width / 2, button15.Top + button15.Height / 2, button16.Left + button16.Width / 2, button16.Top + button16.Height / 2);
            //Painting(panel1.CreateGraphics(), button16.Left + button16.Width / 2, button16.Top + button16.Height / 2, button21.Left + button21.Width / 2, button21.Top + button21.Height / 2);
            //Painting(panel1.CreateGraphics(), button16.Left + button16.Width / 2, button16.Top + button16.Height / 2, button17.Left + button17.Width / 2, button17.Top + button17.Height / 2);
            //Painting(panel1.CreateGraphics(), button20.Left + button20.Width / 2, button20.Top + button20.Height / 2, button17.Left + button17.Width / 2, button17.Top + button17.Height / 2);
            //Painting(panel1.CreateGraphics(), button20.Left + button20.Width / 2, button20.Top + button20.Height / 2, button19.Left + button19.Width / 2, button19.Top + button19.Height / 2);
            //Painting(panel1.CreateGraphics(), button18.Left + button18.Width / 2, button18.Top + button18.Height / 2, button17.Left + button17.Width / 2, button17.Top + button17.Height / 2);
            //Painting(panel1.CreateGraphics(), button18.Left + button18.Width / 2, button18.Top + button18.Height / 2, button19.Left + button19.Width / 2, button19.Top + button19.Height / 2);
            //Painting(panel1.CreateGraphics(), button18.Left + button18.Width / 2, button18.Top + button18.Height / 2, button3.Left + button3.Width / 2, button3.Top + button3.Height / 2);
            //Painting(panel1.CreateGraphics(), button2.Left + button2.Width / 2, button2.Top + button2.Height / 2, button3.Left + button3.Width / 2, button3.Top + button3.Height / 2);
            //Painting(panel1.CreateGraphics(), button2.Left + button2.Width / 2, button2.Top + button2.Height / 2, button1.Left + button1.Width / 2, button1.Top + button1.Height / 2);
            //Painting(panel1.CreateGraphics(), button9.Left + button9.Width / 2, button9.Top + button9.Height / 2, button1.Left + button1.Width / 2, button1.Top + button1.Height / 2);
            //Painting(panel1.CreateGraphics(), button9.Left + button9.Width / 2, button9.Top + button9.Height / 2, button13.Left + button13.Width / 2, button13.Top + button13.Height / 2);
            //Painting(panel1.CreateGraphics(), button16.Left + button16.Width / 2, button16.Top + button16.Height / 2, button13.Left + button13.Width / 2, button13.Top + button13.Height / 2);
            //Painting(panel1.CreateGraphics(), button5.Left + button5.Width / 2, button5.Top + button5.Height / 2, button1.Left + button1.Width / 2, button1.Top + button1.Height / 2);
            //Painting(panel1.CreateGraphics(), button5.Left + button5.Width / 2, button5.Top + button5.Height / 2, button9.Left + button9.Width / 2, button9.Top + button9.Height / 2);
            //Painting(panel1.CreateGraphics(), button5.Left + button5.Width / 2, button5.Top + button5.Height / 2, button13.Left + button13.Width / 2, button13.Top + button13.Height / 2);
            //Painting(panel1.CreateGraphics(), button5.Left + button5.Width / 2, button5.Top + button5.Height / 2, button16.Left + button16.Width / 2, button16.Top + button16.Height / 2);
            //Painting(panel1.CreateGraphics(), button5.Left + button5.Width / 2, button5.Top + button5.Height / 2, button17.Left + button17.Width / 2, button17.Top + button17.Height / 2);
            //Painting(panel1.CreateGraphics(), button14.Left + button14.Width / 2, button14.Top + button14.Height / 2, button13.Left + button13.Width / 2, button13.Top + button13.Height / 2);
            //Painting(panel1.CreateGraphics(), button14.Left + button14.Width / 2, button14.Top + button14.Height / 2, button15.Left + button15.Width / 2, button15.Top + button15.Height / 2);
            //Painting(panel1.CreateGraphics(), button12.Left + button12.Width / 2, button12.Top + button12.Height / 2, button9.Left + button9.Width / 2, button9.Top + button9.Height / 2);
            //Painting(panel1.CreateGraphics(), button12.Left + button12.Width / 2, button12.Top + button12.Height / 2, button13.Left + button13.Width / 2, button13.Top + button13.Height / 2);
            //Painting(panel1.CreateGraphics(), button12.Left + button12.Width / 2, button12.Top + button12.Height / 2, button14.Left + button14.Width / 2, button14.Top + button14.Height / 2);
            //Painting(panel1.CreateGraphics(), button12.Left + button12.Width / 2, button12.Top + button12.Height / 2, button11.Left + button11.Width / 2, button11.Top + button11.Height / 2);
            //Painting(panel1.CreateGraphics(), button9.Left + button9.Width / 2, button9.Top + button9.Height / 2, button11.Left + button11.Width / 2, button11.Top + button11.Height / 2);
            //Painting(panel1.CreateGraphics(), button9.Left + button9.Width / 2, button9.Top + button9.Height / 2, button10.Left + button10.Width / 2, button10.Top + button10.Height / 2);
            //Painting(panel1.CreateGraphics(), button11.Left + button11.Width / 2, button11.Top + button11.Height / 2, button10.Left + button10.Width / 2, button10.Top + button10.Height / 2);
            //Painting(panel1.CreateGraphics(), button6.Left + button6.Width / 2, button6.Top + button6.Height / 2, button10.Left + button10.Width / 2, button10.Top + button10.Height / 2);
            //Painting(panel1.CreateGraphics(), button6.Left + button6.Width / 2, button6.Top + button6.Height / 2, button9.Left + button9.Width / 2, button9.Top + button9.Height / 2);
            //Painting(panel1.CreateGraphics(), button6.Left + button6.Width / 2, button6.Top + button6.Height / 2, button8.Left + button8.Width / 2, button8.Top + button8.Height / 2);
            //Painting(panel1.CreateGraphics(), button7.Left + button7.Width / 2, button7.Top + button7.Height / 2, button8.Left + button8.Width / 2, button8.Top + button8.Height / 2);
            //Painting(panel1.CreateGraphics(), button7.Left + button7.Width / 2, button7.Top + button7.Height / 2, button1.Left + button1.Width / 2, button1.Top + button1.Height / 2);
            //Painting(panel1.CreateGraphics(), button7.Left + button7.Width / 2, button7.Top + button7.Height / 2, button2.Left + button2.Width / 2, button2.Top + button2.Height / 2);
            //g.AddPoint(257, 403); //0
            //g.AddPoint(234, 524); //1
            //g.AddPoint(330, 544); //2
            //g.AddPoint(377, 290); //3
            //g.AddPoint(96, 267); //4
            //g.AddPoint(145, 430); //5
            //g.AddPoint(84, 369); //6
            //g.AddPoint(273, 233); //7
            //g.AddPoint(130, 174); //8
            //g.AddPoint(206, 210); //9
            //g.AddPoint(319, 137); //10
            //g.AddPoint(392, 174); //11
            //g.AddPoint(439, 64); //12
            //g.AddPoint(529, 174); //13
            //g.AddPoint(505, 280); //14
            //g.AddPoint(518, 403); //15
            //g.AddPoint(424, 576); //16
            //g.AddPoint(539, 524); //17
            //g.AddPoint(617, 447); //18
            //g.AddPoint(617, 322); //19
            g.AddPoint(button1.Location.X, button1.Location.Y, 0, button1.Left, button1.Width, button1.Top, button1.Height);
            g.AddPoint(button2.Location.X, button2.Location.Y, 1, button2.Left, button2.Width, button2.Top, button2.Height);
            g.AddPoint(button3.Location.X, button3.Location.Y, 2, button3.Left, button3.Width, button3.Top, button3.Height);
            g.AddPoint(button5.Location.X, button5.Location.Y, 3, button5.Left, button5.Width, button5.Top, button5.Height);
            g.AddPoint(button6.Location.X, button6.Location.Y, 4, button6.Left, button6.Width, button6.Top, button6.Height);
            g.AddPoint(button7.Location.X, button7.Location.Y, 5, button7.Left, button7.Width, button7.Top, button7.Height);
            g.AddPoint(button8.Location.X, button8.Location.Y, 6, button8.Left, button8.Width, button8.Top, button8.Height);
            g.AddPoint(button9.Location.X, button9.Location.Y, 7, button9.Left, button9.Width, button9.Top, button9.Height);
            g.AddPoint(button10.Location.X, button10.Location.Y, 8, button10.Left, button10.Width, button10.Top, button10.Height);
            g.AddPoint(button11.Location.X, button11.Location.Y, 9, button11.Left, button11.Width, button11.Top, button11.Height);
            g.AddPoint(button12.Location.X, button12.Location.Y, 10, button12.Left, button12.Width, button12.Top, button12.Height);
            g.AddPoint(button13.Location.X, button13.Location.Y, 11, button13.Left, button13.Width, button13.Top, button13.Height);
            g.AddPoint(button14.Location.X, button14.Location.Y, 12, button14.Left, button14.Width, button14.Top, button14.Height);
            g.AddPoint(button15.Location.X, button15.Location.Y, 13, button15.Left, button15.Width, button15.Top, button15.Height);
            g.AddPoint(button16.Location.X, button16.Location.Y, 14, button16.Left, button16.Width, button16.Top, button16.Height);
            g.AddPoint(button17.Location.X, button17.Location.Y, 15, button17.Left, button17.Width, button17.Top, button17.Height);
            g.AddPoint(button18.Location.X, button18.Location.Y, 16, button18.Left, button18.Width, button18.Top, button18.Height);
            g.AddPoint(button19.Location.X, button19.Location.Y, 17, button19.Left, button19.Width, button19.Top, button19.Height);
            g.AddPoint(button20.Location.X, button20.Location.Y, 18, button20.Left, button20.Width, button20.Top, button20.Height);
            g.AddPoint(button21.Location.X, button21.Location.Y, 19, button21.Left, button21.Width, button21.Top, button21.Height);
            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(2, 16);
            g.AddEdge(17, 16);
            g.AddEdge(16, 15);
            g.AddEdge(16, 15);
            g.AddEdge(17, 18);
            g.AddEdge(15, 18);
            g.AddEdge(19, 18);
            g.AddEdge(14, 15);
            g.AddEdge(14, 19);
            g.AddEdge(13, 19);
            g.AddEdge(14, 19);
            g.AddEdge(13, 14);
            g.AddEdge(12, 13);
            g.AddEdge(13, 14);
            g.AddEdge(12, 11);
            g.AddEdge(11, 14);
            g.AddEdge(11, 14);
            g.AddEdge(11, 3);
            g.AddEdge(14, 3);
            g.AddEdge(15, 3);
            g.AddEdge(12, 10);
            g.AddEdge(10, 11);
            g.AddEdge(10, 7);
            g.AddEdge(3, 7);
            g.AddEdge(0, 7);
            g.AddEdge(3, 0);
            g.AddEdge(0, 5);
            g.AddEdge(1, 5);
            g.AddEdge(6, 5);
            g.AddEdge(6, 4);
            g.AddEdge(7, 4);
            g.AddEdge(7, 8);
            g.AddEdge(4, 8);
            g.AddEdge(9, 8);
            g.AddEdge(9, 7);
            g.AddEdge(9, 10);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            HandleButtonClick(18, sender, e);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            HandleButtonClick(19, sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            HandleButtonClick(13, sender, e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            HandleButtonClick(14, sender, e);
        }
        private void HandleButtonClick(int destinationIndex, object sender, EventArgs e)
        {
            kc = 0;
            label3_Click(sender, e);
            if (Way.Count() == 0)
            {
                Way.Add(new Point1 { x = points[destinationIndex].x, y = points[destinationIndex].y, z = destinationIndex });
            }
            else if(Way.Count() % 2 == 1)
            {
                g.Dijkstra(Way[0].z, points[destinationIndex].z, panel1.CreateGraphics());
                label3_Click(sender, e);
                Way.Add(new Point1 { x = points[destinationIndex].x, y = points[destinationIndex].y, z = destinationIndex });
            }
            else
            {
                Refresh();
                Way = new List<Point1>();
                Way.Add(new Point1 { x = points[destinationIndex].x, y = points[destinationIndex].y, z = destinationIndex });
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            HandleButtonClick(15, sender, e);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            HandleButtonClick(17, sender, e);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            HandleButtonClick(16, sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(2, sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(1, sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(0, sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HandleButtonClick(7, sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HandleButtonClick(11, sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(3, sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            HandleButtonClick(12, sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HandleButtonClick(10, sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HandleButtonClick(9, sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HandleButtonClick(8, sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandleButtonClick(4, sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HandleButtonClick(6, sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleButtonClick(5, sender, e);
        }
        public struct Point1
        {
            public int x, y, z;
            public int left, width, top, height;
        }
        public struct Node
        {
            public int index;
            public double distance;
            public int x; 
            public int y;
            public int left, width, top, height;
        }
        public class CompareNode : IComparer<Node>
        {
            public int Compare(Node a, Node b)
            {
                return a.distance.CompareTo(b.distance);
            }
        }
        public class Graph
        {
            private int V; // Số đỉnh
            private List<List<Tuple<int, double>>> adjList; 

            public Graph(int vertices)
            {
                V = vertices;
                points = new List<Point1>();
                adjList = new List<List<Tuple<int, double>>>(V);
                for (int i = 0; i < V; i++)
                {
                    adjList.Add(new List<Tuple<int, double>>());
                }
            }
            // Thêm cạnh vào đồ thị
            public void AddEdge(int u, int v)
            {
                double weight = CalculateDistance(points[u], points[v]);
                adjList[u].Add(new Tuple<int, double>(v, weight));
                adjList[v].Add(new Tuple<int, double>(u, weight));
            }
            // Tính khoảng cách Euclid giữa hai điểm
            private double CalculateDistance(Point1 a, Point1 b)
            {
                return Math.Round(Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2)), 2);
            }
            // Thuật toán Dijkstra
            public void Dijkstra(int start, int end, Graphics g)
            {
                double[] distance = new double[V];
                int[] prevVertex = new int[V];
                int[] prevX = new int[V];
                int[] prevY = new int[V];
                int[] prevLeft = new int[V];   
                int[] prevWidth = new int[V];  
                int[] prevTop = new int[V];    
                int[] prevHeight = new int[V]; 
                for (int i = 0; i < V; i++)
                {
                    distance[i] = double.MaxValue;
                }
                PriorityQueue<Node> pq = new PriorityQueue<Node>(new CompareNode());
                distance[start] = 0;
                pq.Enqueue(new Node { index = start, distance = 0, x = points[start].x, y = points[start].y, left = points[start].left, width = points[start].width, top = points[start].top, height = points[start].height });

                while (pq.Count > 0)
                {
                    Node uNode = pq.Dequeue();
                    int u = uNode.index;
                    double dist_u = uNode.distance;

                    foreach (var neighbor in adjList[u])
                    {
                        int v = neighbor.Item1;
                        double weight_uv = neighbor.Item2;

                        if (dist_u + weight_uv < distance[v])
                        {
                            distance[v] = dist_u + weight_uv;
                            prevVertex[v] = u;
                            prevX[v] = uNode.x;
                            prevY[v] = uNode.y;
                            prevLeft[v] = uNode.left;
                            prevWidth[v] = uNode.width;
                            prevTop[v] = uNode.top;
                            prevHeight[v] = uNode.height;

                            pq.Enqueue(new Node
                            {
                                index = v,
                                distance = distance[v],
                                x = points[v].x,
                                y = points[v].y,
                                left = points[v].left,
                                width = points[v].width,
                                top = points[v].top,
                                height = points[v].height
                            });
                        }
                    }
                }

                PrintPath(start, end, prevVertex, prevX, prevY, g, prevLeft, prevWidth, prevTop, prevHeight);
            }
            private void PrintPath(int start, int end, int[] prevVertex, int[] prevX, int[] prevY, Graphics g, int[] prevLeft, int[] prevWidth, int[] prevTop, int[] prevHeight)
            {
                List<Tuple<int, int, int, int, int, int>> path = new List<Tuple<int, int, int, int, int, int>>();
                int current = end;
                while (current != start && current >= 0 && current < prevVertex.Length)
                {
                    path.Add(new Tuple<int, int, int, int, int, int>(prevX[current], prevY[current], prevLeft[current], prevWidth[current], prevTop[current], prevHeight[current]) );
                    current = prevVertex[current];
                }
                path.Reverse();
                path.Add(new Tuple<int, int, int, int, int, int>(points[end].x, points[end].y, prevLeft[end], prevWidth[end], prevTop[end], prevHeight[end]));
                for (int i = 1; i < path.Count; i++)
                {
                    Tuple<int, int, int, int, int, int> currentTuple = path[i];
                    Tuple<int, int, int, int, int, int> previousTuple = path[i - 1];
                    kc += EuclidDistance(currentTuple.Item1, currentTuple.Item2, previousTuple.Item1, previousTuple.Item2);
                    Marking(g, previousTuple.Item1 + previousTuple.Item4 / 2, previousTuple.Item2 + previousTuple.Item6 / 2, currentTuple.Item1 + currentTuple.Item4 / 2, currentTuple.Item2 + currentTuple.Item6 / 2);
                }
            }
            // Thêm điểm vào đồ thị
            public void AddPoint(int x, int y, int z, int left, int width, int top, int height)
            {
                points.Add(new Point1 { x = x, y = y, z = z, left = left, width = width, top = top, height = height});
            }
        }
        static public int EuclidDistance (int a, int b, int c, int d)
        {
            return (int)Math.Sqrt(Math.Pow(a - c, 2) + Math.Pow(b - d, 2));
        }
        public class PriorityQueue<T> : SortedSet<T>
        {
            public PriorityQueue() : base() { }
            public PriorityQueue(IComparer<T> comparer) : base(comparer) { }

            public void Enqueue(T item)
            {
                Add(item);
            }

            public T Dequeue()
            {
                T item = this.First();
                this.Remove(item);
                return item;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = kc.ToString();
            label3.Text = "Distance: " + kc;
            kc = 0;
        }
    }
}
