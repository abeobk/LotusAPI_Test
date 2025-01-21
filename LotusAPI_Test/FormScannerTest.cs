using Abeo.Controls;
using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.MV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusAPI_Test {
    public partial class FormScannerTest : Form {
        PointcloudViewer _pcv = null;
        AbeoScan _scanner = null;
        Pointcloud _pc = null;

        public FormScannerTest() {
            InitializeComponent();

            //setup registry key (to store environment setting)
            Registry.SetApplicationName(Application.ProductName);

            //initialize logger
            Logger.Add(new LogViewLogger(lv));

            //init pointcloud viewer
            _pcv = new PointcloudViewer(pcv);

            //init library
            Library.Initialize();


            this.FormClosed += delegate {
                _scanner?.Disconnect();
                Library.Terminate();
            };
        }

        // Connect to scanner
        private void bt_Connect_Click(object sender, EventArgs e) {
            try {
                var f = new FormAbeoscanConnect();

                if(f.ShowDialog() == DialogResult.OK) {
                    _scanner = f.Scanner;
                }

                if(_scanner.IsConnected) {
                    //change button color
                    bt_Connect.ContentBackColor = SolarizedColorPalette.Green;
                    bt_Connect.ForeColor = SolarizedColorPalette.Base03;

                    Logger.Info("Connected to scanner " + _scanner.Signature);

                    //load default profile
                    _scanner.LoadProfile("Default");
                }

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        // Check scanner status
        void AssertScanner() {
            if(_scanner == null) throw new Exception("Invalid scanner!");
            if(!_scanner.IsConnected) throw new Exception("Scanner is not connected!");
        }

        // Capture scene
        private void bt_Scan_Click(object sender, EventArgs e) {
            try {
                AssertScanner();

                //grab a pointcloud
                _pc = _scanner.Scan();

                //clear display
                _pcv.Clear();

                //add to viewer
                _pcv.Add(_pc, Color.White);

                //and display
                _pcv.Render();

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        //Clear display
        private void bt_ClearDisplay_Click(object sender, EventArgs e) {
            _pc = null;
            _pcv.Clear();
            _pcv.Render();
        }

        // Save pointcloud with PLY format
        private void bt_Save_Click(object sender, EventArgs e) {
            DialogUtils.SavePlyFile(_pc, "Save ply file");
        }
    }
}
