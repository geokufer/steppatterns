namespace FightGame
{
    partial class BattleField
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleField));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_block = new System.Windows.Forms.Button();
            this.button_hit2 = new System.Windows.Forms.Button();
            this.button_hit1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_healthChanged = new System.Windows.Forms.Label();
            this.label_nameChanged = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_health = new System.Windows.Forms.Label();
            this.label5_playerStrength = new System.Windows.Forms.Label();
            this.label5_playerSTR = new System.Windows.Forms.Label();
            this.label5_playerDEF = new System.Windows.Forms.Label();
            this.label5_PlayerDefence = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5_StrBot = new System.Windows.Forms.Label();
            this.label5_botSTR = new System.Windows.Forms.Label();
            this.label5_botDEF = new System.Windows.Forms.Label();
            this.label6_botDefence = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageList_Archer = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Knight = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Halb = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Mage = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList_main = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.fileToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.newCharacterToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepToolStripMenuItem,
            this.stepsToolStripMenuItem,
            this.stepsToolStripMenuItem1,
            this.stepsToolStripMenuItem2});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveToolStripMenuItem.Text = "Sorry, I want get back";
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.stepToolStripMenuItem.Text = "1 step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // stepsToolStripMenuItem
            // 
            this.stepsToolStripMenuItem.Name = "stepsToolStripMenuItem";
            this.stepsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.stepsToolStripMenuItem.Text = "2 steps";
            this.stepsToolStripMenuItem.Click += new System.EventHandler(this.stepsToolStripMenuItem_Click);
            // 
            // stepsToolStripMenuItem1
            // 
            this.stepsToolStripMenuItem1.Name = "stepsToolStripMenuItem1";
            this.stepsToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.stepsToolStripMenuItem1.Text = "3 steps";
            this.stepsToolStripMenuItem1.Click += new System.EventHandler(this.stepsToolStripMenuItem1_Click);
            // 
            // stepsToolStripMenuItem2
            // 
            this.stepsToolStripMenuItem2.Name = "stepsToolStripMenuItem2";
            this.stepsToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.stepsToolStripMenuItem2.Text = "4 steps";
            this.stepsToolStripMenuItem2.Click += new System.EventHandler(this.stepsToolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            this.instructionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.instructionToolStripMenuItem.Text = "Instruction";
            this.instructionToolStripMenuItem.Click += new System.EventHandler(this.instructionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(246, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(279, 488);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_block);
            this.panel1.Controls.Add(this.button_hit2);
            this.panel1.Controls.Add(this.button_hit1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(12, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 204);
            this.panel1.TabIndex = 4;
            // 
            // button_block
            // 
            this.button_block.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_block.Location = new System.Drawing.Point(3, 137);
            this.button_block.Name = "button_block";
            this.button_block.Size = new System.Drawing.Size(222, 61);
            this.button_block.TabIndex = 2;
            this.button_block.Text = "Block";
            this.button_block.UseVisualStyleBackColor = true;
            this.button_block.Click += new System.EventHandler(this.button_block_Click);
            // 
            // button_hit2
            // 
            this.button_hit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hit2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hit2.Location = new System.Drawing.Point(3, 70);
            this.button_hit2.Name = "button_hit2";
            this.button_hit2.Size = new System.Drawing.Size(222, 61);
            this.button_hit2.TabIndex = 1;
            this.button_hit2.Text = "  Hit 2";
            this.button_hit2.UseVisualStyleBackColor = true;
            this.button_hit2.Click += new System.EventHandler(this.button_hit2_Click);
            // 
            // button_hit1
            // 
            this.button_hit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hit1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hit1.Location = new System.Drawing.Point(3, 3);
            this.button_hit1.Name = "button_hit1";
            this.button_hit1.Size = new System.Drawing.Size(222, 61);
            this.button_hit1.TabIndex = 0;
            this.button_hit1.Text = "  Hit 1";
            this.button_hit1.UseVisualStyleBackColor = true;
            this.button_hit1.Click += new System.EventHandler(this.button_hit1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.35088F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.64912F));
            this.tableLayoutPanel1.Controls.Add(this.label_healthChanged, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_nameChanged, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_health, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5_playerStrength, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5_playerSTR, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5_playerDEF, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5_PlayerDefence, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 111);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label_healthChanged
            // 
            this.label_healthChanged.AutoSize = true;
            this.label_healthChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_healthChanged.Location = new System.Drawing.Point(95, 27);
            this.label_healthChanged.Name = "label_healthChanged";
            this.label_healthChanged.Size = new System.Drawing.Size(40, 24);
            this.label_healthChanged.TabIndex = 3;
            this.label_healthChanged.Text = "100";
            // 
            // label_nameChanged
            // 
            this.label_nameChanged.AutoSize = true;
            this.label_nameChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_nameChanged.Location = new System.Drawing.Point(95, 0);
            this.label_nameChanged.Name = "label_nameChanged";
            this.label_nameChanged.Size = new System.Drawing.Size(65, 24);
            this.label_nameChanged.TabIndex = 2;
            this.label_nameChanged.Text = "default";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(3, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(61, 24);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_health
            // 
            this.label_health.AutoSize = true;
            this.label_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_health.Location = new System.Drawing.Point(3, 27);
            this.label_health.Name = "label_health";
            this.label_health.Size = new System.Drawing.Size(64, 24);
            this.label_health.TabIndex = 1;
            this.label_health.Text = "Health";
            // 
            // label5_playerStrength
            // 
            this.label5_playerStrength.AutoSize = true;
            this.label5_playerStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5_playerStrength.Location = new System.Drawing.Point(3, 54);
            this.label5_playerStrength.Name = "label5_playerStrength";
            this.label5_playerStrength.Size = new System.Drawing.Size(80, 24);
            this.label5_playerStrength.TabIndex = 4;
            this.label5_playerStrength.Text = "Strength";
            // 
            // label5_playerSTR
            // 
            this.label5_playerSTR.AutoSize = true;
            this.label5_playerSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5_playerSTR.Location = new System.Drawing.Point(95, 54);
            this.label5_playerSTR.Name = "label5_playerSTR";
            this.label5_playerSTR.Size = new System.Drawing.Size(20, 24);
            this.label5_playerSTR.TabIndex = 6;
            this.label5_playerSTR.Text = "9";
            // 
            // label5_playerDEF
            // 
            this.label5_playerDEF.AutoSize = true;
            this.label5_playerDEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5_playerDEF.Location = new System.Drawing.Point(95, 83);
            this.label5_playerDEF.Name = "label5_playerDEF";
            this.label5_playerDEF.Size = new System.Drawing.Size(20, 24);
            this.label5_playerDEF.TabIndex = 7;
            this.label5_playerDEF.Text = "9";
            // 
            // label5_PlayerDefence
            // 
            this.label5_PlayerDefence.AutoSize = true;
            this.label5_PlayerDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5_PlayerDefence.Location = new System.Drawing.Point(3, 83);
            this.label5_PlayerDefence.Name = "label5_PlayerDefence";
            this.label5_PlayerDefence.Size = new System.Drawing.Size(81, 24);
            this.label5_PlayerDefence.TabIndex = 5;
            this.label5_PlayerDefence.Text = "Defence";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.83929F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.16071F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5_StrBot, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5_botSTR, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5_botDEF, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6_botDefence, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(531, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(241, 111);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Health";
            // 
            // label5_StrBot
            // 
            this.label5_StrBot.AutoSize = true;
            this.label5_StrBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5_StrBot.Location = new System.Drawing.Point(3, 58);
            this.label5_StrBot.Name = "label5_StrBot";
            this.label5_StrBot.Size = new System.Drawing.Size(80, 24);
            this.label5_StrBot.TabIndex = 5;
            this.label5_StrBot.Text = "Strength";
            // 
            // label5_botSTR
            // 
            this.label5_botSTR.AutoSize = true;
            this.label5_botSTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5_botSTR.Location = new System.Drawing.Point(96, 58);
            this.label5_botSTR.Name = "label5_botSTR";
            this.label5_botSTR.Size = new System.Drawing.Size(20, 24);
            this.label5_botSTR.TabIndex = 8;
            this.label5_botSTR.Text = "9";
            // 
            // label5_botDEF
            // 
            this.label5_botDEF.AutoSize = true;
            this.label5_botDEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5_botDEF.Location = new System.Drawing.Point(96, 86);
            this.label5_botDEF.Name = "label5_botDEF";
            this.label5_botDEF.Size = new System.Drawing.Size(20, 24);
            this.label5_botDEF.TabIndex = 9;
            this.label5_botDEF.Text = "9";
            // 
            // label6_botDefence
            // 
            this.label6_botDefence.AutoSize = true;
            this.label6_botDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6_botDefence.Location = new System.Drawing.Point(3, 86);
            this.label6_botDefence.Name = "label6_botDefence";
            this.label6_botDefence.Size = new System.Drawing.Size(81, 24);
            this.label6_botDefence.TabIndex = 6;
            this.label6_botDefence.Text = "Defence";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML файлы (*.xml)|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML файлы (*.xml)|*.xml";
            // 
            // imageList_Archer
            // 
            this.imageList_Archer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Archer.ImageStream")));
            this.imageList_Archer.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Archer.Images.SetKeyName(0, "eagleeye.png");
            this.imageList_Archer.Images.SetKeyName(1, "bullseye.png");
            // 
            // imageList_Knight
            // 
            this.imageList_Knight.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Knight.ImageStream")));
            this.imageList_Knight.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Knight.Images.SetKeyName(0, "swordhit.png");
            this.imageList_Knight.Images.SetKeyName(1, "combosword.png");
            // 
            // imageList_Halb
            // 
            this.imageList_Halb.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Halb.ImageStream")));
            this.imageList_Halb.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Halb.Images.SetKeyName(0, "roundattack.png");
            this.imageList_Halb.Images.SetKeyName(1, "bloodlumberjack.png");
            // 
            // imageList_Mage
            // 
            this.imageList_Mage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Mage.ImageStream")));
            this.imageList_Mage.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Mage.Images.SetKeyName(0, "fireball.png");
            this.imageList_Mage.Images.SetKeyName(1, "windstorm.png");
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(584, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 7;
            // 
            // imageList_main
            // 
            this.imageList_main.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_main.ImageStream")));
            this.imageList_main.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_main.Images.SetKeyName(0, "archer.png");
            this.imageList_main.Images.SetKeyName(1, "castle.png");
            this.imageList_main.Images.SetKeyName(2, "knight.png");
            this.imageList_main.Images.SetKeyName(3, "mage fire.png");
            // 
            // BattleField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BattleField";
            this.Text = "FightGame ver. 0.9";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_block;
        public System.Windows.Forms.Button button_hit2;
        public System.Windows.Forms.Button button_hit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_healthChanged;
        private System.Windows.Forms.Label label_nameChanged;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_health;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.Label label5_playerStrength;
        private System.Windows.Forms.Label label5_playerSTR;
        private System.Windows.Forms.Label label5_playerDEF;
        private System.Windows.Forms.Label label5_PlayerDefence;
        private System.Windows.Forms.Label label5_StrBot;
        private System.Windows.Forms.Label label5_botSTR;
        private System.Windows.Forms.Label label5_botDEF;
        private System.Windows.Forms.Label label6_botDefence;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList_Archer;
        private System.Windows.Forms.ImageList imageList_Knight;
        private System.Windows.Forms.ImageList imageList_Halb;
        private System.Windows.Forms.ImageList imageList_Mage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList_main;
    }
}

