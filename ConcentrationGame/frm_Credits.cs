//  Name: Connor Larsen
//  Project: ConcentrationGame
//  Title: frm_Instructions.cs
//  Purpose: Form which displays the instructions of the game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcentrationGame
{
    public partial class frm_Credits : Form
    {
        public frm_Credits()
        {
            InitializeComponent();
        }

        // When the player clicks the close button
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();   // Close the form
        }
    }
}
