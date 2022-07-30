using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEventSO", menuName = "EventSO", order = 52)]
public class Event : ScriptableObject
{
    private List<EventListener> elisteners = new List<EventListener>();

    public void Register(EventListener listener)
    {
        elisteners.Add(listener);
    }

    public void Unregister(EventListener listener)
    {
        elisteners.Remove(listener);
    }

    public void Raise()
    {
        for (int i = 0; i < elisteners.Count; i++)
        {
            elisteners[i].OnEventOccurs();
        }
    }
    public void Raise(Tile tile)
    {
        for (int i = 0; i < elisteners.Count; i++)
        {
            elisteners[i].OnEventOccurs(tile);
        }
    }
    public void Raise(Building building)
    {
        for (int i = 0; i < elisteners.Count; i++)
        {
            elisteners[i].OnEventOccurs(building);
        }
    }
    public void Raise(CityData cityData)
    {
        for (int i = 0; i < elisteners.Count; i++)
        {
            elisteners[i].OnEventOccurs(cityData);
        }
    }
}
