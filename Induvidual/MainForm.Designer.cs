namespace Induvidual
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewIntegral = new System.Windows.Forms.DataGridView();
            this.Formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftRectangle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightRectangle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Simpson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntegralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntegral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButtonClose,
            this.toolStripButtonSave,
            this.toolStripButtonOpen,
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete,
            this.toolStripButtonClear,
            this.toolStripButtonHelp});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStripHelp";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClose.Text = "toolStripButton5";
            this.toolStripButtonClose.ToolTipText = "Закрити";
            this.toolStripButtonClose.Click += new System.EventHandler(this.ToolStripButtonClose_Click);
            // 
            // dataGridViewIntegral
            // 
            this.dataGridViewIntegral.AllowUserToAddRows = false;
            this.dataGridViewIntegral.AllowUserToOrderColumns = true;
            this.dataGridViewIntegral.AutoGenerateColumns = false;
            this.dataGridViewIntegral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIntegral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Formula,
            this.Xmin,
            this.Xmax,
            this.Dx,
            this.LeftRectangle,
            this.RightRectangle,
            this.Trap,
            this.Simpson});
            this.dataGridViewIntegral.DataSource = this.IntegralBindingSource;
            this.dataGridViewIntegral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIntegral.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewIntegral.Name = "dataGridViewIntegral";
            this.dataGridViewIntegral.ReadOnly = true;
            this.dataGridViewIntegral.Size = new System.Drawing.Size(800, 425);
            this.dataGridViewIntegral.TabIndex = 1;
            // 
            // Formula
            // 
            this.Formula.DataPropertyName = "Formula";
            this.Formula.HeaderText = "Формула";
            this.Formula.Name = "Formula";
            this.Formula.ReadOnly = true;
            // 
            // Xmin
            // 
            this.Xmin.DataPropertyName = "Xmin";
            this.Xmin.HeaderText = "xmin";
            this.Xmin.Name = "Xmin";
            this.Xmin.ReadOnly = true;
            // 
            // Xmax
            // 
            this.Xmax.DataPropertyName = "Xmax";
            this.Xmax.HeaderText = "xmax";
            this.Xmax.Name = "Xmax";
            this.Xmax.ReadOnly = true;
            // 
            // Dx
            // 
            this.Dx.DataPropertyName = "Dx";
            this.Dx.HeaderText = "dx";
            this.Dx.Name = "Dx";
            this.Dx.ReadOnly = true;
            // 
            // LeftRectangle
            // 
            this.LeftRectangle.DataPropertyName = "LeftRectangle";
            this.LeftRectangle.HeaderText = "Лівих прямокутників";
            this.LeftRectangle.Name = "LeftRectangle";
            this.LeftRectangle.ReadOnly = true;
            // 
            // RightRectangle
            // 
            this.RightRectangle.DataPropertyName = "RightRectangle";
            this.RightRectangle.HeaderText = "Правих прямокутників";
            this.RightRectangle.Name = "RightRectangle";
            this.RightRectangle.ReadOnly = true;
            // 
            // Trap
            // 
            this.Trap.DataPropertyName = "Trap";
            this.Trap.HeaderText = "Трапецій";
            this.Trap.Name = "Trap";
            this.Trap.ReadOnly = true;
            // 
            // Simpson
            // 
            this.Simpson.DataPropertyName = "Simpson";
            this.Simpson.HeaderText = "Сімпсона";
            this.Simpson.Name = "Simpson";
            this.Simpson.ReadOnly = true;
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::Induvidual.Properties.Resources.Save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButtonSave";
            this.toolStripButtonSave.ToolTipText = "Зберегти в excel";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::Induvidual.Properties.Resources.Open;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "toolStripButtonSave";
            this.toolStripButtonOpen.ToolTipText = "Вiдкрити";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::Induvidual.Properties.Resources.Add;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "toolStripButton1";
            this.toolStripButtonAdd.ToolTipText = "Додати";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.ToolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = global::Induvidual.Properties.Resources.Edit;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "toolStripButton2";
            this.toolStripButtonEdit.ToolTipText = "Редагувати";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.ToolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "toolStripButton3";
            this.toolStripButtonDelete.ToolTipText = "Видалити";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.ToolStripButtonDelete_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Image = global::Induvidual.Properties.Resources.Close;
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClear.Text = "toolStripButton4";
            this.toolStripButtonClear.ToolTipText = "Очистити";
            this.toolStripButtonClear.Click += new System.EventHandler(this.ToolStripButtonClear_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = global::Induvidual.Properties.Resources.Help;
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHelp.Text = "toolStripButton4";
            this.toolStripButtonHelp.ToolTipText = "Про програму";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewIntegral);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iнтеграл";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntegral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegralBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.DataGridView dataGridViewIntegral;
        private System.Windows.Forms.BindingSource IntegralBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dx;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftRectangle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightRectangle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simpson;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
    }
}

