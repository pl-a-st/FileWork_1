namespace FileWork_1
{
    partial class FmMain
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
            this.cBSurname = new System.Windows.Forms.ComboBox();
            this.cBName = new System.Windows.Forms.ComboBox();
            this.cBMiddleName = new System.Windows.Forms.ComboBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.blbName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lBHumansList = new System.Windows.Forms.ListBox();
            this.btnWritePerson = new System.Windows.Forms.Button();
            this.btnNameAdd = new System.Windows.Forms.Button();
            this.btnSurameAdd = new System.Windows.Forms.Button();
            this.btnMidlenameAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBSurname
            // 
            this.cBSurname.FormattingEnabled = true;
            this.cBSurname.Location = new System.Drawing.Point(10, 36);
            this.cBSurname.Name = "cBSurname";
            this.cBSurname.Size = new System.Drawing.Size(121, 21);
            this.cBSurname.TabIndex = 0;
            // 
            // cBName
            // 
            this.cBName.FormattingEnabled = true;
            this.cBName.Location = new System.Drawing.Point(10, 85);
            this.cBName.Name = "cBName";
            this.cBName.Size = new System.Drawing.Size(121, 21);
            this.cBName.TabIndex = 0;
            // 
            // cBMiddleName
            // 
            this.cBMiddleName.FormattingEnabled = true;
            this.cBMiddleName.Location = new System.Drawing.Point(10, 133);
            this.cBMiddleName.Name = "cBMiddleName";
            this.cBMiddleName.Size = new System.Drawing.Size(121, 21);
            this.cBMiddleName.TabIndex = 0;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(10, 16);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Фамилия";
            // 
            // blbName
            // 
            this.blbName.AutoSize = true;
            this.blbName.Location = new System.Drawing.Point(10, 65);
            this.blbName.Name = "blbName";
            this.blbName.Size = new System.Drawing.Size(29, 13);
            this.blbName.TabIndex = 1;
            this.blbName.Text = "Имя";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(10, 113);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(54, 13);
            this.lblMiddleName.TabIndex = 1;
            this.lblMiddleName.Text = "Отчество";
            // 
            // lBHumansList
            // 
            this.lBHumansList.FormattingEnabled = true;
            this.lBHumansList.Location = new System.Drawing.Point(13, 177);
            this.lBHumansList.Name = "lBHumansList";
            this.lBHumansList.Size = new System.Drawing.Size(276, 134);
            this.lBHumansList.TabIndex = 2;
            // 
            // btnWritePerson
            // 
            this.btnWritePerson.Location = new System.Drawing.Point(183, 36);
            this.btnWritePerson.Name = "btnWritePerson";
            this.btnWritePerson.Size = new System.Drawing.Size(106, 50);
            this.btnWritePerson.TabIndex = 3;
            this.btnWritePerson.Text = "Внести в список товарища";
            this.btnWritePerson.UseVisualStyleBackColor = true;
            this.btnWritePerson.Click += new System.EventHandler(this.btnWritePerson_Click);
            // 
            // btnNameAdd
            // 
            this.btnNameAdd.Location = new System.Drawing.Point(140, 83);
            this.btnNameAdd.Name = "btnNameAdd";
            this.btnNameAdd.Size = new System.Drawing.Size(22, 23);
            this.btnNameAdd.TabIndex = 4;
            this.btnNameAdd.Text = "+";
            this.btnNameAdd.UseVisualStyleBackColor = true;
            this.btnNameAdd.Click += new System.EventHandler(this.btnNameAdd_Click);
            // 
            // btnSurameAdd
            // 
            this.btnSurameAdd.Location = new System.Drawing.Point(140, 34);
            this.btnSurameAdd.Name = "btnSurameAdd";
            this.btnSurameAdd.Size = new System.Drawing.Size(22, 23);
            this.btnSurameAdd.TabIndex = 4;
            this.btnSurameAdd.Text = "+";
            this.btnSurameAdd.UseVisualStyleBackColor = true;
            this.btnSurameAdd.Click += new System.EventHandler(this.btnSurameAdd_Click);
            // 
            // btnMidlenameAdd
            // 
            this.btnMidlenameAdd.Location = new System.Drawing.Point(140, 131);
            this.btnMidlenameAdd.Name = "btnMidlenameAdd";
            this.btnMidlenameAdd.Size = new System.Drawing.Size(22, 23);
            this.btnMidlenameAdd.TabIndex = 4;
            this.btnMidlenameAdd.Text = "+";
            this.btnMidlenameAdd.UseVisualStyleBackColor = true;
            this.btnMidlenameAdd.Click += new System.EventHandler(this.btnMidlenameAdd_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 338);
            this.Controls.Add(this.btnMidlenameAdd);
            this.Controls.Add(this.btnSurameAdd);
            this.Controls.Add(this.btnNameAdd);
            this.Controls.Add(this.btnWritePerson);
            this.Controls.Add(this.lBHumansList);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.blbName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.cBMiddleName);
            this.Controls.Add(this.cBName);
            this.Controls.Add(this.cBSurname);
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
      
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBSurname;
        private System.Windows.Forms.ComboBox cBName;
        private System.Windows.Forms.ComboBox cBMiddleName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label blbName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.ListBox lBHumansList;
        private System.Windows.Forms.Button btnWritePerson;
        private System.Windows.Forms.Button btnNameAdd;
        private System.Windows.Forms.Button btnSurameAdd;
        private System.Windows.Forms.Button btnMidlenameAdd;
    }
}

