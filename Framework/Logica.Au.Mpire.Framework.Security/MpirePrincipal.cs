using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Security;
using System;
using System.Collections;
using System.Security;
using System.Security.Principal;

namespace Logica.Au.Mpire.Framework.Security
{

	[Serializable()]
	public class MpirePrincipal : System.Security.Principal.IPrincipal
	{

		private DateTime myExpiry = DateTime.MinValue;
		private MpireIdentity myIdentity = null;
		private string[] myRoles = null;
		private byte[] mySignature = null;

		public object[] GetSignableData()
		{

			object[] signableData = null;

			signableData = new object[3]
				{
					this.myExpiry,
					this.myIdentity,
					this.myRoles
				};

			return signableData;

		}
		
		public bool IsInRole(string role)
		{

			bool isInRole = false;

			if (Array.IndexOf(this.myRoles, role) != -1)
			{

				isInRole = true;

			}
			else
			{

				isInRole = false;

			}

			return isInRole;

		}

		public DateTime Expiry
		{

			get
			{

				return this.myExpiry;

			}

			set
			{

				this.myExpiry = value;

			}

		}

		public IIdentity Identity
		{

			get
			{

				return (IIdentity)this.myIdentity;

			}

			set
			{

				this.myIdentity = (MpireIdentity)value;

			}

		}

		public string[] Roles
		{

			get
			{

				return this.myRoles;

			}

			set
			{

				this.myRoles = value;

			}

		}

		public byte[] Signature
		{

			get
			{
		
				return this.mySignature;

			}

			set
			{

				this.mySignature = value;

			}

		}

	}

}