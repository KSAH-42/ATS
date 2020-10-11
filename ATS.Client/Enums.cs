using System;

namespace ATS.Client
{
	public enum DOEntityType
	{
		User = 1,

		Account,

		Card,

		Setting,

		Role,
	}

	public enum DOEventType
	{
		None = 0,

		UserConnected,

		UserDisconnected,

		CardOrdered,

		CardEnabled,

		CardDisabled,

		AccountOpened,

		AccountClosed,

		WithdrawMoney,

		DepositMoney,
	}

}