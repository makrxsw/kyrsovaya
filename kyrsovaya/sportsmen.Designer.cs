namespace kyrsovaya
{
    partial class sportsmen
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            listView1 = new ListView();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            повернутисяНаГоловнуToolStripMenuItem = new ToolStripMenuItem();
            зберегтиФайлToolStripMenuItem = new ToolStripMenuItem();
            створитиНовуБазуДанихToolStripMenuItem = new ToolStripMenuItem();
            видалитиФайлToolStripMenuItem = new ToolStripMenuItem();
            закритиПрограмуToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 429);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(46, 17);
            toolStripStatusLabel1.Text = "Статус:";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 137);
            listView1.Name = "listView1";
            listView1.Size = new Size(560, 268);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 36);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 2;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(105, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(467, 23);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 19);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 4;
            label1.Text = "Введіть ім'я спортсмена";
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
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { повернутисяНаГоловнуToolStripMenuItem, зберегтиФайлToolStripMenuItem, створитиНовуБазуДанихToolStripMenuItem, видалитиФайлToolStripMenuItem, закритиПрограмуToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // повернутисяНаГоловнуToolStripMenuItem
            // 
            повернутисяНаГоловнуToolStripMenuItem.Name = "повернутисяНаГоловнуToolStripMenuItem";
            повернутисяНаГоловнуToolStripMenuItem.Size = new Size(217, 22);
            повернутисяНаГоловнуToolStripMenuItem.Text = "Повернутися на головну ";
            повернутисяНаГоловнуToolStripMenuItem.Click += повернутисяНаГоловнуToolStripMenuItem_Click;
            // 
            // зберегтиФайлToolStripMenuItem
            // 
            зберегтиФайлToolStripMenuItem.Name = "зберегтиФайлToolStripMenuItem";
            зберегтиФайлToolStripMenuItem.Size = new Size(217, 22);
            зберегтиФайлToolStripMenuItem.Text = "Зберегти файл";
            зберегтиФайлToolStripMenuItem.Click += зберегтиФайлToolStripMenuItem_Click;
            // 
            // створитиНовуБазуДанихToolStripMenuItem
            // 
            створитиНовуБазуДанихToolStripMenuItem.Name = "створитиНовуБазуДанихToolStripMenuItem";
            створитиНовуБазуДанихToolStripMenuItem.Size = new Size(217, 22);
            створитиНовуБазуДанихToolStripMenuItem.Text = "Створити нову базу даних";
            створитиНовуБазуДанихToolStripMenuItem.Click += створитиНовуБазуДанихToolStripMenuItem_Click;
            // 
            // видалитиФайлToolStripMenuItem
            // 
            видалитиФайлToolStripMenuItem.Name = "видалитиФайлToolStripMenuItem";
            видалитиФайлToolStripMenuItem.Size = new Size(217, 22);
            видалитиФайлToolStripMenuItem.Text = "Видалити файл ";
            видалитиФайлToolStripMenuItem.Click += видалитиФайлToolStripMenuItem_Click;
            // 
            // закритиПрограмуToolStripMenuItem
            // 
            закритиПрограмуToolStripMenuItem.Name = "закритиПрограмуToolStripMenuItem";
            закритиПрограмуToolStripMenuItem.Size = new Size(217, 22);
            закритиПрограмуToolStripMenuItem.Text = "Закрити програму";
            закритиПрограмуToolStripMenuItem.Click += закритиПрограмуToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 79);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 6;
            label2.Text = "Додай свого спортсмена:";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 79);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 7;
            button2.Text = "Додати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(242, 98);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(330, 23);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(105, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 108);
            button3.Name = "button3";
            button3.Size = new Size(87, 23);
            button3.TabIndex = 10;
            button3.Text = "Видалити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // sportsmen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 451);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "sportsmen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sportmen";
            FormClosing += sportsmen_FormClosing;
            Load += Form3_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ListView listView1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem повернутисяНаГоловнуToolStripMenuItem;
        private ToolStripMenuItem зберегтиФайлToolStripMenuItem;
        private ToolStripMenuItem видалитиФайлToolStripMenuItem;
        private ToolStripMenuItem закритиПрограмуToolStripMenuItem;
        private Label label2;
        private Button button2;
        private RichTextBox richTextBox2;
        private ComboBox comboBox1;
        private ToolStripMenuItem створитиНовуБазуДанихToolStripMenuItem;
        private Button button3;
    }
}