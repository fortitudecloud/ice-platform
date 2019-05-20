using System;
using System.Data;
using System.IO; 
using System.Collections;
using System.Diagnostics;
using Logica.Au.Mpire.Framework.Utilities;
using Logica.Au.Mpire.Framework.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;

namespace Logica.Au.MpireFramework.Utilities.Tests
{
	
	[TestClass]
	public class UtilitiesTestHarness
    {
        public UtilitiesTestHarness()
		{
		}

        // CreateSubDirectoryTest_Success test definition.
		// PCS Monday, 22 March 2004
		[TestMethod]
		public void CreateSubDirectoryTest_Success()
		{
			
			string currentDir = Directory.GetCurrentDirectory()  ;

			string newDirectory = "SubDirectory";

			string newDirectoryPath = string.Format("{0}\\{1}",currentDir , newDirectory );

			if( Directory.Exists( newDirectoryPath )) Directory.Delete( newDirectoryPath );

			try
			{
				Console.WriteLine( string.Format("Creating Path \"{0}\".", newDirectoryPath ) );

				MpireFolder.CreateLocalSubDirectory( newDirectoryPath );

			}
			catch( Exception ex )
			{
				Console.WriteLine( ex.Message );
			}

			//Assertion.Assert( Directory.Exists( newDirectoryPath ) );

			Console.WriteLine( string.Format("Path \"{0}\" exists.", newDirectoryPath ) );
		
			// and delete the directory
			Directory.Delete(  newDirectoryPath );
		}


		// CreateSubDirectoryTest_Fails_ParentNotExisting test definition.
		// PCS Monday, 22 March 2004
		[TestMethod]
		public void CreateSubDirectoryTest_Fails_ParentNotExisting()
		{
			
			string currentDir = Directory.GetCurrentDirectory()  ;

			string newDirectory = "ParentDirectory";

			string newDirectoryPath = string.Format("{0}\\{1}",currentDir , newDirectory );

			if( Directory.Exists( newDirectoryPath )) Directory.Delete( newDirectoryPath );

			string secondDirectory = "ChildDirectory";

			newDirectoryPath = string.Format("{0}\\{1}\\{2}",currentDir , newDirectory, secondDirectory );

			try
			{
				Console.WriteLine( string.Format("Creating Path \"{0}\".", newDirectoryPath ) );

				MpireFolder.CreateLocalSubDirectory( newDirectoryPath );
				
			}
			catch( Exception ex )
			{
				Console.WriteLine( ex.Message );
			}

			//Assertion.Assert( !Directory.Exists( newDirectoryPath ) );

			Console.WriteLine( string.Format("Path \"{0}\" does not exist.", newDirectoryPath ) );

		}


		[TestMethod]
		public void CreateDirectoryTest()
		{
			
			string currentDir = Directory.GetCurrentDirectory()  ;

			string newDirectory = "ParentDirectory";

			string newDirectoryPath = string.Format("{0}\\{1}",currentDir , newDirectory );

			string ParentDirPath = newDirectoryPath;

			if( Directory.Exists( newDirectoryPath )) Directory.Delete( newDirectoryPath );

			string secondDirectory = "ChildDirectory";

			newDirectoryPath = string.Format("{0}\\{1}\\{2}",currentDir , newDirectory, secondDirectory );

			try
			{
				Console.WriteLine( string.Format("Creating Path \"{0}\".", newDirectoryPath ) );

				MpireFolder.CreateDirectory( newDirectoryPath );
				
			}
			catch( Exception ex )
			{
				Console.WriteLine( ex.Message );
			}

			//Assertion.Assert( Directory.Exists( newDirectoryPath ) );

			Console.WriteLine( string.Format("Path \"{0}\" exists.", newDirectoryPath ) );

			//  delete the directory
			Directory.Delete(  newDirectoryPath );

			// and the parent directory
			Directory.Delete(  ParentDirPath );
			
		}

