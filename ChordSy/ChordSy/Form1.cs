using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var chordListVerse = "";
            var chordListChorus = "";
            const string Chords = "ABCDEFG";

            for (int i = 0; i < 4; i++)
            {
                var newChord = "";
                newChord = Chords[rand.Next(6)].ToString();
                chordListVerse += newChord;
                chordListVerse += " ";
            }

            for (int i = 0; i < 4; i++)
            {
                var newChord = "";
                newChord = Chords[rand.Next(6)].ToString();
                chordListChorus += newChord;
                chordListChorus += " ";
            }

            label3.Text = chordListVerse;
            label4.Text = chordListChorus;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
