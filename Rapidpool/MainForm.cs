using System.Net.NetworkInformation;
using WK.Libraries.HotkeyListenerNS;

namespace Rapidpool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var screenSize = Screen.GetWorkingArea(this).Size;
            Location = new Point(screenSize.Width - Width, 0);
            Height = screenSize.Height;

            var listener = new HotkeyListener();
            listener.Add(new Hotkey(Keys.Control | Keys.Shift | Keys.Alt, Keys.A));
            listener.HotkeyPressed += (sender, e) => 
            {
                this.WindowState = FormWindowState.Minimized;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            };

            LoadContent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                AddContent(textBox.Text);
                textBox.Text = string.Empty;
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            textBox.Focus();
        }

        Content AddContent(string content, bool save = true)
        {
            var control = new Content(content);
            control.buttonRemove.Click += (sender, args) => { Task.Run(() => DeleteContent(control.Timestamp)); flowLayoutPanel.Controls.Remove(control); control.Dispose(); };
            flowLayoutPanel.Controls.Add(control);
            flowLayoutPanel.Controls.SetChildIndex(control, 0);
            flowLayoutPanel.VerticalScroll.Value = 0;

            if (save)
                Task.Run(() => SaveContent(control));

            return control;
        }

        static async Task SaveContent(Content content)
        {
            var timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            Directory.CreateDirectory("Data");
            await File.WriteAllTextAsync(@"Data\" + timestamp + ".rpc", content.Text);
            content.Timestamp = timestamp;
        }
        static async Task DeleteContent(long timestamp)
        {
            File.Delete(@"Data\" + timestamp + ".rpc");
            await Task.CompletedTask;
        }
        void LoadContent()
        {
            if (Directory.Exists("Data"))
            {
                var files = Directory.GetFiles("Data");
                foreach (var file in files.Reverse())
                    AddContent(File.ReadAllText(file), false).Timestamp = long.Parse(Path.GetFileNameWithoutExtension(file));
            }
        }
    }
}