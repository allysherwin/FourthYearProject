using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using ArduinoUploader;
using System.Management;

namespace ExternalControllerInterface
{

    public static class Globals //Declare global variables here
    {
        public static string arduinoPath = @"C:\Users\Carly\Desktop\ExternalControllerInterface\ArduinoCode"; //Make this variable
        public static string remoteCode = @"\TV\TV.ino.standard.hex";
        public static string callCode = @"\CallButton\CallButton.ino.standard.hex";
        public static string sPortName = "COM3";
    }
    public partial class Form1 : Form
    {
        //static SerialPort mySerP;

        public Form1()
        {
            InitializeComponent();
            //mySerP = new SerialPort("COM3", 9600);
            //mySerP.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open TV remote page and send TV app to arduino


            /*TO DO: 
             * 
             * Get path of program package and find arduino files from there
             * 
             * Make drop down with port names or identify the one with an arduino on it.
             * 
             */

            //mySerP.Write("H");
            Cursor.Current = Cursors.AppStarting;
     
            //string[] ports = SerialPort.GetPortNames(); //use to make dropdown

            var uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = Globals.arduinoPath + Globals.remoteCode,
                    PortName = Globals.sPortName,
                    ArduinoModel = ArduinoUploader.Hardware.ArduinoModel.UnoR3
                });
            uploader.UploadSketch();

            Cursor.Current = Cursors.Default;

            Form2 remote = new Form2();
            remote.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        { // Larger exit button as top ones are small
            this.Close();
        }
    }
}
