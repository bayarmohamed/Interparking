using FilesLibrary;
using FilesLibrary.Factory;
using FilesLibrary.Strategies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterparkingClientApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CboFileTypes.Text))
                {
                    MessageBox.Show("Missed type of file");
                    CboFileTypes.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPath.Text))
                {
                    MessageBox.Show("Missed file");
                    txtPath.Focus();
                    return;
                }

                var file = FileFactory.GetFile(CboFileTypes.Text);
                var content = file.ReadFile(txtPath.Text);

                Client client = new Client();
                client.File = content;

                if (ChkEncryption.Checked)
                {
                    client.SetStrategy(new Encryption());
                }

                if (ChkUseRole.Checked)
                {
                    if (string.IsNullOrEmpty(CboRoles.Text))
                    {
                        MessageBox.Show("Missed Role");
                        CboRoles.Focus();
                        return;
                    }
                    client.SetStrategy(new Role(CboRoles.Text));
                }

               txtFileContent.Text = client.File;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CboFileTypes.Items.Add(typeof(TxTFile).Name);
            CboFileTypes.Items.Add(typeof(JsonFile).Name);
            CboFileTypes.Items.Add(typeof(XmLFile).Name);


            CboRoles.Items.Add("Admin");
        }

        private void btnFileSearch_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            f.ShowDialog();
            txtPath.Text = f.FileName;

        }
    }
}
