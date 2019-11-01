using Activities;
using System;
using System.Threading.Tasks;

namespace InfoWebAPI.Infrastructure.ClientProxies.Interfaces
{
    public interface IActivitiesClientReference
    {
        Task<AddActivity_Gates1> AddActivity1Async(string connectionString, int contactKey, int gateKey);

        Task<AddActivity_PhotoGates1> AddActivity2Async(string connectionString, int contactKey, int gateKey, bool isPhotoGate, string ComputerName, int gatePassage);

        Task<AddPhotoActivity_GenericAddActivity1> AddActivity3Async(string connectionString, int contactKey, int ActivityType, int showKey, int gateKey, string computerName);

        Task<AddActivity_DBMS1> AddActivity4Async(string connectionString, int showKey, int contactKey, int activityType, string activityUsername);

        Task<AddActivity_Importing1> AddActivity5Async(string connectionString, int showKey, int contactKey, int activityType, int importBatch);

        Task<AddActivity_AllFields1> AddActivity6Async(string connectionString, int showKey, int contactKey, DateTime activityDate, int gateKey, int activityType, string activityUsername, int importBatch, int syncStatus);

        Task<AddActivity_Default1> AddActivityAsync(string connectionString, int showKey, int contactKey, int activityType);

        Task<AddtoGate_AllFields1> AddtoGateAsync(string connectionString, int showKey, string GateNumber, string CardNumber);

        Task<DeleteResponse> DeleteAsync(string connectionString, int contactKey);

        Task<FetchAllResponse> FetchAllAsync(string connectionString, int contactKey);

        Task<FetchByActivityTypeResponse> FetchByActivityTypeAsync(string connectionString, int activityType);

        Task<HideRecordResponse> HideRecordAsync(string connectionString, int contactKey);

        Task<PermanentDeleteRecordResponse> PermanentDeleteRecordAsync(string connectionString, int contactkey);

        Task<RestoreRecordResponse> RestoreRecordAsync(string connectionString, int contactKey);
    }
}