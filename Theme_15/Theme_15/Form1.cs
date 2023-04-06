using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Theme_15.Classes;

namespace Theme_15
{
    public partial class tamagochiUE : Form
    {

        private Frames pics;
        private AnimationData animationData;
        private Request request;

        private bool requestIsActive;

        private int secondsLeftTillRequest;
        private int secondsLeftTillBadAction;

        private int mood;
        private string currentRequest;

        private string currentStage; //is used for Help btn

        public tamagochiUE()
        {
            InitializeComponent();

            this.currentStage = "general";

            this.pics = new Frames();
            this.request = new Request();

            this.requestIsActive = false;
            this.secondsLeftTillRequest = 50;
            this.secondsLeftTillBadAction = 10;
            this.mood = 0;

            this.imges.BackgroundImage = menhera_chan.startSCR.startScreen;
        }

        private void gameOver()
        {
            this.currentStage = "general";

            MessageBox.Show("You have failed servi... khm, taking care of this cutie, shame on you!");

            this.animationData = new AnimationData("ending");
            this.animation_tmr.Enabled = true;

            this.generateRequest_tmr.Enabled = false;
            this.badAction_tmr.Enabled = false;
            this.mood = 0;
            this.badActionTimer_pb.Value = 0;
        }
        private void enteredButton(ref Label btn, bool entered)
        {
            if(btn.Enabled)
            {
                btn.BackColor = entered ? Color.LightCoral : Color.MistyRose;
                btn.ForeColor = entered ? Color.White : Color.Black;
            }
        }

        #region start_lbl
        private void start_lbl_Click(object sender, EventArgs e)
        {
            this.currentStage = "started";

            this.animationData = new AnimationData("start");
            this.animation_tmr.Enabled = true;
            this.enteredButton(ref this.start_lbl, false);

            this.start_lbl.Enabled = false;

            this.goodAction_lbl.Enabled = false;

            this.enteredButton(ref this.start_lbl, false);
        }
        private void start_lbl_MouseEnter(object sender, EventArgs e)
        {
            this.enteredButton(ref this.start_lbl, true);
        }
        private void start_lbl_MouseLeave(object sender, EventArgs e)
        {
            this.enteredButton(ref this.start_lbl, false);
        }
        #endregion

        #region help_lbl
        private void help_btn_Click(object sender, EventArgs e)
        {
            switch (this.currentStage)
            {
                case "general":

                    MessageBox.Show("Hello there!\n\n Welcome to TAMAGOCHI ULTIMATE EDITION\nHere you will serve, sorry taking care of the girl located on the screen.\n\nWell, good luck");

                    break;
                case "started":

                    MessageBox.Show("Now you are waiting for orede.. khm, requests from this cutie");


                    break;
                case "event":

                    MessageBox.Show($"Here menhera-chan(yes, this is her actuall name) asks you for {this.currentRequest}.\nWhat to do? Simply press Good action button.");

                    break;
            }
        }
        private void help_btn_MouseEnter(object sender, EventArgs e)
        {
            this.enteredButton(ref this.help_btn, true);
        }
        private void help_btn_MouseLeave(object sender, EventArgs e)
        {
            this.enteredButton(ref this.help_btn, false);
        }
        #endregion

        #region goodAction_lbl
        private void goodAction_lbl_Click(object sender, EventArgs e)
        {

            this.enteredButton(ref this.goodAction_lbl, false);
            if (this.goodAction_lbl.Text == "Heal")
            {
                this.mood = (this.mood != 0?--(this.mood): this.mood);
                this.goodAction_lbl.Enabled = false;
                this.imges.BackgroundImage = this.pics.States[this.mood];
            }
            else if (this.goodAction_lbl.Text == "Good action")
            {
                this.goodAction_lbl.Text = "Heal";
                this.goodAction_lbl.Enabled = false;

                this.activities_tmr.Enabled = true;

                this.requestIsActive = false;
                this.generateRequest_tmr.Enabled = true;

                this.badAction_lbl.Text = "What's up?";

                this.badActionTimer_pb.Value = 0;
                this.secondsLeftTillBadAction = 10;
                this.badAction_tmr.Enabled = false;
            }
        }
        private void goodAction_lbl_MouseEnter(object sender, EventArgs e)
        {
            this.enteredButton(ref this.goodAction_lbl, true);
        }

