namespace FrameworkChallengeScreens.View
{
    partial class FormMainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.btnDevInfo = new System.Windows.Forms.Button();
            this.labelPosts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTodo
            // 
            this.btnTodo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTodo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTodo.ForeColor = System.Drawing.Color.White;
            this.btnTodo.Location = new System.Drawing.Point(12, 105);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(71, 25);
            this.btnTodo.TabIndex = 0;
            this.btnTodo.Text = "ToDo";
            this.btnTodo.UseVisualStyleBackColor = false;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnAlbums
            // 
            this.btnAlbums.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAlbums.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbums.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAlbums.ForeColor = System.Drawing.Color.White;
            this.btnAlbums.Location = new System.Drawing.Point(12, 74);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(71, 25);
            this.btnAlbums.TabIndex = 0;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.UseVisualStyleBackColor = false;
            this.btnAlbums.Click += new System.EventHandler(this.btnAlbums_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPosts.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPosts.ForeColor = System.Drawing.Color.White;
            this.btnPosts.Location = new System.Drawing.Point(12, 43);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(71, 25);
            this.btnPosts.TabIndex = 0;
            this.btnPosts.Text = "Posts";
            this.btnPosts.UseVisualStyleBackColor = false;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // btnDevInfo
            // 
            this.btnDevInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDevInfo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDevInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDevInfo.ForeColor = System.Drawing.Color.White;
            this.btnDevInfo.Location = new System.Drawing.Point(12, 12);
            this.btnDevInfo.Name = "btnDevInfo";
            this.btnDevInfo.Size = new System.Drawing.Size(71, 25);
            this.btnDevInfo.TabIndex = 1;
            this.btnDevInfo.Text = "Dev Info";
            this.btnDevInfo.UseVisualStyleBackColor = false;
            this.btnDevInfo.Click += new System.EventHandler(this.btnDevInfo_Click);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelPosts.Location = new System.Drawing.Point(89, 49);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(154, 13);
            this.labelPosts.TabIndex = 2;
            this.labelPosts.Text = "Shows posts made by Users.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(89, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shows albums created by Users.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(89, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shows tasks made by Users.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(89, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "About the application.";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(56, 5);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(187, 13);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "André Valentim | Processo Seletivo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Location = new System.Drawing.Point(-1, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 23);
            this.panel1.TabIndex = 7;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(286, 166);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.btnDevInfo);
            this.Controls.Add(this.btnPosts);
            this.Controls.Add(this.btnAlbums);
            this.Controls.Add(this.btnTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnPosts;
        private System.Windows.Forms.Button btnDevInfo;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panel1;
    }
}