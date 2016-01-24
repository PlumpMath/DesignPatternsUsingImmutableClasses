using System.CodeDom;

namespace PatternLibrary.Builder
{
    public interface IEngineer
    {
        IEngineer WithBuilder(IBuilder builder);
        IProduct CreateProduct();
    }
}
