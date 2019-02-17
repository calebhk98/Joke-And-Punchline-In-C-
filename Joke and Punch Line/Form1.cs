using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
	Author: Caleb Kirschbaum
	Date: 2/12/19
	Name: Joke and Punch Line
	Goal: To tell a Joke
	 
	 
*/
namespace Joke_and_Punch_Line {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void SetupBtn_Click( object sender, EventArgs e ) {
			JokeLabel.Text = "I don't really understand your code.\nlol You should comment.";//Basic Joke
		}

		private void PunchlineBtn_Click( object sender, EventArgs e ) {
			JokeLabel.Text = "I don't understand it either.\nIt was a lot of trial and error.";//Basic Punchline
		}

		private void CloseBtn_Click( object sender, EventArgs e ) {
			this.Close();//This is to quit after the horrible joke
		}
	}
}
