using System;
using System.Linq;
using CenaStream.Data.Enums;
using CenaStream.Server.Core.Data;
using MediaBrowser.Controller.Entities;
using Xunit;

namespace CenaStream.Server.Implementations.Tests.Data;

public class ItemTypeLookupTests
{
    public static TheoryData<BaseItemKind> MappedKinds()
        => new(new ItemTypeLookup().BaseItemKindNames.Keys);

    [Theory]
    [MemberData(nameof(MappedKinds))]
    public void BaseItemKindNames_Kind_NamesAnItemType(BaseItemKind kind)
    {
        var name = new ItemTypeLookup().BaseItemKindNames[kind];

        var type = AppDomain.CurrentDomain.GetAssemblies().Select(a => a.GetType(name)).FirstOrDefault(t => t is not null);

        Assert.NotNull(type);
        Assert.True(typeof(BaseItem).IsAssignableFrom(type), $"{name} is not an item type.");
    }
}
