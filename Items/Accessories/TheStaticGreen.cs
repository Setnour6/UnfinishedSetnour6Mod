﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Accessories
{
	// Token: 0x02000018 RID: 24
	[AutoloadEquip(new EquipType[] { 10 })]
	public class TheStaticGreen : ModItem
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000485C File Offset: 0x00002A5C
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Green Static");
			base.Tooltip.SetDefault("[c/7D766E:You feel glitchy from within... ]\n[c/694A8A:Good health and agility is within you ]\nIncreases life regeneration by a lot\n+100 Max Life\nGrants effects of Celestial Shell, Frostspark Boots, and Lifeforce Potion\nAdditionally grants Happy! buff\nGrants immunity to fall damage\n[c/C5D962:Works better if paired with] [c/FFFFFF:'White Static' ]");
			ItemID.Sets.ItemNoGravity[base.item.type] = true;
			Main.RegisterItemAnimation(base.item.type, new DrawAnimationVertical(4, 15));
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000048B4 File Offset: 0x00002AB4
		public override void SetDefaults()
		{
			base.item.width = 24;
			base.item.height = 28;
			base.item.value = 1000000;
			base.item.rare = 7;
			base.item.expert = false;
			base.item.accessory = true;
			base.item.lifeRegen = 10;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000491C File Offset: 0x00002B1C
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lifeRegen += 10;
			player.lifeForce = true;
			player.accRunSpeed = 8f;
			player.rocketBoots = 3;
			player.moveSpeed += 0.2f;
			player.iceSkate = true;
			player.accMerman = true;
			player.wolfAcc = true;
			player.statDefense += 4;
			player.statLifeMax2 += 100;
			player.meleeSpeed += 0.1f;
			player.meleeDamage += 0.1f;
			player.meleeCrit += 2;
			player.rangedDamage += 0.1f;
			player.rangedCrit += 2;
			player.thrownDamage += 0.1f;
			player.thrownCrit += 2;
			player.thrownVelocity += 0.1f;
			player.magicDamage += 0.1f;
			player.magicCrit += 2;
			player.pickSpeed -= 0.15f;
			player.minionDamage += 0.1f;
			player.minionKB += 0.5f;
			Mod Calamity = ModLoader.GetMod("CalamityMod");
			if (Calamity != null)
			{
				Calamity.Call(new object[] { "AddRogueCrit", player, 2 });
				Calamity.Call(new object[] { "AddRogueDamage", player, 0.1f });
			}
			player.AddBuff(113, 1, true);
			player.AddBuff(146, 1, true);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004ADC File Offset: 0x00002CDC
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(0, 230, 25));
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004B60 File Offset: 0x00002D60
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(base.mod.GetItem("StaticalEssence"), 8);
			modRecipe.AddIngredient(3467, 250);
			modRecipe.AddIngredient(3530, 50);
			modRecipe.AddIngredient(1859, 10);
			modRecipe.AddIngredient(966, 100);
			modRecipe.AddIngredient(1291, 20);
			modRecipe.AddIngredient(63, 30);
			modRecipe.AddIngredient(2314, 1);
			modRecipe.AddIngredient(3544, 30);
			modRecipe.AddIngredient(3001, 3);
			modRecipe.AddIngredient(2345, 10);
			modRecipe.AddIngredient(3110, 1);
			modRecipe.AddIngredient(1862, 1);
			modRecipe.AddTile(412);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000022B6 File Offset: 0x000004B6
		public TheStaticGreen()
		{
		}
	}
}
