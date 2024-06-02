namespace kyrsovaya
{
    partial class basketball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basketball));
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            повернутисяНаГоловнуToolStripMenuItem = new ToolStripMenuItem();
            закритиПрограмуToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            listView1 = new ListView();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(597, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { повернутисяНаГоловнуToolStripMenuItem, закритиПрограмуToolStripMenuItem });
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
            // закритиПрограмуToolStripMenuItem
            // 
            закритиПрограмуToolStripMenuItem.Name = "закритиПрограмуToolStripMenuItem";
            закритиПрограмуToolStripMenuItem.Size = new Size(210, 22);
            закритиПрограмуToolStripMenuItem.Text = "Закрити програму";
            закритиПрограмуToolStripMenuItem.Click += закритиПрограмуToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 471);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(597, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(49, 17);
            toolStripStatusLabel1.Text = "Статус: ";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Баскетбол";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(12, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 180);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 344);
            label3.Name = "label3";
            label3.Size = new Size(235, 15);
            label3.TabIndex = 5;
            label3.Text = "Актуальний баскетбольний рекордсмен: ";
            // 
            // listView1
            // 
            listView1.Location = new Point(156, 372);
            listView1.Name = "listView1";
            listView1.Size = new Size(259, 42);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 254);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 52);
            textBox1.TabIndex = 7;
            textBox1.Text = "Баскетбол — це командний вид спорту, де дві команди з 5 гравців намагаються закинути м'яч у кільце суперника. Гра триває 48 хвилин в НБА або 40 хвилин в інших лігах, розділених на чотири чверті.";
            // 
            // basketball
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 493);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "basketball";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basketball";
            FormClosing += basketball_FormClosing;
            Load += Form5_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem повернутисяНаГоловнуToolStripMenuItem;
        private ToolStripMenuItem закритиПрограмуToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private ListView listView1;
        private TextBox textBox1;
    }
}