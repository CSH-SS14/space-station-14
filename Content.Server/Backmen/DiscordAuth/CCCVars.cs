using Robust.Shared.Configuration;

namespace Content.Server.Jerry.CCCVars;
[CVarDefs]
public static class CCCVars
{
    /*
     *  Discord OAuth2
     */

    public static readonly CVarDef<bool> DiscordAuthEnabled =
        CVarDef.Create("jerry.discord_auth_enabled", true, CVar.SERVERONLY | CVar.CONFIDENTIAL);

    public static readonly CVarDef<string> DiscordApiUrl =
        CVarDef.Create("jerry.discord_api_url", "http://152.89.199.139:2424/", CVar.CONFIDENTIAL | CVar.SERVERONLY);

    public static readonly CVarDef<string> DiscordApiKey =
        CVarDef.Create("jerry.discord_api_key", "key", CVar.CONFIDENTIAL | CVar.SERVERONLY);

    /*
     * Sponsors
     */

    public static readonly CVarDef<bool> SponsorsEnabled =
        CVarDef.Create("jerry.sponsors_enabled", false, CVar.SERVERONLY | CVar.CONFIDENTIAL);

    public static readonly CVarDef<string> DiscordGuildID =
        CVarDef.Create("jerry.discord_guildId", "1277666412772458558", CVar.CONFIDENTIAL | CVar.SERVERONLY);
}
