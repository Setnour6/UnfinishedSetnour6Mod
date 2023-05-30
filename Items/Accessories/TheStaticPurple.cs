using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Accessories
{
	// Token: 0x0200001A RID: 26
	[AutoloadEquip(new EquipType[] { 10 })]
	public class TheStaticPurple : ModItem
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00004EAC File Offset: 0x000030AC
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Purple Static");
			base.Tooltip.SetDefault("[c/7D766E:You feel glitchy from within... ]\n[c/694A8A:You're mind seems to be full of arcane wonders. ]\nMagic damage increased by 50%\nMagic critical strike chance increased by 20%\n+120 maximum mana\n-50% mana cost\nIncreases mana regeneration rate by a lot\nGrants immunity to Mana Sickness\nGrants effects of all Nebula Boosters... hopefully\nGrants effects of Mana Flower and Celestial Magnet\n[c/334A59:--Would be great if you have Lan's Unlimited Buff Slots Mod enabled-- ]");
			ItemID.Sets.ItemNoGravity[base.item.type] = true;
			Main.RegisterItemAnimation(base.item.type, new DrawAnimationVertical(4, 15));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004F04 File Offset: 0x00003104
		public override void SetDefaults()
		{
			base.item.width = 24;
			base.item.height = 28;
			base.item.value = 1000000;
			base.item.rare = 11;
			base.item.expert = false;
			base.item.accessory = true;
			base.item.defense = 3;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004F6C File Offset: 0x0000316C
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.magicDamage += 0.5f;
			player.magicCrit += 20;
			player.manaRegen = 4;
			player.manaFlower = true;
			player.manaMagnet = true;
			player.statManaMax2 += 120;
			player.manaCost -= 0.5f;
			player.manaRegenDelayBonus++;
			player.manaRegenBonus += 75;
			player.buffImmune[94] = true;
			player.AddBuff(175, 1, true);
			player.AddBuff(178, 1, true);
			player.AddBuff(181, 1, true);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005020 File Offset: 0x00003220
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(180, 0, 255));
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000050A8 File Offset: 0x000032A8
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(base.mod.GetItem("StaticalEssence"), 3);
			modRecipe.AddIngredient(3467, 250);
			modRecipe.AddIngredient(2760, 1);
			modRecipe.AddIngredient(2761, 1);
			modRecipe.AddIngredient(2762, 1);
			modRecipe.AddIngredient(3530, 30);
			modRecipe.AddIngredient(3537, 1);
			modRecipe.AddIngredient(555, 1);
			modRecipe.AddIngredient(2219, 1);
			modRecipe.AddTile(412);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000022B6 File Offset: 0x000004B6
		public TheStaticPurple()
		{
		}
	}
}
