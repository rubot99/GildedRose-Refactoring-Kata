using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void UpdateQuality_QualityShouldDecreaseByOne_WhenSellInIsNotZero()
    {
        IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("foo", items[0].Name);
        Assert.Equal(4, items[0].Quality);
        Assert.Equal(1, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldDecreaseByTwo_WhenSellInIsZero()
    {
        IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("foo", items[0].Name);
        Assert.Equal(3, items[0].Quality);
        Assert.Equal(-1, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldDecreaseByTwo_WhenSellInIsNegativeOne()
    {
        IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = -1, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("foo", items[0].Name);
        Assert.Equal(3, items[0].Quality);
        Assert.Equal(-2, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldNotBeNegative_WhenQualityIsZero()
    {
        IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = 0 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("foo", items[0].Name);
        Assert.Equal(0, items[0].Quality);
        Assert.Equal(1, items[0].SellIn);
    }
    
    [Fact]
    public void UpdateQuality_QualityShouldIncreaseByOne_WhenItemIsAgedBrieAndSellInIsLessThanZero()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -1, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Aged Brie", items[0].Name);
        Assert.Equal(7, items[0].Quality);
        Assert.Equal(-2, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldIncreaseByOne_WhenItemIsAgedBrie()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Aged Brie", items[0].Name);
        Assert.Equal(6, items[0].Quality);
        Assert.Equal(1, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldNotIncreaseAfterFifty_WhenItemIsAgedBrie()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Aged Brie", items[0].Name);
        Assert.Equal(50, items[0].Quality);
        Assert.Equal(1, items[0].SellIn);
    }
    
    
    [Fact]
    public void UpdateQuality_QualityShouldIncreaseByOne_WhenItemIsBackstagePassesAndSellInIsGreaterThanTen()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
        Assert.Equal(6, items[0].Quality);
        Assert.Equal(11, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldIncreaseByTwo_WhenItemIsBackstagePassesAndSellInIsLessThanTen()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
        Assert.Equal(7, items[0].Quality);
        Assert.Equal(8, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldIncreaseByThree_WhenItemIsBackstagePassesAndSellInIsLessThanFive()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
        Assert.Equal(8, items[0].Quality);
        Assert.Equal(3, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldIncreaseByThree_WhenItemIsBackstagePassesAndSellInIsZero()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
        Assert.Equal(8, items[0].Quality);
        Assert.Equal(0, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldReducetoZero_WhenItemIsBackstagePassesAndSellInIsNegativeValue()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
        Assert.Equal(0, items[0].Quality);
        Assert.Equal(-1, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldAlwaysBeEighty_WhenItemIsSulfuras()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Sulfuras, Hand of Ragnaros", items[0].Name);
        Assert.Equal(80, items[0].Quality);
        Assert.Equal(10, items[0].SellIn);
    }
    
    [Fact]
    public void UpdateQuality_QualityShouldReduceByTwo_WhenItemIsConjured()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Conjured Mana Cake", items[0].Name);
        Assert.Equal(4, items[0].Quality);
        Assert.Equal(2, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldReduceByFour_WhenItemIsConjuredANDSellInIsZero()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Conjured Mana Cake", items[0].Name);
        Assert.Equal(2, items[0].Quality);
        Assert.Equal(-1, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldNotGoNegative_WhenItemIsConjuredAndExpiredWithLowQuality()
    {
        IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = -1, Quality = 1 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("Conjured Mana Cake", items[0].Name);
        Assert.Equal(0, items[0].Quality);
        Assert.Equal(-2, items[0].SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldNotGoNegative_WhenItemIsOtherAndExpiredWithLowQuality()
    {
        IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = -1, Quality = 1 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("foo", items[0].Name);
        Assert.Equal(0, items[0].Quality);
        Assert.Equal(-2, items[0].SellIn);
    }
}