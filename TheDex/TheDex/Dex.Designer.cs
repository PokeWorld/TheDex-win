namespace TheDex
{
    partial class Dex
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNxt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPokeName = new System.Windows.Forms.Label();
            this.picbxPokemonPic = new System.Windows.Forms.PictureBox();
            this.lblPokeNumber = new System.Windows.Forms.Label();
            this.lblPokemonDesc = new System.Windows.Forms.Label();
            this.lblPokemonHeight = new System.Windows.Forms.Label();
            this.lblPokemonWeight = new System.Windows.Forms.Label();
            this.lblPokemonGender = new System.Windows.Forms.Label();
            this.lblPokemonCategory = new System.Windows.Forms.Label();
            this.lblPokemonAbilities = new System.Windows.Forms.Label();
            this.lblTypes = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lbltype2 = new System.Windows.Forms.Label();
            this.lblWeaknesses = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPokemonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(13, 551);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 23);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNxt
            // 
            this.btnNxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNxt.Location = new System.Drawing.Point(683, 551);
            this.btnNxt.Name = "btnNxt";
            this.btnNxt.Size = new System.Drawing.Size(28, 23);
            this.btnNxt.TabIndex = 1;
            this.btnNxt.Text = ">";
            this.btnNxt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblWeaknesses);
            this.panel1.Controls.Add(this.lbltype2);
            this.panel1.Controls.Add(this.lbltype);
            this.panel1.Controls.Add(this.lblTypes);
            this.panel1.Controls.Add(this.lblPokemonAbilities);
            this.panel1.Controls.Add(this.lblPokemonCategory);
            this.panel1.Controls.Add(this.lblPokemonGender);
            this.panel1.Controls.Add(this.lblPokemonWeight);
            this.panel1.Controls.Add(this.lblPokemonHeight);
            this.panel1.Controls.Add(this.lblPokemonDesc);
            this.panel1.Controls.Add(this.picbxPokemonPic);
            this.panel1.Controls.Add(this.lblPokeName);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 546);
            this.panel1.TabIndex = 2;
            // 
            // lblPokeName
            // 
            this.lblPokeName.AutoSize = true;
            this.lblPokeName.Font = new System.Drawing.Font("Lucida Console", 17F);
            this.lblPokeName.Location = new System.Drawing.Point(14, 14);
            this.lblPokeName.Name = "lblPokeName";
            this.lblPokeName.Size = new System.Drawing.Size(178, 23);
            this.lblPokeName.TabIndex = 0;
            this.lblPokeName.Text = "Pokemon Name";
            // 
            // picbxPokemonPic
            // 
            this.picbxPokemonPic.Location = new System.Drawing.Point(426, 14);
            this.picbxPokemonPic.Name = "picbxPokemonPic";
            this.picbxPokemonPic.Size = new System.Drawing.Size(286, 281);
            this.picbxPokemonPic.TabIndex = 1;
            this.picbxPokemonPic.TabStop = false;
            // 
            // lblPokeNumber
            // 
            this.lblPokeNumber.AutoSize = true;
            this.lblPokeNumber.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.lblPokeNumber.Location = new System.Drawing.Point(336, 558);
            this.lblPokeNumber.Name = "lblPokeNumber";
            this.lblPokeNumber.Size = new System.Drawing.Size(38, 16);
            this.lblPokeNumber.TabIndex = 3;
            this.lblPokeNumber.Text = "NaN";
            // 
            // lblPokemonDesc
            // 
            this.lblPokemonDesc.AutoSize = true;
            this.lblPokemonDesc.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lblPokemonDesc.Location = new System.Drawing.Point(14, 60);
            this.lblPokemonDesc.Name = "lblPokemonDesc";
            this.lblPokemonDesc.Size = new System.Drawing.Size(251, 38);
            this.lblPokemonDesc.TabIndex = 2;
            this.lblPokemonDesc.Text = "The description of the\r\npokemon goes here.\r\n";
            // 
            // lblPokemonHeight
            // 
            this.lblPokemonHeight.AutoSize = true;
            this.lblPokemonHeight.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblPokemonHeight.Location = new System.Drawing.Point(426, 311);
            this.lblPokemonHeight.Name = "lblPokemonHeight";
            this.lblPokemonHeight.Size = new System.Drawing.Size(95, 14);
            this.lblPokemonHeight.TabIndex = 3;
            this.lblPokemonHeight.Text = "Height: NaN";
            // 
            // lblPokemonWeight
            // 
            this.lblPokemonWeight.AutoSize = true;
            this.lblPokemonWeight.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblPokemonWeight.Location = new System.Drawing.Point(426, 330);
            this.lblPokemonWeight.Name = "lblPokemonWeight";
            this.lblPokemonWeight.Size = new System.Drawing.Size(95, 14);
            this.lblPokemonWeight.TabIndex = 4;
            this.lblPokemonWeight.Text = "Weight: NaN";
            // 
            // lblPokemonGender
            // 
            this.lblPokemonGender.AutoSize = true;
            this.lblPokemonGender.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblPokemonGender.Location = new System.Drawing.Point(426, 349);
            this.lblPokemonGender.Name = "lblPokemonGender";
            this.lblPokemonGender.Size = new System.Drawing.Size(95, 14);
            this.lblPokemonGender.TabIndex = 5;
            this.lblPokemonGender.Text = "Gender: NaG";
            // 
            // lblPokemonCategory
            // 
            this.lblPokemonCategory.AutoSize = true;
            this.lblPokemonCategory.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblPokemonCategory.Location = new System.Drawing.Point(426, 368);
            this.lblPokemonCategory.Name = "lblPokemonCategory";
            this.lblPokemonCategory.Size = new System.Drawing.Size(111, 14);
            this.lblPokemonCategory.TabIndex = 6;
            this.lblPokemonCategory.Text = "Category: NaC";
            // 
            // lblPokemonAbilities
            // 
            this.lblPokemonAbilities.AutoSize = true;
            this.lblPokemonAbilities.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblPokemonAbilities.Location = new System.Drawing.Point(426, 387);
            this.lblPokemonAbilities.Name = "lblPokemonAbilities";
            this.lblPokemonAbilities.Size = new System.Drawing.Size(119, 14);
            this.lblPokemonAbilities.TabIndex = 7;
            this.lblPokemonAbilities.Text = "Abilities: NaA";
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.lblTypes.Location = new System.Drawing.Point(14, 135);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(69, 20);
            this.lblTypes.TabIndex = 8;
            this.lblTypes.Text = "Types";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.Chartreuse;
            this.lbltype.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.lbltype.Location = new System.Drawing.Point(14, 168);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(69, 20);
            this.lbltype.TabIndex = 9;
            this.lbltype.Text = "Type1";
            // 
            // lbltype2
            // 
            this.lbltype2.AutoSize = true;
            this.lbltype2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lbltype2.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.lbltype2.Location = new System.Drawing.Point(89, 168);
            this.lbltype2.Name = "lbltype2";
            this.lbltype2.Size = new System.Drawing.Size(69, 20);
            this.lbltype2.TabIndex = 10;
            this.lbltype2.Text = "Type2";
            // 
            // lblWeaknesses
            // 
            this.lblWeaknesses.AutoSize = true;
            this.lblWeaknesses.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.lblWeaknesses.Location = new System.Drawing.Point(14, 225);
            this.lblWeaknesses.Name = "lblWeaknesses";
            this.lblWeaknesses.Size = new System.Drawing.Size(129, 20);
            this.lblWeaknesses.TabIndex = 11;
            this.lblWeaknesses.Text = "Weaknesses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.label1.Location = new System.Drawing.Point(14, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Type1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.label2.Location = new System.Drawing.Point(89, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type2";
            // 
            // Dex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 586);
            this.Controls.Add(this.lblPokeNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNxt);
            this.Controls.Add(this.btnPrev);
            this.Name = "Dex";
            this.Text = "TheDex";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPokemonPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWeaknesses;
        private System.Windows.Forms.Label lbltype2;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.Label lblPokemonAbilities;
        private System.Windows.Forms.Label lblPokemonCategory;
        private System.Windows.Forms.Label lblPokemonGender;
        private System.Windows.Forms.Label lblPokemonWeight;
        private System.Windows.Forms.Label lblPokemonHeight;
        private System.Windows.Forms.Label lblPokemonDesc;
        private System.Windows.Forms.PictureBox picbxPokemonPic;
        private System.Windows.Forms.Label lblPokeName;
        private System.Windows.Forms.Label lblPokeNumber;
    }
}

