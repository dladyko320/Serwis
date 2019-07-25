using System.Windows.Forms;
using Serwis.DatabaseOperations;

namespace Serwis
{
    public partial class DeviceEditForm : Form
    {
        int id, type;
        string name, imei, annotation;
        private DevicesManagement _device;

        private void DeviceEditForm_SaveButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DeviceEditForm_NameTextBox.Text) == false)
            {
                _device.UpdateDeviceById(id,
                    name = DeviceEditForm_NameTextBox.Text,
                    type = DeviceEditForm_TypeComboBox.SelectedIndex,
                    imei = DeviceEditForm_ImeiTextBox.Text,
                    annotation = DeviceEditForm_AnnotationTextBox.Text);
                 Close();
            }
            else
            {
                MessageBox.Show(Messages.DeviceEditForm_EmptyName);
            }
        }

        private void DeviceEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DeviceEditForm_NameTextBox.Text != name ||
                DeviceEditForm_TypeComboBox.SelectedIndex != type ||
                DeviceEditForm_ImeiTextBox.Text != imei ||
                DeviceEditForm_AnnotationTextBox.Text != annotation)
            {

                DialogResult dialogResult = MessageBox.Show(Messages.SaveChanges, Messages.Attention, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(DeviceEditForm_NameTextBox.Text) == false)
                    {
                        _device.UpdateDeviceById(id,
                            DeviceEditForm_NameTextBox.Text,
                            DeviceEditForm_TypeComboBox.SelectedIndex,
                            DeviceEditForm_ImeiTextBox.Text,
                            DeviceEditForm_AnnotationTextBox.Text);
                         MessageBox.Show(Messages.ChangesSaved);
                    }
                    else
                    {
                        MessageBox.Show(Messages.DeviceEditForm_EmptyName);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }

        public DeviceEditForm(int initialId, string initialName, int initialType, string initialImei, string initialAnnotation)
        {
            InitializeComponent();

            _device = DevicesManagement.GetInstance();

            id = initialId;

            DeviceEditForm_NameTextBox.Text = name = initialName;
            DeviceEditForm_TypeComboBox.SelectedIndex = type = initialType;
            DeviceEditForm_ImeiTextBox.Text = imei = initialImei;
            DeviceEditForm_AnnotationTextBox.Text = annotation = initialAnnotation;

        }
    }
}
