using UnityEngine;
using UnityEngine.Events;



public class EventListener : MonoBehaviour
{
    //todo shuold seprate all responses types
    public Event gEvent;
    public UnityEvent <Tile> tresponse = new UnityEvent<Tile>();
    public UnityEvent<Building> bresponse;
    public UnityEvent<CityData> cresponse;
    public UnityEvent response;
    private void OnEnable()
    {
        gEvent.Register(this);
    }

    private void OnDisable()
    {
        gEvent.Unregister(this);
    }
    public void OnEventOccurs( )
    {
        response.Invoke();
    }
    public void OnEventOccurs(CityData cityData)
    {
       cresponse.Invoke(cityData);
    }
    public void OnEventOccurs(Tile tile)
    {
        tresponse.Invoke(tile);     
    }
    public void OnEventOccurs(Building building)
    {
        bresponse.Invoke(building);
    }
}
