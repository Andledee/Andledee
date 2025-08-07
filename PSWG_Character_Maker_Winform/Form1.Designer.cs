namespace PSWG_Character_Maker_Winform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.lblPersonality = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblAlign = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.genderButton = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblDislikes = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtAlign = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtLikes = new System.Windows.Forms.TextBox();
            this.txtDislikes = new System.Windows.Forms.TextBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.txtPersonality = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.nameButton = new System.Windows.Forms.CheckBox();
            this.colorButton = new System.Windows.Forms.CheckBox();
            this.alignButton = new System.Windows.Forms.CheckBox();
            this.speciesButton = new System.Windows.Forms.CheckBox();
            this.likesButton = new System.Windows.Forms.CheckBox();
            this.dislikesButton = new System.Windows.Forms.CheckBox();
            this.typeButton = new System.Windows.Forms.CheckBox();
            this.weaponButton = new System.Windows.Forms.CheckBox();
            this.personalityButton = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.randSelectButton = new System.Windows.Forms.Button();
            this.randAllButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.randAllButton);
            this.groupBox1.Controls.Add(this.randSelectButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.personalityButton);
            this.groupBox1.Controls.Add(this.weaponButton);
            this.groupBox1.Controls.Add(this.typeButton);
            this.groupBox1.Controls.Add(this.dislikesButton);
            this.groupBox1.Controls.Add(this.likesButton);
            this.groupBox1.Controls.Add(this.speciesButton);
            this.groupBox1.Controls.Add(this.alignButton);
            this.groupBox1.Controls.Add(this.colorButton);
            this.groupBox1.Controls.Add(this.nameButton);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtPersonality);
            this.groupBox1.Controls.Add(this.txtWeapon);
            this.groupBox1.Controls.Add(this.txtDislikes);
            this.groupBox1.Controls.Add(this.txtLikes);
            this.groupBox1.Controls.Add(this.txtSpecies);
            this.groupBox1.Controls.Add(this.txtAlign);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.lblDislikes);
            this.groupBox1.Controls.Add(this.lblLikes);
            this.groupBox1.Controls.Add(this.lblWeapon);
            this.groupBox1.Controls.Add(this.lblPersonality);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblSpecies);
            this.groupBox1.Controls.Add(this.lblAlign);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.genderButton);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Location = new System.Drawing.Point(21, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1573, 708);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeapon.Location = new System.Drawing.Point(812, 101);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(135, 36);
            this.lblWeapon.TabIndex = 10;
            this.lblWeapon.Text = "Weapon:";
            // 
            // lblPersonality
            // 
            this.lblPersonality.AutoSize = true;
            this.lblPersonality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonality.Location = new System.Drawing.Point(776, 189);
            this.lblPersonality.Name = "lblPersonality";
            this.lblPersonality.Size = new System.Drawing.Size(171, 36);
            this.lblPersonality.TabIndex = 9;
            this.lblPersonality.Text = "Personality:";
            this.lblPersonality.Click += new System.EventHandler(this.lblPersonality_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(812, 27);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(158, 36);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Archetype:";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(17, 242);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(129, 36);
            this.lblSpecies.TabIndex = 7;
            this.lblSpecies.Text = "Species:";
            // 
            // lblAlign
            // 
            this.lblAlign.AutoSize = true;
            this.lblAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlign.Location = new System.Drawing.Point(17, 187);
            this.lblAlign.Name = "lblAlign";
            this.lblAlign.Size = new System.Drawing.Size(156, 36);
            this.lblAlign.TabIndex = 6;
            this.lblAlign.Text = "Alignment:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(6, 130);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(210, 36);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color Scheme:";
            // 
            // genderButton
            // 
            this.genderButton.AutoSize = true;
            this.genderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderButton.Location = new System.Drawing.Point(354, 33);
            this.genderButton.Name = "genderButton";
            this.genderButton.Size = new System.Drawing.Size(183, 35);
            this.genderButton.TabIndex = 4;
            this.genderButton.Text = "Randomize";
            this.genderButton.UseVisualStyleBackColor = true;
            this.genderButton.CheckedChanged += new System.EventHandler(this.genderButton_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(123, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 41);
            this.txtName.TabIndex = 3;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(143, 27);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(188, 41);
            this.txtGender.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 36);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(6, 27);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(122, 36);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.HotPink;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(355, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(867, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Panty and Stocking Character Creator";
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.Location = new System.Drawing.Point(35, 299);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(93, 36);
            this.lblLikes.TabIndex = 1;
            this.lblLikes.Text = "Likes:";
            // 
            // lblDislikes
            // 
            this.lblDislikes.AutoSize = true;
            this.lblDislikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDislikes.Location = new System.Drawing.Point(20, 457);
            this.lblDislikes.Name = "lblDislikes";
            this.lblDislikes.Size = new System.Drawing.Size(126, 36);
            this.lblDislikes.TabIndex = 11;
            this.lblDislikes.Text = "Dislikes:";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(222, 130);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(315, 41);
            this.txtColor.TabIndex = 12;
            // 
            // txtAlign
            // 
            this.txtAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlign.Location = new System.Drawing.Point(179, 184);
            this.txtAlign.Name = "txtAlign";
            this.txtAlign.Size = new System.Drawing.Size(313, 41);
            this.txtAlign.TabIndex = 13;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecies.Location = new System.Drawing.Point(163, 242);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(223, 41);
            this.txtSpecies.TabIndex = 14;
            // 
            // txtLikes
            // 
            this.txtLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLikes.Location = new System.Drawing.Point(143, 299);
            this.txtLikes.Multiline = true;
            this.txtLikes.Name = "txtLikes";
            this.txtLikes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLikes.Size = new System.Drawing.Size(420, 155);
            this.txtLikes.TabIndex = 15;
            // 
            // txtDislikes
            // 
            this.txtDislikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDislikes.Location = new System.Drawing.Point(143, 475);
            this.txtDislikes.Multiline = true;
            this.txtDislikes.Name = "txtDislikes";
            this.txtDislikes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDislikes.Size = new System.Drawing.Size(420, 179);
            this.txtDislikes.TabIndex = 16;
            // 
            // txtWeapon
            // 
            this.txtWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeapon.Location = new System.Drawing.Point(953, 101);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(263, 41);
            this.txtWeapon.TabIndex = 17;
            // 
            // txtPersonality
            // 
            this.txtPersonality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonality.Location = new System.Drawing.Point(953, 170);
            this.txtPersonality.Multiline = true;
            this.txtPersonality.Name = "txtPersonality";
            this.txtPersonality.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPersonality.Size = new System.Drawing.Size(393, 284);
            this.txtPersonality.TabIndex = 18;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(976, 34);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(348, 41);
            this.txtType.TabIndex = 19;
            // 
            // nameButton
            // 
            this.nameButton.AutoSize = true;
            this.nameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameButton.Location = new System.Drawing.Point(412, 79);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(183, 35);
            this.nameButton.TabIndex = 20;
            this.nameButton.Text = "Randomize";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.CheckedChanged += new System.EventHandler(this.nameButton_CheckedChanged);
            // 
            // colorButton
            // 
            this.colorButton.AutoSize = true;
            this.colorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorButton.Location = new System.Drawing.Point(556, 136);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(183, 35);
            this.colorButton.TabIndex = 21;
            this.colorButton.Text = "Randomize";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.CheckedChanged += new System.EventHandler(this.colorButton_CheckedChanged);
            // 
            // alignButton
            // 
            this.alignButton.AutoSize = true;
            this.alignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alignButton.Location = new System.Drawing.Point(498, 190);
            this.alignButton.Name = "alignButton";
            this.alignButton.Size = new System.Drawing.Size(183, 35);
            this.alignButton.TabIndex = 22;
            this.alignButton.Text = "Randomize";
            this.alignButton.UseVisualStyleBackColor = true;
            this.alignButton.CheckedChanged += new System.EventHandler(this.alignButton_CheckedChanged);
            // 
            // speciesButton
            // 
            this.speciesButton.AutoSize = true;
            this.speciesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciesButton.Location = new System.Drawing.Point(412, 248);
            this.speciesButton.Name = "speciesButton";
            this.speciesButton.Size = new System.Drawing.Size(183, 35);
            this.speciesButton.TabIndex = 23;
            this.speciesButton.Text = "Randomize";
            this.speciesButton.UseVisualStyleBackColor = true;
            this.speciesButton.CheckedChanged += new System.EventHandler(this.speciesButton_CheckedChanged);
            // 
            // likesButton
            // 
            this.likesButton.AutoSize = true;
            this.likesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likesButton.Location = new System.Drawing.Point(569, 352);
            this.likesButton.Name = "likesButton";
            this.likesButton.Size = new System.Drawing.Size(183, 35);
            this.likesButton.TabIndex = 24;
            this.likesButton.Text = "Randomize";
            this.likesButton.UseVisualStyleBackColor = true;
            this.likesButton.CheckedChanged += new System.EventHandler(this.likesButton_CheckedChanged);
            // 
            // dislikesButton
            // 
            this.dislikesButton.AutoSize = true;
            this.dislikesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dislikesButton.Location = new System.Drawing.Point(569, 536);
            this.dislikesButton.Name = "dislikesButton";
            this.dislikesButton.Size = new System.Drawing.Size(183, 35);
            this.dislikesButton.TabIndex = 25;
            this.dislikesButton.Text = "Randomize";
            this.dislikesButton.UseVisualStyleBackColor = true;
            this.dislikesButton.CheckedChanged += new System.EventHandler(this.dislikesButton_CheckedChanged);
            // 
            // typeButton
            // 
            this.typeButton.AutoSize = true;
            this.typeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeButton.Location = new System.Drawing.Point(1330, 40);
            this.typeButton.Name = "typeButton";
            this.typeButton.Size = new System.Drawing.Size(183, 35);
            this.typeButton.TabIndex = 26;
            this.typeButton.Text = "Randomize";
            this.typeButton.UseVisualStyleBackColor = true;
            this.typeButton.CheckedChanged += new System.EventHandler(this.typeButton_CheckedChanged);
            // 
            // weaponButton
            // 
            this.weaponButton.AutoSize = true;
            this.weaponButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponButton.Location = new System.Drawing.Point(1222, 107);
            this.weaponButton.Name = "weaponButton";
            this.weaponButton.Size = new System.Drawing.Size(183, 35);
            this.weaponButton.TabIndex = 27;
            this.weaponButton.Text = "Randomize";
            this.weaponButton.UseVisualStyleBackColor = true;
            this.weaponButton.CheckedChanged += new System.EventHandler(this.weaponButton_CheckedChanged);
            // 
            // personalityButton
            // 
            this.personalityButton.AutoSize = true;
            this.personalityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalityButton.Location = new System.Drawing.Point(1352, 273);
            this.personalityButton.Name = "personalityButton";
            this.personalityButton.Size = new System.Drawing.Size(183, 35);
            this.personalityButton.TabIndex = 28;
            this.personalityButton.Text = "Randomize";
            this.personalityButton.UseVisualStyleBackColor = true;
            this.personalityButton.CheckedChanged += new System.EventHandler(this.personalityButton_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Gold;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(1259, 574);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(146, 63);
            this.resetButton.TabIndex = 30;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1347, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credits to Andledee";
            // 
            // randSelectButton
            // 
            this.randSelectButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.randSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randSelectButton.Location = new System.Drawing.Point(1001, 488);
            this.randSelectButton.Name = "randSelectButton";
            this.randSelectButton.Size = new System.Drawing.Size(372, 67);
            this.randSelectButton.TabIndex = 31;
            this.randSelectButton.Text = "Randomize Selected Only";
            this.randSelectButton.UseVisualStyleBackColor = false;
            this.randSelectButton.Click += new System.EventHandler(this.randSelectButton_Click);
            // 
            // randAllButton
            // 
            this.randAllButton.BackColor = System.Drawing.Color.LightCoral;
            this.randAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randAllButton.Location = new System.Drawing.Point(976, 574);
            this.randAllButton.Name = "randAllButton";
            this.randAllButton.Size = new System.Drawing.Size(225, 63);
            this.randAllButton.TabIndex = 32;
            this.randAllButton.Text = "Randomize All";
            this.randAllButton.UseVisualStyleBackColor = false;
            this.randAllButton.Click += new System.EventHandler(this.randAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1633, 900);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PSWG Character Maker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox genderButton;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAlign;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Label lblPersonality;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDislikes;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtAlign;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtLikes;
        private System.Windows.Forms.TextBox txtDislikes;
        private System.Windows.Forms.TextBox txtPersonality;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.CheckBox dislikesButton;
        private System.Windows.Forms.CheckBox likesButton;
        private System.Windows.Forms.CheckBox speciesButton;
        private System.Windows.Forms.CheckBox alignButton;
        private System.Windows.Forms.CheckBox colorButton;
        private System.Windows.Forms.CheckBox nameButton;
        private System.Windows.Forms.CheckBox personalityButton;
        private System.Windows.Forms.CheckBox weaponButton;
        private System.Windows.Forms.CheckBox typeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button randAllButton;
        private System.Windows.Forms.Button randSelectButton;
    }
}

