using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Model.Interface;

namespace TestModule.Model.ImClass
{
	public class Device : ICell
	{
	    #region Implementation of IBaseInfo

	    /// <summary>
	    /// X轴长度
	    /// </summary>
	    public double X { get; set; }

	    /// <summary>
	    /// Y轴长度
	    /// </summary>
	    public double Y { get; set; }

	    /// <summary>
	    /// 名称
	    /// </summary>
	    public string Name { get; set; }

	    /// <summary>
	    /// 类型
	    /// </summary>
	    public CellEnum CellTypeEnum { get; set; } = CellEnum.Device;

	    #endregion
    }
}
