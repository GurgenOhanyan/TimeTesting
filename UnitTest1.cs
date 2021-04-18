using System;
using Xunit;
using TimeStruct;
namespace TimeStructTesting
{
    public class UnitTest1
    {
        public Time systemUnderTest1;
        public Time sytemUnderTest2;

        [Fact]
        public void TimeSumTest()
        {
            systemUnderTest1 = new Time("07:10");
            sytemUnderTest2 = new Time("04:10");
            Time systemUnderTestForSum = systemUnderTest1 + sytemUnderTest2;

            Assert.Equal("11:20", systemUnderTestForSum.ToString());
        }
        [Fact]
        public void TimeSubTest()
        {
            systemUnderTest1 = new Time("23:10");
            sytemUnderTest2 = new Time("10:20");
            Time systemUnderTestForSum = systemUnderTest1 - sytemUnderTest2;

            Assert.Equal("12:50", systemUnderTestForSum.ToString());

        }

        [Fact]
        public void FromMidnigntTimeInMinuteTest()
        {
            systemUnderTest1 = new Time("10:30");
            int TimeInMinutes = (int)systemUnderTest1;

            Assert.Equal(630, TimeInMinutes);
        }

        [Fact]
        public void FromMinutesCastToTimeTest()
        {
            int minutes = 730;
            Time time = (Time)minutes;

            Assert.Equal("12:10", time.ToString());
        
        }



    }
}
