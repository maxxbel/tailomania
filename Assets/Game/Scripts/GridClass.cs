using UnityEngine;
using UnityEngine.UI;

public class GridClass 
{
    private int width;
    private int height;
    private float size;
    private Tyle[,] array;
    public GridClass(int width, int height, float size)
    {
        this.width = width;
        this.height = height;
        this.size = size;
        array = new Tyle[width, height];
        
        Debug.Log(width + " " + height);
        for(int i = 0; i < width; i++) {
            for(int j = 0; j < height; j ++) {
                array[i, j] = new Tyle(0, i, new Tyle.TerrainType[] {Tyle.TerrainType.Farm, 0, 0, 0, 0, 0, 0});
                GameObject gameObject = new GameObject("World_Text", typeof(TextMesh));
                gameObject.transform.localPosition = GetWorldPosition(i, j) + new Vector3(size, 0, size) * 0.5f;
                var mesh = gameObject.GetComponent<TextMesh>();
                mesh.anchor = TextAnchor.MiddleCenter;
                mesh.alignment = TextAlignment.Center;
                mesh.text = array[i,j].ToString();
                mesh.fontSize = 10;
                mesh.color = Color.white;
                mesh.transform.rotation = Camera.main.transform.rotation;
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i, j + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i + 1, j), Color.white, 100f);
            }
        }
    }

    private Vector3 GetWorldPosition(int x, int y) {
        return new Vector3(x, 0, y) * size;
    }
    
    public void SetValue(int x, int y, Tyle value) {
        if (x >= 0 && y >= 0 && x < width && y < height) {
            array[x, y] = value;
        }
    }
}
