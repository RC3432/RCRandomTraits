using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Persuasive : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Persuasive");
			Description.SetDefault("You are unusually easy to agree with.\nReduced prices by 20% from friendly NPCs.");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.discount = true;
			}

		}
		

	}
}
