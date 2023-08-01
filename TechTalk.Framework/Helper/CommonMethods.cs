using GemBox.Spreadsheet;
using Newtonsoft.Json;
using System.Collections;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using SaveOptions = GemBox.Spreadsheet.SaveOptions;

namespace TechTalk.Framework.Helper
{
    public static class CommonMethods
	{
		public static string EncryptionKey = "SAPTKEY";

		/// <summary>
		/// Serializes the object.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="objectValue">The object value.</param>
		/// <returns></returns>
		public static string SerializeObject<T>(T objectValue)
		{
			return JsonConvert.SerializeObject(objectValue);
		}

		/// <summary>
		/// Deserializes the string to intended object.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="objectValue">The object value.</param>
		/// <returns>Serialized target object</returns>
		public static T DeserializeObject<T>(string objectValue)
		{
			return JsonConvert.DeserializeObject<T>(objectValue);
		}

		public static string ReadFile(string path)
		{
			string fileData = string.Empty;
			try
			{
				if (File.Exists(path))
				{
					fileData = File.ReadAllText(path);
					//fileData = File.ReadAllText(new Uri(path).AbsolutePath);
				}
			}
			catch (Exception ex)
			{
				//using (ErrorLog errorLog = new ErrorLog())
				//{
				//    errorLog.WriteLog(ex);
				//}
			}

			return fileData;
		}

		#region Generate Random Password
		/// <summary>
		/// This method is to generate Random Password which is the combination of Alphabets and Numeric of 10 characters
		/// </summary>
		/// <returns>string</returns>
		public static string GetRandomPassword()
		{
			char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456989!@#$%^&*".ToCharArray();
			string password = string.Empty;
			Random random = new Random();

			for (int i = 0; i < 8; i++)
			{
				int x = random.Next(1, chars.Length);
				//Don't Allow repeation of Characters
				if (!password.Contains(chars.GetValue(x).ToString()))
					password += chars.GetValue(x);
				else
					i--;
			}
			return password;
		}
		#endregion

		#region UserRights
		/// <summary>
		/// This method is Userd to get User Rights base on the Menu
		/// </summary>
		/// <returns>string</returns>
		public static int GetUserRights(string MeniId)
		{
			//var obj = HttpContext.Session.GetString(SessionField.Token);
			//var obj = HttpContext.Session.Get<List<UserRight>>(SessionField.UserRights);
			//var obj = Context.Session.Get<List<UserRight>>(SessionField.UserRights).Find(o => o.ModuleName == MeniId);
			// return obj?.AccessRight;
			return 0;
		}
		#endregion UserRights

		/// <summary>
		/// accepts a plain text string and returns the string encrypted
		/// </summary>
		/// <param name="strValue"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		/// 

		public static string EncryptValue(string sEncryptionData)
		{
			string sEncryptionValue = string.Empty;
			try
			{

				byte[] clearBytes = Encoding.Unicode.GetBytes(sEncryptionData);
				using (Aes encryptor = Aes.Create())
				{
					// encryptor.Padding = PaddingMode.None;
					Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

					// encryptor.Key = pdb.GetBytes(24);
					encryptor.Key = pdb.GetBytes(32);
					encryptor.IV = pdb.GetBytes(16);
					using (MemoryStream ms = new MemoryStream())
					{
						using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
						{
							cs.Write(clearBytes, 0, clearBytes.Length);
							cs.Close();
						}
						sEncryptionValue = Convert.ToBase64String(ms.ToArray());
						sEncryptionValue = sEncryptionValue.Replace("/", "♥");
					}
				}
			}
			catch (Exception Ex)
			{
				new ErrorLog().WriteLog(Ex);
			}
			return sEncryptionValue;
		}
		/// <summary>
		/// accepts an encrypted string and returns the string as plain text
		/// </summary>
		/// <param name="Msg"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		public static string DecryptValue(string cipherText)
		{

			string sDecrpytText = "";
			try
			{
				if (cipherText != null && EncryptionKey != "" && cipherText != "")
				{
					cipherText = cipherText.Replace("♥", "/");

					cipherText = cipherText.Replace(" ", "+");// Replace the Empty string with. Becase FromBase64String won't accept the Empty string
					byte[] cipherBytes = Convert.FromBase64String(cipherText);
					using (Aes encryptor = Aes.Create())
					{
						// encryptor.Padding = PaddingMode.Zeros;
						Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
						//encryptor.Key = pdb.GetBytes(24);
						encryptor.Key = pdb.GetBytes(32);
						encryptor.IV = pdb.GetBytes(16);
						using (MemoryStream ms = new MemoryStream())
						{
							using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
							{
								cs.Write(cipherBytes, 0, cipherBytes.Length);
								cs.Close();
							}
							sDecrpytText = Encoding.Unicode.GetString(ms.ToArray());
						}
					}
				}
			}
			catch (Exception Ex)
			{
				new ErrorLog().WriteLog(Ex);
			}
			return sDecrpytText;
		}

