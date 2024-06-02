namespace kyrsovaya
{
    partial class football
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(football));
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            listView1 = new ListView();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            повернутисяНаГоловнуToolStripMenuItem = new ToolStripMenuItem();
            вийтиЗПрограмиToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 22);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Футбол";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 185);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 355);
            label3.Name = "label3";
            label3.Size = new Size(216, 15);
            label3.TabIndex = 3;
            label3.Text = "Актуальний футбольний рекордсмен:";
            // 
            // listView1
            // 
            listView1.Location = new Point(149, 373);
            listView1.Name = "listView1";
            listView1.Size = new Size(259, 42);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { повернутисяНаГоловнуToolStripMenuItem, вийтиЗПрограмиToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // повернутисяНаГоловнуToolStripMenuItem
            // 
            повернутисяНаГоловнуToolStripMenuItem.Name = "повернутисяНаГоловнуToolStripMenuItem";
            повернутисяНаГоловнуToolStripMenuItem.Size = new Size(210, 22);
            повернутисяНаГоловнуToolStripMenuItem.Text = "Повернутися на головну";
            повернутисяНаГоловнуToolStripMenuItem.Click += повернутисяНаГоловнуToolStripMenuItem_Click;
            // 
            // вийтиЗПрограмиToolStripMenuItem
            // 
            вийтиЗПрограмиToolStripMenuItem.Name = "вийтиЗПрограмиToolStripMenuItem";
            вийтиЗПрограмиToolStripMenuItem.Size = new Size(210, 22);
            вийтиЗПрограмиToolStripMenuItem.Text = "Закрити програму";
            вийтиЗПрограмиToolStripMenuItem.Click += вийтиЗПрограмиToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 429);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(52, 17);
            toolStripStatusLabel1.Text = " Статус: ";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 237);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 56);
            textBox1.TabIndex = 7;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // football
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 451);
            Controls.Add(textBox1);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "football";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Football";
            FormClosing += football_FormClosing;
            Load += Form4_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private ListView listView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem повернутисяНаГоловнуToolStripMenuItem;
        private ToolStripMenuItem вийтиЗПрограмиToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private TextBox textBox1;
    }
}