using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using InfoWebAX;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public interface IInfoWebAXWrapper
    {
        Task AddActivity(int accountId, int contactKey, int gateKey, int activityType, string computerName, int gatePassage);

        Task AddGatePassage(int accountId, int contactKey, string gateNumber);

        Task AddGatePassage2(int accountId, int contactKey, string cardNumber, string gateNumber, string computerName);

        Task AddNewBarCode(int accountId, int contactKey, string barcodeNumber);

        Task AddPhotoGatePassage(int accountId, int contactKey, string cardNumber, string gateNumber, string computerName);

        Task<bool> AddPrintField(int accountId, int templateId, int fieldId, int fieldType, string fieldName, int top, int left, int width, int charHeight, int charWidth, string justification, string fontFamily, int fontSize, int style, string textString, int maxLength, int fieldCasing, bool isBarcode, int maxLines, int rotation);

        Task<bool> AddTextAnswer(int accountId, int contactKey, string code, string textAnswer);

        Task<Gate> CheckGate(int accountId, string gateNumber);

        Task<bool> DeletePrintFields(int accountId, int templateId);

        Task<bool> DeletePrintTemplate(int accountId, int templateId);

        Task<List<Activity>> FetchAllActivities(int accountId, int contactKey);

        Task<List<Field>> FetchFieldSetup();

        Task<List<Question>> FetchQuestions(int accountId);

        Task<bool> FlagVisitorAsDeleted(int accountId, int contactKey);

        Task<List<PrintTemplate>> GetAllPrintTemplates(int accountId);

        Task<List<Session>> GetAllSessions(int accountId);

        Task<List<Session>> GetAllSessionsForSS(int accountId);

        Task<List<Barcode>> GetBarcodes(int accountId, int contactKey);

        Task<List<Barcode>> GetBarcodesWithoutFullCardNumber(int accountId, int contactKey);

        Task<int> GetBatchCount(int accountId, int batchNumber);

        Task<getCardListResponse> GetCardList(int accountId);

        Task<CoreDetail> GetCoreDetails1(int accountId, bool activeOnly, int rowLimit, string queryParams);

        Task<CoreDetail> GetCoreDetails2(int accountId, string cardNumber);

        Task<CoreDetail> GetCoreDetailsByOtherBarcode(int accountId, string cardNumber);

        Task<List<Country>> GetCountries();

        Task<List<Country>> GetCountries1(string listName);

        //Task<GetDatabasesResponse> GetDatabases(int accountId);

        Task<List<Locality>> GetLocalitiesByPostCode(int accountId, string country, string postCode);

        Task<List<Locality>> GetLocalitiesBySuburb(int accountId, string country, string suburb);

        Task<int> GetNextBatchNumber(int accountId);

        Task<List<PreregCode>> GetPreregCode(int accountId);

        Task<List<PrintTemplateData>> GetPrintTemplate(int accountId, int templateId);

        Task<List<ScreenListDetail>> GetScreenListDetailsById(int accountId, int screenListId);

        Task<List<ScreenMessage>> GetScreenMessages(int accountId);

        Task<Session> GetSessionByKey(int accountId, int sessionKey);

        Task<Session> GetSessionBySessionCode(int accountId, string sessionCode);

        Task<ShowSettings> GetShowSettings(int accountId);

        Task<List<State>> GetStates(string listName);

        Task<List<Status>> GetStatus1(int accountId, string area, ArrayOfXElement visitorData, ArrayOfXElement screenMessages);

        Task<List<Status>> GetStatus2(int accountId, string area, int contactKey, ArrayOfXElement screenMessages);

        Task<List<TextAnswer>> GetTextAnswers(int accountId, string cardNumber);

        Task<int> InsertSession(int accountId, string sessionCode, string sessionName, string sessionDate, string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room);

        Task RemovePhoto(int accountId, int contactKey, string computerName);

        Task<bool> SavePhoto(int accountId, int contactKey, byte[] binaryData);

        Task<List<QASAddress>> SearchAddress(string searchText, string moniker, string displayTextArray);

        Task<int> UndoLastPhotoGateScan(int accountId, int contactKey, string gateName);

        Task<bool> UnflagVisitorAsDeleted(int accountId, int contactKey);

        Task<int> UpdatePrintTemplate(int accountId, string name, string description, bool isDefault, int labelLength, string printerType, string badgeStock, decimal marginLeft, decimal marginRight, decimal marginTop, decimal marginBottom, decimal badgeWidth, decimal badgeHeight, string measurementUnit, string pageOrientation, string defaultPrinterName, string fontName, int templateId);

        Task<int> UpdateRecord(int accountId, string parameters);

        Task<bool> UpdateResponses(int accountId, int contactKey, string responseCodes);

        Task<int> UpdateSession(int accountId, string sessionCode, string sessionName, string sessionDate, string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room, int sessionKey);
        Task<List<PrintTemplateData>> GenerateImageData1(int accountId, string computerName);
        Task<List<PrintTemplateData>> GenerateImageData2(int accountId, int printTemplateId, string computerName);
        Task<List<PrintTemplateData>> GenerateImageData3(int accountId, int contactKey, string computerName);
        Task<List<PrintTemplateData>> GenerateImageDataWrap(int accountId, string cardNumber, int templateId, string computerName);
    }
}