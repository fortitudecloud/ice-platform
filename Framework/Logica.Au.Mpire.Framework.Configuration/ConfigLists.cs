using System;

namespace Logica.Au.Mpire.Framework.Configuration.ConfigLists
{
	/// <summary>
	/// This struct defines the ID's of the config groups and config values in the system
	/// </summary>
	public struct ConfigGroups
	{
		public const string AssetWebMap				= "F76BDCDD-6C14-4E77-BC1A-0223C3393365";
		public const string BusinessHours			= "4737CF67-7FF5-4AD9-BF08-10FC542B247E";
		public const string CreditCard				= "B53701CD-EFDA-4FA9-86CB-8967B2EA6F1C";
		public const string CardGate				= "937D236F-0C51-4c0d-8653-F8BEB3122D7B";
		public const string CustomerSummons			= "30AAE065-E68B-485F-9160-EF072F6E73D3";
		public const string DeliverDocumentsPro		= "40B53EA6-A3AF-4076-9C1F-BC3BD2FA9616";
		public const string DMC_FolderLocations		= "CCD18A84-D62E-4BE0-BC72-5C7505DA994C";
		public const string Environment				= "F1C961DF-4F51-42EB-A220-678629AD654A";
		public const string FieldView				= "23390EF9-F6F1-4E6B-865C-EDF272F8FFE7";
		public const string FixLocationPro			= "1BE1944B-7198-444A-8801-A850585D4308";
		public const string LiveLinkAttributes		= "BC3A2B68-0AD8-4DC6-8A4E-F890A7BFD2AC";
		public const string LivelinkServerConfig	= "144AD421-9FB0-4352-B17B-071F43AE8EAB";
		public const string PFEScreens				= "D25E4420-3597-4484-8767-4874E9A0EA9B";
		public const string PropertyCreationsPro	= "5416F1CF-6700-48F5-B3E2-2E86312A8021";
		public const string PropertyDrainage		= "53C43235-B85E-4F73-8055-6E8BEB79259E";
		public const string PropertyScheme			= "91EC4355-E875-4E5D-ADB3-F2769B6EF36E";
		public const string PSPMediums				= "B751EEB8-7403-4854-AAB6-ACF6CBCE55F5";
		public const string PSPPro					= "50C9E8EA-F420-45B4-8C54-9805FCB0A3AA";
		public const string QAS						= "96B94A77-282A-4399-B6E1-335DA39A4D04";
		public const string WebLogin				= "A26F12A9-18CB-4E6D-88C2-AB2B8AE371AC";
		public const string WebQuarantine			= "507FEE0E-8D58-476C-B357-EB5ACABDBBCD";
        public const string PlumbingPro             = "55C7E642-8342-465d-A048-55333D56046D";
		

	}

	#region AssetWebMap . . .
	public struct AssetWebMapConfig
	{
		public const string AssetMapGeneric = "AD7E7095-3A0A-4DFD-8828-4621746DA57B";
		public const string AssetMapByRange	= "95509CBA-9F17-46DE-BFF0-3A21FBEFC9C2";
		public const string IEXPLORE		= "CB34EE1E-A9DF-4DB6-BF20-45D673BDFC49";
		public const string Server			= "F3918509-0B05-4734-B42B-7954AAE4A1D6";
		public const string ScriptPath		= "8BE7FB61-AF33-4B1F-93ED-11A8B0738F0E";
		public const string HTMLSpec		= "B455D31C-4E26-4FD5-A4FA-836FB467031C";
		public const string Width			= "076E93FF-5B84-4989-8BF8-9C9B194C31A5";
	}
	#endregion
	
	#region Businesshours . . .
	public struct BusinesshoursConfig
	{
		public const string closeOfBusinessTime = "B103CF24-CFBB-4094-9B2B-3892E007B963";
		public const string StartOfBusinessTime = "BA6D5F2A-8B30-4771-AE3E-7CFA3B495674";
	}
	#endregion

