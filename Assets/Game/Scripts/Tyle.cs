using System.Text;

public class Tyle
{
    public enum TerrainType
    {
        Field,
        Farm,
        City,
        Forest
    }
    private int textureId;
    private int rotation;
    private TerrainType[] vertexes = new TerrainType[7];
    public Tyle(int textureId, int rotation, TerrainType[] terrainTypes) {
        this.textureId = textureId;
        Rotation = rotation;
        if (terrainTypes.Length < 7) {
            return;
        }
        for (int i = 0; i < 7; i++) {
            vertexes[i] = terrainTypes[i];
        }
    }
    public int Rotation
    {
        get 
        {
            return rotation;
        }
        set
        {
            value %= 6;
            if (value < 0) 
            {
                value += 6;
            }
            rotation = value;
        }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        int leftWordLength = vertexes[rotation].ToString().Length;
        int midWordLength = vertexes[6].ToString().Length;
        int topLeftWordLength = vertexes[(rotation + 1) % 6].ToString().Length;

        sb.Append(' ', leftWordLength);
        sb.Append(vertexes[(rotation + 1) % 6].ToString());
        sb.Append(' ', midWordLength);
        sb.Append(vertexes[(rotation + 2) % 6].ToString());
        sb.AppendLine();
        sb.AppendLine();

        sb.Append(vertexes[rotation].ToString());
        sb.Append(' ', topLeftWordLength);
        sb.Append(vertexes[6].ToString());
        sb.Append(' ', vertexes[(rotation + 2) % 6].ToString().Length);
        sb.Append(vertexes[(rotation + 3) % 6].ToString());
        sb.AppendLine();
        sb.AppendLine();

        sb.Append(' ', leftWordLength);
        sb.Append(vertexes[(rotation + 5) % 6].ToString());
        sb.Append(' ', midWordLength + topLeftWordLength - vertexes[(rotation + 5) % 6].ToString().Length);
        sb.Append(vertexes[(rotation + 4) % 6].ToString());
        return sb.ToString();
    }
}