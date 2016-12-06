using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
            //Research
            // http://www.identisource.net/26_bit_format_layout.cfm
            // http://stackoverflow.com/questions/30919535/determine-facility-code-and-card-number-from-atr-in-c-sharp

            RTxtResult.Clear();
            RTxtResult.AppendText(HexResult(Convert.ToInt32(TxtFacilityCode.Text), Convert.ToInt32(TxtCardCode.Text)));
        }
        private string HexResult(int facilityCode, int cardCode)
        {
            try
            {
                //So 2^17 * facilityCode plus 2^1 * cardcode = value
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

        private void CmdConvertHex_Click(object sender, EventArgs e)
        {
            try
            {
                //FromByteArray(hexString, int byteOffset, int bitOffset, int numberOfBits)
                //var cardNumber = FromByteArray(atrByteArray, 0, 1, 16);
                //var facilityCode = FromByteArray(atrByteArray, 0, 17, 8);
                RTxtResult.Clear();
                var hexString = TxtConvertHex.Text;
                var start_number = Int64.Parse(hexString, NumberStyles.HexNumber);
                Int64 a_26_only = start_number & 0x3FFFFFF; //26 bits, 11 1111 1111 1111 1111 1111 1111             
                //Int64 result = (a_26_only >> bitOffset) & (long)(Math.Pow(2,numberOfBits)-1); 
                RTxtResult.AppendText("Card Number:"+((a_26_only >> 1) & (long)(Math.Pow(2, 16) - 1)).ToString() + "\r\n");
                RTxtResult.AppendText("Facility Code:" + ((a_26_only >> 17) & (long)(Math.Pow(2, 8) - 1)).ToString() + "\r\n");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }
    }
}
