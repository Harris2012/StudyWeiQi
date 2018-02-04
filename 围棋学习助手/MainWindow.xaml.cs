using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace 围棋学习助手
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			IsBlack = true;

			CheeseGrid grid = new CheeseGrid();
			Ellipse ellipse = new Ellipse();
		}

		private bool? _isBlack;
		/// <summary>
		/// 当前是否为执黑
		/// 若是，该值为True，否则为False
		/// </summary>
		public bool? IsBlack
		{
			get
			{
				return _isBlack;
			}
			set
			{
				if (_isBlack == value)
					return;
				_isBlack = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("IsBlack"));
					PropertyChanged(this, new PropertyChangedEventArgs("IsWhite"));
					PropertyChanged(this, new PropertyChangedEventArgs("ClearThickness"));
					PropertyChanged(this, new PropertyChangedEventArgs("BlackThickness"));
					PropertyChanged(this, new PropertyChangedEventArgs("WhiteThickness"));
				}
			}
		}
		public bool? IsWhite
		{
			get
			{
				return !_isBlack;
			}
		}
		public float ClearThickness
		{
			get
			{
				if (IsBlack.HasValue)
					return 0.5f;
				else
					return 3;
			}
		}
		public float BlackThickness
		{
			get
			{
				if (IsBlack.HasValue && IsBlack == true)
					return 3;
				else
					return 0.5f;

			}
		}
		public float WhiteThickness
		{
			get
			{
				if (IsBlack.HasValue && IsBlack == false)
					return 3;
				else
					return 0.5f;
			}
		}

		private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{

		}

		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// 鼠标进入了修改棋子类型的面板
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TypeBorder_MouseEnter(object sender, MouseEventArgs e)
		{
			(sender as Border).Margin = new Thickness(6, 6, 6, 6);
			Cursor = Cursors.Hand;
		}

		private void TypeBorder_MouseLeave(object sender, MouseEventArgs e)
		{
			(sender as Border).Margin = new Thickness(6, 6, 100, 6);
			Cursor = Cursors.Arrow;
		}

		private void ClearBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			IsBlack = null;
		}

		private void BlackBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			IsBlack = true;
		}

		private void WhiteBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			IsBlack = false;
		}

		private void MainGrid_MouseEnter(object sender, MouseEventArgs e)
		{

		}

		private void MainGrid_MouseLeave(object sender, MouseEventArgs e)
		{

		}
	}
}
