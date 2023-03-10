using Tycho.Messaging.Payload;

namespace TychoSample.Inventory.Contract;

public record StockLevelChangedEvent(string ProductId, int PreviousLevel, int CurrentLevel) : IEvent;
