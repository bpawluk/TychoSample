namespace TychoSample.Inventory.Persistence;

internal interface IStockLevelsRepository
{
    void ReserveProduct(string productId, int amount);
}