	#region CardGate . . .
	public struct CardGateConfig
	{
		public const string CardGateHostIP = "FFD6F6CC-FCD7-45a1-B84D-A313F4778DFD";
		public const string CardGatePort = "44D4DA50-D18D-4fb0-84AA-14D76218A9B7";
		public const string CardGateCAIC = "2E8DA438-BFEC-404b-A7CF-C716341D98C7";
		public const string CardGateICESourceID = "398D5BC8-A7CC-4f10-AC4F-0B28A4BEBB0A";
		public const string CardGateRTPrefix = "D228EF29-2ACC-47A2-9033-A8DEBB7E86AA";
	}
	#endregion

	#region CreditCard . . .
	public struct CreditCardConfig
	{
		public const string CreditCardLimit		= "BE0A032D-75F7-4D48-91F6-E4ACA06EE546";
		public const string WebCreditCardLimit	= "DEB65777-9450-41DB-81E9-56852D39AD00";
		public const string MerchantFeeRate		= "5FCD1127-8994-4EC4-81DE-25C43992696D";
		public const string MerchantFeeLimit	= "3904E876-877A-49BC-94D8-AED979D687BE";
	}
	#endregion

	#region Contact . . .
	public struct ContactDeadlineConfig
	{
		public const string ContactURL		= "B1B04202-AE6F-40E3-9121-B6D260273153";
		public const string WarningDuration	= "D03133ED-0AA7-4AAF-BF8C-06FAA53C6464";
	
	}
	#endregion


	#region CustomerSummons . . .
	public struct CustomerSummonsConfig
	{
		public const string CustomerSummonsEmail = "24E71A8E-CB52-40FB-BEE1-E170F9637308";
		public const string CustomerSummonsName	 = "C837ACAA-184C-4CAD-9D1F-EB98481F09B0";
		public const string CustomerSummonsPhone = "27B40C1F-0160-4DB4-AF37-2473075DD855";
	}
	#endregion

	#region DeliverDocumentsPro . . .
	public struct DeliverDocumentsProConfig
	{
		public const string FAXDLINEDAY	= "5812FF1E-4BAE-4D8D-8538-1947E5EE3CAF";
		public const string FAXDLINEHR	= "F0F896E4-70EB-4A11-9094-2EC0611E1CE0";
		public const string DEADLINEDAY	= "C07E0BED-C251-4EEC-A0DA-C6B48195C112";
		public const string DEADLINEHR	= "E214AA95-0B49-4C0D-BE51-66522EBD27F2";
		public const string FRONTCOUNTER= "1056018F-7235-4791-9F66-520E5EB4CAC3";

	}

	#endregion

	#region DMC_FolderLocations . . .
	public struct DMC_FolderLocationsConfig
	{
		public const string CustomerICEDoc	= "CAD63A4C-983B-4D1B-862C-EC8C4D8BCFAC";
		public const string CaseICEDoc		= "2A1434C3-99AA-44AE-92C7-105CEB7D3F35";
		public const string DevLocICEDoc	= "A92FB9FA-F249-4130-8841-D6A1DA67E994";
		public const string OrderICEDoc		= "518783B1-154B-4C82-8217-0599925C987B";
		public const string PropertyICEDoc	= "A5D9CA23-E2A6-4D41-8CB8-B38CCBA4D27F";
		public const string CustomerPSPDoc	= "28BBB425-D91C-4444-BC24-92DE763B2E64";
		public const string CasePSPDoc		= "4E0B8380-A04C-4856-BE6D-9DCC83935ADD";
		public const string DevLocPSPDoc	= "EFDAE811-CB55-4809-AB04-510D647307E2";
		public const string OrderPSPDoc		= "57FBFD56-DDE2-4AD9-AA64-79556C965F2D";
		public const string PropertyPSPDoc	= "A9CB7F43-95F9-4E92-A4BB-3E08F8D7421C";
		public const string LetterICEDoc	= "E7F952F9-48C8-49FD-AFE5-6F889EAA7E0E";

	}
	#endregion

