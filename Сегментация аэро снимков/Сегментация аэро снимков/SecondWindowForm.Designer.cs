namespace Сегментация_аэро_снимков
{
    partial class SecondWindowForm
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
            this.NirBtn = new System.Windows.Forms.Button();
            this.RedBtn = new System.Windows.Forms.Button();
            this.RGrPalitra = new System.Windows.Forms.GroupBox();
            this.RGrRadio3 = new System.Windows.Forms.RadioButton();
            this.RGrRadio2 = new System.Windows.Forms.RadioButton();
            this.RGrRadio1 = new System.Windows.Forms.RadioButton();
            this.rgFormNDVI = new System.Windows.Forms.GroupBox();
            this.NDVIForm2 = new System.Windows.Forms.RadioButton();
            this.NDVIForm1 = new System.Windows.Forms.RadioButton();
            this.rgEdIzmPL = new System.Windows.Forms.GroupBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictRed = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictNir = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkRedNir = new System.Windows.Forms.CheckBox();
            this.checkPalitra = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkForm = new System.Windows.Forms.CheckBox();
            this.checkEdIzm = new System.Windows.Forms.CheckBox();
            this.btnNDVI = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNxRED = new System.Windows.Forms.Label();
            this.LblNyRED = new System.Windows.Forms.Label();
            this.LblNyNIR = new System.Windows.Forms.Label();
            this.LblNxNIR = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fullRedImg = new System.Windows.Forms.Button();
            this.fullNirImg = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.RGrPalitra.SuspendLayout();
            this.rgFormNDVI.SuspendLayout();
            this.rgEdIzmPL.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictRed)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictNir)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NirBtn);
            this.groupBox1.Controls.Add(this.RedBtn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод файлов RED и NIR составляющих в форматах BMP и JPEG";
            // 
            // NirBtn
            // 
            this.NirBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NirBtn.Location = new System.Drawing.Point(125, 45);
            this.NirBtn.Name = "NirBtn";
            this.NirBtn.Size = new System.Drawing.Size(75, 23);
            this.NirBtn.TabIndex = 4;
            this.NirBtn.Text = "NIR";
            this.NirBtn.UseVisualStyleBackColor = true;
            this.NirBtn.Click += new System.EventHandler(this.NirBtn_Click);
            // 
            // RedBtn
            // 
            this.RedBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedBtn.Location = new System.Drawing.Point(6, 45);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(75, 23);
            this.RedBtn.TabIndex = 3;
            this.RedBtn.Text = "RED";
            this.RedBtn.UseVisualStyleBackColor = true;
            this.RedBtn.Click += new System.EventHandler(this.RedBtn_Click);
            // 
            // RGrPalitra
            // 
            this.RGrPalitra.Controls.Add(this.RGrRadio3);
            this.RGrPalitra.Controls.Add(this.RGrRadio2);
            this.RGrPalitra.Controls.Add(this.RGrRadio1);
            this.RGrPalitra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RGrPalitra.Location = new System.Drawing.Point(9, 150);
            this.RGrPalitra.Name = "RGrPalitra";
            this.RGrPalitra.Size = new System.Drawing.Size(285, 101);
            this.RGrPalitra.TabIndex = 1;
            this.RGrPalitra.TabStop = false;
            this.RGrPalitra.Text = "Какую палитру будете использовать при раскраске NDVI";
            this.RGrPalitra.Enter += new System.EventHandler(this.RGrPalitra_Enter);
            // 
            // RGrRadio3
            // 
            this.RGrRadio3.AutoSize = true;
            this.RGrRadio3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RGrRadio3.Location = new System.Drawing.Point(6, 77);
            this.RGrRadio3.Name = "RGrRadio3";
            this.RGrRadio3.Size = new System.Drawing.Size(269, 19);
            this.RGrRadio3.TabIndex = 5;
            this.RGrRadio3.TabStop = true;
            this.RGrRadio3.Text = "Создаваемую (прямо сейчас) в диалоговом окне";
            this.RGrRadio3.UseVisualStyleBackColor = true;
            this.RGrRadio3.Click += new System.EventHandler(this.RGrRadio3_Click);
            // 
            // RGrRadio2
            // 
            this.RGrRadio2.AutoSize = true;
            this.RGrRadio2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RGrRadio2.Location = new System.Drawing.Point(6, 54);
            this.RGrRadio2.Name = "RGrRadio2";
            this.RGrRadio2.Size = new System.Drawing.Size(179, 19);
            this.RGrRadio2.TabIndex = 4;
            this.RGrRadio2.TabStop = true;
            this.RGrRadio2.Text = "Выбираемую из существущих";
            this.RGrRadio2.UseVisualStyleBackColor = true;
            this.RGrRadio2.Click += new System.EventHandler(this.RGrRadio2_Click);
            // 
            // RGrRadio1
            // 
            this.RGrRadio1.AutoSize = true;
            this.RGrRadio1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RGrRadio1.Location = new System.Drawing.Point(6, 31);
            this.RGrRadio1.Name = "RGrRadio1";
            this.RGrRadio1.Size = new System.Drawing.Size(169, 19);
            this.RGrRadio1.TabIndex = 3;
            this.RGrRadio1.TabStop = true;
            this.RGrRadio1.Text = "Выбираемую по умлочанию";
            this.RGrRadio1.UseVisualStyleBackColor = true;
            this.RGrRadio1.Click += new System.EventHandler(this.RGrRadio1_Click);
            // 
            // rgFormNDVI
            // 
            this.rgFormNDVI.Controls.Add(this.NDVIForm2);
            this.rgFormNDVI.Controls.Add(this.NDVIForm1);
            this.rgFormNDVI.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rgFormNDVI.Location = new System.Drawing.Point(9, 274);
            this.rgFormNDVI.Name = "rgFormNDVI";
            this.rgFormNDVI.Size = new System.Drawing.Size(200, 87);
            this.rgFormNDVI.TabIndex = 2;
            this.rgFormNDVI.TabStop = false;
            this.rgFormNDVI.Text = "NDVI вычисляется по формуле:";
            // 
            // NDVIForm2
            // 
            this.NDVIForm2.AutoSize = true;
            this.NDVIForm2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NDVIForm2.Location = new System.Drawing.Point(6, 58);
            this.NDVIForm2.Name = "NDVIForm2";
            this.NDVIForm2.Size = new System.Drawing.Size(186, 19);
            this.NDVIForm2.TabIndex = 5;
            this.NDVIForm2.TabStop = true;
            this.NDVIForm2.Text = "NDVI= (NIR-RED)/(RED+NIR)";
            this.NDVIForm2.UseVisualStyleBackColor = true;
            // 
            // NDVIForm1
            // 
            this.NDVIForm1.AutoSize = true;
            this.NDVIForm1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NDVIForm1.Location = new System.Drawing.Point(6, 35);
            this.NDVIForm1.Name = "NDVIForm1";
            this.NDVIForm1.Size = new System.Drawing.Size(186, 19);
            this.NDVIForm1.TabIndex = 4;
            this.NDVIForm1.TabStop = true;
            this.NDVIForm1.Text = "NDVI= (RED-NIR)/(RED+NIR)";
            this.NDVIForm1.UseVisualStyleBackColor = true;
            // 
            // rgEdIzmPL
            // 
            this.rgEdIzmPL.Controls.Add(this.radioButton10);
            this.rgEdIzmPL.Controls.Add(this.radioButton9);
            this.rgEdIzmPL.Controls.Add(this.radioButton8);
            this.rgEdIzmPL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rgEdIzmPL.Location = new System.Drawing.Point(9, 399);
            this.rgEdIzmPL.Name = "rgEdIzmPL";
            this.rgEdIzmPL.Size = new System.Drawing.Size(230, 56);
            this.rgEdIzmPL.TabIndex = 2;
            this.rgEdIzmPL.TabStop = false;
            this.rgEdIzmPL.Text = "В чем выразить значение площадей";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton10.Location = new System.Drawing.Point(148, 25);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(63, 19);
            this.radioButton10.TabIndex = 6;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Кв. км.";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton9.Location = new System.Drawing.Point(87, 25);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(57, 19);
            this.radioButton9.TabIndex = 5;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Кв. м.";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton8.Location = new System.Drawing.Point(12, 25);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(71, 19);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Пиксель";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictRed);
            this.panel1.Location = new System.Drawing.Point(379, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 248);
            this.panel1.TabIndex = 3;
            // 
            // pictRed
            // 
            this.pictRed.Location = new System.Drawing.Point(3, 3);
            this.pictRed.Name = "pictRed";
            this.pictRed.Size = new System.Drawing.Size(302, 226);
            this.pictRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictRed.TabIndex = 0;
            this.pictRed.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictNir);
            this.panel2.Location = new System.Drawing.Point(379, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 249);
            this.panel2.TabIndex = 4;
            // 
            // pictNir
            // 
            this.pictNir.Location = new System.Drawing.Point(3, 3);
            this.pictNir.Name = "pictNir";
            this.pictNir.Size = new System.Drawing.Size(302, 226);
            this.pictNir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictNir.TabIndex = 1;
            this.pictNir.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(118, 100);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // checkRedNir
            // 
            this.checkRedNir.AutoSize = true;
            this.checkRedNir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkRedNir.Location = new System.Drawing.Point(9, 3);
            this.checkRedNir.Name = "checkRedNir";
            this.checkRedNir.Size = new System.Drawing.Size(124, 19);
            this.checkRedNir.TabIndex = 7;
            this.checkRedNir.Text = "Разрешить доступ";
            this.checkRedNir.UseVisualStyleBackColor = true;
            this.checkRedNir.Click += new System.EventHandler(this.checkRedNir_Click);
            // 
            // checkPalitra
            // 
            this.checkPalitra.AutoSize = true;
            this.checkPalitra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPalitra.Location = new System.Drawing.Point(15, 128);
            this.checkPalitra.Name = "checkPalitra";
            this.checkPalitra.Size = new System.Drawing.Size(124, 19);
            this.checkPalitra.TabIndex = 8;
            this.checkPalitra.Text = "Разрешить доступ";
            this.checkPalitra.UseVisualStyleBackColor = true;
            this.checkPalitra.Click += new System.EventHandler(this.checkPalitra_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 617);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(119, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Разрешить доступ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkForm
            // 
            this.checkForm.AutoSize = true;
            this.checkForm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkForm.Location = new System.Drawing.Point(15, 257);
            this.checkForm.Name = "checkForm";
            this.checkForm.Size = new System.Drawing.Size(124, 19);
            this.checkForm.TabIndex = 10;
            this.checkForm.Text = "Разрешить доступ";
            this.checkForm.UseVisualStyleBackColor = true;
            this.checkForm.Click += new System.EventHandler(this.checkForm_Click);
            // 
            // checkEdIzm
            // 
            this.checkEdIzm.AutoSize = true;
            this.checkEdIzm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkEdIzm.Location = new System.Drawing.Point(15, 380);
            this.checkEdIzm.Name = "checkEdIzm";
            this.checkEdIzm.Size = new System.Drawing.Size(124, 19);
            this.checkEdIzm.TabIndex = 12;
            this.checkEdIzm.Text = "Разрешить доступ";
            this.checkEdIzm.UseVisualStyleBackColor = true;
            this.checkEdIzm.Click += new System.EventHandler(this.checkEdIzm_Click);
            // 
            // btnNDVI
            // 
            this.btnNDVI.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNDVI.Location = new System.Drawing.Point(3, 637);
            this.btnNDVI.Name = "btnNDVI";
            this.btnNDVI.Size = new System.Drawing.Size(146, 39);
            this.btnNDVI.TabIndex = 13;
            this.btnNDVI.Text = "Перейти красчету NDVI";
            this.btnNDVI.UseVisualStyleBackColor = true;
            this.btnNDVI.Click += new System.EventHandler(this.btnNDVI_ClickAsync);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(167, 637);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 39);
            this.button4.TabIndex = 14;
            this.button4.Text = "Выход из окна";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(391, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Red составляющая:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(391, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "NIR составляющая:";
            // 
            // LblNxRED
            // 
            this.LblNxRED.AutoSize = true;
            this.LblNxRED.Location = new System.Drawing.Point(391, 282);
            this.LblNxRED.Name = "LblNxRED";
            this.LblNxRED.Size = new System.Drawing.Size(32, 13);
            this.LblNxRED.TabIndex = 17;
            this.LblNxRED.Text = "Nx = ";
            // 
            // LblNyRED
            // 
            this.LblNyRED.AutoSize = true;
            this.LblNyRED.Location = new System.Drawing.Point(552, 282);
            this.LblNyRED.Name = "LblNyRED";
            this.LblNyRED.Size = new System.Drawing.Size(32, 13);
            this.LblNyRED.TabIndex = 18;
            this.LblNyRED.Text = "Ny = ";
            // 
            // LblNyNIR
            // 
            this.LblNyNIR.AutoSize = true;
            this.LblNyNIR.Location = new System.Drawing.Point(552, 617);
            this.LblNyNIR.Name = "LblNyNIR";
            this.LblNyNIR.Size = new System.Drawing.Size(32, 13);
            this.LblNyNIR.TabIndex = 20;
            this.LblNyNIR.Text = "Ny = ";
            // 
            // LblNxNIR
            // 
            this.LblNxNIR.AutoSize = true;
            this.LblNxNIR.Location = new System.Drawing.Point(391, 618);
            this.LblNxNIR.Name = "LblNxNIR";
            this.LblNxNIR.Size = new System.Drawing.Size(32, 13);
            this.LblNxNIR.TabIndex = 19;
            this.LblNxNIR.Text = "Nx = ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.checkRedNir);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.RGrPalitra);
            this.panel3.Controls.Add(this.rgEdIzmPL);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.btnNDVI);
            this.panel3.Controls.Add(this.rgFormNDVI);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.checkPalitra);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkEdIzm);
            this.panel3.Controls.Add(this.checkForm);
            this.panel3.Location = new System.Drawing.Point(-1, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 696);
            this.panel3.TabIndex = 21;
            // 
            // fullRedImg
            // 
            this.fullRedImg.Location = new System.Drawing.Point(604, 296);
            this.fullRedImg.Name = "fullRedImg";
            this.fullRedImg.Size = new System.Drawing.Size(91, 38);
            this.fullRedImg.TabIndex = 22;
            this.fullRedImg.Text = "Посмотреть в полном размере";
            this.fullRedImg.UseVisualStyleBackColor = true;
            this.fullRedImg.Click += new System.EventHandler(this.fullRedImg_Click);
            // 
            // fullNirImg
            // 
            this.fullNirImg.Location = new System.Drawing.Point(604, 634);
            this.fullNirImg.Name = "fullNirImg";
            this.fullNirImg.Size = new System.Drawing.Size(91, 38);
            this.fullNirImg.TabIndex = 23;
            this.fullNirImg.Text = "Посмотреть в полном размере";
            this.fullNirImg.UseVisualStyleBackColor = true;
            this.fullNirImg.Click += new System.EventHandler(this.fullNirImg_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            this.OpenFile.Filter = "*.TIFF;*.BMP;*.JPG;*.PNG)|*.TIFF;*.BMP;*.JPG;*.PNG;|All Files(*.*)|*.";
            // 
            // SecondWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 689);
            this.Controls.Add(this.fullNirImg);
            this.Controls.Add(this.fullRedImg);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LblNyNIR);
            this.Controls.Add(this.LblNxNIR);
            this.Controls.Add(this.LblNyRED);
            this.Controls.Add(this.LblNxRED);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SecondWindowForm";
            this.Text = "SecondWindowForm";
            this.groupBox1.ResumeLayout(false);
            this.RGrPalitra.ResumeLayout(false);
            this.RGrPalitra.PerformLayout();
            this.rgFormNDVI.ResumeLayout(false);
            this.rgFormNDVI.PerformLayout();
            this.rgEdIzmPL.ResumeLayout(false);
            this.rgEdIzmPL.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictRed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictNir)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NirBtn;
        private System.Windows.Forms.Button RedBtn;
        private System.Windows.Forms.GroupBox RGrPalitra;
        private System.Windows.Forms.RadioButton RGrRadio3;
        private System.Windows.Forms.RadioButton RGrRadio2;
        private System.Windows.Forms.RadioButton RGrRadio1;
        private System.Windows.Forms.GroupBox rgFormNDVI;
        private System.Windows.Forms.GroupBox rgEdIzmPL;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkRedNir;
        private System.Windows.Forms.CheckBox checkPalitra;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkForm;
        private System.Windows.Forms.CheckBox checkEdIzm;
        private System.Windows.Forms.Button btnNDVI;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNxRED;
        private System.Windows.Forms.Label LblNyRED;
        private System.Windows.Forms.Label LblNyNIR;
        private System.Windows.Forms.Label LblNxNIR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button fullRedImg;
        private System.Windows.Forms.Button fullNirImg;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.PictureBox pictRed;
        public System.Windows.Forms.PictureBox pictNir;
        public System.Windows.Forms.RadioButton NDVIForm2;
        public System.Windows.Forms.RadioButton NDVIForm1;
        public System.Windows.Forms.OpenFileDialog OpenFile;
    }
}