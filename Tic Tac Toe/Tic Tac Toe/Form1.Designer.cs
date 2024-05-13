namespace Tic_Tac_Toe
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.Player1_Count = new System.Windows.Forms.Label();
            this.Player2_Count = new System.Windows.Forms.Label();
            this.Draw_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Exit";
            this.label3.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Reset";
            this.label2.Click += new System.EventHandler(this.reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "New Game";
            this.label1.Click += new System.EventHandler(this.newGame_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(291, 177);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(66, 21);
            this.l3.TabIndex = 50;
            this.l3.Text = "Draw :";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(270, 96);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(87, 21);
            this.l2.TabIndex = 49;
            this.l2.Text = "Player O:";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(270, 35);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(91, 21);
            this.l1.TabIndex = 48;
            this.l1.Text = "Player X :";
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(177, 197);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(87, 82);
            this.b9.TabIndex = 47;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.Buttons);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(91, 197);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(87, 82);
            this.b8.TabIndex = 46;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.Buttons);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(5, 197);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(87, 82);
            this.b7.TabIndex = 45;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.Buttons);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(177, 116);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(87, 82);
            this.b6.TabIndex = 44;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.Buttons);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(91, 116);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(87, 82);
            this.b5.TabIndex = 43;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.Buttons);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(5, 116);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(87, 82);
            this.b4.TabIndex = 42;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.Buttons);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(177, 35);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(87, 82);
            this.b3.TabIndex = 41;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.Buttons);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(91, 35);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(87, 82);
            this.b2.TabIndex = 40;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.Buttons);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(5, 35);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(87, 82);
            this.b1.TabIndex = 39;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.Buttons);
            // 
            // Player1_Count
            // 
            this.Player1_Count.AutoSize = true;
            this.Player1_Count.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1_Count.Location = new System.Drawing.Point(375, 35);
            this.Player1_Count.Name = "Player1_Count";
            this.Player1_Count.Size = new System.Drawing.Size(21, 21);
            this.Player1_Count.TabIndex = 57;
            this.Player1_Count.Text = "0";
            // 
            // Player2_Count
            // 
            this.Player2_Count.AutoSize = true;
            this.Player2_Count.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2_Count.Location = new System.Drawing.Point(375, 96);
            this.Player2_Count.Name = "Player2_Count";
            this.Player2_Count.Size = new System.Drawing.Size(21, 21);
            this.Player2_Count.TabIndex = 58;
            this.Player2_Count.Text = "0";
            // 
            // Draw_Count
            // 
            this.Draw_Count.AutoSize = true;
            this.Draw_Count.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw_Count.Location = new System.Drawing.Point(372, 177);
            this.Draw_Count.Name = "Draw_Count";
            this.Draw_Count.Size = new System.Drawing.Size(21, 21);
            this.Draw_Count.TabIndex = 59;
            this.Draw_Count.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(452, 320);
            this.Controls.Add(this.Draw_Count);
            this.Controls.Add(this.Player2_Count);
            this.Controls.Add(this.Player1_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.MaximumSize = new System.Drawing.Size(470, 367);
            this.MinimumSize = new System.Drawing.Size(470, 367);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label Player1_Count;
        private System.Windows.Forms.Label Player2_Count;
        private System.Windows.Forms.Label Draw_Count;
    }
}

