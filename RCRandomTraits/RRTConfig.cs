using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace RCRandomTraits
{
	public class RRTConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;
		public int TraitsPerPlayerCount = 2;
		public int FlawsPerPlayerCount = 1;
		public bool AllowFlaws;
		public bool AllowFeats;
		public bool AllowDeafAsAFlaw = true;
	}
}
