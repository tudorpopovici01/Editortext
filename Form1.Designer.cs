
namespace Editortext
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fișierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazăToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lipireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tăiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.șriftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setariSriftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setariFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.selecteazăTotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lipireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tăiereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selecteazăTotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fișierToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.șriftToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fișierToolStripMenuItem
            // 
            this.fișierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschideToolStripMenuItem,
            this.salveazăToolStripMenuItem,
            this.salveazăToolStripMenuItem1});
            this.fișierToolStripMenuItem.Name = "fișierToolStripMenuItem";
            this.fișierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fișierToolStripMenuItem.Text = "Fișier";
            // 
            // deschideToolStripMenuItem
            // 
            this.deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            this.deschideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deschideToolStripMenuItem.Text = "Deschide";
            this.deschideToolStripMenuItem.Click += new System.EventHandler(this.deschideToolStripMenuItem_Click);
            // 
            // salveazăToolStripMenuItem
            // 
            this.salveazăToolStripMenuItem.Name = "salveazăToolStripMenuItem";
            this.salveazăToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salveazăToolStripMenuItem.Text = "Salvează ca...";
            this.salveazăToolStripMenuItem.Click += new System.EventHandler(this.salveazăToolStripMenuItem_Click);
            // 
            // salveazăToolStripMenuItem1
            // 
            this.salveazăToolStripMenuItem1.Name = "salveazăToolStripMenuItem1";
            this.salveazăToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salveazăToolStripMenuItem1.Text = "Salvează";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiereToolStripMenuItem,
            this.lipireToolStripMenuItem,
            this.tăiereToolStripMenuItem,
            this.selecteazăTotToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.formatToolStripMenuItem.Text = "Editare";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.formatToolStripMenuItem_Click);
            // 
            // copiereToolStripMenuItem
            // 
            this.copiereToolStripMenuItem.Name = "copiereToolStripMenuItem";
            this.copiereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiereToolStripMenuItem.Text = "Copiere";
            this.copiereToolStripMenuItem.Click += new System.EventHandler(this.copiereToolStripMenuItem_Click);
            // 
            // lipireToolStripMenuItem
            // 
            this.lipireToolStripMenuItem.Name = "lipireToolStripMenuItem";
            this.lipireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lipireToolStripMenuItem.Text = "Lipire";
            this.lipireToolStripMenuItem.Click += new System.EventHandler(this.lipireToolStripMenuItem_Click);
            // 
            // tăiereToolStripMenuItem
            // 
            this.tăiereToolStripMenuItem.Name = "tăiereToolStripMenuItem";
            this.tăiereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tăiereToolStripMenuItem.Text = "Tăiere";
            this.tăiereToolStripMenuItem.Click += new System.EventHandler(this.tăiereToolStripMenuItem_Click);
            // 
            // șriftToolStripMenuItem
            // 
            this.șriftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setariSriftToolStripMenuItem});
            this.șriftToolStripMenuItem.Name = "șriftToolStripMenuItem";
            this.șriftToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.șriftToolStripMenuItem.Text = "Șrift";
            // 
            // setariSriftToolStripMenuItem
            // 
            this.setariSriftToolStripMenuItem.Name = "setariSriftToolStripMenuItem";
            this.setariSriftToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setariSriftToolStripMenuItem.Text = "Setari srift";
            this.setariSriftToolStripMenuItem.Click += new System.EventHandler(this.setariSriftToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setariFontToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fontToolStripMenuItem.Text = "Fon";
            // 
            // setariFontToolStripMenuItem
            // 
            this.setariFontToolStripMenuItem.Name = "setariFontToolStripMenuItem";
            this.setariFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setariFontToolStripMenuItem.Text = "Setari fon";
            this.setariFontToolStripMenuItem.Click += new System.EventHandler(this.setariFontToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selecteazăTotToolStripMenuItem
            // 
            this.selecteazăTotToolStripMenuItem.Name = "selecteazăTotToolStripMenuItem";
            this.selecteazăTotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selecteazăTotToolStripMenuItem.Text = "Selectează tot";
            this.selecteazăTotToolStripMenuItem.Click += new System.EventHandler(this.selecteazăTotToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiereToolStripMenuItem1,
            this.lipireToolStripMenuItem1,
            this.tăiereToolStripMenuItem1,
            this.selecteazăTotToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // copiereToolStripMenuItem1
            // 
            this.copiereToolStripMenuItem1.Name = "copiereToolStripMenuItem1";
            this.copiereToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.copiereToolStripMenuItem1.Text = "Copiere";
            this.copiereToolStripMenuItem1.Click += new System.EventHandler(this.copiereToolStripMenuItem1_Click);
            // 
            // lipireToolStripMenuItem1
            // 
            this.lipireToolStripMenuItem1.Name = "lipireToolStripMenuItem1";
            this.lipireToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lipireToolStripMenuItem1.Text = "Lipire";
            this.lipireToolStripMenuItem1.Click += new System.EventHandler(this.lipireToolStripMenuItem1_Click);
            // 
            // tăiereToolStripMenuItem1
            // 
            this.tăiereToolStripMenuItem1.Name = "tăiereToolStripMenuItem1";
            this.tăiereToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tăiereToolStripMenuItem1.Text = "Tăiere";
            this.tăiereToolStripMenuItem1.Click += new System.EventHandler(this.tăiereToolStripMenuItem1_Click);
            // 
            // selecteazăTotToolStripMenuItem1
            // 
            this.selecteazăTotToolStripMenuItem1.Name = "selecteazăTotToolStripMenuItem1";
            this.selecteazăTotToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.selecteazăTotToolStripMenuItem1.Text = "Selectează tot";
            this.selecteazăTotToolStripMenuItem1.Click += new System.EventHandler(this.selecteazăTotToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor text";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fișierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazăToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lipireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tăiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem șriftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setariSriftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setariFontToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem selecteazăTotToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lipireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tăiereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selecteazăTotToolStripMenuItem1;
    }
}