        #region XmlData
        string xml = @"<application>
              <forms>
                <property>
                  <property>
                    <CISPropId>53S//00015/00107</CISPropId>
                    <DirectoryRef>128D11</DirectoryRef>
                    <GridCoordX>343244</GridCoordX>
                    <GridCoordY>5783025</GridCoordY>
                    <HouseName/>
                    <LotNumber>Lot 702</LotNumber>
                    <PostCode>3977</PostCode>
                    <PropertyId>148FC2BD-04B7-4D1C-A7E3-E304164F54F4</PropertyId>
                    <PropertyNo>18726560</PropertyNo>
                    <PSPNumber>40089890</PSPNumber>
                    <Reference1/>
                    <Reference2/>
                    <RefNumber1/>
                    <RefNumber2/>
                    <SPI/>
                    <StreetNameAndType>SANDHURST BOULEVARD</StreetNameAndType>
                    <StreetNumber>132</StreetNumber>
                    <SubDivPlanNo>PS 500745</SubDivPlanNo>
                    <Suburb>SANDHURST</Suburb>
                    <DT_RowId>148FC2BD-04B7-4D1C-A7E3-E304164F54F4</DT_RowId>
                    <ShortAddress>132 SANDHURST BOULEVARD</ShortAddress>
                    <FullAddress>LOT 702   132 SANDHURST BOULEVARD, SANDHURST, 3977</FullAddress>
                    <PropertyType>Domestic</PropertyType>
                    <PropertyUsage>Domestic</PropertyUsage>
                    <Selected>false</Selected>
                    <Line1>LOT 702  </Line1>
                    <Line2>132 SANDHURST BOULEVARD</Line2>
                    <Line3>SANDHURST, 3977</Line3>
                  </property>
                </property>
                <service>
                  <services>
                    <ServiceId>AAB3E1AE-4B22-4CCC-8B78-4769C0E9E670</ServiceId>
                    <ServiceName>Plug and Re-tap</ServiceName>
                    <Blurb>Are you relocating your water meter/s?</Blurb>
                    <ServiceDesc>Wat Only Plug &amp; Tap New water tapping, plugging of old tapping . This is applicable for properties where a previous water connection is provided and a new sewer connection is not required</ServiceDesc>
                    <PlanEnabled>true</PlanEnabled>
                    <PlanRequired>false</PlanRequired>
                    <DateRequired>false</DateRequired>
                    <PlumberRequired>true</PlumberRequired>
                    <SettlementDateRequired>false</SettlementDateRequired>
                    <MobileSubmitAllowed>true</MobileSubmitAllowed>
                    <Default>false</Default>
                    <DisplayName>Single residential connection - Plug and Re-tap</DisplayName>
                    <Enabled>true</Enabled>
                    <EnabledByGroup>false</EnabledByGroup>
                    <Image>portal-icon-src</Image>
                    <ServiceItems>
                      <ItemId>94F810E3-154D-4D58-B40D-FA0BEFFBBC3E</ItemId>
                      <ItemName>DWRW Meter Deviation</ItemName>
                      <ItemDescription>Deviation of drinking &amp; recycled water services</ItemDescription>
                      <ItemCost>$ 444.00</ItemCost>
                      <ItemCostRaw>444</ItemCostRaw>
                    </ServiceItems>
                    <ServiceCostRaw>513.79</ServiceCostRaw>
                    <ServiceCost>$513.79</ServiceCost>
                    <Selected>true</Selected>
                    <Value>WAT ONLY PLUG TAP</Value>
                    <IsProduct>false</IsProduct>
                    <IsVisible>false</IsVisible>
                    <Vacant>no</Vacant>
                    <Tapping>wetdry</Tapping>
                    <Sewer>false</Sewer>
                    <Water>true</Water>
                    <Recycled>false</Recycled>
                    <Group>Water</Group>
                    <Instructions>
                      <Url>order/src/relationship</Url>
                      <Condition/>
                    </Instructions>
                    <Instructions>
                      <Url>order/src/plumber</Url>
                      <Condition/>
                    </Instructions>
                    <Instructions>
                      <Url>order/src/water</Url>
                      <Condition/>
                    </Instructions>
                    <Hidden>false</Hidden>
                  </services>
                </service>
                <water>
                  <meterInDriveway>yes</meterInDriveway>
                  <meterBeClear>yes</meterBeClear>
                  <meterPosition>right</meterPosition>
                  <meterLocked>no</meterLocked>
                  <meterReady>no</meterReady>
                  <belowGround>no</belowGround>
                </water>
                <plumber>
                  <plumbersFirstname>SYDNEY GEORGE</plumbersFirstname>
                  <plumbersSurname>MANEFIELD</plumbersSurname>
                  <plumbersLicenceNumber>2</plumbersLicenceNumber>
                  <plumbersPhoneNumber>95838548</plumbersPhoneNumber>
                  <plumberCustomerId>93A47AB6-E0A7-48E0-B7C4-4B3F96E9DE7D</plumberCustomerId>
                </plumber>
                <relationship>
                  <alternateCustomer>no</alternateCustomer>
                  <customerName/>
                  <customerContactNumber/>
                  <customerRole/>
                  <customerEmailAddress/>
                </relationship>
                <delivery>
                  <customerNumber>13000017</customerNumber>
                  <customerPassword/>
                  <firstName/>
                  <surName>Pegasus Software Solutions</surName>
                  <emailAddress>michael.pine@sew.com.au</emailAddress>
                  <contactPhoneNumber>0407969282</contactPhoneNumber>
                  <paymentMode>1</paymentMode>
                </delivery>
              </forms>
              <swappedFees>
                <item>
                  <ItemId>1BA2F22B-1A9E-4B30-AD6D-2CBEC7F6EBD6</ItemId>
                  <ItemName>Plug Fee with Conn</ItemName>
                  <ItemDescription>Plugging Fee if done at the same time as a new connection</ItemDescription>
                  <PaymentGroupId>2A829187-B891-47D4-AE98-C911392356D0</PaymentGroupId>
                  <PaymentGroupName>Plumbing</PaymentGroupName>
                  <PaymentGroupDescription>Plumbing Fees</PaymentGroupDescription>
                  <ProposalItemFlag>true</ProposalItemFlag>
                  <ItemCost>$73.85</ItemCost>
                  <ItemCostRaw>73.85</ItemCostRaw>
                  <ItemEffectiveDate>2014-06-30T14:00:00Z</ItemEffectiveDate>
                </item>
                <swappedItem>
                  <ItemId>94F810E3-154D-4D58-B40D-FA0BEFFBBC3E</ItemId>
                  <ItemName>DWRW Meter Deviation</ItemName>
                  <ItemDescription>Deviation of drinking &amp; recycled water services</ItemDescription>
                  <ItemCost>444</ItemCost>
                  <Gst>false</Gst>
                  <PaymentGroupId/>
                  <PaymentGroupName/>
                  <PaymentGroupDescription/>
                </swappedItem>
              </swappedFees>
              <swappedFees>
                <item>
                  <ItemId>9523471C-2109-4EC2-8B9E-413150FE0392</ItemId>
                  <ItemName>Meter Fee 20mm size</ItemName>
                  <ItemDescription>Meter Fee - 20mm</ItemDescription>
                  <PaymentGroupId>2A829187-B891-47D4-AE98-C911392356D0</PaymentGroupId>
                  <PaymentGroupName>Plumbing</PaymentGroupName>
                  <PaymentGroupDescription>Plumbing Fees</PaymentGroupDescription>
                  <ProposalItemFlag>true</ProposalItemFlag>
                  <ItemCost>$97.06</ItemCost>
                  <ItemCostRaw>97.06</ItemCostRaw>
                  <ItemEffectiveDate>2014-06-30T14:00:00Z</ItemEffectiveDate>
                </item>
                <swappedItem>
                  <ItemId>94F810E3-154D-4D58-B40D-FA0BEFFBBC3E</ItemId>
                  <ItemName>DWRW Meter Deviation</ItemName>
                  <ItemDescription>Deviation of drinking &amp; recycled water services</ItemDescription>
                  <ItemCost>444</ItemCost>
                  <Gst>false</Gst>
                  <PaymentGroupId/>
                  <PaymentGroupName/>
                  <PaymentGroupDescription/>
                </swappedItem>
              </swappedFees>
              <swappedFees>
                <item>
                  <ItemId>46288365-D723-4D7D-8E8C-62E5680EDCE5</ItemId>
                  <ItemName>Tapping Fee 20-25mm</ItemName>
                  <ItemDescription>Tapping Fees - 20-25mm</ItemDescription>
                  <PaymentGroupId>2A829187-B891-47D4-AE98-C911392356D0</PaymentGroupId>
                  <PaymentGroupName>Plumbing</PaymentGroupName>
                  <PaymentGroupDescription>Plumbing Fees</PaymentGroupDescription>
                  <ProposalItemFlag>true</ProposalItemFlag>
                  <ItemCost>$342.88</ItemCost>
                  <ItemCostRaw>342.88</ItemCostRaw>
                  <ItemEffectiveDate>2014-06-30T14:00:00Z</ItemEffectiveDate>
                </item>
                <swappedItem>
                  <ItemId>94F810E3-154D-4D58-B40D-FA0BEFFBBC3E</ItemId>
                  <ItemName>DWRW Meter Deviation</ItemName>
                  <ItemDescription>Deviation of drinking &amp; recycled water services</ItemDescription>
                  <ItemCost>444</ItemCost>
                  <Gst>false</Gst>
                  <PaymentGroupId/>
                  <PaymentGroupName/>
                  <PaymentGroupDescription/>
                </swappedItem>
              </swappedFees>
            </application>
            ";
        #endregion

