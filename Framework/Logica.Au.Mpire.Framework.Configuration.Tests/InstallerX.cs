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

namespace Logica.Au.Mpire.Framework.Configuration.Tests
{

	[RunInstaller(true)]
	public class InstallerX : System.Configuration.Install.Installer
	{

		public InstallerX()
		{

			this.Installers.Add(new ConfigurationFileInstaller());

		}

	}

}