namespace TestGame
{
    partial class SeleccionDeMazo
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
            this.label1 = new System.Windows.Forms.Label();
            this.pctBxStatsWarrior = new System.Windows.Forms.PictureBox();
            this.btnTank = new System.Windows.Forms.Button();
            this.btnHealer = new System.Windows.Forms.Button();
            this.btnAssassin = new System.Windows.Forms.Button();
            this.btnWarrior = new System.Windows.Forms.Button();
            this.pctBxAssa = new System.Windows.Forms.PictureBox();
            this.pctBxMago = new System.Windows.Forms.PictureBox();
            this.pctBxTank = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxStatsWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxAssa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxMago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxTank)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(328, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elige tus fichas:";
            // 
            // pctBxStatsWarrior
            // 
            this.pctBxStatsWarrior.Image = global::TestGame.Properties.Resources.statsWarrior;
            this.pctBxStatsWarrior.Location = new System.Drawing.Point(12, 334);
            this.pctBxStatsWarrior.Name = "pctBxStatsWarrior";
            this.pctBxStatsWarrior.Size = new System.Drawing.Size(178, 172);
            this.pctBxStatsWarrior.TabIndex = 5;
            this.pctBxStatsWarrior.TabStop = false;
            this.pctBxStatsWarrior.Visible = false;
            // 
            // btnTank
            // 
            this.btnTank.BackgroundImage = global::TestGame.Properties.Resources.TankByN;
            this.btnTank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTank.Location = new System.Drawing.Point(677, 73);
            this.btnTank.Name = "btnTank";
            this.btnTank.Size = new System.Drawing.Size(178, 263);
            this.btnTank.TabIndex = 3;
            this.btnTank.UseVisualStyleBackColor = true;
            this.btnTank.Click += new System.EventHandler(this.btnTank_Click);
            this.btnTank.MouseLeave += new System.EventHandler(this.btnTank_MouseLeave);
            this.btnTank.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTank_MouseMove);
            // 
            // btnHealer
            // 
            this.btnHealer.BackgroundImage = global::TestGame.Properties.Resources.HealerByN;
            this.btnHealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealer.Location = new System.Drawing.Point(456, 73);
            this.btnHealer.Name = "btnHealer";
            this.btnHealer.Size = new System.Drawing.Size(178, 263);
            this.btnHealer.TabIndex = 2;
            this.btnHealer.UseVisualStyleBackColor = true;
            this.btnHealer.Click += new System.EventHandler(this.btnHealer_Click);
            this.btnHealer.MouseLeave += new System.EventHandler(this.btnHealer_MouseLeave);
            this.btnHealer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHealer_MouseMove);
            // 
            // btnAssassin
            // 
            this.btnAssassin.BackgroundImage = global::TestGame.Properties.Resources.AssassinByN;
            this.btnAssassin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssassin.Location = new System.Drawing.Point(237, 73);
            this.btnAssassin.Name = "btnAssassin";
            this.btnAssassin.Size = new System.Drawing.Size(178, 263);
            this.btnAssassin.TabIndex = 1;
            this.btnAssassin.UseVisualStyleBackColor = true;
            this.btnAssassin.Click += new System.EventHandler(this.btnAssassin_Click);
            this.btnAssassin.MouseLeave += new System.EventHandler(this.btnAssassin_MouseLeave);
            this.btnAssassin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAssassin_MouseMove);
            // 
            // btnWarrior
            // 
            this.btnWarrior.BackgroundImage = global::TestGame.Properties.Resources.WarriorByN;
            this.btnWarrior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarrior.Location = new System.Drawing.Point(12, 73);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(178, 263);
            this.btnWarrior.TabIndex = 0;
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            this.btnWarrior.MouseLeave += new System.EventHandler(this.btnWarrior_MouseLeave);
            this.btnWarrior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnWarrior_MouseMove);
            // 
            // pctBxAssa
            // 
            this.pctBxAssa.Image = global::TestGame.Properties.Resources.statsAssassin;
            this.pctBxAssa.Location = new System.Drawing.Point(237, 334);
            this.pctBxAssa.Name = "pctBxAssa";
            this.pctBxAssa.Size = new System.Drawing.Size(178, 172);
            this.pctBxAssa.TabIndex = 6;
            this.pctBxAssa.TabStop = false;
            this.pctBxAssa.Visible = false;
            // 
            // pctBxMago
            // 
            this.pctBxMago.Image = global::TestGame.Properties.Resources.statsMago;
            this.pctBxMago.Location = new System.Drawing.Point(456, 334);
            this.pctBxMago.Name = "pctBxMago";
            this.pctBxMago.Size = new System.Drawing.Size(178, 172);
            this.pctBxMago.TabIndex = 7;
            this.pctBxMago.TabStop = false;
            this.pctBxMago.Visible = false;
            // 
            // pctBxTank
            // 
            this.pctBxTank.Image = global::TestGame.Properties.Resources.statsTank;
            this.pctBxTank.Location = new System.Drawing.Point(677, 334);
            this.pctBxTank.Name = "pctBxTank";
            this.pctBxTank.Size = new System.Drawing.Size(178, 172);
            this.pctBxTank.TabIndex = 8;
            this.pctBxTank.TabStop = false;
            this.pctBxTank.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(316, 440);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(251, 89);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // SeleccionDeMazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(867, 562);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pctBxTank);
            this.Controls.Add(this.pctBxMago);
            this.Controls.Add(this.pctBxAssa);
            this.Controls.Add(this.pctBxStatsWarrior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTank);
            this.Controls.Add(this.btnHealer);
            this.Controls.Add(this.btnAssassin);
            this.Controls.Add(this.btnWarrior);
            this.Name = "SeleccionDeMazo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion De Mazo";
            ((System.ComponentModel.ISupportInitialize)(this.pctBxStatsWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxAssa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxMago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxTank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnAssassin;
        private System.Windows.Forms.Button btnHealer;
        private System.Windows.Forms.Button btnTank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctBxStatsWarrior;
        private System.Windows.Forms.PictureBox pctBxAssa;
        private System.Windows.Forms.PictureBox pctBxMago;
        private System.Windows.Forms.PictureBox pctBxTank;
        private System.Windows.Forms.Button btnPlay;
    }
}