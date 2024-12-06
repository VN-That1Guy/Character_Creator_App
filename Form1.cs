using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Character_Creator_App
{
    public partial class Form1 : Form
    {
		//Creates new lists for utilizing the Combobbox
        List<ComboBoxItem> Headlist = new List<ComboBoxItem>();
        List<ComboBoxItem> Facelist = new List<ComboBoxItem>();
        List<ComboBoxItem> Necklist = new List<ComboBoxItem>();
        List<ComboBoxItem> Handslist = new List<ComboBoxItem>();
        List<ComboBoxItem> Shoeslist = new List<ComboBoxItem>();
        public Form1()
        {
            InitializeComponent();

			//Get's the directory of the .exe file and then specific folders and files.
            string AppFolderLocation = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string ImagesFolderLocation = Path.Combine(AppFolderLocation, "images");
            string StickFigure = Path.Combine(ImagesFolderLocation, "StickPerson.png");
			
			//ComboBox Items, Creates new items for the use of the Combobox(drop down) feature
			//Default Invisible Image for Cosmetic Items such as Hats
            ComboBoxItem None = new ComboBoxItem() { Text = "None", ImageID = Path.Combine(ImagesFolderLocation, "None.png") };

            //Combobox Items: Head
            ComboBoxItem Hat = new ComboBoxItem() { Text = "Hat", ImageID = Path.Combine(ImagesFolderLocation, "Hat.png") };
            ComboBoxItem Hat_Beanie_Long = new ComboBoxItem() { Text = "Beanie (Long)", ImageID = Path.Combine(ImagesFolderLocation, "Hat_Beanie_Long.png") };
            ComboBoxItem Hat_Beanie_Short = new ComboBoxItem() { Text = "Beanie (Regular)", ImageID = Path.Combine(ImagesFolderLocation, "Hat_Beanie_Short.png") };
            ComboBoxItem Hat_CowBoy = new ComboBoxItem() { Text = "Cowboy Hat", ImageID = Path.Combine(ImagesFolderLocation, "Hat_CowBoy.png") };
            ComboBoxItem Hat_Propeller = new ComboBoxItem() { Text = "Propeller Hat", ImageID = Path.Combine(ImagesFolderLocation, "Hat_Propeller.png") };
            ComboBoxItem Hat_TopHat = new ComboBoxItem() { Text = "Top Hat", ImageID = Path.Combine(ImagesFolderLocation, "Hat_TopHat.png") };
            ComboBoxItem Hat_Yankee = new ComboBoxItem() { Text = "Yankee", ImageID = Path.Combine(ImagesFolderLocation, "Hat_Yankee.png") };
            ComboBoxItem Hat_Yankee_Brimless = new ComboBoxItem() { Text = "Yankee with no brim", ImageID = Path.Combine(ImagesFolderLocation, "Hat_Yankee_Brimless.png") };

            //Combobox Items: Face
            ComboBoxItem Glasses = new ComboBoxItem() { Text = "Glasses", ImageID = Path.Combine(ImagesFolderLocation, "Glasses.png") };
            ComboBoxItem SunGlasses = new ComboBoxItem() { Text = "Sunglasses", ImageID = Path.Combine(ImagesFolderLocation, "SunGlasses.png") };
            ComboBoxItem Blindfold = new ComboBoxItem() { Text = "Blindfold", ImageID = Path.Combine(ImagesFolderLocation, "Blindfold.png") };
            
            //Combobox Items: Neck
            ComboBoxItem Tie = new ComboBoxItem() { Text = "Tie", ImageID = Path.Combine(ImagesFolderLocation, "Tie.png") };
            ComboBoxItem BowTie = new ComboBoxItem() { Text = "Bowtie", ImageID = Path.Combine(ImagesFolderLocation, "BowTie.png") };

            //Combobox Items: Hands
            ComboBoxItem Gloveless = new ComboBoxItem() { Text = "None", ImageID = Path.Combine(ImagesFolderLocation, "Hands.png") };
            ComboBoxItem Hands_Gloves = new ComboBoxItem() { Text = "Gloves", ImageID = Path.Combine(ImagesFolderLocation, "Hands_Gloves.png") };
            ComboBoxItem Hands_Gloves_Fingerless = new ComboBoxItem() { Text = "Fingerless Gloves", ImageID = Path.Combine(ImagesFolderLocation, "Hands_Gloves_Fingerless.png") };

            //ComboBox Items: Shoes
            ComboBoxItem Feet_None = new ComboBoxItem() { Text = "None", ImageID = Path.Combine(ImagesFolderLocation, "Shoes_Slippers.png") };
            ComboBoxItem Shoes = new ComboBoxItem() { Text = "Shoes", ImageID = Path.Combine(ImagesFolderLocation, "Shoes.png") };
            ComboBoxItem Shoes_Drip = new ComboBoxItem() { Text = "Drip", ImageID = Path.Combine(ImagesFolderLocation, "Shoes_Drip.png") };

			//Drop down box categories, Add's the items into each list and calls in ToArray to implement them into a specific drop down box
            //Drop down box Items: Head
            Headlist.Add(None);
            Headlist.Add(Hat);
            Headlist.Add(Hat_Beanie_Long);
            Headlist.Add(Hat_Beanie_Short);
            Headlist.Add(Hat_CowBoy);
            Headlist.Add(Hat_Propeller);
            Headlist.Add(Hat_TopHat);
            Headlist.Add(Hat_Yankee);
            Headlist.Add(Hat_Yankee_Brimless);

            Hat_DropDown.DataSource = Headlist.ToArray();

            //Drop down box Items: Face
            Facelist.Add(None);
            Facelist.Add(Glasses);
            Facelist.Add(SunGlasses);
            Facelist.Add(Blindfold);

            Face_DropDown.DataSource = Facelist.ToArray();

            //Drop down box Items: Neck
            Necklist.Add(None);
            Necklist.Add(Tie);
            Necklist.Add(BowTie);

            Neck_DropDown.DataSource = Necklist.ToArray();

            //Drop down box Items: Hands
            Handslist.Add(Gloveless);
            Handslist.Add(Hands_Gloves);
            Handslist.Add(Hands_Gloves_Fingerless);

            Hands_DropDown.DataSource = Handslist.ToArray();

            //Drop down box Items: Shoes
            Shoeslist.Add(Feet_None);
            Shoeslist.Add(Shoes);
            Shoeslist.Add(Shoes_Drip);

            Feet_DropDown.DataSource = Shoeslist.ToArray();

			//Loads in all the required images as default
            Character.Load(StickFigure);
            Head_Hat.Load(None.ImageID);
            Face.Load(None.ImageID);
            Neck.Load(None.ImageID);
            Hands.Load(Gloveless.ImageID);
            Feet_Shoes.Load(Feet_None.ImageID);

			//Parents each image to each other for the sake of keeping transparency
            Head_Hat.Parent = Character;
            Face.Parent = Head_Hat;
            Neck.Parent = Face;
            Hands.Parent = Neck;
            Feet_Shoes.Parent = Hands;
			
			//Resets each parented image to coordinates 0,0 so that their locations do not change
            Head_Hat.Location = Face.Location = Neck.Location = Hands.Location = Feet_Shoes.Location = new Point(0, 0);
        }
		
		//DropDown Selected Index Change: Updates the Character display based on what is currently selected in each Drop Down Box
        private void Hat_DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            var SelectedItem = (ComboBoxItem)comboBox.SelectedItem;
            Head_Hat.Load(SelectedItem.ImageID);

        }

        private void Face_DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            var SelectedItem = (ComboBoxItem)comboBox.SelectedItem;
            Face.Load(SelectedItem.ImageID);
        }

        private void Neck_DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            var SelectedItem = (ComboBoxItem)comboBox.SelectedItem;
            Neck.Load(SelectedItem.ImageID);
        }

        private void Hands_DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            var SelectedItem = (ComboBoxItem)comboBox.SelectedItem;
            Hands.Load(SelectedItem.ImageID);
        }

        private void Feet_DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            var SelectedItem = (ComboBoxItem)comboBox.SelectedItem;
            Feet_Shoes.Load(SelectedItem.ImageID);
        }
		
		//Updates the Window Title in the Title bar to feature the players Character name if they type in to the Name bar.
        private void CharacterName_TextChanged(object sender, EventArgs e)
        {
            Text = "Character Creator - " + CharacterName.Text;
        }
    }
}
