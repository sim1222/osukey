// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using Newtonsoft.Json;

namespace osu.Game.Misskey.Models
{
    public class RoundBeatmap
    {
        public int ID;
        public string Mods;

        [JsonProperty("BeatmapInfo")]
        public TournamentBeatmap Beatmap;
    }
}
