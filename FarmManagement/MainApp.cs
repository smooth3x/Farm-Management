using FarmManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmManagement
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            this.Icon = Properties.Resources.AppIcon;
            InitializeComponent();
        }

        Point rightClickPos;
        bool isDragging = false;
        int DragginAreaIndex = -1;

        //--- Creates New Farm Class: Includes Blank SectionList & Blank Settings ---
        Farm farm = new Farm();
        FarmSave farmSaveToFile = new FarmSave();
        FarmSave farmLoadFromFile = new FarmSave();

        //--- Right Click Menu - Adding Areas ---
        private void אורווהToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            farm.Map.Sections.AddNewSection(0, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(animalInfoPanel, 0, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(0, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(0, farm.Map.Sections.GetLastId());
        }
        private void רפתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(1, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(animalInfoPanel, 1, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(1, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(1, farm.Map.Sections.GetLastId());
        }
        private void לולToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(2, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(animalInfoPanel, 2, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(2, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(2, farm.Map.Sections.GetLastId());
        }
        private void דירToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(3, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(animalInfoPanel, 3, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(3, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(3, farm.Map.Sections.GetLastId());
        }
        private void מחסךתבואהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(4, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(mainInfoPanel, 4, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(4, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(4, farm.Map.Sections.GetLastId());
        }
        private void מוסךתחזוקהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(5, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(garageInfoPanel, 5, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(5, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(5, farm.Map.Sections.GetLastId());
        }
        private void עלינענעToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(6, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(vegInfoPanel, 6, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(6, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(6, farm.Map.Sections.GetLastId());
        }
        private void גזריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(7, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(vegInfoPanel, 7, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(7, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(7, farm.Map.Sections.GetLastId());
        }
        private void לימוניםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(8, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(vegInfoPanel, 8, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(8, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(8, farm.Map.Sections.GetLastId());
        }
        private void תפוזיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(9, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(vegInfoPanel, 9, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(9, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(9, farm.Map.Sections.GetLastId());
        }
        private void תפוחיאדמהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(10, rightClickPos.X, rightClickPos.Y, farmPanel);
            farm.Map.Buildings.AddNewBuilding(vegInfoPanel, 10, farm.Map.Sections.GetLastId());

            farmSaveToFile.Map.Sections.AddNewSection(10, rightClickPos.X, rightClickPos.Y);
            farmSaveToFile.Map.Buildings.AddNewBuilding(10, farm.Map.Sections.GetLastId());
        }
        private void טרקטורToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(11, rightClickPos.X, rightClickPos.Y, farmPanel);
            farmSaveToFile.Map.Sections.AddNewSection(11, rightClickPos.X, rightClickPos.Y);
        }
        private void טנדרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(12, rightClickPos.X, rightClickPos.Y, farmPanel);
            farmSaveToFile.Map.Sections.AddNewSection(12, rightClickPos.X, rightClickPos.Y);
        }
        private void מכסחהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farm.Map.Sections.AddNewSection(13, rightClickPos.X, rightClickPos.Y, farmPanel);
            farmSaveToFile.Map.Sections.AddNewSection(13, rightClickPos.X, rightClickPos.Y);
        }

        //--- PictureBox Areas Mouse Events ---
        private void farmPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rightClickPos = farmPanel.PointToClient(Cursor.Position);
            }
        }
        private void picture_MouseHover(object sender, EventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            image.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(image.Name + "_hover");
            //image.Size = new System.Drawing.Size(49, 46);
        }
        private void picture_MouseLeave(object sender, EventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            image.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(image.Name);
            //image.Size = new System.Drawing.Size(46, 43);
        }
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox _imageControl = (PictureBox)sender;
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
            {
                isDragging = true;

                if (_imageControl.Name.Contains("Stable"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurStable));
                    DragginAreaIndex = 0;
                }
                else if (_imageControl.Name.Contains("Hen"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurHen));
                    DragginAreaIndex = 1;
                }
                else if (_imageControl.Name.Contains("Cowshed"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurCowshed));
                    DragginAreaIndex = 2;
                }
                else if (_imageControl.Name.Contains("Pen"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurPen));
                    DragginAreaIndex = 3;
                }
                else if (_imageControl.Name.Contains("Hay"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurHay));
                    DragginAreaIndex = 4;
                }
                else if (_imageControl.Name.Contains("Garage"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurGarage));
                    DragginAreaIndex = 5;
                }
                else if (_imageControl.Name.Contains("Mint"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurMint));
                    DragginAreaIndex = 6;
                }
                else if (_imageControl.Name.Contains("Carrot"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurCarrot));
                    DragginAreaIndex = 7;
                }
                else if (_imageControl.Name.Contains("Lemon"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurLemon));
                    DragginAreaIndex = 8;
                }
                else if (_imageControl.Name.Contains("Orange"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurOrange));
                    DragginAreaIndex = 9;
                }
                else if (_imageControl.Name.Contains("Potato"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurPotato));
                    DragginAreaIndex = 10;
                }
                else if (_imageControl.Name.Contains("Tractor"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurTractor));
                    DragginAreaIndex = 11;
                }
                else if (_imageControl.Name.Contains("Tender"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurTender));
                    DragginAreaIndex = 12;
                }
                else if (_imageControl.Name.Contains("LawnMower"))
                {
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurLawnMower));
                    DragginAreaIndex = 13;
                }
            }

        }
        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
            {
                PictureBox _imageControl = (PictureBox)sender;

                if (isDragging)
                {
                    Point curPos = farmPanel.PointToClient(Cursor.Position);

                    isDragging = false;
                    if ((curPos.X > 0 && curPos.X < farmPanel.Width) && (curPos.Y + 21 > 0 && curPos.Y + 21 < farmPanel.Height))
                    {
                        farm.Map.Sections.AddNewSection(DragginAreaIndex, curPos.X, curPos.Y + 21, farmPanel);

                        farmSaveToFile.Map.Sections.AddNewSection(DragginAreaIndex, curPos.X - 23, curPos.Y - 22);
                        farmSaveToFile.Map.Buildings.AddNewBuilding(DragginAreaIndex, farm.Map.Sections.GetLastId());

                        switch (DragginAreaIndex)
                        {
                            case 0:
                            case 1:
                            case 2:
                            case 3:
                                {
                                    farm.Map.Buildings.AddNewBuilding(animalInfoPanel, DragginAreaIndex, farm.Map.Sections.GetLastId());
                                    break;
                                }
                            case 4:
                                {
                                    farm.Map.Buildings.AddNewBuilding(storageInfoPanel, DragginAreaIndex, farm.Map.Sections.GetLastId());
                                    break;
                                }
                            case 5:
                                {
                                    farm.Map.Buildings.AddNewBuilding(garageInfoPanel, DragginAreaIndex, farm.Map.Sections.GetLastId());
                                    break;
                                }
                            case 6:
                            case 7:
                            case 8:
                            case 9:
                            case 10:
                                {
                                    farm.Map.Buildings.AddNewBuilding(vegInfoPanel, DragginAreaIndex, farm.Map.Sections.GetLastId());
                                    break;
                                }
                        }

                    }
                    DragginAreaIndex = -1;
                    _imageControl.Cursor = Cursors.Hand;
                }
            }
        }

        //--- Updating Farm Settings, used in: LoadApp when creating/loading farm ---
        public void farm_SetSettings( string name, string ownerName, Image image )
        {
            farm.Name = name;
            farm.OwnerName = ownerName;
            farm.Map.Image = image;

            farmSaveToFile.Name = name;
            farmSaveToFile.OwnerName = ownerName;

            ImageConverter converter = new ImageConverter();
            farmSaveToFile.Map.Image = (byte[])converter.ConvertTo(image, typeof(byte[]));

            lName.Text = name;
            lOwnerName.Text = ownerName;
            farmPanel.BackgroundImage = image;
        }

        public void showInfoByAreaId(int id)
        {
            animalInfoPanel.Hide();
            vegInfoPanel.Hide();
            garageInfoPanel.Hide();
            storageInfoPanel.Hide();

            var building = farm.Map.Buildings.GetBuildingById(id);
             
            switch (building.Type)
            {
                case "אורווה": case "לול": case "רפת": case "דיר":
                    {
                        areaType.Text = building.Type;
                        areaMax.Text = building.MaxCapacity.ToString();
                        areaCount.Text = building.Count.ToString();
                        areaImage.Image = farm.Map.Sections.GetImageById(id);

                        areaFoodType.Text = building.FoodType;
                        areaFoodAmountPerAnimal.Text = (building.FoodAmountPerAnimal * building.Count).ToString();
                        areaWaterAmountPerAnimal.Text = (building.WaterAmountPerAnimal * building.Count).ToString();

                        areaProduceType.Text = building.ProduceType;
                        areaProduceUnit.Text = building.ProduceUnit.ToString();
                        areaWeeklyProduce.Text = (building.ProduceAmountPerAnimal * building.Count).ToString();

                        if (building.Type == "אורווה")
                        {
                            areaAnimal.Text = "סוסים"; areaAnimal2.Text = "סוסים";
                        }  
                        else if (building.Type == "לול")
                        {
                            areaAnimal.Text = "תרנגולים"; areaAnimal2.Text = "תרנגולים";
                        }
                        else if(building.Type == "רפת")
                        {
                            areaAnimal.Text = "פרות"; areaAnimal2.Text = "פרות";
                        }    
                        else if(building.Type == "דיר")
                        {
                            areaAnimal.Text = "כבשים"; areaAnimal2.Text = "כבשים";
                        }

                        animalInfoPanel.Tag = building.Id;
                        animalInfoPanel.Show();
                        break;
                    }
                case "מחסן":
                    {
                        tbStorageItemName.Clear();
                        tbStorageItemAmount.Clear();
                        cbStorageItemUnit.SelectedIndex = 0;

                        lStorage.Items.Clear();

                        int totalItems = farm.Map.Buildings.GetBuildingById(id).Items.Count;
                        var items = farm.Map.Buildings.GetBuildingById(id).Items;

                        for (int i = 0; i < totalItems; i++)
                        {
                            ListViewItem item = new ListViewItem(items[i].Name);
                            item.SubItems.Add(items[i].Amount.ToString());
                            item.SubItems.Add(items[i].Unit);
                            lStorage.Items.Add(item);
                        }

                        storageType.Text = building.Type;
                        storageInfoPanel.Tag = building.Id;
                        storageInfoPanel.Show();
                        break;
                    }
                case "מוסך":
                    {
                        lMachines.Items.Clear();

                        int totalItems = farm.Map.Buildings.GetBuildingById(id).Machines.Count;
                        for (int i = 0; i < totalItems; i++)
                        {
                            lMachines.Items.Add(farm.Map.Buildings.GetBuildingById(id).Machines[i]);
                        }

                        garageType.Text = building.Type;
                        garageInfoPanel.Tag = building.Id;
                        garageInfoPanel.Show();
                        break;
                    }
                case "עלי נענע": case "גזרים": case "לימונים": case "תפוזים": case "תפו\"א":
                    {
                        vegType.Text = building.Type;
                        vegCount.Text = building.Count.ToString();
                        vegImage.Image = farm.Map.Sections.GetImageById(id);

                        vegWateringBreakDays.Text = building.WateringBreakDays.ToString();
                        vegWateringAmount.Text = building.WateringAmount.ToString();

                        vegProduceType.Text = building.Type;
                        vegUnit.Text = building.ProductUnit;
                        vegWeeklyProduce.Text = (building.WeeklyProduceAmount * building.Count).ToString(); 

                        vegInfoPanel.Tag = building.Id;
                        vegInfoPanel.Show();
                        break;
                    }
            }
            
        }

        public void updateProduce()
        {
            int eggs = 0;
            double milk = 0.0, wool = 0.0;

            int mint = 0, carrots = 0, lemons = 0, oranges = 0, potatos = 0;

            foreach ( dynamic building in farm.Map.Buildings.GetBuildings)
            {
                switch(building.Type)
                {
                    case "לול":
                        eggs += building.Count * building.ProduceAmountPerAnimal * 7;
                        break;
                    case "רפת":
                        milk += building.Count * building.ProduceAmountPerAnimal * 7;
                        break;
                    case "דיר":
                        wool += building.Count * building.ProduceAmountPerAnimal * 7;
                        break;
                    case "עלי נענע":
                        mint += building.Count * building.WeeklyProduceAmount;
                        break;
                    case "גזרים":
                        carrots += building.Count * building.WeeklyProduceAmount;
                        break;
                    case "לימונים":
                        lemons += building.Count * building.WeeklyProduceAmount;
                        break;
                    case "תפוזים":
                        oranges += building.Count * building.WeeklyProduceAmount;
                        break;
                    case "תפו\"א":
                        potatos += building.Count * building.WeeklyProduceAmount;
                        break;

                }
            }

            weeklyWool.Text = wool.ToString();
            weeklyEggs.Text = eggs.ToString();
            weeklyMilk.Text = milk.ToString();

            weeklyMint.Text = mint.ToString();
            weeklyCarrots.Text = carrots.ToString();
            weeklyLemons.Text = lemons.ToString();
            weeklyOranges.Text = oranges.ToString();
            weeklyPotatos.Text = potatos.ToString();
        }

        public Farm Farm
        {
            get { return farm; }
            set { farm = value; }
        }

        public FarmSave FarmSaveToFile
        {
            get { return farmSaveToFile; }
            set { farmSaveToFile = value; }
        }
        public FarmSave FarmLoadFromFile
        {
            get { return farmLoadFromFile; }
            set { farmLoadFromFile = value; }
        }

        //--- Closing the Application when exiting MainApp Form (due to LoadApp is the 'Main Form' and its only in 'Hide' Mode) ---
        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void updateAnimalMax_Click(object sender, EventArgs e)
        {
            if (updateAnimalMax.Text == "עדכן")
            {
                updateAnimalMax.Text = "שמור";
                tbUpdateAnimalMax.Text = areaMax.Text;
                tbUpdateAnimalMax.Show();
            }      
            else
            {
                int count = Int32.Parse(areaCount.Text);
                int max = (tbUpdateAnimalMax.Text == "") ? 0 : Int32.Parse(tbUpdateAnimalMax.Text);

                if (max < count)
                {
                    farm.Map.Buildings.GetBuildingById((int)animalInfoPanel.Tag).Count = max;
                    farmSaveToFile.Map.Buildings.GetBuildingById((int)animalInfoPanel.Tag).Count = max;
                }
                    

                farm.Map.Buildings.GetBuildingById((int)animalInfoPanel.Tag).MaxCapacity = max;
                farmSaveToFile.Map.Buildings.GetBuildingById((int)animalInfoPanel.Tag).MaxCapacity = max;

                updateAnimalMax.Text = "עדכן";
                tbUpdateAnimalMax.Hide();

                updateProduce();
                showInfoByAreaId((int)animalInfoPanel.Tag);
            }
        }

        private void updateAnimalCount_Click(object sender, EventArgs e)
        {
            if (updateAnimalCount.Text == "עדכן")
            {
                updateAnimalCount.Text = "שמור";
                tbUpdateAnimalCount.Text = areaCount.Text;
                tbUpdateAnimalCount.Show();
            }
            else
            {
                int count = (tbUpdateAnimalCount.Text == "") ? 0 : Int32.Parse(tbUpdateAnimalCount.Text);
                int max = Int32.Parse(areaMax.Text);

                if (count > max)
                    MessageBox.Show("הינך חורג/ת מהכמות המקסימלית", "שגיאה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
                else
                {
                    farm.Map.Buildings.GetBuildingById((int)animalInfoPanel.Tag).Count = count;
                    farmSaveToFile.Map.Buildings.GetBuildingById((int)animalInfoPanel.Tag).Count = count;

                    updateAnimalCount.Text = "עדכן";
                    tbUpdateAnimalCount.Hide();

                    updateProduce();
                    showInfoByAreaId((int)animalInfoPanel.Tag);
                }  
            }
        }

        private void tbUpdateAnimalMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbUpdateAnimalCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void updateVegCount_Click(object sender, EventArgs e)
        {
            if (updateVegCount.Text == "עדכן")
            {
                updateVegCount.Text = "שמור";
                tbUpdateVegCount.Text = vegCount.Text;
                tbUpdateVegCount.Show();
            }
            else
            {
                int count = (tbUpdateVegCount.Text == "") ? 0 : Int32.Parse(tbUpdateVegCount.Text);

                farm.Map.Buildings.GetBuildingById((int)vegInfoPanel.Tag).Count = count;
                farmSaveToFile.Map.Buildings.GetBuildingById((int)vegInfoPanel.Tag).Count = count;

                updateVegCount.Text = "עדכן";
                tbUpdateVegCount.Hide();

                updateProduce();
                showInfoByAreaId((int)vegInfoPanel.Tag);
            }
        }

        private void tbUpdateVegCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bAddMachine_Click(object sender, EventArgs e)
        {
            if(tbMachine.Text != "")
            {
                lMachines.Items.Add(tbMachine.Text);
                farm.Map.Buildings.GetBuildingById((int)garageInfoPanel.Tag).AddMachine(tbMachine.Text);
                farmSaveToFile.Map.Buildings.GetBuildingById((int)garageInfoPanel.Tag).AddMachine(tbMachine.Text);

                tbMachine.Text = "";
            }   
        }

        private void bDeleteMachines_Click(object sender, EventArgs e)
        {
            farm.Map.Buildings.GetBuildingById((int)garageInfoPanel.Tag).Machines.Remove(lMachines.GetItemText(lMachines.SelectedItem));
            farmSaveToFile.Map.Buildings.GetBuildingById((int)garageInfoPanel.Tag).Machines.Remove(lMachines.GetItemText(lMachines.SelectedItem));
            lMachines.Items.Remove(lMachines.SelectedItem);
        }

        private void cbStorageUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void tbStorageItemAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bAddItemToStorage_Click(object sender, EventArgs e)
        {
            if( tbStorageItemAmount.Text == "" || tbStorageItemName.Text == "")
                MessageBox.Show("נא לא להשאיר שדות ריקים", "שגיאה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
            else
            {
                var storage = farm.Map.Buildings.GetBuildingById((int)storageInfoPanel.Tag);
                var storageInSaveFile = farmSaveToFile.Map.Buildings.GetBuildingById((int)storageInfoPanel.Tag);

                if (storage.FindItem(tbStorageItemName.Text) )
                {
                    MessageBox.Show("הפריט כבר קיים", "שגיאה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
                    return;
                }

                ListViewItem item = new ListViewItem(tbStorageItemName.Text);
                item.SubItems.Add(tbStorageItemAmount.Text);
                item.SubItems.Add(cbStorageItemUnit.Text);
                lStorage.Items.Add(item);

                storage.AddItemToStorage(item);
                storageInSaveFile.AddItemToStorage(item);

                tbStorageItemName.Clear();
                tbStorageItemAmount.Clear();
                cbStorageItemUnit.SelectedIndex = 0;
            }
        }

        private void bDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lStorage.SelectedItems)
            {
                lStorage.Items.Remove(eachItem);

                farm.Map.Buildings.GetBuildingById((int)storageInfoPanel.Tag).Remove(eachItem);
                farmSaveToFile.Map.Buildings.GetBuildingById((int)storageInfoPanel.Tag).Remove(eachItem);
            }
        }

        private void bSaveFarm_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "data files (*.dat)|*.dat|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream, FarmSaveToFile);
                }
            }
            //Serializator.Serialize("farm.dat", farmSaveToFile);
        }

        public void LoadFromFile()
        {
            Farm.Name = FarmSaveToFile.Name = FarmLoadFromFile.Name;
            Farm.OwnerName = FarmSaveToFile.OwnerName = FarmLoadFromFile.OwnerName;
            Farm.Map.Image = ByteToImage(FarmLoadFromFile.Map.Image);
            FarmSaveToFile.Map.Image = FarmLoadFromFile.Map.Image;

            lName.Text = Farm.Name;
            lOwnerName.Text = Farm.OwnerName;
            farmPanel.BackgroundImage = Farm.Map.Image;

            List<SectionSave> sections = FarmLoadFromFile.Map.Sections.GetSections;
            List<BuildingSave> buildings = FarmLoadFromFile.Map.Buildings.GetBuildings;

            for (int i = 0; i < sections.Count; i++)
            {
                farm.Map.Sections.AddNewSection(sections[i].Type, sections[i].X + 25, sections[i].Y + 40, farmPanel);

                farmSaveToFile.Map.Sections.AddNewSection(sections[i].Type, sections[i].X, sections[i].Y);
                farmSaveToFile.Map.Buildings.AddNewBuilding(sections[i].Type, farm.Map.Sections.GetLastId());

                switch (sections[i].Type)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        {
                            farm.Map.Buildings.AddNewBuilding(animalInfoPanel, sections[i].Type, farm.Map.Sections.GetLastId());

                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).MaxCapacity = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).MaxCapacity = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).MaxCapacity;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).Count = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).Count = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).Count;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).FoodType = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).FoodType = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).FoodType;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).FoodAmountPerAnimal = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).FoodAmountPerAnimal = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).FoodAmountPerAnimal;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).WaterAmountPerAnimal = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).WaterAmountPerAnimal = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).WaterAmountPerAnimal;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).ProduceType = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).ProduceType = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).ProduceType;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).ProduceAmountPerAnimal = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).ProduceAmountPerAnimal = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).ProduceAmountPerAnimal;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).ProduceUnit = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).ProduceUnit = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).ProduceUnit;

                            break;
                        }
                    case 4:
                        {
                            farm.Map.Buildings.AddNewBuilding(storageInfoPanel, sections[i].Type, farm.Map.Sections.GetLastId());

                            //farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).Items = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).ItemsSave = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).ItemsSave;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).copyFromList(farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).Items);
                            farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).copyFromList(farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).Items);
                            break;
                        }
                    case 5:
                        {
                            farm.Map.Buildings.AddNewBuilding(garageInfoPanel, sections[i].Type, farm.Map.Sections.GetLastId());

                            //farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).Machines = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).Machines = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).Machines;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).copyFromList(farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).Machines);
                            farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).copyFromList(farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).Machines);
                            break;
                        }
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        {
                            farm.Map.Buildings.AddNewBuilding(vegInfoPanel, sections[i].Type, farm.Map.Sections.GetLastId());

                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).Count = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).Count = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).Count;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).WateringBreakDays = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).WateringBreakDays = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).WateringBreakDays;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).WateringAmount = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).WateringAmount = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).WateringAmount;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).WeeklyProduceAmount = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).WeeklyProduceAmount = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).WeeklyProduceAmount;
                            farm.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).ProductUnit = farmSaveToFile.Map.Buildings.GetBuildingById(farm.Map.Sections.GetLastId()).ProductUnit = farmLoadFromFile.Map.Buildings.GetBuildingById(sections[i].Id).ProductUnit;
                            break;
                        }
                }
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void bLoadFarm_Click(object sender, EventArgs e)
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
                FarmLoadFromFile = new FarmSave();
                FarmSaveToFile = new FarmSave();
                FarmLoadFromFile = (FarmSave)binaryFormatter.Deserialize(stream);

                stream.Close();
            }

            Farm = new Farm();

            farmPanel.Controls.Clear();
            animalInfoPanel.Hide();
            vegInfoPanel.Hide();
            storageInfoPanel.Hide();
            garageInfoPanel.Hide();

            LoadFromFile();
        }

        //--- Testings ---//
        /*
        public void Testing()
        {
            string text = "";
            text += "Farm Lists:\n";
            text += "Sections:\n";
            for (int i = 0; i < farm.Map.Sections.GetSections.Count; i++)
            {
                text += "Id: " + farm.Map.Sections.GetSections[i].Id +", type: " + farm.Map.Sections.GetSections[i].Type.ToString() + ", X: " + farm.Map.Sections.GetSections[i].X + ", Y: " + farm.Map.Sections.GetSections[i].Y + "\n";
            }
            text += "Buildings:\n";
            for (int i = 0; i < farm.Map.Buildings.GetBuildings.Count; i++)
            {
                text += "Id: " + farm.Map.Buildings.GetBuildings[i].Id + ", type: " + farm.Map.Buildings.GetBuildings[i].Type + "\n";
            }
            text += "\n-----------------------\n";
            text += "Sections Save:\n";
            for (int i = 0; i < farmSaveToFile.Map.Sections.GetSections.Count; i++)
            {
                text += "Id: " + farmSaveToFile.Map.Sections.GetSections[i].Id + ", type: " + farmSaveToFile.Map.Sections.GetSections[i].Type.ToString() + ", X: " + farmSaveToFile.Map.Sections.GetSections[i].X + ", Y: " + farmSaveToFile.Map.Sections.GetSections[i].Y + "\n";
            }
            text += "Buildings Save:\n";
            for (int i = 0; i < farmSaveToFile.Map.Buildings.GetBuildings.Count; i++)
            {
                text += "Id: " + farmSaveToFile.Map.Buildings.GetBuildings[i].Id + ", type: " + farmSaveToFile.Map.Buildings.GetBuildings[i].Type + "\n";
            }

            text += "\n-----------------------\n";

            MessageBox.Show(text);
        }
        
        public void Testing(int id)
        {
            string text = "";
            for (int i = 0; i < farmSaveToFile.Map.Buildings.GetBuildingById(id).Machines.Count; i++)
            {
                text += "Name: " + farmSaveToFile.Map.Buildings.GetBuildingById(id).Machines[i] + "\n";
            }
            text += "\n";
            for (int i = 0; i < farm.Map.Buildings.GetBuildingById(id).Machines.Count; i++)
            {
                text += "Name: " + farm.Map.Buildings.GetBuildingById(id).Machines[i] + "\n";
            }
            
            MessageBox.Show(text);
        }
        */
    }
}
