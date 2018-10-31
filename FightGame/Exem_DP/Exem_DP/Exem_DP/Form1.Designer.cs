namespace Exem_DP {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.buttonCreateHero = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxNameHero = new System.Windows.Forms.TextBox();
            this.labelNameHero = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.buttonClassMage = new System.Windows.Forms.Button();
            this.buttonClassShooter = new System.Windows.Forms.Button();
            this.buttonClassWarrior = new System.Windows.Forms.Button();
            this.buttonFireball = new System.Windows.Forms.Button();
            this.buttonLighting = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonShotByAR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonHitSword = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateHero
            // 
            this.buttonCreateHero.Location = new System.Drawing.Point(375, 12);
            this.buttonCreateHero.Name = "buttonCreateHero";
            this.buttonCreateHero.Size = new System.Drawing.Size(75, 35);
            this.buttonCreateHero.TabIndex = 0;
            this.buttonCreateHero.Text = "Створення персонажу";
            this.buttonCreateHero.UseVisualStyleBackColor = true;
            this.buttonCreateHero.Click += new System.EventHandler(this.buttonCreateHero_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(290, 410);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBoxNameHero
            // 
            this.textBoxNameHero.Location = new System.Drawing.Point(364, 68);
            this.textBoxNameHero.Name = "textBoxNameHero";
            this.textBoxNameHero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameHero.TabIndex = 2;
            this.textBoxNameHero.Visible = false;
            // 
            // labelNameHero
            // 
            this.labelNameHero.AutoSize = true;
            this.labelNameHero.Location = new System.Drawing.Point(323, 71);
            this.labelNameHero.Name = "labelNameHero";
            this.labelNameHero.Size = new System.Drawing.Size(35, 13);
            this.labelNameHero.TabIndex = 3;
            this.labelNameHero.Text = "Им`я:";
            this.labelNameHero.Visible = false;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(372, 99);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(76, 13);
            this.labelClass.TabIndex = 3;
            this.labelClass.Text = "Оберіть клас:";
            this.labelClass.Visible = false;
            // 
            // buttonClassMage
            // 
            this.buttonClassMage.Location = new System.Drawing.Point(326, 124);
            this.buttonClassMage.Name = "buttonClassMage";
            this.buttonClassMage.Size = new System.Drawing.Size(43, 23);
            this.buttonClassMage.TabIndex = 4;
            this.buttonClassMage.Text = "Маг";
            this.buttonClassMage.UseVisualStyleBackColor = true;
            this.buttonClassMage.Visible = false;
            this.buttonClassMage.Click += new System.EventHandler(this.buttonClassMage_Click);
            // 
            // buttonClassShooter
            // 
            this.buttonClassShooter.Location = new System.Drawing.Point(375, 124);
            this.buttonClassShooter.Name = "buttonClassShooter";
            this.buttonClassShooter.Size = new System.Drawing.Size(67, 23);
            this.buttonClassShooter.TabIndex = 4;
            this.buttonClassShooter.Text = "Стрілець";
            this.buttonClassShooter.UseVisualStyleBackColor = true;
            this.buttonClassShooter.Visible = false;
            this.buttonClassShooter.Click += new System.EventHandler(this.buttonClassShooter_Click);
            // 
            // buttonClassWarrior
            // 
            this.buttonClassWarrior.Location = new System.Drawing.Point(448, 124);
            this.buttonClassWarrior.Name = "buttonClassWarrior";
            this.buttonClassWarrior.Size = new System.Drawing.Size(56, 23);
            this.buttonClassWarrior.TabIndex = 4;
            this.buttonClassWarrior.Text = "Воїн";
            this.buttonClassWarrior.UseVisualStyleBackColor = true;
            this.buttonClassWarrior.Visible = false;
            this.buttonClassWarrior.Click += new System.EventHandler(this.buttonClassWarrior_Click);
            // 
            // buttonFireball
            // 
            this.buttonFireball.Location = new System.Drawing.Point(292, 264);
            this.buttonFireball.Name = "buttonFireball";
            this.buttonFireball.Size = new System.Drawing.Size(75, 39);
            this.buttonFireball.TabIndex = 5;
            this.buttonFireball.Text = "Кинути фаєрболл";
            this.buttonFireball.UseVisualStyleBackColor = true;
            this.buttonFireball.Visible = false;
            this.buttonFireball.Click += new System.EventHandler(this.buttonFireball_Click);
            // 
            // buttonLighting
            // 
            this.buttonLighting.Location = new System.Drawing.Point(373, 264);
            this.buttonLighting.Name = "buttonLighting";
            this.buttonLighting.Size = new System.Drawing.Size(75, 39);
            this.buttonLighting.TabIndex = 5;
            this.buttonLighting.Text = "Вдарити молнією";
            this.buttonLighting.UseVisualStyleBackColor = true;
            this.buttonLighting.Visible = false;
            this.buttonLighting.Click += new System.EventHandler(this.buttonLighting_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.buttonFireball_Click);
            // 
            // buttonShotByAR
            // 
            this.buttonShotByAR.Location = new System.Drawing.Point(294, 309);
            this.buttonShotByAR.Name = "buttonShotByAR";
            this.buttonShotByAR.Size = new System.Drawing.Size(75, 39);
            this.buttonShotByAR.TabIndex = 5;
            this.buttonShotByAR.Text = "Постріл зі снайперки";
            this.buttonShotByAR.UseVisualStyleBackColor = true;
            this.buttonShotByAR.Visible = false;
            this.buttonShotByAR.Click += new System.EventHandler(this.buttonShotByAR_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.buttonLighting_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(454, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.buttonFireball_Click);
            // 
            // buttonHitSword
            // 
            this.buttonHitSword.Location = new System.Drawing.Point(296, 354);
            this.buttonHitSword.Name = "buttonHitSword";
            this.buttonHitSword.Size = new System.Drawing.Size(75, 39);
            this.buttonHitSword.TabIndex = 5;
            this.buttonHitSword.Text = "Удар мечем";
            this.buttonHitSword.UseVisualStyleBackColor = true;
            this.buttonHitSword.Visible = false;
            this.buttonHitSword.Click += new System.EventHandler(this.buttonHitSword_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(373, 354);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 39);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.buttonLighting_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(454, 264);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 39);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.buttonFireball_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 410);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonLighting);
            this.Controls.Add(this.buttonHitSword);
            this.Controls.Add(this.buttonShotByAR);
            this.Controls.Add(this.buttonFireball);
            this.Controls.Add(this.buttonClassWarrior);
            this.Controls.Add(this.buttonClassShooter);
            this.Controls.Add(this.buttonClassMage);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelNameHero);
            this.Controls.Add(this.textBoxNameHero);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonCreateHero);
            this.Name = "Form1";
            this.Text = "Демоверсія гри";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateHero;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxNameHero;
        private System.Windows.Forms.Label labelNameHero;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Button buttonClassMage;
        private System.Windows.Forms.Button buttonClassShooter;
        private System.Windows.Forms.Button buttonClassWarrior;
        private System.Windows.Forms.Button buttonFireball;
        private System.Windows.Forms.Button buttonLighting;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonShotByAR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonHitSword;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

