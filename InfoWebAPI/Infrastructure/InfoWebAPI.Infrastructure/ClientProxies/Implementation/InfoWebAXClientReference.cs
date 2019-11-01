using InfoWebAX;
using Microsoft.Extensions.Configuration;
using System.ServiceModel;
using System.Threading.Tasks;

namespace InfoWebAPI.Infrastructure
{
    public class InfoWebAXClientReference : IInfoWebAXClientReference
    {
        private readonly IConfiguration _configuration;
        private readonly InfoWebAXSoapClient _client;
        private AuthenticationHeader _authenticationHeader;

        public InfoWebAXClientReference(IConfiguration configuration)
        {
            _configuration = configuration;
            if (_configuration["InfoService:InfoWebAXEndPoint"].Contains("https"))
                _client = new InfoWebAXSoapClient(new BasicHttpsBinding(), new EndpointAddress(_configuration["InfoService:InfoWebAXEndPoint"]));
            else
                _client = new InfoWebAXSoapClient(new BasicHttpBinding(), new EndpointAddress(_configuration["InfoService:InfoWebAXEndPoint"]));
        }

        private AuthenticationHeader AuthHeader
        {
            get
            {
                if (_authenticationHeader == null)
                {
                    _authenticationHeader = new AuthenticationHeader()
                    {
                        Username = _configuration["InfoService:Credentials:UserName"],
                        Password = _configuration["InfoService:Credentials:Password"]
                    };
                }
                return _authenticationHeader;
            }
        }

        public async Task<AddActivityResponse> AddActivity(string connectionString, int contactKey, int gateKey, int activityType, string computerName, int gatePassage)
        {
            return await _client.AddActivityAsync(AuthHeader, connectionString, contactKey, gateKey, activityType, computerName, gatePassage);
        }

        public async Task<AddGatePassageResponse> AddGatePassage(string connectionString, int contactKey, string gateNumber)
        {
            return await _client.AddGatePassageAsync(AuthHeader, connectionString, contactKey, gateNumber);
        }

        public async Task<AddGatePassage2Response> AddGatePassage2(string connectionString, int contactKey, string cardNumber, string gateNumber, string computerName)
        {
            return await _client.AddGatePassage2Async(AuthHeader, connectionString, contactKey, cardNumber, gateNumber, computerName);
        }

        public async Task<AddNewBarcodeResponse> AddNewBarCode(string connectionString, int contactKey, string barcodeNumber)
        {
            return await _client.AddNewBarcodeAsync(AuthHeader, connectionString, contactKey, barcodeNumber);
        }

        public async Task<AddPhotoGatePassageResponse> AddPhotoGatePassage(string connectionString, int contactKey, string cardNumber, string gateNumber, string computerName)
        {
            return await _client.AddPhotoGatePassageAsync(AuthHeader, connectionString, contactKey, cardNumber, gateNumber, computerName);
        }

        public async Task<AddPrintFieldResponse> AddPrintField(string connectionString, int templateId, int fieldId, int fieldType, string fieldName, int top, int left, int width, int charHeight,
            int charWidth, string justification, string fontFamily, int fontSize, int style, string textString, int maxLength, int fieldCasing, bool isBarcode, int maxLines, int rotation)
        {
            return await _client.AddPrintFieldAsync(AuthHeader, connectionString, templateId, fieldId, fieldType, fieldName, top, left, width, charHeight, charWidth, justification, fontFamily
                , fontSize, style, textString, maxLength, fieldCasing, isBarcode, maxLines, rotation);
        }

        public async Task<AddTextAnswerResponse> AddTextAnswer(string connectionString, int contactKey, string code, string textAnswer)
        {
            return await _client.AddTextAnswerAsync(AuthHeader, connectionString, contactKey, code, textAnswer);
        }

        public async Task<DeletePrintFieldsResponse> DeletePrintFields(string connectionString, int templateId)
        {
            return await _client.DeletePrintFieldsAsync(AuthHeader, connectionString, templateId);
        }

        public async Task<DeletePrintTemplateResponse> DeletePrintTemplate(string connectionString, int templateId)
        {
            return await _client.DeletePrintTemplateAsync(AuthHeader, connectionString, templateId);
        }

        public async Task<FetchAllActivitiesResponse> FetchAllActivities(string connectionString, int contactKey)
        {
            return await _client.FetchAllActivitiesAsync(AuthHeader, connectionString, contactKey);
        }

        public async Task<FetchFieldSetupResponse> FetchFieldSetup()
        {
            return await _client.FetchFieldSetupAsync(AuthHeader);
        }

        public async Task<FetchQuestionsResponse> FetchQuestions(string connectionString)
        {
            return await _client.FetchQuestionsAsync(AuthHeader, connectionString);
        }

        public async Task<FlagVisitorAsDeletedResponse> FlagVisitorAsDeleted(string connectionString, int contactKey)
        {
            return await _client.FlagVisitorAsDeletedAsync(AuthHeader, connectionString, contactKey);
        }