        private void goodAction_lbl_MouseLeave(object sender, EventArgs e)
        {
            this.enteredButton(ref this.goodAction_lbl, false);
        }
        #endregion

        #region badAction_lbl
        private void badAction_lbl_Click(object sender, EventArgs e)
        {
            this.enteredButton(ref this.badAction_lbl, false);
            if (this.badAction_lbl.Text == "What's up?")
            {
                this.imges.BackgroundImage = this.pics.Whats_up_reactions[this.mood];

                this.badAction_lbl.Enabled = false;
                this.whatsUpReactionShowcase_tmr.Enabled = true;
                this.badAction_tmr.Enabled = false;
                this.generateRequest_tmr.Enabled = false;
            }
            else if (this.badAction_lbl.Text == "Reject")
            {
                this.requestIsActive = false;
                this.generateRequest_tmr.Enabled = true;
                this.badAction_lbl.Text = "What's up?";

                this.badActionTimer_pb.Value = 0;
                this.secondsLeftTillBadAction = 10;
                this.badAction_tmr.Enabled = false;

                if (++(this.mood) <= 2)
                {
                    this.imges.BackgroundImage = this.pics.States[this.mood];
                    if (this.mood != 0)
                    {
                        this.goodAction_lbl.Text = "Heal";
                        this.goodAction_lbl.Enabled = true;
                    }
                }
                else
                {
                    this.gameOver();
                }
            }
        }
        private void badAction_lbl_MouseEnter(object sender, EventArgs e)
        {
            this.enteredButton(ref this.badAction_lbl, true);
        }

        private void badAction_lbl_MouseLeave(object sender, EventArgs e)
        {
            this.enteredButton(ref this.badAction_lbl, false);
        }
        #endregion

