# Cake.ImageMagick

A Cake AddIn that extends Cake with [ImageMagick](http://www.imagemagick.org/) command tools.

[![cakebuild.net](https://img.shields.io/badge/WWW-cakebuild.net-blue.svg)](http://cakebuild.net/)
[![NuGet](https://img.shields.io/nuget/v/Cake.ImageMagick.svg)](https://www.nuget.org/packages/Cake.ImageMagick)

## Including addin
Including addin in cake script is easy.
```
#addin "Cake.ImageMagick"
```
## Commands supported

- [convert](http://www.imagemagick.org/script/convert.php) v0.1.0

## Usage

To use the addin just add it to Cake call the aliases and configure any settings you want.

```csharp
#addin "Cake.ImageMagick"

...

// How to remove a container with no settings
Task("ImageMagickConvert")
	.Does(() => {
		// or more containers at once
		ImageMagickConvert("containerName1", "containerName2", ...);
	)};
```
Other commands follow same convention.

# General Notes
**This is an initial version and not tested thoroughly**.
Contributions welcome.

Tested only on Windows. I guess it should work on Linux, too, assuming a proper ImageMagick tool name is added.

[![Follow @mihamarkic](https://img.shields.io/badge/Twitter-Follow%20%40mihamarkic-blue.svg)](https://twitter.com/intent/follow?screen_name=mihamarkic)
