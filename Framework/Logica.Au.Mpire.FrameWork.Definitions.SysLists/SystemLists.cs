using System;

namespace Logica.Au.Mpire.Framework.Definitions.SysLists
{
    //
    //mdp       02/Nov/09       vsn 1.1             Plumbing Modifications
    //
    //mdp       04/Mar/10       vsn 1.2     #4651   Plumbing Modifications for UFE

    // This struct defines the list ID's of all system lists
    public struct SystemLists
    {
        #region System Lists . . .
        // System Lists
        public const string CardType = "8316A9ED-DC45-4F5C-8426-3305F600313A";
        public const string CaseStatus = "69B7335A-9BBD-43B7-BEA0-32E52AB8B79E";
        public const string ContactResolution = "335EC70B-90FD-400F-AD84-924C20622599";
        public const string ContactStatus = "48CB7702-9E9B-4D79-BD69-11FF59B2B91A";
        public const string CreditNoteStatus = "B5E1A4FE-265C-41C2-8431-9873DAE04C32";
        public const string CreditNoteType = "A0DFF057-8E7F-4853-89EE-CEDB34AADE7E";
        public const string DeliveryMethod = "B6541C05-6FFD-4343-A380-E299D5341FE7";
        public const string DiscountCustStatus = "6F191E3C-016C-444A-9472-F0D1989603D0";
        public const string DiscountType = "9F1DCFDE-B27F-457D-A7D0-A311D26D7E91";
        public const string LL_Category = "19168FCA-4E68-4E7A-A3B2-5990DF0F3CCB"; // renamed from 'DocumentCategory'
        public const string LL_Entity = "084E2D42-611E-4AE1-AA6E-29D484B5F86C";
        public const string LL_LocationIdentity = "CC3CC0EE-DB10-4C14-9EA9-AE86692B2C3B";
        public const string ExternalSystem = "AF642B0A-1AA4-47B0-9498-81E34E320EF1";
        public const string FeeRaisedType = "5E1FE22A-2AD6-4979-962F-DEA87F86FC0F";
        public const string FeeStatus = "3479C4A9-F3D5-4991-B4CC-86E3CF56DC23";
        //public const string FilePurposeType			= "1CFEE5B9-9C2C-4790-9ED2-A11204F4D12B";  //Removed on 05/05/2003
        public const string MpireTableEntity = "96AB1FBC-A7C0-40EC-B734-73A003745924";
        public const string OrderStatus = "17489407-2A95-4853-977A-E367EB334654";
        public const string PaymentMethod = "ACFF011F-7C42-4E26-BDCE-F2E5918C9F13";
        public const string PrefDelMethod = "B6541C05-6FFD-4343-A380-E299D5341FE7"; //PBB12/02/2003 10:20AM Changed to be the same as DeliveryMethod
        public const string ReceivedMethod = "248629C3-ED6A-4C61-8E97-CC6E68FF61EB";
        public const string OutputType = "796D05C6-1054-4254-9C01-F3CBC95D0FD3";
        public const string OutputStatus = "0FE2C0FA-FCEC-4C53-BC76-27E09AF20A5E";
        //public const string OutputDefType			= "D8BF3DC2-4E99-4215-ACF9-2CD6E959918E"; // BJT 29/04/03 OutputDefType is redundant.  Use OutputType instead.  Note: This may break some existing code!!!
        public const string OutputPartType = "0C0F3632-2911-4E88-8633-25C7221E6B4D";
        public const string OutputUndeliveredReason = "F4808939-7026-4E64-8FD4-A00F955787F7";
        public const string RootEntity = "7576DFB9-37C6-4947-82CC-4E8BEB0C8C34";
        public const string CustomerSummons = "6C2F823B-757A-42A3-8F84-3D4EC22FB8FD";	// DKO added 16/05/03
        public const string PropertyScheme = "4FEC56FE-293B-4669-868C-0CE1DF5553BC";	// DKO added 16/05/03
        public const string SpecialMeterReading = "1CC250C8-A959-4807-AB47-3C9CA2ABCFE6";	// DKO added 16/05/03
        public const string DrainageTariffs = "FC14CCE4-2EE7-42FE-B1B8-D79DCA13A055";	// DKO added 16/05/03
        public const string NotRated = "86224A8E-B218-4EB7-BB65-1CB4B26BCD64";	// DKO added 16/05/03
        public const string ParksTariffs = "FEC4971D-E6C6-4557-A61A-FC69E2F2E7CC";	// DKO added 16/05/03
        // Stage 2 System Lists - Added by BJT 18/Dec/2003
        public const string ServiceInstallationCompleteStatus = "194F1649-1C4D-4C24-B27C-F743D0E49054";
        public const string ServiceRemovalCompleteStatus = "50F6DFC0-3311-4BCA-B25D-7607D0DA1B3B";
        public const string TenderTypes = "5677579D-3D2B-4483-8A59-A81CCD5E7129";
        public const string DelAuthApprovalStatus = "7BF3EEC9-83EE-472D-A91B-9A5EE3320F73";
        public const string FinancingOption = "D0552F9C-B329-42C1-AEEA-61BEE2FFDCC4";
        public const string YesNo = "D270E586-665E-478B-BD7C-BBD387D78125";
        public const string CustCallBackReq = "51FBB59A-224D-44D7-9F29-296D3D715C3B";
        public const string InstallationSource = "E06D1C50-DA96-4119-A92F-3C84FCE9C67A";
        public const string PlanStatus = "D2455642-8709-4604-AFB5-9EE801AE05B8";
        public const string PlanType = "4A7ED4CB-B288-43A3-9C45-0634846380EE";
        public const string BuildoverAssessmentOutcome = "6CB234D3-AAFD-420E-A90D-07D9E227F2B3";	// TT#3474 - BJT 27/2/04
        public const string BuildoverAppealOutcome = "1A630FE4-8072-48BC-B437-81539F994598";		// TT#3474 - BJT 27/2/04
        public const string AssetService = "A45FAD67-236F-4787-87E3-790406D51ABF";		// TT#3677 - PCS 27/2/04 moved from user -> system
        public const string ServInstContractor = "387CCF0F-33FD-4954-B511-44ADF8FAF4A9";		// TT#1815, dko 09/01/06
        public const string ServRemovalContractor = "387CCF0F-33FD-4954-B511-44ADF8FAF4A9";		// TT#5184, lrh 12/03/19 -> Have begun utilizing RemovalContID field. Lookup values are same as installation contractor values
        public const string ReUseType = "6AFC9D90-9F44-4661-B0B4-A1266B1EAB5C";		// TT#1814, dko 09/01/06
        public const string ServiceInstallationTappingStatus = "783A15AD-4DD3-28AE-E054-00144FEADF8C";
        public const string ServTapContractor = "387CCF0F-33FD-4954-B511-44ADF8FAF4A9";
        // vsn 1.1
        public const string BusinessProcessId = "3F7438F7-0C17-4c06-8CCB-85FCE319CFA8";
        public const string IntegratedWaterTypes = "8DB22FFD-3199-4D55-99E3-925490DDAFFE";       // TT#4652, rgc 12/03/2010
        public const string PFIImportStatus = "7FA07E26-7D7E-438A-E054-00144FEADF8C";
        public const string PFIActiveStatus = "7FA07E26-7D80-438A-E054-00144FEADF8C";
        public const string PFIErrorClassifictions = "7FAEB2B9-9488-6D19-E054-00144FEADF8C";

        #endregion

        #region User Modifiable Lists . . .
        // User modifyable Lists
        public const string AddressType = "B207EDB1-AAA7-4B4B-820C-3880C3CBC59A";
        public const string ClassificationType = "450A72C1-6ACC-4D52-AD71-E48005A9300E";
        public const string ClauseOrigin = "DE3FC220-C0ED-4CFC-8D46-AA03F0F668CD";
        public const string CustomerRanking = "42C8583B-00C8-4CDB-9AC9-052B2D8ED3E0";
        public const string CustSuppType = "84770347-7C80-4727-AAAA-1BAB4A29FEE6";
        public const string ContactMethod = "1FEBD7AD-7CA6-4A64-95D2-F58E0308C2F9";
        public const string CouncilList = "71037AC8-AE23-4A6B-A059-AF89E5BC2FC7";
        public const string DirectoryType = "C1CBAA3B-2AF9-452F-9AB2-437496BD0671";
        public const string FixLocationPriority = "42010575-45E3-48FB-BC3C-3FC7C337E625";
        public const string FixLocationCallBack = "22A21050-057C-4953-B585-B0DCF9D01E4B";
        public const string NoCostReason = "A920FCEC-E62E-4E67-9A9A-727E97A55021";
        public const string NoteType = "44DFF3CC-190D-4AB8-B082-BD94BA9FFB59";
        public const string PrintSection = "CEDFC621-1098-45E1-B3A5-5B6EBE7E077A";
        public const string PropertySchemeList = "9686385C-9903-4E60-8153-1316478B70C4"; //added by Sev on 08/04/2003
        public const string PropSuppType = "8F006914-800E-4503-B37D-34F8F7758CC9";
        public const string RoleReqSuppType = "8DA3CBA3-8DFB-444D-B321-4650AC338BDC";
        public const string State = "BBEE2782-5F60-4862-9601-3C205781F6CE";
        public const string StreetType = "B7F80406-CB68-4F5C-BE3C-D57113CEC923";
        public const string Title = "AB58E08E-C9C6-4154-9414-6502867DD83E";
        // Stage 2 User Lists - Added by BJT 18/Dec/2003
        public const string PipeSize = "CAEFE55E-5B2F-4D4B-B365-BFD34BAB30E5";
        public const string Material = "4D28FD1A-240C-4541-94D9-AE2515FF7DFA";
        public const string DepthRange = "EB2CBA27-18AB-43EE-A07B-8CFB7CE80A7B";
        public const string ReferralFilter = "9E99119A-AE44-4697-90E7-8E3AD746D078";
        public const string ConditionServices = "A30D46D6-08BE-4CD4-A4AA-DAFAF478561E";
        public const string ServiceConditionFilter = "CB2DB48F-8005-43C8-9831-15AD46142A4A";
        public const string ProposalOptions = "939602BA-3B5B-4D34-8524-37796FB2C887";
        public const string ClauseFilter = "0D39E1AE-7BE4-4E12-BB68-94AAB6525B39";
        public const string WaterPricingZones = "0A3958E4-C12D-416D-9B53-215DE87167D5";
        public const string SewerPricingZones = "5A19B1EF-F94F-42CC-84C5-EBEC23F05D52";
        public const string RecycledWaterPricingZones = "652D8340-3CBB-43c7-81BD-8DE6CF190705";   // TT4652 rgc 29/01/2010
        public const string CommunalType = "5F16B1BC-6CF4-417E-BEE0-3CFE06C84ED7";
        public const string MeterPurpose = "2268C7BE-1E6E-41E7-BFCA-C3F640FCD5F0";
        public const string TappingSize = "D578AAED-64BE-415A-974B-3DCC366C6313";
        public const string TappingType = "0973D8FD-4261-4ACF-BB2A-61EA63B0F853";
        public const string PluggingSize = "6844DDE2-A841-48C1-B811-5E4360D1E17E";
        public const string MainMaterial = "005B2D28-22A3-4E36-94D2-50D3DE413E68";
        public const string MainSize = "CB3BD0B4-34DF-474C-8412-6ABCD28755ED";
        public const string TappingOffset = "AD81D1C0-25E6-4E71-9441-8A4D19C42EC3";
        public const string RemovalType = "D7ABE57D-861F-48AA-977E-0AD806AA5ACD";
        public const string RateType = "90D7AA3A-4CC3-421D-8813-E1D79DE4525C";
        public const string CreditType = "4C12D617-6AA0-4FEB-B8A4-F27F25286BD4";
        public const string CreditService = "1E123F6F-13C9-4375-8842-E09DB5190669";
        public const string PICTestType = "ECF494C1-0824-4F43-B5CB-ED59F579E458";
        public const string CheckOutcomeList = "FE15D755-EB98-4B56-BEAF-B8348AE2AB92";
        public const string BondingType = "81B32E35-26A9-409B-B3E5-EE2487B94489";
        public const string ApplicationType = "FD9934F6-A337-41DE-8765-8E799EB58A89";
        public const string TypeOfDevelopment = "36ED0522-AFE5-4242-B3C1-D2ADB454E5EB";
        public const string ProposedUse = "9572970A-28C9-4C9E-96E2-5B58FF89C6C6";
        public const string MinorWorks = "D7B6F2DF-F2BA-4BED-B7D7-BE69AE4FEAB4";
        public const string OffsetBasis = "D8E56615-3182-4601-818A-C32A6F461329";
        public const string TypeOfStructure = "B21D889B-6412-41DB-B8A8-D5E0BCF3FC88";
        public const string TitleOfficePurpose = "7A50BC82-B2DB-4400-A37F-BA00708BD34D";
        public const string IndustryType = "ABC6829D-62D1-459E-8000-E692EDBAA7FC";
        public const string OrdinaryServices = "F3C4E8E9-4999-47A7-A0FF-DE66BFA64C8E";
        public const string BacklogRespones = "F5221DD0-6498-4A67-A0B9-5D7FDCC5EE58";

