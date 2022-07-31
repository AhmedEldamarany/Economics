using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour
{
    public TileData tileData;
    [SerializeField] Event EventSO;
    public string Id;
    public TileMapParent parent;
    [SerializeField] SpriteRenderer spriteRenderer;
   [SerializeField] UiManager uiManager;
    private void OnMouseUpAsButton()
    {
        if (EventSystem.current.IsPointerOverGameObject()) return;
        Debug.Log(Id);
        EventSO.Raise(this);
        parent.HighlightMe(spriteRenderer);
        Sprite currentSprite = uiManager.GetComponent<UiManager>().currentSprite;
        if(currentSprite!=null)
         parent.UpdateTileRender(spriteRenderer,currentSprite);
    }

    void Start()
    {
        tileData = new TileData();
    }

    public void AddCity(CityData city)
    {
        tileData.AddCity(city);
    }

    public void AddBuilding(Building building)
    {
        tileData.AddBilding(building);
    }

}
