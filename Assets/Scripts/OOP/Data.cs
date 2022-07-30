using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data 
{
    public int Citizens;
    public int Workers;
    public int Domestics;
    public int Serfs;
    public int Slaves;
    public int TotalPopulation;
    public float PercentCitizen;
    public Calculator calculator = new Calculator();
    public Data()
    {

    }
    public Data(int citizens, int workers, int domestics, int serfs, int slaves)
    {
        Citizens = citizens;
        Workers = workers;
        Domestics = domestics;
        Serfs = serfs;
        Slaves = slaves;
    }

    public void AddAToB(Data a, Data b)
    {
        b.Citizens += a.Citizens;
        b.Workers += a.Workers;
        b.Domestics += a.Domestics;
        b.Serfs += a.Serfs;
        b.Slaves += a.Slaves;
    }
    public void CalculateTotalPopulation()
    {
        TotalPopulation = Citizens + Domestics + Workers + Serfs + Slaves;
        if(Citizens>0)
        PercentCitizen = Citizens*1f / TotalPopulation;
    }
  
}
