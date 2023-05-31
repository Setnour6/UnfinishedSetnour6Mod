using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Accessories
{
	// Token: 0x0200001B RID: 27
	[AutoloadEquip(EquipType.Shield)]
	public class TheStaticRed : ModItem
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00005154 File Offset: 0x00003354
		public override void SetStaticDefaults()
		{
			// base.DisplayName.SetDefault("Red Static");
			// base.Tooltip.SetDefault("[c/7D766E:You feel glitchy from within... ]\n[c/694A8A:You're muscles are getting stronger. ]\nMelee damage increased by 80%\nMelee speed increased by 60%\nMelee critical strike chance increased by 30%\nWeapons are imbued with Venom, Cursed Flames, Fire, Gold, Ichor, Nanites, and Poison... hopefully\n[c/334A59:--Would be great if you have Lan's Unlimited Buff Slots Mod enabled-- ]");
			ItemID.Sets.ItemNoGravity[base.Item.type] = true;
			Main.RegisterItemAnimation(base.Item.type, new DrawAnimationVertical(4, 15));
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000051AC File Offset: 0x000033AC
		public override void SetDefaults()
		{
			base.Item.width = 24;
			base.Item.height = 28;
			base.Item.value = 1000000;
			base.Item.rare = 10;
			base.Item.expert = false;
			base.Item.accessory = true;
			base.Item.defense = 6;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005214 File Offset: 0x00003414
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Melee) += 0.8f;
			if (player.HeldItem.channel)
			{
				player.GetAttackSpeed(DamageClass.Melee) += 1.6f;
			}
			else
			{
				player.GetAttackSpeed(DamageClass.Melee) += 0.6f;
			}
			player.GetCritChance(DamageClass.Generic) += 30;
			player.AddBuff(71, 1, true);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005280 File Offset: 0x00003480
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.Mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.OverrideColor = new Color?(new Color(255, 0, 0));
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005304 File Offset: 0x00003504
		public override void AddRecipes()
		{
			Recipe modRecipe = /* base */Recipe.Create(this.Type, 1);
			modRecipe.AddIngredient(ModContent.ItemType<Drops.StaticalEssence>(), 3);
			modRecipe.AddIngredient(3467, 250);
			modRecipe.AddIngredient(2763, 1);
			modRecipe.AddIngredient(2764, 1);
			modRecipe.AddIngredient(2765, 1);
			modRecipe.AddIngredient(3530, 30);
			modRecipe.AddIngredient(3539, 1);
			modRecipe.AddIngredient(757, 1);
			modRecipe.AddIngredient(1340, 1);
			modRecipe.AddTile(412);
			modRecipe.Register();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000022B6 File Offset: 0x000004B6
		public TheStaticRed()
		{
		}
	}
}
