
namespace Character_Creator_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Character = new System.Windows.Forms.PictureBox();
            this.CharacterName = new System.Windows.Forms.TextBox();
            this.Hat_DropDown = new System.Windows.Forms.ComboBox();
            this.Neck_DropDown = new System.Windows.Forms.ComboBox();
            this.Face_DropDown = new System.Windows.Forms.ComboBox();
            this.Hands_DropDown = new System.Windows.Forms.ComboBox();
            this.Feet_DropDown = new System.Windows.Forms.ComboBox();
            this.Label_Head = new System.Windows.Forms.Label();
            this.Label_Neck = new System.Windows.Forms.Label();
            this.Label_Gloves = new System.Windows.Forms.Label();
            this.Label_Face = new System.Windows.Forms.Label();
            this.Label_Shoes = new System.Windows.Forms.Label();
            this.Label_Instruction = new System.Windows.Forms.Label();
            this.Head_Hat = new System.Windows.Forms.PictureBox();
            this.CharacterInfo = new System.Windows.Forms.TextBox();
            this.Face = new System.Windows.Forms.PictureBox();
            this.Neck = new System.Windows.Forms.PictureBox();
            this.Hands = new System.Windows.Forms.PictureBox();
            this.Feet_Shoes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Head_Hat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Feet_Shoes)).BeginInit();
            this.SuspendLayout();
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.Transparent;
            this.Character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Character.Location = new System.Drawing.Point(261, 56);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(253, 352);
            this.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Character.TabIndex = 0;
            this.Character.TabStop = false;
            // 
            // CharacterName
            // 
            this.CharacterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterName.Location = new System.Drawing.Point(535, 57);
            this.CharacterName.Multiline = true;
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.PlaceholderText = "Character Name Here";
            this.CharacterName.Size = new System.Drawing.Size(253, 114);
            this.CharacterName.TabIndex = 1;
            this.CharacterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharacterName.TextChanged += new System.EventHandler(this.CharacterName_TextChanged);
            // 
            // Hat_DropDown
            // 
            this.Hat_DropDown.FormattingEnabled = true;
            this.Hat_DropDown.Location = new System.Drawing.Point(325, 27);
            this.Hat_DropDown.Name = "Hat_DropDown";
            this.Hat_DropDown.Size = new System.Drawing.Size(121, 23);
            this.Hat_DropDown.TabIndex = 2;
            this.Hat_DropDown.SelectedIndexChanged += new System.EventHandler(this.Hat_DropDown_SelectedIndexChanged);
            // 
            // Neck_DropDown
            // 
            this.Neck_DropDown.FormattingEnabled = true;
            this.Neck_DropDown.Location = new System.Drawing.Point(44, 174);
            this.Neck_DropDown.Name = "Neck_DropDown";
            this.Neck_DropDown.Size = new System.Drawing.Size(121, 23);
            this.Neck_DropDown.TabIndex = 3;
            this.Neck_DropDown.SelectedIndexChanged += new System.EventHandler(this.Neck_DropDown_SelectedIndexChanged);
            // 
            // Face_DropDown
            // 
            this.Face_DropDown.FormattingEnabled = true;
            this.Face_DropDown.Location = new System.Drawing.Point(44, 75);
            this.Face_DropDown.Name = "Face_DropDown";
            this.Face_DropDown.Size = new System.Drawing.Size(121, 23);
            this.Face_DropDown.TabIndex = 4;
            this.Face_DropDown.SelectedIndexChanged += new System.EventHandler(this.Face_DropDown_SelectedIndexChanged);
            // 
            // Hands_DropDown
            // 
            this.Hands_DropDown.FormattingEnabled = true;
            this.Hands_DropDown.Location = new System.Drawing.Point(44, 278);
            this.Hands_DropDown.Name = "Hands_DropDown";
            this.Hands_DropDown.Size = new System.Drawing.Size(121, 23);
            this.Hands_DropDown.TabIndex = 6;
            this.Hands_DropDown.SelectedIndexChanged += new System.EventHandler(this.Hands_DropDown_SelectedIndexChanged);
            // 
            // Feet_DropDown
            // 
            this.Feet_DropDown.FormattingEnabled = true;
            this.Feet_DropDown.Location = new System.Drawing.Point(44, 386);
            this.Feet_DropDown.Name = "Feet_DropDown";
            this.Feet_DropDown.Size = new System.Drawing.Size(121, 23);
            this.Feet_DropDown.TabIndex = 7;
            this.Feet_DropDown.SelectedIndexChanged += new System.EventHandler(this.Feet_DropDown_SelectedIndexChanged);
            // 
            // Label_Head
            // 
            this.Label_Head.AutoSize = true;
            this.Label_Head.Location = new System.Drawing.Point(368, 9);
            this.Label_Head.Name = "Label_Head";
            this.Label_Head.Size = new System.Drawing.Size(35, 15);
            this.Label_Head.TabIndex = 8;
            this.Label_Head.Text = "Head";
            // 
            // Label_Neck
            // 
            this.Label_Neck.AutoSize = true;
            this.Label_Neck.Location = new System.Drawing.Point(87, 156);
            this.Label_Neck.Name = "Label_Neck";
            this.Label_Neck.Size = new System.Drawing.Size(34, 15);
            this.Label_Neck.TabIndex = 9;
            this.Label_Neck.Text = "Neck";
            // 
            // Label_Gloves
            // 
            this.Label_Gloves.AutoSize = true;
            this.Label_Gloves.Location = new System.Drawing.Point(87, 260);
            this.Label_Gloves.Name = "Label_Gloves";
            this.Label_Gloves.Size = new System.Drawing.Size(42, 15);
            this.Label_Gloves.TabIndex = 10;
            this.Label_Gloves.Text = "Gloves";
            // 
            // Label_Face
            // 
            this.Label_Face.AutoSize = true;
            this.Label_Face.Location = new System.Drawing.Point(89, 57);
            this.Label_Face.Name = "Label_Face";
            this.Label_Face.Size = new System.Drawing.Size(37, 15);
            this.Label_Face.TabIndex = 11;
            this.Label_Face.Text = "Facial";
            // 
            // Label_Shoes
            // 
            this.Label_Shoes.AutoSize = true;
            this.Label_Shoes.Location = new System.Drawing.Point(89, 365);
            this.Label_Shoes.Name = "Label_Shoes";
            this.Label_Shoes.Size = new System.Drawing.Size(38, 15);
            this.Label_Shoes.TabIndex = 13;
            this.Label_Shoes.Text = "Shoes";
            // 
            // Label_Instruction
            // 
            this.Label_Instruction.AutoSize = true;
            this.Label_Instruction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Instruction.Location = new System.Drawing.Point(1, 12);
            this.Label_Instruction.Name = "Label_Instruction";
            this.Label_Instruction.Size = new System.Drawing.Size(204, 42);
            this.Label_Instruction.TabIndex = 14;
            this.Label_Instruction.Text = "Select any of the drop down\r\n to apply accessories";
            this.Label_Instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Head_Hat
            // 
            this.Head_Hat.BackColor = System.Drawing.Color.Transparent;
            this.Head_Hat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Head_Hat.Location = new System.Drawing.Point(260, 56);
            this.Head_Hat.Name = "Head_Hat";
            this.Head_Hat.Size = new System.Drawing.Size(254, 353);
            this.Head_Hat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Head_Hat.TabIndex = 15;
            this.Head_Hat.TabStop = false;
            // 
            // CharacterInfo
            // 
            this.CharacterInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CharacterInfo.Location = new System.Drawing.Point(535, 199);
            this.CharacterInfo.Multiline = true;
            this.CharacterInfo.Name = "CharacterInfo";
            this.CharacterInfo.PlaceholderText = "Info/Description Here";
            this.CharacterInfo.Size = new System.Drawing.Size(253, 210);
            this.CharacterInfo.TabIndex = 16;
            // 
            // Face
            // 
            this.Face.BackColor = System.Drawing.Color.Transparent;
            this.Face.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Face.Location = new System.Drawing.Point(261, 56);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(253, 352);
            this.Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Face.TabIndex = 17;
            this.Face.TabStop = false;
            // 
            // Neck
            // 
            this.Neck.BackColor = System.Drawing.Color.Transparent;
            this.Neck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Neck.Location = new System.Drawing.Point(261, 56);
            this.Neck.Name = "Neck";
            this.Neck.Size = new System.Drawing.Size(253, 352);
            this.Neck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Neck.TabIndex = 18;
            this.Neck.TabStop = false;
            // 
            // Hands
            // 
            this.Hands.BackColor = System.Drawing.Color.Transparent;
            this.Hands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Hands.Location = new System.Drawing.Point(261, 56);
            this.Hands.Name = "Hands";
            this.Hands.Size = new System.Drawing.Size(253, 352);
            this.Hands.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hands.TabIndex = 19;
            this.Hands.TabStop = false;
            // 
            // Feet_Shoes
            // 
            this.Feet_Shoes.BackColor = System.Drawing.Color.Transparent;
            this.Feet_Shoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Feet_Shoes.Location = new System.Drawing.Point(261, 56);
            this.Feet_Shoes.Name = "Feet_Shoes";
            this.Feet_Shoes.Size = new System.Drawing.Size(253, 352);
            this.Feet_Shoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Feet_Shoes.TabIndex = 20;
            this.Feet_Shoes.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Head_Hat);
            this.Controls.Add(this.Feet_Shoes);
            this.Controls.Add(this.Hands);
            this.Controls.Add(this.Neck);
            this.Controls.Add(this.Face);
            this.Controls.Add(this.CharacterInfo);
            this.Controls.Add(this.Label_Instruction);
            this.Controls.Add(this.Label_Shoes);
            this.Controls.Add(this.Label_Face);
            this.Controls.Add(this.Label_Gloves);
            this.Controls.Add(this.Label_Neck);
            this.Controls.Add(this.Label_Head);
            this.Controls.Add(this.Feet_DropDown);
            this.Controls.Add(this.Hands_DropDown);
            this.Controls.Add(this.Face_DropDown);
            this.Controls.Add(this.Neck_DropDown);
            this.Controls.Add(this.Hat_DropDown);
            this.Controls.Add(this.CharacterName);
            this.Controls.Add(this.Character);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Character Creator";
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Head_Hat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Neck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Feet_Shoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.TextBox CharacterName;
        private System.Windows.Forms.ComboBox Hat_DropDown;
        private System.Windows.Forms.ComboBox Neck_DropDown;
        private System.Windows.Forms.ComboBox Face_DropDown;
        private System.Windows.Forms.ComboBox Hands_DropDown;
        private System.Windows.Forms.ComboBox Feet_DropDown;
        private System.Windows.Forms.Label Label_Head;
        private System.Windows.Forms.Label Label_Neck;
        private System.Windows.Forms.Label Label_Gloves;
        private System.Windows.Forms.Label Label_Face;
        private System.Windows.Forms.Label Label_Shoes;
        private System.Windows.Forms.Label Label_Instruction;
        private System.Windows.Forms.PictureBox Head_Hat;
        private System.Windows.Forms.TextBox CharacterInfo;
        private System.Windows.Forms.PictureBox Face;
        private System.Windows.Forms.PictureBox Neck;
        private System.Windows.Forms.PictureBox Hands;
        private System.Windows.Forms.PictureBox Feet_Shoes;
    }
}

