using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul_._LINQ_.Properties
{
	static public class SettingsX
	{

		public static class Conn
		{
			public const string CFG_KEY = nameof(_nilnul_._LINQ_.Properties.Settings.Default.Conn);

			/// <summary>
			/// for asp.net, directly access to user settting  will end up with an exception (in this configuration, user settings is not allowed); however by retrieving the default value, there would be no issue.
			/// </summary>
			/// <returns></returns>
			static public string GetCfged()
			{
				return _nilnul_._LINQ_.Properties.Settings.Default.Properties[CFG_KEY].DefaultValue as string;
			}


		}
	}
}
