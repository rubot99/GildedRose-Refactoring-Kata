# -*- coding: utf-8 -*-
import unittest

from gilded_rose import Item, GildedRose


class GildedRoseTest(unittest.TestCase):
    def test_update_quality_expect_reduce_quality_sellin_by_one_when_quality_sellin_are_positive (self):
        items = [Item("foo", 2, 2)]
        gilded_rose = GildedRose(items)
        gilded_rose.update_quality()
        self.assertEqual("foo", items[0].name)
        self.assertEqual(1, items[0].quality)
        self.assertEqual(1, items[0].sell_in)


        
if __name__ == '__main__':
    unittest.main()
