namespace Exmen
{
    partial class Mapa2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.uva = new System.Windows.Forms.PictureBox();
            this.guinda = new System.Windows.Forms.PictureBox();
            this.rosado = new System.Windows.Forms.PictureBox();
            this.rojo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guinda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Puntaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 76);
            this.label2.TabIndex = 19;
            this.label2.Text = "GAME OVER";
            this.label2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Exmen.Properties.Resources.pacman_right;
            this.pictureBox9.Location = new System.Drawing.Point(300, 207);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 17;
            this.pictureBox9.TabStop = false;
            // 
            // uva
            // 
            this.uva.Image = global::Exmen.Properties.Resources.tile114;
            this.uva.Location = new System.Drawing.Point(389, 324);
            this.uva.Name = "uva";
            this.uva.Size = new System.Drawing.Size(35, 35);
            this.uva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uva.TabIndex = 16;
            this.uva.TabStop = false;
            this.uva.Tag = "";
            // 
            // guinda
            // 
            this.guinda.Image = global::Exmen.Properties.Resources.cherry;
            this.guinda.Location = new System.Drawing.Point(50, 46);
            this.guinda.Name = "guinda";
            this.guinda.Size = new System.Drawing.Size(35, 35);
            this.guinda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guinda.TabIndex = 15;
            this.guinda.TabStop = false;
            this.guinda.Tag = "";
            // 
            // rosado
            // 
            this.rosado.Image = global::Exmen.Properties.Resources.pink_left1;
            this.rosado.Location = new System.Drawing.Point(137, 116);
            this.rosado.Name = "rosado";
            this.rosado.Size = new System.Drawing.Size(35, 35);
            this.rosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rosado.TabIndex = 14;
            this.rosado.TabStop = false;
            this.rosado.Tag = "";
            // 
            // rojo
            // 
            this.rojo.Image = global::Exmen.Properties.Resources.red_left1;
            this.rojo.Location = new System.Drawing.Point(497, 274);
            this.rojo.Name = "rojo";
            this.rojo.Size = new System.Drawing.Size(35, 35);
            this.rojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rojo.TabIndex = 13;
            this.rojo.TabStop = false;
            this.rojo.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mapa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.uva);
            this.Controls.Add(this.guinda);
            this.Controls.Add(this.rosado);
            this.Controls.Add(this.rojo);
            this.Name = "Mapa2";
            this.Text = "Mapa2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guinda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox uva;
        private System.Windows.Forms.PictureBox guinda;
        private System.Windows.Forms.PictureBox rosado;
        private System.Windows.Forms.PictureBox rojo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}