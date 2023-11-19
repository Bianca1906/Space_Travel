
namespace Space_Travel
{
    partial class Mercur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mercur));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.istoricNumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posibilitateaExistențeiViețiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pozeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curiozitățiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.inutil2 = new System.Windows.Forms.Button();
            this.inutil1 = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istoricNumeToolStripMenuItem,
            this.posibilitateaExistențeiViețiiToolStripMenuItem,
            this.pozeToolStripMenuItem,
            this.curiozitățiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // istoricNumeToolStripMenuItem
            // 
            this.istoricNumeToolStripMenuItem.Name = "istoricNumeToolStripMenuItem";
            this.istoricNumeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.istoricNumeToolStripMenuItem.Text = "Istoric Nume";
            this.istoricNumeToolStripMenuItem.Click += new System.EventHandler(this.istoricNumeToolStripMenuItem_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Planeta Mercur";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Sigmar One", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(958, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mercur1.jpg");
            this.imageList1.Images.SetKeyName(1, "mercur2.jpg");
            this.imageList1.Images.SetKeyName(2, "mercur3.gif");
            this.imageList1.Images.SetKeyName(3, "mercur4.jpg");
            this.imageList1.Images.SetKeyName(4, "mercur5.jpg");
            // 
            // inutil2
            // 
            this.inutil2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inutil2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inutil2.Location = new System.Drawing.Point(527, 427);
            this.inutil2.Name = "inutil2";
            this.inutil2.Size = new System.Drawing.Size(57, 33);
            this.inutil2.TabIndex = 22;
            this.inutil2.UseVisualStyleBackColor = false;
            this.inutil2.Visible = false;
            // 
            // inutil1
            // 
            this.inutil1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inutil1.Location = new System.Drawing.Point(419, 427);
            this.inutil1.Name = "inutil1";
            this.inutil1.Size = new System.Drawing.Size(57, 33);
            this.inutil1.TabIndex = 21;
            this.inutil1.UseVisualStyleBackColor = false;
            this.inutil1.Visible = false;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.Color.Red;
            this.stop.Location = new System.Drawing.Point(591, 427);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(39, 33);
            this.stop.TabIndex = 20;
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
            this.pause.Location = new System.Drawing.Point(482, 427);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(39, 33);
            this.pause.TabIndex = 19;
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
            this.play.Location = new System.Drawing.Point(374, 427);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(39, 33);
            this.play.TabIndex = 18;
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
            "🚀Un an pe Planeta Mercur are doar 88 de zile.",
            "",
            "🚀Mercur are riduri. Pe măsură ce miezul de fier al planetei s-a răcit și s-a con" +
                "tractat, suprafața planetei s-a încrețit.",
            "",
            "🚀Doar două nave spațiale au vizitat vreodată Mercur. Datorită apropierii de Soar" +
                "e, Mercur este o planetă dificil ",
            "de vizitat.",
            "",
            "🚀Mercur este numit după mesagerul roman către zei.",
            "",
            "🚀Are o atmosferă subțire. Mercurul are cea mai subțire atmosferă decâto orice al" +
                "tă planetă din sistemul solar. ",
            "Atmosfera planetei este atât de subțire încât oamenii de știință i-au oferit un a" +
                "lt nume: o exosferă."});
            this.listBox1.Location = new System.Drawing.Point(12, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(972, 292);
            this.listBox1.TabIndex = 17;
            this.listBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(374, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(482, 258);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(491, 343);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(177, 258);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(795, 343);
            this.textBox2.TabIndex = 15;
            this.textBox2.Visible = false;
            // 
            // Mercur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Travel.Properties.Resources.mercur_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ControlBox = false;
            this.Controls.Add(this.inutil2);
            this.Controls.Add(this.inutil1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mercur";
            this.Text = "Mercur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem istoricNumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posibilitateaExistențeiViețiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pozeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curiozitățiToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button inutil2;
        private System.Windows.Forms.Button inutil1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}