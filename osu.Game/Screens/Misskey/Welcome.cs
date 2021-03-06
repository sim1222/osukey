// Copyright (c) sim1222 <kokt@sim1222.com>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Framework.Allocation;
using osu.Framework.Extensions.Color4Extensions;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Effects;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Screens;
using osu.Game.Graphics;
using osu.Game.Graphics.Containers;
using osu.Game.Graphics.Sprites;
using osu.Game.Graphics.UserInterface;
using osu.Game.Overlays;
using osu.Game.Screens.Misskey.Components;
using osu.Game.Screens.Select;
using osuTK;
using osuTK.Graphics;

namespace osu.Game.Screens.Misskey
{
    public class Welcome : OsuScreen
    {
        private Container carouselContainer;
        private IconButton aboutButton;

        [BackgroundDependencyLoader(true)]
        private void load()
        {
            InternalChild = new Container
            {
                Masking = true,
                CornerRadius = 10,
                RelativeSizeAxes = Axes.Both,
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Children = new Drawable[]
                {
                    new GridContainer // used for max width implementation
                    {
                        Name = "ParrallaxBackgroundShape",
                        RelativeSizeAxes = Axes.Both,
                        ColumnDimensions = new[]
                        {
                            new Dimension(),
                            new Dimension(GridSizeMode.Relative, 0.5f, maxSize: 850),
                        },
                        Content = new[]
                        {
                            new Drawable[]
                            {
                                new ParallaxContainer
                                {
                                    ParallaxAmount = 0.005f,
                                    RelativeSizeAxes = Axes.Both,
                                    Child = new WedgeBackground
                                    {
                                        RelativeSizeAxes = Axes.Both,
                                        Padding = new MarginPadding { Right = -150 },
                                    },
                                },
                                carouselContainer = new Container
                                {
                                    RelativeSizeAxes = Axes.Both,
                                    Padding = new MarginPadding
                                    {
                                        Top = FilterControl.HEIGHT,
                                        Bottom = Footer.HEIGHT
                                    },
                                    Child = new LoadingSpinner(true) { State = { Value = Visibility.Visible } }
                                }
                            },
                        }
                    },
                    new Container()
                    {
                        Name = "Panel",
                        Anchor = Anchor.CentreLeft,
                        Origin = Anchor.CentreLeft,
                        Width = 500f,
                        Height = 500f,
                        Margin = new MarginPadding(80),
                        CornerRadius = 10,
                        Masking = true,
                        EdgeEffect = new EdgeEffectParameters
                        {
                            Type = EdgeEffectType.Shadow,
                            Colour = Color4.Black.Opacity(60),
                            Radius = 30,
                        },
                        Children = new Drawable[]
                        {
                            new Box()
                            {
                                Name = "BackGround",
                                RelativeSizeAxes = Axes.Both,
                                Colour = Colour4.DarkSlateGray,
                                Width = 1f,
                                Height = 1f,
                            },
                            new OsuSpriteText()
                            {
                                Name = "InsetanceName",
                                Anchor = Anchor.TopCentre,
                                Origin = Anchor.TopCentre,
                                Margin = new MarginPadding(50),
                                Text = "Misskey",
                                Font = new FontUsage(size: 30),
                                Colour = Colour4.White,
                            },
                            aboutButton = new PopupButton
                            {
                                Origin = Anchor.TopRight,
                                Anchor = Anchor.TopRight,
                                Margin = new MarginPadding(20),
                                Position = new Vector2(0),
                                Icon = FontAwesome.Solid.EllipsisH,
                                // Action = () => OsuMenu.Empty()
                                // TODO: ???????????????????????????????????????
                            },
                            new OsuSpriteText()
                            {
                                Name = "InsetanceInfo",
                                Anchor = Anchor.TopCentre,
                                Origin = Anchor.TopCentre,
                                Margin = new MarginPadding(100),
                                Width = 400f,
                                Text = "Misskey.io ??????????????????????????????????????????????????????SNS?????????Fediverse????????????SNS???????????????????????????????????????????????????????????????SNS????????????????????????????????????\n?????????????????????????????????????????????????????????????????????????????????????????????????????????",
                                Font = new FontUsage(size: 20),
                                Colour = Colour4.White,
                            },
                            new GridContainer()
                            {
                                Name = "Buttons",
                                RelativeSizeAxes = Axes.Both,
                                Position = new Vector2(0, 300),
                                ColumnDimensions = new[]
                                {
                                    new Dimension(),
                                    new Dimension(GridSizeMode.Relative, 0.5f, maxSize: 850),
                                },
                                Content = new[]
                                {
                                    new Drawable[]
                                    {
                                        new OsuButton()
                                        {
                                            Name = "SignUpButton",
                                            Anchor = Anchor.TopCentre,
                                            Origin = Anchor.TopCentre,
                                            Width = 100f,
                                            Text = "????????????"
                                        },
                                        new OsuButton()
                                        {
                                            Name = "SignInButton",
                                            Anchor = Anchor.TopCentre,
                                            Origin = Anchor.TopCentre,
                                            Width = 100f,
                                            Text = "????????????"
                                        },
                                    }
                                },
                                // TODO: ??????
                                // TODO: ????????????????????????????????????????????????????????????
                            }
                        }
                    }
                }
            };
        }
        public override void OnResuming(ScreenTransitionEvent e)
        {
            base.OnResuming(e);

            this.FadeIn(250);

            this.ScaleTo(1, 250, Easing.OutSine);

        }
    }
}
