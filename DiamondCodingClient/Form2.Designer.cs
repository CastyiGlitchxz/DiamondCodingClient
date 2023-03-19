namespace DiamondCodingClient
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pname = new TextBox();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // Pname
            // 
            Pname.Location = new Point(12, 12);
            Pname.Name = "Pname";
            Pname.PlaceholderText = "Enter a project name";
            Pname.Size = new Size(160, 27);
            Pname.TabIndex = 0;
            Pname.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 54);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 1;
            button1.Text = "Create Project";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Pname);
            Name = "Form2";
            Text = "Diamond Coding Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        public TextBox Pname;
    }
}