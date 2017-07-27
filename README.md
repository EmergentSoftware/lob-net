US Verifications
-----------


##### Verify a US address.
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


##### Create a new letter
```csharp
var Lob = new Lob('<api-key-here>');
var letter = new Letter
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
Letter createdLetter = Lob.Create.Letter(letter);
```

##### Retrieve a letter
Retrieves the letter with a given ID. You need only supply the unique letter ID that was returned upon letter creation.
```csharp
var Lob = new Lob('<api-key-here>');
var id = "ltr_4868c3b754655f90";
Letter letter = Lob.Retrieve.Letter(id);
```

##### Cancel a letter
Completely removes a letter from production. This can only be done if the letter send_date has not yet passed.
```csharp
var Lob = new Lob('<api-key-here>');
var id = "ltr_4868c3b754655f90";
Letter letter = Lob.Cancel.Letter(id);
```

##### List all letters
Returns a list of letters. The letters are returned sorted by creation date, with the most recently created letters appearing first.
```csharp
var Lob = new Lob('<api-key-here>');
LetterList letters = Lob.List.Letters(limit: 2, offset: 0);
```

Postcards
-----------
##### Create a postcard
```csharp
var Lob = new Lob('<api-key-here>');
var address = new Address
{
    Description = null,
    Name = "Harry Zhang",
    Phone = null,
    Email = null,
    Company = null,
    AddressLine1 = "123 Test Street",
    AddressLine2 = null,
    AddressCity = "Mountain View",
    AddressState = "CA",
    AddressZip = "94041",
    AddressCountry = "US",
};
var postcard = new Postcard
{
    Description = "Demo Postcard job",
    To = address,
    From = address,
    Front = "<html style='padding: 1in; font-size: 50;'>Front HTML for {{name}}</html>",
    Back = "<html style='padding: 1in; font-size: 50;'>Back HTML for {{name}}</html>"
};
Postcard postcard = Lob.Create.Postcard(postcard);
```