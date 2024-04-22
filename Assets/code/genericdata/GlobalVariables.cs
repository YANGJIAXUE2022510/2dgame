using UnityEngine;
using System.Collections.Generic;

public static class GlobalVariables
{
    public static int score = 0;
    public static string dynasty = "周";
    public static string era = "凤临";
    public static int year = 0;
    public static int month = 0;
    public static List<string> bigMapArray = new List<string> { "A城市", "B城市", "C城市" };
    public static List<string> smallMapArray = new List<string> { "居民楼", "医院", "公园" };
    public static List<string[]> mapArray;

    static GlobalVariables()
    {
        InitMapArray();
    }

    public static string GetChineseYearString(int year)
    {
        string[] chineseDigits = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
        string yearString = "";

        if (year == 0)
        {
            yearString = "元";
        }
        else
        {
            int digitCount = (int)Mathf.Floor(Mathf.Log10(year)) + 1;
            for (int i = 0; i < digitCount; i++)
            {
                int digit = (year / (int)Mathf.Pow(10, digitCount - 1 - i)) % 10;
                if (digit != 0)
                {
                    yearString += chineseDigits[digit];
                    if (digitCount - 1 - i > 0)
                    {
                        yearString += chineseDigits[digitCount - 1 - i];
                    }
                }
            }
        }

        return yearString + "年";
    }

    public static string GetChineseMonthString(int month)
    {
        string[] chineseMonths = { "正月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" };
        return chineseMonths[month];
    }

    public static void IncrementMonth()
    {
        month++;
        if (month > 11)
        {
            month = 0;
            year++;
        }
    }

    public static List<string[]> InitMapArray()
    {
        mapArray = new List<string[]>();

        foreach (string bigMap in bigMapArray)
        {
            foreach (string smallMap in smallMapArray)
            {
                mapArray.Add(new string[] { bigMap, smallMap });
            }
        }


        return mapArray;
    }


    //点击小地图后  公共方法
    public static string GetFormattedMap(int index)
    {
        string formattedMap = "";

        if (index >= 0 && index < mapArray.Count)
        {
            string[] map = mapArray[index];
            formattedMap = map[0] + "." + map[1];
        }
        else
        {
            Debug.LogWarning("Index out of range or mapArray is null.");
        }

        return formattedMap;
    }



}
