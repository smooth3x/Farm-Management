using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmManagement
{
    //---- Farm ------
    [Serializable]
    public class FarmSave
    {
        string _name;
        string _ownerName;
        MapSave _map;

        public FarmSave()
        {
            _name = "";
            _ownerName = "";
            _map = new MapSave();
        }
        public FarmSave(string name, string ownerName, byte[] image)
        {
            _name = name;
            _ownerName = ownerName;
            _map = new MapSave(image);
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String OwnerName
        {
            get { return _ownerName; }
            set { _ownerName = value; }
        }
        public MapSave Map
        {
            get { return _map; }
        }
    }

    //---- Map ------
    [Serializable]
    public class MapSave
    {
        SectionListSave _sections;
        BuildingListSave _buildings;
        byte[] _image;

        public MapSave()
        {
            _sections = new SectionListSave();
            _buildings = new BuildingListSave();
        }
        public MapSave(byte[] image)
        {
            _sections = new SectionListSave();
            _buildings = new BuildingListSave();
            _image = image;
        }

        public SectionListSave Sections
        {
            get { return _sections; }
        }

        public BuildingListSave Buildings
        {
            get { return _buildings; }
        }

        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }

    [Serializable]
    public class SectionSave
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

        int _x = -1, _y = -1;

        //--- Section Constructor ---
        public SectionSave(int type, int x_pos, int y_pos)
        {
            this._id = _idCounter++;
            this._type = type;
            this._x = x_pos;
            this._y = y_pos;
        }

        public int Id
        {
            get { return _id; }
        }

        public int Type
        {
            get { return _type; }
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

        public static int IdCount
        {
            get { return _idCounter; }
            set { _idCounter = value; }
        }
    }

    [Serializable]
    public class SectionListSave
    {
        List<SectionSave> _sections;

        public SectionListSave()
        {
            _sections = new List<SectionSave>();
        }

        public List<SectionSave> GetSections
        {
            get { return _sections; }
        }

        // --- Search PictureBox Control in Panel by Tag & Removes the Control from Panel and Remove Section from SectionList ---
        public void RemoveSectionById(int id)
        {
            if( _sections.Find(s => s.Id == id) != null)
                _sections.Remove(_sections.Single(s => s.Id == id));
        }

        public void AddNewSection(int type, int x_pos, int y_pos)
        {
            _sections.Add(new SectionSave(type, x_pos, y_pos));
        }

        public int GetLastId()
        {
            return _sections.Last().Id;
        }

        public SectionSave GetSectionById(int id)
        {
            return _sections.Find(s => s.Id == id);
        }
    }

    //---- Buildings -----
    [Serializable]
    public class BuildingSave
    {
        int _id;
        string _type;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }

    [Serializable]
    public class MaintenanceSave : BuildingSave
    {

    }
    [Serializable]
    public class GarageSave : MaintenanceSave
    {
        List<string> _machines;

        public GarageSave(int id, string type)
        {
            this.Id = id;
            this.Type = type;

            _machines = new List<string>();
        }

        public void AddMachine(string name)
        {
            _machines.Add(name);
        }

        public void RemoveMachine(string name)
        {
            _machines.Remove(name);
        }

        public void copyFromList(List<string> items)
        {
            foreach (var item in items)
            {
                Machines.Add(item);
            }
        }

        public List<string> Machines
        {
            get { return _machines; }
            set { this._machines = value; }
        }
    }
    [Serializable]
    public class Item
    {
        string _itemName;
        int _amount;
        string _unit;

        public string Name
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
    }
    [Serializable]
    public class StorageSave : MaintenanceSave
    {
        List<Item> _items;

        public StorageSave(int id, string type)
        {
            this.Id = id;
            this.Type = type;

            this._items = new List<Item>();
        }

        public List<Item> Items
        {
            get { return _items; }
            set { this._items = value; }
        }

        public void AddItemToStorage(ListViewItem item)
        {
            if (item != null)
            {
                Item itemToAdd = new Item();

                itemToAdd.Name = item.Text;
                itemToAdd.Amount = Int32.Parse(item.SubItems[1].Text);
                itemToAdd.Unit = item.SubItems[2].Text;

                Items.Add(itemToAdd);
            }
        }
        public void Remove(ListViewItem item)
        {
            Items.Remove(Items.Single(s => s.Name == item.Text));
        }

        public void copyFromList(List<Item> items)
        {
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        public bool FindItem(string name)
        {
            if (Items.Find(s => s.Name == name) != null)
                return true;
            return false;
        }
    }
    [Serializable]
    public class GrowingAreaSave : BuildingSave
    {
        int _count = 0;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
    }
    [Serializable]
    public class AnimalSave : GrowingAreaSave
    {
        int _maxCapacity = 10;
        string _foodType;
        double _foodAmountPerAnimal = 0.0;
        double _waterAmountPerAnimal = 0.0;
        string _produceType;
        double _produceAmountPerAnimal;
        string _produceUnit;


        public AnimalSave(int id, string animalType, double foodAmountPerAnimal, double waterAmountPerAnimal, string foodType, string produceType, double produceAmountPerAnimal, string produceUnit)
        {
            this.Id = id;
            this.Type = animalType;
            this._foodType = foodType;
            this._foodAmountPerAnimal = foodAmountPerAnimal;
            this._waterAmountPerAnimal = waterAmountPerAnimal;
            this._produceType = produceType;
            this._produceAmountPerAnimal = produceAmountPerAnimal;
            this._produceUnit = produceUnit;
        }

        public int MaxCapacity
        {
            get { return _maxCapacity; }
            set { _maxCapacity = value; }
        }

        public string FoodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }

        public double WaterAmountPerAnimal
        {
            get { return _waterAmountPerAnimal; }
            set { _waterAmountPerAnimal = value; }
        }

        public double FoodAmountPerAnimal
        {
            get { return _foodAmountPerAnimal; }
            set { _foodAmountPerAnimal = value; }
        }

        public string ProduceType
        {
            get { return _produceType; }
            set { _produceType = value; }
        }

        public double ProduceAmountPerAnimal
        {
            get { return _produceAmountPerAnimal; }
            set { _produceAmountPerAnimal = value; }
        }

        public string ProduceUnit
        {
            get { return _produceUnit; }
            set { _produceUnit = value; }
        }

    }
    [Serializable]
    public class VegetationSave : GrowingAreaSave
    {
        int _wateringBreakDays;
        int _wateringAmount;
        int _weeklyProduceAmount;
        string _productUnit;

        public VegetationSave(int id, string type, int wateringBreakDays, int wateringAmount, int weeklyProduceAmount, string productUnit)
        {
            this.Id = id;
            this.Type = type;
            this._wateringBreakDays = wateringBreakDays;
            this._wateringAmount = wateringAmount;
            this._weeklyProduceAmount = weeklyProduceAmount;
            this._productUnit = productUnit;
        }

        public int WateringBreakDays
        {
            get { return _wateringBreakDays; }
            set { _wateringBreakDays = value;}
        }
        public int WateringAmount
        {
            get { return _wateringAmount; }
            set { _wateringAmount = value; }
        }
        public int WeeklyProduceAmount
        {
            get { return _weeklyProduceAmount; }
            set { _weeklyProduceAmount = value; }
        }
        public string ProductUnit
        {
            get { return _productUnit; }
            set { this._productUnit = value; }
        }
    }

    [Serializable]
    public class BuildingListSave
    {
        static string[] BuildingNames = { "אורווה", "לול", "רפת", "דיר", "מחסן", "מוסך", "עלי נענע", "גזרים", "לימונים", "תפוזים", "תפו\"א" };
        static string[] BuildingFoodType = { "חציר", "גרגירים", "דשא", "דשא" };
        static double[] BuildingFoodPerAnimal = { 4.5, 0.25, 10.0, 1.0 };
        static double[] BuildingWaterPerAnimal = { 20.0, 0.5, 45.0, 5.0 };
        static double[] BuildingAverageProducePerAnimal = { 80, 5, 7, 0.2 };
        static string[] BuildingProduceType = { "רכיבה", "ביצים", "חלב", "צמר", "", "", "עלי נענע", "גזרים", "לימונים", "תפוזים", "תפו\"א" };
        static string[] BuildingProduceUnit = { "ק\"מ", "יחידות", "ליטרים", "מטרים", "", "", "גבעולים", "ק\"ג", "ק\"ג", "ק\"ג", "ק\"ג" };

        static int[] VegWateringBreakDays = { -1, -1, -1, -1, -1, -1, 1, 3, 1, 1, 4 };
        static int[] VegWateringAmount = { -1, -1, -1, -1, -1, -1, 2, 1, 2, 2, 1 };
        static int[] VegWeeklyProduceAmount = { -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1 };

        protected List<BuildingSave> _buildingList;

        public BuildingListSave()
        {
            _buildingList = new List<BuildingSave>();
        }

        public List<BuildingSave> GetBuildings
        {
            get { return _buildingList; }
        }

        public void AddNewBuilding(int type, int id)
        {
            switch (type)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    {
                        _buildingList.Add(new AnimalSave(id, BuildingNames[type], BuildingFoodPerAnimal[type], BuildingWaterPerAnimal[type], BuildingFoodType[type], BuildingProduceType[type], BuildingAverageProducePerAnimal[type], BuildingProduceUnit[type]));
                        break;
                    }
                case 4:
                    {
                        _buildingList.Add(new StorageSave(id, BuildingNames[type]));
                        break;
                    }
                case 5:
                    {
                        _buildingList.Add(new GarageSave(id, BuildingNames[type]));
                        break;
                    }
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    {
                        _buildingList.Add(new VegetationSave(id, BuildingNames[type], VegWateringBreakDays[type], VegWateringAmount[type], VegWeeklyProduceAmount[type], BuildingProduceUnit[type]));
                        break;
                    }
            }
        }
        public dynamic GetBuildingById(int id)
        {
            return _buildingList.Find(s => s.Id == id);
        }
        public void RemoveBuildingById(int id)
        {
            _buildingList.Remove(_buildingList.Single(s => s.Id == id));
        }

    }
}
