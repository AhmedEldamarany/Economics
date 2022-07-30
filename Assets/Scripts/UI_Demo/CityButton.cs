using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CityButton : MonoBehaviour
{
    [SerializeField] TMP_Text nameText;
    [SerializeField] Event CityEvent;
     City city;
    public void Init(CityData CityData)
    {
        nameText.text = CityData.Name;
        city = gameObject.GetComponent<City>();
        city.cityData = CityData;
    }
    public void onClick()
    {
        CityEvent?.Raise(city.cityData);
    }
    
    
}
