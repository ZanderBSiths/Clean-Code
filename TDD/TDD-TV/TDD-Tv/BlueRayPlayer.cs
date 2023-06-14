using TDDProject;

namespace TDDProject;

public class BlueRayPlayer : IMediaDevice
{
	public int quality { get; set; }

	public BlueRayPlayer()
	{
		quality = 1080;
	}
}