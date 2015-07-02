# UnityFody
An implementation of fody that runs from unity.

As fody is written in 4.0+, plugins written for fody will not work by default - they must be modified to work with 3.5.

### Plugin branch setup
To ensure that setting up a plugin branch is consistent, the mono cecil dlls in this repository (or 3.5 configuration builds from the mono cecil repository) should be referenced from a root level lib folder in that branch. The PropertyChanged branch has this, if an example is needed.

## Unity compatible plugin branches
* [PropertyChanged](https://github.com/jbruening/PropertyChanged/tree/3.5_compat)


## Settings
the FodyWeavers.xml can accept the following attributes in the \<Weavers> element:
* ProcessAssemblies - comma separate list of file names for which dlls to actually process. Other dlls found in search paths are skipped.  By default, this is "Assembly-CSharp.dll,Assembly-CSharp-firstpass.dll" if the attribute is not specified.
