using Abeo.Controls.Common;
using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.Math;
using LotusAPI.Robotics.Doosan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoosanRobotTest {
    public partial class FormDoosanRobotTest : Form {
        DoosanRobotClient _robot = null;
        public FormDoosanRobotTest() {
            InitializeComponent();
            //setup registry key (to store environment setting)
            Registry.SetApplicationName(Application.ProductName);

            //initialize logger
            Logger.Add(new LogViewLogger(lv));

            //init library
            Library.Initialize();
        }

        //Conenct to robot
        private void flatButton1_Click(object sender, EventArgs e) {
            try {
                _robot?.Disconnect();
                _robot = new DoosanRobotClient();
                var f = new FormObjectEditor(_robot.Setting);
                if(f.ShowDialog() == DialogResult.OK) {
                    if(_robot.Connect()) { flatButton1.BackColor = Color.Green; }
                    else throw new Exception("Connection failed");
                }
            } catch(Exception ex) {
                Logger.Error(ex.Message); Logger.Trace(ex.StackTrace);
                flatButton1.BackColor = Color.Red;
            }
        }

        void ThrowIfNotConnected() { if(_robot == null | !_robot.IsConnected) throw new Exception("Robotis not connected"); }

        //Get current pose
        private void flatButton2_Click(object sender, EventArgs e) {
            try {
                ThrowIfNotConnected();
                var pose = _robot.GetCurrentPose();
                Logger.Log("Current pose = " + pose.SimpleString);
            } catch(Exception ex) { Logger.Error(ex.Message); Logger.Trace(ex.StackTrace); }
        }

        //X+100
        private void flatButton3_Click(object sender, EventArgs e) {
            try {
                ThrowIfNotConnected();
                if(!DialogUtils.AskForConfirmation("Do you want to move X+100mm?")) return;

                Logger.Log("MOVEL X+100mm");
                Matrix44d H = LotusAPI.Math.Utils.Trans4(100, 0, 0); //x+100mm transform matrix (R=I, t=(100,0,0))
                MoveRobot(H);
            } catch(Exception ex) { Logger.Error(ex.Message); Logger.Trace(ex.StackTrace); }
        }

        //X-100
        private void flatButton4_Click(object sender, EventArgs e) {
            try {
                ThrowIfNotConnected();
                if(!DialogUtils.AskForConfirmation("Do you want to move X-100mm?")) return;

                Logger.Log("MOVEL X-100mm");
                Matrix44d H = LotusAPI.Math.Utils.Trans4(-100, 0, 0); //x-100mm transform matrix (R=I, t=(-100,0,0))
                MoveRobot(H);

            } catch(Exception ex) { Logger.Error(ex.Message); Logger.Trace(ex.StackTrace); }
        }

        void MoveRobot(Matrix44d H) {
            //prepare transform matrix
            Logger.Log("H=\n" + H);
            //get current pose
            var pose = _robot.GetCurrentPose();
            Logger.Log("Current pose = " + pose.SimpleString);

            //transform the current pose
            pose.Matrix = H * pose.Matrix;

            //ask robot to move
            _robot.MoveL(pose, 500,5000);

            //wait until finish
            _robot.WaitMotion();

            //get new pose 
            var new_pose = _robot.GetCurrentPose();
            Logger.Log("New pose = " + new_pose.SimpleString);
        }
    }
}