        public const string MeterSize = "CBC20DBD-CB83-4615-9AF2-811BDC83946F";
        public const string TempYears = "A805A9AA-5A18-4F56-9976-37FDEEB45C67";
        public const string ExitServeFact = "BE082027-DF08-4F65-9255-5C1F77EB4751";
        public const string PSPMedium = "C5DCB9B2-37F1-4884-B262-CD9F93815AC3";
        public const string TownPlanningApproval = "3C7EFA3F-BC2C-433B-BD2B-F63C86A1260C";
        public const string AssessmentOutcome = "764B3247-FB01-4416-91B2-4E0D9F28DF6D";
        public const string HazardLevel = "7832D8B3-022E-4EF9-A713-D7585926A554";
        public const string SCAP = "00F39586-395E-470C-AEDF-D2E698215044";
        public const string DZAP = "C6DD323D-D8C2-48AC-A1BF-9F6300EB27F8";
        public const string AddendumType = "6A4DA424-4DDA-4C97-9352-6D74FEE3B027";
        public const string FinaliseType = "6EA9AC24-687C-4386-9E9C-902E064D27FC";
        public const string ConsentType = "9E3E424D-383F-49A2-BBCD-8A78DF85FC82";
        public const string QAServices = "8B31E663-CFF8-480D-9741-2F7540E5177E";
        public const string TappingItems = "D8F1BEF0-4501-4BA8-AE72-98365B1F1468";
        public const string RemovalItems = "FDBB8053-E55F-441A-AD37-687F4E88EA16";
        public const string InstallationType = "CECCD472-EE26-4462-B4CA-5AD247A85B94";

        public const string BusinessType = "A4BE26F5-9E11-42C6-A2D3-94D37EBDA518";
        public const string SubDivAssessOutcome = "E5FF69D3-393B-450D-92AB-2A5C1CF63544";
        public const string SubDivTpCertAssessOutcome = "E11F9BED-2651-4b55-A575-D63B67C98C7F";     //TT#4328 RGC 02/09/2009
        public const string SubDivisionApproval = "79289400-E9B1-4ABE-AEAB-46C489475C7D";
        public const string ItemSource = "2917166A-7C0A-49CD-9269-588B1B6AFB23";
        public const string SpecialArea = "AB8EF9A3-725D-4284-9C8B-385E184DA2A8";

        // TT 3314 for fileattachment mods PCS 5/1/04
        public const string FilePurpose = "7DCDFE74-22C0-47AC-AC6A-C175F36F2E71";

        public const string TestPriorApproved = "3DE5876A-3D16-4DD6-AAED-B92A013182EF";

        // Adding user lists that are missing
        public const string PSPStatus = "4EE76080-F78D-41A1-89E9-022500078CDB";
        public const string SDAssessmentOutcome = "2EBC966E-1CE2-49C7-B2BE-9834325C0FE3";
        public const string ServiceInstComplete = "194F1649-1C4D-4C24-B27C-F743D0E49054";
        public const string ServiceRemComplete = "50F6DFC0-3311-4BCA-B25D-7607D0DA1B3B";
        public const string DelAuthApproveStatus = "7BF3EEC9-83EE-472D-A91B-9A5EE3320F73";

        // Added for the Plumbing Changes, moving some Application Types to their Own Application Types
        public const string WaterApplicationType = "23EE5DE6-7258-47b7-A94B-89DFC34A46EB";
        public const string SewerApplicationType = "61B9CF20-579A-4efa-A6F8-089E635477BC";
        public const string WaterSewerApplicationType = "C65EF4B7-1A82-420e-B0F2-9DA36AE21D9E";
        public const string CDGApplicationType = "9F777DF7-2E9C-408c-BB5E-C67EF6CDF2DD";
        public const string MSAQApplicationType = "F08A35E9-99C4-4B12-B0D3-0BF3B386ACBF";

        // Recycled Water Inspection types
        public const string RecycledWaterInspectionType = "4ACFB4CE-7425-4792-9518-42BDAECE84C3";

        // SDO Pipe status from SDO service call
        public const string SDOPipeStatusList = "6661E9BA-CF9E-4F7B-E054-00144FEADF8C";

        //TT3301 Backflow Rating
        public const string BackflowRatingList = "6E679143-191A-3C22-E054-00144FEADF8C";

        public const string StepsList = "6F8402BE-4A9F-1700-E054-00144FEADF8C";
        #endregion

    }

    //These structs define the list value item ID's for each system list

    #region AddendumTypeList

    public struct AddendumTypeList
    {

        public const string Bonding = "89FB6E30-2D0B-405E-82E7-0857DAAB15A9";
        public const string Financial = "B01E3CD1-3761-4401-BA69-8984E6FEADD8";
        public const string Servicing = "B6960358-6A80-4E2E-93AF-DA4183608E37";
        public const string FinancialAndServicing = "53604EC4-6BF9-4DE4-A860-BB100824D136";

    }
    #endregion

    #region ApprovalStatusList
    public struct ApprovalStatusList
    {
        public const string Approved = "A7F480FC-D915-4A34-87B0-473D0D905825";
        public const string Derived = "352CA32D-D013-4A9A-B5CE-328E5AAD5992";
        public const string Pending = "43FA4729-6437-4B3B-8DF5-EBF0CD3FCC19";
        public const string Rejected = "CF4C7EB4-8005-4FD6-A784-7921A32734E8";

    }
    #endregion

    #region BacklogResponseList
    public struct BacklogResponseList
    {

        public const string InspectionRefused = "4D7B92EF-D6BE-4043-BA89-C2AAD42B3E70";
        public const string VacantLand = "2420BF69-7296-42E6-A05A-56CC81E2ABC1";
        public const string AppointmentMade = "D3881A81-BE96-4D6A-8318-6C780099D569";
        public const string NoResponse = "BC5D97D1-6671-4A4F-A74B-D3CEFB02ECE7";
        public const string ChangedAddress = "0433370A-9676-4AD3-81A6-4314B66DB4E0";

    }
    #endregion

    #region BondingTypeList
    public struct BondingTypeList
    {
        public const string CashGuarantee = "51A59C24-CC89-4183-98BC-2F69D8FC07BE";
        public const string BankGuarantee = "1379A39D-A849-4484-9F45-5EADA5821BE5";
        public const string InsuranceBond = "A1CFA448-05F1-4268-A8FA-1CD719017D7D";
        public const string Other = "56A9715D-CA4A-4EFD-A870-D501928AC9C3";
    }
    #endregion

    #region BuildoverAssessmentOutcomeList
    public struct BuildoverAssessmentOutcomeList
    {
        public const string Approved = "8F568631-221C-4FD9-9B19-5E95E2D3418D";
        public const string NotApproved = "701C8959-E9E6-4AB9-9827-1E0AC2AAFD25";
        public const string NotRequired = "E05AF204-A728-4e4e-B15F-6DE67A7109A1";

    }
    #endregion

    #region BuildoverAppealOutcomeList
    public struct BuildoverAppealOutcomeList
    {
        public const string Approved = "AD193305-3316-4B31-B28E-BE47A5AD435C";
        public const string NotApproved = "B34AEF21-573B-4A26-8BE5-64D1A7E4E96F";

    }
    #endregion

    //vsn 1.1
    #region BusinessProcessList
    public struct BusinessProcessList
    {
        public const string Developer = "721C9D08-C20C-4d28-A9C8-C8D4E1D10E41";
        public const string Plumbing = "AE7AA433-711C-47b6-8878-7273BDC907B3";

    }
    #endregion

    #region CaseStatusList
    public struct CaseStatusList
    {//PBB12/02/2003 10:50AM Changed all constants and values to reflect database.
        public const string New = "980F5DB0-4C17-4A39-B618-F8D4C6D4B093";
        public const string Saved = "58D1B6B3-B84E-4E99-9673-85CCBE79AE2C";
        public const string Submitted = "966E3839-9964-4CCC-93DE-A644543DD2AE";
        public const string Running = "48BFCFE6-C1D4-4996-A294-4467972CD8A2";
        public const string Completed = "D5AE1DA0-77DC-4DBF-B7F0-94D5743507D8";
        public const string Cancelled = "F51AB12E-6191-49CA-83AE-5C098BFEB0B5";
    }
    #endregion

    #region ContactStatusList
    public struct ContactStatusList
    {//PBB12/02/2003 10:52AM Changed all constants and values to reflect database.
        public const string New = "4AB3D7BA-2812-4DAF-A109-0E92F1853579";
        public const string Saved = "33F890B4-62A6-4A2F-99C4-8F7F7DB7086F";
        public const string Submitted = "F96D2AD5-C5B0-4EB5-84F8-85B781A5D0D7";
        public const string Running = "39C7095C-970B-42EF-88D1-C854C222AD81";
        public const string Completed = "1480C122-2AC6-4CAD-8B92-A2B510676C6A";
        public const string Cancelled = "A0AD3CAC-D07B-4F90-89AD-94D094A04ED2";
    }
    #endregion

    #region ClauseOriginList
    public struct ClauseOriginList
    {
        public const string ICE = "9E24F193-392A-4ADD-B6B0-8E4615036B97";
        public const string Custima = "334DEFE0-8DE7-423C-BC05-67B30A5FDB90";
    }
    #endregion

