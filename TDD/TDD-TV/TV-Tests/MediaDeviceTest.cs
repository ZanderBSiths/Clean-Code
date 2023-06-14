using TDDProject;

namespace Tests
{
	[TestClass]
	public class MediaDeviceTest
	{
		[TestMethod]
		public void VHSQualityReturnTest()
		{
			IMediaDevice mediaDevice = new VHSPlayer();

			Assert.AreEqual(576, mediaDevice.quality);
		}

		[TestMethod]
		public void DVDQualityReturnTest()
		{
			IMediaDevice mediaDevice = new DVDPlayer();

			Assert.AreEqual(720, mediaDevice.quality);
		}

		[TestMethod]
		public void BlueRayQualityReturnTest()
		{
			IMediaDevice mediaDevice = new BlueRayPlayer();

			Assert.AreEqual(1080, mediaDevice.quality);
		}
	}

}

