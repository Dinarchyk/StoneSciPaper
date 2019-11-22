namespace StoneSciPaper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startGame = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startGame.BackgroundImage")));
            this.startGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startGame.Font = new System.Drawing.Font("Super Mario 286(RUS BY LYAJKA)", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGame.ForeColor = System.Drawing.Color.Red;
            this.startGame.Location = new System.Drawing.Point(268, 64);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(301, 107);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.White;
            this.instructions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("instructions.BackgroundImage")));
            this.instructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.instructions.Font = new System.Drawing.Font("Super Mario 286(RUS BY LYAJKA)", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instructions.ForeColor = System.Drawing.Color.Red;
            this.instructions.Location = new System.Drawing.Point(268, 196);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(301, 107);
            this.instructions.TabIndex = 1;
            this.instructions.Text = "Instuctions";
            this.instructions.UseVisualStyleBackColor = false;
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 601);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.startGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 640);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stone Scissors Paper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button instructions;
    }
}

