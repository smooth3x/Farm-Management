using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmManagement
{
    public partial class LoadApp : Form
    {
        public LoadApp()
        {
            this.Icon = Properties.Resources.AppIcon;
            InitializeComponent();           
        }

        MainApp app = new MainApp();
        Image image;

        private void bCreateFarm_Click(object sender, EventArgs e)
        {
            if (validatedFields())
            {
                app.farm_SetSettings(tFarmName.Text, tOwnerName.Text, image);
                this.Hide();
                app.Show();
            }
        }

        private bool validatedFields()
        {
            if (tFarmName.Text == "")
            {
                MessageBox.Show("שם החווה לא יכול להיות ריק", "שגיאה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
                return false;
            } 
            else if (tOwnerName.Text == "")
            {
                MessageBox.Show("שם בעל החווה לא יכול להיות ריק", "שגיאה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
                return false;;
            }
            else if (image == null)
            {
                MessageBox.Show("חובה לעלות תמונת חווה", "שגיאה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
                return false;
            }
                

            return true;
        }

        private void tFarmName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && e.KeyChar != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tOwnerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && e.KeyChar != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void pbLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "data files (*.dat)|*.dat|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                app.FarmLoadFromFile = (FarmSave)binaryFormatter.Deserialize(stream);

                stream.Close();

                //app.FarmSaveToFile = Serializator.Deserialize<FarmSave>("farm.dat");
                app.LoadFromFile();

                this.Hide();
                app.Refresh();
                app.Show();
            }
        }

        private void pbUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(opnfd.FileName);
                pbV.Show();
            }
        }
    }
}
