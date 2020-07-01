namespace FrameworkChallengeScreens
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
            this.SuspendLayout();
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(116, 79);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(64, 20);
            this.btnTodo.TabIndex = 0;
            this.btnTodo.Text = "ToDo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnAlbums
            // 
            this.btnAlbums.Location = new System.Drawing.Point(116, 27);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(64, 20);
            this.btnAlbums.TabIndex = 0;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.UseVisualStyleBackColor = true;
            this.btnAlbums.Click += new System.EventHandler(this.btnAlbums_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.Location = new System.Drawing.Point(116, 53);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(64, 20);
            this.btnPosts.TabIndex = 0;
            this.btnPosts.Text = "Posts";
            this.btnPosts.UseVisualStyleBackColor = true;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 140);
            this.Controls.Add(this.btnPosts);
            this.Controls.Add(this.btnAlbums);
            this.Controls.Add(this.btnTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnPosts;
    }
}