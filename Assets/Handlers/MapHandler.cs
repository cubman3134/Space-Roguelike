using Assets.Enums;
using Assets.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Handlers
{
    public class MapHandler : MonoBehaviour
    {
        private const float _tileScale = 3.13f;
        public List<GameObject> ActiveSubShips = new List<GameObject>();

        public bool CreateTileGameObjectAtPosition(TileTypes tileType, int x, int y)
        {
            GameObject tileGameObject = new GameObject($"Tile{x.ToString().PadLeft(5)}{y.ToString().PadLeft(5)}");
            tileGameObject.transform.position = new Vector3(x, y, 0);
            tileGameObject.transform.localScale = new Vector3(_tileScale, _tileScale, _tileScale);
            var spriteRenderer = tileGameObject.AddComponent<SpriteRenderer>();
            Sprite sprite = null;
            switch (tileType)
            {
                case TileTypes.Wall:
                    sprite = SpriteImplementations.WallTileSprite;
                    break;
                case TileTypes.Conveyor:
                    sprite = SpriteImplementations.ConveyorTileSprite;
                    break;
                case TileTypes.Ground:
                    sprite = SpriteImplementations.GroundTileSprite;
                    break;
                default:
                    break;
            }
            if (sprite == null)
            {
                Destroy(tileGameObject);
                return false;
            }
            spriteRenderer.sprite = sprite;
            return true;
        }

        // Start is called before the first frame update
        void Start()
        {
            for (var widthIterator = 0; widthIterator < ShipInfo.ShipStructures.Count; widthIterator++)
            {
                for (var heightIterator = 0; heightIterator < ShipInfo.ShipStructures[0].Length; heightIterator++)
                {
                    var currentChar = ShipInfo.ShipStructures[widthIterator][heightIterator];
                    switch (currentChar)
                    {
                        case ShipInfo.ConveyorStartChar:
                            CreateTileGameObjectAtPosition(TileTypes.Conveyor, widthIterator, heightIterator);
                            break;
                        case ShipInfo.ConveyorEndChar:
                            CreateTileGameObjectAtPosition(TileTypes.Conveyor, widthIterator, heightIterator);
                            break;
                        case ShipInfo.ConveyorChar:
                            CreateTileGameObjectAtPosition(TileTypes.Conveyor, widthIterator, heightIterator);
                            break;
                        case ShipInfo.WallChar:
                            CreateTileGameObjectAtPosition(TileTypes.Wall, widthIterator, heightIterator);
                            break;
                        case ShipInfo.FloorChar:
                            CreateTileGameObjectAtPosition(TileTypes.Ground, widthIterator, heightIterator);
                            break;
                    }
                }
            }
        }

    }
}
