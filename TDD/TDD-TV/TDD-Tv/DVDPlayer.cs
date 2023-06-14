using TDDProject;

namespace TDDProject;

public class DVDPlayer : IMediaDevice
{
	public int quality { get; set; }

	public DVDPlayer()
	{
		quality = 720;
	}
}