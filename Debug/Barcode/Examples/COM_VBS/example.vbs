Dim bf
Dim b

Set bf = CreateObject("Limilabs.Barcode.BarcodeFactory")
Set b = bf.CreateBarcode(4)			'=Code39. Check Symbology enum for other values.

' Set some barcode properites.
b.FontStyle = 1					'=Bold. Check FontStyleType enum for other values. 
b.Number = "12345"
b.Rotation = 1					'=Degrees90. Check RotationType enum for other values. 

'b.BarColorOle = RGB(255,0,0)   		' You can change the colors using RGB fuction
'b.ForeColorOle = RGB(0,255,0)
'b.BackColorOle = RGB(255,255,255)

' Save barcode image to file as PNG.
b.Save "Barcode_vbs.png", 2				'=Png. Check ImageType enum for other values.

MsgBox "Barcode saved to Barcode_vbs.png", , "Information"