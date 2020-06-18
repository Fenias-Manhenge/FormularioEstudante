namespace FormularioEstudante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListView();
            this.lstCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TURMA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONTACTO";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(121, 24);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(151, 20);
            this.txtCode.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(121, 86);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(151, 20);
            this.txtClass.TabIndex = 6;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(121, 114);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(151, 20);
            this.txtContact.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(333, 24);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(333, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(333, 54);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(89, 23);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "Listar";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lstList
            // 
            this.lstList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstCode,
            this.lstName,
            this.lstClass,
            this.lstContact});
            this.lstList.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstList.HideSelection = false;
            this.lstList.Location = new System.Drawing.Point(53, 162);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(620, 171);
            this.lstList.TabIndex = 11;
            this.lstList.UseCompatibleStateImageBehavior = false;
            this.lstList.View = System.Windows.Forms.View.Details;
            // 
            // lstCode
            // 
            this.lstCode.Text = "CODIGO";
            this.lstCode.Width = 117;
            // 
            // lstName
            // 
            this.lstName.Text = "NOME";
            this.lstName.Width = 265;
            // 
            // lstClass
            // 
            this.lstClass.Text = "TURMA";
            this.lstClass.Width = 103;
            // 
            // lstContact
            // 
            this.lstContact.Text = "CONTACTO";
            this.lstContact.Width = 132;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CADASTRAR ESTUDANTE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListView lstList;
        private System.Windows.Forms.ColumnHeader lstCode;
        private System.Windows.Forms.ColumnHeader lstName;
        private System.Windows.Forms.ColumnHeader lstClass;
        private System.Windows.Forms.ColumnHeader lstContact;
    }
}

