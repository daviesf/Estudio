
namespace Estudio
{
    partial class Cad_Turma
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
            this.groupbox_1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupbox_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_1
            // 
            this.groupbox_1.Controls.Add(this.comboBox1);
            this.groupbox_1.Controls.Add(this.btnCadastrar);
            this.groupbox_1.Controls.Add(this.txtHora);
            this.groupbox_1.Controls.Add(this.txtDia);
            this.groupbox_1.Controls.Add(this.txtProfessor);
            this.groupbox_1.Controls.Add(this.label4);
            this.groupbox_1.Controls.Add(this.label3);
            this.groupbox_1.Controls.Add(this.label2);
            this.groupbox_1.Controls.Add(this.label1);
            this.groupbox_1.Location = new System.Drawing.Point(12, 12);
            this.groupbox_1.Name = "groupbox_1";
            this.groupbox_1.Size = new System.Drawing.Size(475, 179);
            this.groupbox_1.TabIndex = 1;
            this.groupbox_1.TabStop = false;
            this.groupbox_1.Text = "Turma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia da Semana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(104, 53);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(319, 20);
            this.txtProfessor.TabIndex = 5;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(104, 82);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(319, 20);
            this.txtDia.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(104, 109);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(319, 20);
            this.txtHora.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 145);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(463, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // Cad_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 205);
            this.Controls.Add(this.groupbox_1);
            this.Name = "Cad_Turma";
            this.Text = "Cadastrar Turma";
            this.groupbox_1.ResumeLayout(false);
            this.groupbox_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}