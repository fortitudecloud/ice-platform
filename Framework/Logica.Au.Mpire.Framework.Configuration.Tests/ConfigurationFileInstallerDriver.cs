using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Configuration;
using Logica.Au.Mpire.Framework.Configuration.Install;
using Logica.Au.Mpire.Framework.Configuration.Tests;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logica.Au.Mpire.Framework.Configuration.Tests
{

	[TestClass]
	public class ConfigurationFileInstallerDriver
	{

		[TestMethod]
		public void InstansiateInstaller()
		{

			ConfigurationFileInstaller installer = null;

			installer = new ConfigurationFileInstaller();
			installer.ConfigurationFile = "Ufe.exe.config";
			installer.Install(null);

			//Assertion.Assert(false);

		}

	}

}