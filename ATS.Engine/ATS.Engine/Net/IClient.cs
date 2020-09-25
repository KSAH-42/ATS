using System;
using System.Threading.Tasks;

namespace ATS.Engine.Net
{
	using ATS.Engine.Net.Requests;
	using ATS.Engine.Net.Responses;
	using System.Threading;

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

		Task<AuthenticationResponse> AuthenticateAsync( AuthenticationRequest request , CancellationToken cancellationToken );

		SaveEntityResponse SaveEntity( SaveEntityRequest request );

		Task<SaveEntityResponse> SaveEntityAsync( SaveEntityRequest request , CancellationToken cancellationToken );

		SaveTransactionResponse SaveTransaction( SaveTransactionRequest request );

		Task<SaveTransactionResponse> SaveTransactionAsync( SaveTransactionRequest request , CancellationToken cancellationToken );

		SaveEventRecordResponse SaveEventRecord( SaveEventRecordRequest request );

		Task<SaveEventRecordResponse> SaveEventRecordAsync( SaveEventRecordRequest request , CancellationToken cancellationToken );

		FindEntityResponse FindEntity( FindEntityRequest request );

		Task<FindEntityResponse> FindEntityAsync( FindEntityRequest request , CancellationToken cancellationToken );

		FindTransactionResponse FindTransaction( FindTransactionRequest request );

		Task<FindTransactionResponse> FindTransactionAsync( FindTransactionRequest request , CancellationToken cancellationToken );

		FindEventRecordResponse FindEventRecord( FindEventRecordRequest request );

		Task<FindEventRecordResponse> FindEventRecordAsync( FindEventRecordRequest request , CancellationToken cancellationToken );

		ListEntitiesResponse ListEntities();

		Task<ListEntitiesResponse> ListEntitiesAsync( CancellationToken cancellationToken );

		ListEntitiesResponse ListEntities( ListEntitiesRequest request );

		Task<ListEntitiesResponse> ListEntitiesAsync( ListEntitiesRequest request , CancellationToken cancellationToken );

		ListTransactionsResponse ListTransactions();

		Task<ListTransactionsResponse> ListTransactionsAsync( CancellationToken cancellationToken );

		ListTransactionsResponse ListTransactions( ListTransactionsRequest request );

		Task<ListTransactionsResponse> ListTransactionsAsync( ListTransactionsRequest request , CancellationToken cancellationToken );

		ListEventRecordsResponse ListEventRecords();

		Task<ListEventRecordsResponse> ListEventRecordsAsync( CancellationToken cancellationToken );

		ListEventRecordsResponse ListEventRecords( ListEventRecordsRequest request );

		Task<ListEventRecordsResponse> ListEventRecordsAsync( ListEventRecordsRequest request , CancellationToken cancellationToken );

		DeleteEntityResponse DeleteEntity( DeleteEntityRequest request );

		Task<DeleteEntityResponse> DeleteEntityAsync( DeleteEntityRequest request , CancellationToken cancellationToken );

		DeleteTransactionResponse DeleteTransaction( DeleteTransactionRequest request );

		Task<DeleteTransactionResponse> DeleteTransactionAsync( DeleteTransactionRequest request , CancellationToken cancellationToken );

		DeleteEventRecordResponse DeleteEventRecord( DeleteEventRecordRequest request );

		Task<DeleteEventRecordResponse> DeleteEventRecordAsync( DeleteEventRecordRequest request , CancellationToken cancellationToken );

		DeleteEntitiesResponse DeleteEntities();

		Task<DeleteEntitiesResponse> DeleteEntitiesAsync( CancellationToken cancellationToken );

		DeleteEntitiesResponse DeleteEntities( DeleteEntitiesRequest request );

		Task<DeleteEntitiesResponse> DeleteEntitiesAsync( DeleteEntitiesRequest request , CancellationToken cancellationToken );

		DeleteTransactionsResponse DeleteTransactions();
		
		Task<DeleteTransactionsResponse> DeleteTransactionsAsync( CancellationToken cancellationToken );

		DeleteTransactionsResponse DeleteTransactions( DeleteTransactionsRequest request );

		Task<DeleteTransactionsResponse> DeleteTransactionsAsync( DeleteTransactionsRequest request , CancellationToken cancellationToken );

		DeleteEventRecordsResponse DeleteEventRecords();

		Task<DeleteEventRecordsResponse> DeleteEventRecordsAsync( CancellationToken cancellationToken );

		DeleteEventRecordsResponse DeleteEventRecords( DeleteEventRecordsRequest request );

		Task<DeleteEventRecordsResponse> DeleteEventRecordsAsync( DeleteEventRecordsRequest request , CancellationToken cancellationToken );

		OpenAccountResponse OpenAccount( OpenAccountRequest request );

		Task<OpenAccountResponse> OpenAccountAsync( OpenAccountRequest request , CancellationToken cancellationToken );

		ReOpenAccountResponse ReOpenAccount( ReOpenAccountRequest request );

		Task<ReOpenAccountResponse> ReOpenAccountAsync( ReOpenAccountRequest request , CancellationToken cancellationToken );

		CloseAccountResponse CloseAccount( CloseAccountResponse request );

		Task<CloseAccountResponse> CloseAccount( CloseAccountRequest request , CancellationToken cancellationToken );

		DepositResponse	Deposit( DepositRequest request );

		Task<DepositResponse> DepositAsync( DepositRequest request , CancellationToken cancellationToken );

		WithdrawResponse Withdraw( WithdrawRequest request );

		Task<WithdrawResponse> WithdrawAsync( WithdrawRequest request , CancellationToken cancellationToken );

		EnableCardResponse EnableCard( EnableCardRequest request );

		Task<EnableCardResponse> EnableCardAsync( EnableCardRequest request , CancellationToken cancellationToken );

		DisableCardResponse DisableCard( DisableCardRequest request );

		Task<DisableCardResponse> DisableCardAsync( DisableCardRequest request , CancellationToken cancellationToken );
	}
}
