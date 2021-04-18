using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VIARobot_2
{
	public partial class Form1 : Form
	{



		public Form1()
		{
			InitializeComponent();
		}

		private void theProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This project was started in January 2018. I originally programmed this in Visual Basic, but then, 2 years later, I revisited this project. I switched to C# to make this better. Let me know if you think it is better.");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "VIARobot file (*.via)|*.via";
			saveFileDialog1.ShowDialog();
		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			string fN = saveFileDialog1.FileName;
			richTextBox1.SaveFile(saveFileDialog1.FileName);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		
		}


 		private void button1_Click(object sender, EventArgs e)
		{
			
			{

				if (richTextBox1.Text.Contains("print"))
				{
					Console.WriteLine(richTextBox1.Text.Substring(6));
				}

				if (richTextBox1.Text.Contains("msg "))


				{
					MessageBox.Show(richTextBox1.Text.Substring(4));
				}
			}
		}
		

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
	}

