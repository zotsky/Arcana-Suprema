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

namespace ArcanaSuprema.Items
{
	public class MoonledAtom : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Moonled Atom"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Frost and Night Quintascential.");
		}

		public override void SetDefaults() 
		{
			item.maxStack = 90;
			item.rare = (-11);
			item.melee = false;
			item.width = 0;
			item.height = 0;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("ArcanaSuprema:SilverOres", 1);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
	}
}