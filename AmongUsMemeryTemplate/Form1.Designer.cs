using System.Threading;
using System;
using System.Windows.Forms;

namespace AmongUsMemeryTemplate
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
            this.ClientImposter = new System.Windows.Forms.CheckBox();
            this.ClientDead = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.Label();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.SpeedTitle = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.KillTimerBar = new System.Windows.Forms.TrackBar();
            this.KillTimer = new System.Windows.Forms.Label();
            this.ImpostersTitle = new System.Windows.Forms.Label();
            this.imposterlist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KillTimerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientImposter
            // 
            this.ClientImposter.AutoSize = true;
            this.ClientImposter.Location = new System.Drawing.Point(178, 159);
            this.ClientImposter.Margin = new System.Windows.Forms.Padding(4);
            this.ClientImposter.Name = "ClientImposter";
            this.ClientImposter.Size = new System.Drawing.Size(122, 22);
            this.ClientImposter.TabIndex = 0;
            this.ClientImposter.Text = "ClientImposter";
            this.ClientImposter.UseVisualStyleBackColor = true;
            this.ClientImposter.CheckedChanged += new System.EventHandler(this.Imposter_CheckedChanged);
            // 
            // ClientDead
            // 
            this.ClientDead.AutoSize = true;
            this.ClientDead.Location = new System.Drawing.Point(178, 215);
            this.ClientDead.Margin = new System.Windows.Forms.Padding(4);
            this.ClientDead.Name = "ClientDead";
            this.ClientDead.Size = new System.Drawing.Size(99, 22);
            this.ClientDead.TabIndex = 2;
            this.ClientDead.Text = "ClientDead";
            this.ClientDead.UseVisualStyleBackColor = true;
            this.ClientDead.CheckedChanged += new System.EventHandler(this.Dead_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(246, 39);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(268, 39);
            this.title.TabIndex = 3;
            this.title.Text = "Among Us Hack";
            // 
            // SpeedBar
            // 
            this.SpeedBar.Location = new System.Drawing.Point(137, 288);
            this.SpeedBar.Maximum = 20;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(197, 45);
            this.SpeedBar.TabIndex = 4;
            this.SpeedBar.ValueChanged += new System.EventHandler(this.SpeedBar_ValueChanged);
            // 
            // SpeedTitle
            // 
            this.SpeedTitle.AutoSize = true;
            this.SpeedTitle.Location = new System.Drawing.Point(203, 267);
            this.SpeedTitle.Name = "SpeedTitle";
            this.SpeedTitle.Size = new System.Drawing.Size(50, 18);
            this.SpeedTitle.TabIndex = 5;
            this.SpeedTitle.Text = "Speed";
            // 
            // KillTimerBar
            // 
            this.KillTimerBar.Location = new System.Drawing.Point(137, 380);
            this.KillTimerBar.Maximum = 20;
            this.KillTimerBar.Name = "KillTimerBar";
            this.KillTimerBar.Size = new System.Drawing.Size(197, 45);
            this.KillTimerBar.TabIndex = 6;
            this.KillTimerBar.ValueChanged += new System.EventHandler(this.KillTimer_ValueChanged);
            // 
            // KillTimer
            // 
            this.KillTimer.AutoSize = true;
            this.KillTimer.Location = new System.Drawing.Point(203, 359);
            this.KillTimer.Name = "KillTimer";
            this.KillTimer.Size = new System.Drawing.Size(65, 18);
            this.KillTimer.TabIndex = 7;
            this.KillTimer.Text = "KillTimer";
            // 
            // ImpostersTitle
            // 
            this.ImpostersTitle.AutoSize = true;
            this.ImpostersTitle.Location = new System.Drawing.Point(478, 159);
            this.ImpostersTitle.Name = "ImpostersTitle";
            this.ImpostersTitle.Size = new System.Drawing.Size(78, 18);
            this.ImpostersTitle.TabIndex = 8;
            this.ImpostersTitle.Text = "Imposters:";
            // 
            // imposterlist
            // 
            this.imposterlist.AutoSize = true;
            this.imposterlist.Location = new System.Drawing.Point(481, 194);
            this.imposterlist.Name = "imposterlist";
            this.imposterlist.Size = new System.Drawing.Size(0, 18);
            this.imposterlist.TabIndex = 9;
            this.imposterlist.Text = "init";

            ///
            //Detector thread loop
            ///
            


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1200, 586);
            this.Controls.Add(this.imposterlist);
            this.Controls.Add(this.ImpostersTitle);
            this.Controls.Add(this.KillTimer);
            this.Controls.Add(this.KillTimerBar);
            this.Controls.Add(this.SpeedTitle);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ClientDead);
            this.Controls.Add(this.ClientImposter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "AmongUsMemory";

            var ImposterThread = new Thread(() => this.updateImposters());
            ImposterThread.Start();

            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KillTimerBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void updateImposters()
        {
            while (Globals.running)
            {
                if (imposterlist.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(() => imposterlist.Text = string.Join(", ", Globals.imposters)));
                }
                else
                {
                    imposterlist.Text = string.Join(", ", Globals.imposters);
                }
            }
        }
        #endregion

        private System.Windows.Forms.CheckBox ClientImposter;
        private System.Windows.Forms.CheckBox ClientDead;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.Label SpeedTitle;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar KillTimerBar;
        private System.Windows.Forms.Label KillTimer;
        private System.Windows.Forms.Label ImpostersTitle;
        private System.Windows.Forms.Label imposterlist;
    }
}

