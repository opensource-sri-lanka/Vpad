using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace vPad
{
    public partial class Form1 : Form
    {

        private enum TimeLableModes
        {
           _24Hour,
           _12Hour,
           none,
        }

        private enum LableModes
        {
            CurrentTime,
            TimeSpent,
        }

        private void StartTimelable()
        {
            SetCurrentTime(TimeMode);

            Timer t = new Timer();
            t.Interval = 1;
            void t_Tick(object si, EventArgs ei)
            {
                SetCurrentTime(TimeMode);
            }
            t.Tick += new EventHandler(t_Tick);
        }



        private void SetCurrentTime(TimeLableModes format)
        {
            if (!(format == TimeLableModes.none))
                {
                    string f;
                    if (format == TimeLableModes._12Hour)
                    {
                        f = "hh:mm tt";
                    }
                    else
                    {
                        f = "HH:mm";
                    }
                    time_label.Image = null;
                    time_label.Text = DateTime.Now.ToString(f);

                }
            else
                {
                    time_label.Text = "  ";
                    time_label.Image = Properties.Resources.baseline_schedule_white_18dp;
                }
        }

        private void ChangeEditorFontSize(int size)
        {
            var font = textbox.Font.FontFamily;
            var fontStyle = textbox.Font.Style;

            textbox.Font = new Font(font, size, fontStyle);
        }

        private void CalculateTextLength()
        {
            switch (CounterType)
            {
                case "char":
                    var textLength = textbox.TextLength;
                    CharCounter.Text = textLength.ToString() + " Char(s)";
                    break;
                case "words":
                    var wordCount = textbox.Text.ToString().Split(' ').Length;
                    CharCounter.Text = wordCount.ToString() + " word(s)";
                    break;
                case "time":
                    float readTime = textbox.Text.ToString().Split(' ').Length / 250;
                    string readTimeString;
                    if (readTime == 0)
                    {
                        readTimeString = "≤1";
                    }
                    else
                    {
                        readTimeString = readTime.ToString();
                    }


                    CharCounter.Text = readTimeString + " minute(s)";
                    break;
            }
        }

        private void CharCounter_Click(object sender, EventArgs e)
        {
            switch (CounterType)
            {
                case "char":
                    CounterType = "words";
                    break;
                case "words":
                    CounterType = "time";
                    break;
                case "time":
                    CounterType = "char";
                    break;
            }
            CalculateTextLength();
        }
        
        private void ChangeLableMode()
        {
            if (LableMode == LableModes.CurrentTime)
            {
                LableMode = LableModes.TimeSpent;
            } else
            {
                LableMode = LableModes.CurrentTime;
            }
        }

        private void SetRichPresense(string fileName)
        {
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = "Vpad - A light weight text editor for the 21st century",
                State = "Editing " + fileName,
                Assets = new DiscordRPC.Assets()
                {
                    LargeImageKey = "vpadlogo",
                    LargeImageText = "Vpad",
                },
                Timestamps = new DiscordRPC.Timestamps(DateTime.Now.ToUniversalTime()),
            });
        }
    }
}