	#region DuplicateApplications . . .
	public struct DuplicateApplicationsConfig
	{
		public const string DaysForDuplicate = "4C333576-ABA7-48E6-88BC-ED5A7F3DE2F6";
		public const string ExcludeFromDuplicateCheck = "A1029CC2-9BB1-42EB-B734-F35E9DB0204F";

	}
	#endregion


	#region Environment . . .
	public struct EnvironmentConfig
	{
		public const string Environment		= "C2E0757C-92F2-4923-87AC-919BED08AA1E";
		public const string DatabaseVersion = "4DEE7630-C733-444B-B4C9-DFD0A0BCA72B";
		public const string IceAdminName	= "EC824C7C-1AA2-47C3-8FB6-6D1B69516852";
		public const string IceAdminPhone	= "E4DD0D6C-1C31-4182-BFE2-E2F215B74011";
		public const string SEWLGPSMaxX		= "14913865-A1C9-4AF9-8437-EE093FDA49EC";
		public const string SEWLGPSMaxY		= "3D42F5C3-3D9A-4E03-B382-1F9240C3A37A";
		public const string SEWLGPSMinX		= "24413E48-1F06-4BC3-9FF8-7878F276C2B7";
		public const string SEWLGPSMinY		= "E518D134-7485-4AD2-A8AA-7BD535DEF108";
		
	}
	#endregion

	#region FieldView . . .
	public struct FieldViewConfig
	{
		public const string RegistryKey		= "F2831584-202A-43D8-AC17-84B3311B56D2";  
	}
	#endregion

	#region FixLocationPro . . .
	public struct FixLocationProConfig
	{
		public const string DEADLINEDAY	= "1DE9C2AE-360E-4C0B-8EA3-E55CD2866DEF";
		public const string DEADLINEHR	= "A28D0D6A-E7CB-4CF2-BEEF-3FDAB9E8EB24";
		public const string EMAILDLDAY	= "87CA12F8-D725-49DF-B681-8E2D4AAA6D7A";
		public const string EMAILDLHR	= "580B3E0E-F030-4D17-B746-BBF88BF2E6F6";
		public const string PROPCRSUBJ	= "B713BB52-B176-4AEE-BBD6-ECB2614F8F9E";

	}
	#endregion

	#region LiveLinkAttributes . . .
	public struct LiveLinkAttributesConfig
	{
		public const string FileName		= "5FE37C7A-F69A-4CB7-A165-B6D2BF573FCF";
		public const string PSPNumber		= "0FCAD229-1F73-4FE0-A89F-0DF3E8DD03E7";
		public const string Customer_Number	= "8F6D20C8-A8FA-4F2D-B17C-215569127C30";
		public const string Customer_Name	= "43DF0FBD-5FEF-4F4E-9B20-11A636FF34C6";
		public const string Property_Number	= "93488F23-1870-4984-87CA-05483ECB1B9B";
		public const string Property_Address= "367788DF-6C1C-41B5-8626-9C15A385904F";
		public const string Post_Code		= "7303B29B-256B-4F6A-8E65-2BC2B432CA06";
		public const string LP_Number		= "950CE7FF-E259-41A3-8D43-97CBC5823EF8";
		public const string Lot_Number		= "172EE8C0-8B99-4420-A3C9-7B480AA52A7F";
		public const string SEWL_Reference	= "32983476-6045-4AA0-BC56-598DDD3A06D0";
		public const string Estate_Name		= "D975B3C4-1207-4417-8293-98E88687E947";
		public const string Estate_Stage	= "CAAE30F7-DFBA-45CD-94AD-2420EC6966D1";
		public const string Entity			= "34C0CA03-7186-455E-867D-85E7A44552BF";
		public const string Entity_Ref		= "13CB9641-B501-42FB-A7CA-3128053A22A9";
		public const string Archive_Date	= "9B3CEEFA-593C-40BB-9DB0-7936C7E228D7";
		public const string ICE_Service		= "79EF9A21-1B7D-4D67-9487-B386AE0C1FBE";
		public const string Process_Step	= "13D9E311-BFE7-4F63-BA1B-9373B44B310E";
		public const string ICE_Case		= "5902F851-01BF-49CA-A4C4-7914F98030D3";
		public const string Scan_Date		= "62191DB6-2A10-4ABC-BF4C-C6D0008BCD67";
		public const string Size			= "8641ECA3-14A3-43FA-8C69-03B332F5A48E";
		public const string Medium			= "E6E8F828-D119-46C8-ACA2-2B22B6D2A508";
		public const string Archived		= "9030C65F-6687-4C68-9876-684ADDC8E82D";

	}
	#endregion

