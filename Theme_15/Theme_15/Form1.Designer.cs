
namespace Theme_15
{
    partial class tamagochiUE
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
            this.imges = new System.Windows.Forms.PictureBox();
            this.goodAction_lbl = new System.Windows.Forms.Label();
            this.badAction_lbl = new System.Windows.Forms.Label();
            this.start_lbl = new System.Windows.Forms.Label();
            this.help_btn = new System.Windows.Forms.Label();
            this.badActionTimer_pb = new System.Windows.Forms.ProgressBar();
            this.animation_tmr = new System.Windows.Forms.Timer(this.components);
            this.generateRequest_tmr = new System.Windows.Forms.Timer(this.components);
            this.badAction_tmr = new System.Windows.Forms.Timer(this.components);
            this.whatsUpReactionShowcase_tmr = new System.Windows.Forms.Timer(this.components);
            this.activities_tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imges)).BeginInit();
            this.SuspendLayout();
            // 
            // imges
            // 
            this.imges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imges.Location = new System.Drawing.Point(0, 0);
            this.imges.Name = "imges";
            this.imges.Size = new System.Drawing.Size(380, 380);
            this.imges.TabIndex = 0;
            this.imges.TabStop = false;
            // 
            // goodAction_lbl
            // 
            this.goodAction_lbl.Enabled = false;
            this.goodAction_lbl.Location = new System.Drawing.Point(0, 380);
            this.goodAction_lbl.Name = "goodAction_lbl";
            this.goodAction_lbl.Size = new System.Drawing.Size(190, 40);
            this.goodAction_lbl.TabIndex = 1;
            this.goodAction_lbl.Text = "Good action";
            this.goodAction_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goodAction_lbl.Click += new System.EventHandler(this.goodAction_lbl_Click);
            this.goodAction_lbl.MouseEnter += new System.EventHandler(this.goodAction_lbl_MouseEnter);
            this.goodAction_lbl.MouseLeave += new System.EventHandler(this.goodAction_lbl_MouseLeave);
            // 
            // badAction_lbl
            // 
            this.badAction_lbl.Enabled = false;
            this.badAction_lbl.Location = new System.Drawing.Point(0, 420);
            this.badAction_lbl.Name = "badAction_lbl";
            this.badAction_lbl.Size = new System.Drawing.Size(190, 40);
            this.badAction_lbl.TabIndex = 2;
            this.badAction_lbl.Text = "Bad action";
            this.badAction_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.badAction_lbl.Click += new System.EventHandler(this.badAction_lbl_Click);
            this.badAction_lbl.MouseEnter += new System.EventHandler(this.badAction_lbl_MouseEnter);
            this.badAction_lbl.MouseLeave += new System.EventHandler(this.badAction_lbl_MouseLeave);
            // 
            // start_lbl
            // 
            this.start_lbl.BackColor = System.Drawing.Color.MistyRose;
            this.start_lbl.Location = new System.Drawing.Point(190, 380);
            this.start_lbl.Name = "start_lbl";
            this.start_lbl.Size = new System.Drawing.Size(190, 40);
            this.start_lbl.TabIndex = 3;
            this.start_lbl.Text = "Start";
            this.start_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_lbl.Click += new System.EventHandler(this.start_lbl_Click);
            this.start_lbl.MouseEnter += new System.EventHandler(this.start_lbl_MouseEnter);
            this.start_lbl.MouseLeave += new System.EventHandler(this.start_lbl_MouseLeave);
            // 
            // help_btn
            // 
            this.help_btn.Location = new System.Drawing.Point(190, 420);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(190, 40);
            this.help_btn.TabIndex = 4;
            this.help_btn.Text = "Help";
            this.help_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            this.help_btn.MouseEnter += new System.EventHandler(this.help_btn_MouseEnter);
            this.help_btn.MouseLeave += new System.EventHandler(this.help_btn_MouseLeave);
            // 
            // badActionTimer_pb
            // 
            this.badActionTimer_pb.Location = new System.Drawing.Point(0, 460);
            this.badActionTimer_pb.Name = "badActionTimer_pb";
            this.badActionTimer_pb.Size = new System.Drawing.Size(380, 23);
            this.badActionTimer_pb.TabIndex = 5;
            this.badActionTimer_pb.Click += new System.EventHandler(this.badActionTimer_pb_Click);
            // 
            // animation_tmr
            // 
            this.animation_tmr.Interval = 500;
            this.animation_tmr.Tick += new System.EventHandler(this.animation_tmr_Tick);
            // 
            // generateRequest_tmr
            // 
            this.generateRequest_tmr.Interval = 1000;
            this.generateRequest_tmr.Tick += new System.EventHandler(this.generateRequest_tmr_Tick);
            // 
            // badAction_tmr
            // 
            this.badAction_tmr.Interval = 1000;
            this.badAction_tmr.Tick += new System.EventHandler(this.badAction_tmr_Tick);
            // 
            // whatsUpReactionShowcase_tmr
            // 
            this.whatsUpReactionShowcase_tmr.Interval = 1000;
            this.whatsUpReactionShowcase_tmr.Tick += new System.EventHandler(this.whatsUpReactionShowcase_tmr_Tick);
            // 
            // activities_tmr
            // 
            this.activities_tmr.Interval = 500;
            this.activities_tmr.Tick += new System.EventHandler(this.activities_tmr_Tick);
            // 
            // tamagochiUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(384, 481);
            this.Controls.Add(this.badActionTimer_pb);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.start_lbl);
            this.Controls.Add(this.badAction_lbl);
            this.Controls.Add(this.goodAction_lbl);
            this.Controls.Add(this.imges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "tamagochiUE";
            this.Opacity = 0.75D;
            this.Text = "Tamagochi_ultimate_edition";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imges;
        private System.Windows.Forms.Label goodAction_lbl;
        private System.Windows.Forms.Label badAction_lbl;
        private System.Windows.Forms.Label start_lbl;
        private System.Windows.Forms.Label help_btn;
        private System.Windows.Forms.ProgressBar badActionTimer_pb;
        private System.Windows.Forms.Timer animation_tmr;
        private System.Windows.Forms.Timer generateRequest_tmr;
        private System.Windows.Forms.Timer badAction_tmr;
        private System.Windows.Forms.Timer whatsUpReactionShowcase_tmr;
        private System.Windows.Forms.Timer activities_tmr;
    }
}

