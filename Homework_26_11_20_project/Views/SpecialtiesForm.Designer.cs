
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
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.refreshDataButton = new System.Windows.Forms.Button();
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
            this.specialtiesGridView.RowHeadersWidth = 60;
            this.specialtiesGridView.Size = new System.Drawing.Size(362, 227);
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
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addItemButton.Location = new System.Drawing.Point(12, 246);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(122, 34);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Добавить";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteItemButton.Location = new System.Drawing.Point(140, 246);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(122, 34);
            this.deleteItemButton.TabIndex = 2;
            this.deleteItemButton.Text = "Удалить";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshDataButton.Location = new System.Drawing.Point(287, 245);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(87, 35);
            this.refreshDataButton.TabIndex = 3;
            this.refreshDataButton.Text = "Обновить";
            this.refreshDataButton.UseVisualStyleBackColor = true;
            // 
            // SpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 292);
            this.Controls.Add(this.refreshDataButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.specialtiesGridView);
            this.MinimumSize = new System.Drawing.Size(402, 331);
            this.Name = "SpecialtiesForm";
            this.Text = "Специальности";
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView specialtiesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button refreshDataButton;
    }
}