        public async Task<GenerateImageData71> GenerateImageData1(string connectionString, string computerName)
        {
            return await _client.GenerateImageData1Async(AuthHeader, connectionString, null, null, computerName);
        }
        public async Task<GenerateImageData81> GenerateImageData2(string connectionString, int printTemplateId, string computerName)
        {
            return await _client.GenerateImageData2Async(AuthHeader, connectionString, null, printTemplateId, computerName);
        }

        public async Task<GenerateImageData51> GenerateImageData3(string connectionString, int contactKey, string computerName)
        {
            return await _client.GenerateImageDataAsync(AuthHeader, connectionString, contactKey, null,  computerName);
        }

        public async Task<GenerateImageDataWrapResponse> GenerateImageDataWrap(string connectionString, string cardNumber, int templateId, string computerName)
        {
            return await _client.GenerateImageDataWrapAsync(AuthHeader, connectionString, cardNumber, templateId, computerName);
        }
        public async Task<GetAllPrintTemplatesResponse> GetAllPrintTemplates(string connectionString)
        {
            return await _client.GetAllPrintTemplatesAsync(AuthHeader, connectionString);
        }

        public async Task<GetAllSessionsResponse> GetAllSessions(string connectionString)
        {
            return await _client.GetAllSessionsAsync(AuthHeader, connectionString);
        }

        public async Task<GetAllSessionsforSSResponse> GetAllSessionsForSS(string connectionString)
        {
            return await _client.GetAllSessionsforSSAsync(AuthHeader, connectionString);
        }

        public async Task<GetBarcodesResponse> GetBarcodes(string connectionString, int contactKey)
        {
            return await _client.GetBarcodesAsync(AuthHeader, connectionString, contactKey);
        }

        public async Task<GetBarcodesWithoutFullCardNumberResponse> GetBarcodesWithoutFullCardNumber(string connectionString, int contactKey)
        {
            return await _client.GetBarcodesWithoutFullCardNumberAsync(AuthHeader, connectionString, contactKey);
        }

        public async Task<GetBatchCountResponse> GetBatchCount(string connectionString, int batchNumber)
        {
            return await _client.GetBatchCountAsync(AuthHeader, connectionString, batchNumber);
        }

        public async Task<GetCoreDetails21> GetCoreDetails1(string connectionString, bool activeOnly, int rowLimit, string queryParams)
        {
            return await _client.GetCoreDetails1Async(AuthHeader, connectionString, activeOnly, rowLimit, queryParams);
        }

        public async Task<GetCoreDetails11> GetCoreDetails2(string connectionString, string cardNumber)
        {
            return await _client.GetCoreDetailsAsync(AuthHeader, connectionString, cardNumber);
        }

        public async Task<GetCoreDetailsByOtherBarcodeResponse> GetCoreDetailsByOtherBarcode(string connectionString, string cardNumber)
        {
            return await _client.GetCoreDetailsByOtherBarcodeAsync(AuthHeader, connectionString, cardNumber);
        }

        public async Task<GetCountriesResponse> GetCountries()
        {
            return await _client.GetCountriesAsync(AuthHeader);
        }

        public async Task<GetCountries21> GetCountries1(string listName)
        {
            return await _client.GetCountries1Async(AuthHeader, listName);
        }

        public async Task<GetDatabasesResponse> GetDatabases(string connectionString)
        {
            return await _client.GetDatabasesAsync(AuthHeader, connectionString);
        }

        public async Task<GetLocalitiesByPostCodeResponse> GetLocalitiesByPostCode(string connectionString, string country, string postCode)
        {
            return await _client.GetLocalitiesByPostCodeAsync(AuthHeader, connectionString, country, postCode);
        }

        public async Task<GetLocalitiesBySuburbResponse> GetLocalitiesBySuburb(string connectionString, string country, string suburb)
        {
            return await _client.GetLocalitiesBySuburbAsync(AuthHeader, connectionString, country, suburb);
        }

        public async Task<GetNextBatchNumberResponse> GetNextBatchNumber(string connectionString)
        {
            return await _client.GetNextBatchNumberAsync(AuthHeader, connectionString);
        }

        public async Task<GetPreregCodeResponse> GetPreregCode(string connectionString)
        {
            return await _client.GetPreregCodeAsync(AuthHeader, connectionString);
        }

        public async Task<GetPrintTemplateResponse> GetPrintTemplate(string connectionString, int templateId)
        {
            return await _client.GetPrintTemplateAsync(AuthHeader, connectionString, templateId);
        }

        public async Task<GetScreenMessagesResponse> GetScreenMessages(string connectionString)
        {
            return await _client.GetScreenMessagesAsync(AuthHeader, connectionString);
        }

        public async Task<GetSessionByKeyResponse> GetSessionByKey(string connectionString, int sessionKey)
        {
            return await _client.GetSessionByKeyAsync(AuthHeader, connectionString, sessionKey);
        }

