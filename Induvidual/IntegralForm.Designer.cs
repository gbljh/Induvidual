namespace Induvidual
{
    partial class IntegralForm
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
            this.components = new System.ComponentModel.Container();
            this.labelFormula = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelXmax = new System.Windows.Forms.Label();
            this.labelXmin = new System.Windows.Forms.Label();
            this.labelDx = new System.Windows.Forms.Label();
            this.textBoxFormula = new System.Windows.Forms.TextBox();
            this.checkBoxLeftRectangle = new System.Windows.Forms.CheckBox();
            this.checkBoxRightRectangle = new System.Windows.Forms.CheckBox();
            this.checkBoxTrap = new System.Windows.Forms.CheckBox();
            this.checkBoxSimpson = new System.Windows.Forms.CheckBox();
            this.groupMethods = new System.Windows.Forms.GroupBox();
            this.textBoxXmin = new System.Windows.Forms.TextBox();
            this.textBoxXmax = new System.Windows.Forms.TextBox();
            this.textBoxDx = new System.Windows.Forms.TextBox();
            this.IntegralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupMethods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntegralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFormula
            // 
            this.labelFormula.AutoSize = true;
            this.labelFormula.Location = new System.Drawing.Point(17, 21);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(58, 13);
            this.labelFormula.TabIndex = 0;
            this.labelFormula.Text = "Формула:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 219);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(129, 219);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelXmax
            // 
            this.labelXmax.AutoSize = true;
            this.labelXmax.Location = new System.Drawing.Point(126, 55);
            this.labelXmax.Name = "labelXmax";
            this.labelXmax.Size = new System.Drawing.Size(34, 13);
            this.labelXmax.TabIndex = 5;
            this.labelXmax.Text = "xmax:";
            // 
            // labelXmin
            // 
            this.labelXmin.AutoSize = true;
            this.labelXmin.Location = new System.Drawing.Point(21, 55);
            this.labelXmin.Name = "labelXmin";
            this.labelXmin.Size = new System.Drawing.Size(31, 13);
            this.labelXmin.TabIndex = 7;
            this.labelXmin.Text = "xmin:";
            // 
            // labelDx
            // 
            this.labelDx.AutoSize = true;
            this.labelDx.Location = new System.Drawing.Point(237, 58);
            this.labelDx.Name = "labelDx";
            this.labelDx.Size = new System.Drawing.Size(21, 13);
            this.labelDx.TabIndex = 9;
            this.labelDx.Text = "dx:";
            // 
            // textBoxFormula
            // 
            this.textBoxFormula.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntegralBindingSource, "Formula", true));
            this.textBoxFormula.Location = new System.Drawing.Point(115, 18);
            this.textBoxFormula.Name = "textBoxFormula";
            this.textBoxFormula.Size = new System.Drawing.Size(198, 20);
            this.textBoxFormula.TabIndex = 14;
            this.textBoxFormula.Text = "Xmin";
            // 
            // checkBoxLeftRectangle
            // 
            this.checkBoxLeftRectangle.AutoSize = true;
            this.checkBoxLeftRectangle.Location = new System.Drawing.Point(5, 31);
            this.checkBoxLeftRectangle.Name = "checkBoxLeftRectangle";
            this.checkBoxLeftRectangle.Size = new System.Drawing.Size(130, 17);
            this.checkBoxLeftRectangle.TabIndex = 18;
            this.checkBoxLeftRectangle.Text = "Лівих прямокутників";
            this.checkBoxLeftRectangle.UseVisualStyleBackColor = true;
            // 
            // checkBoxRightRectangle
            // 
            this.checkBoxRightRectangle.AutoSize = true;
            this.checkBoxRightRectangle.Location = new System.Drawing.Point(152, 31);
            this.checkBoxRightRectangle.Name = "checkBoxRightRectangle";
            this.checkBoxRightRectangle.Size = new System.Drawing.Size(140, 17);
            this.checkBoxRightRectangle.TabIndex = 20;
            this.checkBoxRightRectangle.Text = "Правих прямокутників";
            this.checkBoxRightRectangle.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrap
            // 
            this.checkBoxTrap.AutoSize = true;
            this.checkBoxTrap.Location = new System.Drawing.Point(5, 63);
            this.checkBoxTrap.Name = "checkBoxTrap";
            this.checkBoxTrap.Size = new System.Drawing.Size(71, 17);
            this.checkBoxTrap.TabIndex = 21;
            this.checkBoxTrap.Text = "Трапецій";
            this.checkBoxTrap.UseVisualStyleBackColor = true;
            // 
            // checkBoxSimpson
            // 
            this.checkBoxSimpson.AutoSize = true;
            this.checkBoxSimpson.Location = new System.Drawing.Point(151, 63);
            this.checkBoxSimpson.Name = "checkBoxSimpson";
            this.checkBoxSimpson.Size = new System.Drawing.Size(73, 17);
            this.checkBoxSimpson.TabIndex = 22;
            this.checkBoxSimpson.Text = "Сімпсона";
            this.checkBoxSimpson.UseVisualStyleBackColor = true;
            // 
            // groupMethods
            // 
            this.groupMethods.Controls.Add(this.checkBoxSimpson);
            this.groupMethods.Controls.Add(this.checkBoxLeftRectangle);
            this.groupMethods.Controls.Add(this.checkBoxTrap);
            this.groupMethods.Controls.Add(this.checkBoxRightRectangle);
            this.groupMethods.Location = new System.Drawing.Point(15, 90);
            this.groupMethods.Name = "groupMethods";
            this.groupMethods.Size = new System.Drawing.Size(298, 103);
            this.groupMethods.TabIndex = 23;
            this.groupMethods.TabStop = false;
            this.groupMethods.Text = "Методи інтегрування";
            // 
            // textBoxXmin
            // 
            this.textBoxXmin.Location = new System.Drawing.Point(58, 55);
            this.textBoxXmin.Name = "textBoxXmin";
            this.textBoxXmin.Size = new System.Drawing.Size(52, 20);
            this.textBoxXmin.TabIndex = 24;
            // 
            // textBoxXmax
            // 
            this.textBoxXmax.Location = new System.Drawing.Point(166, 55);
            this.textBoxXmax.Name = "textBoxXmax";
            this.textBoxXmax.Size = new System.Drawing.Size(52, 20);
            this.textBoxXmax.TabIndex = 25;
            // 
            // textBoxDx
            // 
            this.textBoxDx.Location = new System.Drawing.Point(264, 55);
            this.textBoxDx.Name = "textBoxDx";
            this.textBoxDx.Size = new System.Drawing.Size(52, 20);
            this.textBoxDx.TabIndex = 26;
            // 
            // IntegralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 286);
            this.Controls.Add(this.textBoxDx);
            this.Controls.Add(this.textBoxXmax);
            this.Controls.Add(this.textBoxXmin);
            this.Controls.Add(this.groupMethods);
            this.Controls.Add(this.textBoxFormula);
            this.Controls.Add(this.labelDx);
            this.Controls.Add(this.labelXmin);
            this.Controls.Add(this.labelXmax);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelFormula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IntegralForm";
            this.Text = "Введення формули";
            this.groupMethods.ResumeLayout(false);
            this.groupMethods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntegralBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelXmax;
        private System.Windows.Forms.Label labelXmin;
        private System.Windows.Forms.Label labelDx;
        private System.Windows.Forms.BindingSource IntegralBindingSource;
        private System.Windows.Forms.TextBox textBoxFormula;
        private System.Windows.Forms.CheckBox checkBoxLeftRectangle;
        private System.Windows.Forms.CheckBox checkBoxRightRectangle;
        private System.Windows.Forms.CheckBox checkBoxTrap;
        private System.Windows.Forms.CheckBox checkBoxSimpson;
        private System.Windows.Forms.GroupBox groupMethods;
        private System.Windows.Forms.TextBox textBoxXmin;
        private System.Windows.Forms.TextBox textBoxXmax;
        private System.Windows.Forms.TextBox textBoxDx;
    }
}