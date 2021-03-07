using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul_._LINQ_.cfg.connTxt_
{
	/* 
https://forums.asp.net/t/1484703.aspx?Deploying+Library+Assembly+s+config+File
 Within the BL code, I use OpenMappedExeConfiguration to open the BL config file.  The mapped config file name is constructed by using the executing assembly’s Location property with “.config” concatenated at the end.  This approach works fine for applications other than the web application.  The web app is presenting some interesting differences.  First, the bl.dll file is deployed to the web site’s bin folder, but the bl.dll.config file is not.  In addition, the executing assembly’s Location property is pointing to a shadow copy of the bl.dll file.
 So, I have a two part question.  What is the best way to get the bl.dll.config file deployed to the web site’s bin folder in the first place?  And, how do I ensure that it is shadow copied to the temp folder for execution?  This second part is not crucial.  If it’s a lot of effort to cause the config file to be shadow copied, I could use the executing assembly’s CodeBase property to construct the config file path, assuming the config file got deployed properly. *//*
 It's valid for an assembly to open any config file it likes using the OpenExeConfiguration method. This way that can access their own config rather than the one implicitly available from the executing assembly. This isn't commonly done, but there's nothing to stop you doing it.

		 */

	/*
	 * https://stackoverflow.com/questions/21627502/what-use-has-the-default-assembly-dll-config-file-for-net-assemblies
	 * 
	 * The default values are built into the .dll file. *//*
	 * 
	 * If your assembly is functioning correctly without the config file then it sounds like it has a sensible set of default value that it uses when it cant find the appropriate configuration.*/

	/*
	 by default, it is looking at the config file defined for the AppDomain: my.exe.config – Marc Gravell♦ Feb 27 '09 at 11:04 
1
In particular, the AppDomain.CurrentDomain.SetupInformation.ConfigurationFile setting. – Marc Gravell♦ Feb 27 '09 at 11:06 
	 */
	static public class _DefaultX
	{
		/// <summary>
		/// if in Web, web.config of "default" is used
		/// </summary>
		/// <returns></returns>
		static public string OnAppCfg()
		{
			return System.Configuration.ConfigurationManager.ConnectionStrings[_nilnul_._LINQ_._cfg_.connTxt_._DefaultX.NAME].ConnectionString;
		}
		static public string OnLibCfg() {
			// The dllPath can't just use Assembly.GetExecutingAssembly().Location as ASP.NET doesn't copy the config to shadow copy path
			var dllPath = new Uri(Assembly.GetExecutingAssembly().GetName().CodeBase).LocalPath;
			var dllConfig = ConfigurationManager.OpenExeConfiguration(dllPath);

			return dllConfig.ConnectionStrings.ConnectionStrings[_nilnul_._LINQ_._cfg_.connTxt_._DefaultX.NAME ].ConnectionString;
		}

	}

}
