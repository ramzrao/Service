using InfoWebAPI.Activities.Application.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public interface IActivitiesWrapper
    {
        Task AddAllFieldsActivity(int accountId, int showKey, int contactKey, DateTime activityDate, int gateKey, int activityType, string activityUsername, int importBatch, int syncStatus);

        Task AddDBMSActivity(int accountId, int showKey, int contactKey, int activityType, string activityUsername);

        Task AddDefaultActivity(int accountId, int showKey, int contactKey, int activityType);

        Task AddGateActivity(int accountId, int contactKey, int gateKey);

        Task AddImportingActivity(int accountId, int showKey, int contactKey, int activityType, int importBatch);

        Task AddPhotoActivity(int accountId, int contactKey, int ActivityType, int showKey, int gateKey, string computerName);

        Task AddPhotoGatesActivity(int accountId, int contactKey, int gateKey, bool isPhotoGate, string ComputerName, int gatePassage);

        Task<int> AddToGate(int accountId, int showKey, string GateNumber, string CardNumber);

        Task Delete(int accountId, int contactKey);

        Task<List<Activity>> FetchAll(int accountId, int contactKey);

        Task<List<Activity>> FetchByActivityType(int accountId, int activityType);

        Task<int> HideRecord(int accountId, int contactKey);

        Task<int> PermanentDeleteRecord(int accountId, int contactkey);

        Task<int> RestoreRecord(int accountId, int contactKey);
    }
}