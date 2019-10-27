namespace SkipperSkeetoSaveEditor
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnCreate = new System.Windows.Forms.Button();
			this.LoadSave = new System.Windows.Forms.Button();
			this.lblRoom = new System.Windows.Forms.Label();
			this.cbRoom = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numMinutes = new System.Windows.Forms.NumericUpDown();
			this.cbInventory = new System.Windows.Forms.CheckedListBox();
			this.cbVariables = new System.Windows.Forms.CheckedListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numBonusMinutes = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBonusMinutes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(181, 286);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(177, 26);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Save Changes";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.CreateSaveFile);
			// 
			// LoadSave
			// 
			this.LoadSave.Location = new System.Drawing.Point(12, 12);
			this.LoadSave.Name = "LoadSave";
			this.LoadSave.Size = new System.Drawing.Size(87, 23);
			this.LoadSave.TabIndex = 1;
			this.LoadSave.Text = "Load Save File";
			this.LoadSave.UseVisualStyleBackColor = true;
			this.LoadSave.Click += new System.EventHandler(this.LoadSave_Click);
			// 
			// lblRoom
			// 
			this.lblRoom.AutoSize = true;
			this.lblRoom.Location = new System.Drawing.Point(12, 50);
			this.lblRoom.Name = "lblRoom";
			this.lblRoom.Size = new System.Drawing.Size(35, 13);
			this.lblRoom.TabIndex = 2;
			this.lblRoom.Text = "Room";
			// 
			// cbRoom
			// 
			this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRoom.DropDownWidth = 130;
			this.cbRoom.FormattingEnabled = true;
			this.cbRoom.Items.AddRange(new object[] {
            "Observatory",
            "Fake_Treasure_Room",
            "Mouse_Door",
            "Lumber_Room",
            "Attic_Window_Room",
            "Wine_Cellar",
            "Kids_Room",
            "Crypt",
            "Dining_Room",
            "Dining_Table",
            "Greenhouse",
            "Guest_Room",
            "Main_Hall",
            "Skeleton_Cat",
            "Kitchen",
            "Laboratory",
            "Maze_One",
            "Maze_Two",
            "Library",
            "Living_Room",
            "Bedroom",
            "Roof",
            "Constellations",
            "First_Floor",
            "Sewer_One",
            "Sewer_Two",
            "Skull_Stairs",
            "Clock_Tower_One",
            "Clock_Tower_Two",
            "Runes_Door",
            "Girls_Room",
            "Clockworks",
            "Treasure_Chamber",
            "Game_Over"});
			this.cbRoom.Location = new System.Drawing.Point(66, 47);
			this.cbRoom.Name = "cbRoom";
			this.cbRoom.Size = new System.Drawing.Size(109, 21);
			this.cbRoom.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Minute Hand";
			// 
			// numMinutes
			// 
			this.numMinutes.Location = new System.Drawing.Point(85, 71);
			this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numMinutes.Name = "numMinutes";
			this.numMinutes.Size = new System.Drawing.Size(90, 20);
			this.numMinutes.TabIndex = 6;
			// 
			// cbInventory
			// 
			this.cbInventory.CheckOnClick = true;
			this.cbInventory.FormattingEnabled = true;
			this.cbInventory.Items.AddRange(new object[] {
            "Medallion",
            "Rubber Band",
            "Bedroom Drawer Key",
            "Doll Head",
            "Doll Body",
            "Doll",
            "Dentures",
            "Crowbar",
            "Coin",
            "Dartboard Key",
            "Bugle",
            "Orange bottle",
            "Wine Bottle",
            "Green Bottle",
            "Book of Runes",
            "Battery",
            "Needle",
            "Matchbox",
            "Match",
            "Blue Book",
            "Bedroom Key Handle",
            "Bedroom Key End",
            "Bedroom Key",
            "Dining Room Key",
            "Clock Tower Key",
            "Ladder Key",
            "Hammer Head",
            "Hammer Handle",
            "Hammer",
            "Flower Bulb",
            "Yellow Flower",
            "Paper Piece 1",
            "Paper Piece 2",
            "Paper Piece 3",
            "Paper Piece 4",
            "Paper Piece 5",
            "Paper Piece 6",
            "Paper Piece 7",
            "Paper Piece 8",
            "Paper Piece 9",
            "Paper Piece 10",
            "Paper Piece 11",
            "Paper Piece 12",
            "Paper Piece 13",
            "White Flower",
            "Nitroglycerin",
            "Lever",
            "Lamp Wick",
            "Toy Rabbit (No Battery)",
            "Spring",
            "Spoon",
            "Slingshot handle",
            "Slingshot",
            "Salami",
            "Salami (with Teeth)",
            "Rubber",
            "Toy Rabbit (With battery)"});
			this.cbInventory.Location = new System.Drawing.Point(364, 47);
			this.cbInventory.Name = "cbInventory";
			this.cbInventory.Size = new System.Drawing.Size(162, 229);
			this.cbInventory.TabIndex = 8;
			// 
			// cbVariables
			// 
			this.cbVariables.CheckOnClick = true;
			this.cbVariables.Enabled = false;
			this.cbVariables.FormattingEnabled = true;
			this.cbVariables.Items.AddRange(new object[] {
            "Unlock Clock Tower",
            "Unlock Dining Room",
            "Unlock Bedroom",
            "Unlock Bedroom Drawer",
            "Unlock Lumber Room",
            "Unlock Wine Cellar",
            "Unlock Laboratory",
            "Unlock Wine Barrel",
            "Unlock Sewer Ladder",
            "Unlock Crypt",
            "Open Crypt Stairs",
            "",
            "Trigger Armor Axe",
            "Old woman ghost (Needle)",
            "Skull stairs ghost (Coin)",
            "Living room ghost (Bugle)",
            "Little girl ghost (Doll)",
            "Dining room ghost (Spoon)"});
			this.cbVariables.Location = new System.Drawing.Point(181, 47);
			this.cbVariables.Name = "cbVariables";
			this.cbVariables.Size = new System.Drawing.Size(177, 229);
			this.cbVariables.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(361, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Inventory";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(178, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Variables";
			// 
			// numBonusMinutes
			// 
			this.numBonusMinutes.Location = new System.Drawing.Point(92, 94);
			this.numBonusMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.numBonusMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numBonusMinutes.Name = "numBonusMinutes";
			this.numBonusMinutes.Size = new System.Drawing.Size(83, 20);
			this.numBonusMinutes.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Bonus Minutes";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 321);
			this.Controls.Add(this.numBonusMinutes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbVariables);
			this.Controls.Add(this.cbInventory);
			this.Controls.Add(this.numMinutes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbRoom);
			this.Controls.Add(this.lblRoom);
			this.Controls.Add(this.LoadSave);
			this.Controls.Add(this.btnCreate);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Skipper and Skeeto 2 Save Editor";
			((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBonusMinutes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button LoadSave;
		private System.Windows.Forms.Label lblRoom;
		private System.Windows.Forms.ComboBox cbRoom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numMinutes;
		private System.Windows.Forms.CheckedListBox cbInventory;
		private System.Windows.Forms.CheckedListBox cbVariables;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numBonusMinutes;
		private System.Windows.Forms.Label label4;
	}
}

