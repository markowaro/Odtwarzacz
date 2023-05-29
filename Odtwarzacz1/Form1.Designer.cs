namespace Odtwarzacz1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonREMOVE = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonPAUSE = new System.Windows.Forms.Button();
            this.buttonPLAY = new System.Windows.Forms.Button();
            this.buttonSTOP = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelSTART = new System.Windows.Forms.Label();
            this.labelSONG_LENGTH = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonADD
            // 
            this.buttonADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonADD.Location = new System.Drawing.Point(12, 227);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(59, 47);
            this.buttonADD.TabIndex = 0;
            this.buttonADD.Text = "+";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonREMOVE
            // 
            this.buttonREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonREMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonREMOVE.Location = new System.Drawing.Point(77, 227);
            this.buttonREMOVE.Name = "buttonREMOVE";
            this.buttonREMOVE.Size = new System.Drawing.Size(59, 47);
            this.buttonREMOVE.TabIndex = 1;
            this.buttonREMOVE.Text = "-";
            this.buttonREMOVE.UseVisualStyleBackColor = true;
            this.buttonREMOVE.Click += new System.EventHandler(this.buttonREMOVE_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 147);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // buttonPAUSE
            // 
            this.buttonPAUSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPAUSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPAUSE.Location = new System.Drawing.Point(299, 227);
            this.buttonPAUSE.Name = "buttonPAUSE";
            this.buttonPAUSE.Size = new System.Drawing.Size(59, 47);
            this.buttonPAUSE.TabIndex = 3;
            this.buttonPAUSE.Text = "||";
            this.buttonPAUSE.UseVisualStyleBackColor = true;
            this.buttonPAUSE.Click += new System.EventHandler(this.buttonPAUSE_Click);
            // 
            // buttonPLAY
            // 
            this.buttonPLAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPLAY.Location = new System.Drawing.Point(163, 227);
            this.buttonPLAY.Name = "buttonPLAY";
            this.buttonPLAY.Size = new System.Drawing.Size(59, 47);
            this.buttonPLAY.TabIndex = 4;
            this.buttonPLAY.Text = "▶";
            this.buttonPLAY.UseVisualStyleBackColor = true;
            this.buttonPLAY.Click += new System.EventHandler(this.buttonPLAY_Click);
            // 
            // buttonSTOP
            // 
            this.buttonSTOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSTOP.Location = new System.Drawing.Point(234, 227);
            this.buttonSTOP.Name = "buttonSTOP";
            this.buttonSTOP.Size = new System.Drawing.Size(59, 47);
            this.buttonSTOP.TabIndex = 5;
            this.buttonSTOP.Text = "◼";
            this.buttonSTOP.UseVisualStyleBackColor = true;
            this.buttonSTOP.Click += new System.EventHandler(this.buttonSTOP_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(346, 16);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // labelSTART
            // 
            this.labelSTART.AutoSize = true;
            this.labelSTART.Font = new System.Drawing.Font("DigifaceWide", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTART.Location = new System.Drawing.Point(12, 14);
            this.labelSTART.Name = "labelSTART";
            this.labelSTART.Size = new System.Drawing.Size(114, 35);
            this.labelSTART.TabIndex = 8;
            this.labelSTART.Text = "00:00";
            // 
            // labelSONG_LENGTH
            // 
            this.labelSONG_LENGTH.AutoSize = true;
            this.labelSONG_LENGTH.Font = new System.Drawing.Font("DigifaceWide", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSONG_LENGTH.Location = new System.Drawing.Point(179, 14);
            this.labelSONG_LENGTH.Name = "labelSONG_LENGTH";
            this.labelSONG_LENGTH.Size = new System.Drawing.Size(114, 35);
            this.labelSONG_LENGTH.TabIndex = 9;
            this.labelSONG_LENGTH.Text = "00:00";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(364, 273);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(10, 10);
            this.player.TabIndex = 10;
            this.player.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(314, 64);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 120);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(311, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(314, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "100%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DigifaceWide", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(373, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.labelSONG_LENGTH);
            this.Controls.Add(this.labelSTART);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonSTOP);
            this.Controls.Add(this.buttonPLAY);
            this.Controls.Add(this.buttonPAUSE);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonREMOVE);
            this.Controls.Add(this.buttonADD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonREMOVE;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonPAUSE;
        private System.Windows.Forms.Button buttonPLAY;
        private System.Windows.Forms.Button buttonSTOP;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelSTART;
        private System.Windows.Forms.Label labelSONG_LENGTH;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

