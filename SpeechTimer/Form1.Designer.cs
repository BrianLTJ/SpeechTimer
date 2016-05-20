namespace SpeechTimer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "1",
            "TestTitle",
            "00:03:00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "2",
            "TestTitle2",
            "00:01:00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "3",
            "Title3",
            "00:00:30"}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.打开方案OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存方案OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑方案EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看GithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.listView_stage = new System.Windows.Forms.ListView();
            this.colH_State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colH_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu_List = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_SetNext = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_PopUp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPrev = new System.Windows.Forms.GroupBox();
            this.Prev_panel = new System.Windows.Forms.Panel();
            this.Prev_label_time = new System.Windows.Forms.Label();
            this.Prev_label_stage = new System.Windows.Forms.Label();
            this.Prev_label_title = new System.Windows.Forms.Label();
            this.Prev_label_state = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnStyle_black = new System.Windows.Forms.RadioButton();
            this.radioBtnStyle_white = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNowStage = new System.Windows.Forms.Label();
            this.labelNextStage = new System.Windows.Forms.Label();
            this.buttonShowHideClock = new System.Windows.Forms.Button();
            this.timer_tick = new System.Windows.Forms.Timer(this.components);
            this.checkBoxStickTop = new System.Windows.Forms.CheckBox();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonNextStage = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.checkBoxAdjustLoc = new System.Windows.Forms.CheckBox();
            this.toolTipStop = new System.Windows.Forms.ToolTip(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.contextMenu_List.SuspendLayout();
            this.groupBoxPrev.SuspendLayout();
            this.Prev_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.ToolStripMenuItem_Setting,
            this.ToolStripMenuItem_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开方案OToolStripMenuItem,
            this.保存方案OToolStripMenuItem,
            this.另存为AToolStripMenuItem});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(58, 21);
            this.toolStripMenuItem_File.Text = "文件(&F)";
            // 
            // 打开方案OToolStripMenuItem
            // 
            this.打开方案OToolStripMenuItem.Name = "打开方案OToolStripMenuItem";
            this.打开方案OToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.打开方案OToolStripMenuItem.Text = "打开方案(&O)";
            // 
            // 保存方案OToolStripMenuItem
            // 
            this.保存方案OToolStripMenuItem.Name = "保存方案OToolStripMenuItem";
            this.保存方案OToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.保存方案OToolStripMenuItem.Text = "保存方案(&S)";
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            // 
            // ToolStripMenuItem_Setting
            // 
            this.ToolStripMenuItem_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑方案EToolStripMenuItem});
            this.ToolStripMenuItem_Setting.Name = "ToolStripMenuItem_Setting";
            this.ToolStripMenuItem_Setting.Size = new System.Drawing.Size(59, 21);
            this.ToolStripMenuItem_Setting.Text = "设置(&S)";
            // 
            // 编辑方案EToolStripMenuItem
            // 
            this.编辑方案EToolStripMenuItem.Name = "编辑方案EToolStripMenuItem";
            this.编辑方案EToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.编辑方案EToolStripMenuItem.Text = "编辑方案(&E)";
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检查更新ToolStripMenuItem,
            this.查看GithubToolStripMenuItem,
            this.关于ToolStripMenuItem1});
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            this.ToolStripMenuItem_About.Size = new System.Drawing.Size(60, 21);
            this.ToolStripMenuItem_About.Text = "关于(&A)";
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.检查更新ToolStripMenuItem.Text = "检查更新";
            // 
            // 查看GithubToolStripMenuItem
            // 
            this.查看GithubToolStripMenuItem.Name = "查看GithubToolStripMenuItem";
            this.查看GithubToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.查看GithubToolStripMenuItem.Text = "查看Github";
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.关于ToolStripMenuItem1.Text = "关于";
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // listView_stage
            // 
            this.listView_stage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colH_State,
            this.colH_ID,
            this.colH_Title,
            this.colH_Time});
            this.listView_stage.FullRowSelect = true;
            this.listView_stage.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView_stage.Location = new System.Drawing.Point(6, 28);
            this.listView_stage.MultiSelect = false;
            this.listView_stage.Name = "listView_stage";
            this.listView_stage.Size = new System.Drawing.Size(233, 313);
            this.listView_stage.TabIndex = 1;
            this.listView_stage.UseCompatibleStateImageBehavior = false;
            this.listView_stage.View = System.Windows.Forms.View.Details;
            this.listView_stage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_stage_MouseClick);
            this.listView_stage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_stage_MouseClick);
            // 
            // colH_State
            // 
            this.colH_State.Text = "状态";
            this.colH_State.Width = 22;
            // 
            // colH_ID
            // 
            this.colH_ID.Text = "ID";
            this.colH_ID.Width = 36;
            // 
            // colH_Title
            // 
            this.colH_Title.Text = "标题";
            // 
            // colH_Time
            // 
            this.colH_Time.Text = "时长";
            this.colH_Time.Width = 80;
            // 
            // contextMenu_List
            // 
            this.contextMenu_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SetNext,
            this.ToolStripMenuItem_PopUp,
            this.ToolStripMenuItem_Details});
            this.contextMenu_List.Name = "contextMenu_List";
            this.contextMenu_List.Size = new System.Drawing.Size(167, 70);
            this.contextMenu_List.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_List_Opening);
            // 
            // ToolStripMenuItem_SetNext
            // 
            this.ToolStripMenuItem_SetNext.Name = "ToolStripMenuItem_SetNext";
            this.ToolStripMenuItem_SetNext.Size = new System.Drawing.Size(166, 22);
            this.ToolStripMenuItem_SetNext.Text = "设为下一环节(&N)";
            this.ToolStripMenuItem_SetNext.Click += new System.EventHandler(this.ToolStripMenuItem_SetNext_Click);
            // 
            // ToolStripMenuItem_PopUp
            // 
            this.ToolStripMenuItem_PopUp.Name = "ToolStripMenuItem_PopUp";
            this.ToolStripMenuItem_PopUp.Size = new System.Drawing.Size(166, 22);
            this.ToolStripMenuItem_PopUp.Text = "插播(&B)";
            // 
            // ToolStripMenuItem_Details
            // 
            this.ToolStripMenuItem_Details.Name = "ToolStripMenuItem_Details";
            this.ToolStripMenuItem_Details.Size = new System.Drawing.Size(166, 22);
            this.ToolStripMenuItem_Details.Text = "详情(&D)";
            // 
            // groupBoxPrev
            // 
            this.groupBoxPrev.Controls.Add(this.Prev_panel);
            this.groupBoxPrev.Controls.Add(this.Prev_label_state);
            this.groupBoxPrev.Location = new System.Drawing.Point(257, 350);
            this.groupBoxPrev.Name = "groupBoxPrev";
            this.groupBoxPrev.Size = new System.Drawing.Size(241, 130);
            this.groupBoxPrev.TabIndex = 2;
            this.groupBoxPrev.TabStop = false;
            this.groupBoxPrev.Text = "实时";
            // 
            // Prev_panel
            // 
            this.Prev_panel.Controls.Add(this.Prev_label_time);
            this.Prev_panel.Controls.Add(this.Prev_label_stage);
            this.Prev_panel.Controls.Add(this.Prev_label_title);
            this.Prev_panel.Location = new System.Drawing.Point(8, 32);
            this.Prev_panel.Name = "Prev_panel";
            this.Prev_panel.Size = new System.Drawing.Size(218, 92);
            this.Prev_panel.TabIndex = 1;
            // 
            // Prev_label_time
            // 
            this.Prev_label_time.BackColor = System.Drawing.Color.Transparent;
            this.Prev_label_time.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Prev_label_time.Location = new System.Drawing.Point(2, 57);
            this.Prev_label_time.Name = "Prev_label_time";
            this.Prev_label_time.Size = new System.Drawing.Size(210, 33);
            this.Prev_label_time.TabIndex = 2;
            this.Prev_label_time.Text = "-00:00:00";
            this.Prev_label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prev_label_stage
            // 
            this.Prev_label_stage.BackColor = System.Drawing.Color.Transparent;
            this.Prev_label_stage.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Prev_label_stage.Location = new System.Drawing.Point(3, 34);
            this.Prev_label_stage.Name = "Prev_label_stage";
            this.Prev_label_stage.Size = new System.Drawing.Size(210, 23);
            this.Prev_label_stage.TabIndex = 1;
            this.Prev_label_stage.Text = "副标题";
            this.Prev_label_stage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prev_label_title
            // 
            this.Prev_label_title.BackColor = System.Drawing.Color.Transparent;
            this.Prev_label_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.Prev_label_title.Location = new System.Drawing.Point(2, 3);
            this.Prev_label_title.Name = "Prev_label_title";
            this.Prev_label_title.Size = new System.Drawing.Size(210, 28);
            this.Prev_label_title.TabIndex = 0;
            this.Prev_label_title.Text = "主标题";
            this.Prev_label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prev_label_state
            // 
            this.Prev_label_state.AutoSize = true;
            this.Prev_label_state.Location = new System.Drawing.Point(6, 17);
            this.Prev_label_state.Name = "Prev_label_state";
            this.Prev_label_state.Size = new System.Drawing.Size(41, 12);
            this.Prev_label_state.TabIndex = 0;
            this.Prev_label_state.Text = "已停止";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "透明度";
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.AutoSize = false;
            this.trackBarOpacity.LargeChange = 2;
            this.trackBarOpacity.Location = new System.Drawing.Point(56, 163);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(119, 24);
            this.trackBarOpacity.TabIndex = 4;
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOpacity.Value = 100;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.trackBarOpacity_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "界面颜色";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnStyle_black);
            this.panel1.Controls.Add(this.radioBtnStyle_white);
            this.panel1.Location = new System.Drawing.Point(60, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 25);
            this.panel1.TabIndex = 6;
            // 
            // radioBtnStyle_black
            // 
            this.radioBtnStyle_black.AutoSize = true;
            this.radioBtnStyle_black.Location = new System.Drawing.Point(57, 4);
            this.radioBtnStyle_black.Name = "radioBtnStyle_black";
            this.radioBtnStyle_black.Size = new System.Drawing.Size(47, 16);
            this.radioBtnStyle_black.TabIndex = 1;
            this.radioBtnStyle_black.Text = "黑色";
            this.radioBtnStyle_black.UseVisualStyleBackColor = true;
            this.radioBtnStyle_black.CheckedChanged += new System.EventHandler(this.radioBtnStyle_black_CheckedChanged);
            // 
            // radioBtnStyle_white
            // 
            this.radioBtnStyle_white.AutoSize = true;
            this.radioBtnStyle_white.Checked = true;
            this.radioBtnStyle_white.Location = new System.Drawing.Point(4, 3);
            this.radioBtnStyle_white.Name = "radioBtnStyle_white";
            this.radioBtnStyle_white.Size = new System.Drawing.Size(47, 16);
            this.radioBtnStyle_white.TabIndex = 0;
            this.radioBtnStyle_white.TabStop = true;
            this.radioBtnStyle_white.Text = "白色";
            this.radioBtnStyle_white.UseVisualStyleBackColor = true;
            this.radioBtnStyle_white.CheckedChanged += new System.EventHandler(this.radioBtnStyle_white_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "当前环节";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "下一环节";
            // 
            // labelNowStage
            // 
            this.labelNowStage.AutoEllipsis = true;
            this.labelNowStage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNowStage.Location = new System.Drawing.Point(12, 383);
            this.labelNowStage.Name = "labelNowStage";
            this.labelNowStage.Size = new System.Drawing.Size(227, 30);
            this.labelNowStage.TabIndex = 9;
            this.labelNowStage.Text = "---";
            this.labelNowStage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNextStage
            // 
            this.labelNextStage.AutoEllipsis = true;
            this.labelNextStage.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelNextStage.Location = new System.Drawing.Point(12, 445);
            this.labelNextStage.Name = "labelNextStage";
            this.labelNextStage.Size = new System.Drawing.Size(227, 29);
            this.labelNextStage.TabIndex = 10;
            this.labelNextStage.Text = "---";
            this.labelNextStage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonShowHideClock
            // 
            this.buttonShowHideClock.Location = new System.Drawing.Point(202, 78);
            this.buttonShowHideClock.Name = "buttonShowHideClock";
            this.buttonShowHideClock.Size = new System.Drawing.Size(51, 33);
            this.buttonShowHideClock.TabIndex = 11;
            this.buttonShowHideClock.Text = "显示计时窗口";
            this.toolTipStop.SetToolTip(this.buttonShowHideClock, "显示或关闭计时窗口");
            this.buttonShowHideClock.UseVisualStyleBackColor = true;
            this.buttonShowHideClock.Click += new System.EventHandler(this.buttonShowHideClock_Click);
            // 
            // timer_tick
            // 
            this.timer_tick.Tick += new System.EventHandler(this.timer_tick_Tick);
            // 
            // checkBoxStickTop
            // 
            this.checkBoxStickTop.Location = new System.Drawing.Point(185, 117);
            this.checkBoxStickTop.Name = "checkBoxStickTop";
            this.checkBoxStickTop.Size = new System.Drawing.Size(67, 37);
            this.checkBoxStickTop.TabIndex = 12;
            this.checkBoxStickTop.Text = "计时窗口置顶";
            this.checkBoxStickTop.UseVisualStyleBackColor = true;
            this.checkBoxStickTop.CheckedChanged += new System.EventHandler(this.checkBoxStickTop_CheckedChanged);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(10, 6);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(118, 47);
            this.buttonStartStop.TabIndex = 13;
            this.buttonStartStop.Text = "开始/暂停计时";
            this.toolTipStop.SetToolTip(this.buttonStartStop, "开始/暂停计时");
            this.buttonStartStop.UseVisualStyleBackColor = true;
            // 
            // buttonNextStage
            // 
            this.buttonNextStage.Location = new System.Drawing.Point(135, 6);
            this.buttonNextStage.Name = "buttonNextStage";
            this.buttonNextStage.Size = new System.Drawing.Size(118, 47);
            this.buttonNextStage.TabIndex = 14;
            this.buttonNextStage.Text = "下一环节";
            this.toolTipStop.SetToolTip(this.buttonNextStage, "立即切换到下一环节开始计时");
            this.buttonNextStage.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(11, 78);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(40, 33);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.Text = "停止";
            this.toolTipStop.SetToolTip(this.buttonStop, "停止计时并重置当前环节");
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdjustLoc
            // 
            this.checkBoxAdjustLoc.Checked = true;
            this.checkBoxAdjustLoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdjustLoc.Location = new System.Drawing.Point(185, 160);
            this.checkBoxAdjustLoc.Name = "checkBoxAdjustLoc";
            this.checkBoxAdjustLoc.Size = new System.Drawing.Size(66, 48);
            this.checkBoxAdjustLoc.TabIndex = 16;
            this.checkBoxAdjustLoc.Text = "显示计时窗口标题栏";
            this.checkBoxAdjustLoc.UseVisualStyleBackColor = true;
            this.checkBoxAdjustLoc.CheckedChanged += new System.EventHandler(this.checkBoxAdjustLoc_CheckedChanged);
            // 
            // toolTipStop
            // 
            this.toolTipStop.AutomaticDelay = 300;
            this.toolTipStop.AutoPopDelay = 10000;
            this.toolTipStop.InitialDelay = 300;
            this.toolTipStop.ReshowDelay = 60;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(64, 78);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(39, 33);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "重置";
            this.toolTipStop.SetToolTip(this.buttonReset, "停止计时，重置当前方案，回到环节1，计时器归零");
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonReset);
            this.panelControl.Controls.Add(this.checkBoxAdjustLoc);
            this.panelControl.Controls.Add(this.buttonStop);
            this.panelControl.Controls.Add(this.buttonNextStage);
            this.panelControl.Controls.Add(this.buttonStartStop);
            this.panelControl.Controls.Add(this.checkBoxStickTop);
            this.panelControl.Controls.Add(this.buttonShowHideClock);
            this.panelControl.Controls.Add(this.panel1);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.trackBarOpacity);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Location = new System.Drawing.Point(247, 32);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(266, 309);
            this.panelControl.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 497);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.labelNextStage);
            this.Controls.Add(this.labelNowStage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView_stage);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxPrev);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SpeechTimer - 控制台[新方案*]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenu_List.ResumeLayout(false);
            this.groupBoxPrev.ResumeLayout(false);
            this.groupBoxPrev.PerformLayout();
            this.Prev_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看GithubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ListView listView_stage;
        private System.Windows.Forms.ColumnHeader colH_State;
        private System.Windows.Forms.ColumnHeader colH_ID;
        private System.Windows.Forms.ColumnHeader colH_Title;
        private System.Windows.Forms.ColumnHeader colH_Time;
        private System.Windows.Forms.GroupBox groupBoxPrev;
        private System.Windows.Forms.Panel Prev_panel;
        private System.Windows.Forms.Label Prev_label_state;
        private System.Windows.Forms.Label Prev_label_time;
        private System.Windows.Forms.Label Prev_label_stage;
        private System.Windows.Forms.Label Prev_label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnStyle_black;
        private System.Windows.Forms.RadioButton radioBtnStyle_white;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNowStage;
        private System.Windows.Forms.Label labelNextStage;
        private System.Windows.Forms.ContextMenuStrip contextMenu_List;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SetNext;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_PopUp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Details;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem 打开方案OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存方案OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑方案EToolStripMenuItem;
        private System.Windows.Forms.Button buttonShowHideClock;
        private System.Windows.Forms.Timer timer_tick;
        private System.Windows.Forms.CheckBox checkBoxStickTop;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Button buttonNextStage;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.CheckBox checkBoxAdjustLoc;
        private System.Windows.Forms.ToolTip toolTipStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panelControl;
    }
}

