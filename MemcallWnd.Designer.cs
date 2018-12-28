namespace Memcall
{
    partial class MemcallWnd
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveArgs = new System.Windows.Forms.Button();
            this.panelOld = new System.Windows.Forms.Panel();
            this.btnOpenArgs = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbActivateWindow = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnInvoke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbArgs = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.cbReturnHex = new System.Windows.Forms.CheckBox();
            this.cbReturn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.cbIsRelative = new System.Windows.Forms.CheckBox();
            this.gbArgProps = new System.Windows.Forms.GroupBox();
            this.cbAutoType = new System.Windows.Forms.CheckBox();
            this.cbArgType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArgValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApplyProps = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbArgProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.Transparent;
            this.btnProcess.Location = new System.Drawing.Point(424, 12);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(204, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "PSELECT";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.button1_Click);
            this.btnProcess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnProcess_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnSaveArgs);
            this.panel1.Controls.Add(this.panelOld);
            this.panel1.Controls.Add(this.btnOpenArgs);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 47);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnSaveArgs
            // 
            this.btnSaveArgs.Location = new System.Drawing.Point(129, 12);
            this.btnSaveArgs.Name = "btnSaveArgs";
            this.btnSaveArgs.Size = new System.Drawing.Size(59, 23);
            this.btnSaveArgs.TabIndex = 6;
            this.btnSaveArgs.Text = "Save...";
            this.btnSaveArgs.UseVisualStyleBackColor = true;
            this.btnSaveArgs.Click += new System.EventHandler(this.btnSaveArgs_Click);
            // 
            // panelOld
            // 
            this.panelOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelOld.Location = new System.Drawing.Point(372, 12);
            this.panelOld.Name = "panelOld";
            this.panelOld.Size = new System.Drawing.Size(46, 20);
            this.panelOld.TabIndex = 16;
            this.panelOld.Click += new System.EventHandler(this.panelOld_Click);
            // 
            // btnOpenArgs
            // 
            this.btnOpenArgs.Location = new System.Drawing.Point(62, 12);
            this.btnOpenArgs.Name = "btnOpenArgs";
            this.btnOpenArgs.Size = new System.Drawing.Size(67, 23);
            this.btnOpenArgs.TabIndex = 5;
            this.btnOpenArgs.Text = "Open";
            this.btnOpenArgs.UseVisualStyleBackColor = true;
            this.btnOpenArgs.Click += new System.EventHandler(this.btnOpenArgs_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.Location = new System.Drawing.Point(630, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(53, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(695, 1);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Memcall.Properties.Resources.Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(12, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 37);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTitle.Location = new System.Drawing.Point(187, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(67, 20);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Memcall";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbActivateWindow);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.tbLog);
            this.panel2.Controls.Add(this.btnInvoke);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 99);
            this.panel2.TabIndex = 3;
            // 
            // cbActivateWindow
            // 
            this.cbActivateWindow.AutoSize = true;
            this.cbActivateWindow.Location = new System.Drawing.Point(521, 64);
            this.cbActivateWindow.Name = "cbActivateWindow";
            this.cbActivateWindow.Size = new System.Drawing.Size(147, 17);
            this.cbActivateWindow.TabIndex = 3;
            this.cbActivateWindow.Text = "Activate the main window";
            this.cbActivateWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbActivateWindow.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(695, 1);
            this.panel5.TabIndex = 2;
            // 
            // tbLog
            // 
            this.tbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLog.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.tbLog.Location = new System.Drawing.Point(12, 10);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(475, 77);
            this.tbLog.TabIndex = 1;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
            // 
            // btnInvoke
            // 
            this.btnInvoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoke.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoke.Location = new System.Drawing.Point(503, 22);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(180, 39);
            this.btnInvoke.TabIndex = 0;
            this.btnInvoke.Text = "I believe I can fly (invoke)";
            this.btnInvoke.UseVisualStyleBackColor = false;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lbArgs);
            this.groupBox1.Location = new System.Drawing.Point(200, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 256);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arguments";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(6, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Argument";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.button4.Location = new System.Drawing.Point(203, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.button3.Location = new System.Drawing.Point(172, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Up";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(100, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // lbArgs
            // 
            this.lbArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArgs.BackColor = System.Drawing.SystemColors.Window;
            this.lbArgs.FormattingEnabled = true;
            this.lbArgs.Location = new System.Drawing.Point(6, 19);
            this.lbArgs.Name = "lbArgs";
            this.lbArgs.Size = new System.Drawing.Size(228, 199);
            this.lbArgs.TabIndex = 0;
            this.lbArgs.SelectedIndexChanged += new System.EventHandler(this.lbArgs_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.cbCC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelInformation);
            this.groupBox2.Controls.Add(this.cbReturnHex);
            this.groupBox2.Controls.Add(this.cbReturn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbAddress);
            this.groupBox2.Controls.Add(this.cbIsRelative);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 256);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Method";
            // 
            // cbCC
            // 
            this.cbCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCC.FormattingEnabled = true;
            this.cbCC.Items.AddRange(new object[] {
            "Cdecl",
            "Fastcall",
            "Stdcall",
            "Thiscall"});
            this.cbCC.Location = new System.Drawing.Point(6, 104);
            this.cbCC.Name = "cbCC";
            this.cbCC.Size = new System.Drawing.Size(170, 21);
            this.cbCC.TabIndex = 15;
            this.cbCC.Text = "Cdecl";
            this.cbCC.TextChanged += new System.EventHandler(this.cbCC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Calling convention";
            // 
            // labelInformation
            // 
            this.labelInformation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelInformation.Location = new System.Drawing.Point(6, 197);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(170, 56);
            this.labelInformation.TabIndex = 13;
            this.labelInformation.Text = "Here will be information about process";
            // 
            // cbReturnHex
            // 
            this.cbReturnHex.AutoSize = true;
            this.cbReturnHex.Checked = true;
            this.cbReturnHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReturnHex.Location = new System.Drawing.Point(9, 174);
            this.cbReturnHex.Name = "cbReturnHex";
            this.cbReturnHex.Size = new System.Drawing.Size(113, 17);
            this.cbReturnHex.TabIndex = 12;
            this.cbReturnHex.Text = "Also show it in hex";
            this.cbReturnHex.UseVisualStyleBackColor = true;
            // 
            // cbReturn
            // 
            this.cbReturn.FormattingEnabled = true;
            this.cbReturn.Items.AddRange(new object[] {
            "Nothing"});
            this.cbReturn.Location = new System.Drawing.Point(6, 150);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Size = new System.Drawing.Size(170, 21);
            this.cbReturn.TabIndex = 11;
            this.cbReturn.Text = "Nothing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Returnable value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Address";
            // 
            // cbAddress
            // 
            this.cbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddress.AutoCompleteCustomSource.AddRange(new string[] {
            "0x"});
            this.cbAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(6, 38);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(170, 21);
            this.cbAddress.TabIndex = 8;
            this.cbAddress.SelectedIndexChanged += new System.EventHandler(this.cbAddress_SelectedIndexChanged);
            this.cbAddress.TextChanged += new System.EventHandler(this.cbAddress_TextChanged);
            this.cbAddress.Leave += new System.EventHandler(this.cbAddress_Leave);
            // 
            // cbIsRelative
            // 
            this.cbIsRelative.AutoSize = true;
            this.cbIsRelative.Location = new System.Drawing.Point(6, 65);
            this.cbIsRelative.Name = "cbIsRelative";
            this.cbIsRelative.Size = new System.Drawing.Size(163, 17);
            this.cbIsRelative.TabIndex = 6;
            this.cbIsRelative.Text = "Is relative to the main module";
            this.cbIsRelative.UseVisualStyleBackColor = true;
            // 
            // gbArgProps
            // 
            this.gbArgProps.Controls.Add(this.cbAutoType);
            this.gbArgProps.Controls.Add(this.cbArgType);
            this.gbArgProps.Controls.Add(this.label4);
            this.gbArgProps.Controls.Add(this.tbArgValue);
            this.gbArgProps.Controls.Add(this.label3);
            this.gbArgProps.Controls.Add(this.btnApplyProps);
            this.gbArgProps.Location = new System.Drawing.Point(446, 53);
            this.gbArgProps.Name = "gbArgProps";
            this.gbArgProps.Size = new System.Drawing.Size(237, 256);
            this.gbArgProps.TabIndex = 6;
            this.gbArgProps.TabStop = false;
            this.gbArgProps.Text = "Argument Properties";
            // 
            // cbAutoType
            // 
            this.cbAutoType.AutoSize = true;
            this.cbAutoType.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAutoType.Checked = true;
            this.cbAutoType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoType.Location = new System.Drawing.Point(160, 115);
            this.cbAutoType.Name = "cbAutoType";
            this.cbAutoType.Size = new System.Drawing.Size(71, 17);
            this.cbAutoType.TabIndex = 15;
            this.cbAutoType.Text = "Auto type";
            this.cbAutoType.UseVisualStyleBackColor = true;
            // 
            // cbArgType
            // 
            this.cbArgType.FormattingEnabled = true;
            this.cbArgType.Location = new System.Drawing.Point(10, 38);
            this.cbArgType.Name = "cbArgType";
            this.cbArgType.Size = new System.Drawing.Size(221, 21);
            this.cbArgType.TabIndex = 14;
            this.cbArgType.Text = "String";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // tbArgValue
            // 
            this.tbArgValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArgValue.Location = new System.Drawing.Point(10, 92);
            this.tbArgValue.Name = "tbArgValue";
            this.tbArgValue.Size = new System.Drawing.Size(221, 20);
            this.tbArgValue.TabIndex = 4;
            this.tbArgValue.TextChanged += new System.EventHandler(this.tbArgValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Value";
            // 
            // btnApplyProps
            // 
            this.btnApplyProps.Location = new System.Drawing.Point(133, 220);
            this.btnApplyProps.Name = "btnApplyProps";
            this.btnApplyProps.Size = new System.Drawing.Size(98, 23);
            this.btnApplyProps.TabIndex = 0;
            this.btnApplyProps.Text = "Apply";
            this.btnApplyProps.UseVisualStyleBackColor = true;
            this.btnApplyProps.Click += new System.EventHandler(this.btnApplyProps_Click);
            // 
            // MemcallWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 427);
            this.Controls.Add(this.gbArgProps);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(701, 452);
            this.Name = "MemcallWnd";
            this.Text = "Memcall";
            this.Activated += new System.EventHandler(this.MemcallWnd_Activated);
            this.Deactivate += new System.EventHandler(this.MemcallWnd_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemcallWnd_FormClosing);
            this.Load += new System.EventHandler(this.MemcallWnd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbArgProps.ResumeLayout(false);
            this.gbArgProps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInvoke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbArgs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.CheckBox cbIsRelative;
        private System.Windows.Forms.CheckBox cbReturnHex;
        private System.Windows.Forms.ComboBox cbReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbArgProps;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button btnApplyProps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbArgType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArgValue;
        private System.Windows.Forms.CheckBox cbAutoType;
        private System.Windows.Forms.ComboBox cbCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox cbActivateWindow;
        private System.Windows.Forms.Panel panelOld;
        private System.Windows.Forms.Button btnSaveArgs;
        private System.Windows.Forms.Button btnOpenArgs;
    }
}