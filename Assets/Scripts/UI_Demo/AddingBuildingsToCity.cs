
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class AddingBuildingsToCity : MonoBehaviour
{
   // [SerializeField] List<TMP_InputField> inpf;
    [SerializeField] List<CityData> cityList=new List<CityData>();
     Calculator calculator;
    [SerializeField] List<TMP_Text> ctexts;
    [SerializeField] List<TMP_Text> ctexts2;
    [SerializeField] List<TMP_Text> ctexts3;
    [SerializeField] IntSO BuildingCount;
    private Building BuildingToAdd;
    CityData TempCity;

    private void Start()
    {
        calculator = new Calculator();
    }
    public void SetBuilding(Building b)
    {
        if (TempCity != null)
        {
            if (BuildingCount.Value > 0)
                for (int i = 0; i < BuildingCount.Value; i++)
                {
            TempCity.AddBuilding(b);

                }
            else 
            TempCity.AddBuilding(b);
           
        }
    }
    //public void AddToCairo()
    //{
    //    TempCity.AddBuilding(BuildingToAdd);
    //    cityList.Add(TempCity); //shouldn't do that

    //    ctexts[0].text = TempCity.Citizens.ToString();
    //    ctexts[1].text = TempCity.Workers.ToString();
    //    ctexts[2].text = TempCity.Domestics.ToString();
    //    ctexts[3].text = TempCity.Sertfs.ToString();
    //    ctexts[4].text = TempCity.Slaves.ToString();
    //}
    
    //public void AddToCivilization()
    //{
    //    CityData city=calculator.CalcualteAllCities(cityList.ToArray());
    //    Debug.Log(cityList.Count);
    //    ctexts3[0].text = city.Citizens.ToString();
    //    ctexts3[1].text = city.Workers.ToString();
    //    ctexts3[2].text = city.Domestics.ToString();
    //    ctexts3[3].text = city.Sertfs.ToString();
    //    ctexts3[4].text = city.Slaves.ToString();
    //}
    
    public void AddBuildingToCity(CityData city)
    {
        TempCity = city;

    }
}
