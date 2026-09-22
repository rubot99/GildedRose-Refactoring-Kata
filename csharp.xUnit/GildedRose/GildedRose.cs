using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (Item item in Items)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;

                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    //if (item.Quality > 0)
                    //{
                    //    item.Quality = item.Quality - 1;
                    //}
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality = item.Quality + 1;
                                }
                            }
                        }
                    }
                }
                
                switch (item.Name)
                {
                    case "Aged Brie":
                        CalculateAgedBrieQuality(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        CalculateBackstagePassesQuality(item);
                        break;

                    default:
                        CalculateOtherItemsQuality(item);
                        break;
                }
            }
                
        }
    }

    private void CalculateAgedBrieQuality(Item item)
    {
        if (item.SellIn < 0)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }

    private void CalculateOtherItemsQuality(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality = item.Quality - 1;
        }

        if (item.SellIn < 0)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }
    }
    
    private void CalculateBackstagePassesQuality(Item item)
    {
        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }
}