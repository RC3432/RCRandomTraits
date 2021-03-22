using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Perceptive : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Perceptive");
			Description.SetDefault("You are unusually insightful.\n+5% ranged damage\nIncreased vision in darkness.\nImmunity to darkness and blackout\nAllows you to see further similar to binoculars.");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.scope = true;
				player.rangedDamage *= 1.05f;
				player.nightVision = true;
				player.buffImmune[BuffID.Darkness] = true;
				player.buffImmune[BuffID.Blackout] = true;

			}

		}
		

	}
}
