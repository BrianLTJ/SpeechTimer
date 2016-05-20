using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SpeechTimer
    
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listView_stage_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.listView_stage.SelectedItems.Count == 1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.listView_stage.ContextMenuStrip = contextMenu_List;
                }
            }
            else
            {
                this.listView_stage.ContextMenuStrip = null;
            }
        }

        private void ToolStripMenuItem_SetNext_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenu_List_Opening(object sender, CancelEventArgs e)
        {
            Global.setSelectedStage(((ListView)((sender as ContextMenuStrip).SourceControl)).SelectedItems[0].Index);
        }

        private void buttonShowHideClock_Click(object sender, EventArgs e)
        {
            if(Global.toggleFormShow()) { buttonShowHideClock.Text = "隐藏计时窗口"; }
            else { buttonShowHideClock.Text = "显示计时窗口"; }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            //控制数秒计时器
            if(Global.ClockState){
                timer_tick.Enabled = true;
            }

        }

        private void timer_tick_Tick(object sender, EventArgs e)
        {
            Global.decNowTime();
        }

        private void checkBoxStickTop_CheckedChanged(object sender, EventArgs e)
        {
            Global.setFormStickTop(checkBoxStickTop.Checked);
        }

        private void radioBtnStyle_white_CheckedChanged(object sender, EventArgs e)
        {
            Global.setFormStyle("white");
        }

        private void radioBtnStyle_black_CheckedChanged(object sender, EventArgs e)
        {
            Global.setFormStyle("black");
        }

        private void trackBarOpacity_Scroll(object sender, EventArgs e)
        {
            Global.setFormOpacity(trackBarOpacity.Value);
        }

        private void checkBoxAdjustLoc_CheckedChanged(object sender, EventArgs e)
        {
            Global.setFormBorder(checkBoxAdjustLoc.Checked);
        }
    }

    public class Global
    {
        public static bool ClockState = false;

        private static string[][] StageInfo;

        private static int NowStageID = 0;
        private static int NextStageID = 0;
        private static int NowTime = 0;
        private static TimeObj TimeCount = new TimeObj(0,0,0);

        private static int SelectedStageID = 0;

        //Project Info
        private static string Project_Title = "新方案";
        private static string Project_End = "BackToFirst";
        private static string Project_ShowType = "FixedClock3";

        public static void setNowStage(int id){ NowStageID = id;}

        public static void setNextStage(int id){ NextStageID = id;}

        public static int getNowStage(int id){ return NowStageID;}

        public static int getNextStage(int id){ return NextStageID;}

        public static void setProject_Title(string title){ Project_Title = title;}

        public static string getProjectTitle(){ return Project_Title;}

        public static void setProjectEnd(string end){ Project_End = end;}

        public static string getProjectEnd(string end){ return Project_End;}

        public static void setProjectShowType(string showType){ Project_ShowType = showType;}

        public static string getProjectShowType(string showType){ return Project_ShowType;}

        public static void setSelectedStage(int id) { SelectedStageID = id; }

        public static int getSelectedStage() { return SelectedStageID; }

        //设置时间
        public static void decNowTime() { NowTime--; }

        public static int getNowTime() { return NowTime; }

        public static void setNowTime(int t) { NowTime = t * 10; }//输入为秒计,存储单位为0.1s

        private static void setTimeObj() { TimeCount.SetTime(NowTime / 10); }

        public static string getTimeStr(int format) { return TimeCount.GetTimeStr(format); }


        public static string[] getNowStage() //ID,Title,length(sec),Timeout,NoticeTime,End
        {
            return StageInfo[NowStageID];
        }
        public static void loadStageInfoToList()
        {
            for(int i = 0; i < StageInfo.Length;i++)
            {
                
            }
        }


        //计时窗口
        public static FormShow formClock = new FormShow();
        public static bool clockFormState = false;

        public static string formStyle = "white";
        public static int formOpacity = 100;
        public static bool formStickTop = false;
        public static bool formShowBorder = true;
        
        private static void initClockForm()
        {
            if (formClock==null||formClock.IsDisposed) { try { formClock = new FormShow(); } catch {} }
        }

        public static bool toggleFormShow()
        {
            initClockForm();
            if (Global.clockFormState)
            {
                Global.formClock.Hide();
                Global.clockFormState = false;
                return false;
            }
            else
            {
                Global.formClock.Show();
                Global.clockFormState = true;
                return true;
            }
        }
        public static void setFormStyle(string style)
        {
            initClockForm();
            formStyle = style;
            //实际更新窗口风格
            formClock.setFormStyle(style);
        }

        public static void setFormOpacity(int val)
        {
            initClockForm();
            formOpacity = val;
            formClock.setOpacity(val);
        }

        public static void setFormStickTop(bool pined)
        {
            initClockForm();
            formStickTop = pined;
            formClock.TopMost = formStickTop;
        }

        public static void setFormBorder(bool border)
        {
            initClockForm();
            formShowBorder = border;
            formClock.FormBorderStyle = (border ? FormBorderStyle.FixedDialog : FormBorderStyle.None);
        }

    }
}
