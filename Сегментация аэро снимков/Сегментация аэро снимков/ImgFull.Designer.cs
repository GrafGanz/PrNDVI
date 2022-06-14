namespace Сегментация_аэро_снимков
{
    partial class ImgFull
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьСнимокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictImgFull = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImgFull)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьСнимокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьСнимокToolStripMenuItem
            // 
            this.сохранитьСнимокToolStripMenuItem.Name = "сохранитьСнимокToolStripMenuItem";
            this.сохранитьСнимокToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.сохранитьСнимокToolStripMenuItem.Text = "Сохранить снимок";
            // 
            // pictImgFull
            // 
            this.pictImgFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictImgFull.Location = new System.Drawing.Point(0, 24);
            this.pictImgFull.Name = "pictImgFull";
            this.pictImgFull.Size = new System.Drawing.Size(803, 552);
            this.pictImgFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictImgFull.TabIndex = 1;
            this.pictImgFull.TabStop = false;
            this.pictImgFull.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ImgFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 576);
            this.Controls.Add(this.pictImgFull);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImgFull";
            this.Text = "ImgFull";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImgFull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСнимокToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictImgFull;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}