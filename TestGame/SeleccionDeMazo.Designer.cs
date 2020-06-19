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
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnAssassin = new System.Windows.Forms.Button();
            this.btnHealer = new System.Windows.Forms.Button();
            this.btnTank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWarrior
            // 
            this.btnWarrior.BackgroundImage = global::TestGame.Properties.Resources.WarriorByN;
            this.btnWarrior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarrior.Location = new System.Drawing.Point(12, 105);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(178, 263);
            this.btnWarrior.TabIndex = 0;
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.MouseLeave += new System.EventHandler(this.btnWarrior_MouseLeave);
            this.btnWarrior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnWarrior_MouseMove);
            // 
            // btnAssassin
            // 
            this.btnAssassin.BackgroundImage = global::TestGame.Properties.Resources.AssassinByN;
            this.btnAssassin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssassin.Location = new System.Drawing.Point(237, 105);
            this.btnAssassin.Name = "btnAssassin";
            this.btnAssassin.Size = new System.Drawing.Size(178, 263);
            this.btnAssassin.TabIndex = 1;
            this.btnAssassin.UseVisualStyleBackColor = true;
            this.btnAssassin.MouseLeave += new System.EventHandler(this.btnAssassin_MouseLeave);
            this.btnAssassin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAssassin_MouseMove);
            // 
            // btnHealer
            // 
            this.btnHealer.BackgroundImage = global::TestGame.Properties.Resources.HealerByN;
            this.btnHealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealer.Location = new System.Drawing.Point(456, 105);
            this.btnHealer.Name = "btnHealer";
            this.btnHealer.Size = new System.Drawing.Size(178, 263);
            this.btnHealer.TabIndex = 2;
            this.btnHealer.UseVisualStyleBackColor = true;
            this.btnHealer.MouseLeave += new System.EventHandler(this.btnHealer_MouseLeave);
            this.btnHealer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHealer_MouseMove);
            // 
            // btnTank
            // 
            this.btnTank.BackgroundImage = global::TestGame.Properties.Resources.TankByN;
            this.btnTank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTank.Location = new System.Drawing.Point(677, 105);
            this.btnTank.Name = "btnTank";
            this.btnTank.Size = new System.Drawing.Size(178, 263);
            this.btnTank.TabIndex = 3;
            this.btnTank.UseVisualStyleBackColor = true;
            this.btnTank.MouseLeave += new System.EventHandler(this.btnTank_MouseLeave);
            this.btnTank.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTank_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(328, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elige tus fichas:";
            // 
            // SeleccionDeMazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(867, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTank);
            this.Controls.Add(this.btnHealer);
            this.Controls.Add(this.btnAssassin);
            this.Controls.Add(this.btnWarrior);
            this.Name = "SeleccionDeMazo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion De Mazo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnAssassin;
        private System.Windows.Forms.Button btnHealer;
        private System.Windows.Forms.Button btnTank;
        private System.Windows.Forms.Label label1;
    }
}