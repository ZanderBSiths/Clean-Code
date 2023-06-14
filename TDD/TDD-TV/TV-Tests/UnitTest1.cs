using TDDProject;

namespace TV_Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			TV tv = new TV();

			Assert.AreEqual(0, tv.number);
		}
	}
}

