namespace WeiganSample
{
    partial class WiegandCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFacilityCode = new System.Windows.Forms.TextBox();
            this.TxtCardCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RTxtResult = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdBulkGen = new System.Windows.Forms.Button();
            this.TxtBulkCardCode = new System.Windows.Forms.TextBox();
            this.CmdClear = new System.Windows.Forms.Button();
            this.TxtPrefixAddition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LnkVerifyOnline = new System.Windows.Forms.LinkLabel();
            this.TxtMaxCharResultLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChkIncludeCCinResults = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CmdGenerate
            // 
            this.CmdGenerate.Location = new System.Drawing.Point(212, 9);
            this.CmdGenerate.Name = "CmdGenerate";
            this.CmdGenerate.Size = new System.Drawing.Size(114, 23);
            this.CmdGenerate.TabIndex = 0;
            this.CmdGenerate.Text = "Generate";
            this.CmdGenerate.UseVisualStyleBackColor = true;
            this.CmdGenerate.Click += new System.EventHandler(this.CmdGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facility Code";
            // 
            // TxtFacilityCode
            // 
            this.TxtFacilityCode.Location = new System.Drawing.Point(106, 6);
            this.TxtFacilityCode.Name = "TxtFacilityCode";
            this.TxtFacilityCode.Size = new System.Drawing.Size(100, 22);
            this.TxtFacilityCode.TabIndex = 2;
            this.TxtFacilityCode.Text = "22";
            // 
            // TxtCardCode
            // 
            this.TxtCardCode.Location = new System.Drawing.Point(106, 34);
            this.TxtCardCode.Name = "TxtCardCode";
            this.TxtCardCode.Size = new System.Drawing.Size(100, 22);
            this.TxtCardCode.TabIndex = 4;
            this.TxtCardCode.Text = "29683";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card Code";
            // 
            // RTxtResult
            // 
            this.RTxtResult.Location = new System.Drawing.Point(12, 326);
            this.RTxtResult.Name = "RTxtResult";
            this.RTxtResult.Size = new System.Drawing.Size(395, 175);
            this.RTxtResult.TabIndex = 5;
            this.RTxtResult.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Results";
            // 
            // CmdBulkGen
            // 
            this.CmdBulkGen.Location = new System.Drawing.Point(212, 118);
            this.CmdBulkGen.Name = "CmdBulkGen";
            this.CmdBulkGen.Size = new System.Drawing.Size(114, 23);
            this.CmdBulkGen.TabIndex = 8;
            this.CmdBulkGen.Text = "BulkGenerate";
            this.CmdBulkGen.UseVisualStyleBackColor = true;
            this.CmdBulkGen.Click += new System.EventHandler(this.CmdBulkGen_Click);
            // 
            // TxtBulkCardCode
            // 
            this.TxtBulkCardCode.Location = new System.Drawing.Point(12, 118);
            this.TxtBulkCardCode.MaxLength = 0;
            this.TxtBulkCardCode.Multiline = true;
            this.TxtBulkCardCode.Name = "TxtBulkCardCode";
            this.TxtBulkCardCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBulkCardCode.Size = new System.Drawing.Size(194, 179);
            this.TxtBulkCardCode.TabIndex = 9;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(212, 147);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(114, 23);
            this.CmdClear.TabIndex = 10;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // TxtPrefixAddition
            // 
            this.TxtPrefixAddition.Location = new System.Drawing.Point(106, 62);
            this.TxtPrefixAddition.Name = "TxtPrefixAddition";
            this.TxtPrefixAddition.Size = new System.Drawing.Size(100, 22);
            this.TxtPrefixAddition.TabIndex = 12;
            this.TxtPrefixAddition.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prefix Addition";
            // 
            // LnkVerifyOnline
            // 
            this.LnkVerifyOnline.AutoSize = true;
            this.LnkVerifyOnline.Location = new System.Drawing.Point(318, 307);
            this.LnkVerifyOnline.Name = "LnkVerifyOnline";
            this.LnkVerifyOnline.Size = new System.Drawing.Size(89, 17);
            this.LnkVerifyOnline.TabIndex = 13;
            this.LnkVerifyOnline.TabStop = true;
            this.LnkVerifyOnline.Text = "Verify Online";
            this.LnkVerifyOnline.Click += new System.EventHandler(this.LnkVerifyOnline_Click);
            // 
            // TxtMaxCharResultLength
            // 
            this.TxtMaxCharResultLength.Location = new System.Drawing.Point(167, 90);
            this.TxtMaxCharResultLength.Name = "TxtMaxCharResultLength";
            this.TxtMaxCharResultLength.Size = new System.Drawing.Size(39, 22);
            this.TxtMaxCharResultLength.TabIndex = 15;
            this.TxtMaxCharResultLength.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Max Char Result length";
            // 
            // ChkIncludeCCinResults
            // 
            this.ChkIncludeCCinResults.AutoSize = true;
            this.ChkIncludeCCinResults.Location = new System.Drawing.Point(80, 303);
            this.ChkIncludeCCinResults.Name = "ChkIncludeCCinResults";
            this.ChkIncludeCCinResults.Size = new System.Drawing.Size(207, 21);
            this.ChkIncludeCCinResults.TabIndex = 16;
            this.ChkIncludeCCinResults.Text = "Include Card Code in results";
            this.ChkIncludeCCinResults.UseVisualStyleBackColor = true;
            // 
            // WiegandCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 513);
            this.Controls.Add(this.ChkIncludeCCinResults);
            this.Controls.Add(this.TxtMaxCharResultLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LnkVerifyOnline);
            this.Controls.Add(this.TxtPrefixAddition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.TxtBulkCardCode);
            this.Controls.Add(this.CmdBulkGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTxtResult);
            this.Controls.Add(this.TxtCardCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFacilityCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdGenerate);
            this.Name = "WiegandCalculator";
            this.Text = "Wiegand Calculator - 26-bit format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFacilityCode;
        private System.Windows.Forms.TextBox TxtCardCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTxtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdBulkGen;
        private System.Windows.Forms.TextBox TxtBulkCardCode;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.TextBox TxtPrefixAddition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LnkVerifyOnline;
        private System.Windows.Forms.TextBox TxtMaxCharResultLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkIncludeCCinResults;
    }
}

