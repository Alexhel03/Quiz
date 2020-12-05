namespace KVÍZ_Helísek
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Videohry = new System.Windows.Forms.Button();
            this.btn_Filmy = new System.Windows.Forms.Button();
            this.btn_Anime = new System.Windows.Forms.Button();
            this.nup_Videohry = new System.Windows.Forms.NumericUpDown();
            this.lbl_pocet1 = new System.Windows.Forms.Label();
            this.nup_Filmy = new System.Windows.Forms.NumericUpDown();
            this.lbl_pocet2 = new System.Windows.Forms.Label();
            this.lbl_pocet3 = new System.Windows.Forms.Label();
            this.nup_Anime = new System.Windows.Forms.NumericUpDown();
            this.pic_obrazky = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Videohry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Filmy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Anime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_obrazky)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Videohry
            // 
            this.btn_Videohry.Location = new System.Drawing.Point(13, 13);
            this.btn_Videohry.Name = "btn_Videohry";
            this.btn_Videohry.Size = new System.Drawing.Size(258, 105);
            this.btn_Videohry.TabIndex = 0;
            this.btn_Videohry.Text = "Videohry";
            this.btn_Videohry.UseVisualStyleBackColor = true;
            this.btn_Videohry.Click += new System.EventHandler(this.btn_Videohry_Click);
            // 
            // btn_Filmy
            // 
            this.btn_Filmy.Location = new System.Drawing.Point(277, 13);
            this.btn_Filmy.Name = "btn_Filmy";
            this.btn_Filmy.Size = new System.Drawing.Size(258, 105);
            this.btn_Filmy.TabIndex = 1;
            this.btn_Filmy.Text = "Filmy";
            this.btn_Filmy.UseVisualStyleBackColor = true;
            this.btn_Filmy.Click += new System.EventHandler(this.btn_Filmy_Click);
            // 
            // btn_Anime
            // 
            this.btn_Anime.Location = new System.Drawing.Point(541, 12);
            this.btn_Anime.Name = "btn_Anime";
            this.btn_Anime.Size = new System.Drawing.Size(258, 105);
            this.btn_Anime.TabIndex = 2;
            this.btn_Anime.Text = "Anime";
            this.btn_Anime.UseVisualStyleBackColor = true;
            this.btn_Anime.Click += new System.EventHandler(this.btn_Anime_Click);
            // 
            // nup_Videohry
            // 
            this.nup_Videohry.Location = new System.Drawing.Point(151, 124);
            this.nup_Videohry.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nup_Videohry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_Videohry.Name = "nup_Videohry";
            this.nup_Videohry.Size = new System.Drawing.Size(120, 20);
            this.nup_Videohry.TabIndex = 3;
            this.nup_Videohry.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_pocet1
            // 
            this.lbl_pocet1.AutoSize = true;
            this.lbl_pocet1.Location = new System.Drawing.Point(12, 126);
            this.lbl_pocet1.Name = "lbl_pocet1";
            this.lbl_pocet1.Size = new System.Drawing.Size(103, 13);
            this.lbl_pocet1.TabIndex = 4;
            this.lbl_pocet1.Text = "Kolik chceš otázek?";
            // 
            // nup_Filmy
            // 
            this.nup_Filmy.Location = new System.Drawing.Point(415, 124);
            this.nup_Filmy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nup_Filmy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_Filmy.Name = "nup_Filmy";
            this.nup_Filmy.Size = new System.Drawing.Size(120, 20);
            this.nup_Filmy.TabIndex = 5;
            this.nup_Filmy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_pocet2
            // 
            this.lbl_pocet2.AutoSize = true;
            this.lbl_pocet2.Location = new System.Drawing.Point(274, 126);
            this.lbl_pocet2.Name = "lbl_pocet2";
            this.lbl_pocet2.Size = new System.Drawing.Size(103, 13);
            this.lbl_pocet2.TabIndex = 6;
            this.lbl_pocet2.Text = "Kolik chceš otázek?";
            // 
            // lbl_pocet3
            // 
            this.lbl_pocet3.AutoSize = true;
            this.lbl_pocet3.Location = new System.Drawing.Point(538, 126);
            this.lbl_pocet3.Name = "lbl_pocet3";
            this.lbl_pocet3.Size = new System.Drawing.Size(103, 13);
            this.lbl_pocet3.TabIndex = 7;
            this.lbl_pocet3.Text = "Kolik chceš otázek?";
            // 
            // nup_Anime
            // 
            this.nup_Anime.Location = new System.Drawing.Point(679, 124);
            this.nup_Anime.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nup_Anime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_Anime.Name = "nup_Anime";
            this.nup_Anime.Size = new System.Drawing.Size(120, 20);
            this.nup_Anime.TabIndex = 8;
            this.nup_Anime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pic_obrazky
            // 
            this.pic_obrazky.Location = new System.Drawing.Point(277, 182);
            this.pic_obrazky.Name = "pic_obrazky";
            this.pic_obrazky.Size = new System.Drawing.Size(258, 197);
            this.pic_obrazky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_obrazky.TabIndex = 9;
            this.pic_obrazky.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.pic_obrazky);
            this.Controls.Add(this.nup_Anime);
            this.Controls.Add(this.lbl_pocet3);
            this.Controls.Add(this.lbl_pocet2);
            this.Controls.Add(this.nup_Filmy);
            this.Controls.Add(this.lbl_pocet1);
            this.Controls.Add(this.nup_Videohry);
            this.Controls.Add(this.btn_Anime);
            this.Controls.Add(this.btn_Filmy);
            this.Controls.Add(this.btn_Videohry);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nup_Videohry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Filmy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Anime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_obrazky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Videohry;
        private System.Windows.Forms.Button btn_Filmy;
        private System.Windows.Forms.Button btn_Anime;
        private System.Windows.Forms.NumericUpDown nup_Videohry;
        private System.Windows.Forms.Label lbl_pocet1;
        private System.Windows.Forms.NumericUpDown nup_Filmy;
        private System.Windows.Forms.Label lbl_pocet2;
        private System.Windows.Forms.Label lbl_pocet3;
        private System.Windows.Forms.NumericUpDown nup_Anime;
        private System.Windows.Forms.PictureBox pic_obrazky;
    }
}

