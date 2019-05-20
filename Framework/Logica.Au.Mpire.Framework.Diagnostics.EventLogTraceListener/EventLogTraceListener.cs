using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Logica.Au.Mpire.Framework.Diagnostics.EventLogTraceListener
{

	public class EventLogTraceListener : System.Diagnostics.TraceListener
	{
		//Eventlog source name
		string m_source = null;
		string[] m_categoryList = null;
	

		public EventLogTraceListener()
			: this("Err")
		{
		}
		
		public EventLogTraceListener(string categoryList)
		{
			// Get the name of the topmost executing assembly
			string assemblyName = GetAssemblyName();
			
			//Default source name
			m_source = assemblyName;

			// Determine the Categories we want to look for
			if (categoryList != null && categoryList != String.Empty)
			{
				// The list of categories can be seperated by , or ;
				char[] seps = {',', ';'};

				// Remove spaces in the categories
				categoryList = categoryList.Replace(" ", "");
				// Split the supplied Category List
				m_categoryList = categoryList.ToUpper().Split(seps);
			}
		}


		public override void Write(string msg, string category)
		{
			//don't do anything
		}

		public override void Write(string msg)
		{
			//don't do anything
		}


		
		public override void WriteLine(string msg, string category)
		{
			// Search for the supplied category in the list of wanted Categories
			if (Array.IndexOf(m_categoryList, category.ToUpper()) != -1)
			{
				try
				{
					if (!EventLog.SourceExists(m_source))
					{
						EventLog.CreateEventSource(m_source, "Application");
					}

					EventLogEntryType eventType = ParseEventCategory(category);

					// Write the event to the event log
					EventLog.WriteEntry(m_source, msg, eventType);

				}
				catch (Exception)
				{
					//don't do anything
				}
			}
		}


		public override void WriteLine(string msg)
		{
			//don't do anything
		}


		private EventLogEntryType ParseEventCategory(string category)
		{
			EventLogEntryType type = EventLogEntryType.Information;

			switch (category.ToUpper())
			{
				case "ERR" :
					type = EventLogEntryType.Error;
					break;
				case "WRN" :
					type = EventLogEntryType.Warning;
					break;
				default:
					type = EventLogEntryType.Information;
					break;
			}

			return (type);
		}
		
		private string GetAssemblyName()
		{
			string name = null;

			Assembly assembly = null;

			assembly = Assembly.GetEntryAssembly();

			if (assembly == null)
			{
				// For assemblys that aren't executed via a simple invocation, we can't find the Entry Assembly, so find another way
				int frameCount = 1;

				do
				{
					// Step up the stack frame until we are out of this assembly
					StackFrame frame = new StackFrame(++frameCount);

					assembly = frame.GetMethod().ReflectedType.Assembly;

				} while (assembly == Assembly.GetExecutingAssembly());
			}

			// We have the assembly, so get it's name
			AssemblyName assemblyName = assembly.GetName();

			name = assemblyName.Name;


			return (name);
		}

	}


}