    #region CreditNoteStatusList
    public struct CreditNoteStatusList
    {
        public const string CreditNoteActive = "B6B690A5-D3E4-4F95-B65C-120733589AF9";
        public const string CreditNoteApprovalPending = "8676859B-5DEE-41CD-8048-B69A4F0B38D6";
        public const string CreditNoteApproved = "5D7080C5-5552-4A79-9206-CDAEEBA0C3CD";
        public const string CreditNoteRefunded = "4D1EA807-0DEC-4D20-90A8-C18033331CC4";
        public const string CreditNotePayment = "B72B9DEE-8DDC-4455-AF98-B87C6BA32157";
        public const string CreditNoteOffset = "B8B7E4DF-36E6-4C5A-BCA6-34125E18A5C5";
    }
    #endregion

    #region CreditNoteTypeList
    public struct CreditNoteTypeList
    {
        public const string CreditTypeOverpay = "64E37569-309C-4785-A3E3-FFAA257FA171";
        public const string CreditTypeCancel = "6C83F34D-1615-47BA-80FA-605BA5181FB0";
        public const string CreditTypeRefund = "156A192D-9049-496D-87CF-8DB19198F484";
        public const string CreditTypeAccountOverpay = "A7278D1C-1129-4787-87BE-9759AB385B7B";	// added by dko, CR#5783 29/03/05
        public const string CreditTypeAccountCancel = "7C65652E-80D9-4A87-BB05-0D071A6741B7";			// added by dko, CR#5783 29/03/05
    }
    #endregion

    #region CreditCardTypeList
    public struct CreditCardTypeList
    {
        public const string CardTypeBankcard = "953C58B3-9A85-400E-A8B0-111BD7D5BF37";
        public const string CardTypeVisa = "83E8F6C6-0644-4E51-8485-F04E1A8AD819";
        public const string CardTypeMaster = "080EAE8A-E854-4D7F-B653-609919D2E878";
        public const string CardTypeDiners = "18C8271F-D7F1-4384-8085-2838EFC8BC1B";
        public const string CardTypeAmex = "1F6A0BD8-1C10-498F-89EC-3B25F9E4DC10";
    }
    #endregion

    #region CustCallBackReqList
    public struct CustCallBackReqList
    {
        public const string NotRequired = "E1F09FDF-29EF-4C27-860D-7BC8E8713498";
        public const string UnableToContact = "10DF12D5-1452-4B18-97F5-6128FA8B6A0F";
        public const string CustToCallBack = "5A08FA97-AFD8-4533-A215-6ED5988EC65C";
        public const string ContactDetailInvalid = "B33F4CD7-0B09-4A4B-99F7-ADA966ECC494";
        public const string Other = "E9B347DA-66DF-41EB-94A3-0C9CA93284B3";

    }
    #endregion

    #region CustomerSuppList
    // needed for TestPrior form as we need to get the PlumberRegID ID - #3240
    public struct CustomerSuppList
    {

        public const string OnTap = "527F4DEC-286B-4C8E-902B-49CA258C5BA9";
        public const string RegistrationCurrency = "C9449742-9F7A-4038-9470-1D1CA1BBA155";
        public const string RegistrationID = "D5EF193D-9B57-42B4-A4C4-25A874911955";
        public const string Applicant = "69C131CE-0596-4C4A-B124-21E63BF073E1";
        public const string Architect = "00970B48-93F6-45C1-8066-8C7BAC82D52F";
        public const string Builder = "6B8BCCB9-88A5-44E8-A1E4-576F73BFDC6F";
        public const string ConsultingEngineer = "3285A863-B6AB-44C8-9210-54D7D2EBC895";
        public const string ConveyancerSolicitor = "42327F51-1DA2-47AE-B4BF-5FB4BFFDBC64";
        public const string Developer = "71849E4B-8847-4A92-91E1-BB32D04B1B0A";
        public const string Draftsman = "51748EAC-3B90-45B6-81D5-1216A43AF49F";
        public const string Plumber = "B81B6365-24F5-47EA-9878-70F0269F3F2D";

    }
    #endregion

    #region DeliveryMethodList
    public struct DeliveryMethodList
    {

        public const string Email = "2443DE8D-840E-4302-B53E-EC25528224F5";
        public const string Mail = "1D282C0D-C406-46ED-B800-F14D94B950AD";
        public const string PickUp = "52EBEF8E-DA66-4467-9B35-5E3AE122A6E0";
        public const string Fax = "A92AA4BC-589B-40CC-8CFA-42AF24D23B27";
    }
    #endregion

    #region DiscountTypeList
    public struct DiscountTypeList
    {
        public const string ReceivedMethod = "F60BD26D-9DE4-4FEF-9298-53F5D777F5F6";
        public const string CustomerStatus = "45609D9D-36A4-4AE9-BA26-DAB6F53F3AD4";
    }
    #endregion

    #region DirectoryRefList
    public struct DirectoryRefList
    {
        public const string Melways = "920FF5AA-CFF6-48DB-94E5-6E3EC8163ED9";
        public const string VicRoads = "23A303B5-18AE-455C-A4D2-ACEF3CFE962D";
        public const string Other = "B9417069-CFF3-46D0-B6B3-1F096C8DEDE3";
    }
    #endregion

    #region ExternalSystemList
    public struct ExternalSystemList
    {
        public const string PaymentGateway = "9FBC01C2-B3AE-62A2-E044-00144FEADF8C";
        public const string CardGate = "7BC93EE9-1BF7-475B-BDBC-21F8663ABB90";
        public const string CashLink = "0FC668B1-C32C-43F3-A983-936DC0D6201C";
        public const string Computron = "40272E16-DBE2-4404-B2BE-BA090A24A465";
        public const string Custima = "1F39DE28-6A0B-4BD7-B629-177D424447D6";
        public const string AssetMap = "DE704D40-3820-4CAC-B58B-F53047C89EB7";
    }
    #endregion

    #region FeeRaisedTypeList
    public struct FeeRaisedTypeList
    {//DT 4/03/2003 10:25AM changes values to reflect database
        public const string FeeRaisedTypeApplication = "5DB02F2C-2B34-4088-B636-546807887224";
        public const string FeeRaisedTypeProposal = "E0536B63-49DB-43E7-BBF4-9A5B67374BAC";

        // PCS 13/2/04: added this to support the GenerateFeesBroker requirement.
        public const string FeeRaisedTypeUser = "48F01591-2AA6-4F5C-8032-CE0E3CD4E997";
        public const string FeeRaisedTypeAddendum = "C90DF4C9-1A16-4D61-96FF-DECABDCB6D95";

        // PCS 29/04/04 : extened for MerchantFees - used in submitpayment
        public const string MerchantFee = "E07C3B31-E18D-42F2-A96F-DEB4A78D9B39";
    }
    #endregion

    #region FeeStatusList
    public struct FeeStatusList
    {//PBB12/02/2003 10:52AM changes values to reflect database
        public const string FeeStatusActive = "E551BD47-4D30-4B2D-B522-4818EC714FBD";
        public const string FeeStatusPaid = "E6BB9AD4-DEE6-4B9D-AE57-48ABBD03230B";
        public const string FeeStatusReCalculated = "656CB3FF-9959-4A85-B7A4-7F7239FA803D";
        public const string FeeStatusCancelled = "0685C91D-DE5E-4CB2-AA27-907BED99CACC";
    }
    #endregion

    //	#region FilePurposeTypeList
    //	public struct FilePurposeType
    //	{
    //		public const string FilePurposeTypePSP		= "83D9900A-4F26-4C5A-BF10-573FF6E49D73";
    //		public const string FilePurposeTypeLetter	= "A8E361E1-9445-427D-A40B-7744ED1A7D97";
    //		public const string FilePurposeTypeEncumbrance	= "BDF73212-C9F3-4385-B9D7-49DB74928A1F";
    //	}
    //	#endregion

    #region FinancingOptionList

    // defined - 19/02/04 by MG
    public struct FinancingOptionList
    {
        public const string Immediate = "5EC3260C-0432-4E79-9D50-AB1E4E453A33";
        public const string Deferred = "F7D32D20-875B-41CB-933C-1C6268D93F0A";
    }
    #endregion

    #region FixLocationCallBackList
    public struct FixLocationCallBackList
    {
        public const string CustToCallBack = "873BF0B4-C843-4F2A-A534-DBB73488FAC2";
        public const string ContactDetailInvalid = "B9FFAB3E-8D4F-4A17-A40B-74A394087E47";
        public const string Other = "4594F1BF-3953-44C3-B8F3-0735B1D00D88";
        public const string Cancel = "7028C5B7-99D5-4D5A-8C46-350441BFE0BF";
        public const string LocationFound = "4C54A498-8539-4E01-8A57-6768481F7C1C";
        public const string UnableToContact = "6D4CA602-245B-4AF4-820D-A25EAEDC4239";
    }
    #endregion

    #region FixLocationPriorityList
    public struct FixLocationPriorityList
    {
        public const string Urgent = "A6DC40C6-538D-4A71-84E9-AAED1B3FAB53";
        public const string Routine = "72337D9F-40E6-4DAC-92B2-3B121EBE7BCC";
    }
    #endregion

    #region LL_CategoryList

    // TT3173 - separate the LL_CategoryList into two lists used to separately
    //			define the FileCategory and the FilePurpose. See also the FilePurposeList
    //			below.

    public struct LL_CategoryList
    {
        public const string ICEDocument = "42D20F66-9BDB-45A7-AF39-D36293DCDA0F";
        public const string PSPDocument = "CAC1863D-BD9E-416A-AD2D-E36DDFF49F94";

        // These all move to file purposelist
        //		public const string FilePurposeTypePSP		= "83D9900A-4F26-4C5A-BF10-573FF6E49D73";
        //		public const string FilePurposeTypeLetter	= "A8E361E1-9445-427D-A40B-7744ED1A7D97";
        //		public const string FilePurposeTypeEncumbrance	= "BDF73212-C9F3-4385-B9D7-49DB74928A1F";
        //		public const string S01MatchPro				= "601653CA-C186-4596-9A6B-747468E86707";
        //		public const string P1802SchemeT			= "1FEB48C7-819E-4720-9517-2DD9D610BB3E";
        //		public const string P1802CSchmeT			= "B5543048-4DA6-49E1-A28D-9D3F616DA5A0";
        //		public const string P1815SummonT			= "32D73940-83E3-4ACA-9CB4-70467DF7D784";
        //		public const string P1815CSummnT			= "4D8B4661-F22F-465B-AE5A-3E8F8E4780B0";
        //		public const string ConsolidatedOutput 		= "B166F952-4CD2-4BBE-8D30-0B199662B297";
    }
    #endregion

    #region FilePurposeList

    // Note that even though this is a user list, these constants are still defined
    // for use in stage 1 PFE screens and brokers.

    // TT3173 - separate the LL_CategoryList into two lists used to separately
    //			define the FileCategory and the FilePurpose. See also the LL_CategoryList
    //			above.

