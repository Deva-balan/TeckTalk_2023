namespace TechTalk.Framework
{
    public static class DBVariables
    {
        public static class DBParameter
        {
            // Common Parameter
            public const string DropdownId = nameof(DropdownId);

            public const string DioceseID = nameof(DioceseID);

            public const string Id = nameof(Id);
            public const string CountryId = nameof(CountryId);
            public const string SaintID = nameof(SaintID);

            // Group Params
            public const string GroupName = nameof(GroupName);

            public const string AssociationStatus = nameof(AssociationStatus);
            public const string DateOfCreation = nameof(DateOfCreation);
            public const string Description = nameof(Description);
            public const string EstablishedDate = nameof(EstablishedDate);
            public const string GroupImageName = nameof(GroupImageName);
            public const string GroupId = nameof(GroupId);
            public const string MemberIds = nameof(MemberIds);
            public const string RoleIds = nameof(RoleIds);
            public const string StatusIds = nameof(StatusIds);
            public const string ActionId = nameof(ActionId);
            public const string CreatedBy = nameof(CreatedBy);
            public const string AllowPriestNun = nameof(AllowPriestNun);
            public const string AllowStaff = nameof(AllowStaff);
            public const string AllowMember = nameof(AllowMember);
            public const string AssociationProcessTrackingId = nameof(AssociationProcessTrackingId);

            public const string AssociationProcessTrackingIds = nameof(AssociationProcessTrackingIds);
            public const string AssociationProcessTitles = nameof(AssociationProcessTitles);
            public const string AssociationProcessDescriptions = nameof(AssociationProcessDescriptions);
            public const string AssociationIsActiveProcess = nameof(AssociationIsActiveProcess);

            //Council Parameter
            public const string CouncilId = nameof(CouncilId);

            public const string MemberId = nameof(MemberId);
            public const string SubStationId = nameof(SubStationId);
            public const string StartDate = nameof(StartDate);
            public const string EndDate = nameof(EndDate);
            public const string Status = nameof(Status);
            public const string RoleId = nameof(RoleId);
            public const string Role = nameof(Role);
            public const string StatusName = nameof(StatusName);

            //Building Parameter
            public const string BuildingId = nameof(BuildingId);

            public const string Location = nameof(Location);
            public const string IsAvailable = nameof(IsAvailable);

            //Room Parameter
            public const string RoomId = nameof(RoomId);
            public const string RoomName = nameof(RoomName);
            public const string RoomNumber = nameof(RoomNumber);
            public const string SeatsMax = nameof(SeatsMax);
            public const string SeatRows = nameof(SeatRows);
            public const string RowDepth = nameof(RowDepth);

            //Asset Parameter
            public const string AssetId = nameof(AssetId);
            public const string AssetName = nameof(AssetName);
            public const string AssetNumber = nameof(AssetNumber);
            public const string AssetType = nameof(AssetType);

            //Request Form Parameter
            public const string FormId = nameof(FormId);
            public const string FacilityTypeId = nameof(FacilityTypeId);
            public const string FacilityId = nameof(FacilityId);
            public const string RequestedBy = nameof(RequestedBy);
            public const string RequestedOn = nameof(RequestedOn);

            //Approve reject form Parameter
            public const string ApprovedBy = nameof(ApprovedBy);
            public const string IsApproved = nameof(IsApproved);
            public const string Notes = nameof(Notes);



            // User Login Parameter
            public const string Email = nameof(Email);

            public const string Password = nameof(Password);
            public const string LoginTransferID = nameof(LoginTransferID);

            public const string CurentPassword = nameof(CurentPassword);
            public const string MailId = nameof(MailId);

            // User Detsils Parameter
            public const string UserId = nameof(UserId);
            public const string LoginUserId = nameof(LoginUserId);

            public const string DeletedUserId = nameof(DeletedUserId);
            public const string Name = nameof(Name);
            public const string DOB = nameof(DOB);
            public const string Department = nameof(Department);
            public const string Gender = nameof(Gender);
            public const string Mobile = nameof(Mobile);
            public const string IsApprove = nameof(IsApprove);

            // Parish Parameter
            public const string ParishId = nameof(ParishId);
            public const string PastorName = nameof(PastorName);

            public const string MissionParishId = nameof(MissionParishId);

            public const string FromDate = nameof(FromDate);
            public const string ToDate = nameof(ToDate);

            //Diocese Parameter
            public const string DioceseId = nameof(DioceseId);

            //AnointingoftheSick Parameter
            public const string AnointingoftheSickId = nameof(AnointingoftheSickId);
            public const string PlaceofAnointingoftheSick = nameof(PlaceofAnointingoftheSick);
            public const string City = nameof(City);
            public const string BaptismalName = nameof(BaptismalName);
            public const string DateofAnointingoftheSick = nameof(DateofAnointingoftheSick);
            public const string MassConductedOn = nameof(MassConductedOn);

            //AnointingoftheSick Parameter
            public const string BereavementAndFuneralId = nameof(BereavementAndFuneralId);
            public const string PlaceofFuneral = nameof(PlaceofFuneral);
            public const string PlaceofDeath = nameof(PlaceofDeath);
            public const string DateofDeath = nameof(DateofDeath);
            public const string DateofBurial = nameof(DateofBurial);
            public const string SpouseName = nameof(SpouseName);
            public const string Remark = nameof(Remark);
            public const string CauseofDeath = nameof(CauseofDeath);

            //Alert Parameter
            public const string OrgID = nameof(OrgID);
            public const string MessageID = nameof(MessageID);
            public const string IsProspectAlert = nameof(IsProspectAlert);
            public const string Mission = nameof(Mission);
            public const string Vision = nameof(Vision);
            public const string Type = nameof(Type);
            public const string statusXMLText = nameof(statusXMLText);


			public const string RequestedUserId = nameof(RequestedUserId);
			public const string GiveAccess = nameof(GiveAccess);
			//Team and Roles
			public const string TeamsandRolesId = nameof(TeamsandRolesId);
			public const string TeamandRolesMemberId = nameof(TeamandRolesMemberId);
			public const string DioId = nameof(DioId);
			public const string RolesId = nameof(RolesId);
			public const string TeamName = nameof(TeamName);
			public static class RDLCParameter
			{
				public const string BaptismId = nameof(BaptismId);
				public const string MatrimonyId = nameof(MatrimonyId);
				public const string ConfirmationId = nameof(ConfirmationId);
				public const string EucharistId = nameof(EucharistId);
				public const string BereavementAndFuneralId = nameof(BereavementAndFuneralId);
				public const string DioceseId = nameof(DioceseId);
				public const string ParishId = nameof(ParishId);
			}

            //
            public const string PreviousDioceseId = nameof(PreviousDioceseId);

            public const string PreviousParishId = nameof(PreviousDioceseId);
            public const string PreviousSubStationId = nameof(PreviousSubStationId);
            public const string FamilyId = nameof(FamilyId);

            //Confirmation Parameter
            public const string DateofConfirmation = nameof(DateofConfirmation);
            public const string Reconciliationdate = nameof(Reconciliationdate);
            public const string EucharistId = nameof(EucharistId);
            public const string DateofHE = nameof(DateofHE);


            public const string ConfirmationId = nameof(ConfirmationId);
            public const string PastorId = nameof(PastorId);
            public const string Remarks = nameof(Remarks);
            public const string SponsorName = nameof(SponsorName);

            public static class DioceseParameter
            {
                public const string DioceseId = nameof(DioceseId);
                public const string ParishId = nameof(ParishId);
                public const string DioName = nameof(DioName);
                public const string DioShortName = nameof(DioShortName);
                public const string Email = nameof(Email);
                public const string DioCity = nameof(DioCity);
                public const string DioState = nameof(DioState);
                public const string DioZip = nameof(DioZip);
                public const string DioCountry = nameof(DioCountry);
                public const string DioPhone = nameof(DioPhone);
                public const string DioFax = nameof(DioFax);
                public const string DioURL = nameof(DioURL);
                public const string DioceseCategory = nameof(DioceseCategory);
                public const string IsDioceseClosed = nameof(IsDioceseClosed);
                public const string DioCode = nameof(DioCode);
                public const string EstablishedData = nameof(EstablishedData);
                public const string Notes = nameof(Notes);
                public const string BishopId = nameof(BishopId);
                public const string History = nameof(History);
                public const string BishopSecretaryId = nameof(BishopSecretaryId);
                public const string VicarGeneralId = nameof(VicarGeneralId);
                public const string AdministratorId = nameof(AdministratorId);
                public const string DioAddress1 = nameof(DioAddress1);
                public const string DioAddress2 = nameof(DioAddress2);
                public const string DioMobile = nameof(DioMobile);
                public const string GroupId = nameof(GroupId);
                public const string MemberIds = nameof(MemberIds);
                public const string RoleIds = nameof(RoleIds);
                public const string DateofJoining = nameof(DateofJoining);
                public const string DateofEnding = nameof(DateofEnding);
                public const string Status = nameof(Status);
            }

            public static class UserProfile
            {
                public const string ActionId = nameof(ActionId);
                public const string UserId = nameof(UserId);
                public const string PhysicalAddress1 = nameof(PhysicalAddress1);
                public const string PhysicalAddress2 = nameof(PhysicalAddress2);
                public const string PhysicalCity = nameof(PhysicalCity);
                public const string PhysicalZipCode = nameof(PhysicalZipCode);
                public const string PhysicalStateId = nameof(PhysicalStateId);
                public const string PhysicalCountryId = nameof(PhysicalCountryId);
                public const string IsPhysicalAddress = nameof(IsPhysicalAddress);
                public const string MailingAddress1 = nameof(MailingAddress1);
                public const string MailingAddress2 = nameof(MailingAddress2);
                public const string MailingCity = nameof(MailingCity);
                public const string MailingZipCode = nameof(MailingZipCode);
                public const string MailingStateId = nameof(MailingStateId);
                public const string MailingCountryId = nameof(MailingCountryId);
                public const string Image = nameof(Image);
                public const string PhoneNumber = nameof(PhoneNumber);
            }

            //Vicariate Parameter
            public const string VicariateId = nameof(VicariateId);

            public static class VicariateParameter
            {
                public const string DioceseId = nameof(DioceseId);
                public const string VicariateId = nameof(VicariateId);
                public const string Name = nameof(Name);
                public const string Code = nameof(Code);
                public const string VicarHeadId = nameof(VicarHeadId);
                public const string EstablishmentDate = nameof(EstablishmentDate);
                public const string AddressLine1 = nameof(AddressLine1);
                public const string AddressLine2 = nameof(AddressLine2);
                public const string City = nameof(City);
                public const string StateId = nameof(StateId);
                public const string Zipcode = nameof(Zipcode);
                public const string Mobile = nameof(Mobile);
                public const string Landline = nameof(Landline);
                public const string Fax = nameof(Fax);
                public const string Email = nameof(Email);
                public const string CountryId = nameof(CountryId);
                public const string Note = nameof(Note);
                public const string Website = nameof(Website);
            }

            public static class BaptismParameter
            {
                public const string DioceseId = nameof(DioceseId);
                public const string UserId = nameof(UserId);
                public const string FamilyId = nameof(FamilyId);
                public const string BaptismId = nameof(BaptismId);
                public const string PastorId = nameof(PastorId);
                public const string ParishId = nameof(ParishId);
                public const string BaptismName = nameof(BaptismName);
                public const string DateofBaptism = nameof(DateofBaptism);
                public const string GodFatherName = nameof(GodFatherName);
                public const string GodMotherName = nameof(GodMotherName);
                public const string NameofFather = nameof(NameofFather);
                public const string NameofMother = nameof(NameofMother);
                public const string GiveAccess = nameof(GiveAccess);
                public const string RequestedUserId = nameof(RequestedUserId);
                public const string PastorName = nameof(PastorName);
            }

            public static class PriestParameter
            {
                //Basic Details
                public const string DioceseId = nameof(DioceseId);
                public const string LogoName = nameof(LogoName);
                public const string LogoPath = nameof(LogoPath);
                public const string UniqueFileName = nameof(UniqueFileName);
                public const string SignFileName = nameof(SignFileName);
                public const string SignFilePath = nameof(SignFilePath);
                public const string SignUniqueFileName = nameof(SignUniqueFileName);
                public const string UserId = nameof(UserId);
                public const string IsFromDiocese = nameof(IsFromDiocese);
                public const string LockedOutofAccount = nameof(LockedOutofAccount);
                public const string Usertype = nameof(Usertype);
                public const string DOB = nameof(DOB);
                public const string InstitutionRepresenting = nameof(InstitutionRepresenting);
                public const string Responsibility = nameof(Responsibility);
                public const string ParishId = nameof(ParishId);
                public const string SubParishId = nameof(SubParishId);
                public const string DateofJoin = nameof(DateofJoin);
                public const string CommunityName = nameof(CommunityName);
                public const string Prefix = nameof(Prefix);
                public const string FirstName = nameof(FirstName);
                public const string LastName = nameof(LastName);
                public const string MiddleName = nameof(MiddleName);
                public const string CHMSPosition = nameof(CHMSPosition);
                public const string Consecrators = nameof(Consecrators);
                public const string AddressLine1 = nameof(AddressLine1);
                public const string AddressLine2 = nameof(AddressLine2);
                public const string City = nameof(City);
                public const string StateId = nameof(StateId);
                public const string Zipcode = nameof(Zipcode);
                public const string SameasPhysicalAddress = nameof(SameasPhysicalAddress);
                public const string Mobile = nameof(Mobile);
                public const string Fax = nameof(Fax);
                public const string Email = nameof(Email);
                public const string CountryId = nameof(CountryId);
                public const string Password = nameof(Password);
                public const string Notes = nameof(Notes);
                public const string DisableAccount = nameof(DisableAccount);
                public const string PortalAccess = nameof(PortalAccess);

                //Sacraments Details
                public const string DateofBaptism = nameof(DateofBaptism);

                public const string NameofGodFather = nameof(NameofGodFather);
                public const string NameofGodMother = nameof(NameofGodMother);
                public const string BaptisedPastor = nameof(BaptisedPastor);
                public const string BaptisedParishName = nameof(BaptisedParishName);
                public const string BaptisedPlacename = nameof(BaptisedPlacename);
                public const string DateofEucharist = nameof(DateofEucharist);
                public const string EucharistedPastor = nameof(EucharistedPastor);
                public const string EucharistedParishName = nameof(EucharistedParishName);
                public const string EucharistedPlacename = nameof(EucharistedPlacename);
                public const string DateofReconciliation = nameof(DateofReconciliation);
                public const string Completedworkshops = nameof(Completedworkshops);
                public const string DateofConfirmation = nameof(DateofConfirmation);
                public const string ConfirmationedPastor = nameof(ConfirmationedPastor);
                public const string ConfirmationedParishName = nameof(ConfirmationedParishName);
                public const string ConfirmationedPlacename = nameof(ConfirmationedPlacename);
                public const string ConfirmationSponsorname = nameof(ConfirmationSponsorname);
                public const string DateofDemise = nameof(DateofDemise);
                public const string DemiseedPastor = nameof(DemiseedPastor);
                public const string DemiseedParishName = nameof(DemiseedParishName);
                public const string DemiseedPlacename = nameof(DemiseedPlacename);
                public const string PlaceofDeath = nameof(PlaceofDeath);
                public const string PlaceofBurial = nameof(PlaceofBurial);
                public const string CauseofDeath = nameof(CauseofDeath);
                public const string Formations = nameof(Formations);
                public const string DateofOrdination = nameof(DateofOrdination);
                public const string OrdinatedPastor = nameof(OrdinatedPastor);
                public const string OrdinatedParish = nameof(OrdinatedParish);
                public const string OrdinatedPlace = nameof(OrdinatedPlace);
                public const string OrdinatedWitness1 = nameof(OrdinatedWitness1);
                public const string OrdinatedWitness2 = nameof(OrdinatedWitness2);

                public const string DateofMarriage = nameof(DateofMarriage);
                public const string HusbandName = nameof(HusbandName);
                public const string WifeName = nameof(WifeName);
                public const string MarriageParish = nameof(MarriageParish);
                public const string MarriagePastor = nameof(MarriagePastor);
                public const string MarriagePlace = nameof(MarriagePlace);
                public const string MarriageWitness1 = nameof(MarriageWitness1);
                public const string MarriageWitness2 = nameof(MarriageWitness2);


                //Education Details
                public const string StudyLevelIds = nameof(StudyLevelIds);

                public const string Institutions = nameof(Institutions);
                public const string ProgramIds = nameof(ProgramIds);
                public const string EducationYears = nameof(EducationYears);
                public const string EducationNotes = nameof(EducationNotes);
                public const string EducationIds = nameof(EducationIds);

                //Formation Details
                public const string StageId = nameof(StageId);

                public const string StageName = nameof(StageName);
                public const string FormationInstitutions = nameof(FormationInstitutions);
                public const string FormationyearFrom = nameof(FormationyearFrom);
                public const string FormationYearTo = nameof(FormationYearTo);
                public const string Formationstageplace = nameof(Formationstageplace);
                public const string FormationDateofjoin = nameof(FormationDateofjoin);
                public const string FormationCommunity = nameof(FormationCommunity);
                public const string FormationHead = nameof(FormationHead);

                //Holyorder
                public const string HolyorderId = nameof(HolyorderId);

                public const string HolyorderName = nameof(HolyorderName);
                public const string Holyorderdate = nameof(Holyorderdate);
                public const string HolyorderPaster = nameof(HolyorderPaster);
                public const string HolyorderParish = nameof(HolyorderParish);
                public const string Holyorderplace = nameof(Holyorderplace);

                //History Details
                public const string HistoryId = nameof(HistoryId);

                public const string PreviousOrgId = nameof(PreviousOrgId);
                public const string CurrentOrgId = nameof(CurrentOrgId);
                public const string AssignmentId = nameof(AssignmentId);
                public const string DateFrom = nameof(DateFrom);
                public const string DateTo = nameof(DateTo);
                public const string CreatedBy = nameof(CreatedBy);
            }

            public static class StaffProfile
            {
                public const string UserTypeId = nameof(UserTypeId);
                public const string DioceseID = nameof(DioceseID);
                public const string ParishId = nameof(ParishId);
            }
            public static class SongLibrary
            {
                public const string SongId = nameof(SongId);
                public const string SongTitle = nameof(SongTitle);
                public const string Songlyrics = nameof(Songlyrics);
                public const string SongLink = nameof(SongLink);
                public const string CategoryId = nameof(CategoryId);
                public const string Category = nameof(Category);
            }
            public static class MassRequest
            {
                public const string MassRequestId = nameof(MassRequestId);
                public const string FirstName = nameof(FirstName);
                public const string LastName = nameof(LastName);
                public const string Email = nameof(Email);
                public const string MobileNumber = nameof(MobileNumber);
                public const string MassDedicatedTo = nameof(MassDedicatedTo);
                public const string FirstChoiceDate = nameof(FirstChoiceDate);
                public const string SecondChoiceDate = nameof(SecondChoiceDate);
                public const string AdditionalInformation = nameof(AdditionalInformation);
                public const string RecipientStatus = nameof(RecipientStatus);
                public const string ParishId = nameof(ParishId);
                public const string UserId = nameof(UserId);
                public const string FamilyId = nameof(FamilyId);
                public const string FilterType = nameof(FilterType);
            }
            public static class Matrimony
            {
                public const string MatrimonyId = nameof(MatrimonyId);
                public const string ParishId = nameof(ParishId);
                public const string FromDate = nameof(FromDate);
                public const string ToDate = nameof(ToDate);
                public const string GiveAccess = nameof(GiveAccess);
                public const string RequestedUserId = nameof(RequestedUserId);
                public const string DioceseId = nameof(DioceseId);
                public const string RegisterNumber = nameof(RegisterNumber);
                public const string DateofMarriage = nameof(DateofMarriage);
                public const string BridegroomsFirstName = nameof(BridegroomsFirstName);
                public const string BridegroomsMiddleName = nameof(BridegroomsMiddleName);
                public const string BridegroomsLastName = nameof(BridegroomsLastName);
                public const string BridegroomsDOB = nameof(BridegroomsDOB);
                public const string BridegroomsAddress = nameof(BridegroomsAddress);
                public const string BridegroomsFatherName = nameof(BridegroomsFatherName);
                public const string BridegroomsMotherName = nameof(BridegroomsMotherName);
                public const string BridesFirstName = nameof(BridesFirstName);
                public const string BridesMiddleName = nameof(BridesMiddleName);
                public const string BridesFatherName = nameof(BridesFatherName);
                public const string BridesMotherName = nameof(BridesMotherName);
                public const string BridesLastname = nameof(BridesLastname);
                public const string BridesDOB = nameof(BridesDOB);
                public const string BridesAddress = nameof(BridesAddress);
                public const string Witness1 = nameof(Witness1);
                public const string Witness2 = nameof(Witness2);
                public const string AssistingMinister = nameof(AssistingMinister);
                public const string Remarks = nameof(Remarks);
                public const string PastorId = nameof(PastorId);
                public const string FamilyId = nameof(FamilyId);
                public const string PastorName = nameof(PastorName);
                public const string PastorRoleId = nameof(PastorRoleId);
                public const string MemberId = nameof(MemberId);
                public const string BridesFamilyName = nameof(BridesFamilyName);
                public const string BridegroomsFamilyName = nameof(BridegroomsFamilyName);
            }
            public static class WorkshipService
            {
                public const string ServiceId = nameof(ServiceId);
                public const string ServiceTitle = nameof(ServiceTitle);
                public const string ServiceDate = nameof(ServiceDate);
                public const string ServiceStartTime = nameof(ServiceStartTime);
                public const string ServiceEndTime = nameof(ServiceEndTime);
                public const string ServicePlace = nameof(ServicePlace);
                public const string ServiceMemo = nameof(ServiceMemo);
            }
            public static class WorkshipServiceItem
            {
                public const string ServiceItemId = nameof(ServiceItemId);
                public const string ServiceItemTitle = nameof(ServiceItemTitle);
                public const string Duration = nameof(Duration);
                public const string TeamId = nameof(TeamId);
                public const string SongId = nameof(SongId);
                public const string LedBy = nameof(LedBy);
                public const string Status = nameof(Status);
            }
            public static class Rehearsal
            {
                public const string RehearsalId = nameof(RehearsalId);
                public const string Title = nameof(Title);
                public const string RehearsalDate = nameof(RehearsalDate);
                public const string Schedule = nameof(Schedule);
                public const string Status = nameof(Status);
                public const string Description = nameof(Description);

            }
            public static class Activities
            {
                public const string ActivitiesId = nameof(ActivitiesId);
                public const string OrganizedByType = nameof(OrganizedByType);
                public const string Title = nameof(Title);
                public const string ActivityDate = nameof(ActivityDate);
                public const string Objective = nameof(Objective);
                public const string OrganizedBy = nameof(OrganizedBy);
                public const string SponsoredBy = nameof(SponsoredBy);
                public const string ParticipantMaleCount = nameof(ParticipantMaleCount);
                public const string ParticipantWomenCount = nameof(ParticipantWomenCount);
                public const string ParticipantChildrenCount = nameof(ParticipantChildrenCount);
                public const string Expenses = nameof(Expenses);
                public const string ResultsAchieved = nameof(ResultsAchieved);
                public const string GroupId = nameof(GroupId);
            }
            public static class Registration
            {
                public const string ParishId = nameof(ParishId);
                public const string SubParishId = nameof(SubParishId);
                public const string FamilyId = nameof(FamilyId);
                public const string FamilyHead = nameof(FamilyHead);
                public const string FamilyCardNumber = nameof(FamilyCardNumber);
                public const string FamilyName = nameof(FamilyName);
                public const string HomePhone = nameof(HomePhone);
                public const string FamilyEmail = nameof(FamilyEmail);
                public const string MailingAddress1 = nameof(MailingAddress1);
                public const string MailingAddress2 = nameof(MailingAddress2);
                public const string MailingCity = nameof(MailingCity);
                public const string MailingStateId = nameof(MailingStateId);
                public const string MailingZipCode = nameof(MailingZipCode);
                public const string MailingCountryId = nameof(MailingCountryId);
                public const string PhysicalAddress1 = nameof(PhysicalAddress1);
                public const string PhysicalAddress2 = nameof(PhysicalAddress2);
                public const string PhysicalCity = nameof(PhysicalCity);
                public const string PhysicalStateId = nameof(PhysicalStateId);
                public const string PhysicalZipCode = nameof(PhysicalZipCode);
                public const string PhysicalCountryId = nameof(PhysicalCountryId);
                public const string IsPhysicalAddress = nameof(IsPhysicalAddress);

                //Members
                public const string Prefix = nameof(Prefix);

                public const string UserId = nameof(UserId);
                public const string FirstName = nameof(FirstName);
                public const string MiddleName = nameof(MiddleName);
                public const string LastName = nameof(LastName);
                public const string Email = nameof(Email);
                public const string Dob = nameof(Dob);
                public const string Gender = nameof(Gender);
                public const string Hispanic = nameof(Hispanic);
                public const string Ethnicity = nameof(Ethnicity);
                public const string Relationship = nameof(Relationship);
                public const string Mobile = nameof(Mobile);
                public const string Notes = nameof(Notes);
                public const string MaritalStatus = nameof(MaritalStatus);
                public const string BEC = nameof(BEC);
                public const string Signinaccess = nameof(Signinaccess);
                public const string IsActive = nameof(IsActive);
                public const string RandomPassword = nameof(RandomPassword);
                public const string Password = nameof(Password);
            }

            public static class AlertMessages
            {
                public const string UserID = nameof(UserID);
                public const string MessageID = nameof(MessageID);
                public const string AlertName = nameof(AlertName);
                public const string ProcessStatusID = nameof(ProcessStatusID);
                public const string IsProspectAlert = nameof(IsProspectAlert);
                public const string EmailStatusID = nameof(EmailStatusID);
                public const string VoiceStatusID = nameof(VoiceStatusID);
                public const string TextStatusID = nameof(TextStatusID);
                public const string LaunchDateTime = nameof(LaunchDateTime);
                public const string EmailSubject = nameof(EmailSubject);
                public const string EmailReplyTo = nameof(EmailReplyTo);
                public const string EmailMessage = nameof(EmailMessage);
                public const string VoiceRecordingID = nameof(VoiceRecordingID);
                public const string SMSText = nameof(SMSText);
                public const string Members = nameof(Members);
                public const string DeletedAttachments = nameof(DeletedAttachments);
                public const string AlertType = nameof(AlertType);
                public const string Bcc = nameof(Bcc);

                public const string Email = nameof(Email);
                public const string CallerID = nameof(CallerID);
                public const string ESTOffset = nameof(ESTOffset);
                public const string VoiceCallPhone = nameof(VoiceCallPhone);
                public const string VoiceCallPhoneExt = nameof(VoiceCallPhoneExt);
                public const string FailedAlertEmail = nameof(FailedAlertEmail);
                public const string SenderName = nameof(SenderName);
                public const string OrgId = nameof(OrgId);
                public const string ParishId = nameof(ParishId);

            }
        }
    }
}