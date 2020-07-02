using System;
using System.Windows.Forms;

namespace FrameworkChallengeScreens.View
{
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

        private void btnDevInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application made for use GETS from an .json file type from the API 'https://jsonplaceholder.typicode.com/'" + "\n\n"
                            + "Candidate: André de Sousa Valentim" + "\n"
                            + "Made in Visual Studio" + "\n"
                            + "Programming Language: C#" + "\n"
                            + "Year: 2020" + "\n"
                            + AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName + "\n"
                            , "Development Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}