﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QualityOfLifeRecipes.Items.Placeable.Banners.Events {
    public class UltimateSolarEclipseBanner : BannerItem<UltimateSolarEclipseBanner, Tiles.Banners.Events.UltimateSolarEclipseBanner> {
        protected override string DisplayNameTranslation =>
            "{$Mods.QualityOfLifeRecipes.Placeable.Banners.Events.UltimateSolarEclipseBanner}";

        protected override string TooltipTranslation =>
            "{$CommonItemTooltip.BannerBonus}\n" +
                "{$NPCName.Frankenstein}, {$NPCName.SwampThing}, {$NPCName.Vampire}, {$NPCName.CreatureFromTheDeep},\n" +
                "{$NPCName.Fritz}, {$NPCName.ThePossessed}, {$NPCName.Eyezor}, {$NPCName.Reaper},\n" +
                "{$NPCName.Butcher}, {$NPCName.DeadlySphere}, {$NPCName.DrManFly}, {$NPCName.Nailhead},\n" +
                "{$NPCName.Psycho}, {$NPCName.Mothron}";

        protected override int SellPrice => Item.sellPrice(0, 0, 35, 0);

        protected override int Rarity => ItemRarityID.Green;

        protected override int[] Ingredients => new int[] {
            ModContent.ItemType<SupremeSolarEclipseBanner>(),
            ItemID.MothronBanner
        };
    }
}
