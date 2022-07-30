using System;
[Serializable]
public class Building :Data
{
    public string Name; //todo make all public get only
    
    public bool isCalculated; //Error building type won't be calculated twice for tile if calculated to city
    int multiple; //modifer to multiply each value by for one specific city //above error will apply

    
    public Building (int citizens,int  workers, int domestics,int serfs,int  slaves) : base(citizens, workers, domestics, serfs, slaves)
    {
        
    }
    public Building(string name, int citizens, int workers, int domestics, int serfs, int slaves) : base(citizens, workers, domestics, serfs, slaves)

    {
        Name = name;
        
    }
    public Building Make(string name, int citizens, int workers, int domestics, int sertfs, int slaves) //what is it good for?
    {
        //todo if null then euqal zero
        Name = name;
        Citizens = citizens;
        Workers = workers;
        Domestics = domestics;
        Serfs = sertfs;
        Slaves = slaves;
        return this;
    }
    public Building Multiply(int multiple)
    {
        return new Building(multiple * Citizens, multiple * Workers, multiple * Domestics, multiple * Serfs, multiple * Slaves);
    }
}

