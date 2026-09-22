using GildedRoseKata;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using VerifyXunit;

using Xunit;

namespace GildedRoseTests;

public class ApprovalTest
{
    [Fact]
    public Task Verify_Quantity_Updates_For_Aged_Brie()
    {
        IList<Item> items = new List<Item>
        {
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 10},
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
            new Item {Name = "Aged Brie", SellIn = -1, Quality = 2},
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 50},
            new Item {Name = "Aged Brie", SellIn = 5, Quality = -4},
            new Item {Name = "Aged Brie", SellIn = -5, Quality = -4},
        };
        
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();

        return Verifier.Verify(items);
    }
    
    [Fact]
    public Task Verify_Quantity_Updates_For_Backstage_Passes()
    {
        IList<Item> items = new List<Item>
        {
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = -4,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 2,
                Quality = -49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = -4,
                Quality = -49
            },
        };
        
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();

        return Verifier.Verify(items);
    }
    
    [Fact]
    public Task Verify_Quantity_Updates_For_All_Items()
    {
        IList<Item> items = new List<Item>
        {
            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 2},
            new Item {Name = "Aged Brie", SellIn = -1, Quality = 2},
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 80},
            new Item {Name = "Aged Brie", SellIn = 5, Quality = -4},
            new Item {Name = "Aged Brie", SellIn = -5, Quality = -4},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = -1},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 52},
            new Item {Name = "Elixir of the Mongoose", SellIn = -1, Quality = 5},
            new Item {Name = "Elixir of the Mongoose", SellIn = -1, Quality = -5},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 3, Quality = 8},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 82},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = -82},
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = -4,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 2,
                Quality = -49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = -4,
                Quality = -49
            },
            
            // this conjured item does not work properly yet
            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
        };
        
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();

        return Verifier.Verify(items);
    }
    
    [Fact]
    public Task Verify_Quantity_Updates_For_Other_Items()
    {
        IList<Item> items = new List<Item>
        {
            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = -1},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 52},
            new Item {Name = "Elixir of the Mongoose", SellIn = -1, Quality = 5},
            new Item {Name = "Elixir of the Mongoose", SellIn = -1, Quality = -5},
        };
        
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();

        return Verifier.Verify(items);
    }
    
    [Fact]
    public Task Verify_Quantity_Updates_For_Sulfuras()
    {
        IList<Item> items = new List<Item>
        {
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 3, Quality = 8},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 82},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = -82},
        };
        
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();

        return Verifier.Verify(items);
    }

    [Fact]
    public Task Verify_Quantity_Updates_For_Conjured_Items()
    {
        IList<Item> items = new List<Item>
        {
            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},
            new Item {Name = "Conjured Mana Cake", SellIn = 0, Quality = 6},
            new Item {Name = "Conjured Mana Cake", SellIn = 4, Quality = 50},
            new Item {Name = "Conjured Mana Cake", SellIn = -1, Quality = -1},            
            new Item {Name = "Conjured Mana Cake", SellIn = -1, Quality = 31},
            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = -1},
        };
        
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();

        return Verifier.Verify(items);
    }
}