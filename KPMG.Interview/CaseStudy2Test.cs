using KPMG.Interview.CaseStudy2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KPMG.Interview
{
    [TestClass]
    public class CaseStudy2Test
    {
        [TestMethod]
        public void When_DefaultTreeUsed_Expect_BCValuesOnLevel1()
        {
            //Arrange
            var treeManager = new NotReallyBinaryTreeManager();
            //Act
            var siblings = treeManager.FindSiblings();
            //Assert

            Assert.AreEqual("B", siblings[1][0]);
            Assert.AreEqual("C", siblings[1][1]);
        }

        [TestMethod]
        public void When_DefaultTreeUsed_Expect_DEValuesOnLevel2()
        {
            //Arrange
            var treeManager = new NotReallyBinaryTreeManager();
            //Act
            var siblings = treeManager.FindSiblings();
            //Assert

            Assert.AreEqual("D", siblings[2][0]);
            Assert.AreEqual("E", siblings[2][1]);
        }

        [TestMethod]
        public void When_DefaultTreeUsed_Expect_FEValuesOnLevel3()
        {
            //Arrange
            var treeManager = new NotReallyBinaryTreeManager();
            //Act
            var siblings = treeManager.FindSiblings();
            //Assert

            Assert.AreEqual("F", siblings[3][0]);
            Assert.AreEqual("G", siblings[3][1]);
        }
    }
}
