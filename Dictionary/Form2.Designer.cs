namespace Dictionary
{
    partial class fDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDictionary));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVieToEng = new System.Windows.Forms.Button();
            this.btnGGDich = new System.Windows.Forms.Button();
            this.btnEngToVie = new System.Windows.Forms.Button();
            this.txbDefine = new System.Windows.Forms.TextBox();
            this.txbMeans = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbWord);
            this.panel2.Location = new System.Drawing.Point(12, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 423);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Dictionary.Properties.Resources.micro_512;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(201, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 37);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbWord
            // 
            this.cbWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.DropDownWidth = 200;
            this.cbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Location = new System.Drawing.Point(3, 3);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(192, 409);
            this.cbWord.TabIndex = 0;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.cbWord_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnVieToEng);
            this.panel3.Controls.Add(this.btnGGDich);
            this.panel3.Controls.Add(this.btnEngToVie);
            this.panel3.Controls.Add(this.txbDefine);
            this.panel3.Controls.Add(this.txbMeans);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(260, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(724, 423);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dịch Việt - Anh";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Google Dịch";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dịch Anh - Việt";
            // 
            // btnVieToEng
            // 
            this.btnVieToEng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVieToEng.BackColor = System.Drawing.Color.White;
            this.btnVieToEng.BackgroundImage = global::Dictionary.Properties.Resources.Google_Translate_icon;
            this.btnVieToEng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVieToEng.Location = new System.Drawing.Point(553, 389);
            this.btnVieToEng.Name = "btnVieToEng";
            this.btnVieToEng.Size = new System.Drawing.Size(47, 34);
            this.btnVieToEng.TabIndex = 6;
            this.btnVieToEng.UseVisualStyleBackColor = false;
            this.btnVieToEng.Click += new System.EventHandler(this.btnVieToEng_Click);
            // 
            // btnGGDich
            // 
            this.btnGGDich.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGGDich.BackColor = System.Drawing.Color.White;
            this.btnGGDich.BackgroundImage = global::Dictionary.Properties.Resources.Google_Translate_icon;
            this.btnGGDich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGGDich.Location = new System.Drawing.Point(282, 386);
            this.btnGGDich.Name = "btnGGDich";
            this.btnGGDich.Size = new System.Drawing.Size(47, 34);
            this.btnGGDich.TabIndex = 5;
            this.btnGGDich.UseVisualStyleBackColor = false;
            this.btnGGDich.Click += new System.EventHandler(this.btnGGDich_Click);
            // 
            // btnEngToVie
            // 
            this.btnEngToVie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEngToVie.BackColor = System.Drawing.Color.White;
            this.btnEngToVie.BackgroundImage = global::Dictionary.Properties.Resources.Google_Translate_icon;
            this.btnEngToVie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEngToVie.Location = new System.Drawing.Point(3, 386);
            this.btnEngToVie.Name = "btnEngToVie";
            this.btnEngToVie.Size = new System.Drawing.Size(47, 34);
            this.btnEngToVie.TabIndex = 4;
            this.btnEngToVie.UseVisualStyleBackColor = false;
            this.btnEngToVie.Click += new System.EventHandler(this.btnEngToVie_Click);
            // 
            // txbDefine
            // 
            this.txbDefine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDefine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDefine.Location = new System.Drawing.Point(3, 46);
            this.txbDefine.Multiline = true;
            this.txbDefine.Name = "txbDefine";
            this.txbDefine.Size = new System.Drawing.Size(674, 334);
            this.txbDefine.TabIndex = 3;
            // 
            // txbMeans
            // 
            this.txbMeans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMeans.Location = new System.Drawing.Point(3, 3);
            this.txbMeans.Multiline = true;
            this.txbMeans.Name = "txbMeans";
            this.txbMeans.Size = new System.Drawing.Size(674, 37);
            this.txbMeans.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::Dictionary.Properties.Resources.micro_512;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(683, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 37);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Dictionary.Properties.Resources.oxford_dictionaries;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 107);
            this.panel1.TabIndex = 0;
            // 
            // fDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dictionary.Properties.Resources.pELVjk;
            this.ClientSize = new System.Drawing.Size(996, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ điển Anh - Việt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.Button btnEngToVie;
        private System.Windows.Forms.TextBox txbDefine;
        private System.Windows.Forms.TextBox txbMeans;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVieToEng;
        private System.Windows.Forms.Button btnGGDich;
    }
}