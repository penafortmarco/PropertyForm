
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
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.tbSqm = new System.Windows.Forms.TextBox();
            this.labelSquaM = new System.Windows.Forms.Label();
            this.tbAnt = new System.Windows.Forms.TextBox();
            this.labelOld = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.basePrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelFinalPrice = new System.Windows.Forms.Label();
            this.gbProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
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
            this.gbProperty.Location = new System.Drawing.Point(9, 18);
            this.gbProperty.Margin = new System.Windows.Forms.Padding(2);
            this.gbProperty.Name = "gbProperty";
            this.gbProperty.Padding = new System.Windows.Forms.Padding(2);
            this.gbProperty.Size = new System.Drawing.Size(286, 147);
            this.gbProperty.TabIndex = 1;
            this.gbProperty.TabStop = false;
            this.gbProperty.Text = "Tipo de Inmueble";
            // 
            // tbNumStore
            // 
            this.tbNumStore.Location = new System.Drawing.Point(169, 112);
            this.tbNumStore.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumStore.Name = "tbNumStore";
            this.tbNumStore.Size = new System.Drawing.Size(76, 20);
            this.tbNumStore.TabIndex = 5;
            // 
            // tbNumDept
            // 
            this.tbNumDept.Location = new System.Drawing.Point(23, 112);
            this.tbNumDept.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumDept.Name = "tbNumDept";
            this.tbNumDept.Size = new System.Drawing.Size(76, 20);
            this.tbNumDept.TabIndex = 4;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(23, 82);
            this.labelDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(47, 13);
            this.labelDept.TabIndex = 3;
            this.labelDept.Text = "Nro Piso";
            // 
            // labelWindw
            // 
            this.labelWindw.AutoSize = true;
            this.labelWindw.Location = new System.Drawing.Point(172, 82);
            this.labelWindw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWindw.Name = "labelWindw";
            this.labelWindw.Size = new System.Drawing.Size(72, 13);
            this.labelWindw.TabIndex = 2;
            this.labelWindw.Text = "Nro Ventanas";
            // 
            // rbStore
            // 
            this.rbStore.AutoSize = true;
            this.rbStore.Location = new System.Drawing.Point(175, 37);
            this.rbStore.Margin = new System.Windows.Forms.Padding(2);
            this.rbStore.Name = "rbStore";
            this.rbStore.Size = new System.Drawing.Size(51, 17);
            this.rbStore.TabIndex = 1;
            this.rbStore.TabStop = true;
            this.rbStore.Text = "Local";
            this.rbStore.UseVisualStyleBackColor = true;
            this.rbStore.CheckedChanged += new System.EventHandler(this.rbStoreChecked);
            // 
            // rbDept
            // 
            this.rbDept.AutoSize = true;
            this.rbDept.Location = new System.Drawing.Point(26, 37);
            this.rbDept.Margin = new System.Windows.Forms.Padding(2);
            this.rbDept.Name = "rbDept";
            this.rbDept.Size = new System.Drawing.Size(45, 17);
            this.rbDept.TabIndex = 0;
            this.rbDept.TabStop = true;
            this.rbDept.Text = "Piso";
            this.rbDept.UseVisualStyleBackColor = true;
            this.rbDept.CheckedChanged += new System.EventHandler(this.rbDepartmentChecked);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(9, 200);
            this.labelAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(55, 13);
            this.labelAdress.TabIndex = 2;
            this.labelAdress.Text = "Direccion:";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(11, 217);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(285, 20);
            this.tbAdress.TabIndex = 3;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(9, 258);
            this.labelArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(57, 13);
            this.labelArea.TabIndex = 4;
            this.labelArea.Text = "Superficie:";
            // 
            // tbSqm
            // 
            this.tbSqm.Location = new System.Drawing.Point(9, 274);
            this.tbSqm.Margin = new System.Windows.Forms.Padding(2);
            this.tbSqm.Name = "tbSqm";
            this.tbSqm.Size = new System.Drawing.Size(57, 20);
            this.tbSqm.TabIndex = 5;
            // 
            // labelSquaM
            // 
            this.labelSquaM.AutoSize = true;
            this.labelSquaM.Location = new System.Drawing.Point(70, 276);
            this.labelSquaM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSquaM.Name = "labelSquaM";
            this.labelSquaM.Size = new System.Drawing.Size(27, 13);
            this.labelSquaM.TabIndex = 6;
            this.labelSquaM.Text = "(m2)";
            // 
            // tbAnt
            // 
            this.tbAnt.Location = new System.Drawing.Point(102, 274);
            this.tbAnt.Margin = new System.Windows.Forms.Padding(2);
            this.tbAnt.Name = "tbAnt";
            this.tbAnt.Size = new System.Drawing.Size(76, 20);
            this.tbAnt.TabIndex = 7;
            this.tbAnt.TextChanged += new System.EventHandler(this.tbAnt_TextChanged);
            // 
            // labelOld
            // 
            this.labelOld.AutoSize = true;
            this.labelOld.Location = new System.Drawing.Point(112, 258);
            this.labelOld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOld.Name = "labelOld";
            this.labelOld.Size = new System.Drawing.Size(61, 13);
            this.labelOld.TabIndex = 8;
            this.labelOld.Text = "Antiguedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Años";
            // 
            // basePrice
            // 
            this.basePrice.Location = new System.Drawing.Point(217, 272);
            this.basePrice.Margin = new System.Windows.Forms.Padding(2);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(76, 20);
            this.basePrice.TabIndex = 10;
            this.basePrice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(222, 256);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(63, 13);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Precio base";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(33, 307);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(226, 50);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Calcular";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelFinalPrice
            // 
            this.labelFinalPrice.AutoSize = true;
            this.labelFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalPrice.Location = new System.Drawing.Point(12, 369);
            this.labelFinalPrice.Name = "labelFinalPrice";
            this.labelFinalPrice.Size = new System.Drawing.Size(0, 17);
            this.labelFinalPrice.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 427);
            this.Controls.Add(this.labelFinalPrice);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.basePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOld);
            this.Controls.Add(this.tbAnt);
            this.Controls.Add(this.labelSquaM);
            this.Controls.Add(this.tbSqm);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.gbProperty);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox tbSqm;
        private System.Windows.Forms.Label labelSquaM;
        private System.Windows.Forms.TextBox tbAnt;
        private System.Windows.Forms.Label labelOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox basePrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelFinalPrice;
    }
}

