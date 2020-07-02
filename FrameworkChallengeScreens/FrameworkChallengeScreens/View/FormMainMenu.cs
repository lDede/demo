using System;
using System.Windows.Forms;

namespace FrameworkChallengeScreens.View
{
    public partial class FormMainMenu : Form {

        /// <summary>
        /// Initialize Form.
        /// </summary>
        public FormMainMenu() {
            InitializeComponent();
        }

        /// <summary>
        /// Button click that shows TodoList form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTodo_Click(object sender, EventArgs e)
        {
            FormToDos form = new FormToDos();
            form.ShowDialog();
        }

        /// <summary>
        /// Button click that shows Albums form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlbums_Click(object sender, EventArgs e)
        {
            FormAlbums form = new FormAlbums();
            form.ShowDialog();
        }

        /// <summary>
        /// Button click that shows Posts form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPosts_Click(object sender, EventArgs e)
        {
            FormPosts form = new FormPosts();
            form.ShowDialog();
        }

        /// <summary>
        /// Button click that shows MessageBox with application objective.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
}