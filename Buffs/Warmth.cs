using System;
using System.IO;
using System.Linq;
using System.Collections.ObjectModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using ArcanaSuprema;

namespace ArcanaSuprema.Buffs
{
    public class Warmth : ModBuff
    {		
        public override void SetDefaults() 
		{
			DisplayName.SetDefault("Warmth");
		}
		
		public override void Update(Player player, ref int buffIndex)
        {
			player.lifeRegen = (player.statLifeMax2 - player.statLife)/25;
        }
    }
}