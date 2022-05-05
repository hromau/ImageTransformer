namespace ImageTransformer;

public interface IFilter
{
    public ValueTask Sepia();
    public ValueTask GrayScale();
    public ValueTask Threshold();
}