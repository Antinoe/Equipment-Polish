using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.Audio;
using Terraria.ID;
using EquipmentPolish.Items;

namespace EquipmentPolish
{
	public class EquipmentPolishGlobalItem : GlobalItem
	{
		//Start: Custom Booleans.
		public bool IsAccessory(Item Item)
		{
			return (Item.accessory = true);
		}
		public bool IsArmor(Item Item)
		{
			return (Item.headSlot != -1 || Item.bodySlot != -1 || Item.legSlot != -1);
		}
		public bool IsTool(Item Item)
		{
			return (Item.pick > 0 || Item.axe > 0 || Item.hammer > 0);
		}
		public bool IsWeapon(Item Item)
		{
			return (Item.damage > 0);
		}
		public bool IsEquipment(Item Item)
		{
			return (IsAccessory(Item) || IsArmor(Item) || IsTool(Item) || IsWeapon(Item));
		}
		//End: Custom Booleans.

		public override bool CanRightClick(Item Item)
		{
			return Main.mouseItem.type == ModContent.ItemType<EquipmentPolishKit>();
		}

		public override void RightClick(Item Item, Player Player)
		{
			if (Main.mouseItem.type == ModContent.ItemType<EquipmentPolishKit>())
			{
				//if (Item.maxStack == 1)
				if (Item.maxStack == 1 && Item.damage > 0 || Item.maxStack == 1 && Item.accessory == true)
				{
					SoundEngine.PlaySound(SoundID.Item37);
					Item.SetDefaults(Item.type); //Either SetDefaults or CloneDefaults are fine. They prevent the chosen item from having its Prefix stacked.
					//Item.CloneDefaults(Item.type);
					//Item.Prefix(0);
					Item.Prefix(-2); //-1 is random Prefix. -2 is Reforging.
					Item.stack++;
					Main.mouseItem.stack--;
				}
				else
				{
					Item.stack++;
					//SoundEngine.PlaySound(SoundID.Item34);
				}
			}
		}
	}
}
