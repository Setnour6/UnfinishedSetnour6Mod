using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Potions
{
	// Token: 0x02000012 RID: 18
	public class TinyHealingPotion : ModItem
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00003883 File Offset: 0x00001A83
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Tiny Healing Potion");
			base.Tooltip.SetDefault("Such a surprisingly small potion");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000038A8 File Offset: 0x00001AA8
		public override void SetDefaults()
		{
			base.item.UseSound = SoundID.Item3;
			base.item.useStyle = 2;
			base.item.useTurn = true;
			base.item.useAnimation = 17;
			base.item.useTime = 17;
			base.item.maxStack = 30;
			base.item.consumable = true;
			base.item.width = 20;
			base.item.height = 30;
			base.item.value = Item.sellPrice(0, 1, 1, 0);
			base.item.rare = 0;
			base.item.healLife = 10;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003957 File Offset: 0x00001B57
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(28, 1);
			modRecipe.AddTile(13);
			modRecipe.SetResult(this, 4);
			modRecipe.AddRecipe();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000022B6 File Offset: 0x000004B6
		public TinyHealingPotion()
		{
		}
	}
}
