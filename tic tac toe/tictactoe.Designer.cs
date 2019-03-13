namespace tic_tac_toe
{
    partial class tictactoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tictactoe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(222, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.setDefaultToolStripMenuItem,
            this.resetWinCountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // setDefaultToolStripMenuItem
            // 
            this.setDefaultToolStripMenuItem.Name = "setDefaultToolStripMenuItem";
            this.setDefaultToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.setDefaultToolStripMenuItem.Text = "Set Player Default";
            this.setDefaultToolStripMenuItem.Click += new System.EventHandler(this.setDefaultToolStripMenuItem_Click);
            // 
            // resetWinCountToolStripMenuItem
            // 
            this.resetWinCountToolStripMenuItem.Name = "resetWinCountToolStripMenuItem";
            this.resetWinCountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetWinCountToolStripMenuItem.ShowShortcutKeys = false;
            this.resetWinCountToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.resetWinCountToolStripMenuItem.Text = "Reset Win Count";
            this.resetWinCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.aboutToolStripMenuItem.Text = "Creadit*";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.SystemColors.Control;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(12, 41);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(60, 63);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = false;
            this.a1.Click += new System.EventHandler(this.button_click);
            this.a1.MouseEnter += new System.EventHandler(this.button_enter);
            this.a1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.SystemColors.Control;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(78, 41);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(60, 63);
            this.a2.TabIndex = 1;
            this.a2.UseVisualStyleBackColor = false;
            this.a2.Click += new System.EventHandler(this.button_click);
            this.a2.MouseEnter += new System.EventHandler(this.button_enter);
            this.a2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.SystemColors.Control;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(144, 41);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(60, 63);
            this.a3.TabIndex = 1;
            this.a3.UseVisualStyleBackColor = false;
            this.a3.Click += new System.EventHandler(this.button_click);
            this.a3.MouseEnter += new System.EventHandler(this.button_enter);
            this.a3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Control;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(12, 110);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(60, 63);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button_click);
            this.b1.MouseEnter += new System.EventHandler(this.button_enter);
            this.b1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.Control;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(78, 110);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(60, 63);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.button_click);
            this.b2.MouseEnter += new System.EventHandler(this.button_enter);
            this.b2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.Control;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(144, 110);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(60, 63);
            this.b3.TabIndex = 1;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.button_click);
            this.b3.MouseEnter += new System.EventHandler(this.button_enter);
            this.b3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.SystemColors.Control;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(12, 179);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(60, 63);
            this.c1.TabIndex = 1;
            this.c1.UseVisualStyleBackColor = false;
            this.c1.Click += new System.EventHandler(this.button_click);
            this.c1.MouseEnter += new System.EventHandler(this.button_enter);
            this.c1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.SystemColors.Control;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(78, 179);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(60, 63);
            this.c2.TabIndex = 1;
            this.c2.UseVisualStyleBackColor = false;
            this.c2.Click += new System.EventHandler(this.button_click);
            this.c2.MouseEnter += new System.EventHandler(this.button_enter);
            this.c2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.SystemColors.Control;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(144, 179);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(60, 63);
            this.c3.TabIndex = 1;
            this.c3.UseVisualStyleBackColor = false;
            this.c3.Click += new System.EventHandler(this.button_click);
            this.c3.MouseEnter += new System.EventHandler(this.button_enter);
            this.c3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(12, 261);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(62, 20);
            this.p1.TabIndex = 2;
            this.p1.Text = "Player 1";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(141, 261);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(62, 20);
            this.p2.TabIndex = 2;
            this.p2.Text = "Player 2";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2.TextChanged += new System.EventHandler(this.p2_textchanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Draw Count";
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Location = new System.Drawing.Point(27, 287);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(13, 13);
            this.x_win_count.TabIndex = 4;
            this.x_win_count.Text = "0";
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Location = new System.Drawing.Point(99, 287);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(13, 13);
            this.draw_count.TabIndex = 5;
            this.draw_count.Text = "0";
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Location = new System.Drawing.Point(171, 287);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(13, 13);
            this.o_win_count.TabIndex = 5;
            this.o_win_count.Text = "0";
            // 
            // tictactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(222, 309);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "tictactoe";
            this.Opacity = 0.95D;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.tictactoe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label draw_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultToolStripMenuItem;
    }
}

