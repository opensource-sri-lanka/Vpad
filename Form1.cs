using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace vPad
{
    public partial class Form1 : Form
    {

        private string CounterType = "char";
        private TimeLableModes TimeMode = TimeLableModes._12Hour;
        private LableModes LableMode = LableModes.CurrentTime;
        private bool RichPresenseStatus = false;
        private DiscordRPC.DiscordRpcClient client;
        private string CurrentFileName = "";


        public Form1()
        {
            InitializeComponent();
            StartTimelable();


            client = new DiscordRPC.DiscordRpcClient("798143914951180288");
            client.Logger = new DiscordRPC.Logging.ConsoleLogger() { Level = DiscordRPC.Logging.LogLevel.Warning };
            client.Initialize();
        }


        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.Clear();
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textbox.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                CurrentFileName = openFileDialog1.FileName;
                SetRichPresense(Path.GetFileName(CurrentFileName));
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textbox.Text);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutVPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: add more info about vpad
        }

        private void FontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oldSize = textbox.Font.Size;
            var font = textbox.Font.FontFamily;
            var fontStyle = textbox.Font.Style;

            textbox.Font = new Font(font, oldSize + 5, fontStyle);
        }




        // font controls
        private void Font_up_button_MouseDown(object sender, MouseEventArgs e)
        {
            var oldSize = textbox.Font.Size;
            ChangeEditorFontSize((int)oldSize + 2);
        }

        private void Font_down_button_MouseDown(object sender, MouseEventArgs e)
        {
            var oldSize = textbox.Font.Size;
            if (oldSize - 2 > 0)
            {
                ChangeEditorFontSize((int)oldSize - 2);
            }
        }


        // time display
        private void Time_label_Click(object sender, EventArgs e)
        {
            if (TimeMode == TimeLableModes._12Hour)
            {
                TimeMode = TimeLableModes._24Hour;
            }
            else if (TimeMode == TimeLableModes._24Hour)
            {
                TimeMode = TimeLableModes.none;
            }
            else
            {
                TimeMode = TimeLableModes._12Hour;
            }
            SetCurrentTime(TimeMode);            
        }

        private void Time_label_DoubleClick(object sender, EventArgs e)
        {
            ChangeLableMode();
        }

        private void DiscordIntegrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichPresenseStatus = !RichPresenseStatus;
            Console.WriteLine("richpresense status: " + RichPresenseStatus.ToString());
            if (RichPresenseStatus == true)
            {
                client.UpdateStartTime(DateTime.Now);
                if (CurrentFileName == "")
                {
                    SetRichPresense("a new file");
                }
                else
                {
                    SetRichPresense(Path.GetFileName(CurrentFileName));
                }
            } else
            {
                Console.WriteLine("rich presense removed");
                client.ClearPresence();
            }

        }
    }
}
