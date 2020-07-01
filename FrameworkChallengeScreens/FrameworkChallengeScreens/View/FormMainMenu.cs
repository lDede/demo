using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrameworkChallengeScreens {
    public partial class FormMainMenu : Form {
        public FormMainMenu() {
            InitializeComponent();
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            FormToDos form = new FormToDos();
            form.ShowDialog();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            FormAlbums form = new FormAlbums();
            form.ShowDialog();
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            FormPosts form = new FormPosts();
            form.ShowDialog();
        }
    }
}
