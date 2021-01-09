namespace windows_pet
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
            this.components = new System.ComponentModel.Container();
            this.actiontimer1 = new System.Windows.Forms.Timer(this.components);
            this.movetimer = new System.Windows.Forms.Timer(this.components);
            this.pichu = new System.Windows.Forms.PictureBox();
            this.binieta = new System.Windows.Forms.PictureBox();
            this.texobinieta = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pichu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binieta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // actiontimer1
            // 
            this.actiontimer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // movetimer
            // 
            this.movetimer.Interval = 10;
            this.movetimer.Tick += new System.EventHandler(this.movetimer_Tick);
            // 
            // pichu
            // 
            this.pichu.BackColor = System.Drawing.Color.Transparent;
            this.pichu.Image = global::windows_pet.Properties.Resources.z;
            this.pichu.Location = new System.Drawing.Point(655, 385);
            this.pichu.Name = "pichu";
            this.pichu.Size = new System.Drawing.Size(103, 103);
            this.pichu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichu.TabIndex = 0;
            this.pichu.TabStop = false;
            // 
            // binieta
            // 
            this.binieta.BackColor = System.Drawing.Color.Transparent;
            this.binieta.Image = global::windows_pet.Properties.Resources.textbox;
            this.binieta.InitialImage = global::windows_pet.Properties.Resources.textbox;
            this.binieta.Location = new System.Drawing.Point(304, 12);
            this.binieta.Name = "binieta";
            this.binieta.Size = new System.Drawing.Size(126, 68);
            this.binieta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.binieta.TabIndex = 5;
            this.binieta.TabStop = false;
            this.binieta.Visible = false;
            // 
            // texobinieta
            // 
            this.texobinieta.AutoSize = true;
            this.texobinieta.BackColor = System.Drawing.SystemColors.Window;
            this.texobinieta.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texobinieta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.texobinieta.Location = new System.Drawing.Point(344, 21);
            this.texobinieta.Name = "texobinieta";
            this.texobinieta.Size = new System.Drawing.Size(22, 23);
            this.texobinieta.TabIndex = 6;
            this.texobinieta.Text = "h";
            this.texobinieta.UseMnemonic = false;
            this.texobinieta.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(748, 474);
            this.Controls.Add(this.texobinieta);
            this.Controls.Add(this.binieta);
            this.Controls.Add(this.pichu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "casita J";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pichu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binieta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pichu;
        private System.Windows.Forms.Timer actiontimer1;
        private System.Windows.Forms.Timer movetimer;
        private System.Windows.Forms.PictureBox binieta;
        private System.Windows.Forms.Label texobinieta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

