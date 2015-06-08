using UnityEngine;
using System.Collections;

public static class GameObjectExtensions
{

    /// <summary>
    /// If GameObject has specified Component, it returns it.
    /// If GameObject does not have specified Component, it adds it and then returns it.
    /// </summary>
    /// <typeparam name="ComponentType">The type of Component to be (added and) retrieved</typeparam>
    /// <param name="gameObject">The GameObject the Component check will be performed on</param>
    /// <returns>The existing or new Component attached to the GameObject</returns>
    public static ComponentType GetOrAddComponent<ComponentType>(this GameObject gameObject) where ComponentType : Component
    {
        ComponentType component = gameObject.GetComponent<ComponentType>();
        if (component == null)
        {
            gameObject.AddComponent(typeof(ComponentType));
        }
        return gameObject.GetComponent<ComponentType>();
    }

}