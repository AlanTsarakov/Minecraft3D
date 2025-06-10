namespace Minecraft3D
{
    partial class FormAddObject
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
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.radioButtonEarth = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonWater = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(47, 163);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(23, 20);
            this.textBoxLength.TabIndex = 1;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(158, 163);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(23, 20);
            this.textBoxWidth.TabIndex = 2;
            // 
            // radioButtonEarth
            // 
            this.radioButtonEarth.AutoSize = true;
            this.radioButtonEarth.Location = new System.Drawing.Point(3, 10);
            this.radioButtonEarth.Name = "radioButtonEarth";
            this.radioButtonEarth.Size = new System.Drawing.Size(58, 17);
            this.radioButtonEarth.TabIndex = 3;
            this.radioButtonEarth.TabStop = true;
            this.radioButtonEarth.Text = "Земля";
            this.radioButtonEarth.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonWater);
            this.panel1.Controls.Add(this.radioButtonEarth);
            this.panel1.Location = new System.Drawing.Point(44, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 66);
            this.panel1.TabIndex = 4;
            // 
            // radioButtonWater
            // 
            this.radioButtonWater.AutoSize = true;
            this.radioButtonWater.Location = new System.Drawing.Point(3, 33);
            this.radioButtonWater.Name = "radioButtonWater";
            this.radioButtonWater.Size = new System.Drawing.Size(50, 17);
            this.radioButtonWater.TabIndex = 4;
            this.radioButtonWater.TabStop = true;
            this.radioButtonWater.Text = "Вода";
            this.radioButtonWater.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(77, 210);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ширина";
            // 
            // FormAddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxLength);
            this.Name = "FormAddObject";
            this.Text = "Добавить объект";
            this.Load += new System.EventHandler(this.FormAddObject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.RadioButton radioButtonEarth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonWater;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}