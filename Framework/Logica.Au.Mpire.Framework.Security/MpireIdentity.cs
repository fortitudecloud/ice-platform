using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Security;
using System;
using System.Security;
using System.Security.Principal;

namespace Logica.Au.Mpire.Framework.Security
{
    //
    // TT #329
    //
    // I have added 2 new property's to allow AuthenticateBySubmission which requires, customerno, password and email address all to match.
    //

	[Serializable()]
	public class MpireIdentity : System.Security.Principal.IIdentity
	{

		private string myAuthenticationType = null;
		private byte[] myCredentials = null;
		private bool myIsAuthenticated = false;
		private string myName = null;

        private string mySymmetricCredentials = null;
        private byte[] mySymmetricKey = null;

		public string AuthenticationType
		{

			get
			{

				return this.myAuthenticationType;

			}

			set
			{

				this.myAuthenticationType = value;

			}

		}

		public byte[] Credentials
		{

			get
			{

				return this.myCredentials;

			}

			set
			{

				this.myCredentials = value;

			}

		}

		public bool IsAuthenticated
		{

			get
			{

				return this.myIsAuthenticated;

			}

			set
			{

				this.myIsAuthenticated = value;

			}

		}

		public string Name
		{

			get
			{

				return this.myName;

			}

			set
			{

				this.myName = value;

			}

		}

        public byte[] MySymmetricKey
        {

            get
            {

                return this.mySymmetricKey;

            }

            set
            {

                this.mySymmetricKey = value;

            }

        }

        public string MySymmetricCredentials
        {

            get
            {

                return this.mySymmetricCredentials;

            }

            set
            {

                this.mySymmetricCredentials = value;

            }

        }

	}

}