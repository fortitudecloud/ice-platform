using System;
using System.Text;

namespace Logica.Au.Mpire.Framework.Utilities

{
    /// <summary>
    /// SsoHelper holds methods that are useful when dealing with SSO related data, such as nodes, queues, keys, procedures, etc.
    /// </summary>
    /// <history>
    /// 	<change user="rcook" date="23 Oct 2009" tt="4680">Added MapProcedureName</change>
    /// </history>
    public static class SsoHelper
    {

        #region Queue Tags

        /// <summary>
        /// MakeQueueTag builds an SSO Queue Tag.  Code is taken directly from the SSO MakeTag method,
        /// but included here to prevent eliminate the need to link in the SSO libraries.
        /// This overload returns a Released queue tag.
        /// </summary>
        /// <param name="aNode">the iProcess Engine Node Name</param>
        /// <param name="aQueueName">the iProcess Engine Queue Name</param>
        /// <returns></returns>
        public static string MakeQueueTag(string aNode, string aQueueName)
        {
            return MakeQueueTag(aNode, aQueueName, true);
        }

        /// <summary>
        /// MakeQueueTag builds an SSO Queue Tag.  Code is taken directly from the SSO MakeTag method,
        /// but included here to prevent eliminate the need to link in the SSO libraries
        /// </summary>
        /// <param name="aNode">the iProcess Engine Node Name</param>
        /// <param name="aQueueName">the iProcess Engine Queue Name</param>
        /// <param name="aIsReleased">true for Released, false for Test</param>
        /// <returns></returns>
        public static string MakeQueueTag(string aNode, string aQueueName, bool aIsReleased)
        {
            StringBuilder builder = new StringBuilder();
            builder = builder.Append(aNode).Append("|").Append(aQueueName).Append("|");
            if (aIsReleased)
            {
                builder = builder.Append("R");
            }
            else
            {
                builder = builder.Append("T");
            }
            return builder.ToString();
        }

        /// <summary>
        /// Gets the Queue Name from a Queue Tag.
        /// </summary>
        /// <param name="queueTag">must be in format node|queue or node|queue|R</param>
        /// <returns></returns>
        public static string GetQueueNameFromQueueTag(string queueTag)
        {
            string[] tagParts = queueTag.Split('|');
            if (tagParts.Length < 2)
                throw new ArgumentException("Invalid Tag Format");
            return tagParts[1];
        }

        /// <summary>
        /// Gets the Node Name from a Queue Tag.
        /// </summary>
        /// <param name="queueTag">must be in format node|queue or node|queue|R</param>
        /// <returns></returns>
        public static string GetNodeNameFromQueueTag(string queueTag)
        {
            string[] tagParts = queueTag.Split('|');
            if (tagParts.Length < 2)
                throw new ArgumentException("Invalid Tag Format");
            return tagParts[0];
        }

        #endregion

        #region Work Item Tags

        public static string MakeWorkItemTag(string aNode, string aProcName, string aWorkQueue, bool aIsReleased, string aCaseNumber, string aMailId, string aStepName)
        {
            StringBuilder builder = new StringBuilder();
            builder = builder.Append(aNode).Append("|").Append(aProcName).Append("|").Append(aWorkQueue).Append("|");
            if (aIsReleased)
            {
                builder = builder.Append("R");
            }
            else
            {
                builder = builder.Append("T");
            }
            return builder.Append("|").Append(aCaseNumber).Append("|").Append(aMailId).Append("|").Append(aStepName).Append("|").Append("-1").Append("|").Append("-1").ToString();
        }

        #endregion

        #region Map Procedure Name

        /// <summary>
        /// Maps a procedure name (usually specified in a config file) to its new name.  The supplied
        /// procedure name should be in the format "oldproc,newproc".  "oldproc" will be returned if
        /// the parent procedure is in the old format (ie. prefixed with P or S), otherwise "newproc"
        /// will be returned.
        /// 
        /// This procedure has been abstracted here in case our naming approach changes.
        /// </summary>
        /// <param name="procedureName">single procedure name or two comma-separated procedure names</param>
        /// <param name="parentProcedureName">the main procedure name</param>
        /// <returns>the mapped procedure name</returns>
        public static string MapProcedureName(string procedureName, string parentProcedureName)
        {
            const string OLD_PROCEDURE_PREFIX_LIST = "PpSs";

            // exit if no procedure name specified
            if (String.IsNullOrEmpty(procedureName))
            {
                return procedureName;
            }

            // get list of supplied procedure names
            string[] procedureNames = procedureName.Split(new[] { ',' });

            // if only one procedure name was supplied, return it now
            if (procedureNames.Length <= 1)
            {
                return procedureName;
            }

            // if the parent procedure wasn't supplied, or if it starts with a P or an S (old style name)
            // return the first procedure name in the list
            if (String.IsNullOrEmpty(parentProcedureName) || OLD_PROCEDURE_PREFIX_LIST.IndexOf(parentProcedureName[0]) != -1)
            {
                return procedureNames[0];
            }
            else
            {
                return procedureNames[1];
            }

        }


        #endregion

        #region iProcess Markings

        /// <summary>
        /// Returns a date formatted for iProcess
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string iProcessDateString(DateTime date)
        {
            return (date.ToString("dd/MM/yyyy"));
        }

        /// <summary>
        /// Returns a time formatted for iProcess
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string iProcessTimeString(DateTime time)
        {
            return (time.ToString("HH:mm"));
        }

        /// <summary>
        /// Converts a boolean to the equivalent iProcess marking value of YES or NO
        /// </summary>
        public static string iProcessYesOrNo(bool yesNoBool)
        {
            return (yesNoBool ? "YES" : "NO");
        }

        /// <summary>
        /// Converts an iProcess marking value of YES or NO to an equivalent boolean value.
        /// </summary>
        public static bool iProcessYesOrNo(string yesNoString)
        {
            return (yesNoString.Equals("YES", StringComparison.InvariantCultureIgnoreCase));
        }

        #endregion
 }
}
