using InfoWebAPI.Activities.Application.Models;
using InfoWebAPI.Application.Common.Helpers;
using InfoWebAPI.Core.Application.Account;
using InfoWebAPI.Infrastructure.ClientProxies.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class ActivitiesWrapper : DeserializeXml, IActivitiesWrapper
    {
        private readonly IActivitiesClientReference _activitiesClientReference;
        private readonly IMediator _mediator;

        public ActivitiesWrapper(IActivitiesClientReference activitiesClientReference, IMediator mediator)
        {
            _activitiesClientReference = activitiesClientReference;
            _mediator = mediator;
        }

        public async Task AddGateActivity(int accountId, int contactKey, int gateKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _activitiesClientReference.AddActivity1Async(connString, contactKey, gateKey);
        }

        public async Task AddPhotoGatesActivity(int accountId, int contactKey, int gateKey, bool isPhotoGate, string ComputerName, int gatePassage)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _activitiesClientReference.AddActivity2Async(connString, contactKey, gateKey, isPhotoGate, ComputerName, gatePassage);
        }

        public async Task AddPhotoActivity(int accountId, int contactKey, int ActivityType, int showKey, int gateKey, string computerName)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _activitiesClientReference.AddActivity3Async(connString, contactKey, ActivityType, showKey, gateKey, computerName);
        }

        public async Task AddDBMSActivity(int accountId, int showKey, int contactKey, int activityType, string activityUsername)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _activitiesClientReference.AddActivity4Async(connString, showKey, contactKey, activityType, activityUsername);
        }

        public async Task AddImportingActivity(int accountId, int showKey, int contactKey, int activityType, int importBatch)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _activitiesClientReference.AddActivity5Async(connString, showKey, contactKey, activityType, importBatch);
        }

        public async Task AddAllFieldsActivity(int accountId, int showKey, int contactKey, DateTime activityDate, int gateKey, int activityType, string activityUsername, int importBatch, int syncStatus)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _activitiesClientReference.AddActivity6Async(connString, showKey, contactKey, activityDate, gateKey, activityType, activityUsername, importBatch, syncStatus);
        }

        public async Task AddDefaultActivity(int accountId, int showKey, int contactKey, int activityType)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _activitiesClientReference.AddActivityAsync(connString, showKey, contactKey, activityType);
        }

        public async Task<int> AddToGate(int accountId, int showKey, string GateNumber, string CardNumber)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _activitiesClientReference.AddtoGateAsync(connString, showKey, GateNumber, CardNumber);
            return await Task.FromResult(response.AddtoGate_AllFieldsResult);
        }

        public async Task Delete(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            await _activitiesClientReference.DeleteAsync(connString, contactKey);
        }

        public async Task<List<Activity>> FetchAll(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _activitiesClientReference.FetchAllAsync(connString, contactKey);
            return GetDeserializedResponse<Activity>(response.FetchAllResult.Nodes);
        }

        public async Task<List<Activity>> FetchByActivityType(int accountId, int activityType)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _activitiesClientReference.FetchByActivityTypeAsync(connString, activityType);
            return GetDeserializedResponse<Activity>(response.FetchByActivityTypeResult.Nodes);
        }

        public async Task<int> HideRecord(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _activitiesClientReference.HideRecordAsync(connString, contactKey);
            return await Task.FromResult(response.HideRecordResult);
        }

        public async Task<int> PermanentDeleteRecord(int accountId, int contactkey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _activitiesClientReference.PermanentDeleteRecordAsync(connString, contactkey);
            return await Task.FromResult(response.PermanentDeleteRecordResult);
        }

        public async Task<int> RestoreRecord(int accountId, int contactKey)
        {
            var connString = await GetAccountConnectionString(accountId);
            var response = await _activitiesClientReference.RestoreRecordAsync(connString, contactKey);
            return await Task.FromResult(response.RestoreRecordResult);
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