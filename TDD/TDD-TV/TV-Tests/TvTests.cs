using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDProject;

namespace Tests
{
	[TestClass]
	public class TvTests
	{
		[TestMethod]
		public void TvVHSQuailtyReturnTest()
		{
			IMediaDevice mediaDevice = new VHSPlayer();
			IUI ui = new ConsoleUI();
			TV tv = new TV(mediaDevice, ui);


			Assert.AreEqual(576, tv.mediaDevice.quality);
		}

		[TestMethod]
		public void TvDVDQuailtyReturnTest()
		{
			IMediaDevice mediaDevice = new DVDPlayer();
			IUI ui = new ConsoleUI();
			TV tv = new TV(mediaDevice, ui);


			Assert.AreEqual(720, tv.mediaDevice.quality);
		}

		[TestMethod]
		public void TvBlueRayQuailtyReturnTest()
		{
			IMediaDevice mediaDevice = new BlueRayPlayer();
			IUI ui = new ConsoleUI();
			TV tv = new TV(mediaDevice, ui);


			Assert.AreEqual(1080, tv.mediaDevice.quality);
		}

	}
}
