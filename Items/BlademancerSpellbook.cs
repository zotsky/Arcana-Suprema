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
	public class BlademancerSpellbook : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Unpowered Blademancer's Spellbook"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("An alchemical stone must be inserted into the slot in order to give the spellbook a functionality");
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
			item.melee = false;
			item.width = 0;
			item.height = 0;
			item.useStyle = 5;
			item.useTime = 10;
			item.useAnimation = 10;
			item.knockBack = 0;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item24;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}