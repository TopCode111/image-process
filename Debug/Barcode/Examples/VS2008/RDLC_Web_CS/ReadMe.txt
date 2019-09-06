1. Look into Page_Load method in Default class, some required code is there.

2. Open Report.rdlc in design mode, select "Properties" from the context menu on grey field:
	a. Take a look at "References" tab, Barcode.dll is referenced there, and BarcodeFactory is instantiated.
	b. Note that Barcode.dll must be registered in GAC - installer does that.
	c. Take a look at "Code" tab, GetBarcode128 method is defined there.
	
3. Take a look at Image control below "ID" text, note its properties:
	MimeType	"image/png"
	Source		"DataBase"
	Value		"=Code.GetBarcode128(Fields!Name.Value)"