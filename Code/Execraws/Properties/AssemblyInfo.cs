using System;
using System.Reflection;

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyTitle("Execraws")]
[assembly: AssemblyDescription("A module that executes a list of raw commands upon connection to the IRC server.")]
[assembly: AssemblyCompany("Zack Loveless")]
[assembly: AssemblyProduct("Execraws Module")]
[assembly: AssemblyCopyright("Copyright © Zack Loveless. All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyVersion("1.0")]
