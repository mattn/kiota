﻿using System;
using System.Collections.Generic;

namespace Kiota.Builder.CodeDOM;

/// <summary>
/// Marker interface used for type searching.
/// </summary>
public interface IBlock
{
    T? FindChildByName<T>(string childName, bool findInChildElements = true) where T : ICodeElement;
    T? FindChildByName<T>(string childName, uint maxDepth) where T : ICodeElement;
    IEnumerable<T> FindChildrenByName<T>(string childName) where T : ICodeElement;
    void AddUsing(params CodeUsing[] codeUsings);
    CodeElement? Parent
    {
        get; set;
    }
    IEnumerable<CodeUsing> Usings
    {
        get;
    }
    void RenameChildElement(string oldName, string newName);
}
