using System;
using System.Threading.Tasks;

namespace ATS.Engine.Net
{
	using ATS.Engine.Net.Requests;
	using ATS.Engine.Net.Responses;

	public interface IClient
	{
		object SyncRoot
		{
			get;
		}

		Guid? SessionId
		{
			get;
		}

		DOReadOnlyCache<DOEntity> Entities
		{
			get;
		}

		PermissionReadOnlyList Permissions
		{
			get;
		}

		HandlerList Handlers
		{
			get;
		}

		bool IsConnected
		{
			get;
		}

		void Connect( string server );

		void Connect( string server , TimeSpan timeout );

		Task ConnectAsync( string server );

		Task ConnectAsync( string server , TimeSpan timeout );

		void Disconnect();

		void Ping();

		AuthenticationResponse Authenticate( AuthenticationRequest request );

		Task<AuthenticationResponse> AuthenticateAsync( AuthenticationRequest request );

		GetEntityResponse GetEntity( GetEntityRequest request );

		Task<GetEntityResponse> GetEntityAsync( GetEntityRequest request );

		ListEntitiesResponse ListEntities();

		Task<ListEntitiesResponse> ListEntitiesAsync();

		ListEntitiesResponse ListEntities( ListEntitiesRequest request );

		Task<ListEntitiesResponse> ListEntitiesAsync( ListEntitiesRequest request );

		ListTransactionsResponse ListTransactions();

		Task<ListTransactionsResponse> ListTransactionsAsync();

		ListTransactionsResponse ListTransactions( ListTransactionsRequest request );

		Task<ListTransactionsResponse> ListTransactionsAsync( ListTransactionsRequest request );

		ListEventRecordsResponse ListEventRecords();

		Task<ListEventRecordsResponse> ListEventRecordsAsync();

		ListEventRecordsResponse ListEventRecords( ListEventRecordsRequest request );

		Task<ListEventRecordsResponse> ListEventRecordsAsync( ListEventRecordsRequest request );

		DeleteEntityResponse DeleteEntity( DeleteEntityRequest request );

		Task<DeleteEntityResponse> DeleteEntityAsync( DeleteEntityRequest request );

		DeleteTransactionResponse DeleteTransaction( DeleteTransactionRequest request );

		Task<DeleteTransactionResponse> DeleteTransactionAsync( DeleteTransactionRequest request );

		DeleteEventRecordResponse DeleteEventRecord( DeleteEventRecordRequest request );

		Task<DeleteEventRecordResponse> DeleteEventRecordAsync( DeleteEventRecordRequest request );

		DeleteAllEntitiesResponse DeleteAllEntities();

		Task<DeleteAllEntitiesResponse> DeleteAllEntitiesAsync();

		DeleteAllEntitiesResponse DeleteAllEntities( DeleteAllEntitiesRequest request );

		Task<DeleteAllEntitiesResponse> DeleteAllEntitiesAsync( DeleteAllEntitiesRequest request );

		DeleteAllTransactionsResponse DeleteAllTransactions();
		
		Task<DeleteAllTransactionsResponse> DeleteAllTransactionsAsync();

		DeleteAllTransactionsResponse DeleteAllTransactions( DeleteAllTransactionsRequest request );

		Task<DeleteAllTransactionsResponse> DeleteAllTransactionsAsync( DeleteAllTransactionsRequest request );

		DeleteAllEventRecordsResponse DeleteAllEventRecords();

		Task<DeleteAllEventRecordsResponse> DeleteAllEventRecordsAsync();

		DeleteAllEventRecordsResponse DeleteAllEventRecords( DeleteAllEventRecordsRequest request );

		Task<DeleteAllEventRecordsResponse> DeleteAllEventRecordsAsync( DeleteAllEventRecordsRequest request );
	}
}
