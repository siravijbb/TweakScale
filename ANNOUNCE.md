## ANNOUNCE

Release 2.4.3.15 is available for downloading.

This is an **VERY IMPORTANT** update, fixing some lsat minute problems detected on KSP >= 1.8, as well introducing new Houstons to alert the users about problems on the instalment:

* KSP Recall is now not only recommended, but heavily pushed on KSP >= 1.9. TweakScale will pesky you until you install it.
* TweakScale 2.4.3 will not run on KSP >= 1.10 , and will complain it you try.
	+ Only Version 2.4.4 will support KSP 1.10
	+ But you can try your luck nevertheless - just be absolutely sure you installed [S.A.V.E.](https://forum.kerbalspaceprogram.com/index.php?/topic/94997-181-save-automatic-backup-system-180-3165/)
		- Really. Everybody **should** be using [S.A.V.E.](https://forum.kerbalspaceprogram.com/index.php?/topic/94997-181-save-automatic-backup-system-180-3165/) by now, and I holding myself to do not code a new Houston for it.  

See [OP](https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*) for the links.

## Highlights

### KSP 1.10.x Support

KSP 1.10 definitively will not be supported by TweakScale 2.4.3 without a comprehensive set of testings from my side.

Don't expect KSP 1.10 support on 2.4.3, I'm almost certain that only 2.4.4.0 will allow being run on KSP 1.10 (however, Kerbal proposes, Kraken disposes...).

But you can try your luck if you want.

### KSP 1.9.x Support

#### VAB/SPH Editor

KSP 1.9.x Editor introduced a glitch that was rendering parts with ModulePartVariant displaced on loading. Crafts being instantiated on LaunchPad/Runway (as also living craft on the Universe) are not affected.

This is what I know until this moment:

* KSP is shoving back prefab data into living crafts on savegames (and on loading crafts on the Editor) since 1.6 or 1.7, and recently started to obliterate the resources customisations made by Modules.
	+ You already know that, KSP Recall was born due it.
* The novelty is that, somehow, surface attachments are, now, also affected - but not exactly as the Resources, and this is what caught me with my pants down (and what made me bork the 2.4.3.13 release, already withdrawn):
	+ Parts with variants are getting surface attachments mangled on Editor, but parts without variants are not!
		- Attachments points apparently are being mangled too, but I did't did a full testing on the matter - proceed with caution
			- Attachment points with parts are also reset, but are preserved on classic parts.
			- Boy, what a mess... :P 
* This, **probably**, could be also solved by using the `GameEvents.onEditorVariantApplied`, but since KSP still mangles with TweakScale business in other situations (including on Flight Scene), I would need to split the survivorship logic in two different places now - so I opted to keep the current Event handling for while until I fully refactor (and validade) the code.
	+ Surviving different KSP Version's idiosyncrasies are taxing badly the codetree
	+ And I'm firm on my commitment to keep TweakScale (core) compatible with every KSP still em use - expect TweakScale 2.5 to be useable down to KSP 1.2 (KSPe already does it, by the way) - so I will be able to backport every fix and enhancements to people that choose to stay playing older KSP versions.
* The after math is that I'm still using Unity's Update callback to handle the "first Scale Back" event, needed to survive KSP manglings.
For some time I considered using KSP Recall to handle this situation, but since Scaling is the TweakScale's Core Business, and I don't intend to tie KSP Recall to TweakScale in any way (it must be a generic solution for everyone, not just for me), I rolled back any change on it.

Please also note that there's a lot of glitches on KSP 1.9 Editor not related to TweakScale (or any other Add'On).

#### Drain Valve

The FTE-1 Drain Valve is being scaled, however not properly. Mass and size scales fine, but the drain rate is not. See Issue [#102](https://github.com/net-lisias-ksp/TweakScale/issues/102) for details.


#### Resources

KSP 1.9.x is known to replace any Resource customisation made by custom modules with default definitions from the `prefab`.

This affects many Add'Ons, being TweakScale only one of them. So a new Add'On called [KSP Recall](https://forum.kerbalspaceprogram.com/index.php?/topic/192048-*/) was created to specifically handle KSP issues that would affect everybody.

Users of KSP 1.9.0 and 1.9.1 are **urged** to install [KSP Recall](https://forum.kerbalspaceprogram.com/index.php?/topic/192048-*/). Future KSP releases may or may not fix the glitches [KSP Recall](https://forum.kerbalspaceprogram.com/index.php?/topic/192048-*/) aims to workaround - but until there, you need KSP Recall to use TweakScale on KSP 1.9.x . 

#### Misc

Keep an eye on the [Known Issues](https://github.com/net-lisias-ksp/TweakScale/blob/master/KNOWN_ISSUES.md) file.

— — — — —

This Release will be published using the following Schedule:

* GitHub, reaching first manual installers and users of KSP-AVC. Right now.
* CurseForge, Thursday night
* SpaceDock (and CKAN users), Friday night

The reasoning is to gradually distribute the Release to easily monitor the deployment and cope with eventual mishaps.
