using UnityEngine;

namespace ForjaGames.Foundations.Core.Interfaces
{
  public interface IInjector
  {
    void Bind<T>(T instance);

    T GetAny<T>();

    T GetScript<T>() where T : MonoBehaviour;

    T GetAny<T>(ref T value);

    T LazyInitializeAny<T>(ref T value);

    T GetScript<T>(ref T value) where T : MonoBehaviour;

    T LazyInitializeScript<T>(ref T value) where T : MonoBehaviour;

    void Clear();
  }
}
