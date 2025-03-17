namespace TestModule.Model.Interface
{
	interface IBaseInfo
	{
		/// <summary>
		/// X轴长度
		/// </summary>
		double X { get; set; }

		/// <summary>
		/// Y轴长度
		/// </summary>
		double Y { get; set; }

		/// <summary>
		/// 名称
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// 类型
		/// </summary>
		CellEnum CellTypeEnum { get; set; }


	}
}
