namespace USAP_MATRICULA
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.lbl_SisMatric = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbx_Estud = new System.Windows.Forms.PictureBox();
            this.picbx_Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Estud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SisMatric
            // 
            this.lbl_SisMatric.AutoSize = true;
            this.lbl_SisMatric.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_SisMatric.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SisMatric.Location = new System.Drawing.Point(621, 45);
            this.lbl_SisMatric.Name = "lbl_SisMatric";
            this.lbl_SisMatric.Size = new System.Drawing.Size(465, 46);
            this.lbl_SisMatric.TabIndex = 1;
            this.lbl_SisMatric.Text = "Sistema de Matrícula";
            this.lbl_SisMatric.Click += new System.EventHandler(this.lbl_SisMatric_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Versión 1.0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 150);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Inicio);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1266, 567);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 4;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Inicio.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio.Image = global::USAP_MATRICULA.Properties.Resources.Home_50;
            this.btn_Inicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Inicio.Location = new System.Drawing.Point(45, 45);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(96, 89);
            this.btn_Inicio.TabIndex = 0;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Inicio.UseVisualStyleBackColor = false;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::USAP_MATRICULA.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(173, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 295);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picbx_Estud
            // 
            this.picbx_Estud.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picbx_Estud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbx_Estud.Image = global::USAP_MATRICULA.Properties.Resources.Student_Male_100;
            this.picbx_Estud.Location = new System.Drawing.Point(1115, 27);
            this.picbx_Estud.Name = "picbx_Estud";
            this.picbx_Estud.Size = new System.Drawing.Size(122, 98);
            this.picbx_Estud.TabIndex = 2;
            this.picbx_Estud.TabStop = false;
            // 
            // picbx_Fondo
            // 
            this.picbx_Fondo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picbx_Fondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbx_Fondo.Location = new System.Drawing.Point(0, 1);
            this.picbx_Fondo.Name = "picbx_Fondo";
            this.picbx_Fondo.Size = new System.Drawing.Size(1266, 150);
            this.picbx_Fondo.TabIndex = 0;
            this.picbx_Fondo.TabStop = false;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1266, 717);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbx_Estud);
            this.Controls.Add(this.lbl_SisMatric);
            this.Controls.Add(this.picbx_Fondo);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Estud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_Fondo;
        private System.Windows.Forms.Label lbl_SisMatric;
        private System.Windows.Forms.PictureBox picbx_Estud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

