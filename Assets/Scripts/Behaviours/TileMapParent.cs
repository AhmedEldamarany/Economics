using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapParent : MonoBehaviour
{
    SpriteRenderer oldSpriteRenderer;
    [SerializeField] Color defaulrColor;
    [SerializeField] UiManager uiManager;
    
    void Start()
    {
        Tile[] tiles = gameObject.GetComponentsInChildren<Tile>();
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].Id = $"Tile {i}";
            tiles[i].parent = this;
        }
    }
    public void HighlightMe(SpriteRenderer current)
    {
        current.color = Color.grey;
        if (oldSpriteRenderer != null)
            oldSpriteRenderer.color = defaulrColor;
        oldSpriteRenderer = current;
       
        //new for map creator
        if (uiManager.currentSprite != null)
            current.sprite = uiManager.currentSprite;
    }
  
}
