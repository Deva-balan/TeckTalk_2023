using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.Repository.Interfaces;
using TechTalk.DBEngine;
using Dapper;
using System.Data;
using TechTalk.Framework.Helper;
using TechTalk.Framework;

namespace TechTalk.Repository.Repository
{
    public class StudentRepository: IStudentRepository
    {
        private readonly ISQLServerHandler _SQLServerHandler;

        public StudentRepository(ISQLServerHandler sQLServerHandler)
        {
            _SQLServerHandler = sQLServerHandler;
        }

        public async Task<DBResultArgs> GetStudentAsync()
        {
            var parameters = new DynamicParameters();
            DBResultArgs resultArgs=new DBResultArgs();
            try
            {
                using (_SQLServerHandler.Connection)
                {
                    parameters.Add("ActionId", 1, DbType.Int16, ParameterDirection.Input);

                    var multipleResults = await _SQLServerHandler.QueryMultipleAsync(_SQLServerHandler.Connection, "ManageApplicationSettings", CommandType.StoredProcedure, parameters);
                    if (multipleResults != null)
                    {
                        //logoResult.ApplicationSettingsDTOList = (await multipleResults.ReadAsync<ApplicationSettingsDTO>()).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                new ErrorLog().WriteLog(ex);
            }
            return resultArgs;
        }
    }
}
