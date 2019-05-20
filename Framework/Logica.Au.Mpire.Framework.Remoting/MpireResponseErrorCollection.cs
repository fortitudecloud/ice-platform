using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;
using System;
using System.Collections;
using System.Text;
using System.Threading;

namespace Logica.Au.Mpire.Framework.Remoting
{

	[Serializable()]
	public class MpireResponseErrorCollection : System.Collections.ICollection
	{
		
		private ArrayList myCollection = null;

		public MpireResponseErrorCollection()
		{

			myCollection = new ArrayList();

		}

		public void Add(MpireResponseError error)
		{

			this.myCollection.Add(error);
			
		}

		public void Add(string message)
		{

			MpireResponseError error = null;

			error = new MpireResponseError(message);
			this.Add(error);

		}

		public void Add(string format, params object[] args)
		{
			string message = String.Format(format, args);

			this.Add(message);
		}


		public void AddRange(MpireResponseErrorCollection errors)
		{

			this.myCollection.AddRange(errors);

		}

		public void CopyTo(Array array, int index)
		{

			this.myCollection.CopyTo(array, index);

		}

		public IEnumerator GetEnumerator()
		{

			return this.myCollection.GetEnumerator();

		}
		
		public override string ToString()
		{
			
			StringBuilder builder = null;
			string errorsString = null;
			
			builder = new StringBuilder();
			foreach (MpireResponseError error in this)
			{
				
				builder.AppendFormat("{0}\n", error);
				
			}
			
			errorsString = builder.ToString();
			
			return errorsString;
			
		}

		public int Count
		{

			get
			{

				return this.myCollection.Count;

			}

		}

		public bool IsSynchronized
		{

			get
			{

				return this.myCollection.IsSynchronized;

			}

		}

		public MpireResponseError this[int index]
		{

			get
			{

				return (MpireResponseError)this.myCollection[index];

			}

		}

		public object SyncRoot
		{

			get
			{

				return this.myCollection.SyncRoot;

			}

		}

	}

}
