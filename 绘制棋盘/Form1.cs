using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace 绘制棋盘
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void 开始绘制ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//格子数
			int cellCount = 18;


			//格子边长
			int cellLength = (panel1.Height - 40) / 19;

			//边框画笔
			Pen borderPen = new Pen(Color.Black, 3);
			//一般画笔
			Pen commonPen = new Pen(Color.Black, 1);

			Bitmap map = new Bitmap((cellCount + 1) * cellLength, (cellCount + 1) * cellLength);

			Graphics g = Graphics.FromImage(map);

			//g.FillRectangle(Brushes.White, 0, 0, map.Width, map.Height);
			//g.FillRectangle(Brushes.LightCyan, 0, 0, map.Width, map.Height);

			for (int row = 1; row < 18; row++)
			{
				g.DrawLine(commonPen,
					cellLength / 2, row * cellLength + cellLength / 2,
					cellLength * 18.5f, row * cellLength + cellLength / 2);
			}
			for (int col = 1; col < 18; col++)
			{
				g.DrawLine(commonPen,
					col * cellLength + cellLength / 2, cellLength / 2,
					col * cellLength + cellLength / 2, cellLength * 18.5f);
			}
			g.DrawLine(borderPen, cellLength / 2, cellLength / 2, cellLength * 18.5f, cellLength / 2);
			g.DrawLine(borderPen, cellLength / 2, cellLength * 18.5f, cellLength * 18.5f, cellLength * 18.5f);
			g.DrawLine(borderPen, cellLength / 2, cellLength / 2, cellLength / 2, cellLength * 18.5f);
			g.DrawLine(borderPen, cellLength * 18.5f, cellLength / 2, cellLength * 18.5f, cellLength * 18.5f);

			int pointSize = 4;
			PointF[] points = new PointF[]
			{
				new PointF(cellLength*3.5f,cellLength*3.5f),
				new PointF(cellLength*9.5f,cellLength*3.5f),
				new PointF(cellLength*15.5f,cellLength*3.5f),
				new PointF(cellLength*3.5f,cellLength*9.5f),
				new PointF(cellLength*9.5f,cellLength*9.5f),
				new PointF(cellLength*15.5f,cellLength*9.5f),
				new PointF(cellLength*3.5f,cellLength*15.5f),
				new PointF(cellLength*9.5f,cellLength*15.5f),
				new PointF(cellLength*15.5f,cellLength*15.5f),

			};
			foreach (var point in points)
			{
				g.FillEllipse(Brushes.Black, point.X - pointSize, point.Y - pointSize, pointSize * 2, pointSize * 2);
			}


			pictureBox1.Image = map;
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
		}

		private void 保存结果ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBox1.Image.Save(@"C:\bg.png", ImageFormat.Png);
		}

		private void 绘制焦点ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap map = new Bitmap(35, 35);
			Graphics g = Graphics.FromImage(map);
			Pen pen = new Pen(Brushes.LightBlue, 2);

			g.DrawLine(pen, new Point(2, 2), new Point(2, 33));
			g.DrawLine(pen, new Point(2, 2), new Point(33, 2));
			g.DrawLine(pen, new Point(33, 33), new Point(2, 33));
			g.DrawLine(pen, new Point(33, 33), new Point(33, 2));


			pictureBox1.Image = map;
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
		}

		private void 保存焦点ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBox1.Image.Save(@"C:\focus.png", ImageFormat.Png);
		}
	}
}