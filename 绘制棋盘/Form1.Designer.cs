namespace 绘制棋盘
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.开始绘制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.绘制焦点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存焦点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(20, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(216, 217);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始绘制ToolStripMenuItem,
            this.保存结果ToolStripMenuItem,
            this.绘制焦点ToolStripMenuItem,
            this.保存焦点ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(725, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 开始绘制ToolStripMenuItem
			// 
			this.开始绘制ToolStripMenuItem.Name = "开始绘制ToolStripMenuItem";
			this.开始绘制ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.开始绘制ToolStripMenuItem.Text = "开始绘制";
			this.开始绘制ToolStripMenuItem.Click += new System.EventHandler(this.开始绘制ToolStripMenuItem_Click);
			// 
			// 保存结果ToolStripMenuItem
			// 
			this.保存结果ToolStripMenuItem.Name = "保存结果ToolStripMenuItem";
			this.保存结果ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.保存结果ToolStripMenuItem.Text = "保存结果";
			this.保存结果ToolStripMenuItem.Click += new System.EventHandler(this.保存结果ToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 471);
			this.panel1.TabIndex = 2;
			// 
			// 绘制焦点ToolStripMenuItem
			// 
			this.绘制焦点ToolStripMenuItem.Name = "绘制焦点ToolStripMenuItem";
			this.绘制焦点ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.绘制焦点ToolStripMenuItem.Text = "绘制焦点";
			this.绘制焦点ToolStripMenuItem.Click += new System.EventHandler(this.绘制焦点ToolStripMenuItem_Click);
			// 
			// 保存焦点ToolStripMenuItem
			// 
			this.保存焦点ToolStripMenuItem.Name = "保存焦点ToolStripMenuItem";
			this.保存焦点ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.保存焦点ToolStripMenuItem.Text = "保存焦点";
			this.保存焦点ToolStripMenuItem.Click += new System.EventHandler(this.保存焦点ToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 496);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 开始绘制ToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem 保存结果ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 绘制焦点ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存焦点ToolStripMenuItem;
	}
}

