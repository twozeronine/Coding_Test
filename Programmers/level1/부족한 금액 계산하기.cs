using System;
using System.Collections.Generic;
using System.Linq;

class GetlessPrice
{
    public static long solution(int price, int money, int count)
    {
        var priceList = new List<int>();
        for (int i = 0; i < count; i++)
        {
            priceList.Add(i * price);
        }

        var resultPrice = money - priceList.Sum();

        return resultPrice >= 0 ? 0 : -resultPrice;
    }
}