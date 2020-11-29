
namespace Homework_26_11_20.Views
{
    partial class GroupsForm
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
            this.refreshDataButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.groupsGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshDataButton.Location = new System.Drawing.Point(294, 246);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(87, 35);
            this.refreshDataButton.TabIndex = 7;
            this.refreshDataButton.Text = "Обновить";
            this.refreshDataButton.UseVisualStyleBackColor = true;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteItemButton.Location = new System.Drawing.Point(133, 247);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(122, 34);
            this.deleteItemButton.TabIndex = 6;
            this.deleteItemButton.Text = "Удалить";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addItemButton.Location = new System.Drawing.Point(5, 247);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(122, 34);
            this.addItemButton.TabIndex = 5;
            this.addItemButton.Text = "Добавить";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // groupsGridView
            // 
            this.groupsGridView.AllowUserToOrderColumns = true;
            this.groupsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.YearColumn,
            this.SpecialtyColumn});
            this.groupsGridView.Location = new System.Drawing.Point(5, 13);
            this.groupsGridView.Name = "groupsGridView";
            this.groupsGridView.RowHeadersWidth = 60;
            this.groupsGridView.Size = new System.Drawing.Size(376, 227);
            this.groupsGridView.TabIndex = 4;
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
            // YearColumn
            // 
            this.YearColumn.DataPropertyName = "Year";
            this.YearColumn.HeaderText = "Год";
            this.YearColumn.Name = "YearColumn";
            // 
            // SpecialtyColumn
            // 
            this.SpecialtyColumn.DataPropertyName = "Specialty.Name";
            this.SpecialtyColumn.HeaderText = "Специальность";
            this.SpecialtyColumn.Name = "SpecialtyColumn";
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 295);
            this.Controls.Add(this.refreshDataButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.groupsGridView);
            this.MinimumSize = new System.Drawing.Size(402, 331);
            this.Name = "GroupsForm";
            this.Text = "Группы";
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refreshDataButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.DataGridView groupsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn SpecialtyColumn;
    }
}