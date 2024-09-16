﻿// Copyright (c) Rodel. All rights reserved.
// <auto-generated />

using Markdig.Syntax.Inlines;
using BiliCopilot.UI.Controls.Markdown.TextElements;

namespace BiliCopilot.UI.Controls.Markdown.Renderers.ObjectRenderers.Inlines;

internal class AutoLinkInlineRenderer : WinUIObjectRenderer<AutolinkInline>
{
    protected override void Write(WinUIRenderer renderer, AutolinkInline link)
    {
        if (renderer == null)
        {
            throw new ArgumentNullException(nameof(renderer));
        }

        if (link == null)
        {
            throw new ArgumentNullException(nameof(link));
        }

        var url = link.Url;
        if (link.IsEmail)
        {
            url = "mailto:" + url;
        }

        if (!Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
        {
        }

        var autolink = new MyAutolinkInline(link);

        renderer.Push(autolink);

        renderer.WriteText(link.Url);
        renderer.Pop();
    }
}