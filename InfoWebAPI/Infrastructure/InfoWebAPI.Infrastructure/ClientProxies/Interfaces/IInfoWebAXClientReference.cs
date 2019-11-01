using InfoWebAX;
using System.Threading.Tasks;

namespace InfoWebAPI.Infrastructure
{
    public interface IInfoWebAXClientReference
    {
        Task<AddActivityResponse> AddActivity(string connectionString, int contactKey, int gateKey, int activityType, string computerName, int gatePassage);

        Task<AddGatePassageResponse> AddGatePassage(string connectionString, int contactKey, string gateNumber);

        Task<AddGatePassage2Response> AddGatePassage2(string connectionString, int contactKey, string cardNumber, string gateNumber, string computerName);

        Task<AddNewBarcodeResponse> AddNewBarCode(string connectionString, int contactKey, string barcodeNumber);

        Task<AddPhotoGatePassageResponse> AddPhotoGatePassage(string connectionString, int contactKey, string cardNumber, string gateNumber, string computerName);

        Task<AddPrintFieldResponse> AddPrintField(string connectionString, int templateId, int fieldId, int fieldType, string fieldName, int top, int left, int width, int charHeight, int charWidth, string justification, string fontFamily, int fontSize, int style, string textString, int maxLength, int fieldCasing, bool isBarcode, int maxLines, int rotation);

        Task<AddTextAnswerResponse> AddTextAnswer(string connectionString, int contactKey, string code, string textAnswer);

        Task<checkGateResponse> CheckGate(string connectionString, string gateNumber);

        Task<DeletePrintFieldsResponse> DeletePrintFields(string connectionString, int templateId);

        Task<DeletePrintTemplateResponse> DeletePrintTemplate(string connectionString, int templateId);

        Task<FetchAllActivitiesResponse> FetchAllActivities(string connectionString, int contactKey);

        Task<FetchFieldSetupResponse> FetchFieldSetup();

        Task<FetchQuestionsResponse> FetchQuestions(string connectionString);

        Task<FlagVisitorAsDeletedResponse> FlagVisitorAsDeleted(string connectionString, int contactKey);

        Task<GetAllPrintTemplatesResponse> GetAllPrintTemplates(string connectionString);

        Task<GetAllSessionsResponse> GetAllSessions(string connectionString);

        Task<GetAllSessionsforSSResponse> GetAllSessionsForSS(string connectionString);

        Task<GetBarcodesResponse> GetBarcodes(string connectionString, int contactKey);

        Task<GetBarcodesWithoutFullCardNumberResponse> GetBarcodesWithoutFullCardNumber(string connectionString, int contactKey);

        Task<GetBatchCountResponse> GetBatchCount(string connectionString, int batchNumber);

        Task<getCardListResponse> GetCardList(string connectionString);

        Task<GetCoreDetails21> GetCoreDetails1(string connectionString, bool activeOnly, int rowLimit, string queryParams);

        Task<GetCoreDetails11> GetCoreDetails2(string connectionString, string cardNumber);

        Task<GetCoreDetailsByOtherBarcodeResponse> GetCoreDetailsByOtherBarcode(string connectionString, string cardNumber);

        Task<GetCountriesResponse> GetCountries();

        Task<GetCountries21> GetCountries1(string listName);

        Task<GetDatabasesResponse> GetDatabases(string connectionString);

        Task<GetLocalitiesByPostCodeResponse> GetLocalitiesByPostCode(string connectionString, string country, string postCode);

        Task<GetLocalitiesBySuburbResponse> GetLocalitiesBySuburb(string connectionString, string country, string suburb);

        Task<GetNextBatchNumberResponse> GetNextBatchNumber(string connectionString);

        Task<GetPreregCodeResponse> GetPreregCode(string connectionString);

        Task<GetPrintTemplateResponse> GetPrintTemplate(string connectionString, int templateId);

        Task<getScreenListDetailsByIdResponse> GetScreenListDetailsById(string connectionString, int screenListId);

        Task<GetScreenMessagesResponse> GetScreenMessages(string connectionString);

        Task<GetSessionByKeyResponse> GetSessionByKey(string connectionString, int sessionKey);

        Task<GetSessionBySessionCodeResponse> GetSessionBySessionCode(string connectionString, string sessionCode);

        Task<GetShowSettingsResponse> GetShowSettings(string connectionString);

        Task<GetStatesResponse> GetStates(string listName);

        Task<GetStatus21> GetStatus1(string connectionString, string area, ArrayOfXElement visitorData, ArrayOfXElement screenMessages);

        Task<GetStatus11> GetStatus2(string connectionString, string area, int contactKey, ArrayOfXElement screenMessages);

        Task<GetTextAnswersResponse> GetTextAnswers(string connectionString, string cardNumber);

        Task<InsertSessionResponse> InsertSession(string connectionString, string sessionCode, string sessionName, string sessionDate, string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room);

        Task<RemovePhotoResponse> RemovePhoto(string connectionString, int contactKey, string computerName);

        Task<SavePhotoResponse> SavePhoto(string connectionString, int contactKey, byte[] binaryData);

        Task<SearchAddressResponse> SearchAddress(string searchText, string moniker, string displayTextArray);

        Task<UndoLastPhotoGateScanResponse> UndoLastPhotoGateScan(string connectionString, int contactKey, string gateName);

        Task<UnflagVisitorAsDeletedResponse> UnflagVisitorAsDeleted(string connectionString, int contactKey);

        Task<UpdatePrintTemplateResponse> UpdatePrintTemplate(string connectionString, string name, string description, bool isDefault, int labelLength, string printerType, string badgeStock, decimal marginLeft, decimal marginRight, decimal marginTop, decimal marginBottom, decimal badgeWidth, decimal badgeHeight, string measurementUnit, string pageOrientation, string defaultPrinterName, string fontName, int templateId);

        Task<UpdateRecordResponse> UpdateRecord(string connectionString, string parameters);

        Task<UpdateResponsesResponse> UpdateResponses(string connectionString, int contactKey, string responseCodes);

        Task<UpdateSessionResponse> UpdateSession(string connectionString, string sessionCode, string sessionName, string sessionDate, string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room, int sessionKey);
        Task<GenerateImageData71> GenerateImageData1(string connectionString, string computerName);
        Task<GenerateImageData81> GenerateImageData2(string connectionString, int printTemplateId, string computerName);
        Task<GenerateImageData51> GenerateImageData3(string connectionString, int contactKey, string computerName);
        Task<GenerateImageDataWrapResponse> GenerateImageDataWrap(string connectionString, string cardNumber, int templateId, string computerName);

    }
}