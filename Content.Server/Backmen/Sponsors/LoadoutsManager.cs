using System.Diagnostics.CodeAnalysis;
using Content.Corvax.Interfaces.Shared;
using Robust.Shared.Network;

namespace Content.Server.Backmen.Sponsors;

public sealed class LoadoutsManager : ISharedLoadoutsManager
{

    public void Initialize()
    {
    }

    public bool TryGetServerPrototypes()
    {
		return false;
    }
}