        public static byte[] GetBytes(ExcelFile file, SaveOptions options)
        {
            using (var stream = new MemoryStream())
            {
                file.Save(stream, options);
                return stream.ToArray();
            }
        }


        public static ExcelFile ExportToExcelWithDataType(DataTable dtInput)
        {
            //Set the License Key
            GemBox.Spreadsheet.SpreadsheetInfo.SetLicense(CommonVariable.GemBoxSettings.LicenseKey);
            //Create a new Excel File
            GemBox.Spreadsheet.ExcelFile ef = new GemBox.Spreadsheet.ExcelFile();
            //Assign the Sheet Name
            GemBox.Spreadsheet.ExcelWorksheet ws = ef.Worksheets.Add("Sheet1");

            if (dtInput != null && dtInput.Rows.Count > 0)
            {
                bool ColumnHeaderBold = true;
                ArrayList HideColumn = null;

                int iRow = 0;
                int iColumn = 0;
                int iTempStartColumn = iColumn;

                #region Writing Page Header

                //Write Code for common Header
                //iRow++; //Leave one Empty Row

                #endregion Writing Page Header

                #region Remove Unwanted Column

                if (HideColumn != null)
                {
                    //Copy the Column Names into a List
                    ArrayList Cols = new ArrayList();
                    foreach (DataColumn objCol in dtInput.Columns)
                    {
                        Cols.Add(objCol.ColumnName);
                    }
                    string sKey = string.Empty;
                    for (int i = 0; i < HideColumn.Count; i++)
                    {
                        sKey = Convert.ToString(HideColumn[i]);
                        if (Cols.Contains(sKey))
                        {
                            dtInput.Columns.Remove(sKey);
                        }
                    }
                }

                #endregion Remove Unwanted Column

                #region Writing the Column Headers

                foreach (DataColumn objCol in dtInput.Columns)
                {
                    ws.Cells[iRow, iColumn].Value = objCol.ColumnName;
                    //ws.Columns[iColumn].AutoFit(1, ws.Rows[iRow], ws.Rows[ws.Rows.Count - 1]);

                    if (ColumnHeaderBold)
                    {
                        ws.Cells[iRow, iColumn].Style.Font.Weight = ExcelFont.BoldWeight;
                    }
                    iColumn++;
                }

                //for (int i=0; i < dtInput.Columns.Count; i++)
                //{
                //    ws.Columns[i].AutoFit(1, ws.Rows[1], ws.Rows[ws.Rows.Count - 1]);
                //}

                iRow++; // Increase the Row Number by one , so that Content is moved to next row.
                iColumn = 0;// To Use the First Column It Self

                #endregion Writing the Column Headers

                #region To write the DataTable into Excel

                for (int i = 0; i < dtInput.Rows.Count; i++) //Loop through all records
                {
                    iTempStartColumn = iColumn;
                    for (int j = 0; j < dtInput.Columns.Count; j++)  //Loop through All columns
                    {
                        try
                        {
                            string sDataType = dtInput.Columns[j].DataType.ToString();

                            if (sDataType == "System.Int16")
                                ws.Cells[iRow, iTempStartColumn].Value = ConversionHelper.ToInt16(dtInput.Rows[i][j]);
                            else if (sDataType == "System.Int32")
                                ws.Cells[iRow, iTempStartColumn].Value = ConversionHelper.ToInt32(dtInput.Rows[i][j]);
                            else
                                ws.Cells[iRow, iTempStartColumn].Value = Convert.ToString(dtInput.Rows[i][j]);
                        }
                        catch (Exception ex)
                        {
                            new ErrorLog().WriteLog(ex);
                        }
                        iTempStartColumn++;
                    }
                    //Move to the Next Row of Excel
                    iRow++;
                }

                try
                {
                    #region To Set Column Width

                    int columnCount = ws.CalculateMaxUsedColumns();
                    for (int i = 0; i < columnCount; i++)
                        ws.Columns[i].AutoFit(1, ws.Rows[1], ws.Rows[ws.Rows.Count - 1]);

                    #endregion To Set Column Width
                }
                catch (Exception ex)
                {
                    new ErrorLog().WriteLog(ex);
                }

                #endregion To write the DataTable into Excel

                var options = SaveOptions.XlsxDefault;
            }

            return ef;
        }

