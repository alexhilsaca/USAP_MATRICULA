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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.btn_identificate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_SisMatric = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbx_Estud = new System.Windows.Forms.PictureBox();
            this.picbx_Fondo = new System.Windows.Forms.PictureBox();
            this.lbl_Bienv = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Nomb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Estud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Inicio);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.btn_identificate);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.btn_Inicio, "btn_Inicio");
            this.btn_Inicio.ForeColor = System.Drawing.Color.Black;
            this.btn_Inicio.Image = global::USAP_MATRICULA.Properties.Resources.Home_50;
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = false;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // btn_identificate
            // 
            this.btn_identificate.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.btn_identificate, "btn_identificate");
            this.btn_identificate.ForeColor = System.Drawing.Color.Black;
            this.btn_identificate.Image = global::USAP_MATRICULA.Properties.Resources.Student_Male_50;
            this.btn_identificate.Name = "btn_identificate";
            this.btn_identificate.UseVisualStyleBackColor = false;
            this.btn_identificate.Click += new System.EventHandler(this.btn_identificate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::USAP_MATRICULA.Properties.Resources.logo1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lbl_SisMatric
            // 
            resources.ApplyResources(this.lbl_SisMatric, "lbl_SisMatric");
            this.lbl_SisMatric.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_SisMatric.Name = "lbl_SisMatric";
            this.lbl_SisMatric.Click += new System.EventHandler(this.lbl_SisMatric_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Name = "label1";
            // 
            // picbx_Estud
            // 
            this.picbx_Estud.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.picbx_Estud, "picbx_Estud");
            this.picbx_Estud.Image = global::USAP_MATRICULA.Properties.Resources.Student_Male_100;
            this.picbx_Estud.Name = "picbx_Estud";
            this.picbx_Estud.TabStop = false;
            // 
            // picbx_Fondo
            // 
            this.picbx_Fondo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picbx_Fondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picbx_Fondo, "picbx_Fondo");
            this.picbx_Fondo.Name = "picbx_Fondo";
            this.picbx_Fondo.TabStop = false;
            // 
            // lbl_Bienv
            // 
            resources.ApplyResources(this.lbl_Bienv, "lbl_Bienv");
            this.lbl_Bienv.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Bienv.Name = "lbl_Bienv";
            // 
            // lbl_Nombre
            // 
            resources.ApplyResources(this.lbl_Nombre, "lbl_Nombre");
            this.lbl_Nombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Nombre.Name = "lbl_Nombre";
            // 
            // lbl_Nomb
            // 
            resources.ApplyResources(this.lbl_Nomb, "lbl_Nomb");
            this.lbl_Nomb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Nomb.Name = "lbl_Nomb";
            // 
            // frm_Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Nomb);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Bienv);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbx_Estud);
            this.Controls.Add(this.lbl_SisMatric);
            this.Controls.Add(this.picbx_Fondo);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
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
        private System.Windows.Forms.Label lbl_SisMatric;
        private System.Windows.Forms.PictureBox picbx_Estud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_identificate;
        private System.Windows.Forms.Label lbl_Nombre;
        public System.Windows.Forms.Label lbl_Bienv;
        public System.Windows.Forms.Label lbl_Nomb;
        public System.Windows.Forms.PictureBox picbx_Fondo;
    }
}