	#region LiveLinkServer . . .
	public struct LiveLinkServerConfig
	{
		public const string LivelinkHostname	= "FD432395-81A4-4443-9264-E4845A4A5D49";
		public const string LiveLinkPort		= "80C6A107-DA60-4bff-A5C5-2AF6FE99780A";
		public const string LL_UseWeb_TrueFalse = "9F7F447B-61A5-4D4C-9197-52E9B2EA702F";
		public const string LL_WebPort			= "0EDC8E1D-93BF-47A3-A04F-C7568DD1236F";
		public const string LL_CGI_Bin			= "D66914B4-4388-41C5-9357-4EE0363D8322";
	}
	#endregion

//	#region PropertyCreations . . .
//	public struct PropertyCreationsConfig
//	{
//		public const string PropName = "ADA336B6-EBAE-4BDE-A5D2-FAAA60E28587";
//		public const string PropPhone = "333D7F42-1926-4295-B679-2972F23B9493";
//		public const string PropEmail = "447A2B1A-7CBB-4E77-8FAE-ACA12425D23A";
//	}
//	#endregion
	
	#region PFEScreens . . .
	public struct PFEScreensConfig
	{
		public const string S0101ChProp	= "4BDEB723-BCCD-4FF4-8ABC-632B42453CBD";
		public const string S0101CkProp	= "C19A9DD7-AD86-4525-B353-503A09D2F420";
		public const string S0101AsProp	= "449FA0A3-A8C8-49C3-A0DB-560B0D917367";
		public const string S0101ChICE	= "DCDF6FD0-49FD-41A0-A5CA-FB2C090A13CA";
		public const string P1202DirRfT	= "6C3584DC-2C41-4B88-9690-EC6C64205DA9";
		public const string S01MatchProT= "71152269-8B75-400A-883D-E0BF3DC55B19";
		public const string S04AwaitCol	= "8B72B65D-FF6B-4CFE-9DD9-EE79B36D49E7";
		public const string S04NotPickup= "282BC2D5-E91C-4FF5-938B-FBB0FFBDADFB";
		public const string S04FaxNoSent= "5C9F864B-E692-49B2-BAA7-0E6A485EB9B3";
		public const string S04DelManual= "7590450E-EDD5-40E5-9B7C-9DB32E3C4677";
		public const string GCancelCase	= "005C5BCD-6C85-45E0-88A1-4BE75462D2C0";
		public const string GSuperEsc	= "C2206AD1-B0D1-4370-9811-E7F8F029915F";
		public const string GSLAExceed	= "2B2809E0-C90F-4A14-A81F-43CDADB29917";
		public const string P12PrdAPlanT= "4487F46A-53B4-4EED-BB22-0FC6F4A6B915";
		public const string P2901FindPSP= "6EED2707-04B3-42A4-B6C1-9C9B6A0221AA";
		public const string P12PrdDPlanT= "93F461C0-C219-453F-9DB3-641122F3823B";
		public const string P2901ViewPSP= "273552F4-4A6F-4A4A-A508-79B350047382";
		public const string P2902RevwPSP= "364AF937-62B6-4016-938A-17DFBA4E373C";
		public const string P2902Create	= "4D29FAA9-2370-4772-8DCA-E7F056E2BFBE";
		public const string S03ChkPayT	= "3A7BBCAA-2993-407C-A175-924D90D4DC5B";
		public const string P2902ImgPSP	= "A65FE4EC-F1DF-43ED-8679-FCA27E204DFF";
	}
	#endregion
	#region PropertyCreationsPro . . .
	public struct PropertyCreationsProConfig
	{
		public const string PropName	= "ADA336B6-EBAE-4BDE-A5D2-FAAA60E28587";
		public const string PropPhone	= "333D7F42-1926-4295-B679-2972F23B9493";
		public const string PropEmail	= "447A2B1A-7CBB-4E77-8FAE-ACA12425D23A";
	}
	#endregion

