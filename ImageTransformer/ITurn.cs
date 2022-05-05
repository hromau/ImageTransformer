namespace ImageTransformer;

public interface ITurn
{
    public ValueTask Rotate90();
    public ValueTask Rotate180();
}