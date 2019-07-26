using Terraria.ModLoader;
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
using Terraria.Localization;
using ArcanaSuprema;

namespace ArcanaSuprema
{
	public class ArcanaSuprema : Mod
	{
		public ArcanaSuprema()
		{
		}
		
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Iron Ore or Lead Ore", new int[]
			{
				ItemID.IronOre,
				ItemID.LeadOre,
			});
			RecipeGroup.RegisterGroup("ArcanaSuprema:IronOres", group);
			
			RecipeGroup group1 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver Ore or Tungsten Ore", new int[]
			{
				ItemID.SilverOre,
				ItemID.TungstenOre,
			});
			RecipeGroup.RegisterGroup("ArcanaSuprema:SilverOres", group1);
			
			RecipeGroup group2 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold Ore or Platinum Ore", new int[]
			{
				ItemID.GoldOre,
				ItemID.PlatinumOre,
			});
			RecipeGroup.RegisterGroup("ArcanaSuprema:GoldOres", group2);

		}
	}
}