using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactive_Story_App
{
    public partial class InteractiveStoryApp : Form
    {
        public InteractiveStoryApp()
        {
            InitializeComponent();
        }

        

        void UpdateMiddle(Button btn)
        {
            btn1TabBeginning.Enabled = false;
            btn2TabBeginning.Enabled = false;

            TabControl.SelectedTab = tbMiddle;
            btn1TabMiddle.Enabled = true;
            btn2TabMiddle.Enabled = true;

            if (btn==btn1TabBeginning)
            {
                txtTabMiddle.Text = btn1TabBeginning.Tag.ToString();           
                btn1TabMiddle.Text = "Help the wolf";         
                btn2TabMiddle.Text = "Run away";
            
            }

            if (btn==btn2TabBeginning)
            {
                txtTabMiddle.Text = btn2TabBeginning.Tag.ToString();
                btn1TabMiddle.Text = "Move toward the light";
                btn2TabMiddle.Text = "Sit and wait";
        
            }

           btn1TabMiddle.Tag = btn1TabMiddle.Text;
           btn2TabMiddle.Tag = btn2TabMiddle.Text;
        }


        void ShowTheEndMessage(string Message,string Ending)
        {
            txtTabEnd.Text = $"{Message}\n\n";
            txtTabEnd.Text += Ending;
        }


        void ResetStory()
        {
            TabControl.SelectedTab = tbStoryIntroduction;

            txtTabBeginning.Text = "";
            btn1TabBeginning.Enabled = false;
            btn2TabBeginning.Enabled = false;

            txtTabMiddle.Text = "";
            btn1TabMiddle.Enabled = false;
            btn2TabMiddle.Enabled = false;

            txtTabEnd.Text = "";
            btnResetStory.Enabled = false;
            btnStart.Enabled = true;
        }

        void SetTheEndOfTheStory(Button btn)
        {
            btn1TabMiddle.Enabled = false;
            btn2TabMiddle.Enabled = false;

            TabControl.SelectedTab = tbEnd;
            btnResetStory.Enabled = true;

            

            if (btn.Tag.ToString() == "Help the wolf")
            {
                ShowTheEndMessage("You free the wolf from the branch.\nIt slowly stands, then disappears into the trees.\nMoments later, the forest opens, and you find your way home.",
                    "Good Ending 🌿");
                return;
            }

            if(btn.Tag.ToString()== "Run away")
            {
                ShowTheEndMessage("You run in fear and fall into a deep pit.\nNo one hears your screams.",
                    "Bad Ending 🌑");
                return;
            }

            if (btn.Tag.ToString() == "Move toward the light")
            {
                ShowTheEndMessage("The light leads you to a small cabin.\nInside, you find safety and warmth.",
                    "Safe Ending 🔥");

                return;
            }

            if (btn.Tag.ToString() == "Sit and wait")
            {
                ShowTheEndMessage("You wait for hours.\nThe cold becomes unbearable, and darkness surrounds you.",
                    "Lonely Ending ❄️");
            }
        }

        void StartStory()
        {
            btnStart.Enabled = false;
            TabControl.SelectedTab = tbBeginning;
           
            txtTabBeginning.Text = btnStart.Tag.ToString();
            btn1TabBeginning.Enabled = true;
            btn2TabBeginning.Enabled = true;

            btn1TabBeginning.Text = "Follow the sound";
            btn2TabBeginning.Text = "Walk away into the darkness";

        }


        private void btn1TabBeginning_Click(object sender, EventArgs e)
        {
            UpdateMiddle((Button)sender);
        }

        private void btn2TabBeginning_Click(object sender, EventArgs e)
        {
            UpdateMiddle((Button)sender);
        }


        private void btn1TabMiddle_Click(object sender, EventArgs e)
        {
            SetTheEndOfTheStory((Button)sender);
        }

        private void btn2TabMiddle_Click(object sender, EventArgs e)
        {
            SetTheEndOfTheStory((Button)sender);
        }

        private void btnResetStory_Click(object sender, EventArgs e)
        {
            ResetStory();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartStory();
        }
    }
}
