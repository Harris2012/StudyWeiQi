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
	/// CheeseGrid.xaml 的交互逻辑
	/// </summary>
	public partial class CheeseGrid : Grid, INotifyPropertyChanged
	{
		public CheeseGrid()
		{
			InitializeComponent();
		}

		private bool? _isBlack;
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
					PropertyChanged(this, new PropertyChangedEventArgs("WhiteVisiable"));
					PropertyChanged(this, new PropertyChangedEventArgs("BlackVisiable"));
					PropertyChanged(this, new PropertyChangedEventArgs("ForeColor"));
				}
			}
		}
		public Visibility BlackVisiable
		{
			get
			{
				if (_isBlack.HasValue && _isBlack.Value)
					return Visibility.Visible;
				else
					return Visibility.Hidden;
			}
		}
		public Visibility WhiteVisiable
		{
			get
			{
				if (_isBlack.HasValue && !_isBlack.Value)
					return Visibility.Visible;
				else
					return Visibility.Hidden;
			}
		}
		public Brush ForeColor
		{
			get
			{
				if (_isBlack.HasValue)
					if (_isBlack.Value)
						return Brushes.White;
					else
						return Brushes.Black;
				else
					return Brushes.Transparent;
			}
		}
		private int _lifeCount;
		public int LifeCount
		{
			get
			{
				return _lifeCount;
			}
			set
			{
				if (_lifeCount != value)
				{
					_lifeCount = value;
					if (PropertyChanged != null)
						PropertyChanged(this, new PropertyChangedEventArgs("LifeCount"));
				}
			}
		}

		public int RowIndex
		{
			get;
			set;
		}

		public int ColIndex
		{
			get;
			set;
		}

		public Visibility FocusVisibility
		{
			get
			{
				if (IsMouseOver)
					return Visibility.Visible;
				else
					return Visibility.Hidden;
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;
	}
}
