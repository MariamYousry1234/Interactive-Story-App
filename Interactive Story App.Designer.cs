
namespace Interactive_Story_App
{
    partial class InteractiveStoryApp
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tbStoryIntroduction = new System.Windows.Forms.TabPage();
            this.tbBeginning = new System.Windows.Forms.TabPage();
            this.btn2TabBeginning = new System.Windows.Forms.Button();
            this.btn1TabBeginning = new System.Windows.Forms.Button();
            this.txtTabBeginning = new System.Windows.Forms.TextBox();
            this.tbMiddle = new System.Windows.Forms.TabPage();
            this.btn2TabMiddle = new System.Windows.Forms.Button();
            this.btn1TabMiddle = new System.Windows.Forms.Button();
            this.txtTabMiddle = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TabPage();
            this.txtTabEnd = new System.Windows.Forms.TextBox();
            this.btnResetStory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tbStoryIntroduction.SuspendLayout();
            this.tbBeginning.SuspendLayout();
            this.tbMiddle.SuspendLayout();
            this.tbEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tbStoryIntroduction);
            this.TabControl.Controls.Add(this.tbBeginning);
            this.TabControl.Controls.Add(this.tbMiddle);
            this.TabControl.Controls.Add(this.tbEnd);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(220, 38);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1133, 730);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 0;
            // 
            // tbStoryIntroduction
            // 
            this.tbStoryIntroduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbStoryIntroduction.Controls.Add(this.label2);
            this.tbStoryIntroduction.Controls.Add(this.btnStart);
            this.tbStoryIntroduction.Controls.Add(this.label1);
            this.tbStoryIntroduction.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStoryIntroduction.Location = new System.Drawing.Point(4, 42);
            this.tbStoryIntroduction.Name = "tbStoryIntroduction";
            this.tbStoryIntroduction.Padding = new System.Windows.Forms.Padding(3);
            this.tbStoryIntroduction.Size = new System.Drawing.Size(1125, 684);
            this.tbStoryIntroduction.TabIndex = 0;
            this.tbStoryIntroduction.Text = "Story Introduction";
            // 
            // tbBeginning
            // 
            this.tbBeginning.BackColor = System.Drawing.Color.Silver;
            this.tbBeginning.Controls.Add(this.btn2TabBeginning);
            this.tbBeginning.Controls.Add(this.btn1TabBeginning);
            this.tbBeginning.Controls.Add(this.txtTabBeginning);
            this.tbBeginning.Location = new System.Drawing.Point(4, 42);
            this.tbBeginning.Name = "tbBeginning";
            this.tbBeginning.Padding = new System.Windows.Forms.Padding(3);
            this.tbBeginning.Size = new System.Drawing.Size(1125, 684);
            this.tbBeginning.TabIndex = 1;
            this.tbBeginning.Text = "Beginning";
            // 
            // btn2TabBeginning
            // 
            this.btn2TabBeginning.BackColor = System.Drawing.Color.Lime;
            this.btn2TabBeginning.Enabled = false;
            this.btn2TabBeginning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2TabBeginning.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2TabBeginning.Location = new System.Drawing.Point(190, 500);
            this.btn2TabBeginning.Name = "btn2TabBeginning";
            this.btn2TabBeginning.Size = new System.Drawing.Size(273, 89);
            this.btn2TabBeginning.TabIndex = 5;
            this.btn2TabBeginning.Tag = "You choose to walk away.\nThe forest becomes darker, and you feel more alone.\nSoon" +
    ", you see a faint light ahead.";
            this.btn2TabBeginning.UseVisualStyleBackColor = false;
            this.btn2TabBeginning.Click += new System.EventHandler(this.btn2TabBeginning_Click);
            // 
            // btn1TabBeginning
            // 
            this.btn1TabBeginning.BackColor = System.Drawing.Color.Lime;
            this.btn1TabBeginning.Enabled = false;
            this.btn1TabBeginning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1TabBeginning.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1TabBeginning.Location = new System.Drawing.Point(688, 500);
            this.btn1TabBeginning.Name = "btn1TabBeginning";
            this.btn1TabBeginning.Size = new System.Drawing.Size(273, 89);
            this.btn1TabBeginning.TabIndex = 4;
            this.btn1TabBeginning.Tag = "You walk carefully toward the sound.\nSuddenly, you see a small injured wolf trapp" +
    "ed under a branch.\n\nThe wolf looks at you with fearful eyes.";
            this.btn1TabBeginning.UseVisualStyleBackColor = false;
            this.btn1TabBeginning.Click += new System.EventHandler(this.btn1TabBeginning_Click);
            // 
            // txtTabBeginning
            // 
            this.txtTabBeginning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTabBeginning.Enabled = false;
            this.txtTabBeginning.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabBeginning.ForeColor = System.Drawing.Color.Blue;
            this.txtTabBeginning.Location = new System.Drawing.Point(267, 56);
            this.txtTabBeginning.Multiline = true;
            this.txtTabBeginning.Name = "txtTabBeginning";
            this.txtTabBeginning.Size = new System.Drawing.Size(592, 332);
            this.txtTabBeginning.TabIndex = 3;
            // 
            // tbMiddle
            // 
            this.tbMiddle.BackColor = System.Drawing.Color.Silver;
            this.tbMiddle.Controls.Add(this.btn2TabMiddle);
            this.tbMiddle.Controls.Add(this.btn1TabMiddle);
            this.tbMiddle.Controls.Add(this.txtTabMiddle);
            this.tbMiddle.Location = new System.Drawing.Point(4, 42);
            this.tbMiddle.Name = "tbMiddle";
            this.tbMiddle.Padding = new System.Windows.Forms.Padding(3);
            this.tbMiddle.Size = new System.Drawing.Size(1125, 684);
            this.tbMiddle.TabIndex = 2;
            this.tbMiddle.Text = "Middle";
            // 
            // btn2TabMiddle
            // 
            this.btn2TabMiddle.BackColor = System.Drawing.Color.Lime;
            this.btn2TabMiddle.Enabled = false;
            this.btn2TabMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2TabMiddle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2TabMiddle.Location = new System.Drawing.Point(193, 494);
            this.btn2TabMiddle.Name = "btn2TabMiddle";
            this.btn2TabMiddle.Size = new System.Drawing.Size(273, 89);
            this.btn2TabMiddle.TabIndex = 7;
            this.btn2TabMiddle.UseVisualStyleBackColor = false;
            this.btn2TabMiddle.Click += new System.EventHandler(this.btn2TabMiddle_Click);
            // 
            // btn1TabMiddle
            // 
            this.btn1TabMiddle.BackColor = System.Drawing.Color.Lime;
            this.btn1TabMiddle.Enabled = false;
            this.btn1TabMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1TabMiddle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1TabMiddle.Location = new System.Drawing.Point(678, 494);
            this.btn1TabMiddle.Name = "btn1TabMiddle";
            this.btn1TabMiddle.Size = new System.Drawing.Size(273, 89);
            this.btn1TabMiddle.TabIndex = 6;
            this.btn1TabMiddle.UseVisualStyleBackColor = false;
            this.btn1TabMiddle.Click += new System.EventHandler(this.btn1TabMiddle_Click);
            // 
            // txtTabMiddle
            // 
            this.txtTabMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTabMiddle.Enabled = false;
            this.txtTabMiddle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabMiddle.ForeColor = System.Drawing.Color.Blue;
            this.txtTabMiddle.Location = new System.Drawing.Point(261, 58);
            this.txtTabMiddle.Multiline = true;
            this.txtTabMiddle.Name = "txtTabMiddle";
            this.txtTabMiddle.Size = new System.Drawing.Size(592, 332);
            this.txtTabMiddle.TabIndex = 5;
            // 
            // tbEnd
            // 
            this.tbEnd.BackColor = System.Drawing.Color.Silver;
            this.tbEnd.Controls.Add(this.label3);
            this.tbEnd.Controls.Add(this.btnResetStory);
            this.tbEnd.Controls.Add(this.txtTabEnd);
            this.tbEnd.Location = new System.Drawing.Point(4, 42);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Padding = new System.Windows.Forms.Padding(3);
            this.tbEnd.Size = new System.Drawing.Size(1125, 684);
            this.tbEnd.TabIndex = 3;
            this.tbEnd.Text = "End";
            // 
            // txtTabEnd
            // 
            this.txtTabEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTabEnd.Enabled = false;
            this.txtTabEnd.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabEnd.ForeColor = System.Drawing.Color.Blue;
            this.txtTabEnd.Location = new System.Drawing.Point(269, 145);
            this.txtTabEnd.Multiline = true;
            this.txtTabEnd.Name = "txtTabEnd";
            this.txtTabEnd.Size = new System.Drawing.Size(593, 350);
            this.txtTabEnd.TabIndex = 8;
            // 
            // btnResetStory
            // 
            this.btnResetStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResetStory.Enabled = false;
            this.btnResetStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetStory.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetStory.Location = new System.Drawing.Point(466, 578);
            this.btnResetStory.Name = "btnResetStory";
            this.btnResetStory.Size = new System.Drawing.Size(233, 55);
            this.btnResetStory.TabIndex = 9;
            this.btnResetStory.Text = "Reset Story";
            this.btnResetStory.UseVisualStyleBackColor = false;
            this.btnResetStory.Click += new System.EventHandler(this.btnResetStory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(154, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 350);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the story.\n\nYour choices will shape what happens next.\n\nThere are no r" +
    "ight or wrong decisions.\n\nChoose carefully.";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(449, 594);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(207, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Tag = "You wake up in a dark forest.\nThe trees are tall, and the wind is cold.\nYou hear " +
    "a strange sound coming from the left path.\n\nWhat will you do?";
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(368, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 77);
            this.label2.TabIndex = 2;
            this.label2.Text = "Let\'s Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(384, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 62);
            this.label3.TabIndex = 10;
            this.label3.Text = "End Of The Story";
            // 
            // InteractiveStoryApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 730);
            this.Controls.Add(this.TabControl);
            this.Name = "InteractiveStoryApp";
            this.Text = "Interactive Story App";
            this.TabControl.ResumeLayout(false);
            this.tbStoryIntroduction.ResumeLayout(false);
            this.tbStoryIntroduction.PerformLayout();
            this.tbBeginning.ResumeLayout(false);
            this.tbBeginning.PerformLayout();
            this.tbMiddle.ResumeLayout(false);
            this.tbMiddle.PerformLayout();
            this.tbEnd.ResumeLayout(false);
            this.tbEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tbStoryIntroduction;
        private System.Windows.Forms.TabPage tbBeginning;
        private System.Windows.Forms.TabPage tbMiddle;
        private System.Windows.Forms.TabPage tbEnd;
        private System.Windows.Forms.Button btn2TabBeginning;
        private System.Windows.Forms.Button btn1TabBeginning;
        private System.Windows.Forms.TextBox txtTabBeginning;
        private System.Windows.Forms.Button btn2TabMiddle;
        private System.Windows.Forms.Button btn1TabMiddle;
        private System.Windows.Forms.TextBox txtTabMiddle;
        private System.Windows.Forms.TextBox txtTabEnd;
        private System.Windows.Forms.Button btnResetStory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

