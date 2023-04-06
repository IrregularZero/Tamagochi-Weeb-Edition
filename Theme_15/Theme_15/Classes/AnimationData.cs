using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_15.Classes
{
    class AnimationData
    {
        private string animation;
        private int index;
        private int length; //Number of frames

        public AnimationData(string animation)
        {
            if(animation == "start")
            {
                this.animation = animation;
                this.index = 1;
                this.length = 5; //last frame + 1(cuz here I don't use array like count system)
            }
            else if(animation == "ending")
            {
                this.animation = animation;
                this.index = 0;
                this.length = 4; //here simply was used array like counting system
            }
            else
            {
                throw new Exception("there are only two kinds of anims! (start/ending)");
            }
        }

        public string Animation 
        {
            get
            {
                return this.animation;
            }
            set
            {
                if (value == "start" || value == "ending")
                {
                    this.animation = value;
                }
                else
                {
                    throw new Exception("there are only two kinds of anims! (start/ending)");
                }
            }
        }
        public int Index 
        {
            get
            {
                return this.index;
            }
            set
            {
                //if(value < this.length)
                //{
                    if (this.animation == "start")
                    {
                        if (value > 0)
                        {
                            this.index = value;
                        }
                        else
                        {
                            this.index = 1;
                        }
                    }
                    else if (this.animation == "ending")
                    {
                        if(value >= 0)
                        {
                            this.index = value;
                        }
                        else
                        {
                            this.index = 0;
                        }
                    }
                //}
            }
        }
        public int Length 
        {
            get
            {
                return this.length;
            }
        }
    }
}
