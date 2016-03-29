namespace GUI
{
    partial class FormCadastroAmigos
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labeldata = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataDesejo = new System.Windows.Forms.DateTimePicker();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.dataGridViewAmigo = new System.Windows.Forms.DataGridView();
            this.textBoxIDAmigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmigo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(78, 19);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(81, 54);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(35, 13);
            this.labelemail.TabIndex = 1;
            this.labelemail.Text = "Email:";
            // 
            // labeldata
            // 
            this.labeldata.AutoSize = true;
            this.labeldata.Location = new System.Drawing.Point(9, 84);
            this.labeldata.Name = "labeldata";
            this.labeldata.Size = new System.Drawing.Size(107, 13);
            this.labeldata.TabIndex = 2;
            this.labeldata.Text = "Data de Nascimento:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(122, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(122, 51);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(270, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // dateTimePickerDataDesejo
            // 
            this.dateTimePickerDataDesejo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDesejo.Location = new System.Drawing.Point(121, 78);
            this.dateTimePickerDataDesejo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDataDesejo.Name = "dateTimePickerDataDesejo";
            this.dateTimePickerDataDesejo.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerDataDesejo.TabIndex = 6;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(230, 105);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 10;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(110, 105);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 9;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // dataGridViewAmigo
            // 
            this.dataGridViewAmigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAmigo.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewAmigo.Name = "dataGridViewAmigo";
            this.dataGridViewAmigo.Size = new System.Drawing.Size(382, 150);
            this.dataGridViewAmigo.TabIndex = 11;
            // 
            // textBoxIDAmigo
            // 
            this.textBoxIDAmigo.Location = new System.Drawing.Point(230, 78);
            this.textBoxIDAmigo.Name = "textBoxIDAmigo";
            this.textBoxIDAmigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDAmigo.TabIndex = 12;
            this.textBoxIDAmigo.Text = "0";
            this.textBoxIDAmigo.Visible = false;
            // 
            // FormCadastroAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 295);
            this.Controls.Add(this.textBoxIDAmigo);
            this.Controls.Add(this.dataGridViewAmigo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.dateTimePickerDataDesejo);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labeldata);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelNome);
            this.Name = "FormCadastroAmigos";
            this.Text = "CadastroAmigos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labeldata;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDesejo;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.DataGridView dataGridViewAmigo;
        private System.Windows.Forms.TextBox textBoxIDAmigo;
    }
}