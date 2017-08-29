using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MKCrossingRopeLibrary;

namespace MonkeysCrossingRopeApp
{
    public partial class Form1 : Form
    {
        List<string> lstMnkRope = new List<string>() { "  ", "  ", "  " };
        List<string> lstMnkLeft = new List<string>() { "MR1", "MR2", "MR3" };
        List<string> lstMnkRight = new List<string>() { "ML1", "ML2", "ML3" };

        public int iCntL = 3;

        public int iCntR = 3;

        public MKCrossingRope objMKCrossingRope; 

        public Form1()
        {
            objMKCrossingRope = new MKCrossingRope();

            InitializeComponent();

            RefreshList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iCntL = iCntL + 1;

            string strNewMokey = "ML" + iCntL;

            lstMnkRight.Add(strNewMokey);

            RefreshList();
        }

        /// <summary>
        /// Refresh the list view
        /// </summary>
        private void RefreshList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lstMnkRight;

            listBox2.DataSource = null;
            listBox2.DataSource = lstMnkLeft;

            textBox1.Text = objMKCrossingRope.GetRopeMonkeys(lstMnkRope);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            iCntL = iCntL + 1;

            string strNewMokey = "MR" + iCntL;

            lstMnkLeft.Add(strNewMokey);

            RefreshList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;

            objMKCrossingRope.MoveLeft(ref lstMnkRope, ref lstMnkLeft, ref lstMnkRight);

            if (objMKCrossingRope.GetRopeMonkeys(lstMnkRope).Trim().Length == 0)
            {
                button3.Enabled = false;
                button4.Enabled = true;
            }

            RefreshList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

            objMKCrossingRope.MoveRight(ref lstMnkRope, ref lstMnkLeft, ref lstMnkRight);

            if (objMKCrossingRope.GetRopeMonkeys(lstMnkRope).Trim().Length == 0)
            {
                button4.Enabled = false;

                button3.Enabled = true;
            }

            RefreshList();
        }
    }
}
