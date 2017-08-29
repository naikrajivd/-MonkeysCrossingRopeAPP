using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKCrossingRopeLibrary
{
    public class MKCrossingRope
    {

        // This Library will help to move monkeys over the rope from one  side to another side and vice versa
        // There should be only 3 monkeys  or Fixed monkeys on the rope to follow the steps 
        // Each monkey requires 4 steps to cross the rope: 1) ¼ of the way across the rope, 
        // 2) ½ way across the rope 2) ¾ way across the rope 4) off the rope. 
        // Monkeys cannot pass each other once on the rope and they cannot occupy the same spot on the rope.
        //(This could be managed on user interface or client)
        //check-1 you could move the monkeys from left to right
        //check-2 you could move the monkeys from right to left  
        //check-3 monkeys on the rope
        
        public void MoveLeft(ref List<string> lstMnkRope
                                    , ref List<string> lstMnkLeft
                                    , ref List<string> lstMnkRight)
        {

            string sNewItem = "   ";

            string sRemoveFromRope = "   ";

            if (lstMnkLeft.Count > 0)
            {
                sNewItem = lstMnkLeft[0];
                lstMnkLeft.RemoveAt(0);
            }

            if (lstMnkRope.Count > 0)
            {
                sRemoveFromRope = lstMnkRope[0];
                lstMnkRope.Add(sNewItem);
                lstMnkRope.RemoveAt(0);
                // check if rope item empty
                if (sRemoveFromRope.Trim().Length > 0)
                    lstMnkRight.Add(sRemoveFromRope);
            }

        }

        public void MoveRight(ref List<string> lstMnkRope
                                    , ref List<string> lstMnkLeft
                                    , ref List<string> lstMnkRight)
        {

            string sNewItem = "   ";

            string sRemoveFromRope = "   ";

            if (lstMnkRight.Count > 0)
            {
                sNewItem = lstMnkRight[0];
                lstMnkRight.RemoveAt(0);
            }

            if (lstMnkRope.Count > 0)
            {
                sRemoveFromRope = lstMnkRope[lstMnkRope.Count - 1];
                lstMnkRope.Insert(0, sNewItem);
                lstMnkRope.RemoveAt(lstMnkRope.Count - 1);
                // check if rope item empty
                if (sRemoveFromRope.Trim().Length > 0)
                    lstMnkLeft.Add(sRemoveFromRope);
            }

        }


        public string GetRopeMonkeys(List<string> lstMnkRope)
        {
            string sRopeItems = "";

            foreach (var sMKName in lstMnkRope)
            {
                sRopeItems = sRopeItems + "  " + sMKName;
            }

            return sRopeItems;
        }
        
    }
}
