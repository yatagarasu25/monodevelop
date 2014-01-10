
using System;
using Mono.Addins;

[assembly:AddinRoot ("Debugger.Gdb", 
	Namespace = "MonoDevelop",
	Version = MonoDevelop.BuildInfo.Version,
	Category = "Debugging")]

[assembly:AddinName ("GDB debugger support")]
[assembly:AddinDescription ("GDB debugger support")]

[assembly:AddinDependency ("Core", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("Ide", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("Debugger", MonoDevelop.BuildInfo.Version)]
