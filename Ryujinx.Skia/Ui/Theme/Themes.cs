﻿using Ryujinx.Skia.Ui.Skia;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ryujinx.Skia.Ui
{
    public class Themes
    {
        public static Theme Light => new Theme()
        {
            Name = "Light",
            SceneBackgroundColor = SKColors.White,
            BackgroundColor = SKColors.White,
            LightPrimaryColor = SKColor.Parse("#ff553e"),
            PrimaryColor = Colors.NeonRed,
            DarkPrimaryColor = SKColor.Parse("#ab0000"),
            HoverBackgroundColor = SKColor.Parse("#ffe6e8"),
            HoverForegroundColor = SKColors.Black,
            HoverOutlineColor = Colors.NeonBlue,
            SelectBackgroundColor = SKColor.Parse("#ff99a2"),
            SelectForegroundColor = SKColors.Black,
            ContextHoverBackgroundColor = Colors.NeonBlue,
            ContextHoverForegroundColor = SKColors.Black,
            ContextHoverOutlineColor = Colors.NeonBlue,
            ContextSelectBackgroundColor = Colors.NeonRed,
            ContextSelectForegroundColor = SKColors.White,
            SelectOutlineColor = Colors.ConsoleRed,
            ForegroundColor = Colors.NeonGrey,
            ModalBackgroundColor = SKColors.White,
            SecondaryColor = SKColors.White,
            ModalBackdropColor = SKColor.Parse("#414142").WithAlpha(100),
            SideBarColor = SKColor.Parse("#fcfcfc")            
        };

        public static Theme Dark => new Theme()
        {
            Name = "Dark",
            SceneBackgroundColor = SKColor.Parse("#363636"),
            BackgroundColor = SKColor.Parse("#4f4f4f"),
            LightPrimaryColor = SKColor.Parse("#66f6ff"),
            PrimaryColor = Colors.NeonBlue,
            DarkPrimaryColor = SKColor.Parse("#0092b1"),
            HoverBackgroundColor = Colors.NeonGrey,
            HoverForegroundColor = SKColors.White,
            HoverOutlineColor = Colors.NeonBlue,
            SelectBackgroundColor = SKColor.Parse("#80eeff"),
            SelectForegroundColor = SKColors.White,
            ContextHoverBackgroundColor = Colors.NeonBlue,
            ContextHoverForegroundColor = SKColors.Black,
            ContextHoverOutlineColor = Colors.NeonBlue,
            ContextSelectBackgroundColor = Colors.NeonRed,
            ContextSelectForegroundColor = SKColors.White,
            SelectOutlineColor = SKColor.Parse("#4545ff"),
            ForegroundColor = SKColors.White,
            ModalBackgroundColor = SKColor.Parse("#4f4f4f"),
            SecondaryColor = SKColors.White,
            ModalBackdropColor = SKColor.Parse("#414142").WithAlpha(100),
            SideBarColor = SKColor.Parse("#2e2e2e")
        };
    }
}
