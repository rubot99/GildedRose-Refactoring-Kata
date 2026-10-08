import io
import sys

from approvaltests import verify
from gilded_rose import *

def test_regular_items_approvals():
    items = [
        Item(name="foo vest", sell_in=5, quality=5),
        Item(name="foo vest", sell_in=1, quality=5),
        Item(name="foo vest", sell_in=0, quality=5)
    ]

    GildedRose(items).update_quality()

    verify(items)

def test_aged_brie_approvals():
    items = [
        Item(name="Aged Brie", sell_in=5, quality=5),        
        Item(name="Aged Brie", sell_in=5, quality=50),
        Item(name="Aged Brie", sell_in=0, quality=5)
    ]

    GildedRose(items).update_quality()

    verify(items)

def test_sulfuras_approvals():
    items = [
        Item(name="Sulfuras, Hand of Ragnaro", sell_in=5, quality=80),        
        Item(name="Sulfuras, Hand of Ragnaro", sell_in=5, quality=50),
        Item(name="Sulfuras, Hand of Ragnaro", sell_in=0, quality=5)
    ]

    GildedRose(items).update_quality()

    verify(items)

def test_backstage_pass_approvals():
    items = [
        Item(name="Backstage passes to a TAFKAL80ETC concert", sell_in=15, quality=20),        
        Item(name="Backstage passes to a TAFKAL80ETC concert", sell_in=10, quality=20),        
        Item(name="Backstage passes to a TAFKAL80ETC concert", sell_in=5, quality=20),
        Item(name="Backstage passes to a TAFKAL80ETC concert", sell_in=0, quality=20)
    ]

    GildedRose(items).update_quality()

    verify(items)
   
if __name__ == "__main__":
    test_regular_items_approvals()
    test_aged_brie_approvals()
    test_sulfuras_approvals()
    test_backstage_pass_approvals()

