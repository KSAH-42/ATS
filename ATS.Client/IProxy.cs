using System;
using System.Threading;
using System.Threading.Tasks;

namespace ATS.Client
{
	using ATS.Client.Requests;
	using ATS.Client.Responses;

	public interface IProxy
	{
		object SyncRoot
		{
			get;
		}

		Guid? SessionId
		{
			get;
		}

		bool IsConnected
		{
			get;
		}

		TimeSpan Timeout
		{
			get;
			set;
		}

		void Connect( string host );

		Task ConnectAsync( string host );

		Task ConnectAsync( string host , CancellationToken cancellationToken );

		void Disconnect();

		void Ping();

		AuthenticationResponse Authenticate( AuthenticationRequest request );

		Task<AuthenticationResponse> AuthenticateAsync( AuthenticationRequest request );

		Task<AuthenticationResponse> AuthenticateAsync( AuthenticationRequest request , CancellationToken cancellationToken );

		SaveEntityResponse SaveEntity( SaveEntityRequest request );

		Task<SaveEntityResponse> SaveEntityAsync( SaveEntityRequest request  );

		Task<SaveEntityResponse> SaveEntityAsync( SaveEntityRequest request , CancellationToken cancellationToken );

		SaveTransactionResponse SaveTransaction( SaveTransactionRequest request );

		Task<SaveTransactionResponse> SaveTransactionAsync( SaveTransactionRequest request );

		Task<SaveTransactionResponse> SaveTransactionAsync( SaveTransactionRequest request , CancellationToken cancellationToken );

		SaveEventResponse SaveEvent( SaveEventRequest request );

		Task<SaveEventResponse> SaveEventAsync( SaveEventRequest request );

		Task<SaveEventResponse> SaveEventAsync( SaveEventRequest request , CancellationToken cancellationToken );

		FindEntityResponse FindEntity( FindEntityRequest request );

		Task<FindEntityResponse> FindEntityAsync( FindEntityRequest request );

		Task<FindEntityResponse> FindEntityAsync( FindEntityRequest request , CancellationToken cancellationToken );

		FindTransactionResponse FindTransaction( FindTransactionRequest request );

		Task<FindTransactionResponse> FindTransactionAsync( FindTransactionRequest request );

		Task<FindTransactionResponse> FindTransactionAsync( FindTransactionRequest request , CancellationToken cancellationToken );

		FindEventResponse FindEvent( FindEventRequest request );

		Task<FindEventResponse> FindEventAsync( FindEventRequest request );

		Task<FindEventResponse> FindEventAsync( FindEventRequest request , CancellationToken cancellationToken );

		ListEntitiesResponse ListEntities();

		Task<ListEntitiesResponse> ListEntitiesAsync();

		Task<ListEntitiesResponse> ListEntitiesAsync( CancellationToken cancellationToken );

		ListEntitiesResponse ListEntities( ListEntitiesRequest request );

		Task<ListEntitiesResponse> ListEntitiesAsync( ListEntitiesRequest request );

		Task<ListEntitiesResponse> ListEntitiesAsync( ListEntitiesRequest request , CancellationToken cancellationToken );

		ListTransactionsResponse ListTransactions();

		Task<ListTransactionsResponse> ListTransactionsAsync();

		Task<ListTransactionsResponse> ListTransactionsAsync( CancellationToken cancellationToken );

		ListTransactionsResponse ListTransactions( ListTransactionsRequest request );

		Task<ListTransactionsResponse> ListTransactionsAsync( ListTransactionsRequest request );

		Task<ListTransactionsResponse> ListTransactionsAsync( ListTransactionsRequest request , CancellationToken cancellationToken );

		ListEventsResponse ListEvents();

		Task<ListEventsResponse> ListEventsAsync();

		Task<ListEventsResponse> ListEventsAsync( CancellationToken cancellationToken );

		ListEventsResponse ListEvents( ListEventsRequest request );

		Task<ListEventsResponse> ListEventsAsync( ListEventsRequest request );

		Task<ListEventsResponse> ListEventsAsync( ListEventsRequest request , CancellationToken cancellationToken );

		DeleteEntityResponse DeleteEntity( DeleteEntityRequest request );

		Task<DeleteEntityResponse> DeleteEntityAsync( DeleteEntityRequest request );

		Task<DeleteEntityResponse> DeleteEntityAsync( DeleteEntityRequest request , CancellationToken cancellationToken );

		DeleteTransactionResponse DeleteTransaction( DeleteTransactionRequest request );

		Task<DeleteTransactionResponse> DeleteTransactionAsync( DeleteTransactionRequest request );

