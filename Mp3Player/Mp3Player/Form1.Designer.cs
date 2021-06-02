
namespace Mp3Player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.helpBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackList = new System.Windows.Forms.ListBox();
            this.audioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.volume = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.volLabel = new System.Windows.Forms.Label();
            this.deleteSongBtn = new System.Windows.Forms.Button();
            this.deletePlaylistBtn = new System.Windows.Forms.Button();
            this.labelDuration = new System.Windows.Forms.Label();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.helpBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 47);
            this.panel2.TabIndex = 3;
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.Transparent;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Image = global::Mp3Player.Properties.Resources.helpButton2;
            this.helpBtn.Location = new System.Drawing.Point(711, -2);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(46, 42);
            this.helpBtn.TabIndex = 18;
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Gadugi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "MP3 Player";
            // 
            // trackList
            // 
            this.trackList.AllowDrop = true;
            this.trackList.BackColor = System.Drawing.Color.Gray;
            this.trackList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackList.ForeColor = System.Drawing.Color.Aqua;
            this.trackList.FormattingEnabled = true;
            this.trackList.ItemHeight = 16;
            this.trackList.Location = new System.Drawing.Point(285, 53);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(487, 260);
            this.trackList.TabIndex = 4;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // audioPlayer
            // 
            this.audioPlayer.Enabled = true;
            this.audioPlayer.Location = new System.Drawing.Point(10, 327);
            this.audioPlayer.Name = "audioPlayer";
            this.audioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("audioPlayer.OcxState")));
            this.audioPlayer.Size = new System.Drawing.Size(762, 42);
            this.audioPlayer.TabIndex = 7;
            // 
            // volume
            // 
            this.volume.BackColor = System.Drawing.SystemColors.Info;
            this.volume.Location = new System.Drawing.Point(617, 414);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.RightToLeftLayout = true;
            this.volume.Size = new System.Drawing.Size(155, 45);
            this.volume.TabIndex = 10;
            this.volume.TickFrequency = 10;
            this.volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Volume";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Aqua;
            this.progressBar.ForeColor = System.Drawing.Color.Cyan;
            this.progressBar.Location = new System.Drawing.Point(10, 372);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(731, 14);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 13;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volLabel
            // 
            this.volLabel.AutoSize = true;
            this.volLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volLabel.Location = new System.Drawing.Point(719, 402);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(40, 17);
            this.volLabel.TabIndex = 14;
            this.volLabel.Text = "100%";
            // 
            // deleteSongBtn
            // 
            this.deleteSongBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.deleteSongBtn.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSongBtn.Location = new System.Drawing.Point(38, 392);
            this.deleteSongBtn.Name = "deleteSongBtn";
            this.deleteSongBtn.Size = new System.Drawing.Size(128, 35);
            this.deleteSongBtn.TabIndex = 15;
            this.deleteSongBtn.Text = "Delete song";
            this.deleteSongBtn.UseVisualStyleBackColor = false;
            this.deleteSongBtn.Click += new System.EventHandler(this.deleteSongBtn_Click);
            // 
            // deletePlaylistBtn
            // 
            this.deletePlaylistBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.deletePlaylistBtn.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlaylistBtn.Location = new System.Drawing.Point(38, 436);
            this.deletePlaylistBtn.Name = "deletePlaylistBtn";
            this.deletePlaylistBtn.Size = new System.Drawing.Size(128, 35);
            this.deletePlaylistBtn.TabIndex = 16;
            this.deletePlaylistBtn.Text = "Delete playlist";
            this.deletePlaylistBtn.UseVisualStyleBackColor = false;
            this.deletePlaylistBtn.Click += new System.EventHandler(this.deletePlaylistBtn_Click);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(736, 371);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(0, 23);
            this.labelDuration.TabIndex = 17;
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.pauseBtn.FlatAppearance.BorderSize = 0;
            this.pauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseBtn.Image = global::Mp3Player.Properties.Resources.pause_button_64px;
            this.pauseBtn.Location = new System.Drawing.Point(419, 395);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(64, 64);
            this.pauseBtn.TabIndex = 12;
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mp3Player.Properties.Resources.music2;
            this.pictureBox1.Location = new System.Drawing.Point(13, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 268);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // fileBtn
            // 
            this.fileBtn.BackColor = System.Drawing.Color.Transparent;
            this.fileBtn.FlatAppearance.BorderSize = 0;
            this.fileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileBtn.Image = global::Mp3Player.Properties.Resources.audio_file_64px;
            this.fileBtn.Location = new System.Drawing.Point(189, 395);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(64, 64);
            this.fileBtn.TabIndex = 5;
            this.fileBtn.UseVisualStyleBackColor = false;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Image = global::Mp3Player.Properties.Resources.forward_64px;
            this.nextBtn.Location = new System.Drawing.Point(502, 395);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(64, 64);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Image = global::Mp3Player.Properties.Resources.play_64px;
            this.playBtn.Location = new System.Drawing.Point(349, 395);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(64, 64);
            this.playBtn.TabIndex = 1;
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.FlatAppearance.BorderSize = 0;
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtn.Image = global::Mp3Player.Properties.Resources.back_64px;
            this.prevBtn.Location = new System.Drawing.Point(270, 395);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(64, 64);
            this.prevBtn.TabIndex = 0;
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(782, 480);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.deletePlaylistBtn);
            this.Controls.Add(this.deleteSongBtn);
            this.Controls.Add(this.volLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.audioPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.prevBtn);
            this.Name = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer audioPlayer;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label volLabel;
        private System.Windows.Forms.Button deleteSongBtn;
        private System.Windows.Forms.Button deletePlaylistBtn;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Button helpBtn;
    }
}

