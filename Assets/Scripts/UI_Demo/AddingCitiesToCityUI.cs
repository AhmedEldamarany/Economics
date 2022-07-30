using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddingCitiesToCityUI : MonoBehaviour
{
    [SerializeField] GameObject ButtonPrefabOfCity;
    [SerializeField] TMP_InputField cityName;
    [SerializeField] CityListSO cityListSO;

    private void Start()
    {
        if (cityListSO.Cities.Count > 0)
        {
            foreach (CityData city in cityListSO.Cities)
            {
                GameObject go = Instantiate(ButtonPrefabOfCity, this.transform);
                go.GetComponent<CityButton>().Init(city);
            }
        }
    }
    public void AddCity()
    {
        GameObject go = Instantiate(ButtonPrefabOfCity, this.transform);
        CityData cd = new CityData(cityName.text);
        go.GetComponent<CityButton>().Init(cd);
        cityListSO.Cities.Add(cd);
    }
}
