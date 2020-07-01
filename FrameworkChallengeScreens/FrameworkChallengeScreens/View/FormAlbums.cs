using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FrameworkChallengeScreens.Control;

namespace FrameworkChallengeScreens
{
    public partial class FormAlbums : Form {

        SendRequest sendRequest = new SendRequest();
        public FormAlbums() {
            InitializeComponent();
        }

        private void FormAlbums_Load(object sender, EventArgs e) {
            RefreshDataGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            try
            {
                List<Albums> userAlbums = sendRequest.RequestAlbums();
                dataGridViewAlbums.Rows.Clear();
                foreach (Albums value in userAlbums)
                    dataGridViewAlbums.Rows.Add(value.ID, value.Title);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceção: " + ex.Message + "\nLocal : " + ex.Source, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Albums album = new Albums();
                album.Title = "Flush";
                album.UserId = 1;
                sendRequest.CreateAlbum(album);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceção: " + ex.Message + "\nLocal : " + ex.Source, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
