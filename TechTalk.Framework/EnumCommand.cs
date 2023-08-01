namespace TechTalk.Framework
{
    public class EnumCommand
    {

        public enum DataType
        {
            BigInt,
            Boolean,
            Byte,
            Char,
            Date,
            DateTime,
            smalldatetime,
            Decimal,
            Double,
            Money,
            Int,
            Int16,
            Int32,
            Int64,
            SByte,
            Single,
            String,
            TimeSpan,
            UInt16,
            UInt32,
            UInt64,
            ByteArray,
            Varchar,
            nVarchar,
            None,
            Memo,
            Blob,
            Text,
            Xml,
            bit,
            ntext

        }

        public enum SQLType
        {
            SQLStatic,
            SQLDynamic,
            SQLStoredProcedure
        }

        public enum QueryAddFormAction
        {
            TemplateActionId = 12,
            FormCategoryActionId = 13,
            FieldMoveRightActionId = 6,
            FieldMoveLeft = 5,
            CopyField = 4,
            DeleteDynamicField = 3,
            GetFieldMapping = 7,
            EditDynamicField = 9,
            SaveFieldActionId = 1,
            EditFieldActionId = 2,
            AddBetweenFieldActionId = 8,
            SectionMoveDown = 5,
            SectionMoveUp = 4,
            DeleteDynamicSection = 3,
            SaveDynamicSection = 1,
            EditDynamicSection = 2,
            GetSectionById = 10,
            AddDynamicSection = 10,
            AddFormSection = 1,
            SaveOnlineForms = 1,
            EditOnlineForms = 2,
            DeleteDynamicForm = 3,
            ArchiveForm = 6,
            SetActiveForm = 10,
            UnArchiveForm = 7,
            GetFormsData = 1,
            GetViperTemplates = 14,
            PublishUnPublishForm = 11,
            UpdateTemplateActionId = 5,
            AttachmentActionId = 8,
            FielUpdateActionId = 7,
            RequiredUpdateActionId = 7,
            TemplateCopyActionId = 1,
            CopyActionId = 2,
            ActiveForms = 1,
            AllDynamicFormsBySchoolId = 2,
            DynamicFormsByFormId = 3,
            SesctionByFormId = 4,
            ControlsByFormId = 5,
            DynamicEditDataByRecordId = 6,
            ActionId = 7,
            DynamicSectionBySectionId = 10,
            AtutoSaveActionId = 1,
            AtutoSaveBlankActionId = 9,
        }

        public enum DataSource
        {
            DataSet,
            DataReader,
            DataTable,
            DataView,
            Scalar,
            ExecuteXmlReader
        }
        /// <summary>
        /// These are linked with table mailsetting
        /// string - Mailcode
        /// </summary>
        public enum MailCode
        {
            UserApprove = 1,
            ApproveRegistration = 2,
            RejectRegistration = 3,
           
        }

        public enum ActionQuery
        {
            AllRecords = 0,
            InsertRecoreds = 1,
            SaveRecords = 2,
            DeleteRecords = 3,
        }
        public enum QueryRenderAction
        {
            ActiveForms = 1,
            StudentActiveForms = 2,
            AllDynamicFormsBySchoolId = 2,
            allArchiveForm = 16,
            DynamicFormsByFormId = 3,
            SesctionByFormId = 4,
            StaffRenderForm = 1,
            staffRenderForm = 18,
            StudentRecordId = 1,
            ControlsByFormId = 5,
            DynamicEditDataByRecordId = 6,
            ActionId = 7,
            DynamicSectionBySectionId = 10,
            ParentActiveFormsActionId = 13,
            NextFormActionId = 14,
            TeplateActionId = 15,
            FilterStudentActionId = 1,
            FilterStaffActionId = 3,
            CopyStudentActionId = 2,
            ExportUserFormStatus = 17

        }


    }
}
