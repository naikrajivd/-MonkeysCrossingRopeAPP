using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MKCrossingRopeLibrary;

namespace MKCrossingRopeLibraryTest
{
    [TestClass]
    public class MKCrossingRopeTest
    {

        [TestMethod]
        public void Check_GetRopeMonkeys_Test()
        {
            List<string> lstMnkRope = new List<string>() { "MR1", "MR2", "MR3" }; // only 3 monkeys on rope

            MKCrossingRope objMKCrossingRope = new MKCrossingRope();

            string strRopeMonkey = objMKCrossingRope.GetRopeMonkeys(lstMnkRope);

            Assert.AreEqual(strRopeMonkey.Trim(), "MR1  MR2  MR3");
        }

        [TestMethod]
        public void Check_MK_MoveLeft_Test()
        {
            List<string> lstMnkRope = new List<string>() { "  ", "  ", "  " }; // only 3 monkeys on rope
            List<string> lstMnkLeft = new List<string>() { "MR1", "MR2", "MR3" };
            List<string> lstMnkRight = new List<string>() { "ML1", "ML2", "ML3" };

            MKCrossingRope objMKCrossingRope = new MKCrossingRope();

            objMKCrossingRope.MoveLeft(ref lstMnkRope, ref lstMnkLeft, ref lstMnkRight);

            string strRopeMonkey = objMKCrossingRope.GetRopeMonkeys(lstMnkRope);

            Assert.AreEqual(strRopeMonkey.Trim(), "MR1");
        }

        [TestMethod]
        public void Check_MK_MoveRight_Test()
        {
            List<string> lstMnkRope = new List<string>() { "  ", "  ", "  " };
            List<string> lstMnkLeft = new List<string>() { "MR1", "MR2", "MR3" };
            List<string> lstMnkRight = new List<string>() { "ML1", "ML2", "ML3" };

            MKCrossingRope objMKCrossingRope = new MKCrossingRope();

            objMKCrossingRope.MoveRight(ref lstMnkRope, ref lstMnkLeft, ref lstMnkRight);

            string strRopeMonkey = objMKCrossingRope.GetRopeMonkeys(lstMnkRope);

            Assert.AreEqual(strRopeMonkey.Trim(), "ML1");
        }
    }
}
