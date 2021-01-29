using Stopwatch.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class StopwatchForm : Form
    {
        private readonly Timer timer;
        TimeContainer timeContainer;
        public StopwatchForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timeContainer = new TimeContainer();
            timeContainer.Start();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) => ReDraw();

        void ReDraw() => timeDisplayLbl.Text = timeContainer?.ToString() ?? "00:00:00";

        private void StopwatchForm_Load(object sender, EventArgs e)
        {
            SetTooltipText(actionBtn, "Start/Stop");
            SetTooltipText(resetBtn, "Reset");
            SetTooltipText(exitBtn, "Exit app");

            FlattenButtons(actionBtn, resetBtn, exitBtn);

            var workingArea = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(workingArea.Width - Width, workingArea.Height - Height);

            void FlattenButtons(params Button[] buttons)
            {
                foreach(var button in buttons)
                {
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                    button.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }

            void SetTooltipText(Control control, string text)
            {
                new ToolTip().SetToolTip(control, text);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e) => Application.Exit();

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if(timer.Enabled)
            {
                timeContainer.Stop();
                actionBtn.BackgroundImage = Resources.play;
            }
            else
            {
                timeContainer.Start();
                actionBtn.BackgroundImage = Resources.pause;
            }
            timer.Enabled = !timer.Enabled;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timeContainer = new TimeContainer();
            if(timer.Enabled)
            {
                timeContainer.Start();
                actionBtn.BackgroundImage = Resources.pause;
            }
            else
            {
                actionBtn.BackgroundImage = Resources.play;
            }
            ReDraw();
        }


        #region move window on the screen
        //src: https://stackoverflow.com/a/4580843/3703803
        private void timeDisplayLbl_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
    }
}
