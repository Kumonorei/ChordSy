﻿using System;
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

            int verseChords;
            verseChords = Convert.ToInt32(verseChordsNo.Text);

            int chorusChords;
            chorusChords = Convert.ToInt32(chorusChordsNo.Text);

            for (int i = 0; i < verseChords; i++)
            {
                var newChord = "";
                newChord = Chords[rand.Next(6)].ToString();
                chordListVerse += newChord;
                chordListVerse += " ";
            }

            for (int i = 0; i < chorusChords; i++)
            {
                var newChord = "";
                newChord = Chords[rand.Next(6)].ToString();
                chordListChorus += newChord;
                chordListChorus += " ";
            }

            verseChordsOutput.Text = chordListVerse;
            chorusChordsOutput.Text = chordListChorus;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
