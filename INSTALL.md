# TweakScale /L : Under New Management

**TweakScale** lets you change the size of a part.

**TweakScale /L** is TweakScale under Lisias' management.


## Installation Instructions

To install, place the GameData folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
	+ Delete `<KSP_ROOT>/GameData/TweakScale`
* Extract the package's `GameData/` folder into your KSP's as follows:
	+ `<PACKAGE>/GameData/TweakScale` --> `<KSP_ROOT>/GameData`
	+ `<PACKAGE>/GameData/999_Scale_Redist.dll` --> `<KSP_ROOT>/GameData`
		- Overwrite any preexisting file.
* If you **have** installed TweakableEverything:
	+ `<PACKAGE>/GameData/TweakableEverything` --> `<KSP_ROOT>/GameData/TweakableEverything`
	+ **Warning**: By reinstalling (or later installing) TweakableEverything, you will need to update TweakScale again!
* If (and only if) you **do not** have installed the current release for the Dependencies:
	+ `<PACKAGE>/GameData/ModuleManager.3.1.0.dll` --> `<KSP_ROOT>/GameData/ModuleManager.3.1.0.dll`

The following file layout must be present after installation:

```
<KSP_ROOT>
	[GameData]
		[TweakScale]
			[Plugins]
				KSPe.Light.TweakScale.dll
				Scale.dll
			[patches]
				...
			CHANGE_LOG.md
			DefaultScales.cfg
			Examples.cfg
			LICENSE
			NOTICE
			README.md
			ScaleExponents.cfg
			TweakScale.version
			documentation.txt
		999_Scale_Redist.dll
		ModuleManager.dll
		...
	KSP.log
	PastDatabase.cfg
	...
```


### Dependencies

* KSPe Light for TweakScale
	+ Included
	+ Licensed to TweakScale under [SKL 1.0](https://ksp.lisias.net/SKL-1_0.txt)
* Module Manager 3.0.7 or later
	+ Included
		- Do not unzip this if you use my [Experimental fork](https://github.com/net-lisias-ksp/ModuleManager).

