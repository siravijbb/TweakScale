# TweakScale :: Change Log

* 2020-0326: 2.5.0.10 Beta (Lisias) for KSP >= 1.4.1 
	+ Some more care on supporting Stock and DLC parts
	+ KIS and KAS patches is now on EoL, and are expected to be deprecated soon.
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.10
			- [#103](https://github.com/net-lisias-ksp/TweakScale/issues/103) Implement KSP Recall :: Attachment support
			- [#7](https://github.com/net-lisias-ksp/TweakScale/issues/7) Update some patches to KSP 1.5 and 1.6 (rework)
			- [#35](https://github.com/net-lisias-ksp/TweakScale/issues/35) Check for new parts on KSP 1.7 (rework)
			- [#73](https://github.com/net-lisias-ksp/TweakScale/issues/73) Support the new parts for KSP 1.8 (rework)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system
			- [#101](https://github.com/net-lisias-ksp/TweakScale/issues/101) Add Support for KSP 1.9
		- 2.5.0.9
			- KSP 1.9 Compliance
				- Delegated to [KSP Recall](https://github.com/net-lisias-ksp/KSP-Recall).
			- [#98](https://github.com/net-lisias-ksp/TweakScale/issues/98) Added support for [KSP Recall](https://github.com/net-lisias-ksp/KSP-Recall).
		- 2.5.0.8
			- KSP 1.8 Compliance
				- Compatibility check updated
				- Changing `Scale_Redist.dll` deployment model. See [KNOWN_ISSUES](https://github.com/net-lisias-ksp/TweakScale/blob/master/KNOWN_ISSUES.md) for details.
			- [#46](https://github.com/net-lisias-ksp/TweakScale/issues/46) Feasibility Studies for Serenity
				- Added scaling to Proppelers 
			- [#73](https://github.com/net-lisias-ksp/TweakScale/issues/73) Support the new parts for KSP 1.8 
			- [#74](https://github.com/net-lisias-ksp/TweakScale/issues/74) Check (and fix if needed) a possible misbehaviour on handling Events on Scale
		- 2.5.0.7
			- [#21](https://github.com/net-lisias-ksp/TweakScale/issues/21) Check that :FOR[TWEAKSCALE] thingy on the patches
				- Some entries for NFT were missing the fix 
			- [#26](https://github.com/net-lisias-ksp/TweakScale/issues/26) Document the patches
			- [#69](https://github.com/net-lisias-ksp/TweakScale/issues/69) Act on deprecated or misplaced patches
			- [#76](https://github.com/net-lisias-ksp/TweakScale/issues/76) Prevent KSP from running if TweakScale is installed on the wrong place!
		- 2.5.0.6
			- [#71](https://github.com/net-lisias-ksp/TweakScale/issues/71) Check for typos on the _V2 parts from patches for Squad's revamped parts
			- [#30](https://github.com/net-lisias-ksp/TweakScale/issues/30) Prevent incorrectly initialized Modules to be used (reopened)
		- 2.5.0.4
			- [#65](https://github.com/net-lisias-ksp/TweakScale/issues/65) Support for new Nertea's Cryo Engines
		- 2.5.0.3
			- [#47](https://github.com/net-lisias-ksp/TweakScale/issues/47) Count failed Sanity Checks as a potential problem. Warn user
			- [#48](https://github.com/net-lisias-ksp/TweakScale/issues/48) Backport the Heterodox Logging system into Orthodox (using KSPe.Light
			- [#49](https://github.com/net-lisias-ksp/TweakScale/issues/49) Check the Default patches for problems due wildcard!
			- [#50](https://github.com/net-lisias-ksp/TweakScale/issues/50) Check the patches for currently supported Add'Ons
			- [#58](https://github.com/net-lisias-ksp/TweakScale/issues/58) Mk4 System Patch (addendum)
		- 2.5.0.2
			- [#51](https://github.com/net-lisias-ksp/TweakScale/issues/51) Implement a "Cancel" button when Actions are given to MessageBox
			- [#54](https://github.com/net-lisias-ksp/TweakScale/issues/54) [ERR \*\*FATAL\*\* link provided in KSP.log links to 404
			- [#56](https://github.com/net-lisias-ksp/TweakScale/issues/56) "Breaking Parts" patches
			- [#57](https://github.com/net-lisias-ksp/TweakScale/issues/57) Implement Warning Dialogs (concluded)
		- 2.5.0.1
			- [#07](https://github.com/net-lisias-ksp/TweakScale/issues/7)	Update some patches to KSP 1.5 and 1.6 bug
			- [#41](https://github.com/net-lisias-ksp/TweakScale/issues/41) TweakScale is being summoned to scale parts without TweakScale module info?
			- [#42](https://github.com/net-lisias-ksp/TweakScale/issues/42) Crash Test for TweakScale - the Ground Breaking tests
		- 2.5.0.0
			- [#10](https://github.com/net-lisias-ksp/TweakScale/issues/10) Weird late ADDON-Binder issue
			- [#11](https://github.com/net-lisias-ksp/TweakScale/issues/11) Negative mass on parts.
			- [#21](https://github.com/net-lisias-ksp/TweakScale/issues/21) Check that :FOR[TWEAKSCALE] thingy on the patches
			- [#31](https://github.com/net-lisias-ksp/TweakScale/issues/31) Preventing being ran over by other mods
			- [#34](https://github.com/net-lisias-ksp/TweakScale/issues/34) New Sanity Check: duplicated properties]
			- [#35](https://github.com/net-lisias-ksp/TweakScale/issues/35) Check for new parts on KSP 1.7 (with Making History!) and add support to them
	+ **WARNING**
		- This can break your KSP, ruin your Windows, kill your pet, offend your mom  and poison your kids. :D
		- By the Holy Kerbol that enlighten us all, please use this only under my instructions, and only if I ask you to do so! Twice. :)
		- TweakScale **strongly** advises you to use [S.A.V.E](https://forum.kerbalspaceprogram.com/index.php?/topic/94997-171-save-automatic-backup-system-155-3121/) for regular backups of your savegames. Really. :)	
