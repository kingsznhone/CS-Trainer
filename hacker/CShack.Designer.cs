namespace hacker
{
    partial class CShack
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
            this.AmmoHack = new System.Windows.Forms.Button();
            this.LockTimer = new System.Windows.Forms.Timer(this.components);
            this.AmmoLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmmoHack
            // 
            this.AmmoHack.Location = new System.Drawing.Point(93, 91);
            this.AmmoHack.Name = "AmmoHack";
            this.AmmoHack.Size = new System.Drawing.Size(100, 43);
            this.AmmoHack.TabIndex = 1;
            this.AmmoHack.Text = "Lock";
            this.AmmoHack.UseVisualStyleBackColor = true;
            this.AmmoHack.Click += new System.EventHandler(this.AmmoHack_Click);
            // 
            // LockTimer
            // 
            this.LockTimer.Interval = 10;
            this.LockTimer.Tick += new System.EventHandler(this.LockTimer_Tick);
            // 
            // AmmoLB
            // 
            this.AmmoLB.AutoSize = true;
            this.AmmoLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AmmoLB.Location = new System.Drawing.Point(228, 18);
            this.AmmoLB.Name = "AmmoLB";
            this.AmmoLB.Size = new System.Drawing.Size(28, 31);
            this.AmmoLB.TabIndex = 3;
            this.AmmoLB.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primary Weapon:";
            // 
            // CShack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmmoLB);
            this.Controls.Add(this.AmmoHack);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CShack";
            this.Text = "CShack";
            this.Load += new System.EventHandler(this.CShack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AmmoHack;
        private System.Windows.Forms.Timer LockTimer;
        private System.Windows.Forms.Label AmmoLB;
        private System.Windows.Forms.Label label1;
    }
}