US Verifications
-----------

```csharp
var Lob = new Lob('<api-key-here>');
var address = new USAddress
{
    PrimaryLine = "185 Berry Street",
    City = "San Francisco",
    State = "CA",
    ZipCode = "94107"
};
USVerification verification = Lob.Verify(address);
```