
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class AddingBuildingsToCity : MonoBehaviour
{
    [SerializeField] List<TMP_InputField> inpf;
    [SerializeField] City city;
    [SerializeField] Calculator calculator;
    [SerializeField] List<TMP_Text> ctexts;
    public void Add()
    {
        Building building = new Building(inpf[0].text,int.Parse(inpf[1].text), int.Parse(inpf[2].text),
            int.Parse(inpf[3].text), int.Parse(inpf[4].text), int.Parse(inpf[5].text));
        city.AddBuilding(building);
        calculator.CalculateTotalPeople(city);
        ctexts[0].text = city.Citizens.ToString();
        ctexts[1].text = city.Workers.ToString();
        ctexts[2].text = city.Domestics.ToString();
        ctexts[3].text = city.Sertfs.ToString();
        ctexts[4].text = city.Slaves.ToString();
    }

}
