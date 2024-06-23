using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FarmManagement
{
    //--- Map Class: Containes Image of the Farm & Section List
    [Serializable]
    public class Map
    {
        SectionList _sections;
        BuildingList _buildings;
        Image _image;

        public Map(Image image)
        {
            _sections = new SectionList();
            _buildings = new BuildingList();
            _image = image;
        }

        public SectionList Sections
        {
            get { return _sections; }
        }

        public BuildingList Buildings
        {
            get { return _buildings; }
        }

        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
    [Serializable]
    public class Section
    {
        //--- Static Arrays of Section: Names, Background Images & Cursor Images ---
        static string[] SectionsNames = { "Stable", "Hen", "Cowshed", "Pen", "Hay", "Garage", "Mint", "Carrot", "Lemon", "Orange", "Potato", "Tractor", "Tender", "LawnMower" };
        static string[] ImagesNames = { "tipStable", "tipHen", "tipCowshed", "tipPen", "tipHay", "tipGarage", "tipMint", "tipCarrot", "tipLemon", "tipOrange", "tipPotato", "tipTractor", "tipTender", "tipLawnMower" };
        static string[] cursorsNames = { "CurStable.cur", "CurHen.cur", "CurCowshed.cur", "CurPen.cur", "CurHay.cur", "CurGarage.cur", "CurMint.cur", "CurCarrot.cur", "CurLemon.cur", "CurOrange.cur", "CurPotato.cur", "CurTractor.cur", "CurTender.cur", "CurLawnMower.cur" };
        static string[] SectionsTip = { "אורווה", "לול", "רפת", "דיר", "מחסן", "מוסך", "עלי נענע", "גזרים", "לימונים", "תפוזים", "תפו\"א", "טרקטור", "טנדר", "מכסחה" };

        //--- Index of Section ---
        static int _idCounter = 1;  // Global Counter Index, starts at '1'
        int _id;                    // Unique Index

        //--- Type of Section ---
        int _type;

        //--- Variables for getting Panel, ImageControl, TipControl & Delete Menu ----
        Panel _panel;
        PictureBox _imageControl;
        ContextMenuStrip _deleteMenu;
        Label _tip;

        //--- Dragging Section Indicator --- 
        bool isDragging = false;
        Timer longPressTimer = new Timer();
        int _x = -1, _y = -1;

        //--- Section Constructor ---
        public Section(int type, int x_pos, int y_pos, Panel panel)
        {
            this._id = _idCounter++;
            this._type = type;
            this._panel = panel;
            this._x = x_pos;
            this._y = y_pos;
            createPictureBox(type, x_pos, y_pos); // Creates PictoreBox Control (Visual)
            createTip(x_pos, y_pos);
            createLongPressTimer();
        }

        //----- Create PictureBox Control & Add it to the Main Panel -------
        private void createPictureBox(int type, int x_pos, int y_pos)
        {
            _imageControl = new System.Windows.Forms.PictureBox();

            _imageControl.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(ImagesNames[_type]);
            _imageControl.Cursor = Cursors.Hand;
            _imageControl.Location = new Point(x_pos - 25, y_pos - 40);
            _imageControl.Margin = new Padding(2);
            _imageControl.Name = SectionsNames[_type];
            _imageControl.Size = new Size(46, 43);
            _imageControl.SizeMode = PictureBoxSizeMode.StretchImage;
            _imageControl.TabStop = false;
            _imageControl.Tag = _id;

            _imageControl.MouseDown += picture_MouseDown;
            _imageControl.MouseUp += picture_MouseUp;
            //_imageControl.MouseHover += picture_MouseHover;
            //_imageControl.MouseLeave += picture_MouseLeave;

            createDeleteMenu();

            _panel.Controls.Add(_imageControl);
        }

        //----- Create Tip (Label) Control & Add it to the Main Panel -------
        private void createTip(int x_pos, int y_pos)
        {
            _tip = new System.Windows.Forms.Label();

            _tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            _tip.BackColor = System.Drawing.Color.LightGray;
            _tip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            _tip.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            _tip.Location = new Point(x_pos - 25 - 3, y_pos - 40 - 18);
            _tip.Name = "tipHelp";
            _tip.Size = new System.Drawing.Size(50, 18);
            _tip.TabIndex = 0;
            _tip.Tag = _id;
            _tip.Text = SectionsTip[_type];
            _tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _tip.BringToFront();

            _panel.Controls.Add(_tip);
        }

        private void createLongPressTimer()
        {
            longPressTimer.Interval = 100;

            longPressTimer.Tick += delegate (object sender, EventArgs e)
            {
                // ... stop the timer - it shouldn't fire again
                longPressTimer.Stop();

                isDragging = true;

                _imageControl.Hide();
                _tip.Hide();

                if (_imageControl.Name.Contains("Stable"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurStable));
                else if (_imageControl.Name.Contains("Hen"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurHen));
                else if (_imageControl.Name.Contains("Cowshed"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurCowshed));
                else if (_imageControl.Name.Contains("Pen"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurPen));
                else if (_imageControl.Name.Contains("Hay"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurHay));
                else if (_imageControl.Name.Contains("Garage"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurGarage));
                else if (_imageControl.Name.Contains("Mint"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurMint));
                else if (_imageControl.Name.Contains("Carrot"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurCarrot));
                else if (_imageControl.Name.Contains("Lemon"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurLemon));
                else if (_imageControl.Name.Contains("Orange"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurOrange));
                else if (_imageControl.Name.Contains("Potato"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurPotato));
                else if (_imageControl.Name.Contains("Tractor"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurTractor));
                else if (_imageControl.Name.Contains("Tender"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurTender));
                else if (_imageControl.Name.Contains("LawnMower"))
                    _imageControl.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.CurLawnMower));
            };
        }

        //----- Create "Delete Menu" & Add it to the PictureBox Control -------
        private void createDeleteMenu()
        {
            _deleteMenu = new ContextMenuStrip();
            _deleteMenu.RightToLeft = RightToLeft.Yes;
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem();
            deleteMenuItem.Text = "מחק איזור";
            deleteMenuItem.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Delete_Icon");
            deleteMenuItem.Click += deleteSection;
            _deleteMenu.Items.Add(deleteMenuItem);

            _imageControl.ContextMenuStrip = _deleteMenu;
        }

        //---- Delete Menu Item Event: Removes Section from Farm's SectionList ----
        private void deleteSection(object sender, EventArgs e)
        {
            MainApp app = (MainApp)_panel.Parent;
            app.Farm.Map.Sections.RemoveSectionById(_id, _panel);
            app.Farm.Map.Buildings.RemoveBuildingById(_id);

            app.FarmSaveToFile.Map.Sections.RemoveSectionById(_id);
            app.FarmSaveToFile.Map.Buildings.RemoveBuildingById(_id);

            app.updateProduce();
        }

        //---- Section ImageControl MouseDown Event ---
        //--------- If Dragging: Set Cursor Image to Section Image (Simulating Dragging) ---------

        private void picture_MouseDown(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
            {
                longPressTimer.Start();
            }
        }

        //---- Section ImageControl MouseUp Event ---
        //--------- If Dragging: Set Cursor Image to Default, Set IsDragging to FALSE & Change ImageControl Location (X,Y) to Cursor Location (X,Y) ---------
        private void picture_MouseUp(object sender, EventArgs e)
        {
            longPressTimer.Stop(); // Stop Long Press Timer

            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
            {
                if (isDragging)
                {
                    Point curPos = _panel.PointToClient(Cursor.Position);

                    isDragging = false;
                    if ((curPos.X > 0 && curPos.X < _panel.Width) && (curPos.Y > 0 && curPos.Y < _panel.Height))
                    {
                        _imageControl.Location = new Point(curPos.X - 23, curPos.Y - 22);
                        _tip.Location = new Point(curPos.X - 23 - 3, curPos.Y - 22 - 18);


                        MainApp app = _panel.Parent as MainApp;

                        app.FarmSaveToFile.Map.Sections.GetSectionById(_id).X = curPos.X - 23;
                        app.FarmSaveToFile.Map.Sections.GetSectionById(_id).Y = curPos.Y - 22;


                        _x = curPos.X - 23;
                        _y = curPos.Y - 22;
                    }

                    _imageControl.Show();
                    _imageControl.Cursor = Cursors.Hand;
                    _tip.Show();
                    _tip.BringToFront();
                }
                else
                {
                    //
                    PictureBox pictureBox = (PictureBox)sender;
                    MainApp app = (MainApp)_panel.Parent;

                    if( pictureBox.Name != "LawnMower" && pictureBox.Name != "Tractor" && pictureBox.Name != "Tender" )
                        app.showInfoByAreaId((int)pictureBox.Tag);
                }
            }
        }

        public int Id
        {
            get { return _id; }
        }

        public PictureBox ImageControl
        {
            get { return _imageControl; }
        }

        public Label TipControl
        {
            get { return _tip; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }

    [Serializable]
    public class SectionList
    {
        List<Section> _sections;

        public SectionList()
        {
            _sections = new List<Section>();
        }

        // --- Search PictureBox Control in Panel by Tag & Removes the Control from Panel and Remove Section from SectionList ---
        public void RemoveSectionById(int id, Panel panel)
        {
            foreach( Section section in _sections)
            {
                if( section.Id == id )
                {
                    section.ImageControl.Dispose();
                    section.TipControl.Dispose();
                }
            }

            _sections.Remove(_sections.Single(s => s.Id == id));
        }

        public void AddNewSection(int type, int x_pos, int y_pos, Panel panel)
        {
            _sections.Add(new Section(type, x_pos, y_pos, panel));
        }

        public int GetLastId()
        {
            return _sections.Last().Id;
        }

        public Section GetSectionById(int id)
        {
            return _sections.Find(s => s.Id == id);
        }

        public Image GetImageById(int id)
        {
            return _sections.Find(s => s.Id == id).ImageControl.Image;
        }

        public List<Section> GetSections
        {
            get { return _sections; }
        }
    }

}
