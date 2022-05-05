namespace ImageTransformer;

public interface IFlip
{
    public ValueTask FlipVertical();
    public ValueTask FlipHorizontal();
}