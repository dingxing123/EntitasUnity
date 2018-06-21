//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Entitas.Component.AnimationComponent animationComponent = new Entitas.Component.AnimationComponent();

    public bool isAnimation {
        get { return HasComponent(GameComponentsLookup.Animation); }
        set {
            if (value != isAnimation) {
                if (value) {
                    AddComponent(GameComponentsLookup.Animation, animationComponent);
                } else {
                    RemoveComponent(GameComponentsLookup.Animation);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnimation;

    public static Entitas.IMatcher<GameEntity> Animation {
        get {
            if (_matcherAnimation == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Animation);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnimation = matcher;
            }

            return _matcherAnimation;
        }
    }
}