    public struct FilePurposeList
    {
        public const string GeneralICEDocument = "2D80B397-623E-4F3B-AF3A-83A97C41958C";
        public const string FilePurposeTypeEncumbrance = "BDF73212-C9F3-4385-B9D7-49DB74928A1F";
        public const string FilePurposeTypePSP = "83D9900A-4F26-4C5A-BF10-573FF6E49D73";
        public const string ConsolidatedOutput = "B166F952-4CD2-4BBE-8D30-0B199662B297";
        public const string FilePurposeTypeLetter = "A8E361E1-9445-427D-A40B-7744ED1A7D97";
        public const string S01MatchPro = "601653CA-C186-4596-9A6B-747468E86707";
        public const string P1802SchemeT = "1FEB48C7-819E-4720-9517-2DD9D610BB3E";
        public const string P1802CSchmeT = "B5543048-4DA6-49E1-A28D-9D3F616DA5A0";
        public const string P1815SummonT = "32D73940-83E3-4ACA-9CB4-70467DF7D784";
        public const string P1815CSummnT = "4D8B4661-F22F-465B-AE5A-3E8F8E4780B0";
        public const string TP_Objection_Letter = "BCB8A083-0CA3-4B77-A330-A1A8C66C4776";
        public const string board_paper = "1481BC87-8579-4712-958D-D48743A64079";
        public const string Title_Office_Plan = "05FA4B20-D67F-437A-A455-E637A55B0F19";
        public const string Backflow_Info = "97B9603F-FEBB-41C8-9430-5C76EC3B08B2";
        public const string Referral_Response = "8F8D2632-C690-4952-ABC0-495B58672C6D";
        public const string TestPrior = "84BDBC8B-C6D7-4346-B669-DF0002A114D8";
        public const string Acceptance_Form = "5F0F014C-C377-40E1-83EA-3D42F8F13D1D";
        public const string Letter = "A8E361E1-9445-427D-A40B-7744ED1A7D97";
        public const string SD_Rfus_Cnsnt_Let = "2F618E34-83AB-486A-8FB6-C3BF928B90CB";
        public const string WaterPlans = "8279DB11-BD72-4631-B75E-4D7B807717EA";
        public const string PlanForOperation = "28466C4E-5B53-4E6A-B8FA-CC7027438440";
        public const string CasePSPs = "C2D87AF2-763F-40D6-B84D-2FA395710EE8";
        public const string Addendum = "41ED8B1C-E150-466D-A0BF-BE1C8CE0BC0F";
        //public const string AsConstructedPlan = "444782A0-DA4C-4EF2-9531-7C08B09A9D70";
        public const string AsConstructedPlan = "E8AE7E17-FB19-414C-B118-3B4CD496118E";
        public const string AsConstructedSewer = "651D9451-00AC-46A8-BA5C-71D5F088FC86";
        public const string AsConstructedWater = "FD2552FD-FDD0-4562-BC3C-D73406E63737";
        public const string ConstructionTender = "6EB739F7-CCA9-4F54-9EA3-83C44ACCF596";
        public const string UPDATEPSP = "E4249FB4-0E75-4ACA-A54C-E788F239A6AC";
        public const string NPVAssessment = "1EEED5F3-1A73-404D-86E2-306D6899D204";
        public const string PSP = "83D9900A-4F26-4C5A-BF10-573FF6E49D73";
        public const string BOApprove = "9C306598-004B-427B-B1AE-E19B9FCFD7D6";
        public const string BOAcceptance = "173B45B6-34C7-4CA1-8338-D173AAA1C228";
        public const string BackflowRegForm = "3B2028AB-0BD9-41F8-957E-EADD49986D3E";
        public const string TaxInvoice = "5373DFCE-C071-4385-8334-32482F0FA029";
        public const string PropertyConnectApplication = "6DD0D790-9EB3-4dcd-AD68-E87301725D84";
        public const string ApplicationData = "6DD0D790-9EB3-4dcd-AD68-E87301725D84";
        public const string SitePlan = "3F37C79C-D1A7-4B7D-B389-47AA9FB59319";
        public const string ElevationPlan = "FA180D32-D319-4089-80E9-652F422BAE91";
        public const string FloorPlan = "BC04337B-A819-4DC6-8332-1F67840249DA";
        public const string FootingPlan = "E898BAC7-3BD1-4CBB-BB42-756727EAD800";
        public const string HydraulicWater = "00D8B77D-9354-4ECA-82B6-5A935146C26B";
        public const string HydraulicSewer = "3955C51E-535D-4E84-BBCC-925BAC9E4A98";
        public const string PFI = "6730879B-BC3B-4084-8959-EA25E6871B29";
        public const string FirePumpCurve = "C9D46DB4-D68A-4E15-A629-3BF7B2671E23";
        public const string GeneralPumpCurve = "39D04285-F788-4201-8E22-9BC1942F43ED";
        public const string ColdWaterSchematic = "FBA352F5-97CB-4B02-A1D3-638776498AB1";
        public const string ColdWaterRiserPlan = "33085EC2-3207-4CA1-912B-76DDED3545B6";
        public const string PlanOfSub = "B7CEF772-1237-45DD-8044-1AFA37BC1931";
        public const string DigitalPlan = "A60D5108-F593-4EFA-AF1E-D0938B69F1CB";
        public const string AreaWorksPlan = "EF822ED3-0116-4ECA-80C4-68A35C5AAADA";
        public const string EngineeringPlan = "78887E0A-45E9-4285-8488-0D9EC2200AAE";
        public const string PrelimDesignPlan = "61B2FEED-794A-4B43-B5F4-399858EB20E4";
        public const string CrossSection = "5AE35E2C-379F-4C95-9861-319C050C1326";
        public const string CheckMetersBooking = "6FBEB7C1-F512-4150-E054-00144FEADF8C";
    }
    #endregion

    #region LL_EntityList
    public struct LL_EntityList
    {
        public const string Case = "5ED14CE8-792E-43BD-B599-BC04C90A59E0";
        public const string Property = "6172A09B-2094-4D23-A5D7-14950E259373";
        public const string Customer = "9085E2EF-4905-4D6F-9BC3-774D5105594C";
        public const string Order = "984C70D2-AFBE-49DB-98BB-223C442B1DF0";
        public const string DevelopmentLocation = "9F400DFF-BCF3-4AF9-84B1-7EFD89CA7BED";
        public const string Letter = "F5D5D5DF-8F40-44C7-9AD0-6C9C5DCB68BF";
        public const string CasePSPs = "9A52AE91-13AB-49AF-88E7-F2D9286B137E";
        public const string TitleOfficePlan = "E322F549-D78F-4B57-9D26-EE9ABBAF27C8";
        public const string Contact = "5670016E-CC99-4F5F-B364-7613A45312AD";
        public const string PSPImage = "EAD9AAAE-E4A9-48f5-A0F3-31F5B868FC04";
    }
    #endregion

    #region MailingTypeList
    public struct MailingTypeList
    {
        public const string Mail = "96E8A958-7B77-4BCF-953A-E5C2333FA285"; // Fake Value. Change once in use
        public const string POBox = "692C74DF-A5B7-49D3-ADB5-9B6F49EE91A3"; // Fake Value. Change once in use
        public const string DXMail = "AE6E414F-9AEA-4B7B-91A9-60AB5BAFB263"; // Fake Value. Change once in use
        public const string CourierAllotment = "8DE9EC10-A811-42E1-A33C-BE6788B1E4E2"; // Fake Value. Change once in use
        public const string Other = "BBE8ABF6-0B85-42BE-A6B5-6F102DA64D90"; // Fake Value. Change once in use

    }
    #endregion

    #region MpireTableEntityList
    public struct MpireTableEntityList
    {//27/03/2003 Added by SV
        public const string OutputPart = "E870A6D1-AA36-45E2-9043-50DB6B886E30";
        public const string Payment = "277E3FE9-3A59-4F57-9B99-BBDE9FC9FE1E";
        public const string PaymentAllocation = "468767F5-661D-4D5A-B51D-1746305E4C9F";
        public const string PaymentGroup = "BB1208B7-C6AB-405A-AA41-D48087B86274";
        public const string Procedure = "4E68FD27-2F80-455C-9F33-1504D92C9CDF";
        public const string Progress = "08265BC4-81CB-43E4-8C1E-3412A35E293F";
        public const string Property = "E1B0D5D8-9E7B-4BCE-BF47-E35B17868F72";
        public const string PropSupplementary = "A95AA2BA-8605-4187-A73C-BF919E0BA167";
        public const string Relationship = "B9B5305A-2D53-43A4-B527-CA3419A3C2DA";
        public const string Role = "1F7BF351-8A52-4102-9939-C3BB9AD01790";
        public const string RoleReqSupp = "01BDBBFF-5735-4D51-AD9F-0B99B17B2B6A";
        public const string SDOInformation = "FE8C4B04-3F68-41AE-BDE4-600E2C1719CF";
        public const string Service = "6004B4E0-E83D-465A-8588-2E049B512F9C";
        public const string ServiceItem = "12830950-DB82-4110-BC3E-7AC1B092F1B2";
        public const string StandardClause = "075EF9DF-9B28-49B3-8D64-5371F84E127D";
        public const string TitleOfficePlan = "DF033C34-38EE-48E5-82BE-2CAF5C206266";
        public const string User = "7BAAEB27-6D08-4809-A4FF-D074613497AE";
        public const string OutputDef = "08336650-B0F2-445A-93B6-23A6C8119BF2";
        public const string AssetInformation = "BB6E2503-E54F-44BA-96F9-5E490AAD93A8";
        public const string Address = "19C0C1D1-1BBB-46BC-872E-0A955437A7F6";
        public const string BrokerQuery = "D7C5886B-6449-43E7-8C57-57BF0E66281B";
        public const string Case = "E8AA3292-73F1-413B-814B-11532FC5FD86";
        public const string CaseClassification = "EDD7A2F5-77B7-48BD-8ED5-5B29782C79C3";
        public const string CaseClauses = "6657E925-613C-429F-B153-895A3D2DF70D";
        public const string CaseProperty = "9FA4EEBB-A1BA-48F4-A6B6-004D8434175E";
        public const string CaseTariffs = "63C372C8-50EC-414F-8365-DEF588355AD5";
        public const string ClauseTranslation = "471B9238-ADD4-405B-BED5-CB681B2DBEA5";
        public const string CompanyRep = "166BF34D-DF81-408D-9551-8BD9AC283A02";
        public const string ConfigGroup = "9E816A25-849E-4AFA-ACE5-70E968EE90A8";
        public const string ConfigValue = "E654100D-754B-4DE8-B8F8-2FDE146A0C23";
        public const string Contact = "2FDAC05F-22F7-498B-8278-16CB7A9BB7AA";
        public const string ContactClass = "2730026C-17B2-4573-A366-9F23FB124988";
        public const string ContactHistory = "BCAC0746-8B95-4909-97F3-B5FCE7F28392";
        public const string CreditNote = "7815F3F1-B708-4147-AE9F-9B86578B7035";
        public const string Customer = "C279022F-E4D2-4130-B3E6-9B638CC6DB75";
        public const string CustSupplementary = "E8F8EDD1-0620-4882-8F8B-B03F70B98992";
        public const string CustomerBalance = "7B3AB439-75D6-4A35-84F6-0D1CDD698842";
        public const string DelegatedAuthority = "8207FBF3-BE58-4725-AA89-AF82591A2573";
        public const string DeliveryAddress = "D8E46D77-3BBA-414B-B39E-72E46FE8B71C";
        public const string DevelopmentLocation = "7E25CF26-7D9C-4FDB-A955-891995120225";
        public const string DvlpmntLcatnPrprty = "C5C8AD68-54E0-4CC7-BFEA-D37720D6DF3D";
        public const string DirectoryReference = "6C6EA5DA-4DFF-4F08-A3D4-509C4959A3FE";
        public const string DirectoryTranslation = "83403B2B-7DED-4CD6-A0AC-384E90BC9224";
        public const string Discount = "AE7F8D1B-54B7-41C4-BD73-CDCD13D79240";
        public const string DMRetrieval = "F0FA5639-DB9B-4D23-A6F2-2D39900C638B";
        public const string DMAttributes = "76C6A739-8D67-4078-B31E-A7CAD0E16B97";
        public const string Fee = "B2666315-5F85-44B8-8EA0-A8880BA0D706";
        public const string FieldAudit = "90637717-2133-4A33-BF8C-D603F10C39F8";
        public const string FileAttachement = "8E87D834-8E8A-4AC4-AE84-D21008A0FE49";
        public const string FinanceTransfer = "83E4B31D-9D05-40E0-98CA-C2AF50E68078";
        public const string FixLocation = "DBF858AF-2177-4398-80CE-298004F06553";
        public const string InformationStatements = "7672F2EA-D48C-4FE0-B951-59D5DBC55AE6";
        public const string Item = "CEC85D7C-09C7-4911-9DDD-90AF7235BBDE";
        public const string ItemCost = "D84B7319-CA62-406C-895E-84EC90705AD4";
        public const string Letter = "D6891C91-FF92-456A-9786-2C4BF9BD7819";
        public const string LetterQuery = "83DF2393-C7FF-4CA2-A1C8-78FF9C7A4B33";
        public const string LetterQueries = "B66F7377-02B8-4E78-B319-CD2D38085EDA";
        public const string List = "976ACFF0-5EE0-43C4-B6C2-87DAF6163051";
        public const string ListValue = "40047932-7648-42B0-A637-5D6CFF1D0937";
        public const string NonWorkingDay = "5702BFB8-4ECC-4235-B55C-5A56AF8CB951";
        public const string Notes = "C43F40F4-D3CC-4B21-8A23-493BB9517406";
        public const string Orders = "A7AF0177-D7DF-425F-9CFD-F656870F1AEB";
        public const string Output = "878121EC-01AC-44A0-BA55-E7012A0B755C";
    }
    #endregion

