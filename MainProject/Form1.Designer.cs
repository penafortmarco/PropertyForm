
namespace MainProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbProperty = new System.Windows.Forms.GroupBox();
            this.tbNumStore = new System.Windows.Forms.TextBox();
            this.tbNumDept = new System.Windows.Forms.TextBox();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelWindw = new System.Windows.Forms.Label();
            this.rbStore = new System.Windows.Forms.RadioButton();
            this.rbDept = new System.Windows.Forms.RadioButton();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSquaM = new System.Windows.Forms.Label();
            this.tbAnt = new System.Windows.Forms.TextBox();
            this.labelOld = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.gbProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // gbProperty
            // 
            this.gbProperty.Controls.Add(this.tbNumStore);
            this.gbProperty.Controls.Add(this.tbNumDept);
            this.gbProperty.Controls.Add(this.labelDept);
            this.gbProperty.Controls.Add(this.labelWindw);
            this.gbProperty.Controls.Add(this.rbStore);
            this.gbProperty.Controls.Add(this.rbDept);
            this.gbProperty.Location = new System.Drawing.Point(12, 22);
            this.gbProperty.Name = "gbProperty";
            this.gbProperty.Size = new System.Drawing.Size(382, 181);
            this.gbProperty.TabIndex = 1;
            this.gbProperty.TabStop = false;
            this.gbProperty.Text = "Tipo de Inmueble";
            this.gbProperty.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbNumStore
            // 
            this.tbNumStore.Location = new System.Drawing.Point(225, 138);
            this.tbNumStore.Name = "tbNumStore";
            this.tbNumStore.Size = new System.Drawing.Size(100, 22);
            this.tbNumStore.TabIndex = 5;
            // 
            // tbNumDept
            // 
            this.tbNumDept.Location = new System.Drawing.Point(31, 138);
            this.tbNumDept.Name = "tbNumDept";
            this.tbNumDept.Size = new System.Drawing.Size(100, 22);
            this.tbNumDept.TabIndex = 4;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(31, 101);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(62, 17);
            this.labelDept.TabIndex = 3;
            this.labelDept.Text = "Nro Piso";
            // 
            // labelWindw
            // 
            this.labelWindw.AutoSize = true;
            this.labelWindw.Location = new System.Drawing.Point(230, 101);
            this.labelWindw.Name = "labelWindw";
            this.labelWindw.Size = new System.Drawing.Size(95, 17);
            this.labelWindw.TabIndex = 2;
            this.labelWindw.Text = "Nro Ventanas";
            // 
            // rbStore
            // 
            this.rbStore.AutoSize = true;
            this.rbStore.Location = new System.Drawing.Point(233, 45);
            this.rbStore.Name = "rbStore";
            this.rbStore.Size = new System.Drawing.Size(63, 21);
            this.rbStore.TabIndex = 1;
            this.rbStore.TabStop = true;
            this.rbStore.Text = "Local";
            this.rbStore.UseVisualStyleBackColor = true;
            // 
            // rbDept
            // 
            this.rbDept.AutoSize = true;
            this.rbDept.Location = new System.Drawing.Point(34, 45);
            this.rbDept.Name = "rbDept";
            this.rbDept.Size = new System.Drawing.Size(56, 21);
            this.rbDept.TabIndex = 0;
            this.rbDept.TabStop = true;
            this.rbDept.Text = "Piso";
            this.rbDept.UseVisualStyleBackColor = true;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(12, 246);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(71, 17);
            this.labelAdress.TabIndex = 2;
            this.labelAdress.Text = "Direccion:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 22);
            this.textBox1.TabIndex = 3;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(12, 317);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(75, 17);
            this.labelArea.TabIndex = 4;
            this.labelArea.Text = "Superficie:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 5;
            // 
            // labelSquaM
            // 
            this.labelSquaM.AutoSize = true;
            this.labelSquaM.Location = new System.Drawing.Point(93, 340);
            this.labelSquaM.Name = "labelSquaM";
            this.labelSquaM.Size = new System.Drawing.Size(37, 17);
            this.labelSquaM.TabIndex = 6;
            this.labelSquaM.Text = "(m2)";
            // 
            // tbAnt
            // 
            this.tbAnt.Location = new System.Drawing.Point(136, 337);
            this.tbAnt.Name = "tbAnt";
            this.tbAnt.Size = new System.Drawing.Size(100, 22);
            this.tbAnt.TabIndex = 7;
            this.tbAnt.TextChanged += new System.EventHandler(this.tbAnt_TextChanged);
            // 
            // labelOld
            // 
            this.labelOld.AutoSize = true;
            this.labelOld.Location = new System.Drawing.Point(149, 317);
            this.labelOld.Name = "labelOld";
            this.labelOld.Size = new System.Drawing.Size(80, 17);
            this.labelOld.TabIndex = 8;
            this.labelOld.Text = "Antiguedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Años";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(289, 335);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(296, 315);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(83, 17);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Precio base";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(44, 378);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(302, 62);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Calcular";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 493);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOld);
            this.Controls.Add(this.tbAnt);
            this.Controls.Add(this.labelSquaM);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.gbProperty);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbProperty.ResumeLayout(false);
            this.gbProperty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProperty;
        private System.Windows.Forms.RadioButton rbStore;
        private System.Windows.Forms.RadioButton rbDept;
        private System.Windows.Forms.TextBox tbNumStore;
        private System.Windows.Forms.TextBox tbNumDept;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelWindw;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelSquaM;
        private System.Windows.Forms.TextBox tbAnt;
        private System.Windows.Forms.Label labelOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

