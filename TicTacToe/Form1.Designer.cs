namespace TicTacToe
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
            errorProvider1 = new ErrorProvider(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            abuotToolStripMenuItem = new ToolStripMenuItem();
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(262, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(132, 22);
            newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(132, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abuotToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // abuotToolStripMenuItem
            // 
            abuotToolStripMenuItem.Name = "abuotToolStripMenuItem";
            abuotToolStripMenuItem.Size = new Size(107, 22);
            abuotToolStripMenuItem.Text = "About";
            abuotToolStripMenuItem.Click += abuotToolStripMenuItem_Click;
            // 
            // A1
            // 
            A1.AccessibleName = "";
            A1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            A1.Location = new Point(13, 33);
            A1.Name = "A1";
            A1.Size = new Size(75, 75);
            A1.TabIndex = 1;
            A1.UseVisualStyleBackColor = true;
            A1.Click += button_click;
            // 
            // A2
            // 
            A2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            A2.Location = new Point(94, 33);
            A2.Name = "A2";
            A2.Size = new Size(75, 75);
            A2.TabIndex = 2;
            A2.UseVisualStyleBackColor = true;
            A2.Click += button_click;
            // 
            // A3
            // 
            A3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            A3.Location = new Point(175, 33);
            A3.Name = "A3";
            A3.Size = new Size(75, 75);
            A3.TabIndex = 3;
            A3.UseVisualStyleBackColor = true;
            A3.Click += button_click;
            // 
            // B1
            // 
            B1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            B1.Location = new Point(13, 114);
            B1.Name = "B1";
            B1.Size = new Size(75, 75);
            B1.TabIndex = 4;
            B1.UseVisualStyleBackColor = true;
            B1.Click += button_click;
            // 
            // B2
            // 
            B2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            B2.Location = new Point(94, 114);
            B2.Name = "B2";
            B2.Size = new Size(75, 75);
            B2.TabIndex = 5;
            B2.UseVisualStyleBackColor = true;
            B2.Click += button_click;
            // 
            // B3
            // 
            B3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            B3.Location = new Point(175, 114);
            B3.Name = "B3";
            B3.Size = new Size(75, 75);
            B3.TabIndex = 6;
            B3.UseVisualStyleBackColor = true;
            B3.Click += button_click;
            // 
            // C1
            // 
            C1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            C1.Location = new Point(13, 195);
            C1.Name = "C1";
            C1.Size = new Size(75, 75);
            C1.TabIndex = 7;
            C1.UseVisualStyleBackColor = true;
            C1.Click += button_click;
            // 
            // C2
            // 
            C2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            C2.Location = new Point(94, 195);
            C2.Name = "C2";
            C2.Size = new Size(75, 75);
            C2.TabIndex = 8;
            C2.UseVisualStyleBackColor = true;
            C2.Click += button_click;
            // 
            // C3
            // 
            C3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            C3.Location = new Point(175, 195);
            C3.Name = "C3";
            C3.Size = new Size(75, 75);
            C3.TabIndex = 9;
            C3.UseVisualStyleBackColor = true;
            C3.Click += button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 278);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(278, 317);
            MinimumSize = new Size(278, 317);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem abuotToolStripMenuItem;
        private Button A1;
        private Button C3;
        private Button C2;
        private Button C1;
        private Button B3;
        private Button B2;
        private Button B1;
        private Button A3;
        private Button A2;
    }
}