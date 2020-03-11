namespace tictactoe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblxSum = new System.Windows.Forms.Label();
            this.lblDrawSum = new System.Windows.Forms.Label();
            this.lbloSum = new System.Windows.Forms.Label();
            this.resetWinSumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetWinSumToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // btnA1
            // 
            this.btnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA1.Location = new System.Drawing.Point(12, 27);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(75, 75);
            this.btnA1.TabIndex = 1;
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.button_click);
            this.btnA1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btnA1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btnA2
            // 
            this.btnA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA2.Location = new System.Drawing.Point(93, 27);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(75, 75);
            this.btnA2.TabIndex = 1;
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.button_click);
            this.btnA2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btnA2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btnA3
            // 
            this.btnA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA3.Location = new System.Drawing.Point(178, 27);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(75, 75);
            this.btnA3.TabIndex = 1;
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.button_click);
            this.btnA3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btnA3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btnB1
            // 
            this.btnB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB1.Location = new System.Drawing.Point(12, 108);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(75, 75);
            this.btnB1.TabIndex = 1;
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.button_click);
            this.btnB1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btnB1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btnB2
            // 
            this.btnB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB2.Location = new System.Drawing.Point(93, 108);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(75, 75);
            this.btnB2.TabIndex = 1;
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.button_click);
            this.btnB2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btnB2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btnB3
            // 
            this.btnB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB3.Location = new System.Drawing.Point(178, 108);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(75, 75);
            this.btnB3.TabIndex = 1;
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.button_click);
            this.btnB3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btnB3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btnC1
            // 
            this.btnC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC1.Location = new System.Drawing.Point(12, 189);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(75, 75);
            this.btnC1.TabIndex = 1;
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.button_click);
            this.btnC1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btnC1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btnC2
            // 
            this.btnC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC2.Location = new System.Drawing.Point(93, 189);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(75, 75);
            this.btnC2.TabIndex = 1;
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.button_click);
            this.btnC2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btnC2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btnC3
            // 
            this.btnC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC3.Location = new System.Drawing.Point(178, 189);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(75, 75);
            this.btnC3.TabIndex = 1;
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.button_click);
            this.btnC3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btnC3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 280);
            this.label1.MaximumSize = new System.Drawing.Size(84, 16);
            this.label1.MinimumSize = new System.Drawing.Size(84, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "X win count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(91, 280);
            this.label2.MaximumSize = new System.Drawing.Size(84, 16);
            this.label2.MinimumSize = new System.Drawing.Size(84, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Draw count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(175, 280);
            this.label3.MaximumSize = new System.Drawing.Size(86, 16);
            this.label3.MinimumSize = new System.Drawing.Size(86, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "O win count";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblxSum
            // 
            this.lblxSum.AutoSize = true;
            this.lblxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblxSum.Location = new System.Drawing.Point(1, 317);
            this.lblxSum.Name = "lblxSum";
            this.lblxSum.Size = new System.Drawing.Size(16, 16);
            this.lblxSum.TabIndex = 2;
            this.lblxSum.Text = "0";
            // 
            // lblDrawSum
            // 
            this.lblDrawSum.AutoSize = true;
            this.lblDrawSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrawSum.Location = new System.Drawing.Point(91, 317);
            this.lblDrawSum.Name = "lblDrawSum";
            this.lblDrawSum.Size = new System.Drawing.Size(16, 16);
            this.lblDrawSum.TabIndex = 2;
            this.lblDrawSum.Text = "0";
            // 
            // lbloSum
            // 
            this.lbloSum.AutoSize = true;
            this.lbloSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloSum.Location = new System.Drawing.Point(192, 317);
            this.lbloSum.Name = "lbloSum";
            this.lbloSum.Size = new System.Drawing.Size(16, 16);
            this.lbloSum.TabIndex = 2;
            this.lbloSum.Text = "0";
            // 
            // resetWinSumToolStripMenuItem
            // 
            this.resetWinSumToolStripMenuItem.Name = "resetWinSumToolStripMenuItem";
            this.resetWinSumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetWinSumToolStripMenuItem.Text = "Reset Win Sum";
            this.resetWinSumToolStripMenuItem.Click += new System.EventHandler(this.resetWinSumToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbloSum);
            this.Controls.Add(this.lblDrawSum);
            this.Controls.Add(this.lblxSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblxSum;
        private System.Windows.Forms.Label lblDrawSum;
        private System.Windows.Forms.Label lbloSum;
        private System.Windows.Forms.ToolStripMenuItem resetWinSumToolStripMenuItem;
    }
}

