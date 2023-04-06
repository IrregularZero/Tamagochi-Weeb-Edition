using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_15.Classes
{
    class Frames
    {
        private System.Drawing.Bitmap[] eating;
        private System.Drawing.Bitmap[] heal;
        private System.Drawing.Bitmap[] playing;
        private System.Drawing.Bitmap[] reactions_on_rejections;
        private System.Drawing.Bitmap[] sleep;
        private System.Drawing.Bitmap[] starting_animation;
        private System.Drawing.Bitmap[] states;
        private System.Drawing.Bitmap[] whats_up_reactions;

        public Frames()
        {
            this.eating = new System.Drawing.Bitmap[3]
            {
                menhera_chan.Eating.requestToEat,
                menhera_chan.Eating.eating,
                menhera_chan.Eating.finishedEating
            };

            this.heal = new System.Drawing.Bitmap[1]
            {
                menhera_chan.Heal1.Heal
            };

            this.playing = new System.Drawing.Bitmap[3]
            {
                menhera_chan.Playing.requestToPlay,
                menhera_chan.Playing.playing1,
                menhera_chan.Playing.playing2,
            };

            this.reactions_on_rejections = new System.Drawing.Bitmap[6]
            {
                menhera_chan.Reactions_on_rejections.reactionOnRejectionInGoodMood,
                menhera_chan.Reactions_on_rejections.reactionOnRejection_mediumMood,
                menhera_chan.Reactions_on_rejections.reactionOnRejection_badMood0,
                menhera_chan.Reactions_on_rejections.reactionOnRejection_badMood1,
                menhera_chan.Reactions_on_rejections.reactionOnRejection_badMood2,
                menhera_chan.Reactions_on_rejections.reactionOnRejection_badMood3,
            };

            this.sleep = new System.Drawing.Bitmap[3]
            {
                menhera_chan.Sleep.sleep,
                menhera_chan.Sleep.sleeping,
                menhera_chan.Sleep.wakingUp,
            };

            this.starting_animation = new System.Drawing.Bitmap[4]
            {
                menhera_chan.Starting_animation.gettingInGame_Frame1,
                menhera_chan.Starting_animation.gettingInGame_Frame2,
                menhera_chan.Starting_animation.gettingInGame_Frame3,
                menhera_chan.Starting_animation.gettingInGame_Frame4,
            };

            this.states = new System.Drawing.Bitmap[3]
            {
                menhera_chan.States.goodMoodState,
                menhera_chan.States.mediumMoodState,
                menhera_chan.States.badMoodState,
            };

            this.whats_up_reactions = new System.Drawing.Bitmap[3]
            {
                menhera_chan.Whats_up_reactions.reactionOnWhatsUp_goodMood,
                menhera_chan.Whats_up_reactions.reactionOnWhatsUp_mediumMood,
                menhera_chan.Whats_up_reactions.reactionOnWhatsUp_badMood,
            };
        }

        //Every prop here has only get
        public System.Drawing.Bitmap[] Eating 
        {
            get
            {
                return this.eating;
            }
        }
        public System.Drawing.Bitmap[] HeaL
        {
            get
            {
                return this.heal;
            }
        }
        public System.Drawing.Bitmap[] Playing
        {
            get
            {
                return this.playing;
            }
        }
        public System.Drawing.Bitmap[] Reactions_on_rejections
        {
            get
            {
                return this.reactions_on_rejections;
            }
        }
        public System.Drawing.Bitmap[] Sleep
        {
            get
            {
                return this.sleep;
            }
        }
        public System.Drawing.Bitmap[] Starting_animation
        {
            get
            {
                return this.starting_animation;
            }
        }
        public System.Drawing.Bitmap[] States
        {
            get
            {
                return this.states;
            }
        }
        public System.Drawing.Bitmap[] Whats_up_reactions
        {
            get
            {
                return this.whats_up_reactions;
            }
        }
    }
}
