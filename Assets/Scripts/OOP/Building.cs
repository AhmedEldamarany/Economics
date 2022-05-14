using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
  public string Name; //todo make all public get only
  public int Citizens;
  public int Workers;
  public int Domestics;
  public int Sertfs;
  public int Slaves;
    public bool isCalculated; //Error building type won't be calculated twice for tile if calculated to city
    int multiple; //modifer to multiply each value by for one specific city //above error will apply
  
    public Building(string name, int citizens, int workers, int domestics, int sertfs, int slaves)
    {
        //todo if null then euqal zero
        Name = name;
        Citizens = citizens;
        Workers = workers;
        Domestics = domestics;
        Sertfs = sertfs;
        Slaves = slaves;
    }
}
