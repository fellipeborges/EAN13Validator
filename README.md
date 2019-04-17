# EAN13Validator
A simple 13 digit EAN validator.

## What is an EAN number
The International Article Number (also known as European Article Number or EAN) is a standard describing a barcode symbology and numbering system used in global trade to identify a specific retail product type, in a specific packaging configuration, from a specific manufacturer.

## Usage
```csharp
IEanValidator eanValidator = new EanValidator();
bool isValid = eanValidator.Validate("0040232916847");
```