    #region OrderStatusList
    public struct OrderStatusList
    { //PBB12/02/2003 10:48AM Changed all constants and values to reflect database.
        public const string New = "BC7062DF-1BEB-4AEE-AD94-9A7C71DDD9C7";
        public const string Saved = "A07FD3B5-59BA-4747-975D-F5A805E41B0C";
        public const string Submitted = "57F8DCFC-5C92-4BFA-A88D-15B12A5CF7A0";
        public const string Running = "98F89859-F68B-46F8-B59D-385CB2FFE38B";
        public const string Completed = "C713D1AB-1AD4-4E80-A28C-DB58EB1D9EEB";
        public const string Cancelled = "A81E7659-EC25-4DF5-B0D7-A5B4B132ABB1";

    }
    #endregion

    //  OutputDefTypeList is redundant, use OutputTypeList instead.
    //	public struct OutputDefTypeList
    //	{
    //		public const string OutputDefEmail = "413D4611-1ECC-41DA-AD48-A466CEF43C16";
    //		public const string OutputDefCaseOutput = "C93A78BB-AC44-4DF8-8706-B2993AF92E6F";
    //	}

    #region OutputPartTypeList
    public struct OutputPartTypeList
    {
        public const string OutputPartTypeEmailBody = "494C0033-38B3-410F-ABCD-F30E818FCAAD";
        public const string OutputPartTypeEmailAttachment = "8C83E30E-85C3-46D9-AB37-B6EC9AAE95A8";
        public const string OutputPartTypeFaxCoverSheet = "085CC889-857E-4C87-99B6-63553231C14D";
        public const string OutputPartTypeFaxAttachment = "46BF6BD1-7AA7-486A-9625-2BBB0C2D959D";
        public const string OutputPartTypePSP = "B687A802-5F6F-4B51-A68B-E5454535E1EF";
        public const string OutputPartTypeEncumbrance = "40C817A5-DD9A-4C76-8BF7-7B900C366106";
        public const string OutputPartTypePSPPrimaryStamp = "4BE0D273-6DC9-4264-8315-8603BF1DBE5E";
        public const string OutputPartTypePSPSecondaryStamp = "C167F9EC-49CB-4BD4-9E8D-9ED14C3D179E";
        public const string CaseLetter = "AC3097DA-ABFC-40F4-BDCD-DACF08F4B62C";

    }
    #endregion

    #region OutputStatusList
    public struct OutputStatusList
    {//DT 24/02/2003 11:58AM Changed all constants and values to reflect database.
        public const string New = "12CA81E3-32A0-415B-87E5-AB8FB20033CD";
        public const string Saved = "488B53E3-0F46-4A32-A45A-09A3EF145380";
        public const string Submitted = "4837FC75-4384-49E8-9B78-18A22ADEAC0E";
        public const string Running = "34E10F90-35EF-4FDE-9F1F-39E7A0324BFA";
        public const string Completed = "412F7C8C-B637-4C8B-8E1A-27CC067F1B57";
        public const string Cancelled = "44090F3B-21B2-459C-BB27-2D55034CAB1F";
    }
    #endregion

    #region OutputTypeList
    public struct OutputTypeList
    {//PBB12/02/2003 10:50AM Changed all constants and values to reflect database.
        public const string OutputTypeEmail = "413D4611-1ECC-41DA-AD48-A466CEF43C16";
        public const string OutputTypeEmailInternal = "41635884-F9D0-48C0-92CC-84F3B5022439";
        public const string OutputTypeCaseOutput = "C93A78BB-AC44-4DF8-8706-B2993AF92E6F";
        public const string OutputTypeFax = "DC225861-8679-4F0A-85A8-DF6E8F09B394";
    }
    #endregion

    #region PaymentMethodList
    public struct PaymentMethodList
    { //SV 25/03/2003 10:30AM changed PaymentMethodBilled GUID as it reflected a wrong one . . .
        public const string PaymentMethodCash = "5A1674BE-266C-4AA0-82EA-D2A64B547B1B";
        public const string PaymentMethodCheque = "B588A201-E685-4938-AEA8-9F550398F739";
        public const string PaymentMethodCard = "1B336B7F-51E1-41F5-9F1B-F02BAF158E77";
        public const string PaymentMethodBilled = "E81A11CC-8F38-47e8-B481-3AA8A3DE4D61";
        public const string PaymentMethodCreditNote = "7B14BBD4-E2F4-448E-8085-7C2EA3DBB5D4";
        public const string PaymentMethodAdjustment = "1A16011B-ABD3-4C8C-B357-468F8DEB268D";
        public const string PaymentMethodTenderOffset = "DFC70D4D-F3CE-401A-B091-56277F2DA459";
        public const string PaymentMethodApplicationOffset = "26FC5DB3-4441-4F76-9334-CC7964496AE3";
        public const string PaymentMethodCreditTransfer = "91FF2FAB-7FA2-4D33-B733-C0F3F1A5DEDA";

    }
    #endregion

    #region PlanStatusList
    public struct PlanStatusList
    {
        public const string Consent = "BB3278DC-FCB9-4CF7-9086-6268028318F1";
        public const string ConsentCompliance = "8BCA4B59-0FF7-4527-AF25-CB01B85761C2";
        public const string Received = "BADAB655-7F16-4AF4-B4D4-6AFCBB503EA1";
        public const string AmendmentRequired = "E44C7393-81D6-4BDA-936C-7376C387E407";
    }
    #endregion

    #region PlanTypeList
    public struct PlanTypeList
    {
        public const string Subdivision = "9B320A4E-FFE2-41AD-AEEF-410CC2BEB1DD";
        public const string Consolidation = "8BED8814-FA36-4361-8902-6B1DADFBA4FC";
        public const string Expungement = "B46E0883-25AB-416C-AB53-6C2AF2DF1778";
    }
    #endregion

    #region PriorityTypeList
    public struct PriorityTypeList
    {
        public const string Urgent = "BGDHU365-D3E4-4FGF-B65C-12075839873G"; // Fake Value. Change once in use
        public const string Routine = "235H5J63-D6E4-467F-BV5C-124633HY651G"; // Fake Value. Change once in use
    }
    #endregion

    #region ProceduresList
    //	13-02-03	DK - using procedure names.
    public struct ProceduresList
    {

        public const string AssetInformation = "3308D596-6C53-42D6-825D-7F1ADC592EE4";
        public const string InformationStatement = "64E00FEC-45B2-4368-AE61-EF02B515D8F6";
        public const string PSP = "414BEC15-1F13-4C6B-88B4-A4A500A356B5";
        public const string SDOInformation = "C55C3DBF-F3EE-425C-9CF6-BD12AE7B111E";
        public const string TownPlanning = "2CC291E7-6008-4F09-AD83-5E81442B80FA";
        public const string Developer = "1C0E6013-83F5-41DB-AC83-6A1A4722773E";
        public const string BuildOver = "1F66D475-F804-4350-802B-56111CF9AEBA";
        public const string OtherAuthoritiesWorks = "796C1A5B-753F-4B5D-AD94-E015178536D0";
        public const string SubDivision = "23E9E750-F56D-4573-8EA0-8A7604F0AD38";
        public const string BackLog = "6C57C484-2D30-4C4B-B3E7-FDEE9FFAAAD2";
        public const string IllegalConnections = "2CDF0401-35DB-4AB9-94D7-22E9489D4AE4";
        public const string SRC = "5AB9A68D-ECB7-42BB-9BC7-5EFB38D8B47F";
        public const string Plumbing = "822B8b61-8dA7-471A-AB31-F9C6AEE8BB16";
        public const string PFI = "8A6160F4-65B7-0A43-E044-00144FEADF8C"; //MG 6/7/2010


    }
    #endregion

    #region ECOTypeList
    public struct EcoTypeList
    {
        public const string ECO = "7F287F90-F661-4E19-BDBB-6DD5CB499199";
        public const string Backlog = "610DE399-08A7-45AD-9A85-E2BA52DB8E76";
        public const string DeveloperDriven = "B69CAD73-CED1-4DCE-997A-A51144630404";
        public const string VacantLand = "D35F8CAD-1E50-41BB-853E-F13CF8A324F0";
    }
    #endregion

    #region ProposalOptionsList

    public struct ProposalOptionsList
    {
        public const string Standard = "C5099074-E705-4F1E-95BF-1F293ED923A3";
    }

    #endregion

    #region RankingTypeList
    // DT 4/3/2003 Updated to reflect the changes on the ListValue table
    public struct RankingTypeList
    {
        public const string RankingVIP = "79C26D23-5987-46B5-B305-C51C7C8DF9B2";
        public const string RankingNormal = "5BA46A4B-8030-456F-8CEA-6011220DAC21";
    }
    #endregion

    #region ReceivedMethodList
    //	13/02/02	DK
    public struct ReceivedMethodList
    {