        [TestMethod]
        public void GetBooleanFromSomeXml()
        {
            bool value = false;

            xml.TryGetBooleanFromXpath("//application/forms/water/meterLocked", out value);

            Assert.AreEqual(false, value);
        }

        [TestMethod]
        public void GetStringFromSomeXml()
        {
            string value = string.Empty;

            xml.TryGetStringFromXpath("//application/forms/delivery/surName", out value);

            Assert.AreEqual("Pegasus Software Solutions", value);
        }

        [TestMethod]
        public void GetDecimalFromSomeXml()
        {
            decimal value = 0;

            xml.TryGetDecimalFromXpath("//application/swappedFees[1]/item/ItemCostRaw", out value);

            decimal comp = 73.85M;
            Assert.AreEqual(comp, value);
        }

        [TestMethod]
        public void GetIntegerFromSomeXml()
        {
            int value = 0;

            xml.TryGetIntegerFromXpath("//application/swappedFees[3]/swappedItem/ItemCost", out value);

            int comp = 444;
            Assert.AreEqual(comp, value);
        }

        [TestMethod]
        public void GetListValueFromListValueName()
        {
            string result = "TaxInvoice".GetStructureConstantValue("FilePurposeList", "GeneralIceDocument");

            Assert.AreEqual(result, "5373DFCE-C071-4385-8334-32482F0FA029");
        }

