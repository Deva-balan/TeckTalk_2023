
/***********************************************************************************************************
 * Created by       : Justine
 * Created On       : 26 Apr 2023
 *
 * Reviewed By      :
 * Reviewed On      :
 *
 * Purpose          : To have Error log methods that handles error in the file path and file name
 ***********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTalk.Framework.Helper
{
	/// <summary>
	/// Summary description for ErrorLog new 
	/// </summary>
	public class ErrorLog 
	{
		#region Properties

		private static string LogFilePath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "\\ErrorLog", "\\", DateTime.Today.Year + "\\", DateTime.Today.Month);

		private string LogFileName = string.Empty;
		private string LogAPIFileName = string.Empty;

		#endregion Properties

		public ErrorLog()
		{
			//check if the directory exists
			if (!Directory.Exists(LogFilePath))
			{
				Directory.CreateDirectory(LogFilePath);
			}
			LogFileName = string.Concat(LogFilePath, "\\", "Log_", DateTime.Today.ToShortDateString().Replace("/", "_"), ".log");
			LogAPIFileName = string.Concat(LogFilePath, "\\", "APILog_", DateTime.Today.ToShortDateString().Replace("/", "_"), ".log");
		}

		/// <summary>
		/// This method is to write the passed error message and other details of error occurence
		/// </summary>
		/// <param name="sMessage">string - Error message</param>
		///
		public void WriteLog(string sMessage)
		{
			try
			{
				StreamWriter sw = File.AppendText(LogFileName);
				sw.WriteLine("Date/Time : " + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString());
				sw.WriteLine("Message   : " + sMessage);
				sw.Close();
			}
			catch (Exception ex)
			{
				string ErrMsg = ex.Message;
			}
		}

		public void WriteLog(Exception ex)
		{
			try
			{
				StreamWriter sw = File.AppendText(LogFileName);
				sw.WriteLine("-----------------------------------------------------------------------------------------");
				sw.WriteLine("Date/Time  :" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString());
				sw.WriteLine("Source/MSG :" + ex.Source + " / " + ex.Message);
				sw.WriteLine("StackTrace :" + ex.StackTrace);
				sw.WriteLine("-----------------------------------------------------------------------------------------");
				sw.Close();
			}
			catch (Exception exlog)
			{
				string ErrMsg = exlog.Message;
			}
		}

	 
		
		public void Dispose()
		{
			GC.Collect();
		}
	}
}