        public const string CFE = "1341F43A-6D6B-4A86-BA98-AE3D7EF5EF6E";
        public const string Counter = "5376B308-5876-463C-86CD-A03080CBCF53";
        public const string Email = "4F7D11B7-3925-44F1-B98C-D6DD40361B51";
        public const string Fax = "10D9DF54-67E2-4B33-8206-7E983B82F684";
        public const string Mail = "64DF880A-AFAA-4B28-A0AA-9158169022DF";
        public const string Phone = "33CDEA40-EFD7-4A7E-94C2-B584A48AEB33";
        public const string Upload = "B8615AE5-4DE8-4C9C-A838-BAD09ED85CB0";
        public const string Batch = "03BE8C7C-489C-4AF3-BE2E-5C5E30B51539";
        public const string UFE = "8EB4B575-EFB1-4F1D-B598-DEAC7CC27159";
        public const string Api = "07846A3D-E129-43BB-8ADE-8F99AC4661FA";
        public const string SPEAR = "8FCAFE84-E0C3-4f09-BE77-A2127148D704";
    }
    #endregion

    #region RootEntityList
    public struct RootEntityList
    {//11/04/2003 Added by SV
        public const string Case = "748C43A5-0423-4C32-9BE8-A5AC35C07ABD";
        public const string Customer = "110AA7A6-D522-4DEE-9B00-4A0F992D0BBF";
        public const string Order = "EA662AF9-67E5-49F6-B191-CD66646F9D48";
        public const string Property = "ACEE09FA-9DA9-4364-9650-43B182C3EB43";
        public const string DevelopmentLocation = "A8BC4CC7-F27B-4701-A291-638E45C984CD";
        public const string Output = "70BA70ED-962A-470B-A3DA-94471BE50C77";
        public const string AlternateCase = "E4569B5D-5B15-40B4-A795-8A43B2434579";	// dko, TT 2020 04/08/06
        public const string Payment = "96251520-D4A3-1E3C-E044-00144FEADF8C";

    }
    #endregion

    // TT 1817 - added 4 new SRC Services
    #region ServicesList
    //	13/02/02	DK  - needed so that we don't need to use the ProcedureFacade to get a list of services
    //	to place in the Case table when creating a new Case
    //	These are the service names

    public struct ServicesList
    {

        public const string Combined = "D8278D5A-1405-44E2-A0AE-9E43D6042C0A";
        public const string DBYD = "3E7CFB9A-C9C2-4DD2-8421-63553F504B80";
        public const string FinancialUpdate = "629A5F2C-C2B9-4999-8A72-55DB70846A4E";
        public const string PSP = "0FC2BFB6-3493-4B45-9890-672F88977E25";
        public const string ManualSDO = "AC6F54E1-F689-4D45-823A-01799C383548";
        public const string SDO = "8C3852E4-1F4D-4C59-A798-E37706EC5D2A";
        public const string Sewer = "E9409F41-FE96-42B2-BDDD-681E7BD917F0";
        public const string Water = "C5802893-8E15-4301-AD38-8FB14FFC42FA";
        public const string WithPSP = "6F9857E4-35E9-4572-BE6C-467C04E36E6A";
        public const string WithoutPSP = "23006F78-18B2-4093-B422-F7C0C7C0817A";
        public const string TownPlanning = "FC8D141C-4051-4D4D-BC02-0925079607CD";
        public const string SchemeAmendment = "E0F509C1-5558-4A64-B57A-BF736B379944";

        // Developer Services
        public const string ConstructAndContrib = "A11F9D7D-A14D-46B1-8A47-BB41E1AC9C05";
        public const string MinorAssetAlt = "4A85D9A1-E2EF-41F3-AA0D-8A9D8BA15234";
        public const string NonResConnection = "A759AF7C-4C57-4658-836C-B59199588E6E";
        public const string ContributionsOnly = "87A6D82D-708C-4078-8969-4C6BAE3C1E1B";
        public const string LandServiceAdvice = "E986DA81-B474-4E38-AA20-38677115B61A";
        public const string NonResServiceAlt = "1E2F34DA-8CD3-4AC8-AF8D-88D0A80E2974";
        public const string PrivateWaterServ = "46019369-EF68-4018-A420-02E1FFA3F670";

        // Backlog Services
        public const string Control = "2B239851-64F6-48B0-B08C-A3FB4CF29463";
        public const string Property = "9296C9AB-52DF-4328-B1D5-537351B714BD";

        //BuildOver
        public const string BuildOver = "3C76D6EB-E282-499F-8A9D-FF00E04A4B8D";

        //OtherAuthoritiesWorks
        public const string OAWStandard = "C0816B75-8FD3-425D-A8CC-411EBB1B8DC1";
        public const string RoadClosure = "CA9B9D93-F78D-4999-8841-9A1C0A108570";

        //SubDivision
        public const string CertReferral = "11775CCD-9123-42EE-8F97-0BEDB5A3752C";
        public const string CertReferralAndTp = "3CB990F4-6F65-4cfe-B8FB-579DDEBC89E0";   //TT#4328 RGC 02/09/09

        //IllegalConnections
        public const string ICStandard = "CC3849B8-F01A-427B-8DC4-5FA6FA18DDFA";

        // SRC
        public const string SewWatDryTapped = "9E97B985-F0E4-47BC-ABEB-6B5CAEB0F848";
        public const string SewWatWetTapped = "E6F7D260-2F99-4761-BC1B-E5251E5EA0A4";
        public const string SewerOnly = "035BF10E-2017-43E3-AC15-928B5F050F04";
        public const string HouseExtension = "6FC20F32-BF09-4CB3-866D-4FF50451EC71";
        public const string InternalPlumbing = "A0FBA8B1-34EC-43DC-AB99-623218CF8556";
        public const string DrainAltCutAndSeal = "C990C58D-BE64-4FFB-83B5-81E8019AC8F2";
        public const string WaterOnlyWetTapped = "9358D604-A23B-4658-B968-AD7B6E6B69C9";
        public const string WaterPlugging = "D59702BD-B98E-48C4-9E66-E2564F8095F3";
        public const string SeptictoSewer = "030F6193-50CC-4D29-8FBB-D36F3A6EA778";
        public const string UrgentRepairNotice = "2E42D167-863E-4FF1-95BB-5258272BB7D4";
        public const string PreCheckedSewer = "A827B0D4-2B50-41CE-95B0-A8EF008C9BEB";
        public const string PreCheckedWater = "7D6E1306-8720-40BD-B7D9-54D457042324";
        public const string PreCheckedSewWat = "F1E63AA0-A5FB-4529-BA8A-C842A609CEDF";
        public const string WaterDryTapOnly = "0227D1D4-E27E-4F7F-BAC4-AFCBECE87889";
        public const string WaterDryAndSewer = "A9F595E1-291F-44F6-8582-A5E5B3591145";
        public const string WaterDryAndReUse = "606328A5-3071-4655-82F7-34426A1FAFD9";
        public const string SewWatDryReUse = "47E9F83C-CBF5-4AA0-ABB7-E9ECBBF940CF";
        public const string RecycledWaterOnly = "9DF3C3ED-AC99-411B-98C2-857532CF3544";
        public const string EarlyConnectionOffer = "B8C08AC6-0054-443C-AC90-A1729E5030DF";

        //Plumbing
        public const string PlumbingCDG = "25547F37-007B-4733-A2B8-72833AD86F43";
        public const string PlumbingSewer = "6B4A9F0E-5335-4C0E-BE78-B37C2C100124";
        public const string PlumbingWater = "9DF3C3ED-AC84-411B-98C2-857532CF3544";
        public const string PlumbingSewerWater = "91ABCD7F-0A2E-4b92-9F28-B9D4FB47070B";
        public const string PlumbingMSAQuote = "FFDA54FC-48D2-4a12-A4E6-750A4FFA57C8";   //TT4312 05/08/2010 RGC
        public const string PlumbingMeters = "B14411B7-6C0F-4A23-838F-61CB53132B7A";    //TT3141 26/06/2018 MDP

        //PFI
        public const string PFISingleTappingStd = "8A6160F4-65B8-0A43-E044-00144FEADF8C";
        public const string PFISingleTappingPty = "8BEF3BB2-0E3C-244D-E044-00144FEADF8C";
        public const string PFITwoSingleTappingStd = "8BEF3BB2-0E3F-244D-E044-00144FEADF8C";
        public const string PFITwoSingleTappingPty = "8BEF3BB2-0E41-244D-E044-00144FEADF8C";
        public const string PFIDualSupplyStd = "8BEF3BB2-0E43-244D-E044-00144FEADF8C";
        public const string PFIDualSupplyPty = "8BEF3BB2-0E45-244D-E044-00144FEADF8C";


    }
    #endregion

    // TT 1815 - 09/01/06, dko. Also corrected some of the values. Very wrong!
    #region ServiceInstallationCompleteStatusList
    public struct ServiceInstallationCompleteStatusList
    {
        public const string New = "354CADA2-7630-48CD-8352-BB3C47144453";
        public const string InProgress = "09E67DF7-187A-4EEF-967F-8F604D15A411";
        public const string ContractorToSchedule = "EC514E88-773E-46D7-B1AE-D1A4C5567D29";
        public const string Scheduled = "FFCB2408-5809-4FEF-AF3A-C894C7500131";
        public const string Completed = "688215A2-8A39-40C2-8F27-B4E53630CC5B";
        public const string ServiceCallVisit = "9580D0E7-34C7-430D-9776-5D39AD66AC16";
        public const string Installed = "87A9043F-98CB-42C3-9805-B1C5CFE09D73";
        public const string Lapsed = "7BDDCF68-3C12-4E54-A94C-2C6A1A2C1963";
        public const string Unlock = "CAD34660-E453-4E67-B9B2-8CB9FB9299CD";
        public const string ContractorInvestigate = "F4D7940E-3419-4C71-85F0-EFA72D3F1AFC";
        public const string AlreadyInstalled = "7E39C794-3984-483F-9AE8-5B2AF30B5967";	// TT 2046
        public const string Cancelled = "ED225831-1B17-4b55-AF37-590CB8FCBBA5";   // TT 4658
        public const string Withheld = "9C5613BD-96BD-4E5E-8CD7-DF31439216ED";  // TT 2686 
        public const string Illegal = "FAA7720D-3D8D-4882-9038-F42E7A3D5699";
        public const string Requested = "7503EAFD-2516-124A-E054-00144FEADF8C";       
    }
    #endregion

    #region ServiceInstallationTappingStatusList
    public struct ServiceInstallationTappingStatusList
    {
        public const string New = "783A15AD-4DD4-28AE-E054-00144FEADF8C";
        public const string Scheduled = "783A15AD-4DD6-28AE-E054-00144FEADF8C";
        public const string Completed = "783A15AD-4DD5-28AE-E054-00144FEADF8C";                
        public const string Cancelled = "783A15AD-4DD8-28AE-E054-00144FEADF8C";           
        public const string Requested = "783A15AD-4DD7-28AE-E054-00144FEADF8C";
        public const string Withheld = "783CE6E5-B105-3A70-E054-00144FEADF8C";
        public const string ServiceCall = "787ABF51-578C-052C-E054-00144FEADF8C";
    }
    #endregion

    #region ServiceRemovalCompleteStatusList
    public struct ServiceRemovalCompleteStatusList
    {
        public const string New = "0B9785E5-3A9B-4CCA-B3B7-17F2BA064230";
        public const string ContractorToSchedule = "E2F3D7FD-2366-44DB-84CA-D18330026AA9";
        public const string Completed = "EBAD3586-33FE-4082-A2B0-AA9206E5478E";
        public const string Scheduled = "B25E7B7D-34F3-4AF3-93FF-F5916B088CC6";
        public const string Removed = "8B9DF999-665A-4AF6-AA6C-58CED8D6C321";
        public const string Lapsed = "57C9719F-5FC0-4857-8997-2D50B5DDEFDD";
        public const string Cancelled = "8476C683-DC15-4a1a-B216-914E2352D043";   // TT 4658
        public const string Withheld = "F2DF4FD1-7E48-480B-8FE3-5B33A0B5B8E7";  // TT 2686
        public const string Requested = "7503EAFD-2517-124A-E054-00144FEADF8C";  //TT4800
    }
    #endregion

