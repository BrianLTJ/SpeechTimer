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
    }

    public class Global
    {
        int NowStageID = 0;
        int NextStageID = 0;
        int NowTime;

        //Project Info
        string Project_Title = "新方案";
        string Project_End = "BackToFirst";
        string ShowType = "FixedClock3";


    }
}
