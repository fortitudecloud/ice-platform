using Logica;
using Logica.Au;
using Logica.Au.Mpire;
using Logica.Au.Mpire.Framework;
using Logica.Au.Mpire.Framework.Remoting;
using System;

namespace Logica.Au.Mpire.Framework.Remoting
{

	public enum RequestResult
	{

		Success,				// Response succeeded.
		Failure,				// Response failed.  Errors collection should detail reasons for failure.
		Unknown					// Response status not yet set, or request not yet processed.
	}


	public enum RequestFailureReason
	{
		None,					// No additional Information available
		NoDataAvailable,		// No data was returned for the given Request
		ConcurrencyException,	// A database concurrency problem occured
		ConfigurationException,	// Remoting Configuration not valid
		ConstraintException,	// A dataset Constraint Exception occured
		RemotingException,		// Remote Server unavailable
		SecurityException,		// The Request encountered a security exception
		UnexpectedException,		// Any other type of exception
		SystemNotAvailableException,// The requested external system is not currently available
		ValidationFailure,		// The request failed data validation
        FinancialUpdateFailure  // Indicates that an issue was found searching for a Financial update
	}

}