        [TestMethod]
        public void SsoHelperTests()
        {
            string queue = "ICEDEVADMIN";
            string node = "ICE";
            string queueTagShouldEqual = node + "|" + queue + "|T";

            // build au unreleased queue tag
            string tag = SsoHelper.MakeQueueTag(node, queue, false);
            Assert.AreEqual(queueTagShouldEqual, tag);
            
            // check that the components of the queue tag can be split out correctly
            Assert.AreEqual(queue, SsoHelper.GetQueueNameFromQueueTag(tag));
            Assert.AreEqual(node, SsoHelper.GetNodeNameFromQueueTag(tag));

            // test MapProcedureName

            // 1. old format parent procedure should return old format mapped name ie. first item in the procedure list
            string procedureList = "P0000001,A0000001";
            string parentProcedure = "S1234567";
            string expectedOutcome = "P0000001";
            Assert.AreEqual(expectedOutcome, SsoHelper.MapProcedureName(procedureList, parentProcedure));

            // 2. new format parent procedure should return new format mapped name
            parentProcedure = "X1234567";
            expectedOutcome = "A0000001";
            Assert.AreEqual(expectedOutcome, SsoHelper.MapProcedureName(procedureList, parentProcedure));

            // 3. try again with subprocedure names (old and new style)
            procedureList = "SP070101,B0070101";
            parentProcedure = "A0000001";
            expectedOutcome = "B0070101";
            Assert.AreEqual(expectedOutcome, SsoHelper.MapProcedureName(procedureList, parentProcedure));

            // try outlier cases
            // 4. single procedure in the procedure list
            procedureList = "P0000001";
            parentProcedure = "S1234567";
            expectedOutcome = "P0000001";
            Assert.AreEqual(expectedOutcome, SsoHelper.MapProcedureName(procedureList, parentProcedure));

            // 5. single procedure in list, with no parent procedure
            procedureList = "P0000001";
            parentProcedure = null;
            expectedOutcome = "P0000001";
            Assert.AreEqual(expectedOutcome, SsoHelper.MapProcedureName(procedureList, parentProcedure));

            // 6. multiple procedures in list, no parent procedure
            procedureList = "P0000001,A0000001";
            parentProcedure = null;
            expectedOutcome = "P0000001";
            Assert.AreEqual(expectedOutcome, SsoHelper.MapProcedureName(procedureList, parentProcedure));

        }


        public class Token
        {
            public string CustomerNumber { get; set; }
            public string Password { get; set; }
            public string EmailAddress { get; set; }
        }

        [TestMethod]
        public void DecrptyToken()
        {
            string b64token = "xTTZIYPTMQ3mDtIg8BN0cwASN7fLtML7lURBpVx+S62x/sqe7N9QLqbau7a04u1LyAZiE34Jj71J0wA9L9PJJtAGQJwQSbNu5ZmgNbn/HjuVAc/G+ATijSLM0mUYUVer";

            string xml = Logica.Au.Mpire.Framework.Utilities.Symmetric.Decrypt(b64token);

            XmlDocument parser = new XmlDocument();
            parser.LoadXml(xml);

            Token token = new Token();

            token.CustomerNumber = parser.SelectSingleNode("/root/n1").InnerText;
            token.Password = parser.SelectSingleNode("/root/n2").InnerText;
            token.EmailAddress = parser.SelectSingleNode("/root/n3").InnerText;

            string password = "CsIzIT0QRNP6s1A4N3m4iw==";
            string clear = Logica.Au.Mpire.Framework.Utilities.Symmetric.Decrypt(password);

            Assert.AreEqual(token.Password, clear);


        }
	}

}
