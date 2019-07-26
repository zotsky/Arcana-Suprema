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

namespace ArcanaSuprema.Accessories
{
    public class RingOfWarmth : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ring of Warmth"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("The stone irradiates a nice warmth, providing life regeneration. The weaker the user, the stronger the effect.");
        }

        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
            item.value = 10000;
            item.rare = 3;
            item.accessory = true;
        }
		
		public override void UpdateEquip(Player player)
		{
            player.AddBuff(mod.BuffType("Warmth"), 1); //this is an example of how to add your own buff
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