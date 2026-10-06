from approvaltests import verify_all_combinations

from gilded_rose import GildedRose, Item

NAMES = [
    "+5 Dexterity Vest",
    "Aged Brie",
    "Backstage passes to a TAFKAL80ETC concert",
    "Sulfuras, Hand of Ragnaros",
    "Conjured Mana Cake",
]
SELL_INS = [-1, 0, 1, 5, 6, 10, 11]
QUALITIES = [0, 1, 48, 49, 50, 80]


def update_item(name, sell_in, quality):
    item = Item(name, sell_in, quality)
    GildedRose([item]).update_quality()
    return item


def test_update_quality_all_combinations():
    verify_all_combinations(update_item, [NAMES, SELL_INS, QUALITIES])
