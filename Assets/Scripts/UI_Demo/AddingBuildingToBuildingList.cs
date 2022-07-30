using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AddingBuildingToBuildingList : MonoBehaviour
{
    [SerializeField] GameObject ButtonPrefabOfBuilding;
    [SerializeField] List<TMP_InputField> inpf;
    [SerializeField] BuildingListSO buildingListSO;
    
    private void Start()
    {
        if(buildingListSO.BuildingList.Count>0)
        {
            foreach (Building building in buildingListSO.BuildingList)
            {
                GameObject go = Instantiate(ButtonPrefabOfBuilding, this.transform);
                go.GetComponent<BuildingButton>().Init(building);
            }
        }
    }
    public void Add()
    {
        Building building = new Building(inpf[0].text, int.Parse(inpf[1].text), int.Parse(inpf[2].text),
            int.Parse(inpf[3].text), int.Parse(inpf[4].text), int.Parse(inpf[5].text));

        buildingListSO.AddBuilding(building); 

        foreach (var item in inpf)
        {
            item.text = ""; //reseting the inputfields 
        }

        
        GameObject go = Instantiate(ButtonPrefabOfBuilding, this.transform);
        go.GetComponent<BuildingButton>().Init(building);

        
    }
   
}
