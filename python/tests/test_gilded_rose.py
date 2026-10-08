# -*- coding: utf-8 -*-
import unittest

from gilded_rose import Item, GildedRose


class GildedRoseTest(unittest.TestCase):

    def test_item_sellin_quality_decreases_when_sell_has_not_passed(self):
        items = [Item("foo vest", 2, 5)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("foo vest", items[0].name)
        self.assertEqual(4, items[0].quality)
        self.assertEqual(1, items[0].sell_in)

    def test_item_quality_decreases_by_2_when_sell_has_passed(self):
        items = [Item("foo vest", 0, 5)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("foo vest", items[0].name)
        self.assertEqual(3, items[0].quality)
        self.assertEqual(-1, items[0].sell_in)

    def test_item_quality_is_not_negative_when_sell_decreases(self):
        items = [Item("foo vest", 2, 0)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("foo vest", items[0].name)
        self.assertEqual(0, items[0].quality)
        self.assertEqual(1, items[0].sell_in)

    def test_item_quality_is_never_greater_than_50_when_aged_briw(self):
        items = [Item("Aged Brie", 2, 50)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("Aged Brie", items[0].name)
        self.assertEqual(50, items[0].quality)
        self.assertEqual(1, items[0].sell_in)

    def test_item_quality_increases_when_aged_brie(self):
        items = [Item("Aged Brie", 2, 2)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("Aged Brie", items[0].name)
        self.assertEqual(3, items[0].quality)
        self.assertEqual(1, items[0].sell_in)

    def test_item_quality_increases_when_backstage_passes(self):
        items = [Item("Backstage passes to a TAFKAL80ETC concert", 15, 4)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("Backstage passes to a TAFKAL80ETC concert", items[0].name)
        self.assertEqual(5, items[0].quality)
        self.assertEqual(14, items[0].sell_in)

    def test_item_quality_increases_by_2_when_backstage_passes_sellin_is_10(self):
        items = [Item("Backstage passes to a TAFKAL80ETC concert", 10, 4)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("Backstage passes to a TAFKAL80ETC concert", items[0].name)
        self.assertEqual(6, items[0].quality)
        self.assertEqual(9, items[0].sell_in)

    def test_item_quality_increases_by_3_when_backstage_passes_sellin_is_5(self):
        items = [Item("Backstage passes to a TAFKAL80ETC concert", 5, 4)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("Backstage passes to a TAFKAL80ETC concert", items[0].name)
        self.assertEqual(7, items[0].quality)
        self.assertEqual(4, items[0].sell_in)

    def test_item_quality_decreases_to_0_when_backstage_passes_sellin_is_0(self):
        items = [Item("Backstage passes to a TAFKAL80ETC concert", 0, 14)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("Backstage passes to a TAFKAL80ETC concert", items[0].name)
        self.assertEqual(0, items[0].quality)
        self.assertEqual(-1, items[0].sell_in)

    def test_item_quality_sellin_never_decreases_when_sulfuras(self):
        items = [Item("Sulfuras, Hand of Ragnaros", 2, 14)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("Sulfuras, Hand of Ragnaros", items[0].name)
        self.assertEqual(14, items[0].quality)
        self.assertEqual(2, items[0].sell_in)
        

if __name__ == '__main__':
    unittest.main()