    #region ServiceRemovalTypeList
    public struct ServiceRemovalTypeList
    {
        public const string Plugging = "BAF48774-D9EE-45ED-B637-F80C1F659F21";
        public const string TeeRemoval = "20FC75E2-44F7-4678-8E25-F2332246F0A7";
        public const string BlankEnd = "47A81AEB-00AA-4070-A7C3-4F22CFE87555";
        public const string PluggingRecycledWater = "F6EF5631-A793-4076-A55F-7A4E3724FCC0";
        public const string TeeRemovalRecycledWater = "BFB6C3FE-5D76-40db-AED0-3613CF6E3BB9";
        public const string BlankEndRecycledWater = "08BE35E4-C03E-43ee-B25F-2981FF538189";
    }
    #endregion

    #region SubDivisionApproval
    public struct SubDivisionApprovalList
    {
        public const string Approved = "241A852E-3975-4341-AE27-1633C410A334";
        public const string NotApproved = "48EA2BAB-CE8B-4898-A5FD-61D183719BF7";
    }

    #endregion

    #region SubDivisionAssessmentOutcome
    public struct SubDivisionAssessOutcomeList
    {
        public const string SuspensionOfTime = "13B7041C-4808-47CF-BC93-841D789BC6B3";
        public const string ConsentWithCompliance = "3D8E5D9C-CD59-4E48-B2A8-65C4AC853BBA";
        public const string ConsentWithoutCompliance = "F1B7E380-F6B3-4729-94B8-71BA2046F447";
    }

    #endregion

    #region SubDivisionTpCertAssessmentOutcome
    public struct SubDivisionTpCertAssessOutcomeList            // TT#4328
    {
        public const string SuspensionOfTimeConditions = "D25E167B-A8D4-40ae-89E8-C2928C48C12E";
        public const string SuspensionOfTimeNoConditions = "0453FB13-5EF9-42b4-8C83-85472B58698F";
        public const string ConsentWithCompliance = "E5CB4A19-C90B-40af-A48E-8BEA9542CC73";
        public const string ConsentWithoutCompliance = "E4E562C9-C007-4a76-9901-36AFA1474A80";
    }

    #endregion

    #region TownPlanningApproval
    public struct TownPlanningApprovalList
    {
        public const string Yes = "8907CD94-8E95-4941-9A46-1EE25BA065A8";
        public const string No = "7F88B533-4D0B-409C-9761-EBD432E51FE2";
    }

    #endregion

    #region TenderTypeList
    public struct TenderTypeList
    {
        public const string FinalCost = "0446F7BF-918C-4D13-BF74-76CFFED613E1";
        public const string Estimate = "47D2FD23-9C95-4672-BE7A-1FA8C47446A4";
        public const string Tender = "011151A6-5A92-4A05-9010-E60463CA6607";

    }
    #endregion

    #region YesNoList
    public struct YesNoList
    {
        public const string Yes = "2AECF54C-E28F-474F-A8BC-0D2CABA451AE";
        public const string No = "113C3B8C-EDF7-4840-95FE-7E449880AB21";
    }
    #endregion

    #region TestPriorApprovedList
    public struct TestPriorApprovedList
    {
        public const string Approved = "DF9945A4-467E-4323-B51F-9040666C2350";
        public const string NotApproved = "92B552EA-F9D1-42C8-A061-7AA24D3E8202";
    }

    #endregion


    #region AssetServiceList
    public struct AssetServiceList
    {
        public const string WaterService = "DDFE2B25-4751-49B9-A2DF-D003D6CF10E9";
        public const string SewerService = "BCD43C6B-4D25-4A2C-9B59-AEFBF0593F92";
        public const string RecWaterService = "291B5986-B33F-47F7-8CD0-FD4281B9D725";
        public const string PressureSewerService = "182E0B3E-6F67-4D2B-B9E6-C2D31A81C970";
    }
    #endregion

    // TT 5537 - Used in Developer's Detailed Assessment form. Depending on the apptype, we will
    // have to disable/.enable the Consent Deemed Given combobox. 19/05/2005
    #region ApplicationTypeList
    public struct AppTypeList
    {
        public const string IndividualMeters = "055D54F2-9D02-440C-B2FB-E220ADA627AD";
        public const string PlugAndRetapping = "0B3A11B4-B02B-48D2-9DC9-421AFCDB07ED";
        public const string PluggingsOnly = "6F822EAD-14F7-49AD-99DA-3292172B8AE9";
        public const string RemoteMeterInstallation = "DC3B2452-819F-4F73-BB4A-36CC1C28D3B6";
        public const string SubdivisonAssetConstruction = "7904E837-8D3C-4812-9CA9-1C2101FCE0C3";
        public const string MinorExternalAssetConstruct = "0117F7F1-E44B-457F-8776-C6F08DDB8CCC";
        public const string InternalAssetSEWL = "78AD47E7-3FD5-4201-B460-633AB9C23904";
        public const string ServicingAdvice = "7EA3BFA9-DE6F-4E57-B661-D19B802547E2";
        public const string ServicingAdviceConts = "2552A85C-1EA1-462A-8E38-D5147F53EF14";
        public const string SubdivisionContributions = "824458F6-9BD9-4151-BCEC-831786245722";
        public const string InternalAssetsPrivate = "B92E7A25-79E2-46FE-B4BE-7AE7966686AE";
        public const string SubAssetWSConsent = "EC090E8D-8CF3-451A-BC95-3F7178BEB689";
        public const string SubAssetSewerConsent = "003FBBD8-4A38-4533-9DF8-2F379C44CBCA";
        public const string SubAssetWaterConsent = "D729929F-1993-417D-A5F8-EC228C8D6117";
        public const string TradeWaste = "F1145AD4-E067-45A9-88DE-8C9796EE0B77";
        public const string ServiceAlteration = "08FB66CE-848B-41AE-B18F-B5EA700CFCC0";
        public const string WaterOnly = "8EB11E7F-4873-46DB-A1F9-3BD56FDF7B77";
        public const string PrivateWater = "023C3967-7875-4DCA-A8AB-3B9617692C66";
        public const string IrrigationSystem = "B4AE936C-B58A-440A-BCB2-6033E9476F44";
        public const string FireService = "5F430AF6-CB81-4A49-A0B0-FE15F35EB2CA";
        public const string SepticToSewer = "B4E22553-BB70-4CE8-8F99-125B2A426D6F";
        public const string SewerOnly = "25656C29-83E4-4C23-AFF3-0E980EB67DE5";
        public const string StandardConnection = "640A539D-7992-4580-A85E-F9B52F6CCB96";
    }
    #endregion

    // vsn 1.2
    #region PlumbingApplicationTypeLists
    public struct WaterApplicationTypeList
    {
        public const string ServiceAlteration = "A3501C21-EE09-41b8-85B9-EC1D8F1E6F6C";
        public const string WaterOnly = "9DA0C30B-4260-47b1-98B2-CC0EA1878DF8";
        public const string PrivateWater = "4E85F88A-6A59-4612-BD4F-19CDE27CF26B";
        public const string IrrigationSystem = "01FF345F-85C3-47f7-9CAF-BF73CB421C1A";
        public const string FireService = "97D1914F-395E-4c3d-BC42-C0BA106F3E97";
        public const string RecycledWaterOnly = "4CA7936D-9D98-4e2c-9722-95D10167DAB9";
    }
    public struct SewerApplicationTypeList
    {
        public const string SepticToSewer = "DFB7D7E9-56B4-4158-B978-B88D0C28BFFB";
        public const string SewerOnly = "BEEB1B1C-FCFE-42dd-B285-31125E9CDC97";
        public const string PrivateSewer = "9CF20A93-9579-4cc7-BB12-76ED8E1311CB";
    }
    public struct WaterSewerApplicationTypeList
    {
        public const string StandardConnection = "4E7B8827-E057-4ab2-BA9E-00378E1279D1";
    }
    public struct CDGApplicationTypeList
    {
        public const string ConsentDeemedGiven = "47892582-CA49-408a-A3E6-38E68F40ADB9";
    }
    public struct MSAQApplicationTypeList
    {
        public const string ServiceAlteration = "F08A35E9-99C4-4B12-B0D3-0BF3B386ACBF";     // RC 02/09/10
    }
    #endregion
    // vsn 1.2

    // TT 1815 - Used in ARMSExport - EntryPoint.cs file to retrieve the list value ids.
    #region ServInstContractorList
    public struct ServInstContractorList
    {
        public const string AMRS = "B9564B68-DF4D-477C-8313-58B8C1AB3F05";
        public const string PP = "3A4FCEA4-6CA7-4285-9484-B1F68EAFE329";
        public const string THEISS = "DEF2CAF3-D15D-402B-8A3F-B2ADC1B465BE";
        public const string PRIORITYPLUMBING = "DEF2CAF3-D15D-402B-8A3F-B2ADC1B465BE";
        public const string MINORWATERWORKS = "7850A9B8-C12B-0EF9-E054-00144FEADF8C";
    }
    #endregion

    #region ServRemovalContractorList
    public struct ServRemovalContractorList
    {
        public const string AMRS = "B9564B68-DF4D-477C-8313-58B8C1AB3F05";
        public const string PP = "3A4FCEA4-6CA7-4285-9484-B1F68EAFE329";
        public const string THEISS = "DEF2CAF3-D15D-402B-8A3F-B2ADC1B465BE";
        public const string PRIORITYPLUMBING = "DEF2CAF3-D15D-402B-8A3F-B2ADC1B465BE";
        public const string MINORWATERWORKS = "7850A9B8-C12B-0EF9-E054-00144FEADF8C";
    }
    #endregion

    // TT 1815, dko 09/01/2006
    #region ReUseTypeList
    public struct ReUseTypeList
    {
        public const string NA = "8C327398-AAC9-4030-AAB3-3AA5988778DE";
        public const string Garden = "FE1FAEE3-8448-4DD1-87E1-B1FED6E45F8A";
        public const string Toilet = "ABB67E3A-3E34-45E7-BF04-F981A9D1B409";
        public const string GardenToilet = "633B9CF2-B971-4388-8590-72A24CCA1FF4";
    }
    #endregion

    // TT 1817, dko 11/01/2006. Used in CreateServInstallBroker
    // TT 4658, rgc 21/06/2010. Added DryTapping for new Plumbing GenRegenSerInstallRemovalsBroker
    #region TappingTypeList
    public struct TappingTypeList
    {
        public const string DivideValve = "75F4A9C0-1F68-48BC-8FFF-6E2B0F73B340";
        public const string Tapping = "0602BF74-C1A5-4004-B750-ADADE40C88FD";
        public const string TeeInsertion = "1562317F-2398-41DB-B515-4373B9B83354";
        public const string DryTapping = "8510AE11-ED7E-4c8f-A57E-0373B3678027";
    }
    #endregion

