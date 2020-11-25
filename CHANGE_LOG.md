# TweakScale :: Change Log

* 2020-1125: 2.5.0.29 Beta (Lisias) for KSP >= 1.4.4
	+ I missed a detail, I didn't accounted for the `attPos` atribute (moving an attached part with the "Move" tool). Fixed.
* 2020-1123: 2.5.0.28 Beta (Lisias) for KSP >= 1.4.4
	+ Scaled parts with Variants now correctly translates the attached part when applying variants #HURRAY
		- As long the part has no symmetry, when things get completely screwed up...
		- See [this comment](https://github.com/net-lisias-ksp/TweakScale/issues/42#issuecomment-732321477) on [Issue #42](https://github.com/net-lisias-ksp/TweakScale/issues/42) for details.
* 2020-1113: 2.5.0.27 Beta (Lisias) for KSP >= 1.4.4
	+ Fixes a regression on Chain Scaling introduced on .25 and passed undetected on .26.
	+ (Almost) implements changing variants on scaled part
		+ There's something missing yet that affects the repositioning, specially on the Mastodon. 
	+ Known Issues:
		- Scaling parts with variants that change attachment nodes have a glitch, affecting:
			- The Mastodon engine
			- The Structural Tubes
				- T-12
				- T-18
				- T-25
				- T-37
				- T-50
			- And probably more, as Add'Ons starts to use such feature.
			- See [this comment](https://github.com/net-lisias-ksp/TweakScale/issues/42#issuecomment-726428889) on [Issue #42](https://github.com/net-lisias-ksp/TweakScale/issues/42) for details.
		- Detaching and reattaching the Mastodon work arounds the problem on the engine.
		- Detaching and reattaching the parts attached to a scaled tube work arounds the problem with the tubes.
		- Things on KSP 1.9 are yet more problematic. [KSP Recall](https://github.com/net-lisias-ksp/KSP-Recall/issues/9) will tackle this down.
	+ This is a beta release, merging the latest fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.23
			- [#142](https://github.com/net-lisias-ksp/TweakScale/issues/142) Add ignoreResourcesForCost to the TweakScale module attributes
			- [#87](https://github.com/net-lisias-ksp/TweakScale/issues/87) Wrong default scales (partial)
		- 2.5.0.21
			- [#138](https://github.com/net-lisias-ksp/TweakScale/issues/138) Expand TweakScaleCompanion_NF#2 (suppress warnings due empty configs)
			- [#13](https://github.com/net-lisias-ksp/TweakScale/issues/13) Properly support ModulePartVariants #HURRAY
		- 2.5.0.20
			- [#137](https://github.com/net-lisias-ksp/TweakScale/issues/137) Prevent havoc from patches that changed the scaling on the prefab.
			- [#136](https://github.com/net-lisias-ksp/TweakScale/issues/136) Config getting skipped during creation. 
		- 2.5.0.16
			- [#125](https://github.com/net-lisias-ksp/TweakScale/issues/125) The new deactivation process (due sanity checks) is preventing parts with TweakScale deactivated to be attached 
		- 2.5.0.15
			- [#124](https://github.com/net-lisias-ksp/TweakScale/issues/124) Script error (TweakScale): OnDestroy() can not take parameters.
			- [#119](https://github.com/net-lisias-ksp/TweakScale/issues/119) Remove TweakScale's handler from the onEditorShipModified when the part is Destroyed
		- 2.5.0.14
			- [#115](https://github.com/net-lisias-ksp/TweakScale/issues/115) KSP 1.10 Support Status
			- [#114](https://github.com/net-lisias-ksp/TweakScale/issues/114) KSP 1.8 (and 1.9) rendered the Sanity Checks useless.
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
		- Bug reports for this release **should be issued on the [Issue #42](https://github.com/net-lisias-ksp/TweakScale/issues/42) only**, as development problems are not considered "bugs" and should not clutter the back log where real issues happening the field need to be tackled down
* 2020-1112: 2.5.0.26 Beta (Lisias) for KSP >= 1.4.4
	+ (Almost) implements changing variants on scaled part
		+ There's something missing yet that affects the repositioning, specially on the Mastodon. 
	+ Known Issues:
		- Scaling parts with variants that change attachment nodes have a glitch, affecting:
			- The Mastodon engine
			- The Structural Tubes
				- T-12
				- T-18
				- T-25
				- T-37
				- T-50
			- And probably more, as Add'Ons starts to use such feature.
			- See [this comment](https://github.com/net-lisias-ksp/TweakScale/issues/42#issuecomment-726428889) on [Issue #42](https://github.com/net-lisias-ksp/TweakScale/issues/42) for details.
		- Detaching and reattaching the Mastodon work arounds the problem on the engine.
		- Detaching and reattaching the parts attached to a scaled tube work arounds the problem with the tubes.
		- Things on KSP 1.9 are yet more problematic. [KSP Recall](https://github.com/net-lisias-ksp/KSP-Recall/issues/9) will tackle this down.
	+ This is a beta release, merging the latest fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.23
			- [#142](https://github.com/net-lisias-ksp/TweakScale/issues/142) Add ignoreResourcesForCost to the TweakScale module attributes
			- [#87](https://github.com/net-lisias-ksp/TweakScale/issues/87) Wrong default scales (partial)
		- 2.5.0.21
			- [#138](https://github.com/net-lisias-ksp/TweakScale/issues/138) Expand TweakScaleCompanion_NF#2 (suppress warnings due empty configs)
			- [#13](https://github.com/net-lisias-ksp/TweakScale/issues/13) Properly support ModulePartVariants #HURRAY
		- 2.5.0.20
			- [#137](https://github.com/net-lisias-ksp/TweakScale/issues/137) Prevent havoc from patches that changed the scaling on the prefab.
			- [#136](https://github.com/net-lisias-ksp/TweakScale/issues/136) Config getting skipped during creation. 
		- 2.5.0.16
			- [#125](https://github.com/net-lisias-ksp/TweakScale/issues/125) The new deactivation process (due sanity checks) is preventing parts with TweakScale deactivated to be attached 
		- 2.5.0.15
			- [#124](https://github.com/net-lisias-ksp/TweakScale/issues/124) Script error (TweakScale): OnDestroy() can not take parameters.
			- [#119](https://github.com/net-lisias-ksp/TweakScale/issues/119) Remove TweakScale's handler from the onEditorShipModified when the part is Destroyed
		- 2.5.0.14
			- [#115](https://github.com/net-lisias-ksp/TweakScale/issues/115) KSP 1.10 Support Status
			- [#114](https://github.com/net-lisias-ksp/TweakScale/issues/114) KSP 1.8 (and 1.9) rendered the Sanity Checks useless.
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
		- Bug reports for this release **should be issued on the [Issue #42](https://github.com/net-lisias-ksp/TweakScale/issues/42) only**, as development problems are not considered "bugs" and should not clutter the back log where real issues happening the field need to be tackled down
* 2020-1023: 2.5.0.25 Beta (Lisias) for KSP >= 1.4.4
	+ Correctly implements scaling Mass and Cost.
		- Again. 
	+ Fixes a regression where symmetry counterparts were not being scaled.
		- Thanks for the [report](https://github.com/net-lisias-ksp/TweakScale/issues/42#issuecomment-703414755), AccidentalDisassembly! 
	+ Fixes the Scale Chaining when non scalable parts are present.
	+ Known Issues:
		- Scaling parts with variants that change attachment nodes are still problematic at this moment affecting:
			- The Mastodon engine
			- The Structural Tubes
				- T-12
				- T-18
				- T-25
				- T-37
				- T-50
			- And probably more, as Add'Ons starts to use such feature.
		- Detaching and reattaching the Mastodon work arounds the problem on the engine.
		- Detaching and reattaching the parts attached to a scaled tube work arounds the problem with the tubes.
		- Things on KSP 1.9 are yet more problematic. [KSP Recall](https://github.com/net-lisias-ksp/KSP-Recall/issues/9) will tackle this down.
	+ This is a beta release, merging the latest fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.23
			- [#142](https://github.com/net-lisias-ksp/TweakScale/issues/142) Add ignoreResourcesForCost to the TweakScale module attributes
			- [#87](https://github.com/net-lisias-ksp/TweakScale/issues/87) Wrong default scales (partial)
		- 2.5.0.21
			- [#138](https://github.com/net-lisias-ksp/TweakScale/issues/138) Expand TweakScaleCompanion_NF#2 (suppress warnings due empty configs)
			- [#13](https://github.com/net-lisias-ksp/TweakScale/issues/13) Properly support ModulePartVariants #HURRAY
		- 2.5.0.20
			- [#137](https://github.com/net-lisias-ksp/TweakScale/issues/137) Prevent havoc from patches that changed the scaling on the prefab.
			- [#136](https://github.com/net-lisias-ksp/TweakScale/issues/136) Config getting skipped during creation. 
		- 2.5.0.16
			- [#125](https://github.com/net-lisias-ksp/TweakScale/issues/125) The new deactivation process (due sanity checks) is preventing parts with TweakScale deactivated to be attached 
		- 2.5.0.15
			- [#124](https://github.com/net-lisias-ksp/TweakScale/issues/124) Script error (TweakScale): OnDestroy() can not take parameters.
			- [#119](https://github.com/net-lisias-ksp/TweakScale/issues/119) Remove TweakScale's handler from the onEditorShipModified when the part is Destroyed
		- 2.5.0.14
			- [#115](https://github.com/net-lisias-ksp/TweakScale/issues/115) KSP 1.10 Support Status
			- [#114](https://github.com/net-lisias-ksp/TweakScale/issues/114) KSP 1.8 (and 1.9) rendered the Sanity Checks useless.
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
		- Bug reports for this release **should be issued on the [Issue #42](https://github.com/net-lisias-ksp/TweakScale/issues/42) only**, as development problems are not considered "bugs" and should not clutter the back log where real issues happening the field need to be tackled down
* 2020-0918: 2.5.0.24 Beta (Lisias) for KSP >= 1.4.4
	+ Alleviates a bit the scaling issues on parts with Variants with Attachment Nodes introduced on .23
		- Still don't works as it should, but now the nodes are not messed up, so savegames will be good now.
	+ Known Issues:
		- Scaling parts with variants that change attachment nodes is problematic at this moment affecting:
			- The Mastodon engine
			- The Structural Tubes
				- T-12
				- T-18
				- T-25
				- T-37
				- T-50
			- And probably more, as Add'Ons starts to use such feature.
		- Detaching and reattaching the Mastodon work arounds the problem on the engine.
		- Detaching and reattaching the parts attached to a scaled tube work arounds the problem with the tubes.
		- Things on KSP 1.9 are yet more problematic. [KSP Recall](https://github.com/net-lisias-ksp/KSP-Recall/issues/9) will tackle this down.
	+ This is a beta release, merging the latest fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.23
			- [#142](https://github.com/net-lisias-ksp/TweakScale/issues/142) Add ignoreResourcesForCost to the TweakScale module attributes
			- [#87](https://github.com/net-lisias-ksp/TweakScale/issues/87) Wrong default scales (partial)
		- 2.5.0.21
			- [#138](https://github.com/net-lisias-ksp/TweakScale/issues/138) Expand TweakScaleCompanion_NF#2 (suppress warnings due empty configs)
			- [#13](https://github.com/net-lisias-ksp/TweakScale/issues/13) Properly support ModulePartVariants #HURRAY
		- 2.5.0.20
			- [#137](https://github.com/net-lisias-ksp/TweakScale/issues/137) Prevent havoc from patches that changed the scaling on the prefab.
			- [#136](https://github.com/net-lisias-ksp/TweakScale/issues/136) Config getting skipped during creation. 
		- 2.5.0.16
			- [#125](https://github.com/net-lisias-ksp/TweakScale/issues/125) The new deactivation process (due sanity checks) is preventing parts with TweakScale deactivated to be attached 
		- 2.5.0.15
			- [#124](https://github.com/net-lisias-ksp/TweakScale/issues/124) Script error (TweakScale): OnDestroy() can not take parameters.
			- [#119](https://github.com/net-lisias-ksp/TweakScale/issues/119) Remove TweakScale's handler from the onEditorShipModified when the part is Destroyed
		- 2.5.0.14
			- [#115](https://github.com/net-lisias-ksp/TweakScale/issues/115) KSP 1.10 Support Status
			- [#114](https://github.com/net-lisias-ksp/TweakScale/issues/114) KSP 1.8 (and 1.9) rendered the Sanity Checks useless.
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
* 2020-0917: 2.5.0.23 Beta (Lisias) for KSP >= 1.4.4
	+ Fixes the DryCost problem introduced on .22
	+ Known Issues:
		- Scaling parts with variants that change attachment nodes is problematic at this moment, affecting:
			- The Mastodon engine
			- The Tubes
		- Detaching and reattaching the Mastodon work arounds the problem on the engine, but the Tubes are really problematic and I don't have a workaround for it by now.
	+ This is a beta release, merging the latest fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.23
			- [#142](https://github.com/net-lisias-ksp/TweakScale/issues/142) Add ignoreResourcesForCost to the TweakScale module attributes
			- [#87](https://github.com/net-lisias-ksp/TweakScale/issues/87) Wrong default scales (partial)
		- 2.5.0.21
			- [#138](https://github.com/net-lisias-ksp/TweakScale/issues/138) Expand TweakScaleCompanion_NF#2 (suppress warnings due empty configs)
			- [#13](https://github.com/net-lisias-ksp/TweakScale/issues/13) Properly support ModulePartVariants #HURRAY
		- 2.5.0.20
			- [#137](https://github.com/net-lisias-ksp/TweakScale/issues/137) Prevent havoc from patches that changed the scaling on the prefab.
			- [#136](https://github.com/net-lisias-ksp/TweakScale/issues/136) Config getting skipped during creation. 
		- 2.5.0.16
			- [#125](https://github.com/net-lisias-ksp/TweakScale/issues/125) The new deactivation process (due sanity checks) is preventing parts with TweakScale deactivated to be attached 
		- 2.5.0.15
			- [#124](https://github.com/net-lisias-ksp/TweakScale/issues/124) Script error (TweakScale): OnDestroy() can not take parameters.
			- [#119](https://github.com/net-lisias-ksp/TweakScale/issues/119) Remove TweakScale's handler from the onEditorShipModified when the part is Destroyed
		- 2.5.0.14
			- [#115](https://github.com/net-lisias-ksp/TweakScale/issues/115) KSP 1.10 Support Status
			- [#114](https://github.com/net-lisias-ksp/TweakScale/issues/114) KSP 1.8 (and 1.9) rendered the Sanity Checks useless.
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
* 2020-0905: 2.5.0.22 Beta (Lisias) for KSP >= 1.4.4
	+ Maintenance release, fixing some badly implemented features on the .21 one.  
* 2020-0905: 2.5.0.21 Beta (Lisias) for KSP >= 1.4.4 
	+ Raises the bar to KSP 1.4.4, as Variant with Mass and Costs started to be supported only from this version.
	+ This is a beta release, merging the latest fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.21
			- [#138](https://github.com/net-lisias-ksp/TweakScale/issues/138) Expand TweakScaleCompanion_NF#2 (suppress warnings due empty configs)
			- [#13](https://github.com/net-lisias-ksp/TweakScale/issues/13) Properly support ModulePartVariants #HURRAY
		- 2.5.0.20
			- [#137](https://github.com/net-lisias-ksp/TweakScale/issues/137) Prevent havoc from patches that changed the scaling on the prefab.
			- [#136](https://github.com/net-lisias-ksp/TweakScale/issues/136) Config getting skipped during creation. 
		- 2.5.0.16
			- [#125](https://github.com/net-lisias-ksp/TweakScale/issues/125) The new deactivation process (due sanity checks) is preventing parts with TweakScale deactivated to be attached 
		- 2.5.0.15
			- [#124](https://github.com/net-lisias-ksp/TweakScale/issues/124) Script error (TweakScale): OnDestroy() can not take parameters.
			- [#119](https://github.com/net-lisias-ksp/TweakScale/issues/119) Remove TweakScale's handler from the onEditorShipModified when the part is Destroyed
		- 2.5.0.14
			- [#115](https://github.com/net-lisias-ksp/TweakScale/issues/115) KSP 1.10 Support Status
			- [#114](https://github.com/net-lisias-ksp/TweakScale/issues/114) KSP 1.8 (and 1.9) rendered the Sanity Checks useless.
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
* 2020-0830: 2.5.0.20 Beta (Lisias) for KSP >= 1.4.1 
	+ Updating KSPe.Light for TweakScale
		- Needed as some Companions will need it soon. 
	+ Fixed mishaps on withdrawing `TweakScale` from insane parts
	+ Lifting the ban on KSP 1.10.1
	+ Fixing an error on handling Warnings and Houstons where a warning would occlude a Houston!
	+ New helpers for the Companions.
	+ Better (and safer) deactivation code using info gathered from [TweakScale](https://github.com/net-lisias-ksp/TweakScale/issues/125).
	+ Updating the Houston for KSP-Recall
		- Only KSP 1.9.x needs it, currently. 
	+ This is a beta release, merging the latest fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.20
			- [#137](https://github.com/net-lisias-ksp/TweakScale/issues/137) Prevent havoc from patches that changed the scaling on the prefab.
			- [#136](https://github.com/net-lisias-ksp/TweakScale/issues/136) Config getting skipped during creation. 
		- 2.5.0.16
			- [#125](https://github.com/net-lisias-ksp/TweakScale/issues/125) The new deactivation process (due sanity checks) is preventing parts with TweakScale deactivated to be attached 
		- 2.5.0.15
			- [#124](https://github.com/net-lisias-ksp/TweakScale/issues/124) Script error (TweakScale): OnDestroy() can not take parameters.
			- [#119](https://github.com/net-lisias-ksp/TweakScale/issues/119) Remove TweakScale's handler from the onEditorShipModified when the part is Destroyed
		- 2.5.0.14
			- [#115](https://github.com/net-lisias-ksp/TweakScale/issues/115) KSP 1.10 Support Status
			- [#114](https://github.com/net-lisias-ksp/TweakScale/issues/114) KSP 1.8 (and 1.9) rendered the Sanity Checks useless.
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
* 2020-0830: 2.5.0.19 Beta (Lisias) for KSP >= 1.4.1 
	+ **Withdrawn**
		- Superseded by 2.5.0.20. 
* 2020-0829: 2.5.0.18 Beta (Lisias) for KSP >= 1.4.1 
	+ Updating KSPe.Light for TweakScale
		- Needed as some Companions will need it soon. 
* 2020-0822: 2.5.0.17 Beta (Lisias) for KSP >= 1.4.1 
	+ Fixed mishaps on withdrawing `TweakScale` from insane parts
	+ Lifting the ban on KSP 1.10.1
	+ Fixing an error on handling Warnings and Houstons where a warning would occlude a Houston!
* 2020-0715: 2.5.0.16 Beta (Lisias) for KSP >= 1.4.1 
	+ New helpers for the Companions.
	+ Better (and safer) deactivation code using info gathered from [TweakScale](https://github.com/net-lisias-ksp/TweakScale/issues/125).
	+ Updating the Houston for KSP-Recall
		- Only KSP 1.9.x needs it, currently. 
* 2020-0711: 2.5.0.15 Beta (Lisias) for KSP >= 1.4.1 
	+ Huge, comprehensive overhaul of the whole patching system.
		- This will make my life **way** easier when adding support for new parts and detecting merge errors that started to plague my pull requests lately. 
	+ Added support for some missed parts from Stock and MH (see the previous point)
	+ Added support for the simplest parts from Serenity (no robotics yet)
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.15
			- [#124](https://github.com/net-lisias-ksp/TweakScale/issues/124) Script error (TweakScale): OnDestroy() can not take parameters.
			- [#119](https://github.com/net-lisias-ksp/TweakScale/issues/119) Remove TweakScale's handler from the onEditorShipModified when the part is Destroyed
		- 2.5.0.14
			- [#115](https://github.com/net-lisias-ksp/TweakScale/issues/115) KSP 1.10 Support Status
			- [#114](https://github.com/net-lisias-ksp/TweakScale/issues/114) KSP 1.8 (and 1.9) rendered the Sanity Checks useless.
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
* 2020-0625: 2.5.0.14 Beta (Lisias) for KSP >= 1.4.1 
	+ Module Manager is not distributed anymore.
		- A [Watch Dog](https://github.com/net-lisias-ksp/ModuleManagerWatchDog) is being distributed instead.
		- This will prevent users from running older versions of MM unattendly. Full history on [Forum](https://forum.kerbalspaceprogram.com/index.php?/topic/179030-ksp-141-tweakscale-under-lisias-management-24314-2020-0519/&do=findComment&comment=3798088).
	+ Fixed a pretty dumb mistake on a TWEAKSCALEBEHAVIOUR (ModuleGeneratorExtended).
		- Don't have a clue when I messed up, the first release of that file was working. :(
	+ Some smarter logging and warnings
		- The MM cache is now checked, and Warnings only popup when it is newer than 1 hour.
		- No more Dialog spamming.
		- Sorry being late on this.
	+ New "Houston" when running on KSP >= 1.9 without KSP Recall
		- It's the only way to prevent KSP to reset the Resources to the `prefab` state after scaling the parts! 
	+ New "Advise" when running on KSP >= 1.10
		- Given the numerous problems I still have to handle from KSP 1.8 and 1.9, I don't think it's wise to use TweakScale on KSP 1.10 without a lot of testing from my side first. Proceed with caution, and use [S.A.V.E.](https://forum.kerbalspaceprogram.com/index.php?/topic/94997-*) just in case.
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.14
			- [#115](https://github.com/net-lisias-ksp/TweakScale/issues/115) KSP 1.10 Support Status
			- [#114](https://github.com/net-lisias-ksp/TweakScale/issues/114) KSP 1.8 (and 1.9) rendered the Sanity Checks useless.
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
* 2020-0531: 2.5.0.13 Beta (Lisias) for KSP >= 1.4.1 
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.13
			- [TSC_FS#1](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/1) Weird issue with SXT parts using `FSBuoyancy`.
			- [TSC_FS#2](https://github.com/net-lisias-ksp/TweakScaleCompantion_FS/issues/2) Properly Support `FSBuoyancy`.
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
* 2020-0505: 2.5.0.12 Beta (Lisias) for KSP >= 1.4.1 
	+ Changes
		- Fixed a problem on KSP 1.9 Editor with Attachments on Parts with Variants. 
		- Fixed a pretty stupid mistake on handling TweakScaleRogueDuplicates
		- Refactoring code
		- Refactoring filesystem.
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.12
			- [#110](https://github.com/net-lisias-ksp/TweakScale/issues/110) Revert to Vehicle Assembly and Loading Craft are mangling the part attachments.
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
* 2020-0505: 2.5.0.11 Beta (Lisias) for KSP >= 1.4.1 
	+ Some new methods on `TweakScale Module` to make life easier to the TweakScale Companions.
	+ All non Squad related patches are now on EoL, and are expected to be deprecated soon.
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
		- 2.5.0.11
			- [#106](https://github.com/net-lisias-ksp/TweakScale/issues/106) Deprecate everything and the kitchen's sink (but Stock and DLC)
			- [#95](https://github.com/net-lisias-ksp/TweakScale/issues/95) Give some care to the Warnings system (rework) 
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
* 2020-0302: 2.5.0.9 Beta (Lisias) for KSP >= 1.4.1 
	+ Some care on documentation
	+ Some care on support Stock parts
	+ Fixing a nasty mistake on the default scale of the Mk3 Engine Mount (`adapterEngine`)
		- This can break existing savegames!
	+ NFS patches is now on EoL, and are expected to be deprecated soon.
	+ Some resilience on scaling parts
	+ Added Localisation Suport for EN-US and ZH-CN
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
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
* 2019-1104: 2.5.0.8 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
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
* 2019-0903: 2.5.0.6 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ Added support for hot-fixes - handcrafted patches to brute force a correct path when the normal way is not possible - as when an unmaintained ARR Add'On is involved on the mess.
		- New hot fix for [CxAerospace:Station Parts](https://forum.kerbalspaceprogram.com/index.php?/topic/138910-dev-halted13-cxaerospace-stations-parts-pack-v162-2017-5-24/page/31/) breaking [Bluedog_DB](https://forum.kerbalspaceprogram.com/index.php?/topic/122020-16x-bluedog-design-bureau-stockalike-saturn-apollo-and-more-v152-бруно-8feb2019/). 
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
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
* 2019-1010: 2.5.0.7 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
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
* 2019-0903: 2.5.0.6 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ Added support for hot-fixes - handcrafted patches to brute force a correct path when the normal way is not possible - as when an unmaintained ARR Add'On is involved on the mess.
		- New hot fix for [CxAerospace:Station Parts](https://forum.kerbalspaceprogram.com/index.php?/topic/138910-dev-halted13-cxaerospace-stations-parts-pack-v162-2017-5-24/page/31/) breaking [Bluedog_DB](https://forum.kerbalspaceprogram.com/index.php?/topic/122020-16x-bluedog-design-bureau-stockalike-saturn-apollo-and-more-v152-бруно-8feb2019/). 
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
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
* 2019-0813: 2.5.0.5 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ Added support for hot-fixes - handcrafted patches to brute force a correct path when the normal way is not possible - as when an unmaintained ARR Add'On is involved on the mess.
		- New hot fix for [CxAerospace:Station Parts](https://forum.kerbalspaceprogram.com/index.php?/topic/138910-dev-halted13-cxaerospace-stations-parts-pack-v162-2017-5-24/page/31/) breaking [Bluedog_DB](https://forum.kerbalspaceprogram.com/index.php?/topic/122020-16x-bluedog-design-bureau-stockalike-saturn-apollo-and-more-v152-бруно-8feb2019/). 
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
		- [#07](https://github.com/net-lisias-ksp/TweakScale/issues/7)	Update some patches to KSP 1.5 and 1.6 bug
		- [#10](https://github.com/net-lisias-ksp/TweakScale/issues/10) Weird late ADDON-Binder issue
		- [#11](https://github.com/net-lisias-ksp/TweakScale/issues/11) Negative mass on parts.
		- [#21](https://github.com/net-lisias-ksp/TweakScale/issues/21) Check that :FOR[TWEAKSCALE] thingy on the patches
		- [#31](https://github.com/net-lisias-ksp/TweakScale/issues/31) Preventing being ran over by other mods
		- [#34](https://github.com/net-lisias-ksp/TweakScale/issues/34) New Sanity Check: duplicated properties]
		- [#35](https://github.com/net-lisias-ksp/TweakScale/issues/35) Check for new parts on KSP 1.7 (with Making History!) and add support to them
		- [#41](https://github.com/net-lisias-ksp/TweakScale/issues/41) TweakScale is being summoned to scale parts without TweakScale module info?
		- [#42](https://github.com/net-lisias-ksp/TweakScale/issues/42) Crash Test for TweakScale - the Ground Breaking tests
		- [#47](https://github.com/net-lisias-ksp/TweakScale/issues/47) Count failed Sanity Checks as a potential problem. Warn user
		- [#48](https://github.com/net-lisias-ksp/TweakScale/issues/48) Backport the Heterodox Logging system into Orthodox (using KSPe.Light
		- [#49](https://github.com/net-lisias-ksp/TweakScale/issues/49) Check the Default patches for problems due wildcard!
		- [#50](https://github.com/net-lisias-ksp/TweakScale/issues/50) Check the patches for currently supported Add'Ons
		- [#51](https://github.com/net-lisias-ksp/TweakScale/issues/51) Implement a "Cancel" button when Actions are given to MessageBox
		- [#54](https://github.com/net-lisias-ksp/TweakScale/issues/54) [ERR \*\*FATAL\*\* link provided in KSP.log links to 404
		- [#56](https://github.com/net-lisias-ksp/TweakScale/issues/56) "Breaking Parts" patches
		- [#57](https://github.com/net-lisias-ksp/TweakScale/issues/57) Implement Warning Dialogs (concluded)
		- [#58](https://github.com/net-lisias-ksp/TweakScale/issues/58) Mk4 System Patch (addendum)
		- [#65](https://github.com/net-lisias-ksp/TweakScale/issues/65) Support for new Nertea's Cryo Engines
	+ **WARNING**
		- This can break your KSP, ruin your Windows, kill your pet, offend your mom  and poison your kids. :D
		- By the Holy Kerbol that enlighten us all, please use this only under my instructions, and only if I ask you to do so! Twice. :)
		- TweakScale **strongly** advises you to use [S.A.V.E](https://forum.kerbalspaceprogram.com/index.php?/topic/94997-171-save-automatic-backup-system-155-3121/) for regular backups of your savegames. Really. :)
* 2019-0084: 2.5.0.4 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
		- [#07](https://github.com/net-lisias-ksp/TweakScale/issues/7)	Update some patches to KSP 1.5 and 1.6 bug
		- [#10](https://github.com/net-lisias-ksp/TweakScale/issues/10) Weird late ADDON-Binder issue
		- [#11](https://github.com/net-lisias-ksp/TweakScale/issues/11) Negative mass on parts.
		- [#21](https://github.com/net-lisias-ksp/TweakScale/issues/21) Check that :FOR[TWEAKSCALE] thingy on the patches
		- [#31](https://github.com/net-lisias-ksp/TweakScale/issues/31) Preventing being ran over by other mods
		- [#34](https://github.com/net-lisias-ksp/TweakScale/issues/34) New Sanity Check: duplicated properties]
		- [#35](https://github.com/net-lisias-ksp/TweakScale/issues/35) Check for new parts on KSP 1.7 (with Making History!) and add support to them
		- [#41](https://github.com/net-lisias-ksp/TweakScale/issues/41) TweakScale is being summoned to scale parts without TweakScale module info?
		- [#42](https://github.com/net-lisias-ksp/TweakScale/issues/42) Crash Test for TweakScale - the Ground Breaking tests
		- [#47](https://github.com/net-lisias-ksp/TweakScale/issues/47) Count failed Sanity Checks as a potential problem. Warn user
		- [#48](https://github.com/net-lisias-ksp/TweakScale/issues/48) Backport the Heterodox Logging system into Orthodox (using KSPe.Light
		- [#49](https://github.com/net-lisias-ksp/TweakScale/issues/49) Check the Default patches for problems due wildcard!
		- [#50](https://github.com/net-lisias-ksp/TweakScale/issues/50) Check the patches for currently supported Add'Ons
		- [#51](https://github.com/net-lisias-ksp/TweakScale/issues/51) Implement a "Cancel" button when Actions are given to MessageBox
		- [#54](https://github.com/net-lisias-ksp/TweakScale/issues/54) [ERR \*\*FATAL\*\* link provided in KSP.log links to 404
		- [#56](https://github.com/net-lisias-ksp/TweakScale/issues/56) "Breaking Parts" patches
		- [#57](https://github.com/net-lisias-ksp/TweakScale/issues/57) Implement Warning Dialogs (concluded)
		- [#58](https://github.com/net-lisias-ksp/TweakScale/issues/58) Mk4 System Patch (addendum)
		- [#65](https://github.com/net-lisias-ksp/TweakScale/issues/65) Support for new Nertea's Cryo Engines
	+ **WARNING**
		- This can break your KSP, ruin your Windows, kill your pet, offend your mom  and poison your kids. :D
		- By the Holy Kerbol that enlighten us all, please use this only under my instructions, and only if I ask you to do so! Twice. :)
		- TweakScale **strongly** advises you to use [S.A.V.E](https://forum.kerbalspaceprogram.com/index.php?/topic/94997-171-save-automatic-backup-system-155-3121/) for regular backups of your savegames. Really. :)
* 2019-0721: 2.5.0.3 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues:
		- [#07](https://github.com/net-lisias-ksp/TweakScale/issues/7)	Update some patches to KSP 1.5 and 1.6 bug
		- [#10](https://github.com/net-lisias-ksp/TweakScale/issues/10) Weird late ADDON-Binder issue
		- [#11](https://github.com/net-lisias-ksp/TweakScale/issues/11) Negative mass on parts.
		- [#21](https://github.com/net-lisias-ksp/TweakScale/issues/21) Check that :FOR[TWEAKSCALE] thingy on the patches
		- [#31](https://github.com/net-lisias-ksp/TweakScale/issues/31) Preventing being ran over by other mods
		- [#34](https://github.com/net-lisias-ksp/TweakScale/issues/34) New Sanity Check: duplicated properties]
		- [#35](https://github.com/net-lisias-ksp/TweakScale/issues/35) Check for new parts on KSP 1.7 (with Making History!) and add support to them
		- [#41](https://github.com/net-lisias-ksp/TweakScale/issues/41) TweakScale is being summoned to scale parts without TweakScale module info?
		- [#42](https://github.com/net-lisias-ksp/TweakScale/issues/42) Crash Test for TweakScale - the Ground Breaking tests
		- [#47](https://github.com/net-lisias-ksp/TweakScale/issues/47) Count failed Sanity Checks as a potential problem. Warn user
		- [#48](https://github.com/net-lisias-ksp/TweakScale/issues/48) Backport the Heterodox Logging system into Orthodox (using KSPe.Light
		- [#49](https://github.com/net-lisias-ksp/TweakScale/issues/49) Check the Default patches for problems due wildcard!
		- [#50](https://github.com/net-lisias-ksp/TweakScale/issues/50) Check the patches for currently supported Add'Ons
		- [#51](https://github.com/net-lisias-ksp/TweakScale/issues/51) Implement a "Cancel" button when Actions are given to MessageBox
		- [#54](https://github.com/net-lisias-ksp/TweakScale/issues/54) [ERR \*\*FATAL\*\* link provided in KSP.log links to 404
		- [#56](https://github.com/net-lisias-ksp/TweakScale/issues/56) "Breaking Parts" patches
		- [#57](https://github.com/net-lisias-ksp/TweakScale/issues/57) Implement Warning Dialogs (concluded)
		- [#58](https://github.com/net-lisias-ksp/TweakScale/issues/58) Mk4 System Patch (addendum)
	+ **WARNING**
		- This can break your KSP, ruin your Windows, kill your pet, offend your mom  and poison your kids. :D
		- By the Holy Kerbol that enlighten us all, please use this only under my instructions, and only if I ask you to do so! Twice. :)
		- TweakScale **strongly** advises you to use [S.A.V.E](https://forum.kerbalspaceprogram.com/index.php?/topic/94997-171-save-automatic-backup-system-155-3121/) for regular backups of your savegames. Really. :)
* 2019-0622: 2.5.0.2 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues (some already fixed, others not yet):
		- [#07](https://github.com/net-lisias-ksp/TweakScale/issues/7)	Update some patches to KSP 1.5 and 1.6 bug
		- [#10](https://github.com/net-lisias-ksp/TweakScale/issues/10) Weird late ADDON-Binder issue
		- [#11](https://github.com/net-lisias-ksp/TweakScale/issues/11) Negative mass on parts.
		- [#21](https://github.com/net-lisias-ksp/TweakScale/issues/21) Check that :FOR[TWEAKSCALE] thingy on the patches
		- [#31](https://github.com/net-lisias-ksp/TweakScale/issues/31) Preventing being ran over by other mods
		- [#34](https://github.com/net-lisias-ksp/TweakScale/issues/34) New Sanity Check: duplicated properties]
		- [#35](https://github.com/net-lisias-ksp/TweakScale/issues/35) Check for new parts on KSP 1.7 (with Making History!) and add support to them
		- [#41](https://github.com/net-lisias-ksp/TweakScale/issues/41) TweakScale is being summoned to scale parts without TweakScale module info?
		- [#42](https://github.com/net-lisias-ksp/TweakScale/issues/42) Crash Test for TweakScale - the Ground Breaking tests
		- [#49](https://github.com/net-lisias-ksp/TweakScale/issues/49) Check the Default patches for problems due wildcard!
		- [#51](https://github.com/net-lisias-ksp/TweakScale/issues/51) Implement a "Cancel" button when Actions are given to MessageBox
		- [#54](https://github.com/net-lisias-ksp/TweakScale/issues/54) [ERR \*\*FATAL\*\* link provided in KSP.log links to 404
		- [#56](https://github.com/net-lisias-ksp/TweakScale/issues/56) "Breaking Parts" patches
		- [#31](https://github.com/net-lisias-ksp/TweakScale/issues/31) Preventing being ran over by other mods ***WiP***
		- [#57](https://github.com/net-lisias-ksp/TweakScale/issues/57) Implement Warning Dialogs ***WiP***
	+ **WARNING**
		- This can break your KSP, ruin your Windows, kill your pet, offend your mom  and poison your kids. :D
		- By the Holy Kerbol that enlighten us all, please use this only under my instructions, and only if I ask you to do so! Twice. :)
* 2019-0508: 2.5.0.1 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ This is a beta release, merging the latest release fixes and aiming to test solutions and check stability issues related to the following issues (some already fixed, others not yet):
		- [#07](https://github.com/net-lisias-ksp/TweakScale/issues/7)	Update some patches to KSP 1.5 and 1.6 bug
		- [#10](https://github.com/net-lisias-ksp/TweakScale/issues/10) Weird late ADDON-Binder issue
		- [#11](https://github.com/net-lisias-ksp/TweakScale/issues/11) Negative mass on parts.
		- [#21](https://github.com/net-lisias-ksp/TweakScale/issues/21) Check that :FOR[TWEAKSCALE] thingy on the patches
		- [#31](https://github.com/net-lisias-ksp/TweakScale/issues/31) Preventing being ran over by other mods
		- [#34](https://github.com/net-lisias-ksp/TweakScale/issues/34) New Sanity Check: duplicated properties]
		- [#41](https://github.com/net-lisias-ksp/TweakScale/issues/41) TweakScale is being summoned to scale parts without TweakScale module info?
		- [#42](https://github.com/net-lisias-ksp/TweakScale/issues/42) Crash Test for TweakScale - the Ground Breaking tests
	+ **WARNING**
		- This can break your KSP, ruin your Windows, kill your pet, offend your mom  and poison your kids. :D
		- By the Holy Kerbol that enlighten us, please use this only under my instructions, and only if I ask you to do so! Twice. :)
* 2019-0608: 2.4.3.0 (Lisias) for KSP >= 1.4.1
	+ This is an emergencial Release due a Show Stopper issue (see Issue #34 below) with some new features.
	+ Adding features:
		- [#7](https://github.com/net-lisias-ksp/TweakScale/issues/7) Adding support for new Parts from KSP 1.5 and 1.6 (and Making History)! (**finally!**)
		- [#35](https://github.com/net-lisias-ksp/TweakScale/issues/35) Checking for new Parts on KSP 1.7 (none found)
			- (Serenity is Work In Progress)
		- Adding KSPe.Light support for some UI features. 
	+ Fixing bugs:
		- [#31](https://github.com/net-lisias-ksp/TweakScale/issues/31) Preventing being ran over by other mods
		- [#34](https://github.com/net-lisias-ksp/TweakScale/issues/34) New Sanity Check: duplicated properties
	+ [Known Issues](https://github.com/net-lisias-ksp/TweakScale/blob/master/KNOWN_ISSUES.md) update:
		- A new and definitively destructive interaction was found due some old or badly written patches ends up injecting TweakScale properties **twice** on the Node.
* 2019-0508: 2.5.0.0 Beta (Lisias) for KSP >= 1.4.1 TEST RELEASE
	+ This is a beta release, aiming to test solutions and check stability issues related to the following issues (some already fixed, others not yet):
		- [#07](https://github.com/net-lisias-ksp/TweakScale/issues/7)	Update some patches to KSP 1.5 and 1.6 bug
		- [#10](https://github.com/net-lisias-ksp/TweakScale/issues/10) Weird late ADDON-Binder issue
		- [#11](https://github.com/net-lisias-ksp/TweakScale/issues/11) Negative mass on parts.
		- [#21](https://github.com/net-lisias-ksp/TweakScale/issues/21) Check that :FOR[TWEAKSCALE] thingy on the patches
		- [#31](https://github.com/net-lisias-ksp/TweakScale/issues/31) Preventing being ran over by other mods
		- [#34](https://github.com/net-lisias-ksp/TweakScale/issues/34) New Sanity Check: duplicated properties
		- [#35](https://github.com/net-lisias-ksp/TweakScale/issues/35) Check for new parts on KSP 1.7 (with Making History!) and add support to them.
	+ **WARNING**
		- This can break your KSP, ruin your Windows, kill your pet, offend your mom  and poison your kids. :D
		- By the Holy Kerbol that enlighten us, please use this only under my instructions, and only if I ask you to do so! Twice. :)
* 2019-0505: 2.4.2.0 (Lisias) for KSP >= 1.4.1
	+ Adding features:
		- [#32](https://github.com/net-lisias-ksp/TweakScale/issues/32) Near Future Aeronautics Patches
	+ Fixing bugs:
		- [#20](https://github.com/net-lisias-ksp/TweakScale/issues/20)	Duplicated TweakScale support on some parts
		- [#23](https://github.com/net-lisias-ksp/TweakScale/issues/23) Unhappy merge on TweakScale exponents
		- [#24](https://github.com/net-lisias-ksp/TweakScale/issues/24) Fix that duplicated support on some parts
		- [#30](https://github.com/net-lisias-ksp/TweakScale/issues/30) Prevent incorrectly initialized Modules to be used
	+ [Known Issues](https://github.com/net-lisias-ksp/TweakScale/blob/master/KNOWN_ISSUES.md) update:
		- Users of "Classic" [Infernal Robotics](https://github.com/MagicSmokeIndustries/InfernalRobotics) should avoid scaling parts to "Small -" or Krakens will be released.
			- [Infernal Robotics/Next](https://github.com/meirumeiru/InfernalRobotics) fixes this issue.   
* 2019-0216: 2.4.1.0 (Lisias) for KSP >= 1.4.1
	+ Adding 1.875 scale as default (being now a Stock size on MH, it makes sense to properly acknowledge it). Suggested by Tyko.
		- Closing issue [#3](https://github.com/net-lisias-ksp/TweakScale/issues/3)
	+ Adding support for Stock Alike Station Parts. Courtesy of Speadge.
		- Closing issue [#8](https://github.com/net-lisias-ksp/TweakScale/issues/8)
	+ Fixed a critical craft corruption (even flying ones) as TweakScale is sometimes being injected twice (or even more) into a part. This patch does not fix the duplicity, but prevent your crafts from being corrupted once a fix is applied (yeah - fixing the bug would cause craft corruption without this patch!)
		- Closing issue [#20](https://github.com/net-lisias-ksp/TweakScale/issues/20)
* 2018-1229: 2.4.0.7 (Lisias) for KSP >= 1.4.1
	+ KSP 1.6 (partial) support certified.
	+ Actively reverting support in runtime for parts with problematic or unsupported modules.
		- Closing issue [#9](https://github.com/net-lisias-ksp/TweakScale/issues/9)
		- Closing issue [#11](https://github.com/net-lisias-ksp/TweakScale/issues/11)
		- Closing issue [#12](https://github.com/net-lisias-ksp/TweakScale/issues/12)
	+ Lifting the Max KSP restriction on the `.version` file.
	+ Updating Module Manager to 3.1.1
* 2018-1027: 2.4.0.6 (Lisias) for KSP 1.4.1+; 1.5
	+ KSP 1.5 support certified.
	+ Reverting some misunderstood versioning.
	+ Moving the repository to the Official Headquarters
	+ Some performance (and type safety) enhancements
	+ Fixes on the MX-3L Hermes (NFT) as proposed by NachtRaveVL
	+ Fixed an issue when Making History is present.
		- With additional failsafe measure 
	+ Bumping Release to assume official maintenance and mark the URL change.
	+ **Properly** Reverting KSPe dependency (for while, at least).
		- Unholy user settings files are back to the Sacred Land of GameData. Repent, Sinner!!
* 2018-1027: 2.4.0.5 (Lisias) for KSP 1.4.1+; 1.5
	* Move on, nothing to see here! =P 
* 2018-1025: 2.4.0.4 (Lisias) for KSP 1.4
	+ DITCHED
* 2018-1019: 2.4.0.3 (Lisias) for KSP 1.4
	+ DITCHED
* 2018-1016: 2.4.0.2 (Lisias) for KSP 1.4
	+ DITCHED
* 2018-1016: 2.4.0.1 (Lisias) for KSP 1.4
	+ DITCHED
* 2018-0816: 2.3.12.1 (Lisias) for KSP 1.4.x
	+ Saving xml config files under <KSP_ROOT>/PluginData Hierarchy
		- Added hard dependency for [KSP API Extensions/L](https://github.com/net-lisias-ksp/KSPAPIExtensions). 
	+ Removed deprecated DLLs
		- Needs TweakableEverything installed now
		- A small hack:
			- one DLL was moved to a new Plugin directory inside the dependency to overcome the loading order problem.
			- a better solution is WiP for the next release
	+ Removed Support code for deleted KSP functionalities
		- Not needed anymore? (RiP) 
* 2018-0416: 2.3.12 (Pellinor) for KSP 1.4.2
	+ configs for new parts
	+ fix for exceptions
	+ fix for solar panels
	+ recompile for KSP 1.4.2
* 2018-0314: 2.3.10 (Pellinor) for KSP 1.4.1
	+ don't overwrite stuff if the exponent is zero
	+ recompile against KSP 1.4.1
* 2018-0309: 2.3.9 (Pellinor) for KSP 1.4.0
	+ fix interaction with stock ModulePartVariants
* 2018-0307: 2.3.8 (Pellinor) for KSP 1.4.0
	+ [TweakScale-v2.3.8.zip](https://github.com/pellinor0/TweakScale/files/1790799/TweakScale-v2.3.8.zip)
		- recompile for KSP 1.4
		- a few patches for new parts
	+ Known issues:
		- the new stock texture switch messes up attachment nodes on scaled parts
		- (first switching and then scaling seems to work)
* 2017-1013: 2.3.7 (Pellinor) for KSP 1.3.1
	+ recompile for KSP 1.3.1
	+ only complain about negative dry mass if the number is significant
* 2017-0527: 2.3.6 (Pellinor) for KSP 1.3.0
	+ recompile for KSP 1.3
	+ lots of player-submitted patches (thanks eberkain, mikeloeven, OliverPA77)
	+ set SRB thrust exponent to 3 (so both TWR and burntime are preserved now)
	+ added a few null checks
	+ scaling support for resource lists (for drills and converters)
	+ Fix: don't scale mass if the part has a MFT module
	+ TWEAKSCALEEXPONENTS should now affect not only the mentioned module but also derived modules
	+ (e.g. the exponent for ModuleRCS also applies for ModuleRCSFX)
* 2017-0123: 2.3.4 (Pellinor) for KSP 1.2.2
	+ fix exponent for stock ModuleGenerator
	+ found a way to write dryCost of the prefab early enough (fixes a cost issue with KIS)
	+ functions to ask the prefab about stats of scaled parts (meant for KIS)
* 2016-1217: 2.3.3 (Pellinor) for KSP 1.2.2
	+ recompile for KSP 1.2.2
	+ fix cost bug with fsfuelswitch
	+ (ignore resource cost because FSfuelSwitch takes it into account)
	+ added a bit of documentation
* 2016-1102: 2.3.2 (Pellinor) for KSP 1.2
	+ recompile for KSP1.2.1
	+ update patches for RLA-Stockalike, OPT
	+ exponents for ModuleRCSFX
	+ remove an obsolete exponent
	+ remove patches for relay antennas since scaling of their main function does not work
	+ (which is relaying signals when the antenna is part of an unloaded vessel)
* 2016-1021: 2.3.1 (Pellinor) for KSP 1.2
	+ exponent for groundHeightOffset (fixes landing gears clipping the runway at launch)
	+ fix for node positions reverting when cloning a part
	+ antennas: refresh range display
	+ antennas: tweak exponent (so that downscaled antennas are a bit less overpowered)
* 2016-1015: 2.3 (Pellinor) for KSP 1.2
	+ fix for wheel colliders
	+ fix wheelMotor torque and ec consumption
	+ CrewCapacity: has a configurable exponent now
	+ CrewCapacity: additional seats are not shown in the editor (stock limitation)
	+ scaling support for FloatCurve (for wheel torque)
	+ scaling support for and int values (for CrewCapacity)
	+ fix scaling of input/outputResources (new stock "resHandler", e.g. consumption of reaction wheels)
	+ move workaround for stock UI_ScaleEdit bug into the plugin
* 2016-0624: 2.2.13 (Pellinor) for KSP 1.1.3
	+ recompile for KSP 1.1.3
	+ fix for solar panels
	+ rewrite of chainScaling: propagate relative scaling factor to child parts
* 2016-0519: 2.2.12 (Pellinor) for KSP 1.1.2
	+ scaling of crew capacity (hardcoded to use the mass exponent for now)
	+ Fix patches scale crewed parts with an exponent of 2 for crew and mass
	+ (not realistic but fits better to stock balance than 3). In any case mass/kerbal is hardcoded to be preserved.
	+ scaling of the IVA overlay
	+ support for new firespitter biplane
	+ support for HLAirships module (thanks SpannerMonkey)
	+ some missing patches for B9 (thanks BlowFish)
	+ (did some reordering but still need to sort through the content)
	+ fixed a few patches
	+ reorganize some patches into their own folder
	+ (B9, Squad including nasa and spacePlanePlus)
	+ small optimisation: disable partModule in flight if not scaled
* 2016-0512: 2.2.11 (Pellinor) for KSP 1.1.2
	+ remove obsolete IFS exponents
	+ fix bug in partMessage for MFT
	+ expose API via the part message system
	+ fix for mirrored parts
	+ workaround for tweakable bug: extra scaleFactor 500% for the free scaletypes
	+ (so the range from 200-400% is usable again)
	+ don't interfere if other mods illegaly write part.mass. Print a warning in this case
	+ fix thrust for moduleRCS (new maxFuelFlow exponent like for moduleEngines)
* 2016-0505: 2.2.10 (Pellinor) for KSP 1.1.2
	+ basic wheel scaling: scaled wheels work but still behave strange. They roll, are pretty close to touching the ground, and are able to bounce.
	+ make sure the exponents are applied before notifying other mods through the API (needed for interaction with FAR)
	+ MFT support changed to TweakScale using their API (instead of the other way round)
	+ tweaked downscaled science parts to be a little more expensive
* 2016-0430: 2.2.9 (Pellinor) for KSP 1.1.2
	+ fix for drag cube scaling
	+ update right click menu after rescale
	+ recompile for 1.1.2
	+ cleanup for mass scaling
* 2016-0424: 2.2.7.2 (Pellinor) for KSP 1.1
	+ fix scaling of the root part
* 2016-0423: 2.2.7.1 (Pellinor) for KSP 1.1
	+ update for 1.1
	+ Workaround for the camera breaking (root part scaling is still broken)
	+ support for new stock parts
	+ shrinking science and probe cores makes them more expensive
	+ (only changed for stock so far)
	+ update for the OPT v1.8 test release
* 2016-0102: 2.2.6 (Pellinor) for KSP 1.0.5
	+ Support for NF-Construction
	+ update for NFT Octo-Girders
	+ fix for infinite loop between TweakScale and MFT
	+ fix for engineer's report mass display
* 2015-1109: 2.2.5 (Pellinor) for KSP 0.90
	+ recompile for KSP 1.0.5 (still using the old KspApiExtensions)
	+ update MM
	+ patches for the new parts
* 2015-1030: 2.2.4 (Pellinor) for KSP 0.90
	+ Fix for scaling of lists. This should fix the trouble with cost of FSFuelSwitch parts.
	+ Partial fix for editor mass display not updating
	+ new file Examples.cfg with frequently used custom patches
	+ Removed MM switch for scaleable crew pods
	+ update of NFT patches
	+ Fix scaling of resource lists
	+ support for a few missing stock parts
	+ partial support for a few other mods
	+ stock radiator support
	+ Scale ImpactRange for stock drill modules (this is what determines if the drill has ground contact or not)
	+ scale captureRange for claw (this should fix 3.75m claws not grappling)
	+ removed brakingTorque exponent (not needed and breaks stock tweakable)
* 2015-0626: 2.2.1 (Pellinor) for KSP 0.90
	+ update for KSP 1.0.4
	+ KSP 1.0 support: scaling of dragCubes
	+ exponent -0.5 for heatProduction
	+ support for HX parts from B9-Aerospace
	+ support for firespitter modules: FSEngine, FSPropellerTweak, FSAlternator
	+ remove support for KAS connector port so it stays stackable in KIS
	+ a few missing part patches
	+ update NF-Solar patches (some parts were renamed)
	+ catch exceptions on rescale
	+ survive duplicate part config
* 2015-0502: 2.1 (Pellinor) for KSP 0.90
	+ recompile for KSP 1.0.2
	+ new stock part
* 2015-0501: 2.0.1 (Pellinor) for KSP 0.90
	+ restored maxThrust exponent to fix the editor CoT display
	+ added patch for new KIS container
	+ survive mistyped scaleTypes
* 2015-0430: 2.0 (Pellinor) for KSP 0.90
	+ recompile for KSP 1.0
	+ new TWEAKSCALEBEHAVIOR nodes (engines, decouplers, boosters)
	+ scale DryCost with the mass exponent if there is no DryCost exponent defined
	+ fuel fraction of tanks is now preserved [breaking]
	+ move part patches into their own directory
	+ KIS support
	+ proper MM switches for mod exponents
	+ removed KSPI support (will be distributed with KSPI)
	+ scaleExponents for NF-electrical capacitors
	+ cleanup of stock scaleExponents
	+ support for the new stock modules
	+ support for the changed engine modules
* 2015-0420: 1.53 (Pellinor) for KSP 0.90
	+ download address for version file
	+ added missing RLA configs
	+ only touch part cost of the part is rescaled
	+ fix for repairing incomplete scaletypes
	+ support for stock decoupling modules
	+ OPT support
	+ remove RF scale exponents (RF does its own support)
* 2015-0310: 1.52.1 (Pellinor) for KSP 0.90
	+ No changelog provided
* 2015-0308: 1.52 (Pellinor) for KSP 0.90
	+ New Tweakable with more flexible intervals.
	+ All scaletypes use scaleFactors now, max/minScale is obsolete.
	+ Better handling of incomplete or inconsistent scaletype configs.
	+ Vessels now survive a change of defaultScale.
	+ less persistent data
* 2015-0226: 1.51.1 (Pellinor) for KSP 0.90
	+ added KSP-AVC support
	+ freescale slider Increments are now part of the scaletype config
	+ added stock mk3 configs
	+ auto- and chain scaling off by default (the hotkeys are leftCtrl-L and leftCtrl-K)
	+ auto- and chain scaling restricted to parts of the same scaletype
	+ Changed the 'stack' scaletype to free scaling
	+ Moved stock adapters to stack scaletype
	+ Changed surface scaletype to free scaling
	+ added an example discrete scaletype for documentation, because there is none left
	+ fixed error spam with regolith & KAS
	+ removed duplicate MM patch for IntakeRadialLong
	+ hopefully restricted the camera bug to scaled root parts
* 2015-0225: 1.51 (Pellinor) for KSP 0.90
	+ added KSP-AVC support
	+ added stock mk3 configs
	+ autoscaling
		- auto- and chain scaling off by default
		- auto- and chain scaling restricted to parts of the same scaletype
		- rewrote GetRelativeScaling based on the nodes of the prefab part
	+ scaletypes
		- freescale slider Increments are now part of the scaletype config
		- Change the 'stack' scaletype to free scaling
		- Move stock adapters to stack scaletype
		- Change surface scaletype to free scaling
		- added an example discrete scaletype for documentation, because there is none left in the default configs
		- if min/maxScale are missing in a free scaletype take min/max of the scaleFactors list
	+ fixes
		- fixed error spam with scalable parts from KAS containers
		- removed duplicate MM patch for IntakeRadialLong
		- hopefully restricted the camera bug to scaled root parts
* 2014-1224: 1.50 (Biotronic) for KSP 0.24
	+ Fixed erroneous placement of attach nodes when duplicating parts.
* 2014-1218: 1.49 (Biotronic) for KSP 0.24
	+ Now saving hotkey states correctly
	+ 'Free' scaletype actually free
	+ Fixed bug in OnStart
	+ First attempt at scaling offsets
* 2014-1216: 1.48 (Biotronic) for KSP 0.24
	+ Added .90 support! (screw Curse for not having that option yet)(Admin Edit: Curse added it! File updated to reflect the proper version)
	+ Cleaned up autoscale and chain scaling!
* 2014-1117: 1.47 (Biotronic) for KSP 0.24
	+ Removed [RealChute](http://forum.kerbalspaceprogram.com/threads/57988) support
	+ Fixed a bug where TweakScale would try to set erroneous values for some fields and properties, which notably affected [Infernal Robotics](http://forum.kerbalspaceprogram.com/threads/37707)
	+ Fixed a bug where cloned fuel tanks would have erroneous volumes.
* 2014-1116: 1.46 (Biotronic) for KSP 0.24
	+ Fixed an issue where features were incorrectly scaled upon loading a ship,
	+ Scaling a part now scales its children if they have the same size.
	+ Parts now automatically guess which size they should be.
* 2014-1115: 1.45 (Biotronic) for KSP 0.24
	+ New Features:
		- Now updating UI sliders for float values.
		- Better support for [KSP Interstellar](http://forum.kerbalspaceprogram.com/threads/43839).
		- Added support for [TweakableEverything](http://forum.kerbalspaceprogram.com/threads/64711).
		- Added support for [FireSpitter](http://forum.kerbalspaceprogram.com/threads/24551)'s FSFuelSwitch.
* 2014-1010: 1.44 (Biotronic) for KSP 0.24
	+ Version 1.44:
		- Updated for KSP 0.25
		- Added ability to not update certain properties when a specific partmodule is on the part.
	+ Thanks a lot to NathanKell, who did all the work on this release!
* 2014-0824: 1.43 (Biotronic) for KSP 0.24
	+ Version 1.43:
		- Added licence file (sorry, mods!)
		- No longer chokes on null particle emitters.
* 2014-0815: 1.41 (Biotronic) for KSP 0.24
	+ Version 1.41:
		- Fixed scaling of Part values in unnamed TWEAKSCALEEXPONENTS blocks.
* 2014-0813: 1.40 (Biotronic) for KSP 0.24
	+ Version 1.40:
		- Removed [Karbonite](http://forum.kerbalspaceprogram.com/threads/89401) cfg, since that project does its own TweakScale config.
* 2014-0812: 1.39 (Biotronic) for KSP 0.24
	+ Version 1.39:
		- Fixed cost calculation for non-full tanks.
* 2014-0812: 1.38 (Biotronic) for KSP 0.24
	+ Version 1.38:
		- Added scaling of FX.
		- Added support for [Banana for Scale](http://forum.kerbalspaceprogram.com/threads/89570).
		- Updated [Karbonite](http://forum.kerbalspaceprogram.com/threads/87335) support.
		- Fixed a bug where no scalingfactors available due to tech requirements would lead to unintended consequences.
* 2014-0805: 1.37 (Biotronic) for KSP 0.24
	+ Version 1.37:
		- Updated cost calculation.
* 2014-0804: 1.36 (Biotronic) for KSP 0.24
	+ Version 1.36:
		- Updated [Real Fuels](http://forum.kerbalspaceprogram.com/threads/64118) and [Modular Fuel Tanks](http://forum.kerbalspaceprogram.com/threads/64117) support.
		- Added [KSPX](http://forum.kerbalspaceprogram.com/threads/30472) support.
* 2014-0803: 1.35 (Biotronic) for KSP 0.24
	+ Corrected cost calculation.
	+ Updated to [KSPAPIExtensions 1.7.0](http://forum.kerbalspaceprogram.com/threads/81496)
* 2014-0802: 1.34 (Biotronic) for KSP 0.24
	+ Version 1.34:
		- Fixed a bug where repeated scaling led to inaccurate placing of child parts.
		- Added [Karbonite](http://forum.kerbalspaceprogram.com/threads/87335) support.
* 2014-0728: 1.33 (Biotronic) for KSP 0.24
	+ Updated RealFuels support for 7.1
* 2014-0725: 1.32 (Biotronic) for KSP 0.24
	+ Version 1.32:
		- Updated KSPAPIExtension for 0.24.2 support.
* 2014-0725: 1.31 (Biotronic) for KSP 0.24
	+ Fixed a bug where parts with defaultScale inaccessible due to tech requirements were incorrectly scaled.
* 2014-0725: 1.30 (Biotronic) for KSP 0.24
	+ Updated KSPAPIExtensions with 24.1 support.
	+ Re-enabled Real Fuels support.
	+ Added support for IPartCostModifier.
* 2014-0724: 1.29 (Biotronic) for KSP 0.24
	+ Fixed Modular Fuel Tanks support.
* 2014-0724: 1.28 (Biotronic) for KSP 0.24
	+ Fixed more cross-platform bugs.
	+ Added [Tantares Space Technologies](http://forum.kerbalspaceprogram.com/threads/80550).
* 2014-0723: 1.27 (Biotronic) for KSP 0.24
	+ Fixed a bug on non-Windows platforms.
* 2014-0723: 1.26 (Biotronic) for KSP 0.24
	+ Version 1.26:
		- Fixed typo in DefaultScales.cfg that caused som parts to baloon ridiculously.
		- Added support for updated NFT and KW Rocketry
* 2014-0723: 1.25 (Biotronic) for KSP 0.24
	+ Version 1.25:
		- Modular Fuel Tanks](http://forum.kerbalspaceprogram.com/threads/64117) yet again supported! (Still waiting for Real Fuels)
		- Refactored IRescalable system to be easier for mod authors.
		- Fixed a bug where one field could have multiple exponents, and thus be rescaled multiple times.
* 2014-0721: 1.23 (Biotronic) for KSP 0.24
	+ Version 1.23:
		- Duplicate TweakScale dlls no longer interfere.
* 2014-0720: 1.22 (Biotronic) for KSP 0.24
	+ Version 1.22
		- Fixed tanks that magically refill.
		- Fixed technology requirements are too slow.
		- Updated KSPAPIExtensions to make TweakScale play nicely with other mods.
* 2014-0718: 1.21 (Biotronic) for KSP 0.24
	+ Version 1.21:
		- Updated for 0.24
		- Now supports global, per-part, and per-scaletype scaling of features (like mass, buoyancy, thrust, etc)
* 2014-0613: 1.20 (Biotronic) for KSP 0.23.5
	+ Version 1.20:
		- New algorithm for rescaling attach nodes. Tell me what you think!
		- Added [Deadly Reentry Continued](http://forum.kerbalspaceprogram.com/threads/54954) and [Large Structural/Station Components](http://forum.kerbalspaceprogram.com/threads/34664).
* 2014-0606: 1.19 (Biotronic) for KSP 0.23.5
	+ Version 1.19:
		- Added support for tech requirements for non-freescale parts.
* 2014-0606: 1.18 (Biotronic) for KSP 0.23.5
	+ Version 1.18
		- Factored out Real Fuels and Modular Fuel Tanks support to separate dlls.
* 2014-0603: 1.17 (Biotronic) for KSP 0.23.5
	+ Version 1.17:
		- Fixed bug where attachment nodes were incorrectly scaled after reloading. This time with more fix!
		- Added support for [Near Future Technologies](http://forum.kerbalspaceprogram.com/threads/52042).
* 2014-0603: 1.16 (Biotronic) for KSP 0.23.5
	+ Version 1.16:
		- Fixed bug where attachment nodes were incorrectly scaled after reloading.
* 2014-0603: 1.15 (Biotronic) for KSP 0.23.5
	+ Version 1.15:
		- Finally squished the bug where crafts wouldn't load correctly. This bug is present in 1.13 and 1.14, and affects certain parts from Spaceplane+, MechJeb, and KAX.
* 2014-0603: 1.14 (Biotronic) for KSP 0.23.5
	+ Version 1.14:
		- Fixed a bug where nodes with the same name were moved to the same location regardless of correct location. (Only observed with KW fairing bases, but there could be others)
* 2014-0602: 1.13 (Biotronic) for KSP 0.23.5
	+ Version 1.13:
		- Added support for [MechJeb](http://forum.kerbalspaceprogram.com/threads/12384), [Kerbal Aircraft eXpanion](http://forum.kerbalspaceprogram.com/threads/76668), [Spaceplane+](http://forum.kerbalspaceprogram.com/threads/80796), [Stack eXTensions](http://forum.kerbalspaceprogram.com/threads/79542), [Kerbal Attachment System](http://forum.kerbalspaceprogram.com/threads/53134), [Lack Luster Labs](http://forum.kerbalspaceprogram.com/threads/24906), [Firespitter](http://forum.kerbalspaceprogram.com/threads/24551), [Taverio's Pizza and Aerospace](http://forum.kerbalspaceprogram.com/threads/15348), [Better RoveMates](http://forum.kerbalspaceprogram.com/threads/75873), and [Sum Dum Heavy Industries Service Module System](http://forum.kerbalspaceprogram.com/threads/48357).
		- Fixed a bug where Modular Fuel Tanks were not correctly updated.
* 2014-0602: 1.12 (Biotronic) for KSP 0.23.5
	+ Version 1.12:
		- Added support for [КОСМОС](http://forum.kerbalspaceprogram.com/threads/24970).
		- No longer scaling heatDissipation, which I was informed was a mistake.
* 2014-0601: 1.11 (Biotronic) for KSP 0.23.5
	+ 1.11:
		- Removed silly requirement of 'name = *' for updating all elements of a list.
		- Added .cfg controlled scaling of Part fields.
* 2014-0601: 1.10 (Biotronic) for KSP 0.23.5
	+ 1.10:
		- Added support for nested fields.
* 2014-0531: 1.9 (Biotronic) for KSP 0.23.5
	+ Version 1.9
		- Fixed bugs in 1.8 where duplication of parts caused incorrect scaling.
* 2014-0530: 1.8 (Biotronic) for KSP 0.23.5
	+ Version 1.8:
		- Fixed a bug where rescaleFactor caused incorrect scaling.
		- Added (some) support for [Kethane](http://forum.kerbalspaceprogram.com/threads/23979-Kethane-Pack-0-8-5-Find-it-mine-it-burn-it!-0-23-5-\(ARM\)-compatibility-update) parts.
* 2014-0522: 1.7 (Biotronic) for KSP 0.23.5
	+ No changelog provided
* 2014-0522: 1.6 (Biotronic) for KSP 0.23.5
	+ Version 1.6:
		- Fixed a problem where parts were scaled back to their default scale after loading, duplicating and changing scenes.
* 2014-0520: 1.5.0.1 (Biotronic) for KSP 0.23.5
	+ Version 1.5.0.1:
		- Fixed a bug in 1.5
		- Changed location of KSPAPIExtensions.dll
* 2014-0520: 1.5 (Biotronic) for KSP 0.23.5
	+ Version 1.5
		- Changed from hardcoded updaters to a system using cfg files.
* 2014-0520: 1.4 (Biotronic) for KSP 0.23.5
	+ Version 1.4
		- Fixed incompatibilities with GoodspeedTweakScale
* 2014-0519: 1.3 (Biotronic) for KSP 0.23.5
	+ Version 1.3
		- Fixed a bug where parts would get rescaled to stupid sizes after loading.
		- Breaks compatibility with old version of the plugin (pre-1.0) and GoodspeedTweakScale. :(
* 2014-0518: 1.2 (Biotronic) for KSP 0.23.5
	+ Version 1.2 (2014-05-18, 22:00 UTC):
		- Fixed default scale for freeScale parts.
		- Fixed node sizes, which could get absolutely redonkulous. Probably not perfect now either.
		- B9, Talisar Cargo Transportation Solutions, and NASA Module Manager configs.
		- Now does scaling at onload, removing the problem where the rockets gets embedded in the ground and forcibly eject at launch.
		- Fixed a silly bug in surface scale type.
* 2014-0516: 1.1 (Biotronic) for KSP 0.23.5
	+ Version 1.1:
		- Added scaling support for [B9 Aerospace ](http://forum.kerbalspaceprogram.com/threads/25241)and [Talisar's Cargo Transportation Solutions](http://forum.kerbalspaceprogram.com/threads/77505)
		- Will now correctly load (some) save games using an older version of the plugin.
* 2014-0516: 1.0 (Biotronic) for KSP 0.23.5
	+ No changelog provided

- - -
	WiP : Work In Progress
	RiP : Research In Progress

