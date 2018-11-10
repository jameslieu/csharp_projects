namespace TicTacToe
{
    partial class GameForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.PlayerOneWinCountLabel = new System.Windows.Forms.Label();
            this.drawCountLabel = new System.Windows.Forms.Label();
            this.PlayerTwoWinCountLabel = new System.Windows.Forms.Label();
            this.PlayerTwoWinCount = new System.Windows.Forms.Label();
            this.DrawCount = new System.Windows.Forms.Label();
            this.PlayerOneWinCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(265, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetWinCountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetWinCountToolStripMenuItem
            // 
            this.resetWinCountToolStripMenuItem.Name = "resetWinCountToolStripMenuItem";
            this.resetWinCountToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetWinCountToolStripMenuItem.Text = "Reset Win Count";
            this.resetWinCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.A1.Location = new System.Drawing.Point(14, 36);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 2;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            this.A1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.A1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.A2.Location = new System.Drawing.Point(95, 36);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 3;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            this.A2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.A2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.A3.Location = new System.Drawing.Point(176, 36);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 4;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            this.A3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.A3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.B1.Location = new System.Drawing.Point(14, 117);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            this.B1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.B1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.B2.Location = new System.Drawing.Point(95, 117);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 6;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            this.B2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.B2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.B3.Location = new System.Drawing.Point(176, 117);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 7;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            this.B3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.B3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.C2.Location = new System.Drawing.Point(95, 198);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            this.C2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.C2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.C3.Location = new System.Drawing.Point(176, 198);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            this.C3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.C3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.C1.Location = new System.Drawing.Point(14, 198);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 10;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            this.C1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.C1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // PlayerOneWinCountLabel
            // 
            this.PlayerOneWinCountLabel.AutoSize = true;
            this.PlayerOneWinCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneWinCountLabel.Location = new System.Drawing.Point(15, 282);
            this.PlayerOneWinCountLabel.MaximumSize = new System.Drawing.Size(78, 13);
            this.PlayerOneWinCountLabel.MinimumSize = new System.Drawing.Size(78, 13);
            this.PlayerOneWinCountLabel.Name = "PlayerOneWinCountLabel";
            this.PlayerOneWinCountLabel.Size = new System.Drawing.Size(78, 13);
            this.PlayerOneWinCountLabel.TabIndex = 11;
            this.PlayerOneWinCountLabel.Text = "X Win Count";
            this.PlayerOneWinCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawCountLabel
            // 
            this.drawCountLabel.AutoSize = true;
            this.drawCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawCountLabel.Location = new System.Drawing.Point(96, 282);
            this.drawCountLabel.MaximumSize = new System.Drawing.Size(78, 13);
            this.drawCountLabel.MinimumSize = new System.Drawing.Size(78, 13);
            this.drawCountLabel.Name = "drawCountLabel";
            this.drawCountLabel.Size = new System.Drawing.Size(78, 13);
            this.drawCountLabel.TabIndex = 12;
            this.drawCountLabel.Text = "Draw Count";
            this.drawCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerTwoWinCountLabel
            // 
            this.PlayerTwoWinCountLabel.AutoSize = true;
            this.PlayerTwoWinCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoWinCountLabel.Location = new System.Drawing.Point(174, 282);
            this.PlayerTwoWinCountLabel.MaximumSize = new System.Drawing.Size(79, 13);
            this.PlayerTwoWinCountLabel.MinimumSize = new System.Drawing.Size(79, 13);
            this.PlayerTwoWinCountLabel.Name = "PlayerTwoWinCountLabel";
            this.PlayerTwoWinCountLabel.Size = new System.Drawing.Size(79, 13);
            this.PlayerTwoWinCountLabel.TabIndex = 13;
            this.PlayerTwoWinCountLabel.Text = "O Win Count";
            this.PlayerTwoWinCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerTwoWinCount
            // 
            this.PlayerTwoWinCount.AutoSize = true;
            this.PlayerTwoWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoWinCount.Location = new System.Drawing.Point(204, 301);
            this.PlayerTwoWinCount.Name = "PlayerTwoWinCount";
            this.PlayerTwoWinCount.Size = new System.Drawing.Size(14, 13);
            this.PlayerTwoWinCount.TabIndex = 16;
            this.PlayerTwoWinCount.Text = "0";
            // 
            // DrawCount
            // 
            this.DrawCount.AutoSize = true;
            this.DrawCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawCount.Location = new System.Drawing.Point(124, 301);
            this.DrawCount.Name = "DrawCount";
            this.DrawCount.Size = new System.Drawing.Size(14, 13);
            this.DrawCount.TabIndex = 15;
            this.DrawCount.Text = "0";
            // 
            // PlayerOneWinCount
            // 
            this.PlayerOneWinCount.AutoSize = true;
            this.PlayerOneWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneWinCount.Location = new System.Drawing.Point(45, 301);
            this.PlayerOneWinCount.Name = "PlayerOneWinCount";
            this.PlayerOneWinCount.Size = new System.Drawing.Size(14, 13);
            this.PlayerOneWinCount.TabIndex = 14;
            this.PlayerOneWinCount.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 334);
            this.Controls.Add(this.PlayerTwoWinCount);
            this.Controls.Add(this.DrawCount);
            this.Controls.Add(this.PlayerOneWinCount);
            this.Controls.Add(this.PlayerTwoWinCountLabel);
            this.Controls.Add(this.drawCountLabel);
            this.Controls.Add(this.PlayerOneWinCountLabel);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Label PlayerOneWinCountLabel;
        private System.Windows.Forms.Label drawCountLabel;
        private System.Windows.Forms.Label PlayerTwoWinCountLabel;
        private System.Windows.Forms.Label PlayerTwoWinCount;
        private System.Windows.Forms.Label DrawCount;
        private System.Windows.Forms.Label PlayerOneWinCount;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountToolStripMenuItem;
    }
}

