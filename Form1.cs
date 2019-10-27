using System;
using System.IO;
using System.Windows.Forms;

namespace SkipperSkeetoSaveEditor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private string SavePath = string.Empty;
		private uint[] FileData;

		/// <summary>
		/// Searches for a variable in FileData and returns its value
		/// </summary>
		/// <param name="base_id">The hexadecimal value for the variable ID</param>
		/// <param name="offset">The offset of the variable value from the base_id</param>
		public int GetVariable (string base_id, int offset)
		{
			for (int b = 0; b < FileData.Length; b++)
			{
				string hex = ReverseBytes(FileData[b]).ToString("X8");
				if(hex.Equals(base_id))
				{
					return (int)FileData[b + offset];
				}
			}
			return -1;
		}

		/// <summary>
		/// Sets a variable in FileData to newValue
		/// </summary>
		/// <param name="base_id">The hexadecimal value for the variable ID</param>
		/// <param name="offset">The offset of the variable value from the base_id</param>
		/// <param name="newValue">The new integer value</param>
		public void SetVariable(string base_id, int offset, uint newValue)
		{
			for (int b = 0; b < FileData.Length; b++)
			{
				string hex = ReverseBytes(FileData[b]).ToString("X8");
				if (hex.Equals(base_id))
				{
					FileData[b + offset] = newValue;
				}
			}
		}

		/// <summary>
		/// Writes all form data to the FileData array
		/// </summary>
		public void CreateSaveFile (object sender, System.EventArgs e)
		{
			// Set Room
			Rooms newRoom;
			Enum.TryParse(cbRoom.Text, out newRoom);
			SetVariable("11000100", 2, (uint)newRoom);

			// Set Time
			SetVariable("11000500", 2, (uint)numMinutes.Value);

			// Set Bonus Minutes
			SetVariable("52003600", 2, (uint)numBonusMinutes.Value);

			// Inventory
			SetVariable("3F002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(0)));
			SetVariable("4F002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(1)));
			SetVariable("4E002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(2)));
			SetVariable("4D002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(3)));
			SetVariable("4C002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(4)));
			SetVariable("4B002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(5)));
			SetVariable("4A002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(6)));
			SetVariable("49002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(7)));
			SetVariable("48002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(8)));
			SetVariable("47002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(9)));
			SetVariable("46002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(10)));
			SetVariable("45002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(11)));
			SetVariable("44002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(12)));
			SetVariable("43002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(13)));
			SetVariable("42002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(14)));
			SetVariable("40002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(15)));
			SetVariable("5F002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(16)));
			SetVariable("5E002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(17)));
			SetVariable("5D002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(18)));
			SetVariable("5C002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(19)));
			SetVariable("5B002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(20)));
			SetVariable("5A002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(21)));
			SetVariable("59002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(22)));
			SetVariable("58002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(23)));
			SetVariable("57002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(24)));
			SetVariable("56002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(25)));
			SetVariable("55002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(26)));
			SetVariable("54002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(27)));
			SetVariable("53002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(28)));
			SetVariable("51002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(29)));
			SetVariable("50002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(30)));
			SetVariable("6F002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(31)));
			SetVariable("6E002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(32)));
			SetVariable("6D002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(33)));
			SetVariable("6C002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(34)));
			SetVariable("6B002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(35)));
			SetVariable("6A002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(36)));
			SetVariable("69002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(37)));
			SetVariable("68002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(38)));
			SetVariable("67002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(39)));
			SetVariable("66002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(40)));
			SetVariable("65002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(41)));
			SetVariable("64002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(42)));
			SetVariable("62002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(43)));
			SetVariable("61002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(44)));
			SetVariable("60002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(45)));
			SetVariable("7B002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(46)));
			SetVariable("7A002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(47)));
			SetVariable("79002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(48)));
			SetVariable("77002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(49)));
			SetVariable("76002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(50)));
			SetVariable("75002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(51)));
			SetVariable("74002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(52)));
			SetVariable("72002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(53)));
			SetVariable("73002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(54)));
			SetVariable("71002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(55)));
			SetVariable("70002D00", 2, Convert.ToUInt32(cbInventory.GetItemChecked(56)));

			// Save the file changes
			WriteToFile(SavePath);
		}

		/// <summary>
		/// Writes FileData to the currently loaded file
		/// </summary>
		/// <param name="fileName"></param>
		private void WriteToFile(string fileName)
		{
			using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
			{
				byte[] byteArray = new byte[FileData.Length * sizeof(int)];
				Buffer.BlockCopy(FileData, 0, byteArray, 0, byteArray.Length);
				fs.Write(byteArray, 0, byteArray.Length);
			}
		}

		/// <summary>
		/// Deals with endianness by flipping the order of bytes
		/// </summary>
		private int ReverseBytes(UInt32 value)
		{
			return (int)((value & 0x000000FFU) << 24 | (value & 0x0000FF00U) << 8 | (value & 0x00FF0000U) >> 8 | (value & 0xFF000000U) >> 24);
		}

		/// <summary>
		/// Allows the user to choose a Skipper and Skeeto 2 save file to load the values from.
		/// Reads each 4 byte chunk of data into the FileData array.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoadSave_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				//openFileDialog.InitialDirectory = "C:\\Users\\dndga\\AppData\\Local\\VirtualStore\\Program Files (x86)\\Skipper2";
				openFileDialog.InitialDirectory = "C:\\Program Files (x86)\\";
				openFileDialog.Filter = "m2s files (*.m2s)|*.m2s";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					SavePath = openFileDialog.FileName;
					FileStream fs = new FileStream(SavePath, FileMode.Open, FileAccess.Read);
					FileData = new uint[fs.Length / 4];
					byte[] intBytes = new byte[4];
					int index = 0;
					while (fs.Position < fs.Length)
					{
						intBytes = new byte[4];
						fs.Read(intBytes, 0, 4);
						FileData[index++] =  BitConverter.ToUInt32(intBytes, 0);
					}
					fs.Close();
					UpdateUI();
				}
			}
		}

		/// <summary>
		/// Read values from FileData and display them on the form
		/// </summary>
		private void UpdateUI ()
		{
			// Room
			cbRoom.SelectedIndex = cbRoom.FindStringExact(((Rooms)GetVariable("11000100", 2)).ToString());
			// Time
			numMinutes.Value = GetVariable("11000500", 2);
			// Bonus Minutes
			numBonusMinutes.Value = GetVariable("52003600", 2);
			// Variables
			
			// Inventory
			cbInventory.SetItemChecked(0,  Convert.ToBoolean(GetVariable("3F002D00", 2)));
			cbInventory.SetItemChecked(1,  Convert.ToBoolean(GetVariable("4F002D00", 2)));
			cbInventory.SetItemChecked(2,  Convert.ToBoolean(GetVariable("4E002D00", 2)));
			cbInventory.SetItemChecked(3,  Convert.ToBoolean(GetVariable("4D002D00", 2)));
			cbInventory.SetItemChecked(4,  Convert.ToBoolean(GetVariable("4C002D00", 2)));
			cbInventory.SetItemChecked(5,  Convert.ToBoolean(GetVariable("4B002D00", 2)));
			cbInventory.SetItemChecked(6,  Convert.ToBoolean(GetVariable("4A002D00", 2)));
			cbInventory.SetItemChecked(7,  Convert.ToBoolean(GetVariable("49002D00", 2)));
			cbInventory.SetItemChecked(8,  Convert.ToBoolean(GetVariable("48002D00", 2)));
			cbInventory.SetItemChecked(9,  Convert.ToBoolean(GetVariable("47002D00", 2)));
			cbInventory.SetItemChecked(10, Convert.ToBoolean(GetVariable("46002D00", 2)));
			cbInventory.SetItemChecked(11, Convert.ToBoolean(GetVariable("45002D00", 2)));
			cbInventory.SetItemChecked(12, Convert.ToBoolean(GetVariable("44002D00", 2)));
			cbInventory.SetItemChecked(13, Convert.ToBoolean(GetVariable("43002D00", 2)));
			cbInventory.SetItemChecked(14, Convert.ToBoolean(GetVariable("42002D00", 2)));
			cbInventory.SetItemChecked(15, Convert.ToBoolean(GetVariable("40002D00", 2)));
			cbInventory.SetItemChecked(16, Convert.ToBoolean(GetVariable("5F002D00", 2)));
			cbInventory.SetItemChecked(17, Convert.ToBoolean(GetVariable("5E002D00", 2)));
			cbInventory.SetItemChecked(18, Convert.ToBoolean(GetVariable("5D002D00", 2)));
			cbInventory.SetItemChecked(19, Convert.ToBoolean(GetVariable("5C002D00", 2)));
			cbInventory.SetItemChecked(20, Convert.ToBoolean(GetVariable("5B002D00", 2)));
			cbInventory.SetItemChecked(21, Convert.ToBoolean(GetVariable("5A002D00", 2)));
			cbInventory.SetItemChecked(22, Convert.ToBoolean(GetVariable("59002D00", 2)));
			cbInventory.SetItemChecked(23, Convert.ToBoolean(GetVariable("58002D00", 2)));
			cbInventory.SetItemChecked(24, Convert.ToBoolean(GetVariable("57002D00", 2)));
			cbInventory.SetItemChecked(25, Convert.ToBoolean(GetVariable("56002D00", 2)));
			cbInventory.SetItemChecked(26, Convert.ToBoolean(GetVariable("55002D00", 2)));
			cbInventory.SetItemChecked(27, Convert.ToBoolean(GetVariable("54002D00", 2)));
			cbInventory.SetItemChecked(28, Convert.ToBoolean(GetVariable("53002D00", 2)));
			cbInventory.SetItemChecked(29, Convert.ToBoolean(GetVariable("51002D00", 2)));
			cbInventory.SetItemChecked(30, Convert.ToBoolean(GetVariable("50002D00", 2)));
			cbInventory.SetItemChecked(31, Convert.ToBoolean(GetVariable("6F002D00", 2)));
			cbInventory.SetItemChecked(32, Convert.ToBoolean(GetVariable("6E002D00", 2)));
			cbInventory.SetItemChecked(33, Convert.ToBoolean(GetVariable("6D002D00", 2)));
			cbInventory.SetItemChecked(34, Convert.ToBoolean(GetVariable("6C002D00", 2)));
			cbInventory.SetItemChecked(35, Convert.ToBoolean(GetVariable("6B002D00", 2)));
			cbInventory.SetItemChecked(36, Convert.ToBoolean(GetVariable("6A002D00", 2)));
			cbInventory.SetItemChecked(37, Convert.ToBoolean(GetVariable("69002D00", 2)));
			cbInventory.SetItemChecked(38, Convert.ToBoolean(GetVariable("68002D00", 2)));
			cbInventory.SetItemChecked(39, Convert.ToBoolean(GetVariable("67002D00", 2)));
			cbInventory.SetItemChecked(40, Convert.ToBoolean(GetVariable("66002D00", 2)));
			cbInventory.SetItemChecked(41, Convert.ToBoolean(GetVariable("65002D00", 2)));
			cbInventory.SetItemChecked(42, Convert.ToBoolean(GetVariable("64002D00", 2)));
			cbInventory.SetItemChecked(43, Convert.ToBoolean(GetVariable("62002D00", 2)));
			cbInventory.SetItemChecked(44, Convert.ToBoolean(GetVariable("61002D00", 2)));
			cbInventory.SetItemChecked(45, Convert.ToBoolean(GetVariable("60002D00", 2)));
			cbInventory.SetItemChecked(46, Convert.ToBoolean(GetVariable("7B002D00", 2)));
			cbInventory.SetItemChecked(47, Convert.ToBoolean(GetVariable("7A002D00", 2)));
			cbInventory.SetItemChecked(48, Convert.ToBoolean(GetVariable("79002D00", 2)));
			cbInventory.SetItemChecked(49, Convert.ToBoolean(GetVariable("77002D00", 2)));
			cbInventory.SetItemChecked(50, Convert.ToBoolean(GetVariable("76002D00", 2)));
			cbInventory.SetItemChecked(51, Convert.ToBoolean(GetVariable("75002D00", 2)));
			cbInventory.SetItemChecked(52, Convert.ToBoolean(GetVariable("74002D00", 2)));
			cbInventory.SetItemChecked(53, Convert.ToBoolean(GetVariable("72002D00", 2)));
			cbInventory.SetItemChecked(54, Convert.ToBoolean(GetVariable("73002D00", 2)));
			cbInventory.SetItemChecked(55, Convert.ToBoolean(GetVariable("71002D00", 2)));
			cbInventory.SetItemChecked(56, Convert.ToBoolean(GetVariable("70002D00", 2)));
		}
	}
}
