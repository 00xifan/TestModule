using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TestModule.Model;
using TestModule.Model.ImClass;

namespace TestModule.Vms
{
   public class CellVm :ObservableObject
	{
		private double _x;
		private double _y;
		private string _name;
		private CellEnum _cellTypeEnum;
		private double _positionX;
		private double _positionY;
		private double _boxSizeX;
		private double _boxSizeY;

		public CellVm()
		{
			//X = cell.X;
			//Y = cell.Y;
			//Name = cell.Name;
			//CellTypeEnum = cell.CellTypeEnum;
		}

		/// <summary>
		/// 在台面上的位置X
		/// </summary>
		public double PositionX
		{
			get => _positionX;
			set => SetProperty(ref _positionX, value);
		}

		/// <summary>
		/// 在台面上的位置Y
		/// </summary>
		public double PositionY
		{
			get => _positionY;
			set => SetProperty(ref _positionY, value);
		}

		/// <summary>
		/// 模块占位X
		/// </summary>
		public double BoxSizeX
		{
			get => _boxSizeX;
			set => SetProperty(ref _boxSizeX, value);
		}

		/// <summary>
		/// 模块占位Y
		/// </summary>
		public double BoxSizeY
		{
			get => _boxSizeY;
			set => SetProperty(ref _boxSizeY, value);
		}

		/// <summary>
		/// X轴长度
		/// </summary>
		public double X
		{
			get => _x;
			set => SetProperty(ref _x, value);
		}

		/// <summary>
		/// Y轴长度
		/// </summary>
		public double Y
		{
			get => _y;
			set => SetProperty(ref _y, value);
		}

		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get => _name;
			set => SetProperty(ref _name, value);
		}

		/// <summary>
		/// 类型
		/// </summary>
		public CellEnum CellTypeEnum
		{
			get => _cellTypeEnum;
			set => SetProperty(ref _cellTypeEnum, value);
		}

		public string CellEnumString => CellTypeEnum.ToString();
		public ObservableCollection<CellEnum> CellsList => new() { CellEnum.Pod,CellEnum.Device,CellEnum.Plate };
		public RelayCommand DeleteItemCommand => new(() => { });
	}
}
