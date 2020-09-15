namespace ConcentrationGame
{
    partial class frm_Instructions
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
            this.pb_Instruction01 = new System.Windows.Forms.PictureBox();
            this.pb_Instructions02 = new System.Windows.Forms.PictureBox();
            this.pb_Instructions03 = new System.Windows.Forms.PictureBox();
            this.pb_Instructions04 = new System.Windows.Forms.PictureBox();
            this.lbl_ClickThese = new System.Windows.Forms.Label();
            this.lbl_ToFlip = new System.Windows.Forms.Label();
            this.lbl_MatchPairs = new System.Windows.Forms.Label();
            this.lbl_UntilWin = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Instruction01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Instructions02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Instructions03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Instructions04)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Instruction01
            // 
            this.pb_Instruction01.Image = global::ConcentrationGame.Properties.Resources.cardBack;
            this.pb_Instruction01.Location = new System.Drawing.Point(12, 12);
            this.pb_Instruction01.Name = "pb_Instruction01";
            this.pb_Instruction01.Size = new System.Drawing.Size(74, 108);
            this.pb_Instruction01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Instruction01.TabIndex = 0;
            this.pb_Instruction01.TabStop = false;
            // 
            // pb_Instructions02
            // 
            this.pb_Instructions02.Image = global::ConcentrationGame.Properties.Resources.clubs_ace;
            this.pb_Instructions02.Location = new System.Drawing.Point(307, 12);
            this.pb_Instructions02.Name = "pb_Instructions02";
            this.pb_Instructions02.Size = new System.Drawing.Size(74, 108);
            this.pb_Instructions02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Instructions02.TabIndex = 1;
            this.pb_Instructions02.TabStop = false;
            // 
            // pb_Instructions03
            // 
            this.pb_Instructions03.Image = global::ConcentrationGame.Properties.Resources.clubs_ace;
            this.pb_Instructions03.Location = new System.Drawing.Point(12, 181);
            this.pb_Instructions03.Name = "pb_Instructions03";
            this.pb_Instructions03.Size = new System.Drawing.Size(74, 108);
            this.pb_Instructions03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Instructions03.TabIndex = 2;
            this.pb_Instructions03.TabStop = false;
            // 
            // pb_Instructions04
            // 
            this.pb_Instructions04.Image = global::ConcentrationGame.Properties.Resources.spades_ace;
            this.pb_Instructions04.Location = new System.Drawing.Point(92, 181);
            this.pb_Instructions04.Name = "pb_Instructions04";
            this.pb_Instructions04.Size = new System.Drawing.Size(74, 108);
            this.pb_Instructions04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Instructions04.TabIndex = 3;
            this.pb_Instructions04.TabStop = false;
            // 
            // lbl_ClickThese
            // 
            this.lbl_ClickThese.AutoSize = true;
            this.lbl_ClickThese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClickThese.Location = new System.Drawing.Point(92, 12);
            this.lbl_ClickThese.Name = "lbl_ClickThese";
            this.lbl_ClickThese.Size = new System.Drawing.Size(147, 20);
            this.lbl_ClickThese.TabIndex = 4;
            this.lbl_ClickThese.Text = "<-- Click on a card...";
            // 
            // lbl_ToFlip
            // 
            this.lbl_ToFlip.AutoSize = true;
            this.lbl_ToFlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToFlip.Location = new System.Drawing.Point(181, 100);
            this.lbl_ToFlip.Name = "lbl_ToFlip";
            this.lbl_ToFlip.Size = new System.Drawing.Size(120, 20);
            this.lbl_ToFlip.TabIndex = 5;
            this.lbl_ToFlip.Text = "To flip it over -->";
            // 
            // lbl_MatchPairs
            // 
            this.lbl_MatchPairs.AutoSize = true;
            this.lbl_MatchPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatchPairs.Location = new System.Drawing.Point(173, 181);
            this.lbl_MatchPairs.Name = "lbl_MatchPairs";
            this.lbl_MatchPairs.Size = new System.Drawing.Size(202, 20);
            this.lbl_MatchPairs.TabIndex = 6;
            this.lbl_MatchPairs.Text = "<-- Match pairs of the same";
            this.lbl_MatchPairs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UntilWin
            // 
            this.lbl_UntilWin.AutoSize = true;
            this.lbl_UntilWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UntilWin.Location = new System.Drawing.Point(196, 201);
            this.lbl_UntilWin.Name = "lbl_UntilWin";
            this.lbl_UntilWin.Size = new System.Drawing.Size(178, 20);
            this.lbl_UntilWin.TabIndex = 7;
            this.lbl_UntilWin.Text = "colour suit until you win!!";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(275, 266);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(106, 28);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 301);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_UntilWin);
            this.Controls.Add(this.lbl_MatchPairs);
            this.Controls.Add(this.lbl_ToFlip);
            this.Controls.Add(this.lbl_ClickThese);
            this.Controls.Add(this.pb_Instructions04);
            this.Controls.Add(this.pb_Instructions03);
            this.Controls.Add(this.pb_Instructions02);
            this.Controls.Add(this.pb_Instruction01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_Instructions";
            this.Text = "Instructions";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Instruction01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Instructions02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Instructions03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Instructions04)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Instruction01;
        private System.Windows.Forms.PictureBox pb_Instructions02;
        private System.Windows.Forms.PictureBox pb_Instructions03;
        private System.Windows.Forms.PictureBox pb_Instructions04;
        private System.Windows.Forms.Label lbl_ClickThese;
        private System.Windows.Forms.Label lbl_ToFlip;
        private System.Windows.Forms.Label lbl_MatchPairs;
        private System.Windows.Forms.Label lbl_UntilWin;
        private System.Windows.Forms.Button btn_Close;
    }
}