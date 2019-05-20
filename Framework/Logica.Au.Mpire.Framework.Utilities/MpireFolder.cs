using System;
using System.IO;
using System.Security; 


namespace Logica.Au.Mpire.Framework.Utilities
{
	/// <summary>
	/// Summary description for MpireFolder.
	/// </summary>
	public class MpireFolder
	{
		private MpireFolder()
		{
		}



		/// <summary>
		/// Method  CreateLocalSubDirectory checks if a subdirectory identified by PathToFolder
		/// exists, and if not it attempts to create the subdirectory. It will only create a 
		/// leaf node directory - it requires that the root to parent, inclusive, already exist.
		/// </summary>
		/// <return>static void </return>
		/// <author>Peter Cassar-Smith</author>
		/// <history>16/03/2004 10:41:00 AM Created. </history>
		/// <param name=Path type=string></param>
		/// 
		public static void CreateLocalSubDirectory( string Path )
		{

			if( Path == null || Path == string.Empty ) 
			{
				throw new ArgumentNullException ( "Path", "Argument \"Path\" may not be null or empty.");
			}

			if( Path.StartsWith(@"\\") ) 
			{
				throw new ArgumentException ( "Argument \"Path\" may not reference a UNC path - CreateLocalFolder supports folder creation on the local filesystem only.");
			}

			DirectoryInfo folder = new DirectoryInfo(Path);
 
			// if the folder exists we do nothing
			if( !folder.Exists )
			{
				// enforce the restriction that the parent directory exists
				if( !folder.Parent.Exists )
				{
					throw new ArgumentException ("Can not create a subdirectory - the parent directory \"" + folder.Parent.FullName + "\" does not exist.");  
				}
				// get the subdirectory name from path
				string SubDirectory = Path.Substring(Path.LastIndexOf("\\")+1);
				bool PathCreated = false;
				string ErrMsg = null;

				// try to create the folder
				try
				{
					folder.Parent.CreateSubdirectory( SubDirectory );
					PathCreated = true;
				}
				
				#region The many possible exceptions ...

				// exception interpretations based on the method documentation. More helpfull than the raw exception info.
				
				catch( ArgumentNullException  )
				{
					ErrMsg = string.Format("Path is null.");
				}
				catch( ArgumentException  )
				{
					ErrMsg = string.Format("Path \"{0}\" does not specify a valid file path or contains invalid characters.",Path); 
				}
				catch( DirectoryNotFoundException  )
				{
					ErrMsg = string.Format("Part of the path \"{0}\" is not found.", Path); 
				}
				catch( PathTooLongException  )
				{
					ErrMsg = "The specified path, file name, or both are too long. After full qualification, each must be less than 256 characters."; 
				}
				catch( IOException  )
				{
					ErrMsg = string.Format("A file or directory already has the name specified by path \"{0}\".",Path); 
				}
				catch( SecurityException   )
				{
					ErrMsg = string.Format("The user does not have permission to create the sub directory \"{0}\"",Path);
				}

				#endregion

				// if we failed, repack the exception interpretation into out own and throw it back
				if( !PathCreated )
					throw new Exception( ErrMsg );
			}

		}




		/// <summary>
		/// Method  CreateDirectory attempts to create a directory and any parent directories
		/// specified in the Path argument, and accepts UNC paths.
		/// </summary>
		/// <return>static void </return>
		/// <author>Peter Cassar-Smith</author>
		/// <history>16/03/2004 11:42:20 AM Created. </history>
		/// <param name=Path type=string></param>
		/// 
		public static void CreateDirectory( string Path )
		{

			if( Path == null || Path == string.Empty ) 
			{
				throw new ArgumentNullException ( "Path", "Argument \"Path\" may not be null or empty.");
			}
			 
			// if the folder exists we do nothing
			if( !Directory.Exists(Path) )
			{
				
				bool PathCreated = false;
				string ErrMsg = null;

				// try to create the folder
				try
				{
					Directory.CreateDirectory( Path );
					PathCreated = true;
				}
				
				#region The many possible exceptions ...

					// exception interpretations based on the method documentation. More helpfull than the raw exception info.
				catch( ArgumentNullException )
				{
					ErrMsg = string.Format("Path is null.");
				}
				catch( ArgumentException  )
				{
					ErrMsg = string.Format("Path \"{0}\" does not specify a valid file path or contains invalid characters.",Path); 
				}
				catch( DirectoryNotFoundException  )
				{
					ErrMsg = string.Format("Part of the path \"{0}\" is not found.", Path); 
				}
				catch( PathTooLongException  )
				{
					ErrMsg = "The specified path, file name, or both are too long. After full qualification, each must be less than 256 characters."; 
				}
				catch( IOException  )
				{
					ErrMsg = string.Format("Path \"{0}\"is read-only or is not empty.",Path); 
				}
				catch( SecurityException )
				{
					ErrMsg = string.Format("The user does not have permission to create the sub directory \"{0}\"",Path);
				}
				catch( NotSupportedException )
				{
					ErrMsg = "Can not create a directory with only the colon (:) character."; 
				}
				#endregion

				// if we failed, repack the exception interpretation into out own and throw it back
				if( !PathCreated )
					throw new Exception( ErrMsg );
			}

		}

	}

}
