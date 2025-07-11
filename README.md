# Corner49.PayNL
C# SDK for Pay.NL payment system

This SDK is started as a clone of the offical [Pay.NL sdk-net](https://github.com/paynl/sdk-net)
This SDK provides support for both the [PAY 2.0](https://developer.pay.nl/v2.0/docs/introduction), and the [PAY 3.0](https://developer.pay.nl/v3.0/docs/introduction), with each their own client class, `PayV2Client` and `PayV3Client`.


- Added some bugfixes
- Added some improvements
- Added extra features


---

- [Installation](#installation)
- [Quick start and examples](#usage)
- [Supported platforms](#supported-platforms)
- [Implemented features](#implemented-features)
- [License](#license)

---
### Installation
Simply download and restore nuget packages https://www.nuget.org/packages/PayNL.Sdk or install it from package manager
```
PM> Install-Package Corner49.PayNL -Version x.x.x
```
### Usage

Creating a client, you can find your API key and tokens in the [Pay.nl Admin Panel](https://my.pay.nl/company/tokens), and the service id (SL-xxxx-xxx) secret in the [Pay.nl Services Overview](https://my.pay.nl/programs/programs#field_content) under 'Sales locations':
```c#
var client = new PayV2Client("apiSecret", "AT-xxxx-xxxx", "ST-xxxx-xxxx");
```

Getting a list of available payment methods:
```c#
var methods = await client.GetAvailablePaymentMethods();
```

Starting a transaction:
```c#
var transactionRequest = new CreateTransactionRequest()
{
    Amount = new Amount()
        {
            Value = 1000,
        },
    ReturnUrl = "https://demo.pay.nl/complete/",
    Description = "Example transaction",
    Reference = "12345XXY0123"
};

// Contains ID
var transactionResponse = await client.CreateTransaction(transactionRequest);
```

To determine if a transaction has been paid, you can use:
```c#
var trxStatus = await client.GetTransactionInfo(transactionResponse.Id);
var paid = trxStatus.AmountPaid.Value == trxStatus.Amount.Value;
```

### Flexible debit order

To start a flexible debit order first create a mandate:
```c#
var mandate = await client.CreateMandate(new CreateMandateRequest
    {
        ServiceId = "SL-1234-1234",
        Amount= 1,
        Bankaccountholder = "John Doe",
        ProcessDate = "dd-MM-yyyy",
        Description = "Create Mandate",
        BankaccountNumber = "NL42INGB0000000000"
    });
var mandateId = mandate.MandateId;
```

The mandate first needs to be processed, use the below service too check the status of the mandate (`MandateStatusCode` should be `Processed`):
```c#
var mandate = await client.GetMandate("IO-1234-1234-1234");
```

Once processed you can start a flexible debit order using the below service:
```c#
var debitOrder = await client.CreateFlexibleDirectDebit(new FlexibleDirectDebitRequest
{
    MandateId = "IO-1234-1234-1234",
    Amount = 1,
    ProcessDate = "dd-MM-yyyy",
    Description = "Create debit order",
    Last = false,
});

var debitOrderId = debitOrder.DebitOrderId;
```

### Unit Tests

In order run the unit tests the following environment variables needs too be set up:
| Variable                    | Value                                             |
|-----------------------------|-------------------------------------------------------------|
| PAY_APIKEY                  | Your pay API Token from the pay dashboard                   |
| PAY_AT                      | AT code of the API Token (AT-1234-1234)                     |
| PAY_SERVICEID               | Service location code                                       |
| PAY_MERCHANTID              | Merchant code (M-1223-1234)                                 |
| PAY_MANDATEID               | Mandate code used for direct debit orders                   |
| PAY_BANKACCOUNTNUMBER       | Iban number used for clearing and diriect debit order tests |
| PAY_BANKACCOUNTHOLDER       | Account holder of the above Iban                            |

### Supported platforms
This library is built using .NET standard 2.0. This means that the package supports the following .NET implementations:
| Framework                   | Version Support |
|-----------------------------|-----------------|
| .NET and .NET Core          | 2.0, 2.1, 2.2, 3.0, 3.1, 5.0, 6.0, 7.0, 8.0, 9.0 |
| .NET Framework              | 4.6.1 2, 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8, 4.8.1 |
| Mono                        | 5.4, 6.4        |
| Xamarin.iOS                 | 10.14, 12.16    |
| Xamarin.Mac                 | 3.8, 5.16       |
| Xamarin.Android             | 8.0, 10.0       |
| Universal Windows Platform  | 10.0.16299, TBD |
| Unity                       | 2018.1          |

Source: https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0

### Implemented features API V2

- [ ] Transactions
    - [x] Create
    - [x] View
    - [x] Cancel
    - [x] Refund
    - [x] Approve
    - [x] Decline
    - [x] Capture
    - [x] Void
    - [x] Load
    - [ ] Load UUID
- [x] Refund
    - [x] Add
    - [x] Info
- [x] Get available currencies
- [x] DirectDebits CRUD
- [x] Ip addresses
    - [x] Get all
    - [x] Verify single
- [ ] Merchants
    - [x] Create    
    - [x] Get    
    - [x] Delete    
    - [x] List    
    - [x] Update
    - [x] Request review 
    - [x] Clearings
    - [x] Invoices
    - [x] Update package
    - [x] Undelete
- [x] Packages
- [x] Get available payment methods
- [x] Get services
- [x] Pin transactions
    - [x] Get status
    - [x] Cancel
    - [x] Get terminals
- [x] Trademarks
    - [x] Get
    - [x] List
    - [x] Create
    - [x] (Un)suspend
- [x] Create vouchers
- [ ] Remainder of the documented API

### Implemented features API V3
- [x] Orders
    - [x] Create
    - [x] View
    - [x] Capture order
    - [x] Capture amount
    - [x] Capture products
    - [x] Void
    - [x] Abort
    - [x] Approve
    - [x] Decline
- [ ] Remainder of the documented API

### License

The Assembly is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).