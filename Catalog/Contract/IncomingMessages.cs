﻿using Catalog.Model;
using System.Collections.Generic;
using Tycho.Messaging.Payload;

namespace Catalog.Contract;

public record GetProductsQuery() : IQuery<IEnumerable<Product>>;
public record FindProductQuery(string ProductName) : IQuery<Product>;
public record PriceChangedEvent(string ProductId, decimal OldPrice, decimal NewPrice) : IEvent;
public record StockLevelChangedEvent(string ProductId, int OldLevel, int NewLevel) : IEvent;
