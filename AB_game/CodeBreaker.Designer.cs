namespace AB_game
{
    partial class CodeBreaker
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
            btnHint = new Button();
            txtHintA = new TextBox();
            lblGuess = new Label();
            btnBegin = new Button();
            lblFirstGuess = new Label();
            txtHintB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnHint
            // 
            btnHint.BackColor = Color.MidnightBlue;
            btnHint.Enabled = false;
            btnHint.FlatAppearance.BorderSize = 0;
            btnHint.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHint.ForeColor = SystemColors.Control;
            btnHint.Location = new Point(235, 180);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(132, 30);
            btnHint.TabIndex = 17;
            btnHint.Text = "Enter Given Hint";
            btnHint.UseVisualStyleBackColor = false;
            btnHint.Click += btnHint_Click;
            // 
            // txtHintA
            // 
            txtHintA.Font = new Font("Segoe UI", 11F);
            txtHintA.Location = new Point(240, 139);
            txtHintA.Name = "txtHintA";
            txtHintA.Size = new Size(45, 27);
            txtHintA.TabIndex = 15;
            txtHintA.TextChanged += txtHint_TextChanged;
            // 
            // lblGuess
            // 
            lblGuess.AutoSize = true;
            lblGuess.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuess.Location = new Point(255, 86);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(90, 37);
            lblGuess.TabIndex = 6;
            lblGuess.Text = "Guess";
            lblGuess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBegin
            // 
            btnBegin.BackColor = Color.MidnightBlue;
            btnBegin.FlatAppearance.BorderSize = 0;
            btnBegin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBegin.ForeColor = SystemColors.Control;
            btnBegin.Location = new Point(42, 139);
            btnBegin.Name = "btnBegin";
            btnBegin.Size = new Size(123, 30);
            btnBegin.TabIndex = 7;
            btnBegin.Text = "Begin";
            btnBegin.UseVisualStyleBackColor = false;
            btnBegin.Click += button1_Click;
            // 
            // lblFirstGuess
            // 
            lblFirstGuess.AutoSize = true;
            lblFirstGuess.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstGuess.Location = new Point(53, 86);
            lblFirstGuess.Name = "lblFirstGuess";
            lblFirstGuess.Size = new Size(93, 37);
            lblFirstGuess.TabIndex = 8;
            lblFirstGuess.Text = "First #";
            lblFirstGuess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHintB
            // 
            txtHintB.Font = new Font("Segoe UI", 11F);
            txtHintB.Location = new Point(327, 139);
            txtHintB.Name = "txtHintB";
            txtHintB.Size = new Size(48, 27);
            txtHintB.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 139);
            label1.Name = "label1";
            label1.Size = new Size(27, 30);
            label1.TabIndex = 10;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 136);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 11;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 22);
            label3.Name = "label3";
            label3.Size = new Size(222, 45);
            label3.TabIndex = 18;
            label3.Text = "Code Breaker";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CodeBreaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 233);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHintB);
            Controls.Add(lblFirstGuess);
            Controls.Add(btnBegin);
            Controls.Add(lblGuess);
            Controls.Add(txtHintA);
            Controls.Add(btnHint);
            Name = "CodeBreaker";
            Text = "Code Breaker";
            Load += CodeBreaker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHint;
        private TextBox txtHintA;
        private Label lblGuess;
        private Button btnBegin;
        private Label lblFirstGuess;
        private TextBox txtHintB;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}