    // TT 1816 - dko 27/01/2006, Used by the AMRSImport SpecApp
    #region InstallationSourceList
    public struct InstallationSourceList
    {
        public const string Agreement = "02EBA2CE-9755-4C92-BDDC-8542A7EF4C06";
        public const string Email = "14CE90BB-2643-4259-BFC5-B8788DC31829";
        public const string Field = "B8C40722-D7EC-441A-89C5-53712289E6CB";
        public const string ServiceCall = "49AA6691-AC7C-40B5-B4BB-B8A956C78585";
        public const string SingleResidential = "79FA9FCC-3B81-4EB1-BD47-0774D0323D8D";

    }

    #endregion

    // TT 2017 - dko 02/06/2006
    #region MinorWorksList

    public struct MinorWorksList
    {

        public const string BranchOwnerCost = "FA31A13E-77F3-45EE-8CC0-2DC74D4C3FF4";
        public const string BranchSEWCostArr = "6B1E3894-801D-4F97-8169-40181C265867";
        public const string BranchSEWCost = "F212B265-9A8C-4FD7-BC13-A21C1E75736C";
        public const string WatExtOwnerCost = "1BF320A0-715F-424C-942E-B46DB8F2409A";
        public const string WatExtSEWCostArr = "93DF040A-9C67-44E3-8556-54B114FAD1BD";
        public const string WatExtBranchSEWCost = "4D7F03FF-2BB1-448C-A917-F2DE58B859CA";
        public const string SewExtOwnerCost = "3086B720-17EC-4C30-9E05-821D7BCD9186";
        public const string SewExtSEWCostArr = "261364D6-9EEA-4DA1-9EDC-12018339931E";
        public const string SewExtBranchSEWCost = "3B7F11D5-92F6-4E48-9A58-2EE9D077E3F9";

    }

    #endregion

    // TT 2140 dko 28/06/2006
    #region ConditionServicesList

    public struct ConditionServicesList
    {
        public const string Water = "2269CCD0-9410-486A-B7A0-A5F5B5CBEE29";
        public const string Sewer = "49E87028-9E67-4ADE-B18A-6C9C22F0B099";
        public const string General = "26E1355E-B70B-4F52-B5A2-321658ABFD85";
        public const string RecycleWater = "31D6FC55-B676-400e-AF55-068B2A3CDFD6";
    }

    #endregion

    // TT 4652 rgc 29/01/2010
    #region RecycledWaterPricingZones

    public struct RecycledWaterPricingZones
    {
        public const string Low = "CF8DE08A-B5FD-45c4-9981-F5786DB964F5";
        public const string Medium = "BCB024B3-9022-4b9b-8C56-3BA9B67DE20B";
        public const string High = "F5A815B0-6414-4282-89C0-2713C6E09D4D";
    }

    #endregion

    // TT 4652 rgc 12/03/2010
    #region IntegratedWaterTypes

    public struct IntegratedWaterTypes
    {
        public const string GreyWater = "56E6199C-6726-4EEA-9E52-D149EE027B10";
        public const string RainwaterAbove = "64DE690C-B174-4272-9CC4-D36F35CF0040";
        public const string RainwaterBelow = "3E36160F-019F-4C2E-AF0D-8C8489ECEB23";
        public const string BlackWater = "C7A2DF26-29A4-464D-810F-EBD23BAE8521";
        public const string StormWater = "F8ECC3FF-27BB-47DA-88FD-D43B0759BDBF";
        public const string BoreWater = "6561BFA5-60E7-4BBF-8F5A-72FE781807D7";
        public const string DesalinationWater = "63B71952-D342-45B2-A53D-4151A55972E5";
        public const string Other = "33C15202-B133-4392-A270-9A76E97D4503";
    }

    #endregion

    #region CaseLocationOptions
    public struct CaseLocationOptions
    {
        public const int None = 0x00000000;
        public const int Property = 0x00000001;
        public const int DevelopmentLocation = 0x00000002;
        public const int FreeText = 0x00000004;
    }
    #endregion

    #region Backflow Hazard Level

    // TT4703 RGC 14/04/2010 - this is an existing list, but constants are now
    // required for use in the Plumbing PFE screens.
    public struct HazardLevel
    {
        public const string NotApplicable = "5B3E7FBC-28DF-4E97-BE19-1627D5B73468";     // added 05/08/10 Scrum#58
        public const string Unsure = "B9D09482-9E63-4228-91E6-5C6767321361";
        public const string Low = "248BA3D6-DC58-4A2B-BFDA-51E517CDC5B6";
        public const string LowTestable = "29493454-17AA-4F45-913B-44F940029FC7";       // PCE2707 31/03/07
        public const string Medium = "986697B7-5A60-4CA7-82F4-FB0A07B3CFA2";
        public const string High = "5B3BBA8E-6288-4D28-9996-3055068DAFB9";
    }

    // Scrum 244
    public struct TappingSizeList
    {
        public const string TappingSize20mm = "B66E51A5-9F51-4BC2-85E3-A1A9B8DFA583";
    }
    #endregion

    #region NoCostReason
    // Scrum 244
    public struct NoCostReasonList
    {
        public const string SEWLStaff = "1151C0C2-7E7E-48B8-A57C-8977CCC7450B";
        public const string ManagementApproval = "379C17ED-C728-4A2E-9A84-30B8AD7DCA71";
        public const string SEWLError = "9B11A9B3-D2E3-4877-BB44-01050E399D4E";
        public const string CFEBusinessRule = "721E1E28-74E4-4b61-ABFC-0DC484186368";
        public const string PressureSewer = "72FAB81D-89EE-41FE-8573-B33C6EE34EF8";
    }
    #endregion

    #region Recycled Water Inspection Types
    public struct RecycledWaterInspectionTypes
    {
        public const string R1 = "BED46A8E-38B9-4a70-B777-8009800D0262";
        public const string R2 = "C59ECA16-8366-44b3-9E86-9AE775640AA7";
        public const string R3 = "5A36CCB7-2120-4541-BAD0-C5D76FAA773A";
        public const string R4 = "7589F57D-E55C-4311-930D-62E70C5B94D7";
    }
    #endregion

    // Michael Pine (03/03/2016)
    #region Type of Development
    public struct TypeOfDevelopmentList
    {
        public const string Residential = "61417D45-E618-4F12-A68A-0A38FBD1ECF1";
        public const string CommercialOrIndustrial = "EB9E2ED6-1A94-4693-B146-E5F38F945804";
        public const string Industrial = "644777F2-9541-4D0D-A00F-B33B05A38C99";
        public const string MixedResidentialAndCommercial = "C8647D25-FF37-4EC1-A72B-23FF00373940";
        public const string RetirementVillage = "3D207D68-670F-4CFE-8400-D14953616EEC";
        public const string CaravanPark = "AEA33134-5A63-4C53-9CE9-55ABF1E9010C";
        public const string Roadworks = "347E4C69-D278-4C6A-BECF-C101EB7216AB";
        public const string Relocation = "AB56503C-E487-4957-961C-305E034DC5F4";
        public const string OtherAuthoritiesWork = "8D1B4B87-4B17-4D1B-AE1C-1D5AC65C341D";
    }
    #endregion

    #region Plumbing Job Type
    public struct PlumbingJobTypeList
    {
        public const string ResidentialTwoUnits = "77721918-B441-48B2-95C7-BF796246F1AB";
        public const string ResidentialThreeToNineUnits = "D1FFBA9A-484A-4F2F-8F15-443BF95B2276";
        public const string ResidentialTenPlusUnits = "63F82B60-46EA-483D-A1F7-89EC8BF33913";
        public const string ResidentialTemporaryWaterConnection = "4C360879-FAD1-4D9F-B2C8-102A8678F33F";
        public const string ResidentialConnectAlterOrRemoveWater = "E423858B-C0B5-4530-963E-AB9F4D91B403";
        public const string ResidentialSewerConnectionAlteration = "93863052-F08C-4AE4-9C6E-B36F9E154DB8";
        public const string IndustrialSingleDevelopment = "7DA8381C-DC8B-4B0B-BD2F-0B6F90D50DAF";
        public const string IndustrialMultiDevelopment = "756D4F21-02A1-4CC6-AD15-31879748C7D1";
        public const string IndustrialTemporaryWaterConnection = "A870BEEB-876B-4BA3-93BE-4388EF86AA4D";
        public const string IndustrialConnectAlterOrRemoveWater = "67642F10-AF92-4965-94FA-91FCCF359D77";
        public const string IndustrialSewerConnectionAlteration = "69887C10-1689-4764-9254-476BF99A5CAB";
        public const string IndustrialInternalDrainAlteration = "29EAA3C9-BF70-4522-AC2B-76C500965889";
    }
    #endregion

    // Michael Pine (02/03/2018)
    #region SDO Pipe Status
    public struct SDOPipeStatus
    {
        public const string Accepted = "6661E9BA-CF9F-4F7B-E054-00144FEADF8C";
        public const string Rejected = "6661E9BA-CFA0-4F7B-E054-00144FEADF8C";
    }
    #endregion

    // TT3301, YL 12/06/2018. Added Backflow rating for SRC Water
    #region BackflowRatingList
    public struct BackflowRatingList
    {
        public const string Low = "6E679143-191B-3C22-E054-00144FEADF8C";
        public const string LowTestable = "6E679143-191C-3C22-E054-00144FEADF8C";
        public const string Medium = "6E679143-191D-3C22-E054-00144FEADF8C";
        public const string High = "6E679143-191E-3C22-E054-00144FEADF8C";
    }
    #endregion

    // Michael Pine (26/06/2018)
    #region Steps
    public struct Steps
    {
        public const string Payment = "6F8402BE-4AA0-1700-E054-00144FEADF8C";
        public const string Booking = "6F8402BE-4AA1-1700-E054-00144FEADF8C";
    }
    #endregion

    // Michael Pine this should hold all of the strings that relate to an area i.e AQUAREVO
    public struct Areas
    {

        public const string Aquarevo = "AQUAREVO";
    }

    public struct CommentsConfiguration
    {
        public const string SiteComments = "713E86C3-DD48-746B-E054-00144FEADF8C";
    }

    public struct PFIActiveStatus
    {
        public const string Active = "7FAEB2B9-9489-6D19-E054-00144FEADF8C";
        public const string Archived = "7FAEB2B9-948A-6D19-E054-00144FEADF8C";
        public const string UserEdited = "7FAEB2B9-948C-6D19-E054-00144FEADF8C";
    }
    public struct PFIImportStatus
    {
        public const string InProgress = "7FAEB2B9-948D-6D19-E054-00144FEADF8C";
        public const string New = "7FAEB2B9-948E-6D19-E054-00144FEADF8C";
        public const string Completed = "7FAEB2B9-948F-6D19-E054-00144FEADF8C";
        public const string Failed = "7FAEB2B9-9493-6D19-E054-00144FEADF8C";
    }
    public struct PFIErrorClassifictions
    {
        public const string NegativePressure = "7FAEB2B9-9490-6D19-E054-00144FEADF8C";
        public const string MaxPressureExceed = "7FAEB2B9-9491-6D19-E054-00144FEADF8C";
        public const string NoPressure = "7FAEB2B9-9492-6D19-E054-00144FEADF8C";
        public const string UnKnown = "7FAEB2B9-948B-6D19-E054-00144FEADF8C";
    }
}
