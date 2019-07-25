using System;
using System.Windows.Forms;
using Serwis.DatabaseOperations;

namespace Serwis
{
    public partial class ClientEditForm : Form
    {
        int id;
        string name,phone,email,annotation;
        private ClientsManagement _client;

        private void ClientEditForm_SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientEditForm_EmailTextBox.Text) || ClientEditForm_EmailTextBox.Text.Contains("@"))
            {
                if (string.IsNullOrWhiteSpace(ClientEditForm_NameTextBox.Text) == false)
                {
                    _client.UpdateClientById(id,
                        name = ClientEditForm_NameTextBox.Text,
                        phone = ClientEditForm_PhoneTextBox.Text,
                        email = ClientEditForm_EmailTextBox.Text,
                        annotation = ClientEditForm_AnnotationTextBox.Text);
                     Close();
                }
                else
                {
                    MessageBox.Show(Messages.ClientEditForm_EmptyName);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Messages.ClientEditForm_IncorrectEmail);
                return;
            }
        }

        public ClientEditForm(int initialId, string initialName, string initialPhone, string initialEmail, string initialAnnotation)
        {
            InitializeComponent();

            _client = ClientsManagement.GetInstance();

            id = initialId;

            ClientEditForm_NameTextBox.Text = name = initialName;
            ClientEditForm_PhoneTextBox.Text = phone = initialPhone;
            ClientEditForm_EmailTextBox.Text = email = initialEmail;
            ClientEditForm_AnnotationTextBox.Text = annotation = initialAnnotation;
        }

        private void ClientEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ClientEditForm_NameTextBox.Text != name || 
                ClientEditForm_PhoneTextBox.Text != phone ||
                ClientEditForm_EmailTextBox.Text != email ||
                ClientEditForm_AnnotationTextBox.Text != annotation)
            {

                DialogResult dialogResult = MessageBox.Show(Messages.SaveChanges, Messages.Attention, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(ClientEditForm_EmailTextBox.Text) || ClientEditForm_EmailTextBox.Text.Contains("@"))
                    {
                        if (string.IsNullOrWhiteSpace(ClientEditForm_NameTextBox.Text) == false)
                        {
                            _client.UpdateClientById(id,
                                ClientEditForm_NameTextBox.Text,
                                ClientEditForm_PhoneTextBox.Text,
                                ClientEditForm_EmailTextBox.Text,
                                ClientEditForm_AnnotationTextBox.Text);
                        }
                        else
                        {
                            MessageBox.Show(Messages.ClientEditForm_EmptyName);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Messages.ClientEditForm_IncorrectEmail);
                        return;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
               
        }
    }
}
