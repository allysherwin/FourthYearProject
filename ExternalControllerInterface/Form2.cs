using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExternalControllerInterface
{


    public partial class Form2 : Form
    {




        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*TO DO
             * 
             * Read txt file for TV type and set code variables
             * 
             * establish serial connection
             * 
             */



        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /* TO DO
             * 
             * Radio buttons to choose TV type
             * Save all codes in here
             * 
             * Save chosen type in txt file so that it can be remembered without resetting each time
             */

        }
    }
}
