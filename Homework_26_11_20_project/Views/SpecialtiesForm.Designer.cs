
namespace Homework_26_11_20.Views
{
    partial class SpecialtiesForm
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
            this.specialtiesGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // specialtiesGridView
            // 
            this.specialtiesGridView.AllowUserToOrderColumns = true;
            this.specialtiesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specialtiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialtiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.CodeColumn});
            this.specialtiesGridView.Location = new System.Drawing.Point(12, 12);
            this.specialtiesGridView.Name = "specialtiesGridView";
            this.specialtiesGridView.Size = new System.Drawing.Size(535, 322);
            this.specialtiesGridView.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "№";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            // 
            // CodeColumn
            // 
            this.CodeColumn.DataPropertyName = "Code";
            this.CodeColumn.HeaderText = "Шифр";
            this.CodeColumn.Name = "CodeColumn";
            // 
            // SpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 387);
            this.Controls.Add(this.specialtiesGridView);
            this.Name = "SpecialtiesForm";
            this.Text = "SpecialtiesForm";
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView specialtiesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
    }
}