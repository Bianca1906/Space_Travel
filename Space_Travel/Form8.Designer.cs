
namespace Space_Travel
{
    partial class Uranus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uranus));
            this.button1 = new System.Windows.Forms.Button();
            this.inutil2 = new System.Windows.Forms.Button();
            this.inutil1 = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.numeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posibilitateaExistențeiViețiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pozeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curiozitățiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Sigmar One", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(958, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 48;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // inutil2
            // 
            this.inutil2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inutil2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inutil2.Location = new System.Drawing.Point(525, 512);
            this.inutil2.Name = "inutil2";
            this.inutil2.Size = new System.Drawing.Size(57, 33);
            this.inutil2.TabIndex = 47;
            this.inutil2.UseVisualStyleBackColor = false;
            this.inutil2.Visible = false;
            // 
            // inutil1
            // 
            this.inutil1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inutil1.Location = new System.Drawing.Point(417, 512);
            this.inutil1.Name = "inutil1";
            this.inutil1.Size = new System.Drawing.Size(57, 33);
            this.inutil1.TabIndex = 46;
            this.inutil1.UseVisualStyleBackColor = false;
            this.inutil1.Visible = false;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.Color.Red;
            this.stop.Location = new System.Drawing.Point(589, 512);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(39, 33);
            this.stop.TabIndex = 45;
            this.stop.Text = "◼";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pause.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.ForeColor = System.Drawing.Color.Yellow;
            this.pause.Location = new System.Drawing.Point(480, 512);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(39, 33);
            this.pause.TabIndex = 44;
            this.pause.Text = "| |";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Visible = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.Lime;
            this.play.Location = new System.Drawing.Point(372, 512);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(39, 33);
            this.play.TabIndex = 43;
            this.play.Text = "▶️";
            this.play.UseVisualStyleBackColor = false;
            this.play.Visible = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "🚀Deoarece se rotește lateral, Uranus este cunoscută sub numele de „planeta later" +
                "ală”.",
            "",
            "🚀Uranus a fost prima planetă descoperită prin utilizarea unui telescop.",
            "",
            "🚀William Herschel a descoperit Uranus în 1781.",
            "",
            "🚀Uranus are 27 de luni cunoscute, majoritatea fiind numite după figuri literare." +
                "",
            "",
            "🚀Uranus este o planetă gigantică de gheață care este de aproximativ",
            " patru ori mai mare decât Pământul.",
            "",
            "🚀Uranus este o planetă inelată, precum Saturn, Jupiter și Neptun."});
            this.listBox1.Location = new System.Drawing.Point(10, 247);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(773, 316);
            this.listBox1.TabIndex = 42;
            this.listBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(372, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 280);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(491, 343);
            this.textBox1.TabIndex = 39;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Planeta Uranus";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeToolStripMenuItem,
            this.posibilitateaExistențeiViețiiToolStripMenuItem,
            this.pozeToolStripMenuItem,
            this.curiozitățiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numeToolStripMenuItem
            // 
            this.numeToolStripMenuItem.Name = "numeToolStripMenuItem";
            this.numeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.numeToolStripMenuItem.Text = "Istoric Nume";
            this.numeToolStripMenuItem.Click += new System.EventHandler(this.numeToolStripMenuItem_Click);
            // 
            // posibilitateaExistențeiViețiiToolStripMenuItem
            // 
            this.posibilitateaExistențeiViețiiToolStripMenuItem.Name = "posibilitateaExistențeiViețiiToolStripMenuItem";
            this.posibilitateaExistențeiViețiiToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.posibilitateaExistențeiViețiiToolStripMenuItem.Text = "Posibilitatea existenței vieții";
            this.posibilitateaExistențeiViețiiToolStripMenuItem.Click += new System.EventHandler(this.posibilitateaExistențeiViețiiToolStripMenuItem_Click);
            // 
            // pozeToolStripMenuItem
            // 
            this.pozeToolStripMenuItem.Name = "pozeToolStripMenuItem";
            this.pozeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.pozeToolStripMenuItem.Text = "Poze";
            this.pozeToolStripMenuItem.Click += new System.EventHandler(this.pozeToolStripMenuItem_Click);
            // 
            // curiozitățiToolStripMenuItem
            // 
            this.curiozitățiToolStripMenuItem.Name = "curiozitățiToolStripMenuItem";
            this.curiozitățiToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.curiozitățiToolStripMenuItem.Text = "Curiozități";
            this.curiozitățiToolStripMenuItem.Click += new System.EventHandler(this.curiozitățiToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(10, 280);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(795, 343);
            this.textBox2.TabIndex = 40;
            this.textBox2.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "uranus1.jpg");
            this.imageList1.Images.SetKeyName(1, "uranus2.jpg");
            this.imageList1.Images.SetKeyName(2, "uranus3.jpg");
            this.imageList1.Images.SetKeyName(3, "uranus4.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Uranus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Travel.Properties.Resources.uranuss;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inutil2);
            this.Controls.Add(this.inutil1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uranus";
            this.Text = "Uranus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button inutil2;
        private System.Windows.Forms.Button inutil1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem numeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posibilitateaExistențeiViețiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pozeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curiozitățiToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}