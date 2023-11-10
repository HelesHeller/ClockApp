namespace ClockApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            labelTime = new Label();
            radioButton24h = new RadioButton();
            radioButton12h = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(271, 87);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(38, 15);
            labelTime.TabIndex = 0;
            labelTime.Text = "label1";
            // 
            // radioButton24h
            // 
            radioButton24h.AutoSize = true;
            radioButton24h.Location = new Point(44, 62);
            radioButton24h.Name = "radioButton24h";
            radioButton24h.Size = new Size(44, 19);
            radioButton24h.TabIndex = 1;
            radioButton24h.TabStop = true;
            radioButton24h.Text = "24h";
            radioButton24h.UseVisualStyleBackColor = true;
            // 
            // radioButton12h
            // 
            radioButton12h.AutoSize = true;
            radioButton12h.Location = new Point(44, 87);
            radioButton12h.Name = "radioButton12h";
            radioButton12h.Size = new Size(44, 19);
            radioButton12h.TabIndex = 2;
            radioButton12h.TabStop = true;
            radioButton12h.Text = "12h";
            radioButton12h.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 242);
            Controls.Add(radioButton12h);
            Controls.Add(radioButton24h);
            Controls.Add(labelTime);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTime;
        private RadioButton radioButton24h;
        private RadioButton radioButton12h;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}