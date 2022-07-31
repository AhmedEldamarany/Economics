using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UiManager : MonoBehaviour
{
    [SerializeField] TMP_Text tileName;
    [SerializeField] AddingContentToTileUI adding;
    [SerializeField] IntSO BuildingCount;
    [SerializeField] IntSO CityCount;
    Tile CurrentTile;
    [SerializeField]
    Sprite[] sprites;
    public Sprite currentSprite;
    public void ShowTileData(Tile tile)
    {
        CurrentTile = tile;
        tileName.text = tile.Id;
        adding.DisplayTileData(tile.tileData);
    }
   
    public void AddBuildingToTile(Building building)
    {
        if (BuildingCount.Value > 0)
            building = building.Multiply(BuildingCount.Value);
        CurrentTile.AddBuilding(building);
        adding.DisplayTileData(CurrentTile.tileData);
    }

    public void AddCityToTile(CityData city)
    {
        if (CityCount.Value > 0)
            city = city.Multiply(CityCount.Value);
        CurrentTile.AddCity(city);
        adding.DisplayTileData(CurrentTile.tileData);

    }
    public void ChooseCurrentSprite(int spriteIdx)
    {
        currentSprite = sprites[spriteIdx];
        Debug.Log(spriteIdx);
    }
}
