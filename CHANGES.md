# TweakScale :: Changes

* 2020-0623: 2.4.3.15 (Lisias) for KSP >= 1.4.1
	+ Module Manager is not distributed anymore.
		- A [Watch Dog](https://github.com/net-lisias-ksp/ModuleManagerWatchDog) is being distributed instead.
		- This will prevent users from running older versions of MM unatendly. Full history on [Forum](https://forum.kerbalspaceprogram.com/index.php?/topic/179030-ksp-141-tweakscale-under-lisias-management-24314-2020-0519/&do=findComment&comment=3798088).
	+ Fixed a pretty dumb mistake on a TWEAKSCALEBEHAVIOUR (ModuleGeneratorExtended).
		- Don't have a clue when I messed up, the first release of that file was working. :(
	+ Some smarter logging and warnings
		- The MM cache is now checked, and Warnings only popup when it is newer than 1 hour.
		- No more Dialog spammimg.
		- Sorry being late on this.
	+ New "Houstons"
		- When running on KSP >= 1.9 without KSP Recall
			- It's the only way to prevent KSP to reset the Resources to the `prefab` state after scaling the parts! 
		- When running on KSP >= 1.10
			- Given the numerous problems I still have to handle from KSP 1.8 and 1.9, I don't think it's wise to use TweakScale on KSP 1.10 without a lot of testing from my side first.
* 2020-0519: 2.4.3.14 (Lisias) for KSP >= 1.4.1 
	+ Closes issue:
		- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