        private void badActionTimer_pb_Click(object sender, EventArgs e)
        {
            if (this.start_lbl.Enabled && !this.requestIsActive)
                MessageBox.Show("Try matybe, I don't know, starting the game! To find out what is this bucking bar doing!");
            else if (!this.requestIsActive)
                MessageBox.Show("Time till you automaticaly reject this cutie's request");
            else
                MessageBox.Show("Time till cutie will ask you something");
        }
        private void animation_tmr_Tick(object sender, EventArgs e)
        {
            if(this.animationData.Animation == "start")
            {
                if (this.animationData.Index == this.animationData.Length)
                {
                    this.imges.BackgroundImage = menhera_chan.States.goodMoodState;
                    this.mood = 0;
                    this.animation_tmr.Enabled = false;

                    this.goodAction_lbl.Text = "Heal";

                    this.badAction_lbl.Enabled = true;
                    this.badAction_lbl.Text = "What's up?";

                    this.generateRequest_tmr.Enabled = true;

                    return;
                }
                int index = this.animationData.Index - 1;

                this.imges.BackgroundImage = this.pics.Starting_animation[index];
                this.animationData.Index = this.animationData.Index + 1;
            }
            else if(this.animationData.Animation == "ending")
            {
                if (this.animationData.Index == this.animationData.Length)
                {
                    this.animation_tmr.Enabled = false;

                    this.imges.BackgroundImage = menhera_chan.startSCR.startScreen;
                    this.animation_tmr.Enabled = false;

                    this.start_lbl.Enabled = true;

                    this.goodAction_lbl.Text = "Good action";
                    this.goodAction_lbl.Enabled = false;

                    this.badAction_lbl.Text = "Bad action";
                    this.badAction_lbl.Enabled = false;

                    this.start_lbl.Enabled = true;

                    return;
                }
                this.imges.BackgroundImage = this.pics.Reactions_on_rejections[2 + this.animationData.Index];
                this.animationData.Index = this.animationData.Index + 1;
            }
            else
            {

            }
        }
        private void generateRequest_tmr_Tick(object sender, EventArgs e)
        {
            if(this.secondsLeftTillRequest > 0)
            {
                this.badActionTimer_pb.Value += 2;
                this.secondsLeftTillRequest--;
            }
            else
            {
                this.goodAction_lbl.Enabled = true;
                this.requestIsActive = true;
                this.currentStage = this.currentRequest = this.request.generateRequest();

                this.goodAction_lbl.Enabled = true;
                this.goodAction_lbl.Text = "Good action";

                this.badAction_tmr.Enabled = true;
                this.badAction_lbl.Text = "Reject";

                this.badActionTimer_pb.Value = 0;
                this.secondsLeftTillRequest = 50;
                this.generateRequest_tmr.Enabled = false;

                this.currentStage = "general";

                switch (this.currentRequest)
                {
                    case "eat":
                        this.imges.BackgroundImage = this.pics.Eating[0];
                        break;
                    case "play":
                        this.imges.BackgroundImage = this.pics.Playing[0];
                        break;
                    case "sleep":
                        this.imges.BackgroundImage = this.pics.Sleep[0];
                        break;
                }
            }
        }
        private void badAction_tmr_Tick(object sender, EventArgs e)
        {
            if (this.secondsLeftTillBadAction > 0)
            {
                this.badActionTimer_pb.Value += 10;
                this.secondsLeftTillBadAction--;
            }
            else
            {
                this.requestIsActive = false;
                this.generateRequest_tmr.Enabled = true;
                this.badAction_lbl.Text = "What's up?";

                this.badActionTimer_pb.Value = 0;
                this.secondsLeftTillBadAction = 10;
                this.badAction_tmr.Enabled = false;

                if(++(this.mood) <= 2)
                {
                    this.imges.BackgroundImage = this.pics.States[this.mood];
                    if(this.mood != 0)
                    {
                        this.goodAction_lbl.Text = "Heal";
                        this.goodAction_lbl.Enabled = true;
                    }
                }
                else
                {
                    this.gameOver();
                }
            }
        }
        private void whatsUpReactionShowcase_tmr_Tick(object sender, EventArgs e)
        {
            this.badAction_lbl.Enabled = true;
            this.imges.BackgroundImage = this.pics.States[this.mood];

            this.whatsUpReactionShowcase_tmr.Enabled = false;
            if(this.requestIsActive)
            {
                this.badAction_tmr.Enabled = true;
            }
            else
            {
                this.generateRequest_tmr.Enabled = true;
            }
        }
        private void activities_tmr_Tick(object sender, EventArgs e)
        {
            switch (this.currentRequest)
            {
                case "eat":

                    if(this.imges.BackgroundImage == this.pics.Eating[0])
                    {
                        this.imges.BackgroundImage = this.pics.Eating[1];
                    }
                    else if(this.imges.BackgroundImage == this.pics.Eating[1])
                    {
                        this.imges.BackgroundImage = this.pics.Eating[2];
                    }
                    else if(this.imges.BackgroundImage == this.pics.Eating[2])
                    {
                        if ((this.mood) <= 2)
                        {
                            this.imges.BackgroundImage = this.pics.States[this.mood];
                            if (this.mood != 0)
                            {
                                this.goodAction_lbl.Text = "Heal";
                                this.goodAction_lbl.Enabled = true;
                            }
                        }
                        this.activities_tmr.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("0_0");
                    }

                    break;
                case "play":

                    if (this.imges.BackgroundImage == this.pics.Playing[0])
                    {
                        this.imges.BackgroundImage = this.pics.Playing[1];
                    }
                    else if (this.imges.BackgroundImage == this.pics.Playing[1])
                    {
                        this.imges.BackgroundImage = this.pics.Playing[2];
                    }
                    else if (this.imges.BackgroundImage == this.pics.Playing[2])
                    {
                        if ((this.mood) <= 2)
                        {
                            this.imges.BackgroundImage = this.pics.States[this.mood];
                            if (this.mood != 0)
                            {
                                this.goodAction_lbl.Text = "Heal";
                                this.goodAction_lbl.Enabled = true;
                            }
                        }
                        this.activities_tmr.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("00_00");
                    }

                    break;
                case "sleep":

                    if (this.imges.BackgroundImage == this.pics.Sleep[0])
                    {
                        MessageBox.Show("yseyayseya");
                        this.imges.BackgroundImage = this.pics.Sleep[1];
                    }
                    else if (this.imges.BackgroundImage == this.pics.Sleep[1])
                    {
                        this.imges.BackgroundImage = this.pics.Sleep[2];
                    }
                    else if (this.imges.BackgroundImage == this.pics.Sleep[2])
                    {
                        if ((this.mood) <= 2)
                        {
                            this.imges.BackgroundImage = this.pics.States[this.mood];
                            if (this.mood != 0)
                            {
                                this.goodAction_lbl.Text = "Heal";
                                this.goodAction_lbl.Enabled = true;
                            }
                        }
                        this.activities_tmr.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("000_000");
                    }

                    break;
            }
        }
    }
}
