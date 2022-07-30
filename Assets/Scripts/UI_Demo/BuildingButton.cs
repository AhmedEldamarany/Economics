using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BuildingButton : MonoBehaviour
{
    public Building BuildingData;
    [SerializeField] TMP_Text nameText;
    AddingBuildingsToCity adding;
    [SerializeField] Event BuildingEvent;
    private void Start()
    {
        adding = FindObjectOfType<AddingBuildingsToCity>();
       // Debug.Log(adding);
       // adding.gameObject.SetActive(false);
         
            
    }
   
    public void Init(Building b)
    {
        BuildingData = b;
        
        nameText.text = BuildingData.Name;
    }
  public void onClick()
    {
        adding?.gameObject.SetActive(true);
        adding?.SetBuilding( BuildingData);
        BuildingEvent?.Raise(BuildingData);
        
    }
}
