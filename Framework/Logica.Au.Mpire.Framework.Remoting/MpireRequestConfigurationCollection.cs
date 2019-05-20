using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;
using System;
using System.Collections;

namespace Logica.Au.Mpire.Framework.Remoting
{

	public class MpireRequestConfigurationCollection : System.Collections.Specialized.NameObjectCollectionBase
	{

		public void Add(string name, MpireRequestConfiguration configuration)
		{

			this.BaseAdd(name, configuration);

		}

		public void Clear()
		{

			this.BaseClear();

		}

		public MpireRequestConfiguration Get(int index)
		{

			MpireRequestConfiguration configuration = null;
			
			configuration = (MpireRequestConfiguration)this.BaseGet(index);

			return configuration;

		}

		public MpireRequestConfiguration Get(string name)
		{

			MpireRequestConfiguration configuration = null;
			
			configuration = (MpireRequestConfiguration)this.BaseGet(name);

			return configuration;
		
		}

		public string[] GetAllKeys()
		{

			string[] keys = null;

			keys = this.BaseGetAllKeys();

			return keys;

		}

		public MpireRequestConfiguration[] GetAllValues()
		{

			MpireRequestConfiguration[] configs = null;

			configs = (MpireRequestConfiguration[])this.BaseGetAllValues(typeof(MpireRequestConfiguration));

			return configs;

		}

		public string GetKey(int index)
		{

			string key = null;

			key = this.GetKey(index);

			return key;

		}

		public MpireRequestConfiguration this[string name]
		{

			get
			{

				MpireRequestConfiguration configuration = null;

				configuration = this.Get(name);

				return configuration;

			}

			set
			{

				this.Set(name, value);

			}

		}

		public MpireRequestConfiguration this[int index]
		{

			get
			{

				MpireRequestConfiguration configuration = null;

				configuration = this.Get(index);

				return configuration;

			}

			set
			{

				this.Set(index, value);

			}

		}

		public bool HasKeys()
		{

			bool hasKeys = false;

			hasKeys = this.BaseHasKeys();

			return hasKeys;

		}

		public void Remove(string name)
		{

			this.BaseRemove(name);

		}

		public void RemoveAt(int index)
		{

			this.BaseRemoveAt(index);

		}

		public void Set(int index, MpireRequestConfiguration configuration)
		{

			this.BaseSet(index, configuration);

		}

		public void Set(string name, MpireRequestConfiguration configuration)
		{

			this.BaseSet(name, configuration);

		}

	}

}