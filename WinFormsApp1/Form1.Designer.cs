namespace WinFormsApp1
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
            btnYellow = new Button();
            btnBlue = new Button();
            btnRed = new Button();
            SuspendLayout();
            // 
            // btnYellow
            // 
            btnYellow.Location = new Point(179, 193);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(94, 29);
            btnYellow.TabIndex = 0;
            btnYellow.Text = "Yellow";
            btnYellow.UseVisualStyleBackColor = true;
            // 
            // btnBlue
            // 
            btnBlue.Location = new Point(310, 193);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(94, 29);
            btnBlue.TabIndex = 1;
            btnBlue.Text = "Blue";
            btnBlue.UseVisualStyleBackColor = true;
            // 
            // btnRed
            // 
            btnRed.Location = new Point(440, 193);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(94, 29);
            btnRed.TabIndex = 2;
            btnRed.Text = "Red";
            btnRed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRed);
            Controls.Add(btnBlue);
            Controls.Add(btnYellow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYellow;
        private Button btnBlue;
        private Button btnRed;
    }
}