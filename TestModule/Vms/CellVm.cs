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
using TestModule.Model.Interface;

namespace TestModule.Vms
{
   public class CellVm :ObservableObject
	{
		private double _cellX;
		private double _cellY;
		private string _name;
		private CellEnum _cellTypeEnum;
		private double _cellPositionX;
		private double _cellPositionY;
		private double _boxSizeX;
		private double _boxSizeY;

		public CellVm(ICell cell)
		{
			CellPositionX = cell.CellPositionX;
			CellPositionY = cell.CellPositionY;
			CellX = cell.CellX;
			CellY = cell.CellY;
			Name = cell.CellName;
			CellTypeEnum = cell.CellEnum;

		}

		/// <summary>
		/// 在台面上的位置X
		/// </summary>
		public double CellPositionX
		{
			get => _cellPositionX;
			set => SetProperty(ref _cellPositionX, value);
		}

		/// <summary>
		/// 在台面上的位置Y
		/// </summary>
		public double CellPositionY
		{
			get => _cellPositionY;
			set => SetProperty(ref _cellPositionY, value);
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
		public double CellX
		{
			get => _cellX;
			set => SetProperty(ref _cellX, value);
		}

		/// <summary>
		/// Y轴长度
		/// </summary>
		public double CellY
		{
			get => _cellY;
			set => SetProperty(ref _cellY, value);
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
