using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTalk.Framework
{
    public static class CommonVariable
    {
        public abstract class DefaultValues
        {
            public static int Zero = 0;
            public static int ONE = 1;
            public static int TWO = 2;
            public static int THREE = 3;
            public static int FOUR = 4;
            public static int FIVE = 5;
            public static int SIX = 6;
            public static int SEVEN = 7;
            public static int EIGHT = 8;
            public static int TEN = 10;
            public static string sZero = "0";
            public static string sONE = "1";
            public static string sTWO = "2";
            public static string sTHREE = "3";
            public static string sFOUR = "4";
            public static string sFIVE = "5";
            public static string sSIX = "6";
            public static string sSEVEN = "7";
            public static string sEIGHT = "8";
            public static string sTEN = "10";
            public static string NINETYNINE = "-99";
            public static string NINETYEIGHT = "-98";

            public static string TRUE = "True";
            public static string FALSE = "False";

        }

        //GemBox (Excel Export) Details
        public static class GemBoxSettings
        {
            public const string LicenseKey = "EDWG-UK8O-D78A-OMUQ";
        }

        public static class DefaultValue
        {
            public const string Select = "Select";
            public const string Empty = "";
            public const string One = "1";
            public const string AllFAQs = "-1";
            public const string ToastrMessage = "ToastrMessage";
            public const string Delete = "Delete";
        }

        public static class TempDataField
        {
            public const string FormId = "FormId";
            public const string ToastrMessage = "ToastrMessage";
            public const string Message = "Message";
        }

        public static class ViewBagField
        {
            public const string FormId = "vb_FormId";
        }

        /// <summary>
        /// To handle common session variable
        /// </summary>
        public static class SessionField
        {
            public const string ID = "ID";
            public const string UserId = "UserId";
            public const string UserName = "UserName";
            public const string FirstName = "FirstName";
            public const string LastName = "LastName";
            public const string FullName = "FullName";
            public const string RoleId = "RoleId";
            public const string Token = "Token";
            public const string Email = "Email";
            public const string CurrentRoleId = "CurrentRoleId";

            public const string ShowDirectories = "ShowDirectories";
            public const string OrganizationId = "OrganizationId";

            public const string AdminRoleId = "AdminRoleId";
            public const string StaffRoleId = "StaffRoleId";
            public const string ParentRoleId = "ParentRoleId";
            public const string AdminOrgId = "AdminOrgId";
            public const string StaffOrgId = "StaffOrgId";
            public const string ParentOrgId = "ParentOrgId";
            public const string AdminUserId = "AdminUserId";
            public const string StaffUserId = "StaffUserId";
            public const string StudentId = "StudentId";
            public const string StudentUserId = "StudentUserId";
            public const string ParentUserId = "ParentUserId";
            public const string ParentFirstName = "ParentFirstName";
            public const string ParentLastName = "ParentLastName";
            public const string ParentUserName = "ParentUserName";
            public const string ParentOrganizationName = "ParentOrganizationName";
            public const string ParentFullName = "ParentFullName";

            public const string AdminFirstName = "AdminFirstName";
            public const string AdminLastName = "AdminLastName";
            public const string AdminUserName = "AdminUserName";
            public const string AdminOrganizationName = "AdminOrganizationName";
            public const string AdminFullName = "AdminFullName";

            public const string AdminStudentId = "AdminStudentId";
            public const string StaffStudentId = "StaffStudentId";
            public const string ParentStudentId = "ParentStudentId";
            public const string AdminCurrentTermId = "AdminCurrentTermId";
            public const string StaffCurrentTermId = "StaffCurrentTermId";
            public const string ParentCurrentTermId = "ParentCurrentTermId";
            public const string AdminFormId = "AdminFormId";
            public const string StaffFormId = "StaffFormId";
            public const string ParentFormId = "ParentFormId";

            public const string CurrentPage = "CurrentPage";
            public const string TicketId = "TicketId";
            public const string IsEnforcePassword = "IsEnforcePassword"; 
            public const string LoginUserId = "LoginUserId";
            public const string PUserId = "PUserId";
            public const string TargetID = "TargetID";
            public const string ControlPanelActive = "ControlPanelActive";
            public const string TargetPermission = "TargetPermission";
            public const string TargetUserRole = "TargetUserRole"; 
            public const string Password = "Password";
            public const string PUserName = "PUserName";
            public const string PublishStatus = "PublishStatus";
            public const string DioID = "DioID";
            public const string IsDollarOneEnabled = "IsDollarOneEnabled";
            public const string IsfromDirectoriestool = "IsfromDirectoriestool";
            public const string Permission = "Permission";
            public const string OrganizationState = "OrganizationState";
            public const string OrganizationDiocese = "OrganizationDiocese";
            public const string StateID = "StateID";
            public const string DioceseID = "DioceseID";
            public const string ReditainDioceseId = "ReditainDioceseId";
            public const string SiteLoginID = "SiteLoginID";
            public const string DioceseId = "DioceseId"; 
            public const string CategoryId = "CategoryId";
            public const string uesrId = "uesrId";
            public const string StudentCount = "StudentCount";
            public const string IsLmsPage = "IsLmsPage";
            public const string LoginDatetime = "LoginDatetime";
            public const string LoginFrom = "LoginFrom";
            public const string TaskId = "TaskId";
            public const string ITaskId = "ITaskId";
            public const string Name = "Name";
            public const string AssignmentClassId = "AssignmentClassId";
            public const string AssignmentClassName = "AssignmentClassName";
            public const string ClassName = "ClassName";
            public const string FromPage = "FromPage";
            public const string MonthYear = "MonthYear";
            public const string ShowClassesUser = "ShowClassesUser";
            public const string TermID = "TermID";
            public const string ShowFamilyPrivateMessages = "ShowFamilyPrivateMessages";
            public const string EnableStudentAssignmentSubmissions = "EnableStudentAssignmentSubmissions";
            public const string IsLMS = "IsLms";
            public const string LmsOrgId = "LmsOrgId";
            public const string MMInstruction = "MMInstruction";



            public const string CurrentTermName = "CurrentTermName";
            public const string TZOffset = "TZOffset";
            public const string ObserveDST = "ObserveDST";
            public const string AllowNewRegistration = "AllowNewRegistration";
            public const string AllowProfileUpdate = "AllowProfileUpdate";
            public const string IsDemoSchool = "IsDemoSchool";
            public const string ExportContent = "ExportContent";
            public const string ExportType = "ExportType";
            public const string ExportFileName = "ExportFileName";
            public const string EnableBarcode = "EnableBarcode";
            public const string showData = "showData";

            public const string IsFromDirectory = "IsFromDirectory";
            public const string termData = "termData";


            public const string DateTimeNow = "DateTimeNow";
            public const string UserRights = nameof(UserRights);
            public const string ImagePath = nameof(ImagePath);

            
        }

        public static class MyMessage
        {
            public const string FromUserID = "FromUserID";
            public const string Subject = "Subject";
            public const string MessageText = "MessageText";
            public const string ToUsers = "ToUsers";
            public const string IsDeleted = "IsDeleted";
            public const string IsSentFrom = "IsSentFrom";
            public const string MessageID = "MessageID";
            public const string ToUserID = "ToUserID";
            public const string Undo = "Undo";
            public const string isFrom = "isFrom";
            public const string ThreadID = "ThreadID";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
        }

        public static class ImportTemplatePath
        {
            public const string VicariateTemplate = "Attachment\\Diocese\\Vicariate.xlsx";
            public const string VicariateImportDataPath = "Attachment\\Diocese\\VicariateImportFiles";

            //Parish
            public const string ParishTemplate = "Attachment\\Diocese\\Parish.xlsx";

            public const string ParishImportDataPath = "Attachment\\Diocese\\ParishImportFiles";
            public const string ParishProfileFilesPath = "Attachment\\Diocese\\ParishProfileFiles";

            //Import Staff
            public const string StaffTemplate = "Attachment\\Diocese\\Staff.xlsx";

            public const string UserImportDataPath = "Attachment\\Diocese\\UserImportFiles";

            //Import Baptism
            public const string BaptismTemplate = "Attachment\\Parish\\Baptism.xlsx";

            public const string BaptismImportDataPath = "Attachment\\Parish\\BaptismImportFiles";

            //Import Confimration
            public const string ConfirmationTemplate = "Attachment\\Parish\\Confirmation.xlsx";

            public const string ConfirmationImportDataPath = "Attachment\\Parish\\ConfirmationImportFiles";

            //Import Eucharist
            public const string EucharistTemplate = "Attachment\\Parish\\HolyEucharist.xlsx";

            public const string EucharistImportDataPath = "Attachment\\Parish\\HolyEucharistImportFiles";

            //Import Matrimony
            public const string MatrimonyTemplate = "Attachment\\Parish\\Matrimony.xlsx";

            public const string MatrimonyImportDataPath = "Attachment\\Parish\\MatrimonyImportFiles";

            public const string FamilyandMembersImportTemplate = "Attachment\\Parish\\Import\\ImportTemplate.xlsx";
        }

        public static class Parameter
        {
            public const string ActionId = nameof(ActionId);
            public const string PageActionId = nameof(PageActionId);
            public const string DeletedBy = nameof(DeletedBy);
            public const string DioceseID = nameof(DioceseID);
            public const string StudyLevelId = nameof(StudyLevelId);
            public const string Id = nameof(Id);
            public const string IsFromDiocese = nameof(IsFromDiocese);
            public const string NotificationId = nameof(NotificationId);

            //Diocese Announcements
            public const string AnnouncementId = nameof(AnnouncementId);

            public const string MessageId = nameof(MessageId);
            public const string Message = nameof(Message);

            public const string AnnouncementTitle = nameof(AnnouncementTitle);
            public const string Announcement = nameof(Announcement);
            public const string DateFrom = nameof(DateFrom);
            public const string DateTo = nameof(DateTo);

            //Parish details
            public const string ParishId = nameof(ParishId);

            public const string GroupId = nameof(GroupId);
            public const string StateId = nameof(StateId);
            public const string StartDate = nameof(StartDate);
            public const string EndDate = nameof(EndDate);

            //ConnectCard
            public const string ConnectCardId = nameof(ConnectCardId);

            //setting
            public const string BaptismCodeFormat = nameof(BaptismCodeFormat);
            public const string ConfirmationCodeFormat = nameof(ConfirmationCodeFormat);
            public const string DeathCodeFormat = nameof(DeathCodeFormat);
            public const string MarriageCodeFormat = nameof(MarriageCodeFormat);
            public const string FamilyCardCodeFormat = nameof(FamilyCardCodeFormat);
            public const string AnointingCodeFormat = nameof(AnointingCodeFormat);
            public const string EucharistCodeFormat = nameof(EucharistCodeFormat);
            public const string BereavementCodeFormat = nameof(BereavementCodeFormat);

            public const string Name = nameof(Name);
            public const string ParishPatron = nameof(ParishPatron);
            public const string ParishCode = nameof(ParishCode);
            public const string DioceseId = nameof(DioceseId);
            public const string VicariateId = nameof(VicariateId);
            public const string Establishmentdate = nameof(Establishmentdate);
            public const string ParishPastorId = nameof(ParishPastorId);
            public const string AssociatePastors = nameof(AssociatePastors);
            public const string Deacons = nameof(Deacons);
            public const string RAAddressLine1 = nameof(RAAddressLine1);
            public const string RAAddressLine2 = nameof(RAAddressLine2);
            public const string RACity = nameof(RACity);
            public const string RAState = nameof(RAState);
            public const string RACountry = nameof(RACountry);
            public const string RAZipcode = nameof(RAZipcode);
            public const string SameasRAAddress = nameof(SameasRAAddress);
            public const string MAAddressLine1 = nameof(MAAddressLine1);
            public const string MAAddressLine2 = nameof(MAAddressLine2);
            public const string MACity = nameof(MACity);
            public const string MAState = nameof(MAState);
            public const string MACountry = nameof(MACountry);
            public const string MAZipcode = nameof(MAZipcode);
            public const string Mobile = nameof(Mobile);
            public const string PhoneLandline = nameof(PhoneLandline);
            public const string Email = nameof(Email);
            public const string Website = nameof(Website);
            public const string History = nameof(History);
            public const string Landmark = nameof(Landmark);
            public const string Notes = nameof(Notes);
            public const string EnableZone = nameof(EnableZone);
            public const string EnableLanguageCommunity = nameof(EnableLanguageCommunity);
            public const string FCLogo = nameof(FCLogo);
            public const string FCIncome = nameof(FCIncome);
            public const string FCSubscription = nameof(FCSubscription);
            public const string FCHouseType = nameof(FCHouseType);
            public const string FCHouseOwnership = nameof(FCHouseOwnership);
            public const string FCQualification = nameof(FCQualification);
            public const string FCUID = nameof(FCUID);
            public const string SacramentsDetails = nameof(SacramentsDetails);
            public const string MemberRegistration = nameof(MemberRegistration);
            public const string CatechismRegistration = nameof(CatechismRegistration);
            public const string RegistrationHeader = nameof(RegistrationHeader);
            public const string SacramentRegistration = nameof(SacramentRegistration);
            public const string EPassRegistration = nameof(EPassRegistration);
            public const string PastorHistory = nameof(PastorHistory);
            public const string AdministrativePastorId = nameof(AdministrativePastorId);
            public const string OrgId = nameof(OrgId);
            public const string UserId = nameof(UserId);
            public const string UserType = nameof(UserType);
            public const string Prefix = nameof(Prefix);
            public const string FirstName = nameof(FirstName);
            public const string MiddleName = nameof(MiddleName);
            public const string LastName = nameof(LastName);
            public const string Gender = nameof(Gender);
            public const string DOB = nameof(DOB);
            public const string Image = nameof(Image);
            public const string DOJ = nameof(DOJ);
            public const string PhoneNumber = nameof(PhoneNumber);
            public const string Password = nameof(Password);
            public const string PhysicalAddress1 = nameof(PhysicalAddress1);
            public const string PhysicalAddress2 = nameof(PhysicalAddress2);
            public const string PhysicalCity = nameof(PhysicalCity);
            public const string PhysicalState = nameof(PhysicalState);
            public const string PhysicalZipCode = nameof(PhysicalZipCode);
            public const string PhysicalCountry = nameof(PhysicalCountry);
            public const string SameasPhysicalAddress = nameof(SameasPhysicalAddress);
            public const string MailingAddress1 = nameof(MailingAddress1);
            public const string MailingAddress2 = nameof(MailingAddress2);
            public const string MailingCity = nameof(MailingCity);
            public const string MailingZipCode = nameof(MailingZipCode);
            public const string MailingState = nameof(MailingState);
            public const string MailingCountry = nameof(MailingCountry);
            public const string IsLockedout = nameof(IsLockedout);
            public const string IsDisabled = nameof(IsDisabled);
            public const string MissionParish = nameof(MissionParish);
            public const string MissionParishId = nameof(MissionParishId);
            public const string ParentID = nameof(ParentID);
            public const string RoleId = nameof(RoleId);
            public const string FamilyID = nameof(FamilyID);
            public const string FilterValue = nameof(FilterValue);
            public const string SearchValue = nameof(SearchValue);
            public const string SacramentType = nameof(SacramentType);
            public const string AnointingoftheSickId = nameof(AnointingoftheSickId);
            public const string BereavementAndFuneralId = nameof(BereavementAndFuneralId);
            public const string LogoName = nameof(LogoName);
            public const string LogoPath = nameof(LogoPath);
            public const string UniqueFileName = nameof(UniqueFileName);
            public const string LogoFullPath = nameof(LogoFullPath);
            public const string BasicEcclesialCommunityId = nameof(BasicEcclesialCommunityId);
            public const string FamilyId = nameof(FamilyId);
            public const string CommunityType = nameof(CommunityType);
            public const string CommunityName = nameof(CommunityName);
            public const string DateEstablished = nameof(DateEstablished);
            public const string President = nameof(President);

            //public const string ActionId = "ActionId";
            public const string SubStationId = nameof(SubStationId);

            public const string MainParishId = nameof(MainParishId);
            public const string RoleName = nameof(RoleName);

            //settings
            public const string DioceseSettingId = nameof(DioceseSettingId);

            //MassSchedule

            public const string MassScheduleId = nameof(MassScheduleId);
            public const string IsActive = nameof(IsActive);
            public const string Language = nameof(Language);
            public const string MassCategoryId = nameof(MassCategoryId);
            public const string Massdays = nameof(Massdays);
            public const string Description = nameof(Description);
            public const string Place = nameof(Place);
            public const string Time = nameof(Time);
            public const string Date = nameof(Date);

            //ConnectCard
            public const string ConnectCardTypeId = nameof(ConnectCardTypeId);
            public const string BackroundImageName = nameof(BackroundImageName);
            public const string BackroundImagePath = nameof(BackroundImagePath);
            public const string BackroundImageUniquename = nameof(BackroundImageUniquename);
            public const string EventId = nameof(EventId);
            public const string IsShow = nameof(IsShow);


            public const string MassTimeId = nameof(MassTimeId);
            public const string MassLanguage = nameof(MassLanguage);
            public const string MassDescription = nameof(MassDescription);
            public const string MassPlace = nameof(MassPlace);
            public const string MassTime = nameof(MassTime);

            public const string DioceseLogo = nameof(DioceseLogo);
            public const string SignFilePath = nameof(SignFilePath);
            public const string SignFileName = nameof(SignFileName);
            public const string SignUniqueFileName = nameof(SignUniqueFileName);

            public const string IsManual = nameof(IsManual);
            public const string ParishPrefix = nameof(ParishPrefix);
            public const string SubParishPrefix = nameof(SubParishPrefix);
            public const string VicariatePrefix = nameof(VicariatePrefix);
            public const string Createdby = nameof(Createdby);

            public static class Institution
            {
                public const string ParishId = nameof(ParishId);
                public const string DioceseId = nameof(DioceseId);
                public const string InstitutionId = nameof(InstitutionId);
                public const string InstitutionCode = nameof(InstitutionCode);
                public const string InstitutionName = nameof(InstitutionName);
                public const string InstitutionHead = nameof(InstitutionHead);
                public const string Community = nameof(Community);
                public const string Congregation = nameof(Congregation);
                public const string EstablishmentDate = nameof(EstablishmentDate);
                public const string AddressLine1 = nameof(AddressLine1);
                public const string AddressLine2 = nameof(AddressLine2);
                public const string City = nameof(City);
                public const string State = nameof(State);
                public const string Zipcode = nameof(Zipcode);
                public const string Country = nameof(Country);
                public const string Mobile = nameof(Mobile);
                public const string Landline = nameof(Landline);
                public const string Email = nameof(Email);
                public const string Website = nameof(Website);
                public const string AdditionalNotes = nameof(AdditionalNotes);
                public const string InstitutionMemberId = nameof(InstitutionMemberId);
                public const string Role = nameof(Role);
                public const string Member = nameof(Member);
                public const string DateFrom = nameof(DateFrom);
                public const string DateTo = nameof(DateTo);
                public const string Status = nameof(Status);
            }

            public static class SupportData
            {
                public const string SupportdataId = nameof(SupportdataId);
                public const string Id = nameof(Id);
                public const string Name = nameof(Name);
                public const string ParentId = nameof(ParentId);
                public const string SupportDataId = nameof(SupportDataId);
                public const string FilterId = nameof(FilterId);
            }

            public static class DataAcquisition
            {
                public const string ActionID = nameof(ActionID);
                public const string SupportDataId = nameof(SupportDataId);
                public const string ID = nameof(ID);
                public const string Name = nameof(Name);
                public const string Fk_FieldID = nameof(Fk_FieldID);
                public const string Fk_FieldName = nameof(Fk_FieldName);
            }
        }

        public static class Datatableparameter
        {
            public const string Skip = nameof(Skip);
            public const string NextRecord = nameof(NextRecord);
            public const string searchValue = nameof(searchValue);
            public const string SortColumn = nameof(SortColumn);
            public const string SortType = nameof(SortType);
        }

        /// <summary>
        /// User Rights  Common Variables
        /// </summary>
        public static class UserRights
        {
            public const string UserRoleID = nameof(UserRoleID);
            public const string ModuleNo = nameof(ModuleNo);
            public const string UserId = nameof(UserId);
            public const string RoleID = nameof(RoleID);
            public const string ParentID = nameof(ParentID);
            public const string FetureIds = nameof(FetureIds);
            public const string Rights = nameof(Rights);
            public const string AuditCounts = nameof(AuditCounts);
        }

        public static class ConnectionString
        {
            public const string ConnString = "ConnString";
        }

        public static class CommonRegex
        {
            public const string Phone = "[^0-9a-zA-Z]+";
        }

        public static class DynamicControlsVariable
        {
            public const string ActionId = "ActionId";
            public const string FormId = "FormId";
            public const string SectionId = "SectionId";
            public const string ControlsId = "ControlsId";
            public const string FieldId = "FieldId";

            public const string FieldName = "FieldName";
            public const string Placeholder = "Placeholder";
            public const string InputTypeId = "InputTypeId";
            public const string InputTypeName = "InputTypeName";
            public const string InputDefaultValueId = "InputDefaultValueId";

            public const string DisplayOrder = "DisplayOrder";
            public const string FieldDefaultValue = "FieldDefaultValue";
            public const string FieldMaxLenght = "FieldMaxLenght";
            public const string IsRequired = "IsRequired";
            public const string IsVisible = "IsVisible";
            public const string IsShowInGrid = "IsShowInGrid";
            public const string ValidationType = "ValidationType";
            public const string SectionName = "SectionName";

            public const string CategoryId = "CategoryId";
            public const string CategoryName = "CategoryName";
            public const string FieldMappingId = "FieldMappingId";
            public const string FieldMappingName = "FieldMappingName";
            public const string DisplayName = "DisplayName";
            public const string FileUpload = "FileUpload";
            public const string AddControlId = "AddControlId";

            public const string Id = "Id";
            public const string PreLoadDataOptionId = "PreLoadDataOptionId";
            public const string InputType = "InputType";
        }
        /// <summary>
        ///
        /// </summary>
        public static class UserBASEVariable
        {
            public const string ID = "ID";
            public const string Email = "Email";
            public const string SchoolId = "SchoolId";
            public const string StaffId = "StaffId";
            public const string OrganizationID = "OrganizationID";
            public const string OrganizationName = "OrgName";
            public const string Organization_ID = "Organization_ID";
            public const string OrgID = "OrgID";
            public const string EditSacelId = "EditSacelId";
            public const string EditSkillId = "EditSkillId";
            public const string CommentTypeID = "CommentTypeID";
            public const string PageNumber = "PageNumber";

            public const string OrgId = "OrgId";
            public const string ActionId = "ActionId";
            public const string StudentId = "StudentId";
            public const string SiblingsStudentId = "UserIds";

            public const string TargetId = "TargetId";
            public const string UserId = "UserId";
            public const string IsSignCompleted = "IsSignCompleted";
            public const string IsAdminSignCompleted = "IsAdminSignCompleted";
            public const string sqlQuery = "sqlQuery";

            public const string AllowTaskOnlineSubmissions = "AllowTaskOnlineSubmissions";

            public const string UserID = "UserId";
            public const string UserIDs = "UserID";
            public const string FilterYearID = "FilterYearID";
            public const string BuildingID = "BuildingID";
            public const string StudentID = "StudentID";
            public const string PresentValue = "PresentValue";
            public const string ReportAllYears = "ReportAllYears";
            public const string PhoneFormat = "[^0-9a-zA-Z]+";
            public const string Notificationflag = "Notificationflag";



            //Relation User ID
            public const string RUserID = "RUserID";


            public const string UserName = "UserName";
            public const string Password = "Password";
            public const string SchoolName = "SchoolName";
            public const string IsLockedOut = "IsLockedOut";
            public const string IsFeeAccess = "IsFeeAccess";
            public const string ReceivePrivateMessages = "ReceivePrivateMessages";
            public const string UpdateProfile = "UpdateProfile";
            public const string SchoolType = "SchoolType";
            public const string FullName = "FullName";
            public const string SchoolSettingId = "SchoolSettingId";
            public const string RoleId = "RoleId";
            public const string StudentName = "StudentName";
            public const string DioID = "DioID";
            public const string Permission = "Permission";
            public const string Gender = "Gender";
            public const string OrganizationState = "OrganizationState";
            public const string StateID = "StateID";
            public const string DioceseId = "DioceseId";
            public const string FirstName = "FirstName";
            public const string LastName = "LastName";
            public const string NameFilter = "NameFilter";
            public const string GradeLevelID = "GradeLevelID";
            public const string GraduationYear = "GraduationYear";
            public const string SaintID = "SaintID";
            public const string SaintDate = "SaintDate";
            public const string QueryNum = "queryNum";
            public const string TargetID = "TargetID";
            public const string TermID = "TermID";
            public const string IsCopy = "IsCopy";
            public const string ReviewUserId = "ReviewUserId";
            public const string FamilyType = "FamilyType";
            public const string FamilyID = "FamilyID";
            public const string IsParentSite = "IsParentSite";
            public const string ContactID = "ContactID";
            public const string Section = "Section";
            public const string IncludeProspects = "IncludeProspects";
            public const string LoginType = "LoginType";
            public const string ActinonId = "ActinonId";
            public const string LoginMode = "LoginMode";
            public const string ReportID = "ReportID";
            public const string IncludeStaff = "IncludeStaff";
            public const string LoginTransferId = "LoginTransferId";
            public const string isViperUser = "isViperUser";
            public const string ItemID = "ItemID";
            public const string DestinationUrl = "DestinationUrl";
            public const string ResourceType = "ResourceType";
            public const string IsParent = "IsParent";
            public const string DioName = "DioName";
            public const string ISnewRegistration = "ISnewRegistration";
            public const string LoginUserId = "LoginUserId";
            public const string IsDollarOneEnabled = "IsDollarOneEnabled";
            public const string FuzeAccountId = "FuzeAccountId";
            public const string LandingURL = "LandingURL";
            public const string IsChoiceSchool = "IsChoiceSchool";
            public const string AdminTimeout = "AdminTimeout";
            public const string StaffTimeout = "StaffTimeout";

            public const string ViperUserID = "ViperUserID";
            public const string SMSProviderID = "SMSProviderID";
            public const string SMSProviderEndDate = "SMSProviderEndDate";
            public const string AlertProviderID = "AlertProviderID";
            public const string AlertProviderEndDate = "AlertProviderEndDate";
            public const string TuitionProviderID = "TuitionProviderID";
            public const string TuitionProviderEndDate = "TuitionProviderEndDate";
            public const string MagazineProviderID = "MagazineProviderID";
            public const string MagazineProviderEndDate = "MagazineProviderEndDate";
            public const string ContentProviderID = "ContentProviderID";
            public const string ContentProviderEndDate = "ContentProviderEndDate";
            public const string FinancialNeedAssessmentProviderID = "FinancialNeedAssessmentProviderID";
            public const string FinancialNeedAssessmentProviderEndDate = "FinancialNeedAssessmentProviderEndDate";
            public const string ParishSystemProviderID = "ParishSystemProviderID";
            public const string ParishSystemProviderEndDate = "ParishSystemProviderEndDate";
            public const string CommentID = "CommentID";
            public const string ActionType = "ActionType";
            public const string DioceseID = "DioceseID";

            public const string MaxSickDaysAccumulated = "MaxSickDaysAccumulated";
            public const string Changeattendancesettings = "Changeattendancesettings";
            public const string IsEMSAccess = "IsEMSAccess";
            public const string IsVMSAccess = "IsVMSAccess";
            public const string IsDMSAccess = "IsDMSAccess";
            public const string daystoExpire = "daystoExpire";
            public const string ACH_ProcessingFee = "ACH_ProcessingFee";
            public const string LimitExceed = "LimitExceed";
            public const string CCPerTransaction = "CCPerTransaction";
            public const string eCheckSetupFee = "eCheckSetupFee";
            public const string CreditCardSetupFee = "CreditCardSetupFee";
            public const string OrgCCsetupservice = "OrgCCsetupservice";
            public const string IPAddress = "IPAddress";
            public const string SessionID = "SessionID";
            public const string scaletype = "scaletype";
            public const string IsCategoryEnabled = "IsCategoryEnabled";
            public const string IsAchEnable = "IsAchEnable";
            public const string IsMMAchEnabled = "IsMMAchEnabled";
            public const string MMUtility = "MMUtility";

            public const string HallowStatus = "HallowStatus";
            public const string IsHallowEnabled = "IsHallowEnabled";

            public const string Emailuserflag = "Emailuserflag";
            public const string Updateflag = "Updateflag";
            public const string IsParentorstaff = "IsParentorstaff";
            public const string IsWelcomeOnly = "IsWelcomeOnly";
            public const string IsStartApp = "IsStartApp";

            public const string IsEnableClassicAccess = "IsEnableClassicAccess";
        }

        public static class DynamicSectionVariable
        {
            public const string SchoolId = "SchoolId";
            public const string ActionId = "ActionId";
            public const string FormId = "FormId";
            public const string SectionId = "SectionId";
            public const string SectionName = "SectionName";

            public const string SectionDescription = "SectionDescription";
            public const string DisplayRows = "DisplayRows";
            public const string DisplayOrder = "DisplayOrder";
            public const string IsAddMultiple = "IsAddMultiple";
            public const string DisplayMode = "DisplayMode";
            public const string AddSectionId = "AddSectionId";
        }

        public static class DynamicFromsVariable
        {
            public const string SchoolId = "SchoolId";
            public const string OrganizationId = "OrganizationId";

            public const string ActionId = "ActionId";
            public const string FormStatus = "FormStatus";
            public const string RecordId = "RecordId";
            public const string FieldMappingKey = "FieldMappingKey";
            public const string SectionId = "SectionId";
            public const string StaffID = "StaffID";
            public const string TermID = "TermID";
            public const string FormId = "FormId";
            public const string StudentID = "StudentID";
            public const string OrgId = "OrgId";
            public const string UserIds = "UserIds";
            public const string IsExport = "IsExport";
            public const string SearchText = "SearchText";
            public const string FieldName = "FieldName";
            public const string FormName = "FormName";
            public const string OnlineFormName = "OnlineFormName";

            public const string FormDescription = "FormDescription";
            public const string NoOfRecordExpected = "NoOfRecordExpected";
            public const string NoOfRecordCreate = "NoOfRecordCreate";
            public const string RecordsCreated = "RecordsCreated";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string ShowAddButton = "ShowAddButton";
            public const string ParentCreateCount = "ParentCreateCount";

            public const string PublishStatus = "PublishStatus";
            public const string UserType = "UserType";
            public const string IsAutoFill = "IsAutoFill";
            public const string UserTypeId = "UserTypeId";
            public const string IsEnableFieldMapping = "IsEnableFieldMapping";
            public const string FieldMappingID = "FieldMappingID";
            public const string FieldAccess = "FieldAccess";
            public const string IsEnableMail = "IsEnableMail";
            public const string MailContent = "MailContent";
            public const string IsEnableTemplate = "IsEnableTemplate";
            public const string Attachment = "Attachment";
            public const string Permission = "Permission";
            public const string gradelevel = "gradelevel";
            public const string Grade = "Grade";
            public const string GradeLevelID = "GradeLevelID";
            public const string GradeIds = "GradeIds";
            public const string GradeId = "GradeId";
            public const string GroupIds = "GroupIds";
            public const string IncludeSiblings = "IncludeSiblings";
            public const string DataCollectors = "DataCollectors";
            public const string AutoFill = "AutoFill";
            public const string IsMultiple = "IsMultiple";
            public const string UserId = "UserId";
            public const string RoleId = "RoleId";
            public const string FormDisplayOrder = "FormDisplayOrder";

            public const string FormCategoryId = "FormCategoryId";
            public const string FormCategoryName = "FormCategoryName";
            public const string FormCategoryCount = "FormCategoryCount";
            public const string NoRowsCount = "NoRowsCount";
            public const string StudentIDs = "StudentIDs";
            public const string SupportTypeId = "SupportTypeId";
        }

        public static class FieldMappingVariable
        {
            public const string ActionId = "ActionId";
            public const string FieldMappingId = "FieldMappingId";
            public const string CategoryId = "CategoryId";
            public const string FieldMappingName = "FieldMappingName";
            public const string InputType = "InputType";
            public const string TableName = "TableName";
            public const string ColumnName = "ColumnName";
            public const string DropDownValue = "DropDownValue";
            public const string UpdateQuery = "UpdateQuery";
            public const string SelectQuery = "SelectQuery";
            public const string categories = "categories";
            public const string categoriesId = "categoriesId";
            public const string DisplayOrder = "DisplayOrder";
        }

        public static class SuppportVariables
        {
            public const string FamilyRoleId = "FamilyRoleId";
            public const string FamilyRoleName = "FamilyRoleName";
            public const string SchoolId = "SchoolId";
            public const string SupportTypeId = "SupportTypeId";
            public const string Categories = "Categories";
            public const string FieldMapping = "FieldMapping";
            public const string CategoryId = "CategoryId";
            public const string CategoryName = "CategoryName";
        }


    }
}