        public static ExcelFile ExportToExcelWithDataType(DataTable dtInput, DataTable dtHeader, bool AutoSize = true)
        {
            //Set the License Key
            GemBox.Spreadsheet.SpreadsheetInfo.SetLicense(CommonVariable.GemBoxSettings.LicenseKey);
            //Create a new Excel File
            GemBox.Spreadsheet.ExcelFile ef = new GemBox.Spreadsheet.ExcelFile();
            int sheetCount = 0;
            //if (dsData != null && dsData.Tables.Count > 0)
            //{
            //    for (int k = 0; k < dsData.Tables.Count; k = k + 2)
            //    {
            //        DataTable dtInput = dsData.Tables[k];
            //        DataTable dtHeader = dsData.Tables[k + 1];
            //Assign the Sheet Name
            sheetCount++;
            GemBox.Spreadsheet.ExcelWorksheet ws = ef.Worksheets.Add("Sheet" + sheetCount);

            if (dtInput != null && dtInput.Rows.Count > 0)
            {
                bool ColumnHeaderBold = true;
                ArrayList HideColumn = null;

                int iRow = 0;
                int iColumn = 0;
                int iTempStartColumn = iColumn;

                #region Writing Page Header

                //Write Code for common Header
                //iRow++; //Leave one Empty Row

                #endregion Writing Page Header

                #region Remove Unwanted Column

                if (HideColumn != null)
                {
                    //Copy the Column Names into a List
                    ArrayList Cols = new ArrayList();
                    foreach (DataColumn objCol in dtInput.Columns)
                    {
                        Cols.Add(objCol.ColumnName);
                    }

                    for (int i = 0; i < HideColumn.Count; i++)
                    {
                        string sKey = Convert.ToString(HideColumn[i]);
                        if (Cols.Contains(sKey))
                        {
                            dtInput.Columns.Remove(sKey);
                        }
                    }
                }

                #endregion Remove Unwanted Column

                #region Writing the Column Headers

                foreach (DataRow objCol in dtHeader.Rows)
                {
                    ws.Cells[iRow, iColumn].Value = objCol["Header"];
                    if (ColumnHeaderBold)
                    {
                        ws.Cells[iRow, iColumn].Style.Font.Weight = ExcelFont.BoldWeight;
                    }
                    iColumn++;
                }
                iRow++; // Increase the Row Number by one , so that Content is moved to next row.
                iColumn = 0;// To Use the First Column It Self

                #endregion Writing the Column Headers

                #region To write the DataTable into Excel

                for (int i = 0; i < dtInput.Rows.Count; i++) //Loop through all records
                {
                    iTempStartColumn = iColumn;
                    for (int j = 0; j < dtInput.Columns.Count; j++)  //Loop through All columns
                    {
                        try
                        {
                            string sDataType = dtInput.Columns[j].DataType.ToString();

                            if (sDataType == "System.Int16")
                                ws.Cells[iRow, iTempStartColumn].Value = ConversionHelper.ToInt16(dtInput.Rows[i][j]);
                            else if (sDataType == "System.Int32")
                                ws.Cells[iRow, iTempStartColumn].Value = ConversionHelper.ToInt32(dtInput.Rows[i][j]);
                            else
                                ws.Cells[iRow, iTempStartColumn].Value = Convert.ToString(dtInput.Rows[i][j]);
                        }
                        catch (Exception ex)
                        {
                              new ErrorLog().WriteLog(ex);
                             
                        }
                        iTempStartColumn++;
                    }
                    //Move to the Next Row of Excel
                    iRow++;
                }

                #endregion To write the DataTable into Excel

                //var options = SaveOptions.XlsxDefault;
                //    }
                //}
            }

            return ef;
        }

    }
}
