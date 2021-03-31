
namespace CountdownTimer_2Dia
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnContar = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.upHora = new System.Windows.Forms.NumericUpDown();
            this.upMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.upHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upMin)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(455, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnContar
            // 
            this.btnContar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(188, 184);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(140, 32);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTempo.Location = new System.Drawing.Point(-107, 80);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(550, 55);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // upHora
            // 
            this.upHora.BackColor = System.Drawing.SystemColors.Control;
            this.upHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upHora.Location = new System.Drawing.Point(516, 190);
            this.upHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.upHora.Name = "upHora";
            this.upHora.Size = new System.Drawing.Size(36, 25);
            this.upHora.TabIndex = 6;
            this.upHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upHora.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // upMin
            // 
            this.upMin.BackColor = System.Drawing.SystemColors.Control;
            this.upMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upMin.Location = new System.Drawing.Point(579, 190);
            this.upMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.upMin.Name = "upMin";
            this.upMin.Size = new System.Drawing.Size(36, 25);
            this.upMin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(33, 153);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 60;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(112, 112);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 9;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 272);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upMin);
            this.Controls.Add(this.upHora);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.ShowIcon = false;
            this.Text = "Contador de Dias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.NumericUpDown upHora;
        private System.Windows.Forms.NumericUpDown upMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}

