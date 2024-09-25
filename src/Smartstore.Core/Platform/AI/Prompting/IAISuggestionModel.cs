﻿#nullable enable

namespace Smartstore.Core.Platform.AI.Prompting
{
    /// <summary>
    /// Represents a text suggestion model.
    /// </summary>
    public interface IAISuggestionModel
    {
        string TargetProperty { get; }
        string Input { get; }
        int NumberOfSuggestions { get; }
        int CharLimit { get; }
    }
}