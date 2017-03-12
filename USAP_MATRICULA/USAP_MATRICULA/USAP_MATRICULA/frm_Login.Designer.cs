namespace USAP_MATRICULA
{
    partial class frm_Login
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
            this.txtbx_Cuenta = new System.Windows.Forms.TextBox();
            this.lbl_NumCuent = new System.Windows.Forms.Label();
            this.btn_Acept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_Cuenta
            // 
            this.txtbx_Cuenta.Location = new System.Drawing.Point(114, 74);
            this.txtbx_Cuenta.MaxLength = 7;
            this.txtbx_Cuenta.Name = "txtbx_Cuenta";
            this.txtbx_Cuenta.Size = new System.Drawing.Size(152, 22);
            this.txtbx_Cuenta.TabIndex = 0;
            this.txtbx_Cuenta.TextChanged += new System.EventHandler(this.txtbx_Cuenta_TextChanged);
            this.txtbx_Cuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_NumCuent
            // 
            this.lbl_NumCuent.AutoSize = true;
            this.lbl_NumCuent.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumCuent.Location = new System.Drawing.Point(83, 37);
            this.lbl_NumCuent.Name = "lbl_NumCuent";
            this.lbl_NumCuent.Size = new System.Drawing.Size(227, 25);
            this.lbl_NumCuent.TabIndex = 1;
            this.lbl_NumCuent.Text = "Número de Cuenta:";
            // 
            // btn_Acept
            // 
            this.btn_Acept.Location = new System.Drawing.Point(146, 115);
            this.btn_Acept.Name = "btn_Acept";
            this.btn_Acept.Size = new System.Drawing.Size(75, 27);
            this.btn_Acept.TabIndex = 2;
            this.btn_Acept.Text = "Aceptar";
            this.btn_Acept.UseVisualStyleBackColor = true;
            this.btn_Acept.Click += new System.EventHandler(this.btn_Acept_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 164);
            this.Controls.Add(this.btn_Acept);
            this.Controls.Add(this.lbl_NumCuent);
            this.Controls.Add(this.txtbx_Cuenta);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identifícate";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_Cuenta;
        private System.Windows.Forms.Label lbl_NumCuent;
        private System.Windows.Forms.Button btn_Acept;
    }
}