	#region PropertyDrainage . . .
	public struct PropertyDrainageConfig
	{
		public const string PropDrainageEmail	= "EB339451-A1C3-4333-A727-B1119848C3C2";
		public const string PropDrainageName	= "FB373F54-9714-410C-9D11-9FB43DD10E21";
		public const string PropDrainagePhone	= "7E2D5A8F-43A5-443E-96C0-56B1577CF0F1";
	}
	#endregion

	#region PropertyScheme . . .
	public struct PropertySchemeConfig
	{
		public const string PropSchemeEmail = "2C22A23E-BA7D-49C0-BA29-A0C2CA25F63B";
		public const string PropSchemeName	= "D8E3B4A5-12BF-4E53-86A3-550850A8E62E";
		public const string PropSchemePhone = "E88B6BF8-1BAE-4CFE-976D-FADE8C868935";
	}
	#endregion

	#region PSPMediums . . .
	public struct PSPMediumsConfig
	{
		public const string CONSENT		 = "F1398C12-4368-4B6F-8D5A-338078E1203C";
		public const string PSP			 = "6699B0B3-8574-4173-B262-F4233DC94B72";
		public const string BACKLOGPSP	 = "DB03DAED-D8A6-4F61-B50A-5D6119CE1623";
		public const string PSPMULTIPAGE = "164287D1-D37A-4331-BEC4-AFA5ED204ADE";
		public const string BLOCKPLAN	 = "6372D305-E2DD-4AAD-AFF1-C80448FE9492";
		public const string FIXTURES	 = "819D941A-B0C0-4187-96C8-E7B4587D7D32";
		public const string UPDATEPSP	 = "BD5C238A-23E2-47F1-8093-19F47D000652";
		public const string UPDATEPSPMULTIPAGE = "7E8B02E3-480F-4A05-863B-5283E745A45F";
		public const string CRONO		 = "ACCC7C78-6085-4CCA-B843-BDC96AFB7FBB";
		public const string PAPER		 = "A25E6B1E-B24D-4431-871D-1F396C7D4135";

	}
	#endregion

	#region PSPPro . . .
	public struct PSPProConfig
	{
		public const string SLADLDAY	= "7E90D8B4-F3E7-4977-B510-B2E258F829D4";
		public const string DEADLINEDAY	= "938181B8-278E-4D61-A35F-F3CFB921B7E2";
		public const string DEADLINEHR	= "8EE543CE-99C9-4B51-8D96-514B1D2B2BA8";
		public const string SLADLHR		= "2F3C33E6-266E-4D44-A96B-2A37BAE7C747";
		public const string IMAGEDLDAY	= "7E2A9D85-1013-492F-AF8B-4C64C0F0AFFB";
		public const string IMAGEDLHR	= "776C8B6A-40BC-4F54-B018-00E67D9452E3";
		public const string MAXPSPS		= "9E85A8EA-1E51-4B85-98DF-CE37CAE91579";
	}
	#endregion

	#region QAS . . .
	public struct QASConfig
	{
		public const string DLLPath			= "2A62DE1B-A690-4317-A078-1DACE1D162A3";
	}
	#endregion

	#region WebLogin . . .
	public struct WebLoginConfig
	{
		public const string LoginAttempts	= "053F2F5D-6406-4A58-8B68-439EA8363585";
	}
	#endregion

	#region WebQuarantine . . .
	public struct WebQuarantineConfig
	{
		public const string QuarantinePath = "9B9B4058-99CA-433D-9E4B-D69BD78E28F9";
	}
	#endregion

    #region PlumbingPro . . .
    public struct PlumbingProConfig
    {
        public const string EXPIRYMONTHS = "7902B921-A463-0AB1-E044-00144FEADF8C";

    }
    #endregion

}



