US Verifications
-----------


Verify a US address.
```csharp
var Lob = new Lob('<api-key-here>');
var address = new USAddress
{
    PrimaryLine = "185 Berry Street",
    City = "San Francisco",
    State = "CA",
    ZipCode = "94107"
};
USVerification verification = Lob.Verify.USAddress(address);
```

Letters
-----------


Create a new letter.
```csharp
var Lob = new Lob('<api-key-here>');
Letter = new Letter
{
    Description = "Demo Letter",
    To = Address,
    From = Address,
    Color = true,
    File = "<html style='padding-top: 3in; margin: .5in;'>HTML Letter for {{name}}</html>",
    DoubleSided = true,
    AddressPlacement = "top_first_page",
    ReturnEnvelope = false,
    PerforatedPage = null,
    ExtraService = null,
    MailType = "usps_first_class",
    TemplateId = null,
    TrackingNumber = null,
    TrackingEvents = null,
    SendDate = DateTime.Now.AddDays(1),
};
Letter createdLetter = Lob.Create.Letter(Letter);
```

Retrieve a letter.
Retrieves the letter with a given ID. You need only supply the unique letter ID that was returned upon letter creation.
```csharp
var Lob = new Lob('<api-key-here>');
var id = "ltr_4868c3b754655f90";
Letter letter = Lob.Retrieve.Letter(id);
```