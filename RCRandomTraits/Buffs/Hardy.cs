using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Hardy : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Hardy");
			Description.SetDefault("You are a expert of survival.\n+4 Defense\nIncreased Life Regeneration");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.statDefense += 4;
				player.lifeRegen += 5;
				
				
			}

		}
		

	}
}
