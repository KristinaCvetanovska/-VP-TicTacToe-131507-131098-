namespace TicTacToe
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
            this.btnPvsPC = new System.Windows.Forms.Button();
            this.btnPvsP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPvsPC
            // 
            this.btnPvsPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.btnPvsPC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPvsPC.Location = new System.Drawing.Point(184, 40);
            this.btnPvsPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPvsPC.Name = "btnPvsPC";
            this.btnPvsPC.Size = new System.Drawing.Size(157, 34);
            this.btnPvsPC.TabIndex = 0;
            this.btnPvsPC.Text = "Player vs PC";
            this.btnPvsPC.UseVisualStyleBackColor = false;
            this.btnPvsPC.Click += new System.EventHandler(this.btnPvsPC_Click);
            // 
            // btnPvsP
            // 
            this.btnPvsP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.btnPvsP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPvsP.Location = new System.Drawing.Point(184, 90);
            this.btnPvsP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPvsP.Name = "btnPvsP";
            this.btnPvsP.Size = new System.Drawing.Size(157, 34);
            this.btnPvsP.TabIndex = 1;
            this.btnPvsP.Text = "Player vs Player";
            this.btnPvsP.UseVisualStyleBackColor = false;
            this.btnPvsP.Click += new System.EventHandler(this.btnPvsP_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.TicTacToe_Bluetooth_Icon;
            this.ClientSize = new System.Drawing.Size(511, 512);
            this.Controls.Add(this.btnPvsP);
            this.Controls.Add(this.btnPvsPC);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(529, 557);
            this.MinimumSize = new System.Drawing.Size(529, 557);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPvsPC;
        private System.Windows.Forms.Button btnPvsP;
    }
}

