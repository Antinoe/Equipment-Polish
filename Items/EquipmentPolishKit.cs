using System;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace EquipmentPolish.Items
{
	public class EquipmentPolishKit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Equipment Polishing Kit");
			Tooltip.SetDefault("Right Click equipment with this item in hand to Reforge it.");
		}

		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 32;
			Item.maxStack = 99;
			Item.rare = 1;
			Item.value = 5000;
		}

		public override void AddRecipes()
        {
			CreateRecipe(1)
            .AddIngredient(ItemID.SilverCoin, 5)
			.AddRecipeGroup(RecipeGroupID.Wood, 2)
            //.AddTile(TileID.WorkBenches)
            .Register();
			
			CreateRecipe(20)
            .AddIngredient(ItemID.GoldCoin, 1)
			.AddRecipeGroup(RecipeGroupID.Wood, 2)
            //.AddTile(TileID.WorkBenches)
            .Register();
			
			CreateRecipe(99)
            .AddIngredient(ItemID.ArmorPolish, 1)
            .AddTile(TileID.WorkBenches)
            .Register();
			
        }
	}
}