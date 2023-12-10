using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PointAndEdgeAdd();
            AddDataSource();
            AddLocation();
        }
        #region Thuật toán Dijkstra - Tìm đường đi ngắn nhất
        public void PointAndEdgeAdd() //Thêm đỉnh và cạnh
        {
            g.AddPoint(button0.Location.X, button0.Location.Y, 0, button0.Left, button0.Width, button0.Top, button0.Height);
            g.AddPoint(button1.Location.X, button1.Location.Y, 1, button1.Left, button1.Width, button1.Top, button1.Height);
            g.AddPoint(button2.Location.X, button2.Location.Y, 2, button2.Left, button2.Width, button2.Top, button2.Height);
            g.AddPoint(button3.Location.X, button3.Location.Y, 3, button3.Left, button3.Width, button3.Top, button3.Height);
            g.AddPoint(button4.Location.X, button4.Location.Y, 4, button4.Left, button4.Width, button4.Top, button4.Height);
            g.AddPoint(button5.Location.X, button5.Location.Y, 5, button5.Left, button5.Width, button5.Top, button5.Height);
            g.AddPoint(button6.Location.X, button6.Location.Y, 6, button6.Left, button6.Width, button6.Top, button6.Height);
            g.AddPoint(button7.Location.X, button7.Location.Y, 7, button7.Left, button7.Width, button7.Top, button7.Height);
            g.AddPoint(button8.Location.X, button8.Location.Y, 8, button8.Left, button8.Width, button8.Top, button8.Height);
            g.AddPoint(button9.Location.X, button9.Location.Y, 9, button9.Left, button9.Width, button9.Top, button9.Height);
            g.AddPoint(button10.Location.X, button10.Location.Y, 10, button10.Left, button10.Width, button10.Top, button10.Height);
            g.AddPoint(button11.Location.X, button11.Location.Y, 11, button11.Left, button11.Width, button11.Top, button11.Height);
            g.AddPoint(button12.Location.X, button12.Location.Y, 12, button12.Left, button12.Width, button12.Top, button12.Height);
            g.AddPoint(button13.Location.X, button13.Location.Y, 13, button13.Left, button13.Width, button13.Top, button13.Height);
            g.AddPoint(button14.Location.X, button14.Location.Y, 14, button14.Left, button14.Width, button14.Top, button14.Height);
            g.AddPoint(button15.Location.X, button15.Location.Y, 15, button15.Left, button15.Width, button15.Top, button15.Height);
            g.AddPoint(button16.Location.X, button16.Location.Y, 16, button16.Left, button16.Width, button16.Top, button16.Height);
            g.AddPoint(button17.Location.X, button17.Location.Y, 17, button17.Left, button17.Width, button17.Top, button17.Height);
            g.AddPoint(button18.Location.X, button18.Location.Y, 18, button18.Left, button18.Width, button18.Top, button18.Height);
            g.AddPoint(button19.Location.X, button19.Location.Y, 19, button19.Left, button19.Width, button19.Top, button19.Height);
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
            g.AddEdge(11, 7);
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
        static int kc = 0; //Biến chứa khoảng cách giữa 2 địa điểm
        List<Point1> Way = new List<Point1>();
        Graph g = new Graph(20);
        static List<Point1> points; // Tọa độ các điểm

        public struct Point1 //Định nghĩa cấu trúc Point1
        {
            public int x, y, z;
            public int left, width, top, height;
        }

        public struct Node //Định nghĩa cấu trúc node
        {
            public int index;
            public double distance;
            public int x;
            public int y;
            public int left, width, top, height;
        }

        public class CompareNode : IComparer<Node> //Hàm so sánh cho PriorityQueue
        {
            public int Compare(Node a, Node b)
            {
                return a.distance.CompareTo(b.distance); //Khoảng cách nhỏ nhất ở trên cùng
            }
        }

        public class PriorityQueue<T> : SortedSet<T> //Định dạng PriorityQueue từ SortedSet
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
        static public int EuclidDistance(int a, int b, int c, int d)
        {
            return (int)Math.Sqrt(Math.Pow(a - c, 2) + Math.Pow(b - d, 2));
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

            // Thêm điểm vào đồ thị
            public void AddPoint(int x, int y, int z, int left, int width, int top, int height)
            {
                points.Add(new Point1 { x = x, y = y, z = z, left = left, width = width, top = top, height = height }); //Thêm các thuộc tính cho mỗi điểm
            }

            // Tính khoảng cách Euclid giữa hai điểm
            private double CalculateDistance(Point1 a, Point1 b)
            {
                return Math.Round(Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2)), 2);
            }

            // Thuật toán Dijkstra
            public void Dijkstra(int start, int end, Graphics g)
            {
                double[] distance = new double[V]; //mảng lưu khoảng cách nhỏ nhất của điểm
                int[] prevVertex = new int[V]; //mảng lưu điểm (index)
                int[] prevX = new int[V]; //mảng lưu Y tương ứng
                int[] prevY = new int[V]; //mảng lưu X tương ứng
                int[] prevLeft = new int[V]; //mảng lưu left tương ứng
                int[] prevWidth = new int[V]; //mảng lưu width tương ứng
                int[] prevTop = new int[V]; //mảng lưu top tương ứng
                int[] prevHeight = new int[V]; //mảng lưu height tương ứng
                for (int i = 0; i < V; i++)
                {
                    distance[i] = double.MaxValue; //Mặc định khoảng cách từ điểm đẩu tiên tới các đỉnh còn lại là vô cực
                }
                PriorityQueue<Node> pq = new PriorityQueue<Node>(new CompareNode()); //Định dạng Hàng chờ ưu tiên từ SortedSet
                distance[start] = 0; //khởi tạo khoảng cách từ nó tới chỉnh nó
                pq.Enqueue(new Node { index = start, distance = 0, x = points[start].x, y = points[start].y, left = points[start].left, width = points[start].width, top = points[start].top, height = points[start].height }); // Các thuộc tính của điểm đầu tiên (hoặc điểm Start)

                while (pq.Count > 0)
                {
                    Node uNode = pq.Dequeue();
                    int u = uNode.index; //đỉnh xét hiện tại
                    double dist_u = uNode.distance; //Khoảng cách nhỏ nhất điểm đang lưu trữ

                    foreach (var neighbor in adjList[u]) //adjList[u].(v, weight(khoảng cách u và v))
                    {
                        int v = neighbor.Item1; //điểm v
                        double weight_uv = neighbor.Item2; //Khoảng cách 2 điểm u và v

                        if (dist_u + weight_uv < distance[v]) //Nếu tổng của đỉnh đang xét (u) + trọng số của 2 đỉnh u và v bé hơn thì cập nhật
                        {
                            distance[v] = dist_u + weight_uv; //cập nhật Giá trị nhò hơn
                            prevVertex[v] = u; // đỉnh trước v là đỉnh u (lưu lại đường đi)
                            prevX[v] = uNode.x; //X trước của v (X của u)
                            prevY[v] = uNode.y; //Y trước của v (Y của u)
                            prevLeft[v] = uNode.left; //Left trước của v (Left của u)
                            prevWidth[v] = uNode.width; //Width trước của v (Width của u)
                            prevTop[v] = uNode.top; //Top trước của v (Top của u)
                            prevHeight[v] = uNode.height; //Height trước của v (Height của u)
                            pq.Enqueue(new Node //Thêm các thuộc tính của điểm v
                            {
                                index = v, //Thêm điểm v vào hàng chờ ưu tiên
                                distance = distance[v], // khoảng cách nhỏ nhất của điểm v là khoảng cách vừa cập nhật
                                x = points[v].x, //x của điểm v
                                y = points[v].y, // y của điểm v
                                left = points[v].left, //left của điểm v
                                width = points[v].width, // width của điểm v
                                top = points[v].top, //top của điểm v
                                height = points[v].height //height của điểm v
                            });
                        }
                    }
                }

                PrintPath(start, end, prevVertex, prevX, prevY, g, prevLeft, prevWidth, prevTop, prevHeight);
            }

            private void PrintPath(int start, int end, int[] prevVertex, int[] prevX, int[] prevY, Graphics g, int[] prevLeft, int[] prevWidth, int[] prevTop, int[] prevHeight)
            {
                List<Tuple<int, int, int, int, int, int>> path = new List<Tuple<int, int, int, int, int, int>>(); //X, Y, Left, Width, Top, Height
                int current = end;
                while (current != start && current >= 0 && current < prevVertex.Length)
                {
                    path.Add(new Tuple<int, int, int, int, int, int>(prevX[current], prevY[current], prevLeft[current], prevWidth[current], prevTop[current], prevHeight[current]));
                    current = prevVertex[current]; //mò lại cạnh trước đó (prevVertex) của cạnh hiện tại đang xét (current)
                }
                path.Reverse(); //đảo ngược lại vị trí
                path.Add(new Tuple<int, int, int, int, int, int>(points[end].x, points[end].y, prevLeft[end], prevWidth[end], prevTop[end], prevHeight[end]));
                for (int i = 1; i < path.Count; i++)
                {
                    Tuple<int, int, int, int, int, int> currentTuple = path[i]; //Điểm hiện tại
                    Tuple<int, int, int, int, int, int> previousTuple = path[i - 1]; //Điểm trước
                    kc += EuclidDistance(currentTuple.Item1, currentTuple.Item2, previousTuple.Item1, previousTuple.Item2); //Khoảng cách 2 điểm
                    Marking(g, previousTuple.Item1 + previousTuple.Item4 / 2, previousTuple.Item2 + previousTuple.Item6 / 2, currentTuple.Item1 + currentTuple.Item4 / 2, currentTuple.Item2 + currentTuple.Item6 / 2);
                }
            }
        }
        #endregion

        #region Các chức năng chính

        #region Hover qua các địa điểm
        private void Form1_Load(object sender, EventArgs e)
        {
            this.button0.MouseHover += new EventHandler(Button_MouseHover);
            this.button0.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button1.MouseHover += new EventHandler(Button_MouseHover);
            this.button1.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button2.MouseHover += new EventHandler(Button_MouseHover);
            this.button2.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button3.MouseHover += new EventHandler(Button_MouseHover);
            this.button3.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button4.MouseHover += new EventHandler(Button_MouseHover);
            this.button4.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button5.MouseHover += new EventHandler(Button_MouseHover);
            this.button5.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button6.MouseHover += new EventHandler(Button_MouseHover);
            this.button6.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button7.MouseHover += new EventHandler(Button_MouseHover);
            this.button7.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button8.MouseHover += new EventHandler(Button_MouseHover);
            this.button8.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button9.MouseHover += new EventHandler(Button_MouseHover);
            this.button9.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button10.MouseHover += new EventHandler(Button_MouseHover);
            this.button10.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button11.MouseHover += new EventHandler(Button_MouseHover);
            this.button11.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button12.MouseHover += new EventHandler(Button_MouseHover);
            this.button12.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button13.MouseHover += new EventHandler(Button_MouseHover);
            this.button13.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button14.MouseHover += new EventHandler(Button_MouseHover);
            this.button14.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button15.MouseHover += new EventHandler(Button_MouseHover);
            this.button15.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button16.MouseHover += new EventHandler(Button_MouseHover);
            this.button16.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button17.MouseHover += new EventHandler(Button_MouseHover);
            this.button17.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button18.MouseHover += new EventHandler(Button_MouseHover);
            this.button18.MouseLeave += new EventHandler(Button_MouseLeave);

            this.button19.MouseHover += new EventHandler(Button_MouseHover);
            this.button19.MouseLeave += new EventHandler(Button_MouseLeave);
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            // Sử dụng nút mà sự kiện đang được gọi, không tạo nút mới
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null && button.Tag != null)
            {
                // Hiển thị RichTextBox và thiết lập nội dung
                this.rtbDetail.Text = button.Tag.ToString();
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Xóa nội dung của TextBox khi chuột rời khỏi Button
            this.rtbDetail.Text = "";
        }
        #endregion

        #region Tìm kiếm địa điểm theo tên

        public class LocationDataSource //Tạo class chứa thuộc tính Tên các địa điểm
        {
            public string Name { get; set; }
        }
        public void AddDataSource() //Thêm dữ liệu vào combobox
        {
            List<LocationDataSource> LocationDataSource1 = new List<LocationDataSource>() //Tạo List chứa class DataSource
            {
                new LocationDataSource(){  Name = MLocation0.Text },
                new LocationDataSource(){  Name = MLocation1.Text },
                new LocationDataSource(){  Name = MLocation2.Text },
                new LocationDataSource(){  Name = MLocation3.Text },
                new LocationDataSource(){  Name = MLocation4.Text },
                new LocationDataSource(){  Name = MLocation5.Text },
                new LocationDataSource(){  Name = MLocation6.Text },
                new LocationDataSource(){  Name = MLocation7.Text },
                new LocationDataSource(){  Name = MLocation8.Text },
                new LocationDataSource(){  Name = MLocation9.Text },
                new LocationDataSource(){  Name = MLocation10.Text },
                new LocationDataSource(){  Name = MLocation11.Text },
                new LocationDataSource(){  Name = MLocation12.Text },
                new LocationDataSource(){  Name = MLocation13.Text },
                new LocationDataSource(){  Name = MLocation14.Text },
                new LocationDataSource(){  Name = MLocation15.Text },
                new LocationDataSource(){  Name = MLocation16.Text },
                new LocationDataSource(){  Name = MLocation17.Text },
                new LocationDataSource(){  Name = MLocation18.Text },
                new LocationDataSource(){  Name = MLocation19.Text },
                new LocationDataSource(){}
            };
            List<LocationDataSource> LocationDataSource2 = new List<LocationDataSource>(LocationDataSource1); //Tạo bản sao của DataSource1 
            comboBox1.DataSource = LocationDataSource1; //Thêm DataSource vào comboBox
            comboBox2.DataSource = LocationDataSource2;
            comboBox1.DisplayMember = "Name"; //Đặt hiển thị của comboBox là Tên các địa điểm
            comboBox2.DisplayMember = "Name";
            comboBox1.SelectedIndex = 20; //Đặt hiển thị mặc định là rỗng
            comboBox2.SelectedIndex = 20;
        }
        List<Label> LocationList = new List<Label>(); //List chứa danh sách các địa điểm
        public void AddLocation() //Thêm dữ liệu của các địa điểm vào 1 list
        {
            //Thêm địa điểm vào LocationList
            LocationList.Add(MLocation0);
            LocationList.Add(MLocation1);
            LocationList.Add(MLocation2);
            LocationList.Add(MLocation3);
            LocationList.Add(MLocation4);
            LocationList.Add(MLocation5);
            LocationList.Add(MLocation6);
            LocationList.Add(MLocation7);
            LocationList.Add(MLocation8);
            LocationList.Add(MLocation9);
            LocationList.Add(MLocation10);
            LocationList.Add(MLocation11);
            LocationList.Add(MLocation12);
            LocationList.Add(MLocation13);
            LocationList.Add(MLocation14);
            LocationList.Add(MLocation15);
            LocationList.Add(MLocation16);
            LocationList.Add(MLocation17);
            LocationList.Add(MLocation18);
            LocationList.Add(MLocation19);
        }

        private void Search_Click(object sender, EventArgs e) //Xử lí event Click button Search
        {
            string startLocation = comboBox1.Text;
            string endLocation = comboBox2.Text;
            foreach (Label location in LocationList)
            {
                if (startLocation.ToLower() == location.Text.ToLower())
                {
                    HandleButtonClickSearch(GetNumberFromText(location.Name));
                    PrintDistance();
                }

                if (endLocation.ToLower() == location.Text.ToLower())
                {
                    HandleButtonClickSearch(GetNumberFromText(location.Name));
                    PrintDistance();
                }
            }
        }

        private void HandleButtonClickSearch(int destinationIndex) //Hàm HandleButtonClick thay đổi tham số
        {
            kc = 0;

            if (Way.Count() == 0)
            {
                Way.Add(new Point1 { x = points[destinationIndex].x, y = points[destinationIndex].y, z = destinationIndex });
            }
            else if (Way.Count() % 2 == 1)
            {
                g.Dijkstra(Way[0].z, points[destinationIndex].z, panel1.CreateGraphics());

                Way.Add(new Point1 { x = points[destinationIndex].x, y = points[destinationIndex].y, z = destinationIndex });
            }
            else
            {
                Refresh();
                Way = new List<Point1>();
                Way.Add(new Point1 { x = points[destinationIndex].x, y = points[destinationIndex].y, z = destinationIndex });
            }
        }

        static int GetNumberFromText(string input) //Hàm lấy ra phần số trong chuỗi
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                // Nếu ký tự hiện tại không phải là số, thì dừng lại
                if (!char.IsDigit(input[i]))
                {
                    // Lấy phần số từ vị trí kết thúc cho đến hết chuỗi
                    string numberPart = input.Substring(i + 1);

                    // Chuyển đổi phần số thành số nguyên
                    if (int.TryParse(numberPart, out int result))
                    {
                        return result;
                    }
                }
            }
            return 0; // Giá trị mặc định
        }

        public void PrintDistance() //In khoảng cách giữa 2 địa điểm
        {
            label3.Text = kc.ToString();
            label3.Text = "Distance: " + kc;
            kc = 0;
        }
        #endregion

        #region Thao tác trực tiếp - Click vào 2 địa điểm
        private void HandleButtonClick(int destinationIndex, object sender, EventArgs e)
        {
            kc = 0;
            label3_Click(sender, e);
            if (Way.Count() == 0)
            {
                Way.Add(new Point1 { x = points[destinationIndex].x, y = points[destinationIndex].y, z = destinationIndex });

            }
            else if (Way.Count() % 2 == 1)
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

        private void label3_Click(object sender, EventArgs e) //In khoảng cách giữa 2 địa điểm lên màn hình
        {
            label3.Text = kc.ToString();
            label3.Text = "Distance: " + kc;
            kc = 0;
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #endregion       
    }
}
