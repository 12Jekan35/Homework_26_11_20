
namespace Homework_26_11_20.Views
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
            this.groupFormOpenButton = new System.Windows.Forms.Button();
            this.specialtiesFormOpenButton = new System.Windows.Forms.Button();
            this.studentFormOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupFormOpenButton
            // 
            this.groupFormOpenButton.Location = new System.Drawing.Point(45, 97);
            this.groupFormOpenButton.Name = "groupFormOpenButton";
            this.groupFormOpenButton.Size = new System.Drawing.Size(104, 23);
            this.groupFormOpenButton.TabIndex = 0;
            this.groupFormOpenButton.Text = "Группы";
            this.groupFormOpenButton.UseVisualStyleBackColor = true;
            // 
            // specialtiesFormOpenButton
            // 
            this.specialtiesFormOpenButton.Location = new System.Drawing.Point(45, 46);
            this.specialtiesFormOpenButton.Name = "specialtiesFormOpenButton";
            this.specialtiesFormOpenButton.Size = new System.Drawing.Size(104, 23);
            this.specialtiesFormOpenButton.TabIndex = 1;
            this.specialtiesFormOpenButton.Text = "Специальности";
            this.specialtiesFormOpenButton.UseVisualStyleBackColor = true;
            // 
            // studentFormOpenButton
            // 
            this.studentFormOpenButton.Location = new System.Drawing.Point(45, 152);
            this.studentFormOpenButton.Name = "studentFormOpenButton";
            this.studentFormOpenButton.Size = new System.Drawing.Size(104, 23);
            this.studentFormOpenButton.TabIndex = 2;
            this.studentFormOpenButton.Text = "Студенты";
            this.studentFormOpenButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 230);
            this.Controls.Add(this.studentFormOpenButton);
            this.Controls.Add(this.specialtiesFormOpenButton);
            this.Controls.Add(this.groupFormOpenButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button groupFormOpenButton;
        private System.Windows.Forms.Button specialtiesFormOpenButton;
        private System.Windows.Forms.Button studentFormOpenButton;
    }
}

