# -*- coding: utf-8 -*-
import unittest

from gilded_rose import Item, GildedRose


class GildedRoseTest(unittest.TestCase):

    def test_update_quality_decreases_quality_by_one_when_sell_in_is_not_zero(self):
        items = [Item("foo", 2, 5)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("foo", items[0].name)
        self.assertEqual(4, items[0].quality)
        self.assertEqual(1, items[0].sell_in)

    
    def test_update_quality_decreases_quality_by_two_when_sell_in_is_zero(self):
        items = [Item("foo", 0, 5)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("foo", items[0].name)
        self.assertEqual(3, items[0].quality)
        self.assertEqual(-1, items[0].sell_in) 

    def test_update_quality_decreases_quality_by_two_when_sell_in_is_negative_one(self):
        items = [Item("foo", -1, 5)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("foo", items[0].name)
        self.assertEqual(3, items[0].quality)
        self.assertEqual(-2, items[0].sell_in) 

    def test_update_quality_does_not_go_negative_when_quality_is_zero(self):
        items = [Item("foo", 2, 0)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("foo", items[0].name)
        self.assertEqual(0, items[0].quality)
        self.assertEqual(1, items[0].sell_in) 

    #def test_update_quality_increases_quality_by_one_when_aged_brie_and_sell_in_is_less_than_zero(self):
    #    items = [Item("Aged Brie", -1, 5)]
    #    gilded_rose = GildedRose(items)
    #    gilded_rose.update_quality()
    #    self.assertEqual("Aged Brie", items[0].name)
    #    self.assertEqual(7, items[0].sell_in)
    #    self.assertEqual(-2, items[0].quality)
        
if __name__ == '__main__':
    unittest.main()