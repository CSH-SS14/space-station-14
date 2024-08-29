using System.Linq;
using Content.Corvax.Interfaces.Server;
using Content.Corvax.Interfaces.Shared;
using Content.Server.Mind;
using Content.Shared.Backmen.GhostTheme;
using Content.Shared.GameTicking;
using Content.Shared.Ghost;
using Content.Shared.Players;
using Robust.Server.Configuration;
using Robust.Shared;
using Robust.Shared.Network;
using Robust.Shared.Player;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.Manager;
using Robust.Shared.Timing;

#pragma warning disable CS0618 // Type or member is obsolete

namespace Content.Server.Backmen.GhostTheme;

public sealed class GhostThemeSystem : EntitySystem
{
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;
    [Dependency] private readonly ISerializationManager _serialization = default!;
    [Dependency] private readonly IServerNetConfigurationManager _netConfigManager = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<GhostComponent, PlayerAttachedEvent>(OnPlayerAttached);
    }

    private void OnPlayerAttached(EntityUid uid, GhostComponent component, PlayerAttachedEvent args)
    {
        var prefGhost = _netConfigManager.GetClientCVar(args.Player.Channel, Shared.Backmen.CCVar.CCVars.SponsorsSelectedGhost);
        {
			
        }

        GhostThemePrototype? ghostThemePrototype = null;
        if (string.IsNullOrEmpty(prefGhost) || !_prototypeManager.TryIndex<GhostThemePrototype>(prefGhost, out ghostThemePrototype))
        {
           
        }
		
    }
}
