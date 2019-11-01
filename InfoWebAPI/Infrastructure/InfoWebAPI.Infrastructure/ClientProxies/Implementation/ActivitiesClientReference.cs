using Activities;
using InfoWebAPI.Infrastructure.ClientProxies.Interfaces;
using Microsoft.Extensions.Configuration;
using System.ServiceModel;
using System.Threading.Tasks;

namespace InfoWebAPI.Infrastructure.ClientProxies.Implementation
{
    public class ActivitiesClientReference : IActivitiesClientReference
    {
        private readonly IConfiguration _configuration;
        private readonly ActivitiesSoapClient _client;
        private AuthenticationHeader _authenticationHeader;

        public ActivitiesClientReference(IConfiguration configuration)
        {
            _configuration = configuration;
            if (_configuration["InfoService:ActivitiesEndPoint"].Contains("https"))
                _client = new ActivitiesSoapClient(new BasicHttpsBinding(), new EndpointAddress(_configuration["InfoService:ActivitiesEndPoint"]));
            else
                _client = new ActivitiesSoapClient(new BasicHttpBinding(), new EndpointAddress(_configuration["InfoService:ActivitiesEndPoint"]));
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

        public async Task<FetchByActivityTypeResponse> FetchByActivityTypeAsync(string connectionString, int activityType)
        {
            return await _client.FetchByActivityTypeAsync(AuthHeader, connectionString, activityType);
        }

        public async Task<Activities.FetchAllResponse> FetchAllAsync(string connectionString, int contactKey)
        {
            return await _client.FetchAllAsync(AuthHeader, connectionString, contactKey);
        }

        public async Task<HideRecordResponse> HideRecordAsync(string connectionString, int contactKey)
        {
            return await _client.HideRecordAsync(AuthHeader, connectionString, contactKey);
        }

        public async Task<RestoreRecordResponse> RestoreRecordAsync(string connectionString, int contactKey)
        {
            return await _client.RestoreRecordAsync(AuthHeader, connectionString, contactKey);
        }

        public async Task<PermanentDeleteRecordResponse> PermanentDeleteRecordAsync(string connectionString, int contactkey)
        {
            return await _client.PermanentDeleteRecordAsync(AuthHeader, connectionString, contactkey);
        }

        public async Task<AddActivity_Default1> AddActivityAsync(string connectionString, int showKey, int contactKey, int activityType)
        {
            return await _client.AddActivityAsync(AuthHeader, connectionString, showKey, contactKey, activityType);
        }

        public async Task<AddActivity_Gates1> AddActivity1Async(string connectionString, int contactKey, int gateKey)
        {
            return await _client.AddActivity1Async(AuthHeader, connectionString, contactKey, gateKey);
        }

        public async Task<AddActivity_PhotoGates1> AddActivity2Async(string connectionString, int contactKey, int gateKey, bool isPhotoGate, string ComputerName, int gatePassage)
        {
            return await _client.AddActivity2Async(AuthHeader, connectionString, contactKey, gateKey, isPhotoGate, ComputerName, gatePassage);
        }

        public async Task<AddPhotoActivity_GenericAddActivity1> AddActivity3Async(string connectionString, int contactKey, int ActivityType, int showKey, int gateKey, string computerName)
        {
            return await _client.AddActivity3Async(AuthHeader, connectionString, contactKey, ActivityType, showKey, gateKey, computerName);
        }

        public async Task<AddActivity_DBMS1> AddActivity4Async(string connectionString, int showKey, int contactKey, int activityType, string activityUsername)
        {
            return await _client.AddActivity4Async(AuthHeader, connectionString, showKey, contactKey, activityType, activityUsername);
        }

        public async Task<AddActivity_Importing1> AddActivity5Async(string connectionString, int showKey, int contactKey, int activityType, int importBatch)
        {
            return await _client.AddActivity5Async(AuthHeader, connectionString, showKey, contactKey, activityType, importBatch);
        }

        public async Task<AddActivity_AllFields1> AddActivity6Async(string connectionString, int showKey, int contactKey, System.DateTime activityDate, int gateKey, int activityType, string activityUsername, int importBatch, int syncStatus)
        {
            return await _client.AddActivity6Async(AuthHeader, connectionString, showKey, contactKey, activityDate, gateKey, activityType, activityUsername, importBatch, syncStatus);
        }

        public async Task<AddtoGate_AllFields1> AddtoGateAsync(string connectionString, int showKey, string GateNumber, string CardNumber)
        {
            return await _client.AddtoGateAsync(AuthHeader, connectionString, showKey, GateNumber, CardNumber);
        }

        public async Task<DeleteResponse> DeleteAsync(string connectionString, int contactKey)
        {
            return await _client.DeleteAsync(AuthHeader, connectionString, contactKey);
        }
    }
}