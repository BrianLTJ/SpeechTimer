namespace SpeechTimer
{
    partial class FormStage
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
            this.listView_stagelist = new System.Windows.Forms.ListView();
            this.colH_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Timeout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Notice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_End = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Format = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.numericUpDownTime_h = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownNotice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxEnd = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownTime_m = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTime_s = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTimeformat = new System.Windows.Forms.ComboBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageProject = new System.Windows.Forms.TabPage();
            this.tabPageStage = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime_s)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageProject.SuspendLayout();
            this.tabPageStage.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_stagelist
            // 
            this.listView_stagelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_stagelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colH_ID,
            this.colH_Title,
            this.colH_Time,
            this.colH_Timeout,
            this.colH_Notice,
            this.colH_End,
            this.colH_Format});
            this.listView_stagelist.Location = new System.Drawing.Point(3, 14);
            this.listView_stagelist.Name = "listView_stagelist";
            this.listView_stagelist.Size = new System.Drawing.Size(262, 527);
            this.listView_stagelist.TabIndex = 0;
            this.listView_stagelist.UseCompatibleStateImageBehavior = false;
            this.listView_stagelist.View = System.Windows.Forms.View.Details;
            // 
            // colH_ID
            // 
            this.colH_ID.Text = "ID";
            this.colH_ID.Width = 30;
            // 
            // colH_Title
            // 
            this.colH_Title.Text = "标题";
            // 
            // colH_Time
            // 
            this.colH_Time.Text = "时长";
            // 
            // colH_Timeout
            // 
            this.colH_Timeout.Text = "超时计时";
            // 
            // colH_Notice
            // 
            this.colH_Notice.Text = "提醒";
            // 
            // colH_End
            // 
            this.colH_End.Text = "结束后动作";
            // 
            // colH_Format
            // 
            this.colH_Format.Text = "时间显示格式";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.Location = new System.Drawing.Point(3, 6);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.listView_stagelist);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.AutoScroll = true;
            this.splitContainerMain.Panel2.Controls.Add(this.comboBoxTimeformat);
            this.splitContainerMain.Panel2.Controls.Add(this.numericUpDownTime_s);
            this.splitContainerMain.Panel2.Controls.Add(this.label10);
            this.splitContainerMain.Panel2.Controls.Add(this.numericUpDownTime_m);
            this.splitContainerMain.Panel2.Controls.Add(this.comboBoxEnd);
            this.splitContainerMain.Panel2.Controls.Add(this.label9);
            this.splitContainerMain.Panel2.Controls.Add(this.numericUpDownNotice);
            this.splitContainerMain.Panel2.Controls.Add(this.label8);
            this.splitContainerMain.Panel2.Controls.Add(this.numericUpDownTimeout);
            this.splitContainerMain.Panel2.Controls.Add(this.label7);
            this.splitContainerMain.Panel2.Controls.Add(this.numericUpDownTime_h);
            this.splitContainerMain.Panel2.Controls.Add(this.textBox_title);
            this.splitContainerMain.Panel2.Controls.Add(this.label6);
            this.splitContainerMain.Panel2.Controls.Add(this.label5);
            this.splitContainerMain.Panel2.Controls.Add(this.label4);
            this.splitContainerMain.Panel2.Controls.Add(this.label3);
            this.splitContainerMain.Panel2.Controls.Add(this.label2);
            this.splitContainerMain.Panel2.Controls.Add(this.label1);
            this.splitContainerMain.Size = new System.Drawing.Size(570, 549);
            this.splitContainerMain.SplitterDistance = 268;
            this.splitContainerMain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "时长";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "超时计时";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "时间耗尽提醒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "结束后动作";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "时间显示格式";
            // 
            // textBox_title
            // 
            this.textBox_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_title.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_title.Location = new System.Drawing.Point(111, 24);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(175, 26);
            this.textBox_title.TabIndex = 6;
            // 
            // numericUpDownTime_h
            // 
            this.numericUpDownTime_h.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownTime_h.Location = new System.Drawing.Point(111, 72);
            this.numericUpDownTime_h.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownTime_h.Name = "numericUpDownTime_h";
            this.numericUpDownTime_h.Size = new System.Drawing.Size(42, 26);
            this.numericUpDownTime_h.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(158, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "秒";
            // 
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.Location = new System.Drawing.Point(111, 124);
            this.numericUpDownTimeout.Maximum = new decimal(new int[] {
            359999,
            0,
            0,
            0});
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(88, 21);
            this.numericUpDownTimeout.TabIndex = 10;
            this.numericUpDownTimeout.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "秒";
            // 
            // numericUpDownNotice
            // 
            this.numericUpDownNotice.Location = new System.Drawing.Point(111, 162);
            this.numericUpDownNotice.Maximum = new decimal(new int[] {
            359999,
            0,
            0,
            0});
            this.numericUpDownNotice.Name = "numericUpDownNotice";
            this.numericUpDownNotice.Size = new System.Drawing.Size(88, 21);
            this.numericUpDownNotice.TabIndex = 12;
            // 
            // comboBoxEnd
            // 
            this.comboBoxEnd.DisplayMember = "xczv";
            this.comboBoxEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnd.FormattingEnabled = true;
            this.comboBoxEnd.Items.AddRange(new object[] {
            "停止",
            "下一环节",
            "开始下一环节",
            "重置本环节",
            "重置本环节并开始计时"});
            this.comboBoxEnd.Location = new System.Drawing.Point(111, 201);
            this.comboBoxEnd.Name = "comboBoxEnd";
            this.comboBoxEnd.Size = new System.Drawing.Size(149, 20);
            this.comboBoxEnd.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(223, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = ":";
            // 
            // numericUpDownTime_m
            // 
            this.numericUpDownTime_m.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownTime_m.Location = new System.Drawing.Point(176, 72);
            this.numericUpDownTime_m.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownTime_m.Name = "numericUpDownTime_m";
            this.numericUpDownTime_m.Size = new System.Drawing.Size(42, 26);
            this.numericUpDownTime_m.TabIndex = 16;
            // 
            // numericUpDownTime_s
            // 
            this.numericUpDownTime_s.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownTime_s.Location = new System.Drawing.Point(243, 72);
            this.numericUpDownTime_s.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownTime_s.Name = "numericUpDownTime_s";
            this.numericUpDownTime_s.Size = new System.Drawing.Size(42, 26);
            this.numericUpDownTime_s.TabIndex = 18;
            // 
            // comboBoxTimeformat
            // 
            this.comboBoxTimeformat.DisplayMember = "xczv";
            this.comboBoxTimeformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeformat.FormattingEnabled = true;
            this.comboBoxTimeformat.Items.AddRange(new object[] {
            "自动宽度",
            "固定00:00:00",
            "固定00:00",
            "固定显示秒数"});
            this.comboBoxTimeformat.Location = new System.Drawing.Point(111, 243);
            this.comboBoxTimeformat.Name = "comboBoxTimeformat";
            this.comboBoxTimeformat.Size = new System.Drawing.Size(149, 20);
            this.comboBoxTimeformat.TabIndex = 19;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageProject);
            this.tabControlMain.Controls.Add(this.tabPageStage);
            this.tabControlMain.Location = new System.Drawing.Point(3, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(584, 581);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPageProject
            // 
            this.tabPageProject.Controls.Add(this.textBox1);
            this.tabPageProject.Controls.Add(this.label13);
            this.tabPageProject.Controls.Add(this.comboBox1);
            this.tabPageProject.Controls.Add(this.label11);
            this.tabPageProject.Controls.Add(this.label12);
            this.tabPageProject.Location = new System.Drawing.Point(4, 22);
            this.tabPageProject.Name = "tabPageProject";
            this.tabPageProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProject.Size = new System.Drawing.Size(576, 555);
            this.tabPageProject.TabIndex = 0;
            this.tabPageProject.Text = "方案设置";
            this.tabPageProject.UseVisualStyleBackColor = true;
            // 
            // tabPageStage
            // 
            this.tabPageStage.Controls.Add(this.splitContainerMain);
            this.tabPageStage.Location = new System.Drawing.Point(4, 22);
            this.tabPageStage.Name = "tabPageStage";
            this.tabPageStage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStage.Size = new System.Drawing.Size(576, 555);
            this.tabPageStage.TabIndex = 1;
            this.tabPageStage.Text = "环节设置";
            this.tabPageStage.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(434, 599);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(149, 35);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "全部保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "方案名称";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "所有环节结束后操作";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "文件地址";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "xczv";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "停止",
            "回到第一个环节",
            "回到第一个环节并开始"});
            this.comboBox1.Location = new System.Drawing.Point(193, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox1.Location = new System.Drawing.Point(193, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 26);
            this.textBox1.TabIndex = 16;
            // 
            // FormStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 644);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControlMain);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "FormStage";
            this.Text = "FormStage";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime_s)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProject.ResumeLayout(false);
            this.tabPageProject.PerformLayout();
            this.tabPageStage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_stagelist;
        private System.Windows.Forms.ColumnHeader colH_ID;
        private System.Windows.Forms.ColumnHeader colH_Title;
        private System.Windows.Forms.ColumnHeader colH_Time;
        private System.Windows.Forms.ColumnHeader colH_Timeout;
        private System.Windows.Forms.ColumnHeader colH_Notice;
        private System.Windows.Forms.ColumnHeader colH_End;
        private System.Windows.Forms.ColumnHeader colH_Format;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ComboBox comboBoxTimeformat;
        private System.Windows.Forms.NumericUpDown numericUpDownTime_s;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownTime_m;
        private System.Windows.Forms.ComboBox comboBoxEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownNotice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownTime_h;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageProject;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPageStage;
        private System.Windows.Forms.Button buttonSave;
    }
}