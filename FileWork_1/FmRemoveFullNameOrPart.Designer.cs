namespace FileWork_1
{
    partial class FmRemoveFullNameOrPart
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
            this.lbListFullNamePart = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSaveRemove = new System.Windows.Forms.Button();
            this.btnCancelRemove = new System.Windows.Forms.Button();
            this.chBRemoveAllPerson = new System.Windows.Forms.CheckBox();
            this.lbListChangeRemove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbListFullNamePart
            // 
            this.lbListFullNamePart.FormattingEnabled = true;
            this.lbListFullNamePart.Location = new System.Drawing.Point(12, 23);
            this.lbListFullNamePart.Name = "lbListFullNamePart";
            this.lbListFullNamePart.Size = new System.Drawing.Size(175, 238);
            this.lbListFullNamePart.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(198, 23);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(157, 26);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSaveRemove
            // 
            this.btnSaveRemove.Location = new System.Drawing.Point(193, 235);
            this.btnSaveRemove.Name = "btnSaveRemove";
            this.btnSaveRemove.Size = new System.Drawing.Size(79, 26);
            this.btnSaveRemove.TabIndex = 1;
            this.btnSaveRemove.Text = "Сохранить";
            this.btnSaveRemove.UseVisualStyleBackColor = true;
            this.btnSaveRemove.Click += new System.EventHandler(this.btnSaveRemove_Click);
            // 
            // btnCancelRemove
            // 
            this.btnCancelRemove.Location = new System.Drawing.Point(278, 235);
            this.btnCancelRemove.Name = "btnCancelRemove";
            this.btnCancelRemove.Size = new System.Drawing.Size(79, 26);
            this.btnCancelRemove.TabIndex = 1;
            this.btnCancelRemove.Text = "Отменить";
            this.btnCancelRemove.UseVisualStyleBackColor = true;
            this.btnCancelRemove.Click += new System.EventHandler(this.btnCancelRemove_Click);
            // 
            // chBRemoveAllPerson
            // 
            this.chBRemoveAllPerson.AutoSize = true;
            this.chBRemoveAllPerson.Location = new System.Drawing.Point(192, 191);
            this.chBRemoveAllPerson.Name = "chBRemoveAllPerson";
            this.chBRemoveAllPerson.Size = new System.Drawing.Size(80, 17);
            this.chBRemoveAllPerson.TabIndex = 2;
            this.chBRemoveAllPerson.Text = "checkBox1";
            this.chBRemoveAllPerson.UseVisualStyleBackColor = true;
            // 
            // lbListChangeRemove
            // 
            this.lbListChangeRemove.AutoSize = true;
            this.lbListChangeRemove.Location = new System.Drawing.Point(9, 7);
            this.lbListChangeRemove.Name = "lbListChangeRemove";
            this.lbListChangeRemove.Size = new System.Drawing.Size(170, 13);
            this.lbListChangeRemove.TabIndex = 3;
            this.lbListChangeRemove.Text = "Выберите строчку для удаления";
            // 
            // FmRemoveFullNameOrPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 273);
            this.Controls.Add(this.lbListChangeRemove);
            this.Controls.Add(this.chBRemoveAllPerson);
            this.Controls.Add(this.btnCancelRemove);
            this.Controls.Add(this.btnSaveRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbListFullNamePart);
            this.Name = "FmRemoveFullNameOrPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmRemoveFullNameOrPart";
            this.Load += new System.EventHandler(this.FmRemoveFullNameOrPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListFullNamePart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSaveRemove;
        private System.Windows.Forms.Button btnCancelRemove;
        public System.Windows.Forms.CheckBox chBRemoveAllPerson;
        public System.Windows.Forms.Label lbListChangeRemove;
    }
}