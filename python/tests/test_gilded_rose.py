from gilded_rose import GildedRose, Item


def test_normal_item_loses_one_quality_and_one_sell_in_per_day():
    items = [Item("foo", 2, 2)]
    GildedRose(items).update_quality()
    assert items[0].name == "foo"
    assert items[0].quality == 1
    assert items[0].sell_in == 1
