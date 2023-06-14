using TDDProject;

namespace TDDProject
{
	public class VHSPlayer : IMediaDevice
	{
		public int quality { get; set; }

		public VHSPlayer()
		{
			quality = 576;
		}
	}
}