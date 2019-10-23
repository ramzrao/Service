using InfoWebAPI.Application.Common.Helpers;
using InfoWebAPI.Application.GetAccount;
using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Infrastructure;
using InfoWebAX;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService
{
    public class InfoWebAXWrapper : DeserializeXml, IInfoWebAXWrapper
    {
        private readonly IInfoWebAXClientReference _infowebAXClientReference;
        private readonly IMediator _mediator;

        public InfoWebAXWrapper(IInfoWebAXClientReference infoWebAXClientReference, IMediator mediator)
        {
            _infowebAXClientReference = infoWebAXClientReference;
            _mediator = mediator;
        }

        public async Task<AddActivityResponse> AddActivity(int accountId, int contactKey, int gateKey, int activityType, string computerName, int gatePassage)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.AddActivity(connString, contactKey, gateKey, activityType, computerName, gatePassage);
        }

        public async Task<AddGatePassageResponse> AddGatePassage(int accountId, int contactKey, string gateNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.AddGatePassage(connString, contactKey, gateNumber);
        }

        public async Task<AddGatePassage2Response> AddGatePassage2(int accountId, int contactKey, string cardNumber, string gateNumber, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.AddGatePassage2(connString, contactKey, cardNumber, gateNumber, computerName);
        }

        public async Task<AddNewBarcodeResponse> AddNewBarCode(int accountId, int contactKey, string barcodeNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.AddNewBarCode(connString, contactKey, barcodeNumber);
        }

        public async Task<AddPhotoGatePassageResponse> AddPhotoGatePassage(int accountId, int contactKey, string cardNumber, string gateNumber, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.AddPhotoGatePassage(connString, contactKey, cardNumber, gateNumber, computerName);
        }

        public async Task<AddPrintFieldResponse> AddPrintField(int accountId, int templateId, int fieldId, int fieldType, string fieldName, int top, int left, int width,
            int charHeight, int charWidth, string justification, string fontFamily, int fontSize, int style, string textString, int maxLength, int fieldCasing, bool isBarcode,
            int maxLines, int rotation)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.AddPrintField(connString, templateId, fieldId, fieldType, fieldName, top, left, width, charHeight, charWidth, justification,
                fontFamily, fontSize, style, textString, maxLength, fieldCasing, isBarcode, maxLines, rotation);
        }

        public async Task<AddTextAnswerResponse> AddTextAnswer(int accountId, int contactKey, string code, string textAnswer)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.AddTextAnswer(connString, contactKey, code, textAnswer);
        }

        public async Task<checkGateResponse> CheckGate(int accountId, string gateNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.CheckGate(connString, gateNumber);
        }

        public async Task<DeletePrintFieldsResponse> DeletePrintFields(int accountId, int templateId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.DeletePrintFields(connString, templateId);
        }

        public async Task<bool> DeletePrintTemplate(int accountId, int templateId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.DeletePrintTemplate(connString, templateId);
            return await Task.FromResult(response.DeletePrintTemplateResult);
        }

        public async Task<FetchAllActivitiesResponse> FetchAllActivities(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.FetchAllActivities(connString, contactKey);
        }

        public async Task<FetchFieldSetupResponse> FetchFieldSetup()
        {
            return await _infowebAXClientReference.FetchFieldSetup();
        }

        public async Task<FetchQuestionsResponse> FetchQuestions(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.FetchQuestions(connString);
        }

        public async Task<FlagVisitorAsDeletedResponse> FlagVisitorAsDeleted(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.FlagVisitorAsDeleted(connString, contactKey);
        }

        public async Task<List<PrintTemplate>> GetAllPrintTemplates(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetAllPrintTemplates(connString);
            return GetDeserializedResponse<PrintTemplate>(response.GetAllPrintTemplatesResult);
        }

        public async Task<GetAllSessionsResponse> GetAllSessions(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetAllSessions(connString);
        }

        public async Task<GetAllSessionsforSSResponse> GetAllSessionsForSS(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetAllSessionsForSS(connString);
        }

        public async Task<List<Barcode>> GetBarcodes(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetBarcodes(connString, contactKey);
            return GetDeserializedResponse<Barcode>(response.GetBarcodesResult);
        }

        public async Task<GetBarcodesWithoutFullCardNumberResponse> GetBarcodesWithoutFullCardNumber(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetBarcodesWithoutFullCardNumber(connString, contactKey);
        }

        public async Task<int> GetBatchCount(int accountId, int batchNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetBatchCount(connString, batchNumber);
            return await Task.FromResult(response.GetBatchCountResult);
        }

        public async Task<getCardListResponse> GetCardList(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetCardList(connString);
        }

        public async Task<CoreDetail> GetCoreDetails1(int accountId, bool activeOnly, int rowLimit, string queryParams)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetCoreDetails1(connString, activeOnly, rowLimit, queryParams);
            return GetDeserializedResponse<CoreDetail>(response.GetCoreDetails2Result).FirstOrDefault();
        }

        public async Task<CoreDetail> GetCoreDetails2(int accountId, string cardNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetCoreDetails2(connString, cardNumber);
            return GetDeserializedResponse<CoreDetail>(response.GetCoreDetails1Result).FirstOrDefault();
        }

        public async Task<CoreDetail> GetCoreDetailsByOtherBarcode(int accountId, string cardNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetCoreDetailsByOtherBarcode(connString, cardNumber);
            return GetDeserializedResponse<CoreDetail>(response.GetCoreDetailsByOtherBarcodeResult).FirstOrDefault();
        }

        public async Task<GetCountriesResponse> GetCountries()
        {
            return await _infowebAXClientReference.GetCountries();
        }

        public async Task<GetCountries21> GetCountries1(string listName)
        {
            return await _infowebAXClientReference.GetCountries1(listName);
        }

        public async Task<GetDatabasesResponse> GetDatabases(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetDatabases(connString);
        }

        public async Task<GetLocalitiesByPostCodeResponse> GetLocalitiesByPostCode(int accountId, string country, string postCode)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetLocalitiesByPostCode(connString, country, postCode);
        }

        public async Task<GetLocalitiesBySuburbResponse> GetLocalitiesBySuburb(int accountId, string country, string suburb)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetLocalitiesBySuburb(connString, country, suburb);
        }

        public async Task<int> GetNextBatchNumber(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetNextBatchNumber(connString);
            return await Task.FromResult<int>(response.GetNextBatchNumberResult);
        }

        public async Task<GetPreregCodeResponse> GetPreregCode(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetPreregCode(connString);
        }

        public async Task<GetPrintTemplateResponse> GetPrintTemplate(int accountId, int templateId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetPrintTemplate(connString, templateId);
        }

        public async Task<getScreenListDetailsByIdResponse> GetScreenListDetailsById(int accountId, int screenListId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetScreenListDetailsById(connString, screenListId);
        }

        public async Task<List<ScreenMessage>> GetScreenMessages(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetScreenMessages(connString);
            return GetDeserializedResponse<ScreenMessage>(response.GetScreenMessagesResult);
        }

        public async Task<GetSessionByKeyResponse> GetSessionByKey(int accountId, int sessionKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetSessionByKey(connString, sessionKey);
        }

        public async Task<GetSessionBySessionCodeResponse> GetSessionBySessionCode(int accountId, string sessionCode)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetSessionBySessionCode(connString, sessionCode);
        }

        public async Task<ShowSettings> GetShowSettings(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetShowSettings(connString);
            return GetDeserializedResponse<ShowSettings>(response.GetShowSettingsResult).FirstOrDefault();
        }

        public async Task<GetStatesResponse> GetStates(string listName)
        {
            return await _infowebAXClientReference.GetStates(listName);
        }

        public async Task<GetStatus21> GetStatus1(int accountId, string area, ArrayOfXElement visitorData, ArrayOfXElement screenMessages)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetStatus1(connString, area, visitorData, screenMessages);
        }

        public async Task<List<Status>> GetStatus2(int accountId, string area, int contactKey, ArrayOfXElement screenMessages)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetStatus2(connString, area, contactKey, screenMessages);
            return GetDeserializedResponse<Status>(response.GetStatus1Result);
        }

        public async Task<GetTextAnswersResponse> GetTextAnswers(int accountId, string cardNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.GetTextAnswers(connString, cardNumber);
        }

        public async Task<InsertSessionResponse> InsertSession(int accountId, string sessionCode, string sessionName, string sessionDate,
            string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.InsertSession(connString, sessionCode, sessionName, sessionDate, startTime, endTime, score, allowDupYN, exitFor, attendingCode, attendedCode, room);
        }

        public async Task<RemovePhotoResponse> RemovePhoto(int accountId, int contactKey, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.RemovePhoto(connString, contactKey, computerName);
        }

        public async Task<SavePhotoResponse> SavePhoto(int accountId, int contactKey, byte[] binaryData)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.SavePhoto(connString, contactKey, binaryData);
        }

        public async Task<SearchAddressResponse> SearchAddress(int accountId, string country, string postCode)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.SearchAddress(connString, country, postCode);
        }

        public async Task<UndoLastPhotoGateScanResponse> UndoLastPhotoGateScan(int accountId, int contactKey, string gateName)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.UndoLastPhotoGateScan(connString, contactKey, gateName);
        }

        public async Task<UnflagVisitorAsDeletedResponse> UnflagVisitorAsDeleted(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.UnflagVisitorAsDeleted(connString, contactKey);
        }

        public async Task<UpdatePrintTemplateResponse> UpdatePrintTemplate(int accountId, string name, string description, bool isDefault,
                    int labelLength, string printerType, string badgeStock, decimal marginLeft, decimal marginRight, decimal marginTop, decimal marginBottom,
                    decimal badgeWidth, decimal badgeHeight, string measurementUnit, string pageOrientation, string defaultPrinterName, string fontName,
                    int templateId)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.UpdatePrintTemplate(connString, name, description, isDefault,
                    labelLength, printerType, badgeStock, marginLeft, marginRight, marginTop, marginBottom,
                    badgeWidth, badgeHeight, measurementUnit, pageOrientation, defaultPrinterName, fontName,
                    templateId);
        }

        public async Task<int> UpdateRecord(int accountId, string parameters)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.UpdateRecord(connString, parameters);
            return await Task.FromResult(response.UpdateRecordResult);
        }

        public async Task<UpdateResponsesResponse> UpdateResponses(int accountId, int contactKey, string responseCodes)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.UpdateResponses(connString, contactKey, responseCodes);
        }

        public async Task<UpdateSessionResponse> UpdateSession(int accountId, string sessionCode, string sessionName, string sessionDate, string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room, int sessionKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            return await _infowebAXClientReference.UpdateSession(connString, sessionCode, sessionName, sessionDate, startTime, endTime, score, allowDupYN, exitFor, attendingCode, attendedCode, room, sessionKey);
        }

        private async Task<string> GetAccountConnectionString(int accountId)
        {
            var accountResponse = await _mediator.Send<GetAccountResponse>(new GetAccountRequest() { AccountId = accountId });
            string connectionString = string.Empty;
            if (accountResponse != null)
            {
                var account = accountResponse.Account;
                connectionString = string.Format("user id={0}; password = {1}; initial catalog = {2}; server = {3}", account.AccountDBUserName, account.AccountDBPassword, account.AccountName, account.AccountServer);
            }
            return connectionString;
        }
    }
}