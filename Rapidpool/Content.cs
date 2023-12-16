namespace Rapidpool
{
    public partial class Content : UserControl
    {
        public string Text { get; }
        public long Timestamp { get; set; }
        public Content(string content)
        {
            InitializeComponent();
            label.Text = content;
            this.Text = content;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            var currentText = Clipboard.GetText();
            if (currentText != Text)
                Clipboard.SetText(Text);
        }
    }
}
