namespace Rapidpool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonClose = new Button();
            buttonMinimize = new Button();
            textBox = new TextBox();
            flowLayoutPanel = new FlowLayoutPanel();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(64, 64, 64);
            buttonClose.FlatAppearance.BorderColor = Color.White;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(361, 3);
            buttonClose.Margin = new Padding(0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(23, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "×";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.FromArgb(64, 64, 64);
            buttonMinimize.FlatAppearance.BorderColor = Color.White;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.ForeColor = Color.FromArgb(224, 224, 224);
            buttonMinimize.Location = new Point(335, 3);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(23, 23);
            buttonMinimize.TabIndex = 1;
            buttonMinimize.Text = "−";
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // textBox
            // 
            textBox.BackColor = Color.Silver;
            textBox.Location = new Point(2, 3);
            textBox.Margin = new Padding(0);
            textBox.Name = "textBox";
            textBox.Size = new Size(330, 23);
            textBox.TabIndex = 2;
            textBox.KeyPress += textBox_KeyPress;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 30);
            flowLayoutPanel.Margin = new Padding(0, 60, 0, 60);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(387, 796);
            flowLayoutPanel.TabIndex = 3;
            // 
            // panel
            // 
            panel.Controls.Add(flowLayoutPanel);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(0, 30, 0, 0);
            panel.Size = new Size(387, 826);
            panel.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 80, 80);
            ClientSize = new Size(387, 826);
            Controls.Add(textBox);
            Controls.Add(buttonMinimize);
            Controls.Add(buttonClose);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            Activated += MainForm_Activated;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Button buttonMinimize;
        private TextBox textBox;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel panel;
    }
}