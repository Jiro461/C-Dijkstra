using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            #region Create
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbDetail = new System.Windows.Forms.RichTextBox();
            this.lbNhapDiaDiem = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MLocation5 = new System.Windows.Forms.Label();
            this.MLocation18 = new System.Windows.Forms.Label();
            this.MLocation17 = new System.Windows.Forms.Label();
            this.MLocation15 = new System.Windows.Forms.Label();
            this.MLocation19 = new System.Windows.Forms.Label();
            this.MLocation13 = new System.Windows.Forms.Label();
            this.MLocation14 = new System.Windows.Forms.Label();
            this.MLocation3 = new System.Windows.Forms.Label();
            this.MLocation6 = new System.Windows.Forms.Label();
            this.MLocation4 = new System.Windows.Forms.Label();
            this.MLocation8 = new System.Windows.Forms.Label();
            this.MLocation16 = new System.Windows.Forms.Label();
            this.MLocation2 = new System.Windows.Forms.Label();
            this.MLocation1 = new System.Windows.Forms.Label();
            this.MLocation11 = new System.Windows.Forms.Label();
            this.MLocation10 = new System.Windows.Forms.Label();
            this.MLocation12 = new System.Windows.Forms.Label();
            this.MLocation0 = new System.Windows.Forms.Label();
            this.MLocation9 = new System.Windows.Forms.Label();
            this.MLocation7 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            #endregion
            #region splitContainer
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.rtbDetail);
            this.splitContainer1.Panel1.Controls.Add(this.lbNhapDiaDiem);
            this.splitContainer1.Panel1.Controls.Add(this.Search);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonExit);
            this.splitContainer1.Size = new System.Drawing.Size(1329, 693);
            this.splitContainer1.SplitterDistance = 441;
            this.splitContainer1.TabIndex = 0;
            #endregion
            #region comboBox
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DropDownHeight = 120;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(83, 318);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.MaxDropDownItems = 6;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownHeight = 120;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(83, 246);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.MaxDropDownItems = 6;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 10;
            #endregion
            #region label
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(77, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa điểm gần đó: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(125, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Distance: 0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(77, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIJKSTRA ALGORITHM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(125, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO";
            #endregion
            #region Search
            // 
            // rtbDetail
            // 
            this.rtbDetail.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDetail.Location = new System.Drawing.Point(83, 468);
            this.rtbDetail.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDetail.Name = "rtbDetail";
            this.rtbDetail.Size = new System.Drawing.Size(286, 136);
            this.rtbDetail.TabIndex = 8;
            this.rtbDetail.Text = "";
            // 
            // lbNhapDiaDiem
            // 
            this.lbNhapDiaDiem.AutoSize = true;
            this.lbNhapDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapDiaDiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNhapDiaDiem.Location = new System.Drawing.Point(58, 173);
            this.lbNhapDiaDiem.Name = "lbNhapDiaDiem";
            this.lbNhapDiaDiem.Size = new System.Drawing.Size(350, 29);
            this.lbNhapDiaDiem.TabIndex = 7;
            this.lbNhapDiaDiem.Text = "Hãy nhập địa điểm bạn muốn đi";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.SpringGreen;
            this.Search.ForeColor = System.Drawing.Color.Navy;
            this.Search.Location = new System.Drawing.Point(305, 271);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(98, 44);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            #endregion
            #region panel1
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.MLocation5);
            this.panel1.Controls.Add(this.MLocation18);
            this.panel1.Controls.Add(this.MLocation17);
            this.panel1.Controls.Add(this.MLocation15);
            this.panel1.Controls.Add(this.MLocation19);
            this.panel1.Controls.Add(this.MLocation13);
            this.panel1.Controls.Add(this.MLocation14);
            this.panel1.Controls.Add(this.MLocation3);
            this.panel1.Controls.Add(this.MLocation6);
            this.panel1.Controls.Add(this.MLocation4);
            this.panel1.Controls.Add(this.MLocation8);
            this.panel1.Controls.Add(this.MLocation16);
            this.panel1.Controls.Add(this.MLocation2);
            this.panel1.Controls.Add(this.MLocation1);
            this.panel1.Controls.Add(this.MLocation11);
            this.panel1.Controls.Add(this.MLocation10);
            this.panel1.Controls.Add(this.MLocation12);
            this.panel1.Controls.Add(this.MLocation0);
            this.panel1.Controls.Add(this.MLocation9);
            this.panel1.Controls.Add(this.MLocation7);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Location = new System.Drawing.Point(30, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 640);
            this.panel1.TabIndex = 0;
            #endregion
            #region MLocation
            // 
            // MLocation5
            // 
            this.MLocation5.AutoSize = true;
            this.MLocation5.BackColor = System.Drawing.Color.Transparent;
            this.MLocation5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation5.Location = new System.Drawing.Point(111, 460);
            this.MLocation5.Name = "MLocation5";
            this.MLocation5.Size = new System.Drawing.Size(106, 18);
            this.MLocation5.TabIndex = 41;
            this.MLocation5.Text = "Hồ bơi Phú Lợi";
            // 
            // MLocation18
            // 
            this.MLocation18.AutoSize = true;
            this.MLocation18.BackColor = System.Drawing.Color.Transparent;
            this.MLocation18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation18.Location = new System.Drawing.Point(591, 477);
            this.MLocation18.Name = "MLocation18";
            this.MLocation18.Size = new System.Drawing.Size(101, 18);
            this.MLocation18.TabIndex = 40;
            this.MLocation18.Text = "Katinat Coffee";
            // 
            // MLocation17
            // 
            this.MLocation17.AutoSize = true;
            this.MLocation17.BackColor = System.Drawing.Color.Transparent;
            this.MLocation17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation17.Location = new System.Drawing.Point(525, 555);
            this.MLocation17.Name = "MLocation17";
            this.MLocation17.Size = new System.Drawing.Size(118, 18);
            this.MLocation17.TabIndex = 39;
            this.MLocation17.Text = "KDL Tháp Chàm";
            // 
            // MLocation15
            // 
            this.MLocation15.AutoSize = true;
            this.MLocation15.BackColor = System.Drawing.Color.Transparent;
            this.MLocation15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation15.Location = new System.Drawing.Point(482, 391);
            this.MLocation15.Name = "MLocation15";
            this.MLocation15.Size = new System.Drawing.Size(125, 18);
            this.MLocation15.TabIndex = 38;
            this.MLocation15.Text = "Quán ăn Gia Đình";
            // 
            // MLocation19
            // 
            this.MLocation19.AutoSize = true;
            this.MLocation19.BackColor = System.Drawing.Color.Transparent;
            this.MLocation19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation19.Location = new System.Drawing.Point(579, 309);
            this.MLocation19.Name = "MLocation19";
            this.MLocation19.Size = new System.Drawing.Size(113, 18);
            this.MLocation19.TabIndex = 37;
            this.MLocation19.Text = "Highland Coffee";
            // 
            // MLocation13
            // 
            this.MLocation13.AutoSize = true;
            this.MLocation13.BackColor = System.Drawing.Color.Transparent;
            this.MLocation13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation13.Location = new System.Drawing.Point(483, 161);
            this.MLocation13.Name = "MLocation13";
            this.MLocation13.Size = new System.Drawing.Size(131, 18);
            this.MLocation13.TabIndex = 36;
            this.MLocation13.Text = "Nhà nghỉ Mộc Sơn";
            // 
            // MLocation14
            // 
            this.MLocation14.AutoSize = true;
            this.MLocation14.BackColor = System.Drawing.Color.Transparent;
            this.MLocation14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation14.Location = new System.Drawing.Point(446, 273);
            this.MLocation14.Name = "MLocation14";
            this.MLocation14.Size = new System.Drawing.Size(147, 18);
            this.MLocation14.TabIndex = 35;
            this.MLocation14.Text = "Nhà thờ Vĩnh Nghiêm";
            // 
            // MLocation3
            // 
            this.MLocation3.AutoSize = true;
            this.MLocation3.BackColor = System.Drawing.Color.Transparent;
            this.MLocation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation3.Location = new System.Drawing.Point(352, 273);
            this.MLocation3.Name = "MLocation3";
            this.MLocation3.Size = new System.Drawing.Size(96, 18);
            this.MLocation3.TabIndex = 34;
            this.MLocation3.Text = "Công viên B5";
            // 
            // MLocation6
            // 
            this.MLocation6.AutoSize = true;
            this.MLocation6.BackColor = System.Drawing.Color.Transparent;
            this.MLocation6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation6.Location = new System.Drawing.Point(40, 395);
            this.MLocation6.Name = "MLocation6";
            this.MLocation6.Size = new System.Drawing.Size(132, 18);
            this.MLocation6.TabIndex = 33;
            this.MLocation6.Text = "Hồ câu cá Đinh Ba";
            // 
            // MLocation4
            // 
            this.MLocation4.AutoSize = true;
            this.MLocation4.BackColor = System.Drawing.Color.Transparent;
            this.MLocation4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation4.Location = new System.Drawing.Point(46, 301);
            this.MLocation4.Name = "MLocation4";
            this.MLocation4.Size = new System.Drawing.Size(145, 18);
            this.MLocation4.TabIndex = 32;
            this.MLocation4.Text = "Nhà hàng Đại Dương";
            // 
            // MLocation8
            // 
            this.MLocation8.AutoSize = true;
            this.MLocation8.BackColor = System.Drawing.Color.Transparent;
            this.MLocation8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation8.Location = new System.Drawing.Point(81, 165);
            this.MLocation8.Name = "MLocation8";
            this.MLocation8.Size = new System.Drawing.Size(159, 18);
            this.MLocation8.TabIndex = 31;
            this.MLocation8.Text = "Phố đi bộ Phan Văn Trị";
            // 
            // MLocation16
            // 
            this.MLocation16.AutoSize = true;
            this.MLocation16.BackColor = System.Drawing.Color.Transparent;
            this.MLocation16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation16.Location = new System.Drawing.Point(363, 606);
            this.MLocation16.Name = "MLocation16";
            this.MLocation16.Size = new System.Drawing.Size(183, 18);
            this.MLocation16.TabIndex = 30;
            this.MLocation16.Text = "Khu công nghiệp Biên Hòa";
            // 
            // MLocation2
            // 
            this.MLocation2.AutoSize = true;
            this.MLocation2.BackColor = System.Drawing.Color.Transparent;
            this.MLocation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation2.Location = new System.Drawing.Point(272, 576);
            this.MLocation2.Name = "MLocation2";
            this.MLocation2.Size = new System.Drawing.Size(116, 18);
            this.MLocation2.TabIndex = 29;
            this.MLocation2.Text = "Trendora Coffee";
            // 
            // MLocation1
            // 
            this.MLocation1.AutoSize = true;
            this.MLocation1.BackColor = System.Drawing.Color.Transparent;
            this.MLocation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation1.Location = new System.Drawing.Point(176, 551);
            this.MLocation1.Name = "MLocation1";
            this.MLocation1.Size = new System.Drawing.Size(123, 18);
            this.MLocation1.TabIndex = 28;
            this.MLocation1.Text = "Nhà hàng Cù Lao";
            // 
            // MLocation11
            // 
            this.MLocation11.AutoSize = true;
            this.MLocation11.BackColor = System.Drawing.Color.Transparent;
            this.MLocation11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation11.Location = new System.Drawing.Point(374, 165);
            this.MLocation11.Name = "MLocation11";
            this.MLocation11.Size = new System.Drawing.Size(105, 18);
            this.MLocation11.TabIndex = 27;
            this.MLocation11.Text = "Thảo cầm viên";
            // 
            // MLocation10
            // 
            this.MLocation10.AutoSize = true;
            this.MLocation10.BackColor = System.Drawing.Color.Transparent;
            this.MLocation10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation10.Location = new System.Drawing.Point(282, 129);
            this.MLocation10.Name = "MLocation10";
            this.MLocation10.Size = new System.Drawing.Size(106, 18);
            this.MLocation10.TabIndex = 26;
            this.MLocation10.Text = "Vincom Center";
            // 
            // MLocation12
            // 
            this.MLocation12.AutoSize = true;
            this.MLocation12.BackColor = System.Drawing.Color.Transparent;
            this.MLocation12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation12.Location = new System.Drawing.Point(407, 51);
            this.MLocation12.Name = "MLocation12";
            this.MLocation12.Size = new System.Drawing.Size(105, 18);
            this.MLocation12.TabIndex = 25;
            this.MLocation12.Text = "KDL Cửu Long";
            // 
            // MLocation0
            // 
            this.MLocation0.AutoSize = true;
            this.MLocation0.BackColor = System.Drawing.Color.Transparent;
            this.MLocation0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation0.Location = new System.Drawing.Point(229, 388);
            this.MLocation0.Name = "MLocation0";
            this.MLocation0.Size = new System.Drawing.Size(95, 18);
            this.MLocation0.TabIndex = 24;
            this.MLocation0.Text = "CGV Cinema";
            // 
            // MLocation9
            // 
            this.MLocation9.AutoSize = true;
            this.MLocation9.BackColor = System.Drawing.Color.Transparent;
            this.MLocation9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation9.Location = new System.Drawing.Point(163, 111);
            this.MLocation9.Name = "MLocation9";
            this.MLocation9.Size = new System.Drawing.Size(125, 18);
            this.MLocation9.TabIndex = 23;
            this.MLocation9.Text = "Quảng trường tỉnh";
            // 
            // MLocation7
            // 
            this.MLocation7.AutoSize = true;
            this.MLocation7.BackColor = System.Drawing.Color.Transparent;
            this.MLocation7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLocation7.Location = new System.Drawing.Point(219, 225);
            this.MLocation7.Name = "MLocation7";
            this.MLocation7.Size = new System.Drawing.Size(144, 18);
            this.MLocation7.TabIndex = 22;
            this.MLocation7.Text = "Trung tâm thành phố";
            #endregion
            #region button
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button19.Location = new System.Drawing.Point(617, 320);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(42, 39);
            this.button19.TabIndex = 21;
            this.button19.Tag = "Cơm gà xối mỡ\nCơm tấm Ba Ghiền\nBánh Canh Cá Lóc";
            this.button19.Text = "☻";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button21_Click);
            // 
            // button18
            // 
            this.button18.AutoSize = true;
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button18.Location = new System.Drawing.Point(617, 447);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(42, 39);
            this.button18.TabIndex = 20;
            this.button18.Tag = "Cửa hàng nội thất\nĐiện máy xanh\nFPT Shop";
            this.button18.Text = "☻";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button20_Click);
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button17.Location = new System.Drawing.Point(540, 520);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(42, 39);
            this.button17.TabIndex = 19;
            this.button17.Tag = "UEH CS.A\nBánh Canh Cua\nPet Shop";
            this.button17.Text = "☻";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button19_Click);
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button16.Location = new System.Drawing.Point(425, 576);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(42, 39);
            this.button16.TabIndex = 18;
            this.button16.Tag = "Bún Bò\nMì Trộn";
            this.button16.Text = "☻";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button18_Click);
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button15.Location = new System.Drawing.Point(517, 400);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(42, 39);
            this.button15.TabIndex = 17;
            this.button15.Tag = "Nhà Sách\nRạp CGV";
            this.button15.Text = "☻";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button17_Click);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button14.Location = new System.Drawing.Point(504, 282);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 39);
            this.button14.TabIndex = 16;
            this.button14.Tag = "Quán Nước Triểu Khúc\nNhu Yếu Phẩm";
            this.button14.Text = "☻";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button13.Location = new System.Drawing.Point(528, 170);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 39);
            this.button13.TabIndex = 15;
            this.button13.Tag = "Bánh Canh Cá Lóc\nBún Thịt Nướng";
            this.button13.Text = "☻";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button15_Click);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button12.Location = new System.Drawing.Point(437, 63);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(42, 39);
            this.button12.TabIndex = 14;
            this.button12.Tag = "Bún mắm miền Tây\nBida 79";
            this.button12.Text = "☻";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button14_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button11.Location = new System.Drawing.Point(393, 173);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 39);
            this.button11.TabIndex = 13;
            this.button11.Tag = "Bánh Ướt Lòng GàA\nBánh Tráng Tây Ninh";
            this.button11.Text = "☻";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button13_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button10.Location = new System.Drawing.Point(318, 137);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 39);
            this.button10.TabIndex = 12;
            this.button10.Tag = "Phim Trường\nPhố Đi Bộ";
            this.button10.Text = "☻";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button12_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button9.Location = new System.Drawing.Point(205, 120);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 39);
            this.button9.TabIndex = 11;
            this.button9.Tag = "Nhà Hàng Tubao\nTèo Em Coffe";
            this.button9.Text = "☻";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(130, 174);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 39);
            this.button8.TabIndex = 10;
            this.button8.Tag = "Quán Nét LongChau\nBida KyThuatPhanMem";
            this.button8.Text = "☻";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(272, 232);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 39);
            this.button7.TabIndex = 9;
            this.button7.Tag = "Sân Bay Long Thành\nBến Xe An Sương";
            this.button7.Text = "☻";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(82, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 39);
            this.button6.TabIndex = 8;
            this.button6.Tag = "Thế Giới Di Động\nĐiện Máy Xanh";
            this.button6.Text = "☻";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(142, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 39);
            this.button5.TabIndex = 7;
            this.button5.Tag = "Shop đồ điện tử\nNội thất Decor";
            this.button5.Text = "☻";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(94, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 39);
            this.button4.TabIndex = 6;
            this.button4.Tag = "Nhà Nghỉ A\nKhách Sạn SaoCungDuoc";
            this.button4.Text = "☻";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(377, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 39);
            this.button3.TabIndex = 5;
            this.button3.Tag = "Chợ nổi Cái Răng\nChùa Thiên Mụ";
            this.button3.Text = "☻";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(330, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 39);
            this.button2.TabIndex = 4;
            this.button2.Tag = "Cháo lòng PhungChau\nBún mắm nêm ThienBao";
            this.button2.Text = "☻";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(232, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 3;
            this.button1.Tag = "Cháo lòng Anh Long\nHadilao Longxabong";
            this.button1.Text = "☻";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // button0
            // 
            this.button0.AutoSize = true;
            this.button0.BackColor = System.Drawing.Color.Transparent;
            this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button0.Location = new System.Drawing.Point(255, 401);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(42, 39);
            this.button0.TabIndex = 2;
            this.button0.Tag = "Xe ôm Shop\nMỳ Cay 7 Cấp Độ";
            this.button0.Text = "☻";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonExit.Location = new System.Drawing.Point(841, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(41, 42);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            #endregion
            #region Form1
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 693);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            #endregion

        }
        #endregion
        #region Painting&Marking
        static public void Painting(Graphics g, int a, int b, int c, int d) //Hàm vẽ đường xanh (Không xài)
        {
            Pen blackPen = new Pen(Color.MediumBlue, 3);
            Point point1 = new Point(a, b);
            Point point2 = new Point(c, d);
            g.DrawLine(blackPen, point1, point2);
        }
        static public void Marking(Graphics g, int a, int b, int c, int d) //Hàm vẽ đường đỏ
        {
            Pen blackPen = new Pen(Color.Red, 5);
            Point point1 = new Point(a, b);
            Point point2 = new Point(c, d);
            g.DrawLine(blackPen, point1, point2);
        }
        #endregion
        #region Other
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label MLocation7;
        private Label MLocation9;
        private Button Search;
        private Label MLocation0;
        private Label lbNhapDiaDiem;
        private Label MLocation12;
        private Label MLocation5;
        private Label MLocation18;
        private Label MLocation17;
        private Label MLocation15;
        private Label MLocation19;
        private Label MLocation13;
        private Label MLocation14;
        private Label MLocation3;
        private Label MLocation6;
        private Label MLocation4;
        private Label MLocation8;
        private Label MLocation16;
        private Label MLocation2;
        private Label MLocation1;
        private Label MLocation11;
        private Label MLocation10;
        public RichTextBox rtbDetail;
        private Label label4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button0;
        public System.Windows.Forms.Panel panel1;
        #endregion
    }
}