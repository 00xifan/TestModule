using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TestModule.Vms
{
    public class PositionVm : ObservableObject
    {
	    private double _xLength;
	    private double _yLength;


	    /// <summary>
	    /// 板位宽
	    /// </summary>
	    public double XLength
	    {
		    get => _xLength;
		    set => SetProperty(ref _xLength, value);
	    }

	    /// <summary>
	    /// 板位高
	    /// </summary>
	    public double YLength
	    {
		    get => _yLength;
		    set => SetProperty(ref _yLength, value);
	    }
    }
}
