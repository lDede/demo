using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrameworkChallengeScreens.Control;

namespace FrameworkChallengeScreens.View
{
    public partial class FormToDos : Form
    {
        // Local atribbutes
        SendRequest sendRequest = new SendRequest();
        List<Users> users = new List<Users>();
        int currentComboBoxIndex;


        /// <summary>
        /// Initialize Form.
        /// </summary>
        public FormToDos() {
            InitializeComponent();
        }

        /// <summary>
        /// Run after load Initialize Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormToDos_Load(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        /// <summary>
        /// Store values in local atribbutes and update DataGridView.
        /// </summary>
        private void RefreshUserList()
        {
            // Retrieve all users from .json File
            users = sendRequest.RequestUsers();

            // Set Name from users in ComboBox
            foreach (Users user in users)
                comboBoxUsersList.Items.Add(user.Name);

            // Set 0 as default ComboBox selected value.
            comboBoxUsersList.SelectedIndex = 0;

            // Store current combobox index
            currentComboBoxIndex = comboBoxUsersList.SelectedIndex;

            // Send current combobox index and sum one to fill DataGridView with selected user ID.
            RefreshDataGrid(currentComboBoxIndex + 1);
        }

        /// <summary>
        /// Update DataGridView with Selected User.
        /// </summary>
        /// <param name="id">ID from selected user.</param>
        private void RefreshDataGrid(int id)
        {
            try
            {
                // Get List of Todos
                List<Todos> userTodos = sendRequest.RequestToDosByUser(id);
                dataGridViewAlbums.DataSource = null;

                // Fill datagridview
                dataGridViewAlbums.DataSource = userTodos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message + "\nSource : " + ex.Source, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Run after change selected user from ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxUsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentComboBoxIndex = comboBoxUsersList.SelectedIndex;
            RefreshDataGrid(currentComboBoxIndex + 1);
        }

        /// <summary>
        /// Shows MessageBox with all personal informations of selected user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            foreach (Users user in users)
            {
                if (user.ID == (currentComboBoxIndex + 1))
                {
                    MessageBox.Show("---------------------------------------------" + "\n"
                                    + "Personal Information" + "\n"
                                    + "---------------------------------------------" + "\n"
                                    + "ID: " + user.ID + "\n"
                                    + "Name: " + user.Name + "\n"
                                    + "Username: " + user.Username + "\n"
                                    + "Phone: " + user.Phone + "\n"
                                    + "Website: " + user.Website + "\n"
                                    + "---------------------------------------------" + "\n"
                                    + "Address" + "\n"
                                    + "---------------------------------------------" + "\n"
                                    + "Street: " + user.Address.Street + "\n"
                                    + "Suite: " + user.Address.Suite + "\n"
                                    + "City: " + user.Address.City + "\n"
                                    + "Zipcode: " + user.Address.Zipcode + "\n"
                                    + "Latitude: " + user.Address.Geo.Lat + "\n"
                                    + "Longitude: " + user.Address.Geo.Lng + "\n"
                                    + "---------------------------------------------" + "\n"
                                    + "Company" + "\n"
                                    + "---------------------------------------------" + "\n"
                                    + "Name: " + user.Company.Name + "\n"
                                    + "CatchPhrase: " + user.Company.CatchPhrase + "\n"
                                    + "BS: " + user.Company.BS + "\n", "Personal Information of " + user.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
    }
}