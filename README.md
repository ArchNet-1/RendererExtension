<p align="center">
  <a href="https://archnet-plateform.fr"><img src="https://archnet-plateform.fr/ArchNetLogoWithBck.png" alt="ArchNet" width="240"></a>
</p>

# ArchNet · Renderer Extension

Tells whether a screen point, or objects of the scene, are inside a UI rectangle, for every canvas mode.

- Unity **6000.0** or newer · No dependency.
- Part of [ArchNet](https://archnet-plateform.fr), free and open-source Unity packages

## Install

*Window > Package Manager > + > Install package from git URL…*

```
https://github.com/ArchNet-1/RendererExtension.git
```

## Use

```csharp
using ArchNet.Extension;

bool clicked = button.ContainsScreenPoint(pointer.position);
bool seen = frame.ContainsAny(targets, Camera.main);
```

## License

MIT, see [LICENSE.md](LICENSE.md).
