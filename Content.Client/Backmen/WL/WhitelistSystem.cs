using Content.Client.Backmen.Sponsors;
using Content.Corvax.Interfaces.Client;
using Content.Corvax.Interfaces.Shared;
using Content.Shared.Backmen.WL;
using Content.Shared.Species.Components;
using Robust.Shared.Network;

namespace Content.Client.Backmen.WL;

public sealed class WhitelistSystem  : SharedWhitelistSystem
{

    public override void ProcessReform(EntityUid child, Entity<ReformComponent> source)
    {
        // noop
    }

}
