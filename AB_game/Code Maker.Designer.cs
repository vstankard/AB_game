namespace AB_game
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
            lblNum = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            lblHint = new Label();
            label1 = new Label();
            label2 = new Label();
            btnNum = new Button();
            chkBox = new CheckBox();
            lblCensor = new Label();
            SuspendLayout();
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNum.Location = new Point(65, 144);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(66, 30);
            lblNum.TabIndex = 1;
            lblNum.Text = "label1";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(220, 146);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(100, 23);
            txtGuess.TabIndex = 2;
            txtGuess.TextChanged += txtGuess_TextChanged;
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.MidnightBlue;
            btnGuess.Enabled = false;
            btnGuess.FlatAppearance.BorderSize = 0;
            btnGuess.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuess.ForeColor = SystemColors.Control;
            btnGuess.Location = new Point(209, 187);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(123, 30);
            btnGuess.TabIndex = 3;
            btnGuess.Text = "Enter Guess";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += btnGuess_Click;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI Semibold", 20.75F, FontStyle.Bold);
            lblHint.Location = new Point(234, 95);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(71, 38);
            lblHint.TabIndex = 4;
            lblHint.Text = "Hint";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 19);
            label1.Name = "label1";
            label1.Size = new Size(202, 45);
            label1.TabIndex = 5;
            label1.Text = "Code Maker";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.75F, FontStyle.Bold);
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(169, 38);
            label2.TabIndex = 6;
            label2.Text = "Secret Code";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNum
            // 
            btnNum.BackColor = Color.MidnightBlue;
            btnNum.FlatAppearance.BorderSize = 0;
            btnNum.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNum.ForeColor = SystemColors.Control;
            btnNum.Location = new Point(39, 187);
            btnNum.Name = "btnNum";
            btnNum.Size = new Size(123, 30);
            btnNum.TabIndex = 7;
            btnNum.Text = "Generate Code";
            btnNum.UseVisualStyleBackColor = false;
            btnNum.Click += btnNum_Click;
            // 
            // chkBox
            // 
            chkBox.AutoSize = true;
            chkBox.Location = new Point(93, 239);
            chkBox.Name = "chkBox";
            chkBox.Size = new Size(173, 19);
            chkBox.TabIndex = 8;
            chkBox.Text = "Playing with filthy cheaters?";
            chkBox.UseVisualStyleBackColor = true;
            chkBox.CheckedChanged += chkBox_CheckedChanged;
            // 
            // lblCensor
            // 
            lblCensor.AutoSize = true;
            lblCensor.BackColor = Color.Black;
            lblCensor.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCensor.ForeColor = SystemColors.Control;
            lblCensor.Location = new Point(50, 148);
            lblCensor.Name = "lblCensor";
            lblCensor.Size = new Size(98, 26);
            lblCensor.TabIndex = 9;
            lblCensor.Text = "CENSORED";
            lblCensor.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 278);
            Controls.Add(lblCensor);
            Controls.Add(chkBox);
            Controls.Add(btnNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHint);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblNum);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNum;
        private TextBox txtGuess;
        private Button btnGuess;
        private Label lblHint;
        private Label label1;
        private Label label2;
        private Button btnNum;
        private CheckBox chkBox;
        private Label lblCensor;
    }
}
