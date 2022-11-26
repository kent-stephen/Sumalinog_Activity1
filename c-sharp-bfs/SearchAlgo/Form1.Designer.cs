namespace SearchAlgo
{
    partial class Sumalinog_Activity1_BFS
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
            this.btn_find = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cb_Select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.SystemColors.Control;
            this.btn_find.Location = new System.Drawing.Point(209, 52);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 21);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Find Path";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.button1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(32, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 5;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(209, 79);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 22);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "Reset Maze";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_Select
            // 
            this.cb_Select.FormattingEnabled = true;
            this.cb_Select.Items.AddRange(new object[] {
            "Start",
            "Goal",
            "Obstacle"});
            this.cb_Select.Location = new System.Drawing.Point(35, 42);
            this.cb_Select.Name = "cb_Select";
            this.cb_Select.Size = new System.Drawing.Size(121, 21);
            this.cb_Select.TabIndex = 7;
            this.cb_Select.SelectedIndexChanged += new System.EventHandler(this.cb_Select_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose what to do:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sumalinog_Activity1_BFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Select);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn_find);
            this.Name = "Sumalinog_Activity1_BFS";
            this.Text = "Sumalinog_Activity1_BFS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cb_Select;
        private System.Windows.Forms.Label label1;
    }
}

