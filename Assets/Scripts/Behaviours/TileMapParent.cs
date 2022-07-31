using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapParent : MonoBehaviour
{
    SpriteRenderer oldSpriteRenderer;
    [SerializeField] Color defaulrColor;
    // Start is called before the first frame update
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
    }
   public void UpdateTileRender(SpriteRenderer current, Sprite updatedSprite)
    {
        current.sprite = updatedSprite;
        Debug.Log("Updated");
    }
}
