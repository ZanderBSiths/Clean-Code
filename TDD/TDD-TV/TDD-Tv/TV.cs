namespace TDDProject;

public class TV
{
	public IMediaDevice mediaDevice;
	public IUI ui;


	public TV(IMediaDevice mediaDevice, IUI ui)
	{
		this.mediaDevice = mediaDevice;
		this.ui = ui;
	}


}
