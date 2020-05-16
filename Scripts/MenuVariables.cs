using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuVariables : MonoBehaviour
{
    private string language { get; set; }
    private List<int> vocIdList { get; set; }

    public void SetLanguage(string _language)
    {
        language = _language;
    }
    public void SetvocIdList(string vocName)
    {
        vocIdList = new List<int>();
        switch (vocName)
        {
            case "Street":
                for (int i = 1; i < 9; i++)
                {
                    vocIdList.Add(i);
                }
                break;
            case "Animal":
                vocIdList.Add(0);//add person to the list 
                for (int i = 14; i < 24; i++)
                {
                    vocIdList.Add(i);
                }
                break;
            case "Office":
                //we add "accesory"
                for (int i = 24; i < 29; i++)
                {
                    vocIdList.Add(i);
                }
                //We add "electronic"
                for (int j = 62; j < 68; j++)
                {
                    vocIdList.Add(j);
                }

                break;

            case "Sport":
                for (int i = 29; i < 39; i++)
                {
                    vocIdList.Add(i);
                }
                break;

            case "Kitchen":
                //Add "food" and "furniture" 
                for (int i = 39; i < 56; i++)
                {
                    vocIdList.Add(i);
                }
                //Add "appliance"
                for (int j = 68; j < 73; j++)
                {
                    vocIdList.Add(j);
                }
                break;
     
            default:
                print("You select the automatic mode");
                for (int i = 0; i < 80; i++)
                {
                    vocIdList.Add(i);
                }
                break;
        }
    }

    public List<int> GetvocIdList()
    {
        return vocIdList;
    }
    public string GetLanguage()
    {
        return language;
    }
}
