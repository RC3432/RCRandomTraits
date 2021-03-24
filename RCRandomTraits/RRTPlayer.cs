using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace RCRandomTraits
{
	public class RRTPlayer: ModPlayer
	{

        int checks = 0;
        int trait;
        int flaw;
        public bool deaf = false;
        public bool acrobatic = false;
        public bool Aggressive = false;
        public bool pers = false;
        public bool fisher = false;
        public bool athletic = false;
        public bool blindeye = false;
        public bool feeble = false;
        public bool perceptive = false;
        public bool intel = false;
        public bool hardy = false;
        public bool stealthy = false;
        public bool clumsy = false;
        //Writen by RC3432 3/20/2021
        public override void PostUpdate()
        {
            if (ModContent.GetInstance<RRTConfig>().AllowFeats == true)
            {
 if (hardy == true)
            {
                player.AddBuff(mod.BuffType("Hardy"), 180);
            }
            if (Aggressive == true && player.calmed == false)
            {
                player.AddBuff(mod.BuffType("Aggressive"), 180);
            }
            if (athletic == true)
            {
                player.AddBuff(mod.BuffType("Athletic"), 180);
            }
            if (fisher == true)
            {
                player.AddBuff(mod.BuffType("ExpertFisher"), 180);
            }
            if (pers == true)
            {
                player.AddBuff(mod.BuffType("Persuasive"), 180);
            }
            if (intel == true)
            {
                player.AddBuff(mod.BuffType("Intellegent"), 180);
            }
               if (acrobatic == true)
            {
                player.AddBuff(mod.BuffType("Acrobatic"), 180);
            }
                if (perceptive == true)
                {
                    player.AddBuff(mod.BuffType("Perceptive"), 180);
                }
            }
           if (ModContent.GetInstance<RRTConfig>().AllowFlaws == true)
            {
 if (feeble == true)
            {
                player.AddBuff(mod.BuffType("Feeble"), 180);
            }

            if (stealthy == true)
            {
                player.AddBuff(mod.BuffType("Stealthy"), 180);
            }
            if (clumsy == true)
            {
                player.AddBuff(mod.BuffType("Clumsy"), 180);
            }
         
            if (blindeye == true)
            {
                player.AddBuff(mod.BuffType("DamagedEyesight"), 180);
            }
            if (deaf == true)
            {
                player.AddBuff(mod.BuffType("Deaf"), 180);
            }
            }
           
        }
        [Obsolete]
        public override void SetupStartInventory(IList<Item> items)
        {
            hardy = false;
            acrobatic = false;
            athletic = false;
            intel = false;
            stealthy = false;
            perceptive = false;
            fisher = false;
            //mod.GetConfig<RRTConfig>().TraitsPerPlayerCount Later? TODO
            int checks = mod.GetConfig<RRTConfig>().TraitsPerPlayerCount;
            for (int i = 0; i < checks; i++)
            {
                trait = Main.rand.Next(0, 8);
                if (trait == 1 && acrobatic == false)
                {
                    acrobatic = true;
                }
                if (trait == 1 && acrobatic == true)
                {
                    trait = Main.rand.Next(0, 8);
                }
                if (trait == 0 && athletic == false)
                {
                    athletic = true;
                }
                if (trait == 0 && athletic == true)
                {
                    trait = Main.rand.Next(0, 8);
                }
                if (trait == 2 && stealthy == false)
                {
                    stealthy = true;
                }
                if (trait == 2 && stealthy == true)
                {
                    trait = Main.rand.Next(0, 8);
                }
                if (trait == 3 && perceptive == false)
                {
                    perceptive = true;
                }
                if (trait == 3 && perceptive == true)
                {
                    trait = Main.rand.Next(0, 8);
                }
                if (trait == 4 && intel == false)
                {
                    intel = true;
                }
                if (trait == 4 && intel == true)
                {
                    trait = Main.rand.Next(0, 8);
                }
                if (trait == 5 && pers == false)
                {
                    pers = true;
                }
                if (trait == 5 && pers == true)
                {
                    trait = Main.rand.Next(0, 8);
                }
                if (trait == 6 && fisher == false)
                {
                    fisher = true;
                }
                if (trait == 6 && fisher == true)
                {
                    trait = Main.rand.Next(0, 8);
                }
                if (trait == 7 && hardy == false)
                {
                    hardy = true;
                }
                if (trait == 7 && hardy == true)
                {
                    trait = Main.rand.Next(0, 8);
                }
            }
            int checks2 = mod.GetConfig<RRTConfig>().FlawsPerPlayerCount;
            feeble = false;
            clumsy = false;
            Aggressive = false;
            blindeye = false;
            deaf = false;
            for (int i = 0; i < checks2; i++)
            {
                flaw = Main.rand.Next(0, 5);
                if (flaw == 1 && clumsy == false && acrobatic == false)
                {
                    clumsy = true;
                }
                if (flaw == 1 && clumsy == true || acrobatic == true)
                {
                    flaw = Main.rand.Next(0, 5);
                }
                if (flaw == 0 && feeble == false && athletic == false)
                {
                    feeble = true;
                }
                if (flaw == 0 && feeble == true || athletic == true)
                {
                    flaw = Main.rand.Next(0, 5);
                }
                if (flaw == 2 && blindeye == false && perceptive == false)
                {
                    blindeye = true;
                }
                if (flaw == 2 && blindeye == true || perceptive == true)
                {
                    flaw = Main.rand.Next(0, 5);
               
                }
                if (flaw == 3 && deaf == false && mod.GetConfig<RRTConfig>().AllowDeafAsAFlaw == true)
                {
                    deaf = true;
                }
                if (flaw == 3 && deaf == true || mod.GetConfig<RRTConfig>().AllowDeafAsAFlaw == false)
                {
                    flaw = Main.rand.Next(0, 5);
                }
                if (flaw == 4 && Aggressive == false && hardy == false)
                {
                    Aggressive = true;
                }
                if (flaw == 4 && Aggressive == true || hardy == true)
                {
                    flaw = Main.rand.Next(0, 5);

                }
            }


        }

    

        public override TagCompound Save()
        {
            return new TagCompound {
				{"athletic", athletic},
                    {"hardy", hardy},
                                {"deaf", deaf},
                                          {"Agg", Aggressive},
                {"pers", pers},
                {"acrobatic", acrobatic},
                {"stealthy", stealthy},
                {"feeble", feeble},
                {"clumsy", clumsy},
                                {"fisher", fisher},
                {"perceptive", perceptive},
                {"smart", intel},
                                {"blindeye", blindeye},
            };
        }

        public override void Load(TagCompound tag)
        {
            athletic = tag.GetBool("athletic");
            deaf = tag.GetBool("deaf");
            acrobatic = tag.GetBool("acrobatic");
            stealthy = tag.GetBool("stealthy");
            feeble = tag.GetBool("feeble");
            perceptive = tag.GetBool("perceptive");
            clumsy = tag.GetBool("clumsy");
            hardy = tag.GetBool("hardy");
            intel = tag.GetBool("smart");
            pers = tag.GetBool("pers");
            fisher = tag.GetBool("fisher");
            blindeye = tag.GetBool("blindeye");
            Aggressive = tag.GetBool("Agg");
        }





    }
}