        public async Task<GetSessionBySessionCodeResponse> GetSessionBySessionCode(string connectionString, string sessionCode)
        {
            return await _client.GetSessionBySessionCodeAsync(AuthHeader, connectionString, sessionCode);
        }

        public async Task<GetShowSettingsResponse> GetShowSettings(string connectionString)
        {
            return await _client.GetShowSettingsAsync(AuthHeader, connectionString);
        }

        public async Task<GetStatesResponse> GetStates(string listName)
        {
            return await _client.GetStatesAsync(AuthHeader, listName);
        }

        public async Task<GetStatus21> GetStatus1(string connectionString, string area, ArrayOfXElement visitorData, ArrayOfXElement screenMessages)
        {
            return await _client.GetStatus1Async(AuthHeader, connectionString, area, visitorData, screenMessages);
        }

        public async Task<GetStatus11> GetStatus2(string connectionString, string area, int contactKey, ArrayOfXElement screenMessages)
        {
            return await _client.GetStatusAsync(AuthHeader, connectionString, area, contactKey, screenMessages);
        }

        public async Task<GetTextAnswersResponse> GetTextAnswers(string connectionString, string cardNumber)
        {
            return await _client.GetTextAnswersAsync(AuthHeader, connectionString, cardNumber);
        }

        public async Task<InsertSessionResponse> InsertSession(string connectionString, string sessionCode, string sessionName, string sessionDate, string startTime,
            string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room)
        {
            return await _client.InsertSessionAsync(AuthHeader, connectionString, sessionCode, sessionName, sessionDate, startTime, endTime, score, allowDupYN, exitFor, attendingCode,
                attendedCode, room);
        }

        public async Task<RemovePhotoResponse> RemovePhoto(string connectionString, int contactKey, string computerName)
        {
            return await _client.RemovePhotoAsync(AuthHeader, connectionString, contactKey, computerName);
        }

        public async Task<SavePhotoResponse> SavePhoto(string connectionString, int contactKey, byte[] binaryData)
        {
            return await _client.SavePhotoAsync(AuthHeader, connectionString, contactKey, binaryData);
        }

        public async Task<SearchAddressResponse> SearchAddress(string searchText, string moniker, string displayTextArray)
        {
            return await _client.SearchAddressAsync(AuthHeader, searchText, moniker, displayTextArray);
        }

        public async Task<UndoLastPhotoGateScanResponse> UndoLastPhotoGateScan(string connectionString, int contactKey, string gateName)
        {
            return await _client.UndoLastPhotoGateScanAsync(AuthHeader, connectionString, contactKey, gateName);
        }

        public async Task<UnflagVisitorAsDeletedResponse> UnflagVisitorAsDeleted(string connectionString, int contactKey)
        {
            return await _client.UnflagVisitorAsDeletedAsync(AuthHeader, connectionString, contactKey);
        }

        public async Task<UpdatePrintTemplateResponse> UpdatePrintTemplate(string connectionString, string name, string description, bool isDefault,
                    int labelLength, string printerType, string badgeStock, decimal marginLeft, decimal marginRight, decimal marginTop, decimal marginBottom,
                    decimal badgeWidth, decimal badgeHeight, string measurementUnit, string pageOrientation, string defaultPrinterName, string fontName,
                    int templateId)
        {
            return await _client.UpdatePrintTemplateAsync(AuthHeader, connectionString, name, description, isDefault,
                    labelLength, printerType, badgeStock, marginLeft, marginRight, marginTop, marginBottom,
                    badgeWidth, badgeHeight, measurementUnit, pageOrientation, defaultPrinterName, fontName,
                    templateId);
        }

        public async Task<UpdateRecordResponse> UpdateRecord(string connectionString, string parameters)
        {
            return await _client.UpdateRecordAsync(AuthHeader, connectionString, parameters);
        }

        public async Task<UpdateResponsesResponse> UpdateResponses(string connectionString, int contactKey, string responseCodes)
        {
            return await _client.UpdateResponsesAsync(AuthHeader, connectionString, contactKey, responseCodes);
        }

        public async Task<UpdateSessionResponse> UpdateSession(string connectionString, string sessionCode, string sessionName, string sessionDate, string startTime,
            string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room, int sessionKey)
        {
            return await _client.UpdateSessionAsync(AuthHeader, connectionString, sessionCode, sessionName, sessionDate, startTime, endTime, score, allowDupYN, exitFor, attendingCode,
                attendedCode, room, sessionKey);
        }

        public async Task<checkGateResponse> CheckGate(string connectionString, string gateNumber)
        {
            return await _client.checkGateAsync(AuthHeader, connectionString, gateNumber);
        }

        public async Task<getCardListResponse> GetCardList(string connectionString)
        {
            return await _client.getCardListAsync(AuthHeader, connectionString);
        }

        public async Task<getScreenListDetailsByIdResponse> GetScreenListDetailsById(string connectionString, int screenListId)
        {
            return await _client.getScreenListDetailsByIdAsync(AuthHeader, connectionString, screenListId);
        }
    }
}