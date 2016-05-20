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
    public partial class FormShow : Form
    {
        public FormShow()
        {
            InitializeComponent();
        }

        private void FormShow_Load(object sender, EventArgs e)
        {

        }

        public void setFormStyle(string style)
        {
            switch (style)
            {
                case "black":
                    this.BackColor = Color.FromArgb(70,70,70);
                    labelMainTitle.ForeColor = Color.White;
                    labelStage.ForeColor = Color.White;
                    labelTime.ForeColor = Color.White;
                    break;
                default:
                    this.BackColor = Color.White;
                    labelMainTitle.ForeColor = Color.Black;
                    labelStage.ForeColor = Color.Black;
                    labelTime.ForeColor = Color.Black;
                    break;
            }
        }

        public void setOpacity(int val=100)
        {
            this.Opacity = val / 100.0;
        }

        public void setTitle(string title)
        {
            labelMainTitle.Text = title;
        }
        public void setStage(string stage)
        {
            labelStage.Text = stage;
        }
        public void setTime(string time)
        {
            labelTime.Text = time;
        }
    }
}
