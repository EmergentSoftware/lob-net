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

##### Retrieve a postcard
Retrieves the postcard with a given ID. You need only supply the unique postcard ID that was returned upon postcard creation.
```csharp
var Lob = new Lob('<api-key-here>');
var id = "psc_5c002b86ce47537a";
Postcard postcard = Lob.Retrieve.Postcard(id);
```

##### Cancel a postcard
Completely removes a postcard from production. This can only be done if the postcard’s send_date has not yet passed. If the postcard is successfully canceled, you will not be charged for it. Read more on postcard cancellation windows and scheduling postcards.
```csharp
var Lob = new Lob('<api-key-here>');
var id = "psc_5c002b86ce47537a";
Cancellation cancellation = Lob.Cancel.Postcard(id);
```

##### List all postcards
Returns a list of postcards. The returned postcards are sorted by creation date, with the most recently created postcards appearing first.
```csharp
var Lob = new Lob('<api-key-here>');
ModelList<Postcard> postcards = Lob.List.Postcards(limit: 2, offset: 0);
``` 

Addresses
-----------
##### Create an address
Creates a new address object.
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
Address address = Lob.Create.Address(address);
```

##### Retrieve an address
Retrieves the details of an existing address. You need only supply the unique customer identifier that was returned upon address creation.
```csharp
var Lob = new Lob('<api-key-here>');
var id = "psc_5c002b86ce47537a";
Address address = Lob.Retrieve.Address(id);
```

##### Delete an address
Permanently deletes a customer. It cannot be undone.
```csharp
var Lob = new Lob('<api-key-here>');
var id = "psc_5c002b86ce47537a";
Address address = Lob.Delete.Postcard(id);
```

##### List all addresses
Returns a list of your addresses. The addresses are returned sorted by creation date, with the most recently created addresses appearing first.
```csharp
var Lob = new Lob('<api-key-here>');
ModelList<Address> addresses = Lob.List.Addresses(limit: 2, offset: 0);
``` 