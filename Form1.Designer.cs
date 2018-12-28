namespace Memcall
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.procBox = new System.Windows.Forms.TextBox();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minus0x4 = new System.Windows.Forms.CheckBox();
            this.FuncAdr = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.retHEX = new System.Windows.Forms.RadioButton();
            this.retINT = new System.Windows.Forms.RadioButton();
            this.retUINT = new System.Windows.Forms.RadioButton();
            this.retSTRING = new System.Windows.Forms.RadioButton();
            this.retFLOAT = new System.Windows.Forms.RadioButton();
            this.isReturns = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.argBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.naAdd = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.naHex = new System.Windows.Forms.RadioButton();
            this.naInt = new System.Windows.Forms.RadioButton();
            this.naUint = new System.Windows.Forms.RadioButton();
            this.naStr = new System.Windows.Forms.RadioButton();
            this.naFloat = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.naArg = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CCBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.InvokeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process name (without .exe)";
            // 
            // procBox
            // 
            this.procBox.Location = new System.Drawing.Point(158, 6);
            this.procBox.Name = "procBox";
            this.procBox.Size = new System.Drawing.Size(239, 20);
            this.procBox.TabIndex = 1;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SelectBtn.ForeColor = System.Drawing.Color.Navy;
            this.SelectBtn.Location = new System.Drawing.Point(403, 5);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(92, 20);
            this.SelectBtn.TabIndex = 2;
            this.SelectBtn.Text = "Select...";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AboutBtn.Location = new System.Drawing.Point(501, 5);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(77, 20);
            this.AboutBtn.TabIndex = 3;
            this.AboutBtn.Text = "About";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minus0x4);
            this.groupBox1.Controls.Add(this.FuncAdr);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address (Hex)";
            // 
            // minus0x4
            // 
            this.minus0x4.AutoSize = true;
            this.minus0x4.Location = new System.Drawing.Point(6, 45);
            this.minus0x4.Name = "minus0x4";
            this.minus0x4.Size = new System.Drawing.Size(163, 17);
            this.minus0x4.TabIndex = 5;
            this.minus0x4.Text = "Is relative to the main module";
            this.minus0x4.UseVisualStyleBackColor = true;
            // 
            // FuncAdr
            // 
            this.FuncAdr.Location = new System.Drawing.Point(6, 19);
            this.FuncAdr.Name = "FuncAdr";
            this.FuncAdr.Size = new System.Drawing.Size(165, 20);
            this.FuncAdr.TabIndex = 5;
            this.FuncAdr.TextChanged += new System.EventHandler(this.FuncAdr_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Controls.Add(this.isReturns);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.retHEX);
            this.flowLayoutPanel2.Controls.Add(this.retINT);
            this.flowLayoutPanel2.Controls.Add(this.retUINT);
            this.flowLayoutPanel2.Controls.Add(this.retSTRING);
            this.flowLayoutPanel2.Controls.Add(this.retFLOAT);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 42);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(173, 55);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // retHEX
            // 
            this.retHEX.AutoSize = true;
            this.retHEX.Checked = true;
            this.retHEX.Location = new System.Drawing.Point(3, 3);
            this.retHEX.Name = "retHEX";
            this.retHEX.Size = new System.Drawing.Size(62, 17);
            this.retHEX.TabIndex = 6;
            this.retHEX.TabStop = true;
            this.retHEX.Text = "int [hex]";
            this.retHEX.UseVisualStyleBackColor = true;
            // 
            // retINT
            // 
            this.retINT.AutoSize = true;
            this.retINT.Location = new System.Drawing.Point(3, 26);
            this.retINT.Name = "retINT";
            this.retINT.Size = new System.Drawing.Size(49, 17);
            this.retINT.TabIndex = 6;
            this.retINT.Text = "Int32";
            this.retINT.UseVisualStyleBackColor = true;
            // 
            // retUINT
            // 
            this.retUINT.AutoSize = true;
            this.retUINT.Location = new System.Drawing.Point(71, 3);
            this.retUINT.Name = "retUINT";
            this.retUINT.Size = new System.Drawing.Size(42, 17);
            this.retUINT.TabIndex = 7;
            this.retUINT.Text = "uint";
            this.retUINT.UseVisualStyleBackColor = true;
            // 
            // retSTRING
            // 
            this.retSTRING.AutoSize = true;
            this.retSTRING.Location = new System.Drawing.Point(71, 26);
            this.retSTRING.Name = "retSTRING";
            this.retSTRING.Size = new System.Drawing.Size(50, 17);
            this.retSTRING.TabIndex = 8;
            this.retSTRING.Text = "string";
            this.retSTRING.UseVisualStyleBackColor = true;
            // 
            // retFLOAT
            // 
            this.retFLOAT.AutoSize = true;
            this.retFLOAT.Location = new System.Drawing.Point(127, 3);
            this.retFLOAT.Name = "retFLOAT";
            this.retFLOAT.Size = new System.Drawing.Size(45, 17);
            this.retFLOAT.TabIndex = 9;
            this.retFLOAT.Text = "float";
            this.retFLOAT.UseVisualStyleBackColor = true;
            // 
            // isReturns
            // 
            this.isReturns.AutoSize = true;
            this.isReturns.Location = new System.Drawing.Point(6, 19);
            this.isReturns.Name = "isReturns";
            this.isReturns.Size = new System.Drawing.Size(95, 17);
            this.isReturns.TabIndex = 6;
            this.isReturns.Text = "Returns value:";
            this.isReturns.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemoveBtn);
            this.groupBox3.Controls.Add(this.argBox);
            this.groupBox3.Location = new System.Drawing.Point(197, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 174);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arguments";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.ForeColor = System.Drawing.Color.Maroon;
            this.RemoveBtn.Location = new System.Drawing.Point(6, 145);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(188, 23);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Remove selected";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // argBox
            // 
            this.argBox.FormattingEnabled = true;
            this.argBox.Location = new System.Drawing.Point(6, 19);
            this.argBox.Name = "argBox";
            this.argBox.Size = new System.Drawing.Size(188, 121);
            this.argBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.naAdd);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.naArg);
            this.groupBox4.Location = new System.Drawing.Point(403, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 174);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New Argument";
            // 
            // naAdd
            // 
            this.naAdd.ForeColor = System.Drawing.Color.OliveDrab;
            this.naAdd.Location = new System.Drawing.Point(147, 145);
            this.naAdd.Name = "naAdd";
            this.naAdd.Size = new System.Drawing.Size(22, 23);
            this.naAdd.TabIndex = 3;
            this.naAdd.Text = "+";
            this.naAdd.UseVisualStyleBackColor = true;
            this.naAdd.Click += new System.EventHandler(this.naAdd_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 122);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.naHex);
            this.flowLayoutPanel1.Controls.Add(this.naInt);
            this.flowLayoutPanel1.Controls.Add(this.naUint);
            this.flowLayoutPanel1.Controls.Add(this.naStr);
            this.flowLayoutPanel1.Controls.Add(this.naFloat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(157, 103);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // naHex
            // 
            this.naHex.AutoSize = true;
            this.naHex.Checked = true;
            this.naHex.Location = new System.Drawing.Point(3, 3);
            this.naHex.Name = "naHex";
            this.naHex.Size = new System.Drawing.Size(62, 17);
            this.naHex.TabIndex = 0;
            this.naHex.TabStop = true;
            this.naHex.Text = "int [hex]";
            this.naHex.UseVisualStyleBackColor = true;
            // 
            // naInt
            // 
            this.naInt.AutoSize = true;
            this.naInt.Location = new System.Drawing.Point(3, 26);
            this.naInt.Name = "naInt";
            this.naInt.Size = new System.Drawing.Size(49, 17);
            this.naInt.TabIndex = 1;
            this.naInt.Text = "Int32";
            this.naInt.UseVisualStyleBackColor = true;
            // 
            // naUint
            // 
            this.naUint.AutoSize = true;
            this.naUint.Location = new System.Drawing.Point(3, 49);
            this.naUint.Name = "naUint";
            this.naUint.Size = new System.Drawing.Size(42, 17);
            this.naUint.TabIndex = 2;
            this.naUint.Text = "uint";
            this.naUint.UseVisualStyleBackColor = true;
            // 
            // naStr
            // 
            this.naStr.AutoSize = true;
            this.naStr.Location = new System.Drawing.Point(3, 72);
            this.naStr.Name = "naStr";
            this.naStr.Size = new System.Drawing.Size(50, 17);
            this.naStr.TabIndex = 3;
            this.naStr.Text = "string";
            this.naStr.UseVisualStyleBackColor = true;
            // 
            // naFloat
            // 
            this.naFloat.AutoSize = true;
            this.naFloat.Location = new System.Drawing.Point(71, 3);
            this.naFloat.Name = "naFloat";
            this.naFloat.Size = new System.Drawing.Size(45, 17);
            this.naFloat.TabIndex = 4;
            this.naFloat.Text = "float";
            this.naFloat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value:";
            // 
            // naArg
            // 
            this.naArg.Location = new System.Drawing.Point(39, 147);
            this.naArg.Name = "naArg";
            this.naArg.Size = new System.Drawing.Size(106, 20);
            this.naArg.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CCBox);
            this.groupBox6.Location = new System.Drawing.Point(415, 212);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(163, 46);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Calling convention";
            // 
            // CCBox
            // 
            this.CCBox.FormattingEnabled = true;
            this.CCBox.Items.AddRange(new object[] {
            "Cdecl",
            "Fastcall",
            "Stdcall",
            "Thiscall"});
            this.CCBox.Location = new System.Drawing.Point(6, 19);
            this.CCBox.Name = "CCBox";
            this.CCBox.Size = new System.Drawing.Size(151, 21);
            this.CCBox.TabIndex = 0;
            this.CCBox.Text = "Cdecl";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Memcall.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(110, 212);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(299, 75);
            this.resultBox.TabIndex = 9;
            this.resultBox.Text = "Memcall by Dz3n";
            // 
            // InvokeBtn
            // 
            this.InvokeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvokeBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.InvokeBtn.Location = new System.Drawing.Point(415, 264);
            this.InvokeBtn.Name = "InvokeBtn";
            this.InvokeBtn.Size = new System.Drawing.Size(163, 23);
            this.InvokeBtn.TabIndex = 10;
            this.InvokeBtn.Text = "Invoke!";
            this.InvokeBtn.UseVisualStyleBackColor = true;
            this.InvokeBtn.Click += new System.EventHandler(this.InvokeBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 298);
            this.Controls.Add(this.InvokeBtn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.procBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox procBox;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox minus0x4;
        private System.Windows.Forms.TextBox FuncAdr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton retHEX;
        private System.Windows.Forms.RadioButton retINT;
        private System.Windows.Forms.RadioButton retUINT;
        private System.Windows.Forms.RadioButton retSTRING;
        private System.Windows.Forms.RadioButton retFLOAT;
        private System.Windows.Forms.CheckBox isReturns;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.ListBox argBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button naAdd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton naHex;
        private System.Windows.Forms.RadioButton naInt;
        private System.Windows.Forms.RadioButton naUint;
        private System.Windows.Forms.RadioButton naStr;
        private System.Windows.Forms.RadioButton naFloat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox naArg;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox CCBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button InvokeBtn;
    }
}