		Task<DeleteTransactionResponse> DeleteTransactionAsync( DeleteTransactionRequest request , CancellationToken cancellationToken );

		DeleteEventResponse DeleteEvent( DeleteEventRequest request );

		Task<DeleteEventResponse> DeleteEventAsync( DeleteEventRequest request );

		Task<DeleteEventResponse> DeleteEventAsync( DeleteEventRequest request , CancellationToken cancellationToken );

		DeleteEntitiesResponse DeleteEntities();

		Task<DeleteEntitiesResponse> DeleteEntitiesAsync();

		Task<DeleteEntitiesResponse> DeleteEntitiesAsync( CancellationToken cancellationToken );

		DeleteEntitiesResponse DeleteEntities( DeleteEntitiesRequest request );

		Task<DeleteEntitiesResponse> DeleteEntitiesAsync( DeleteEntitiesRequest request );

		Task<DeleteEntitiesResponse> DeleteEntitiesAsync( DeleteEntitiesRequest request , CancellationToken cancellationToken );

		DeleteTransactionsResponse DeleteTransactions();

		Task<DeleteTransactionsResponse> DeleteTransactionsAsync();

		Task<DeleteTransactionsResponse> DeleteTransactionsAsync( CancellationToken cancellationToken );

		DeleteTransactionsResponse DeleteTransactions( DeleteTransactionsRequest request );

		Task<DeleteTransactionsResponse> DeleteTransactionsAsync( DeleteTransactionsRequest request );

		Task<DeleteTransactionsResponse> DeleteTransactionsAsync( DeleteTransactionsRequest request , CancellationToken cancellationToken );

		DeleteEventsResponse DeleteEvents();

		Task<DeleteEventsResponse> DeleteEventsAsync();

		Task<DeleteEventsResponse> DeleteEventsAsync( CancellationToken cancellationToken );

		DeleteEventsResponse DeleteEvents( DeleteEventsRequest request );

		Task<DeleteEventsResponse> DeleteEventsAsync( DeleteEventsRequest request );

		Task<DeleteEventsResponse> DeleteEventsAsync( DeleteEventsRequest request , CancellationToken cancellationToken );

		SearchTransactionsResponse SearchTransactions( SearchTransactionsRequest request );

		Task<SearchTransactionsResponse> SearchTransactionsAsync( SearchTransactionsRequest request );

		Task<SearchTransactionsResponse> SearchTransactionsAsync( SearchTransactionsRequest request , CancellationToken cancellationToken );

		SearchEventsResponse SearchEvents( SearchEventsRequest request );

		Task<SearchEventsResponse> SearchEventsAsync( SearchEventsRequest request );

		Task<SearchEventsResponse> SearchEventsAsync( SearchEventsRequest request , CancellationToken cancellationToken );

		OpenAccountResponse OpenAccount( OpenAccountRequest request );

		Task<OpenAccountResponse> OpenAccountAsync( OpenAccountRequest request );

		Task<OpenAccountResponse> OpenAccountAsync( OpenAccountRequest request , CancellationToken cancellationToken );

		ReOpenAccountResponse ReOpenAccount( ReOpenAccountRequest request );

		Task<ReOpenAccountResponse> ReOpenAccountAsync( ReOpenAccountRequest request );

		Task<ReOpenAccountResponse> ReOpenAccountAsync( ReOpenAccountRequest request , CancellationToken cancellationToken );

		CloseAccountResponse CloseAccount( CloseAccountResponse request );

		Task<CloseAccountResponse> CloseAccount( CloseAccountRequest request );

		Task<CloseAccountResponse> CloseAccount( CloseAccountRequest request , CancellationToken cancellationToken );

		DepositResponse	Deposit( DepositRequest request );

		Task<DepositResponse> DepositAsync( DepositRequest request );

		Task<DepositResponse> DepositAsync( DepositRequest request , CancellationToken cancellationToken );

		WithdrawResponse Withdraw( WithdrawRequest request );

		Task<WithdrawResponse> WithdrawAsync( WithdrawRequest request );

		Task<WithdrawResponse> WithdrawAsync( WithdrawRequest request , CancellationToken cancellationToken );

		EnableCardResponse EnableCard( EnableCardRequest request );

		Task<EnableCardResponse> EnableCardAsync( EnableCardRequest request );

		Task<EnableCardResponse> EnableCardAsync( EnableCardRequest request , CancellationToken cancellationToken );

		DisableCardResponse DisableCard( DisableCardRequest request );

		Task<DisableCardResponse> DisableCardAsync( DisableCardRequest request );

		Task<DisableCardResponse> DisableCardAsync( DisableCardRequest request , CancellationToken cancellationToken );
	}
}
