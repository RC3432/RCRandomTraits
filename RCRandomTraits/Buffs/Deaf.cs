using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Deaf : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Deaf");
			Description.SetDefault("You are unable to hear sound.");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				Main.ambientVolume = 0;
				Main.soundVolume = 0;
				Main.musicVolume = 0;

			}

		}
		

	}
}
