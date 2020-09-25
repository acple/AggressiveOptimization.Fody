# AggressiveOptimization.Fody
This is a [Fody](https://github.com/Fody/Fody) add-in that disables Quick JIT for all your methods by adding AggressiveOptimization IL flag.

## Install
Available on [NuGet](https://www.nuget.org/packages/AggressiveOptimization.Fody)

Insert below section into your csproj:

```csproj
<ItemGroup>
  <PackageReference Include="Fody" Version="6.0.0" PrivateAssets="All" />
  <PackageReference Include="AggressiveOptimization.Fody" Version="*" PrivateAssets="All" />
</ItemGroup>
```

## Usage
Add `<AggressiveOptimization />` to your `FodyWeavers.xml`

```xml
<Weavers>
  <AggressiveOptimization />
</Weavers>
```

## License
MIT
