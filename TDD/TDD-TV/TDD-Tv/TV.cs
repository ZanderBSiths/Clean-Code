namespace TDDProject;

public class TV
{
	public IMediaDevice? mediaDevice { get; set; } = null;
	public IUI ui;

    public TV(IUI ui)
    {
		this.ui = ui;
	}

    public TV(IUI ui, IMediaDevice mediaDevice)
	{
		this.mediaDevice = mediaDevice;
		this.ui = ui;
	}


}
