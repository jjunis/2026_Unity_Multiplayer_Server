using UnityEngine;

[System.Serializable]
public class AuctionData
{
    public string AuctionKey;
    public string SellerKey;
    public string SellNickName;
    public string Itemname;
    public int Count;
    public int price;
    public bool IsSold;

    public AuctionData()
    {

    }
    
    public AuctionData(string auctionKey, string sellerKey, string sellNickName, 
        string itemname, int count, int price, bool isSold)
    {
        AuctionKey = auctionKey;
        SellerKey = sellerKey;
        SellNickName = sellNickName;
        Itemname = itemname;
        Count = count;
        this.price = price;
        IsSold = isSold;
    }
}
