namespace Automat.Products
{
    public interface IProduct
    {
        int Cost { get; }



        string Buy();
        string Description();
        void Use();
    }
}