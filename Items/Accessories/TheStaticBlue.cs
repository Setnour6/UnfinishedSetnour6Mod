﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Accessories
{
	// Token: 0x02000017 RID: 23
	[AutoloadEquip(EquipType.Shield)]
	public class TheStaticBlue : ModItem
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000045AC File Offset: 0x000027AC
		public override void SetStaticDefaults()
		{
			// base.DisplayName.SetDefault("Blue Static");
			// base.Tooltip.SetDefault("[c/7D766E:You feel glitchy from within... ]\n[c/694A8A:You're eyes and hands are enhancing, and seem to cooperate better ]\nRanged and Throwing damage increased by 80%\nRanged and Throwing speed increased by 60%\nRanged and Throwing critical strike chance increased by 30%\nThrowing velocity increased by 50%\nGrants effects of Master Ninja Gear, Magic Quiver, and Ammo Reservation Potion\nYou have a chance to not consume thrown items and ammo");
			ItemID.Sets.ItemNoGravity[base.Item.type] = true;
			Main.RegisterItemAnimation(base.Item.type, new DrawAnimationVertical(4, 15));
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004604 File Offset: 0x00002804
		public override void SetDefaults()
		{
			base.Item.width = 24;
			base.Item.height = 28;
			base.Item.value = 1000000;
			base.Item.rare = 9;
			base.Item.expert = false;
			base.Item.accessory = true;
			base.Item.defense = 2;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000466C File Offset: 0x0000286C
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Ranged) += 0.8f;
			player.GetCritChance(DamageClass.Ranged) += 30;
			player.GetDamage(DamageClass.Throwing) += 0.15f;
			player.GetCritChance(DamageClass.Throwing) += 30;
			player.ThrownVelocity += 0.5f;
			player.blackBelt = true;
			player.spikedBoots = 2;
			player.dash = 1;
			player.magicQuiver = true;
			player.ammoPotion = true;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000046F0 File Offset: 0x000028F0
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.Mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.OverrideColor = new Color?(new Color(0, 0, 255));
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004774 File Offset: 0x00002974
		public override void AddRecipes()
		{
			Recipe modRecipe = /* base */Recipe.Create(this.Type, 1);
			modRecipe.AddIngredient(ModContent.ItemType<Drops.StaticalEssence>(), 3);
			modRecipe.AddIngredient(3467, 250);
			modRecipe.AddIngredient(2757, 1);
			modRecipe.AddIngredient(2758, 1);
			modRecipe.AddIngredient(2759, 1);
			modRecipe.AddIngredient(3530, 30);
			modRecipe.AddIngredient(3536, 1);
			modRecipe.AddIngredient(1254, 1);
			modRecipe.AddIngredient(2223, 1);
			modRecipe.AddIngredient(2590, 1);
			modRecipe.AddIngredient(984, 1);
			modRecipe.AddIngredient(3103, 1);
			modRecipe.AddIngredient(2344, 5);
			modRecipe.AddIngredient(1321, 1);
			modRecipe.AddTile(412);
			modRecipe.Register();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000022B6 File Offset: 0x000004B6
		public TheStaticBlue()
		{
		}
	}
}
