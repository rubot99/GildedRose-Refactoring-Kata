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

                switch (item.Name)
                {
                    case "Aged Brie":
                        CalculateAgedBrieQuality(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        CalculateBackstagePassesQuality(item);
                        break;
                    case "Conjured Mana Cake":
                        CalculateConjuredItemsQuality(item);
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
        if (item.Quality < 50)
        {            
            if (item.SellIn < 0)
            {
                item.Quality = item.Quality + 2;
            }
            else
            {
                item.Quality = item.Quality + 1;
            }
        }
    }

    private void CalculateOtherItemsQuality(Item item)
    {
        if (item.Quality > 0)
        {                
            if(item.SellIn < 0)
            {
                item.Quality = item.Quality - 2;            
            }
            else
            {
                item.Quality = item.Quality - 1;
            }
        }
    }

    private void CalculateConjuredItemsQuality(Item item)
    {
        if (item.Quality > 0)
        {                
            if(item.SellIn < 0)
            {
                item.Quality = item.Quality - 4;            
            }
            else
            {
                item.Quality = item.Quality - 2;
            }
        }
    }
    
    private void CalculateBackstagePassesQuality(Item item)
    {
        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
        else if (item.Quality < 50)
        {
            item.Quality = item.Quality + 1;

            if (item.SellIn < 6 && item.Quality < 50)
            {
                item.Quality = item.Quality + 2;
            }
            else if (item.SellIn < 11 && item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }
}