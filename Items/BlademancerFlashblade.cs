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
using ArcanaSuprema.Items;

namespace ArcanaSuprema.Items
{
	public class BlademancerFlashblade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blademancer's Flashblade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Essential spellblade learnt by blademancer's apprentices. This flashblade will easily cut through any armor.");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.crit = 65;
			item.melee = false;
			item.magic = true;
			item.width = 70;
			item.height = 72;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.knockBack = 0;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item15;
			item.autoReuse = true;
		}
		
		public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float  scale, int whoAmI)	
		{
			Texture2D texture = mod.GetTexture("Items/BlademancerFlashblade_Glowmask.png");
			spriteBatch.Draw
			(
				texture,
				new Vector2
				(
					item.position.X - Main.screenPosition.X + item.width * 0.5f,
					item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
				),
				new Rectangle(0, 0, texture.Width, texture.Height),
				Color.Cyan,
				rotation,
				texture.Size() * 0.5f,
				scale, 
				SpriteEffects.None, 
				20f
			);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddIngredient(mod.GetItem("BlademancerSpellbook"));
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}