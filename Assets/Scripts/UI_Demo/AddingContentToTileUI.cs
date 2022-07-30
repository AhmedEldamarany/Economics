using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AddingContentToTileUI : MonoBehaviour
{
    [SerializeField] TMP_Text Citizens;
    [SerializeField] TMP_Text Workers;
    [SerializeField] TMP_Text Domestics;
    [SerializeField] TMP_Text Serfs;
    [SerializeField] TMP_Text Slaves;
    [SerializeField] TMP_Text CityCount;
    [SerializeField] TMP_Text BuildingCount;
    [SerializeField] TMP_Text PercentCitizens;




   public void DisplayTileData(TileData tileData) //need both functions for 2 scenes 
    {
        Citizens.text =$"{tileData.Citizens}";
         Workers.text =$"{tileData.Workers}";
         Domestics.text =$"{tileData.Domestics}";
         Serfs.text =$"{tileData.Serfs}";
        Slaves.text =$"{tileData.Slaves}";
        CityCount.text =$"{tileData.Cities.Count}";
        BuildingCount.text =$"{tileData.Buildings.Count}";
        tileData.CalculateTotalPopulation();
        PercentCitizens.text = $"% {tileData.PercentCitizen}";

    }
    public void DisplayCityData(CityData tileData)
    {
        Citizens.text =$"{tileData.Citizens}";
         Workers.text =$"{tileData.Workers}";
         Domestics.text =$"{tileData.Domestics}";
         Serfs.text =$"{tileData.Serfs}";
        Slaves.text =$"{tileData.Slaves}";
        CityCount.text =$"{tileData.Name}";
        BuildingCount.text =$"{tileData.Buildings.Count}";
        tileData.CalculateTotalPopulation();
        PercentCitizens.text = $"% {tileData.PercentCitizen}";
    }

   

}
