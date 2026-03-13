namespace Content.Client._Stalker_EN.CharacterRank;

/// <summary>
/// Client-only marker component added to entities with active speech bubbles.
/// Used by <see cref="STCharacterRankSystem"/> to hide the rank icon during speech.
/// </summary>
[RegisterComponent]
public sealed partial class STSpeechBubbleActiveComponent : Component { }
