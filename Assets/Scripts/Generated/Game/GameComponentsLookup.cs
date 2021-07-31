//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int DeltaTime = 0;
    public const int Health = 1;
    public const int PlayerCharacter = 2;
    public const int PlayerInput = 3;
    public const int Destroyed = 4;

    public const int TotalComponents = 5;

    public static readonly string[] componentNames = {
        "DeltaTime",
        "Health",
        "PlayerCharacter",
        "PlayerInput",
        "Destroyed"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Ecs.Features.Game.Components.DeltaTimeComponent),
        typeof(Game.Components.HealthComponent),
        typeof(Game.Components.PlayerCharacterComponent),
        typeof(Game.Components.PlayerInputComponent),
        typeof(Libs.OpenCore.Ecs.Common.Components.DestroyedComponent)
    };
}
