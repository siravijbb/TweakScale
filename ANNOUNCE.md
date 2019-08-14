## ANNOUNCE

Release 2.4.3.3 is available for downloading, with the following changes:

+ Added support for hot-fixes - handcrafted patches to brute force a correct path when the normal way is not possible - as when an unmaintained ARR Add'On is involved on the mess.
	- New hot fix for [CxAerospace:Station Parts](https://forum.kerbalspaceprogram.com/index.php?/topic/138910-dev-halted13-cxaerospace-stations-parts-pack-v162-2017-5-24/page/31/) breaking [Bluedog_DB](https://forum.kerbalspaceprogram.com/index.php?/topic/122020-16x-bluedog-design-bureau-stockalike-saturn-apollo-and-more-v152-бруно-8feb2019/). 

See OP for the links.

## Highlights

### Hot Fixes

TweakScale know recognizes and keep track of HOT FIXES.

A Hot Fix is a hand crafted patch that fixes by brute force patching problems, forcing the original intended result for a given KSP installment. The difference from an overrule is that Hot Fixes don't break compatibility with sane installments, so you can start new savegames and share your crafts without worries.

However, a Hot Fix is highly specialized to a given situation, and thiere're no guarantees that it will behave correctly as the affected Add'Ons are updated by the maintainers. So, a pesky Advise will popup when Hot Fixes are detected to prevent you from forgetting a old Hot Fix on your installments.

In an ideal World, Overrules and HotFixes would not be necessary. These are temporary workaround to keep KSP installments sane enough to keep going.

Apply Hot-Fixes or Overrules only when recommended by me, LisiasT. It's ok to reach me asking about if you think it will help you, but please confirm with me first. These things can cause as much damage as it can fix them.

Each Hot Fix will have an URL associated pinpoint to the Post where the problem were detected and fixed for traceability.

### New Scaling Behaviour

A new TWEAKSCALEBEHAVIOUR, ModuleGeneratorExtended , is available for parts using ModuleGenerator that wants to scale the INPUT_RESOURCES too. This feature wasn't introduced directly into the ModuleGenerator's TWEAKSCALEEXPONENTS to prevent damage on Add'Ons (and savegames) that rely on the current behaviour (scaling only the output), as suddenly the resource consumption would increase on already stablished bases and crafts.

Just add the lines as the example below (the output resources scaling is still inherited from the default patch!).

```
@PART[my_resource_converter]:NEEDS[TweakScale]
{
    #@TWEAKSCALEBEHAVIOR[ModuleGeneratorExtended]/MODULE[TweakScale] { }
    %MODULE[TweakScale]
    {
        type = free
    }
}
```

## WARNINGS

The last detected *Unholy interaction between modules* (Kraken Food), when rogue patches apply twice the same property on a part, are still detected on the Sanity Checks and a (now) proper (scaring) warning is being shown. Unfortunately, this issue is a serious Show Stopper, potentially (and silently) ruining your savegames. This is not TweakScale fault, but yet it's up to it to detect the problem and warn you about it. If this happens with you, call for help. Now a "Cancel" button is available for the brave Kerbonauts willing to fly unsafe.

TweakScale strongly recommends using [S.A.V.E.](https://forum.kerbalspaceprogram.com/index.php?/topic/94997-*).

Special procedures for recovering mangled installments once the TweakScale are installed (triggering the MM cache rebuilding) are possible, but **keep your savegames backed up**. And **DON`T SAVE** your crafts once you detect the problem. Reach me on [Forum](https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*) for help.

TweakScale stills "mangles further" affected crafts and savegames with some badly (but recoverable) patched parts so when things are fixed, your crafts preserve the TweakScale settings without harm. **THIS DOES NOT FIX THE PROBLEM**,  as this is beyond the reach of TweakScale - but it at least prevents you from losing your crafts and savegames once the problem happens and then is later fixed.

As usual, this version still drops support in runtime for some problematic parts. Any savegame with such problematic parts scaled will have them "descaled". This is not a really big problem as your game was going to crash sooner or later anyway - but if you plan to return to such savegame later when TweakScale will fully support that parts again, it's better to backup your savegames!

Keep an eye on the [Known Issues](https://github.com/net-lisias-ksp/TweakScale/blob/master/KNOWN_ISSUES.md) file.

— — — — —

This Release will be published using the following Schedule:

* GitHub, reaching first manual installers and users of KSP-AVC. Right now.
* CurseForge, by Saturday night
* SpaceDock (and CKAN users), by Sunday night.

The reasoning is to gradually distribute the Release to easily monitor the deployment and cope with eventual mishaps.
