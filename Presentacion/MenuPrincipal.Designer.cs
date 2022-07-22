
namespace Sistema_de_asistencias.Presentacion
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panr = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.btnConsultas);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 450);
            this.panel1.TabIndex = 0;
            // 
            // panr
            // 
            this.panr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panr.Location = new System.Drawing.Point(195, 0);
            this.panr.Name = "panr";
            this.panr.Size = new System.Drawing.Size(680, 450);
            this.panr.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 88);
            this.panel3.TabIndex = 0;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(0, 88);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(195, 89);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "Pre planilla\r\n";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Location = new System.Drawing.Point(0, 177);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(195, 89);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(7, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 96);
            this.panel2.TabIndex = 3;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.panr);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panr;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel panel2;
    }
}