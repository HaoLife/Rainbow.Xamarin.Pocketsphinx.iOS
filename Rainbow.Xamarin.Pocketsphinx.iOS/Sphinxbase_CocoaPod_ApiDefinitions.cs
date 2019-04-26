using Foundation;


partial interface Constants
{
	// extern const char *[] agc_type_str;
	[Field ("agc_type_str", "__Internal")]
	unsafe sbyte*[] agc_type_str { get; }


    // extern const char *[] cmn_type_str;
    [Field("cmn_type_str", "__Internal")]
    unsafe sbyte*[] cmn_type_str { get; }


    // extern double Sphinxbase_CocoaPodVersionNumber;
    [Field("Sphinxbase_CocoaPodVersionNumber", "__Internal")]
    double Sphinxbase_CocoaPodVersionNumber { get; }

    // extern const unsigned char [] Sphinxbase_CocoaPodVersionString;
    [Field("Sphinxbase_CocoaPodVersionString", "__Internal")]
    byte[] Sphinxbase_CocoaPodVersionString { get; }
}
