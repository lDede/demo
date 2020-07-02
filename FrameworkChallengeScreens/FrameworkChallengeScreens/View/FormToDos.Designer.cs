using System.Drawing;

namespace FrameworkChallengeScreens.View
{
    partial class FormToDos {
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
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboBoxUsersList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.dataGridViewAlbums = new System.Windows.Forms.DataGridView();
            this.panelAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUserInfo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnUserInfo.Location = new System.Drawing.Point(356, 325);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(166, 23);
            this.btnUserInfo.TabIndex = 13;
            this.btnUserInfo.Text = "See Personal Infomation...";
            this.btnUserInfo.UseVisualStyleBackColor = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelUser.Location = new System.Drawing.Point(17, 327);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(90, 17);
            this.labelUser.TabIndex = 12;
            this.labelUser.Text = "Change User:";
            // 
            // comboBoxUsersList
            // 
            this.comboBoxUsersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUsersList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsersList.FormattingEnabled = true;
            this.comboBoxUsersList.Location = new System.Drawing.Point(114, 327);
            this.comboBoxUsersList.Name = "comboBoxUsersList";
            this.comboBoxUsersList.Size = new System.Drawing.Size(160, 21);
            this.comboBoxUsersList.TabIndex = 11;
            this.comboBoxUsersList.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsersList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 23);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "ToDo List";
            // 
            // panelAlbums
            // 
            this.panelAlbums.Controls.Add(this.dataGridViewAlbums);
            this.panelAlbums.Location = new System.Drawing.Point(9, 47);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(526, 272);
            this.panelAlbums.TabIndex = 9;
            // 
            // dataGridViewAlbums
            // 
            this.dataGridViewAlbums.AllowUserToAddRows = false;
            this.dataGridViewAlbums.AllowUserToDeleteRows = false;
            this.dataGridViewAlbums.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAlbums.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlbums.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 35);
            this.dataGridViewAlbums.Name = "dataGridViewAlbums";
            this.dataGridViewAlbums.ReadOnly = true;
            this.dataGridViewAlbums.Size = new System.Drawing.Size(501, 247);
            this.dataGridViewAlbums.TabIndex = 0;
            // 
            // FormToDos
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 382);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxUsersList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormToDos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormToDos_FormClosed);
            this.Load += new System.EventHandler(this.FormToDos_Load);
            this.panelAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboBoxUsersList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.DataGridView dataGridViewAlbums;
    }
}