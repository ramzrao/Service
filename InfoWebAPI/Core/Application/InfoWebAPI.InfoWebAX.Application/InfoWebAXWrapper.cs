using InfoWebAPI.Application.Common.Helpers;
using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Core.Application.Account;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using InfoWebAPI.Infrastructure;
using InfoWebAX;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
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

        public async Task AddActivity(int accountId, int contactKey, int gateKey, int activityType, string computerName, int gatePassage)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _infowebAXClientReference.AddActivity(connString, contactKey, gateKey, activityType, computerName, gatePassage);
        }

        public async Task AddGatePassage(int accountId, int contactKey, string gateNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _infowebAXClientReference.AddGatePassage(connString, contactKey, gateNumber);
        }

        public async Task AddGatePassage2(int accountId, int contactKey, string cardNumber, string gateNumber, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _infowebAXClientReference.AddGatePassage2(connString, contactKey, cardNumber, gateNumber, computerName);
        }

        public async Task AddNewBarCode(int accountId, int contactKey, string barcodeNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _infowebAXClientReference.AddNewBarCode(connString, contactKey, barcodeNumber);
        }

        public async Task AddPhotoGatePassage(int accountId, int contactKey, string cardNumber, string gateNumber, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _infowebAXClientReference.AddPhotoGatePassage(connString, contactKey, cardNumber, gateNumber, computerName);
        }

        public async Task<bool> AddPrintField(int accountId, int templateId, int fieldId, int fieldType, string fieldName, int top, int left, int width,
            int charHeight, int charWidth, string justification, string fontFamily, int fontSize, int style, string textString, int maxLength, int fieldCasing, bool isBarcode,
            int maxLines, int rotation)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.AddPrintField(connString, templateId, fieldId, fieldType, fieldName, top, left, width, charHeight, charWidth, justification,
                fontFamily, fontSize, style, textString, maxLength, fieldCasing, isBarcode, maxLines, rotation);
            return await Task.FromResult(response.AddPrintFieldResult);
        }

        public async Task<bool> AddTextAnswer(int accountId, int contactKey, string code, string textAnswer)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.AddTextAnswer(connString, contactKey, code, textAnswer);
            return await Task.FromResult(response.AddTextAnswerResult);
        }

        public async Task<Gate> CheckGate(int accountId, string gateNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.CheckGate(connString, gateNumber);
            return GetDeserializedResponse<Gate>(response.checkGateResult.Nodes).FirstOrDefault();
        }

        public async Task<bool> DeletePrintFields(int accountId, int templateId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.DeletePrintFields(connString, templateId);
            return await Task.FromResult(response.DeletePrintFieldsResult);
        }

        public async Task<bool> DeletePrintTemplate(int accountId, int templateId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.DeletePrintTemplate(connString, templateId);
            return await Task.FromResult(response.DeletePrintTemplateResult);
        }

        public async Task<List<Activity>> FetchAllActivities(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.FetchAllActivities(connString, contactKey);
            return GetDeserializedResponse<Activity>(response.FetchAllActivitiesResult.Nodes);
        }

        public async Task<List<Field>> FetchFieldSetup()
        {
            var response = await _infowebAXClientReference.FetchFieldSetup();
            return GetDeserializedResponse<Field>(response.FetchFieldSetupResult.Nodes);
        }

        public async Task<List<Question>> FetchQuestions(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.FetchQuestions(connString);
            return GetDeserializedResponse<Question>(response.FetchQuestionsResult.Nodes);
        }

        public async Task<bool> FlagVisitorAsDeleted(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.FlagVisitorAsDeleted(connString, contactKey);
            return await Task.FromResult(response.FlagVisitorAsDeletedResult);
        }

        public async Task<List<PrintTemplate>> GetAllPrintTemplates(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetAllPrintTemplates(connString);
            return GetDeserializedResponse<PrintTemplate>(response.GetAllPrintTemplatesResult.Nodes);
        }

        public async Task<List<Session>> GetAllSessions(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetAllSessions(connString);
            return GetDeserializedResponse<Session>(response.GetAllSessionsResult.Nodes);
        }

        public async Task<List<Session>> GetAllSessionsForSS(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetAllSessionsForSS(connString);
            return GetDeserializedResponse<Session>(response.GetAllSessionsforSSResult.Nodes);
        }

        public async Task<List<Barcode>> GetBarcodes(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetBarcodes(connString, contactKey);
            return GetDeserializedResponse<Barcode>(response.GetBarcodesResult.Nodes);
        }

        public async Task<List<Barcode>> GetBarcodesWithoutFullCardNumber(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetBarcodesWithoutFullCardNumber(connString, contactKey);
            return GetDeserializedResponse<Barcode>(response.GetBarcodesWithoutFullCardNumberResult.Nodes);
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
            return GetDeserializedResponse<CoreDetail>(response.GetCoreDetails2Result.Nodes).FirstOrDefault();
        }

        public async Task<CoreDetail> GetCoreDetails2(int accountId, string cardNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetCoreDetails2(connString, cardNumber);
            return GetDeserializedResponse<CoreDetail>(response.GetCoreDetails1Result.Nodes).FirstOrDefault();
        }

        public async Task<CoreDetail> GetCoreDetailsByOtherBarcode(int accountId, string cardNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetCoreDetailsByOtherBarcode(connString, cardNumber);
            return GetDeserializedResponse<CoreDetail>(response.GetCoreDetailsByOtherBarcodeResult.Nodes).FirstOrDefault();
        }

        public async Task<List<Country>> GetCountries()
        {
            var response = await _infowebAXClientReference.GetCountries();
            return GetDeserializedResponse<Country>(response.GetCountriesResult.Nodes);
        }

        public async Task<List<Country>> GetCountries1(string listName)
        {
            var response = await _infowebAXClientReference.GetCountries1(listName);
            return GetDeserializedResponse<Country>(response.GetCountries2Result.Nodes);
        }

        //public async Task<GetDatabasesResponse> GetDatabases(int accountId)
        //{
        //    var connString = await GetAccountConnectionString(accountId);
        //    return await _infowebAXClientReference.GetDatabases(connString);
        //}

        public async Task<List<Locality>> GetLocalitiesByPostCode(int accountId, string country, string postCode)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetLocalitiesByPostCode(connString, country, postCode);
            return GetDeserializedResponse<Locality>(response.GetLocalitiesByPostCodeResult.Nodes);
        }

        public async Task<List<Locality>> GetLocalitiesBySuburb(int accountId, string country, string suburb)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetLocalitiesBySuburb(connString, country, suburb);
            return GetDeserializedResponse<Locality>(response.GetLocalitiesBySuburbResult.Nodes);
        }

        public async Task<int> GetNextBatchNumber(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetNextBatchNumber(connString);
            return await Task.FromResult<int>(response.GetNextBatchNumberResult);
        }

        public async Task<List<PreregCode>> GetPreregCode(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetPreregCode(connString);
            return GetDeserializedResponse<PreregCode>(response.GetPreregCodeResult.Nodes);
        }

        public async Task<List<PrintTemplateData>> GetPrintTemplate(int accountId, int templateId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetPrintTemplate(connString, templateId);
            return GetDeserializedResponse<PrintTemplateData>(response.GetPrintTemplateResult.Nodes);
        }

        public async Task<List<ScreenListDetail>> GetScreenListDetailsById(int accountId, int screenListId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetScreenListDetailsById(connString, screenListId);
            return GetDeserializedResponse<ScreenListDetail>(response.getScreenListDetailsByIdResult.Any[1]);
        }

        public async Task<List<ScreenMessage>> GetScreenMessages(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetScreenMessages(connString);
            return GetDeserializedResponse<ScreenMessage>(response.GetScreenMessagesResult.Nodes);
        }

        public async Task<Session> GetSessionByKey(int accountId, int sessionKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetSessionByKey(connString, sessionKey);
            return GetDeserializedResponse<Session>(response.GetSessionByKeyResult.Nodes).FirstOrDefault();
        }

        public async Task<Session> GetSessionBySessionCode(int accountId, string sessionCode)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetSessionBySessionCode(connString, sessionCode);
            return GetDeserializedResponse<Session>(response.GetSessionBySessionCodeResult.Nodes).FirstOrDefault();
        }

        public async Task<ShowSettings> GetShowSettings(int accountId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetShowSettings(connString);
            return GetDeserializedResponse<ShowSettings>(response.GetShowSettingsResult.Nodes).FirstOrDefault();
        }

        public async Task<List<State>> GetStates(string listName)
        {
            var response = await _infowebAXClientReference.GetStates(listName);
            return GetDeserializedResponse<State>(response.GetStatesResult.Nodes);
        }

        public async Task<List<Status>> GetStatus1(int accountId, string area, ArrayOfXElement visitorData, ArrayOfXElement screenMessages)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetStatus1(connString, area, visitorData, screenMessages);
            return GetDeserializedResponse<Status>(response.GetStatus2Result.Nodes);
        }

        public async Task<List<Status>> GetStatus2(int accountId, string area, int contactKey, ArrayOfXElement screenMessages)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetStatus2(connString, area, contactKey, screenMessages);
            return GetDeserializedResponse<Status>(response.GetStatus1Result.Nodes);
        }

        public async Task<List<TextAnswer>> GetTextAnswers(int accountId, string cardNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GetTextAnswers(connString, cardNumber);
            return GetDeserializedResponse<TextAnswer>(response.GetTextAnswersResult.Nodes);
        }

        public async Task<int> InsertSession(int accountId, string sessionCode, string sessionName, string sessionDate,
            string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.InsertSession(connString, sessionCode, sessionName, sessionDate, startTime, endTime, score, allowDupYN, exitFor, attendingCode, attendedCode, room);
            return await Task.FromResult(response.InsertSessionResult);
        }

        public async Task RemovePhoto(int accountId, int contactKey, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _infowebAXClientReference.RemovePhoto(connString, contactKey, computerName);
        }

        public async Task<bool> SavePhoto(int accountId, int contactKey, byte[] binaryData)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.SavePhoto(connString, contactKey, binaryData);
            return await Task.FromResult(response.SavePhotoResult);
        }

        public async Task<List<QASAddress>> SearchAddress(string searchText, string moniker, string displayTextArray)
        {
            var response = await _infowebAXClientReference.SearchAddress(searchText, moniker, displayTextArray);
            return GetDeserializedResponse<QASAddress>(response.SearchAddressResult.Nodes);
        }

        public async Task<List<PrintTemplateData>> GenerateImageData1(int accountId, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GenerateImageData1(connString, computerName);
            return GetDeserializedResponse<PrintTemplateData>(response.GenerateImageData7Result.Nodes);
        }
        public async Task<List<PrintTemplateData>> GenerateImageData2(int accountId, int printTemplateId, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GenerateImageData2(connString, printTemplateId, computerName);
            return GetDeserializedResponse<PrintTemplateData>(response.GenerateImageData8Result.Nodes);
        }
        public async Task<List<PrintTemplateData>> GenerateImageData3(int accountId, int contactKey, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GenerateImageData3(connString, contactKey, computerName);
            return GetDeserializedResponse<PrintTemplateData>(response.GenerateImageData5Result.Nodes);
        }

        public async Task<List<PrintTemplateData>> GenerateImageDataWrap(int accountId, string cardNumber, int templateId, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.GenerateImageDataWrap(connString, cardNumber, templateId, computerName);
            return GetDeserializedResponse<PrintTemplateData>(response.GenerateImageDataWrapResult.Nodes);
        }

        public async Task<int> UndoLastPhotoGateScan(int accountId, int contactKey, string gateName)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.UndoLastPhotoGateScan(connString, contactKey, gateName);
            return await Task.FromResult(response.UndoLastPhotoGateScanResult);
        }

        public async Task<bool> UnflagVisitorAsDeleted(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.UnflagVisitorAsDeleted(connString, contactKey);
            return await Task.FromResult(response.UnflagVisitorAsDeletedResult);
        }

        public async Task<int> UpdatePrintTemplate(int accountId, string name, string description, bool isDefault,
                    int labelLength, string printerType, string badgeStock, decimal marginLeft, decimal marginRight, decimal marginTop, decimal marginBottom,
                    decimal badgeWidth, decimal badgeHeight, string measurementUnit, string pageOrientation, string defaultPrinterName, string fontName,
                    int templateId)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.UpdatePrintTemplate(connString, name, description, isDefault,
                    labelLength, printerType, badgeStock, marginLeft, marginRight, marginTop, marginBottom,
                    badgeWidth, badgeHeight, measurementUnit, pageOrientation, defaultPrinterName, fontName,
                    templateId);
            return await Task.FromResult(response.UpdatePrintTemplateResult);
        }

        public async Task<int> UpdateRecord(int accountId, string parameters)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.UpdateRecord(connString, parameters);
            return await Task.FromResult(response.UpdateRecordResult);
        }

        public async Task<bool> UpdateResponses(int accountId, int contactKey, string responseCodes)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.UpdateResponses(connString, contactKey, responseCodes);
            return await Task.FromResult(response.UpdateResponsesResult);
        }

        public async Task<int> UpdateSession(int accountId, string sessionCode, string sessionName, string sessionDate, string startTime, string endTime, double score, bool allowDupYN, int exitFor, string attendingCode, string attendedCode, string room, int sessionKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _infowebAXClientReference.UpdateSession(connString, sessionCode, sessionName, sessionDate, startTime, endTime, score, allowDupYN, exitFor, attendingCode, attendedCode, room, sessionKey);
            return await Task.FromResult(response.UpdateSessionResult);
        }

        private async Task<string> GetAccountConnectionString(int accountId)
        {
            var accountResponse = await _mediator.Send<GetAccountResponse>(new GetAccountRequest() { AccountId = accountId });
            string connectionString = string.Empty;
            if (accountResponse != null && accountResponse.Account != null)
            {
                var account = accountResponse.Account;
                connectionString = string.Format("user id={0}; password = {1}; initial catalog = {2}; server = {3}", account.AccountDBUserName, account.AccountDBPassword, account.AccountName, account.AccountServer);
            }
            return connectionString;
        }
    }
}