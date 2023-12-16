namespace Rapidpool
{
    partial class Content
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Content));
            label = new Label();
            buttonCopy = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoEllipsis = true;
            label.Location = new Point(-1, 0);
            label.Name = "label";
            label.Size = new Size(341, 66);
            label.TabIndex = 0;
            label.Text = resources.GetString("label.Text");
            // 
            // buttonCopy
            // 
            buttonCopy.BackColor = Color.DarkGray;
            buttonCopy.FlatAppearance.BorderColor = Color.DarkGray;
            buttonCopy.FlatStyle = FlatStyle.Flat;
            buttonCopy.ForeColor = Color.FromArgb(224, 224, 224);
            buttonCopy.Location = new Point(342, 40);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(23, 23);
            buttonCopy.TabIndex = 2;
            buttonCopy.Text = "█";
            buttonCopy.UseVisualStyleBackColor = false;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.DarkGray;
            buttonRemove.FlatAppearance.BorderColor = Color.DarkGray;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(342, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(23, 23);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "×";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // Content
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonRemove);
            Controls.Add(buttonCopy);
            Controls.Add(label);
            Margin = new Padding(0);
            Name = "Content";
            Size = new Size(365, 66);
            ResumeLayout(false);
        }

        #endregion

        private Label label;
        private Button buttonCopy;
        public Button buttonRemove;
    }
}
