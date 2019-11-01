using Newtonsoft.Json;
using System;

namespace InfoWebAPI.Application.InfoService.Models
{
    public class CoreDetail
    {
        public string Title { get; set; }

        [JsonProperty("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Surname")]
        public string LastName { get; set; }

        [JsonProperty("Date Modified")]
        public DateTime DateModified { get; set; }

        [JsonProperty("Company Name")]
        public string CompanyName { get; set; }

        public string Street { get; set; }

        [JsonProperty("Other Address")]
        public string OtherAddress { get; set; }

        public string Suburb { get; set; }

        public string State { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        [JsonProperty("Telephone")]
        public string TelephoneNumber { get; set; }

        [JsonProperty("Telephone Area")]
        public string TelephoneAreaCode { get; set; }

        [JsonProperty("Telephone Country")]
        public string TelephoneCountryCode { get; set; }

        public string Facsimile { get; set; }

        [JsonProperty("Facsimile Area")]
        public string FacsimileAreaCode { get; set; }

        [JsonProperty("Facsimile Country")]
        public string FacsimileCountryCode { get; set; }

        public string Position { get; set; }

        public string Function { get; set; }

        [JsonProperty("Mobile Number")]
        public string Mobile { get; set; }

        [JsonProperty("Mobile Area")]
        public string MobileAreaCode { get; set; }

        public string Email { get; set; }

        [JsonProperty("Code Source")]
        public string CodeSource { get; set; }

        [JsonProperty("Card_Num")]
        public string CardNumber { get; set; }

        [JsonProperty("Server_ID")]
        public int ServerID { get; set; }

        [JsonProperty("Card_Show_Num")]
        public int CardShowNumber { get; set; }

        [JsonProperty("Num_Cards_Issued")]
        public int CardsIssuedCount { get; set; }

        [JsonProperty("Contact ID")]
        public int ContactKey { get; set; }

        [JsonProperty("Visitor Type")]
        public char VisitorType { get; set; }

        public string FullCardNumber { get; set; }

        [JsonProperty("NFC")]
        public string NFCID { get; set; }

        [JsonProperty("User Defined 1")]
        public string UserDefined1 { get; set; }

        [JsonProperty("User Defined 2")]
        public string UserDefined2 { get; set; }

        [JsonProperty("User Defined 3")]
        public string UserDefined3 { get; set; }

        [JsonProperty("User Defined 4")]
        public string UserDefined4 { get; set; }

        [JsonProperty("User Defined 5")]
        public string UserDefined5 { get; set; }

        [JsonProperty("User Defined 6")]
        public string UserDefined6 { get; set; }

        [JsonProperty("User Defined 7")]
        public string UserDefined7 { get; set; }

        [JsonProperty("User Defined 8")]
        public string UserDefined8 { get; set; }

        [JsonProperty("User Defined 9")]
        public DateTime UserDefined9 { get; set; }

        [JsonProperty("User Defined 10")]
        public string UserDefined10 { get; set; }

        [JsonProperty("User Defined 11")]
        public string UserDefined11 { get; set; }

        [JsonProperty("User Defined 12")]
        public string UserDefined12 { get; set; }

        [JsonProperty("User Defined 13")]
        public string UserDefined13 { get; set; }

        [JsonProperty("User Defined 14")]
        public string UserDefined14 { get; set; }

        [JsonProperty("User Defined 15")]
        public string UserDefined15 { get; set; }

        [JsonProperty("User Defined 16")]
        public string UserDefined16 { get; set; }

        [JsonProperty("User Defined 17")]
        public string UserDefined17 { get; set; }

        [JsonProperty("User Defined 18")]
        public string UserDefined18 { get; set; }

        [JsonProperty("User Defined 19")]
        public string UserDefined19 { get; set; }

        [JsonProperty("User Defined 20")]
        public string UserDefined20 { get; set; }

        [JsonProperty("Date Created")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("Login Token")]
        public string LoginToken { get; set; }

        [JsonProperty("Computer Modified")]
        public string ComputerModified { get; set; }

        [JsonProperty("Computer Name")]
        public string ComputerName { get; set; }

        [JsonProperty("Batch Number")]
        public int BatchNumber { get; set; }

        [JsonProperty("Market SMS")]
        public bool IsMarketSMS { get; set; }

        [JsonProperty("Market Email")]
        public bool IsMarketEmail { get; set; }

        public string Department { get; set; }

        [JsonProperty("Time Created")]
        public string TimeCreated { get; set; }

        [JsonProperty("Sub Type")]
        public char SubType { get; set; }

        [JsonProperty("Registration Year")]
        public int RegistrationYear { get; set; }

        [JsonProperty("Street 3")]
        public string Street3 { get; set; }

        [JsonProperty("Full Name (Translated)")]
        public string FullNameTranslated { get; set; }

        [JsonProperty("Position (Translated)")]
        public string PostionTranslated { get; set; }

        [JsonProperty("Company Name (Translated)")]
        public string CompanyNameTranslated { get; set; }

        [JsonProperty("Street 1 (Translated)")]
        public string Street1Translated { get; set; }

        [JsonProperty("Street 2 (Translated)")]
        public string Street2Translated { get; set; }

        [JsonProperty("Street 3 (Translated)")]
        public string Street3Translated { get; set; }

        [JsonProperty("Suburb (Translated)")]
        public string SuburbTranslated { get; set; }

        [JsonProperty("Show_Key")]
        public int ShowKey { get; set; }

        public byte[] PhotoImage { get; set; }

        [JsonProperty("Telephone Country Code (Second)")]
        public string SecondTelephoneCountryCode { get; set; }

        [JsonProperty("Telephone Area (Second)")]
        public string SecondTelephoneAreaCode { get; set; }

        [JsonProperty("Telephone (Second)")]
        public string SecondTelephoneNumber { get; set; }

        [JsonProperty("Facsimile Country Code (Second)")]
        public string SecondFacsimileCountryCode { get; set; }

        [JsonProperty("Facsimile Area (Second)")]
        public string SecondFacsimileAreaCode { get; set; }

        [JsonProperty("Facsimile (Second)")]
        public string SecondFacsimileNumber { get; set; }

        public string ParentCardNumber { get; set; }

        [JsonProperty("Email (Second)")]
        public string SecondEmail { get; set; }

        public bool HasChildRecords { get; set; }

        [JsonProperty("Mobile Area (Second)")]
        public string SecondMobileAreaCode { get; set; }

        [JsonProperty("Mobile Number (Second)")]
        public string SecondMobileNumber { get; set; }

        [JsonProperty("Telephone Extension")]
        public string TelephoneExtension { get; set; }

        [JsonProperty("Telephone Extension (Second)")]
        public string SecondTelephoneExtension { get; set; }
    }
}