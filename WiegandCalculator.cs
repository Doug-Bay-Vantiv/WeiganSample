using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeiganSample
{
    public partial class WiegandCalculator : Form
    {
        public WiegandCalculator()
        {
            InitializeComponent();
        }

        private void CmdGenerate_Click(object sender, EventArgs e)
        {
            RTxtResult.Clear();

            RTxtResult.AppendText(HexResult(Convert.ToInt32(TxtFacilityCode.Text), Convert.ToInt32(TxtCardCode.Text)));
        }
        private string HexResult(int facilityCode, int cardCode)
        {
            try
            {
                int sum = (facilityCode << 17) + (cardCode << 1);

                int count = 0;
                int sumCopy = sum;
                for (int i = 0; i < 12; i++)
                {
                    sumCopy >>= 1;
                    count += sumCopy & 1;
                }
                int parityRight = 1 - (count % 2);

                count = 0;
                for (int i = 0; i < 12; i++)
                {
                    sumCopy >>= 1;
                    count += sumCopy & 1;
                }
                int parityLeft = (count % 2) << 25;
                int total = sum + parityRight + parityLeft;
                string hexValue = total.ToString("X");//convert int to hex

                //See what we need to do for the Prefix
                hexValue = TxtPrefixAddition.Text + hexValue;
                if (hexValue.Length > Convert.ToInt32(TxtMaxCharResultLength.Text))
                {//Truncate left justified by number of characters over
                    int diffLength = hexValue.Length - Convert.ToInt32(TxtMaxCharResultLength.Text);
                    hexValue = hexValue.Substring(diffLength, hexValue.Length - diffLength);
                }
                if (ChkIncludeCCinResults.Checked)
                    hexValue = cardCode + "," + hexValue;

                return hexValue;
            }
            catch
            { 
                return ""; 
            }
        }
        private void CmdBulkGen_Click(object sender, EventArgs e)
        {
            string[] delimiterChars = { "\r\n" };
            string[] rows;
            rows = TxtBulkCardCode.Text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            RTxtResult.Clear();

            foreach (string s in rows)
            {
                try
                {
                    RTxtResult.AppendText(HexResult(Convert.ToInt32(TxtFacilityCode.Text), Convert.ToInt32(s)) + "\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            TxtBulkCardCode.Text = "";
            RTxtResult.Clear();
        }

        private void LnkVerifyOnline_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ccdesignworks.com/wiegand_calc.htm");
        }
    }
}
