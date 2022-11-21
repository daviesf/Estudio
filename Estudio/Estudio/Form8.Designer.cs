
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
            this.chSexta = new System.Windows.Forms.CheckBox();
            this.chSabado = new System.Windows.Forms.CheckBox();
            this.chQuarta = new System.Windows.Forms.CheckBox();
            this.chQuinta = new System.Windows.Forms.CheckBox();
            this.chTerca = new System.Windows.Forms.CheckBox();
            this.chSegunda = new System.Windows.Forms.CheckBox();
            this.chDomingo = new System.Windows.Forms.CheckBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_1
            // 
            this.groupbox_1.Controls.Add(this.chSexta);
            this.groupbox_1.Controls.Add(this.chSabado);
            this.groupbox_1.Controls.Add(this.chQuarta);
            this.groupbox_1.Controls.Add(this.chQuinta);
            this.groupbox_1.Controls.Add(this.chTerca);
            this.groupbox_1.Controls.Add(this.chSegunda);
            this.groupbox_1.Controls.Add(this.chDomingo);
            this.groupbox_1.Controls.Add(this.dtpHora);
            this.groupbox_1.Controls.Add(this.cbModalidade);
            this.groupbox_1.Controls.Add(this.btnCadastrar);
            this.groupbox_1.Controls.Add(this.txtProfessor);
            this.groupbox_1.Controls.Add(this.label4);
            this.groupbox_1.Controls.Add(this.label3);
            this.groupbox_1.Controls.Add(this.label2);
            this.groupbox_1.Controls.Add(this.label1);
            this.groupbox_1.Location = new System.Drawing.Point(12, 12);
            this.groupbox_1.Name = "groupbox_1";
            this.groupbox_1.Size = new System.Drawing.Size(437, 218);
            this.groupbox_1.TabIndex = 1;
            this.groupbox_1.TabStop = false;
            this.groupbox_1.Text = "Turma";
            // 
            // chSexta
            // 
            this.chSexta.AutoSize = true;
            this.chSexta.Location = new System.Drawing.Point(177, 105);
            this.chSexta.Name = "chSexta";
            this.chSexta.Size = new System.Drawing.Size(53, 17);
            this.chSexta.TabIndex = 16;
            this.chSexta.Text = "Sexta";
            this.chSexta.UseVisualStyleBackColor = true;
            // 
            // chSabado
            // 
            this.chSabado.AutoSize = true;
            this.chSabado.Location = new System.Drawing.Point(252, 82);
            this.chSabado.Name = "chSabado";
            this.chSabado.Size = new System.Drawing.Size(63, 17);
            this.chSabado.TabIndex = 15;
            this.chSabado.Text = "Sábado";
            this.chSabado.UseVisualStyleBackColor = true;
            // 
            // chQuarta
            // 
            this.chQuarta.AutoSize = true;
            this.chQuarta.Location = new System.Drawing.Point(104, 128);
            this.chQuarta.Name = "chQuarta";
            this.chQuarta.Size = new System.Drawing.Size(58, 17);
            this.chQuarta.TabIndex = 14;
            this.chQuarta.Text = "Quarta";
            this.chQuarta.UseVisualStyleBackColor = true;
            // 
            // chQuinta
            // 
            this.chQuinta.AutoSize = true;
            this.chQuinta.Location = new System.Drawing.Point(177, 82);
            this.chQuinta.Name = "chQuinta";
            this.chQuinta.Size = new System.Drawing.Size(57, 17);
            this.chQuinta.TabIndex = 13;
            this.chQuinta.Text = "Quinta";
            this.chQuinta.UseVisualStyleBackColor = true;
            // 
            // chTerca
            // 
            this.chTerca.AutoSize = true;
            this.chTerca.Location = new System.Drawing.Point(104, 105);
            this.chTerca.Name = "chTerca";
            this.chTerca.Size = new System.Drawing.Size(54, 17);
            this.chTerca.TabIndex = 12;
            this.chTerca.Text = "Terça";
            this.chTerca.UseVisualStyleBackColor = true;
            // 
            // chSegunda
            // 
            this.chSegunda.AutoSize = true;
            this.chSegunda.Location = new System.Drawing.Point(104, 82);
            this.chSegunda.Name = "chSegunda";
            this.chSegunda.Size = new System.Drawing.Size(69, 17);
            this.chSegunda.TabIndex = 11;
            this.chSegunda.Text = "Segunda";
            this.chSegunda.UseVisualStyleBackColor = true;
            // 
            // chDomingo
            // 
            this.chDomingo.AutoSize = true;
            this.chDomingo.Location = new System.Drawing.Point(252, 105);
            this.chDomingo.Name = "chDomingo";
            this.chDomingo.Size = new System.Drawing.Size(68, 17);
            this.chDomingo.TabIndex = 10;
            this.chDomingo.Text = "Domingo";
            this.chDomingo.UseVisualStyleBackColor = true;
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "hh:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHora.Location = new System.Drawing.Point(104, 157);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(69, 20);
            this.dtpHora.TabIndex = 9;
            // 
            // cbModalidade
            // 
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Location = new System.Drawing.Point(104, 22);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(320, 21);
            this.cbModalidade.TabIndex = 2;
            this.cbModalidade.SelectedIndexChanged += new System.EventHandler(this.cbModalidade_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 183);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(425, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(104, 53);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(320, 20);
            this.txtProfessor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // Cad_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 240);
            this.Controls.Add(this.groupbox_1);
            this.Name = "Cad_Turma";
            this.Text = "Cadastrar Turma";
            this.groupbox_1.ResumeLayout(false);
            this.groupbox_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_1;
        private System.Windows.Forms.ComboBox cbModalidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chSexta;
        private System.Windows.Forms.CheckBox chSabado;
        private System.Windows.Forms.CheckBox chQuarta;
        private System.Windows.Forms.CheckBox chQuinta;
        private System.Windows.Forms.CheckBox chTerca;
        private System.Windows.Forms.CheckBox chSegunda;
        private System.Windows.Forms.CheckBox chDomingo;
        private System.Windows.Forms.DateTimePicker dtpHora;
    }
}