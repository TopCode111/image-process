#include "stdafx.h"
#include <atlimage.h>

// tlb file is created during Barcode.dll installation
#import "..\..\..\Redistributables\Barcode.tlb" named_guids
//#import "c:\Barcode.tlb" named_guids

int _tmain(int argc, _TCHAR* argv[])
{
	// Initialize COM.
    CoInitialize(NULL);
	
	Barcode::IBarcodeFactoryPtr pIBarcodeFactory;
	HRESULT hr = pIBarcodeFactory.CreateInstance(Barcode::CLSID_BarcodeFactory);

	Barcode::IBaseBarcodePtr pIBarcode = pIBarcodeFactory->CreateBarcode(Barcode::Symbology_Code39);

	// Release BarcodeFactory object.
	pIBarcodeFactory = NULL;
	
	// Set some barcode properites.
	pIBarcode->FontStyle = Barcode::FontStyleType_Bold;
	pIBarcode->ForeColor = RGB(100, 100, 200);
	pIBarcode->Number = "123";
	pIBarcode->Rotation = Barcode::RotationType_Degrees90;

	// Save barcode image to file as PNG.
	pIBarcode->Save("barcode.png", Barcode::ImageType_Png);

	// Obtain handle to another memory bitmap.
	HBITMAP hBitmap = (HBITMAP)pIBarcode->RenderHbitmap();

	// Attach CBitmap object to this handle.
	// CBitmap *pBitmap = CBitmap::FromHandle(hBitmap);
	// // Here you can use CBitmap object
	// pBitmap->DeleteObject();

	// Attach CImage object to this handle.
	CImage image;
    image.Attach(hBitmap);
	// Save Cimage object to file as BMP.
    image.Save(L"barcode.bmp", Gdiplus::ImageFormatBMP);
	image.Destroy();
	
	// Release Barcode object.
	pIBarcode = NULL;

	// Uninitialize COM.
    CoUninitialize();


	//==============================================
	/*
	HRESULT hRes;

	// Initialize COM.
    CoInitialize(NULL);

	// Create BarcodeFactory.
	Barcode::IBarcodeFactory *pIBarcodeFactory;

    hRes = CoCreateInstance(
		Barcode::CLSID_BarcodeFactory, 
		NULL, 
		CLSCTX_INPROC_SERVER, 
		Barcode::IID_IBarcodeFactory, 
		reinterpret_cast<void**> (&pIBarcodeFactory)
		);

    if (S_OK == hRes)
    {
		// Create Barcode object using specified symbology.
		Barcode::IBarcode *pIBarcode;
		pIBarcode = pIBarcodeFactory->CreateBarcode(Barcode::Symbology_Code39);

		// Release BarcodeFactory object.
		pIBarcodeFactory->Release();
		
		// Set some barcode properites.
		pIBarcode->FontStyle = Barcode::FontStyleType_Bold;
		pIBarcode->ForeColor = RGB(100, 100, 200);
		pIBarcode->Number = "123";
		pIBarcode->Rotation = Barcode::RotationType_Degrees90;

		// Save barcode image to file as PNG.
		pIBarcode->Save("barcode.png", Barcode::ImageType_Png);

		// Obtain handle to another memory bitmap.
		HBITMAP hBitmap = (HBITMAP)pIBarcode->RenderHbitmap();

		// Attach CBitmap object to this handle.
		// CBitmap *pBitmap = CBitmap::FromHandle(hBitmap);
		// // Here you can use CBitmap object
		// pBitmap->DeleteObject();

		// Attach CImage object to this handle.
		CImage image;
        image.Attach(hBitmap);
		// Save Cimage object to file as BMP.
        image.Save(L"barcode.bmp", Gdiplus::ImageFormatBMP);
		image.Destroy();
		
		// Release Barcode object.
		pIBarcode->Release();
    }

	// Uninitialize COM.
    CoUninitialize();

*/
	return 0;
}

