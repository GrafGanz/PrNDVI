namespace Сегментация_аэро_снимков
{
    partial class Shablon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImgCveta = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnVisTabStdClr = new System.Windows.Forms.Button();
            this.BtnLoadFromFL = new System.Windows.Forms.Button();
            this.BtnSaveToFL = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCveta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImgCveta);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Табл. стандартных цветов и их принятых номеров ";
            // 
            // ImgCveta
            // 
            this.ImgCveta.Location = new System.Drawing.Point(12, 20);
            this.ImgCveta.Name = "ImgCveta";
            this.ImgCveta.Size = new System.Drawing.Size(311, 256);
            this.ImgCveta.TabIndex = 0;
            this.ImgCveta.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(346, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(541, 282);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // BtnVisTabStdClr
            // 
            this.BtnVisTabStdClr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnVisTabStdClr.Location = new System.Drawing.Point(12, 348);
            this.BtnVisTabStdClr.Name = "BtnVisTabStdClr";
            this.BtnVisTabStdClr.Size = new System.Drawing.Size(247, 38);
            this.BtnVisTabStdClr.TabIndex = 2;
            this.BtnVisTabStdClr.Text = "Показать табл. стандартных цветов";
            this.BtnVisTabStdClr.UseVisualStyleBackColor = true;
            this.BtnVisTabStdClr.Click += new System.EventHandler(this.BtnVisTabStdClr_Click);
            // 
            // BtnLoadFromFL
            // 
            this.BtnLoadFromFL.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLoadFromFL.Location = new System.Drawing.Point(341, 348);
            this.BtnLoadFromFL.Name = "BtnLoadFromFL";
            this.BtnLoadFromFL.Size = new System.Drawing.Size(277, 38);
            this.BtnLoadFromFL.TabIndex = 3;
            this.BtnLoadFromFL.Text = "Загрузить шаблон (таблицу покровов и их цветов)";
            this.BtnLoadFromFL.UseVisualStyleBackColor = true;
            this.BtnLoadFromFL.Click += new System.EventHandler(this.BtnLoadFromFL_Click);
            // 
            // BtnSaveToFL
            // 
            this.BtnSaveToFL.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSaveToFL.Location = new System.Drawing.Point(639, 348);
            this.BtnSaveToFL.Name = "BtnSaveToFL";
            this.BtnSaveToFL.Size = new System.Drawing.Size(123, 38);
            this.BtnSaveToFL.TabIndex = 4;
            this.BtnSaveToFL.Text = "Сохранить в файле";
            this.BtnSaveToFL.UseVisualStyleBackColor = true;
            this.BtnSaveToFL.Click += new System.EventHandler(this.BtnSaveToFL_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(812, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // Shablon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 402);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnSaveToFL);
            this.Controls.Add(this.BtnLoadFromFL);
            this.Controls.Add(this.BtnVisTabStdClr);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Shablon";
            this.Text = "Shablon";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCveta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnVisTabStdClr;
        private System.Windows.Forms.Button BtnLoadFromFL;
        private System.Windows.Forms.Button BtnSaveToFL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox ImgCveta;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}