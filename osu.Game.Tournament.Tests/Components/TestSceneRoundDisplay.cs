// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics;
using osu.Game.Misskey.Components;
using osu.Game.Misskey.Models;

namespace osu.Game.Misskey.Tests.Components
{
    public class TestSceneRoundDisplay : TournamentTestScene
    {
        public TestSceneRoundDisplay()
        {
            Children = new Drawable[]
            {
                new RoundDisplay(new TournamentMatch
                {
                    Round =
                    {
                        Value = new TournamentRound
                        {
                            Name = { Value = "Test Round" }
                        }
                    }
                })
                {
                    Margin = new MarginPadding(20)
                }
            };
        }
    }
}
