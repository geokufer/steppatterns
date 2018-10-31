namespace FightGame
{
    partial class NewCharacter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCharacter));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_NameChar = new System.Windows.Forms.Label();
            this.maskedTextBox_nameCharacter = new System.Windows.Forms.MaskedTextBox();
            this.label_nameNotification = new System.Windows.Forms.Label();
            this.imageList_unitProfessions = new System.Windows.Forms.ImageList(this.components);
            this.groupBox_choiceClassWarior = new System.Windows.Forms.GroupBox();
            this.radioButton_mage = new System.Windows.Forms.RadioButton();
            this.radioButton_halberdier = new System.Windows.Forms.RadioButton();
            this.radioButton_knight = new System.Windows.Forms.RadioButton();
            this.radioButton_archer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_newCharOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_choiceClassWarior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.Controls.Add(this.label_NameChar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox_nameCharacter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_nameNotification, 0, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.91667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.79167F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_NameChar
            // 
            this.label_NameChar.AutoSize = true;
            this.label_NameChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NameChar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_NameChar.Location = new System.Drawing.Point(125, 0);
            this.label_NameChar.Margin = new System.Windows.Forms.Padding(125, 0, 3, 0);
            this.label_NameChar.Name = "label_NameChar";
            this.label_NameChar.Size = new System.Drawing.Size(61, 24);
            this.label_NameChar.TabIndex = 0;
            this.label_NameChar.Text = "Name";
            // 
            // maskedTextBox_nameCharacter
            // 
            this.maskedTextBox_nameCharacter.BeepOnError = true;
            this.maskedTextBox_nameCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_nameCharacter.Location = new System.Drawing.Point(3, 48);
            this.maskedTextBox_nameCharacter.Mask = "A???????????????";
            this.maskedTextBox_nameCharacter.Name = "maskedTextBox_nameCharacter";
            this.maskedTextBox_nameCharacter.PromptChar = ' ';
            this.maskedTextBox_nameCharacter.Size = new System.Drawing.Size(354, 29);
            this.maskedTextBox_nameCharacter.TabIndex = 1;
            // 
            // label_nameNotification
            // 
            this.label_nameNotification.AutoSize = true;
            this.label_nameNotification.Location = new System.Drawing.Point(75, 30);
            this.label_nameNotification.Margin = new System.Windows.Forms.Padding(75, 3, 3, 0);
            this.label_nameNotification.Name = "label_nameNotification";
            this.label_nameNotification.Size = new System.Drawing.Size(164, 13);
            this.label_nameNotification.TabIndex = 2;
            this.label_nameNotification.Text = "(15 characters letters of numbers)";
            // 
            // imageList_unitProfessions
            // 
            this.imageList_unitProfessions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_unitProfessions.ImageStream")));
            this.imageList_unitProfessions.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_unitProfessions.Images.SetKeyName(0, "bow.png");
            this.imageList_unitProfessions.Images.SetKeyName(1, "halberd.png");
            this.imageList_unitProfessions.Images.SetKeyName(2, "swords.png");
            this.imageList_unitProfessions.Images.SetKeyName(3, "mage.png");
            // 
            // groupBox_choiceClassWarior
            // 
            this.groupBox_choiceClassWarior.Controls.Add(this.radioButton_mage);
            this.groupBox_choiceClassWarior.Controls.Add(this.radioButton_halberdier);
            this.groupBox_choiceClassWarior.Controls.Add(this.radioButton_knight);
            this.groupBox_choiceClassWarior.Controls.Add(this.radioButton_archer);
            this.groupBox_choiceClassWarior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_choiceClassWarior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_choiceClassWarior.Location = new System.Drawing.Point(12, 100);
            this.groupBox_choiceClassWarior.Name = "groupBox_choiceClassWarior";
            this.groupBox_choiceClassWarior.Size = new System.Drawing.Size(357, 163);
            this.groupBox_choiceClassWarior.TabIndex = 1;
            this.groupBox_choiceClassWarior.TabStop = false;
            this.groupBox_choiceClassWarior.Text = "Choice your unit type";
            // 
            // radioButton_mage
            // 
            this.radioButton_mage.AutoSize = true;
            this.radioButton_mage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_mage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton_mage.ImageIndex = 3;
            this.radioButton_mage.ImageList = this.imageList_unitProfessions;
            this.radioButton_mage.Location = new System.Drawing.Point(175, 96);
            this.radioButton_mage.Name = "radioButton_mage";
            this.radioButton_mage.Size = new System.Drawing.Size(131, 56);
            this.radioButton_mage.TabIndex = 3;
            this.radioButton_mage.TabStop = true;
            this.radioButton_mage.Text = "           Mage";
            this.radioButton_mage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_mage.UseVisualStyleBackColor = true;
            // 
            // radioButton_halberdier
            // 
            this.radioButton_halberdier.AutoSize = true;
            this.radioButton_halberdier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_halberdier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton_halberdier.ImageIndex = 1;
            this.radioButton_halberdier.ImageList = this.imageList_unitProfessions;
            this.radioButton_halberdier.Location = new System.Drawing.Point(175, 34);
            this.radioButton_halberdier.Name = "radioButton_halberdier";
            this.radioButton_halberdier.Size = new System.Drawing.Size(171, 56);
            this.radioButton_halberdier.TabIndex = 2;
            this.radioButton_halberdier.TabStop = true;
            this.radioButton_halberdier.Text = "           Halberdier";
            this.radioButton_halberdier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_halberdier.UseVisualStyleBackColor = true;
            // 
            // radioButton_knight
            // 
            this.radioButton_knight.AutoSize = true;
            this.radioButton_knight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_knight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton_knight.ImageIndex = 2;
            this.radioButton_knight.ImageList = this.imageList_unitProfessions;
            this.radioButton_knight.Location = new System.Drawing.Point(6, 96);
            this.radioButton_knight.Name = "radioButton_knight";
            this.radioButton_knight.Size = new System.Drawing.Size(136, 56);
            this.radioButton_knight.TabIndex = 1;
            this.radioButton_knight.TabStop = true;
            this.radioButton_knight.Text = "           Knight";
            this.radioButton_knight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_knight.UseVisualStyleBackColor = true;
            // 
            // radioButton_archer
            // 
            this.radioButton_archer.AutoSize = true;
            this.radioButton_archer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_archer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton_archer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton_archer.ImageIndex = 0;
            this.radioButton_archer.ImageList = this.imageList_unitProfessions;
            this.radioButton_archer.Location = new System.Drawing.Point(6, 34);
            this.radioButton_archer.Name = "radioButton_archer";
            this.radioButton_archer.Size = new System.Drawing.Size(140, 56);
            this.radioButton_archer.TabIndex = 0;
            this.radioButton_archer.TabStop = true;
            this.radioButton_archer.Text = "           Archer";
            this.radioButton_archer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_archer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_newCharOK);
            this.panel1.Location = new System.Drawing.Point(12, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 50);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "oooOOo...I\'m scary...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_newCharOK
            // 
            this.button_newCharOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_newCharOK.Location = new System.Drawing.Point(223, 3);
            this.button_newCharOK.Name = "button_newCharOK";
            this.button_newCharOK.Size = new System.Drawing.Size(128, 36);
            this.button_newCharOK.TabIndex = 0;
            this.button_newCharOK.Text = "Let\'s Fight!";
            this.button_newCharOK.UseVisualStyleBackColor = true;
            this.button_newCharOK.Click += new System.EventHandler(this.button_newCharOK_Click);
            // 
            // NewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_choiceClassWarior);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "NewCharacter";
            this.Text = "NewCharacter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_choiceClassWarior.ResumeLayout(false);
            this.groupBox_choiceClassWarior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_NameChar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_nameCharacter;
        private System.Windows.Forms.Label label_nameNotification;
        private System.Windows.Forms.ImageList imageList_unitProfessions;
        private System.Windows.Forms.GroupBox groupBox_choiceClassWarior;
        private System.Windows.Forms.RadioButton radioButton_mage;
        private System.Windows.Forms.RadioButton radioButton_halberdier;
        private System.Windows.Forms.RadioButton radioButton_knight;
        private System.Windows.Forms.RadioButton radioButton_archer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_newCharOK;
    }
}