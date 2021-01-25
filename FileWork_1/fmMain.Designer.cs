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
            this.RBMail = new System.Windows.Forms.RadioButton();
            this.RBFemaill = new System.Windows.Forms.RadioButton();
            this.btnSurnameRemove = new System.Windows.Forms.Button();
            this.btnNameRemove = new System.Windows.Forms.Button();
            this.btnMidlenameRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.btnFunctionAdd = new System.Windows.Forms.Button();
            this.btnFunctionRemove = new System.Windows.Forms.Button();
            this.lbFunction = new System.Windows.Forms.Label();
            this.cBFunction = new System.Windows.Forms.ComboBox();
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
            this.lBHumansList.Location = new System.Drawing.Point(10, 224);
            this.lBHumansList.Name = "lBHumansList";
            this.lBHumansList.Size = new System.Drawing.Size(300, 134);
            this.lBHumansList.TabIndex = 2;
            // 
            // btnWritePerson
            // 
            this.btnWritePerson.Location = new System.Drawing.Point(204, 104);
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
            // RBMail
            // 
            this.RBMail.AutoSize = true;
            this.RBMail.Location = new System.Drawing.Point(204, 44);
            this.RBMail.Name = "RBMail";
            this.RBMail.Size = new System.Drawing.Size(72, 17);
            this.RBMail.TabIndex = 5;
            this.RBMail.Text = "Мужчины";
            this.RBMail.UseVisualStyleBackColor = true;
            this.RBMail.CheckedChanged += new System.EventHandler(this.RBMail_CheckedChanged);
            // 
            // RBFemaill
            // 
            this.RBFemaill.AutoSize = true;
            this.RBFemaill.Location = new System.Drawing.Point(204, 67);
            this.RBFemaill.Name = "RBFemaill";
            this.RBFemaill.Size = new System.Drawing.Size(77, 17);
            this.RBFemaill.TabIndex = 6;
            this.RBFemaill.Text = "Женщины";
            this.RBFemaill.UseVisualStyleBackColor = true;
            this.RBFemaill.CheckedChanged += new System.EventHandler(this.RBFemaill_CheckedChanged);
            // 
            // btnSurnameRemove
            // 
            this.btnSurnameRemove.Location = new System.Drawing.Point(163, 34);
            this.btnSurnameRemove.Name = "btnSurnameRemove";
            this.btnSurnameRemove.Size = new System.Drawing.Size(22, 23);
            this.btnSurnameRemove.TabIndex = 4;
            this.btnSurnameRemove.Text = "-";
            this.btnSurnameRemove.UseVisualStyleBackColor = true;
            this.btnSurnameRemove.Click += new System.EventHandler(this.btnSurnameRemove_Click);
            // 
            // btnNameRemove
            // 
            this.btnNameRemove.Location = new System.Drawing.Point(163, 83);
            this.btnNameRemove.Name = "btnNameRemove";
            this.btnNameRemove.Size = new System.Drawing.Size(22, 23);
            this.btnNameRemove.TabIndex = 4;
            this.btnNameRemove.Text = "-";
            this.btnNameRemove.UseVisualStyleBackColor = true;
            this.btnNameRemove.Click += new System.EventHandler(this.btnNameRemove_Click);
            // 
            // btnMidlenameRemove
            // 
            this.btnMidlenameRemove.Location = new System.Drawing.Point(163, 131);
            this.btnMidlenameRemove.Name = "btnMidlenameRemove";
            this.btnMidlenameRemove.Size = new System.Drawing.Size(22, 23);
            this.btnMidlenameRemove.TabIndex = 4;
            this.btnMidlenameRemove.Text = "-";
            this.btnMidlenameRemove.UseVisualStyleBackColor = true;
            this.btnMidlenameRemove.Click += new System.EventHandler(this.btnMidlenameRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Творцы коммунизма";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(10, 364);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(79, 25);
            this.btnGenerator.TabIndex = 8;
            this.btnGenerator.Text = "Генератор";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // btnFunctionAdd
            // 
            this.btnFunctionAdd.Location = new System.Drawing.Point(140, 182);
            this.btnFunctionAdd.Name = "btnFunctionAdd";
            this.btnFunctionAdd.Size = new System.Drawing.Size(22, 23);
            this.btnFunctionAdd.TabIndex = 11;
            this.btnFunctionAdd.Text = "+";
            this.btnFunctionAdd.UseVisualStyleBackColor = true;
            this.btnFunctionAdd.Click += new System.EventHandler(this.btnFunctionAdd_Click);
            // 
            // btnFunctionRemove
            // 
            this.btnFunctionRemove.Location = new System.Drawing.Point(163, 182);
            this.btnFunctionRemove.Name = "btnFunctionRemove";
            this.btnFunctionRemove.Size = new System.Drawing.Size(22, 23);
            this.btnFunctionRemove.TabIndex = 12;
            this.btnFunctionRemove.Text = "-";
            this.btnFunctionRemove.UseVisualStyleBackColor = true;
            this.btnFunctionRemove.Click += new System.EventHandler(this.btnFunctionRemove_Click);
            // 
            // lbFunction
            // 
            this.lbFunction.AutoSize = true;
            this.lbFunction.Location = new System.Drawing.Point(10, 164);
            this.lbFunction.Name = "lbFunction";
            this.lbFunction.Size = new System.Drawing.Size(65, 13);
            this.lbFunction.TabIndex = 10;
            this.lbFunction.Text = "Профессия";
            // 
            // cBFunction
            // 
            this.cBFunction.FormattingEnabled = true;
            this.cBFunction.Location = new System.Drawing.Point(10, 184);
            this.cBFunction.Name = "cBFunction";
            this.cBFunction.Size = new System.Drawing.Size(121, 21);
            this.cBFunction.TabIndex = 9;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 401);
            this.Controls.Add(this.btnFunctionAdd);
            this.Controls.Add(this.btnFunctionRemove);
            this.Controls.Add(this.lbFunction);
            this.Controls.Add(this.cBFunction);
            this.Controls.Add(this.btnGenerator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBFemaill);
            this.Controls.Add(this.RBMail);
            this.Controls.Add(this.btnMidlenameAdd);
            this.Controls.Add(this.btnMidlenameRemove);
            this.Controls.Add(this.btnNameRemove);
            this.Controls.Add(this.btnSurnameRemove);
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
        private System.Windows.Forms.RadioButton RBMail;
        private System.Windows.Forms.RadioButton RBFemaill;
        private System.Windows.Forms.Button btnSurnameRemove;
        private System.Windows.Forms.Button btnNameRemove;
        private System.Windows.Forms.Button btnMidlenameRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.Button btnFunctionAdd;
        private System.Windows.Forms.Button btnFunctionRemove;
        private System.Windows.Forms.Label lbFunction;
        private System.Windows.Forms.ComboBox cBFunction;
    }
}

