using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KPMG.Interview.CaseStudy1;
using System.IO;

namespace KPMG.Interview
{
    [TestClass]
    public class CaseStudy1Test
    {
        private IHourHandler hourHandlerMock;
        private IBFactory bFactoryMock;
        private StringWriter stringWriter;
        private TextWriter originalOutput;

        [TestInitialize()]
        public void Startup()
        {
             
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
            bFactoryMock = new BFactory();
        }

        [TestMethod]
        public void When_HourLessThan12_Expect_InitailizeAndRunB1()
        {
            //Arrange
            hourHandlerMock = new HourHandler(11);
            var a = new A(bFactoryMock, hourHandlerMock);
            //Act
            a.DoWork();
            //Assert
            Assert.AreEqual($"Type {typeof(B1)} run executed", this.stringWriter.ToString().Trim());
        }

        [TestMethod]
        public void When_HourMoreThan12_Expect_InitailizeAndRunB2()
        {
            //Arrange
            hourHandlerMock = new HourHandler(13);
            var a = new A(bFactoryMock, hourHandlerMock);
            //Act
            a.DoWork();
            //Assert
            Assert.AreEqual($"Type {typeof(B2)} run executed", this.stringWriter.ToString().Trim());
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}
