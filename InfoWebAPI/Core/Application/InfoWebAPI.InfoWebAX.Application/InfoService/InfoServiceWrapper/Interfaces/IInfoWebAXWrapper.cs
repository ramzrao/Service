using InfoWebAPI.Application.InfoService.Models;
using InfoWebAX;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService
{
    public interface IInfoWebAXWrapper
    {
        Task<AddActivityResponse> AddActivity(int accountId, int contactKey, int gateKey, int activityType, string computerName, int gatePassage);

        Task<AddGatePassageResponse> AddGatePassage(int accountId, int contactKey, string gateNumber);

        Task<AddGatePassage2Response> AddGatePassage2(int accountId, int contactKey, string cardNumber, string gateNumber, string computerName);

        Task<AddNewBarcodeResponse> AddNewBarCode(int accountId, int contactKey, string barcodeNumber);

        Task<AddPhotoGatePassageResponse> AddPhotoGatePassage(int accountId, int contactKey, string cardNumber, string gateNumber, string computerName);

        Task<AddPrintFieldResponse> AddPrintField(int accountId, int templateId, int fieldId, int fieldType, string fieldName, int top, int left, int width, int charHeight, int charWidth, string justification, string fontFamily, int fontSize, int style, string textString, int maxLength, int fieldCasing, bool isBarcode, int maxLines, int rotation);

        Task<AddTextAnswerResponse> AddTextAnswer(int accountId, int contactKey, string code, string textAnswer);

        Task<checkGateResponse> CheckGate(int accountId, string gateNumber);

        Task<DeletePrintFieldsResponse> DeletePrintFields(int accountId, int templateId);

        Task<bool> DeletePrintTemplate(int accountId, int templateId);

        Task<FetchAllActivitiesResponse> FetchAllActivities(int accountId, int contactKey);

        Task<FetchFieldSetupResponse> FetchFieldSetup();

        Task<FetchQuestionsResponse> FetchQuestions(int accountId);

        Task<FlagVisitorAsDeletedResponse> FlagVisitorAsDeleted(int accountId, int contactKey);

        Task<List<PrintTemplate>> GetAllPrintTemplates(int accountId);

        Task<GetAllSessionsResponse> GetAllSessions(int accountId);

        Task<GetAllSessionsforSSResponse> GetAllSessionsForSS(int accountId);

        Task<List<Barcode>> GetBarcodes(int accountId, int contactKey);

        Task<GetBarcodesWithoutFullCardNumberResponse> GetBarcodesWithoutFullCardNumber(int accountId, int contactKey);

        Task<int> GetBatchCount(int accountId, int batchNumber);

        Task<getCardListResponse> GetCardList(int accountId);

        Task<CoreDetail> GetCoreDetails1(int accountId, bool activeOnly, int rowLimit, string queryParams);

        Task<CoreDetail> GetCoreDetails2(int accountId, string cardNumber);

        Task<CoreDetail> GetCoreDetailsByOtherBarcode(int accountId, string cardNumber);

        Task<GetCountriesResponse> GetCountries();

        Task<GetCountries21> GetCountries1(string listName);

        Task<GetDatabasesResponse> GetDatabases(int accountId);

        Task<GetLocalitiesByPostCodeResponse> GetLocalitiesByPostCode(int accountId, string country, string postCode);

        Task<GetLocalitiesBySuburbResponse> GetLocalitiesBySuburb(int accountId, string country, string suburb);

        Task<int> GetNextBatchNumber(int accountId);

        Task<GetPreregCodeResponse> GetPreregCode(int accountId);

        Task<GetPrintTemplateResponse> GetPrintTemplate(int accountId, int templateId);

        Task<getScreenListDetailsByIdResponse> GetScreenListDetailsById(int accountId, int screenListId);

        Task<List<ScreenMessage>> GetScreenMessages(int accountId);

        Task<GetSessionByKeyResponse> GetSessionByKey(int accountId, int sessionKey);

        Task<GetSessionBySessionCodeResponse> GetSessionBySessionCode(int accountId, string sessionCode);

        Task<ShowSettings> GetShowSettings(int accountId);

        Task<GetStatesResponse> GetStates(string listName);

        Task<GetStatus21> GetStatus1(int accountId, string area, ArrayOfXElement visitorData, ArrayOfXElement screenMessages);

        Task<List<Status>> GetStatus2(int accountId, string area, int contactKey, ArrayOfXElement screenMessages);

        Task<GetTextAnswersResponse> GetTextAnswers(int accountId, string cardNumber);

        Task<InsertSessionResponse> InsertSession(int accountId, string sessionCode, string sessionName, string sessionDate, string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room);

        Task<RemovePhotoResponse> RemovePhoto(int accountId, int contactKey, string computerName);

        Task<SavePhotoResponse> SavePhoto(int accountId, int contactKey, byte[] binaryData);

        Task<SearchAddressResponse> SearchAddress(int accountId, string country, string postCode);

        Task<UndoLastPhotoGateScanResponse> UndoLastPhotoGateScan(int accountId, int contactKey, string gateName);

        Task<UnflagVisitorAsDeletedResponse> UnflagVisitorAsDeleted(int accountId, int contactKey);

        Task<UpdatePrintTemplateResponse> UpdatePrintTemplate(int accountId, string name, string description, bool isDefault, int labelLength, string printerType, string badgeStock, decimal marginLeft, decimal marginRight, decimal marginTop, decimal marginBottom, decimal badgeWidth, decimal badgeHeight, string measurementUnit, string pageOrientation, string defaultPrinterName, string fontName, int templateId);

        Task<int> UpdateRecord(int accountId, string parameters);

        Task<UpdateResponsesResponse> UpdateResponses(int accountId, int contactKey, string responseCodes);

        Task<UpdateSessionResponse> UpdateSession(int accountId, string sessionCode, string sessionName, string sessionDate, string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room, int sessionKey);
    }
}