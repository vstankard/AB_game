namespace AB_game
{
    partial class Welcome
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMaker = new Button();
            btnBreaker = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 22);
            label1.Name = "label1";
            label1.Size = new Size(159, 45);
            label1.TabIndex = 0;
            label1.Text = "AB Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 72);
            label2.Name = "label2";
            label2.Size = new Size(342, 30);
            label2.TabIndex = 1;
            label2.Text = "Welcome to Team #1's Code Game!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 121);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 2;
            label3.Text = "Choose A Mode:";
            // 
            // btnMaker
            // 
            btnMaker.BackColor = SystemColors.ActiveCaption;
            btnMaker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaker.Location = new Point(59, 160);
            btnMaker.Name = "btnMaker";
            btnMaker.Size = new Size(128, 37);
            btnMaker.TabIndex = 3;
            btnMaker.Text = "Code Maker";
            btnMaker.UseVisualStyleBackColor = false;
            btnMaker.Click += btnMaker_Click;
            // 
            // btnBreaker
            // 
            btnBreaker.BackColor = Color.IndianRed;
            btnBreaker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBreaker.Location = new Point(245, 160);
            btnBreaker.Name = "btnBreaker";
            btnBreaker.Size = new Size(128, 37);
            btnBreaker.TabIndex = 4;
            btnBreaker.Text = "Code Breaker";
            btnBreaker.UseVisualStyleBackColor = false;
            btnBreaker.Click += btnBreaker_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 224);
            label4.Name = "label4";
            label4.Size = new Size(334, 15);
            label4.TabIndex = 5;
            label4.Text = "Developed By: Vincent Stankard, Luis Nava, Mohammed Mota";
            label4.Click += label4_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 248);
            Controls.Add(label4);
            Controls.Add(btnBreaker);
            Controls.Add(btnMaker);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnMaker;
        private Button btnBreaker;
        private Label label4;
    }
}