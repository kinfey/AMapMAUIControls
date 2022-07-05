using System;
using iOS.AMap.Foundation;
using CoreLocation;
using Foundation;
using ObjCRuntime;



namespace iOS.AMap.Foundation {

	[Static]
	// [Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AMapFoundationVersion;
		[Field ("AMapFoundationVersion", "__Internal")]
		NSString AMapFoundationVersion { get; }

		// extern NSString *const AMapFoundationName;
		[Field ("AMapFoundationName", "__Internal")]
		NSString AMapFoundationName { get; }

		// extern BOOL _amapLocationOverseas;
		[Field ("_amapLocationOverseas", "__Internal")]
		IntPtr _amapLocationOverseas { get; }
		// extern const NSErrorDomain _Nonnull AMapFoundationNSErrorFileDonotExist;
		[Field ("AMapFoundationNSErrorFileDonotExist", "__Internal")]
		NSString AMapFoundationNSErrorFileDonotExist { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationNSErrorFileDonotExistCode;
		[Field ("AMapFoundationNSErrorFileDonotExistCode", "__Internal")]
		nint AMapFoundationNSErrorFileDonotExistCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationNSErrorFilePathInvaild;
		[Field ("AMapFoundationNSErrorFilePathInvaild", "__Internal")]
		NSString AMapFoundationNSErrorFilePathInvaild { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationNSErrorFilePathInvaildCode;
		[Field ("AMapFoundationNSErrorFilePathInvaildCode", "__Internal")]
		nint AMapFoundationNSErrorFilePathInvaildCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationNSErrorTypeLogDonotExist;
		[Field ("AMapFoundationNSErrorTypeLogDonotExist", "__Internal")]
		NSString AMapFoundationNSErrorTypeLogDonotExist { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationNSErrorTypeLogDonotExistCode;
		[Field ("AMapFoundationNSErrorTypeLogDonotExistCode", "__Internal")]
		nint AMapFoundationNSErrorTypeLogDonotExistCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationNSErrorUploadDataIsEmpty;
		[Field ("AMapFoundationNSErrorUploadDataIsEmpty", "__Internal")]
		NSString AMapFoundationNSErrorUploadDataIsEmpty { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationNSErrorUploadDataIsEmptyCode;
		[Field ("AMapFoundationNSErrorUploadDataIsEmptyCode", "__Internal")]
		nint AMapFoundationNSErrorUploadDataIsEmptyCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationNSErrorParametersInvalid;
		[Field ("AMapFoundationNSErrorParametersInvalid", "__Internal")]
		NSString AMapFoundationNSErrorParametersInvalid { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationNSErrorParametersInvalidCode;
		[Field ("AMapFoundationNSErrorParametersInvalidCode", "__Internal")]
		nint AMapFoundationNSErrorParametersInvalidCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationNSErrorCloudConfigDisable;
		[Field ("AMapFoundationNSErrorCloudConfigDisable", "__Internal")]
		NSString AMapFoundationNSErrorCloudConfigDisable { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationNSErrorCloudConfigDisableCode;
		[Field ("AMapFoundationNSErrorCloudConfigDisableCode", "__Internal")]
		nint AMapFoundationNSErrorCloudConfigDisableCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationNSErrorNetworkUnusable;
		[Field ("AMapFoundationNSErrorNetworkUnusable", "__Internal")]
		NSString AMapFoundationNSErrorNetworkUnusable { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationNSErrorNetworkUnusableCode;
		[Field ("AMapFoundationNSErrorNetworkUnusableCode", "__Internal")]
		nint AMapFoundationNSErrorNetworkUnusableCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationNSErrorCurrentworkIsRunning;
		[Field ("AMapFoundationNSErrorCurrentworkIsRunning", "__Internal")]
		NSString AMapFoundationNSErrorCurrentworkIsRunning { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationNSErrorCurrentworkIsRunningCode;
		[Field ("AMapFoundationNSErrorCurrentworkIsRunningCode", "__Internal")]
		nint AMapFoundationNSErrorCurrentworkIsRunningCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationNSErrorCurrentUploadSizeHaveExcess;
		[Field ("AMapFoundationNSErrorCurrentUploadSizeHaveExcess", "__Internal")]
		NSString AMapFoundationNSErrorCurrentUploadSizeHaveExcess { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationNSErrorCurrentUploadSizeHaveExcessCode;
		[Field ("AMapFoundationNSErrorCurrentUploadSizeHaveExcessCode", "__Internal")]
		nint AMapFoundationNSErrorCurrentUploadSizeHaveExcessCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationErrorPrivacyShowUnknow;
		[Field ("AMapFoundationErrorPrivacyShowUnknow", "__Internal")]
		NSString AMapFoundationErrorPrivacyShowUnknow { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationErrorPrivacyShowUnknowCode;
		[Field ("AMapFoundationErrorPrivacyShowUnknowCode", "__Internal")]
		nint AMapFoundationErrorPrivacyShowUnknowCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationErrorPrivacyShowNoShow;
		[Field ("AMapFoundationErrorPrivacyShowNoShow", "__Internal")]
		NSString AMapFoundationErrorPrivacyShowNoShow { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationErrorPrivacyShowNoShowCode;
		[Field ("AMapFoundationErrorPrivacyShowNoShowCode", "__Internal")]
		nint AMapFoundationErrorPrivacyShowNoShowCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationErrorPrivacyInfoUnknow;
		[Field ("AMapFoundationErrorPrivacyInfoUnknow", "__Internal")]
		NSString AMapFoundationErrorPrivacyInfoUnknow { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationErrorPrivacyInfoUnknowCode;
		[Field ("AMapFoundationErrorPrivacyInfoUnknowCode", "__Internal")]
		nint AMapFoundationErrorPrivacyInfoUnknowCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationErrorPrivacyInfoNotContain;
		[Field ("AMapFoundationErrorPrivacyInfoNotContain", "__Internal")]
		NSString AMapFoundationErrorPrivacyInfoNotContain { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationErrorPrivacyInfoNotContainCode;
		[Field ("AMapFoundationErrorPrivacyInfoNotContainCode", "__Internal")]
		nint AMapFoundationErrorPrivacyInfoNotContainCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationErrorPrivacyAgreeUnknow;
		[Field ("AMapFoundationErrorPrivacyAgreeUnknow", "__Internal")]
		NSString AMapFoundationErrorPrivacyAgreeUnknow { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationErrorPrivacyAgreeUnknowCode;
		[Field ("AMapFoundationErrorPrivacyAgreeUnknowCode", "__Internal")]
		nint AMapFoundationErrorPrivacyAgreeUnknowCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationErrorPrivacyAgreeNotAgreee;
		[Field ("AMapFoundationErrorPrivacyAgreeNotAgreee", "__Internal")]
		NSString AMapFoundationErrorPrivacyAgreeNotAgreee { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationErrorPrivacyAgreeNotAgreeeCode;
		[Field ("AMapFoundationErrorPrivacyAgreeNotAgreeeCode", "__Internal")]
		nint AMapFoundationErrorPrivacyAgreeNotAgreeeCode { get; }

		// extern const NSErrorDomain _Nonnull AMapFoundationErrorInvaildUserKey;
		[Field ("AMapFoundationErrorInvaildUserKey", "__Internal")]
		NSString AMapFoundationErrorInvaildUserKey { get; }

		// extern const AMapFoundationNSErrorCode AMapFoundationErrorInvaildUserKeyCode;
		[Field ("AMapFoundationErrorInvaildUserKeyCode", "__Internal")]
		nint AMapFoundationErrorInvaildUserKeyCode { get; }
	}

	// @interface AMapServices : NSObject
	[BaseType (typeof(NSObject))]
	interface AMapServices
	{
		// +(AMapServices *)sharedServices;
		[Static]
		[Export ("sharedServices")]
		// [Verify (MethodToProperty)]
		AMapServices SharedServices { get; }

		// @property (copy, nonatomic) NSString * apiKey;
		[Export ("apiKey")]
		string ApiKey { get; set; }

		// @property (assign, nonatomic) BOOL enableHTTPS;
		[Export ("enableHTTPS")]
		bool EnableHTTPS { get; set; }

		// @property (assign, nonatomic) BOOL crashReportEnabled __attribute__((deprecated("从v1.5.7开始废弃，调用无任何作用")));
		[Export ("crashReportEnabled")]
		bool CrashReportEnabled { get; set; }

		// @property (readonly, nonatomic) NSString * identifier;
		[Export ("identifier")]
		string Identifier { get; }
	}

	// @interface AMapNaviConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface AMapNaviConfig
	{
		// @property (copy, nonatomic) NSString * appScheme;
		[Export ("appScheme")]
		string AppScheme { get; set; }

		// @property (copy, nonatomic) NSString * appName;
		[Export ("appName")]
		string AppName { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D destination;
		[Export ("destination", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Destination { get; set; }

		// @property (assign, nonatomic) AMapDrivingStrategy strategy;
		[Export ("strategy", ArgumentSemantic.Assign)]
		AMapDrivingStrategy Strategy { get; set; }
	}

	// @interface AMapRouteConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface AMapRouteConfig
	{
		// @property (copy, nonatomic) NSString * appScheme;
		[Export ("appScheme")]
		string AppScheme { get; set; }

		// @property (copy, nonatomic) NSString * appName;
		[Export ("appName")]
		string AppName { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D startCoordinate;
		[Export ("startCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D StartCoordinate { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D destinationCoordinate;
		[Export ("destinationCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D DestinationCoordinate { get; set; }

		// @property (assign, nonatomic) AMapDrivingStrategy drivingStrategy;
		[Export ("drivingStrategy", ArgumentSemantic.Assign)]
		AMapDrivingStrategy DrivingStrategy { get; set; }

		// @property (assign, nonatomic) AMapTransitStrategy transitStrategy;
		[Export ("transitStrategy", ArgumentSemantic.Assign)]
		AMapTransitStrategy TransitStrategy { get; set; }

		// @property (assign, nonatomic) AMapRouteSearchType routeType;
		[Export ("routeType", ArgumentSemantic.Assign)]
		AMapRouteSearchType RouteType { get; set; }
	}

	// @interface AMapPOIConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface AMapPOIConfig
	{
		// @property (copy, nonatomic) NSString * appScheme;
		[Export ("appScheme")]
		string AppScheme { get; set; }

		// @property (copy, nonatomic) NSString * appName;
		[Export ("appName")]
		string AppName { get; set; }

		// @property (copy, nonatomic) NSString * keywords;
		[Export ("keywords")]
		string Keywords { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D leftTopCoordinate;
		[Export ("leftTopCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D LeftTopCoordinate { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D rightBottomCoordinate;
		[Export ("rightBottomCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D RightBottomCoordinate { get; set; }
	}

	// @interface AMapURLSearch : NSObject
	[BaseType (typeof(NSObject))]
	interface AMapURLSearch
	{
		// +(void)getLatestAMapApp;
		[Static]
		[Export ("getLatestAMapApp")]
		void GetLatestAMapApp ();

		// +(BOOL)openAMapNavigation:(AMapNaviConfig *)config;
		[Static]
		[Export ("openAMapNavigation:")]
		bool OpenAMapNavigation (AMapNaviConfig config);

		// +(BOOL)openAMapRouteSearch:(AMapRouteConfig *)config;
		[Static]
		[Export ("openAMapRouteSearch:")]
		bool OpenAMapRouteSearch (AMapRouteConfig config);

		// +(BOOL)openAMapPOISearch:(AMapPOIConfig *)config;
		[Static]
		[Export ("openAMapPOISearch:")]
		bool OpenAMapPOISearch (AMapPOIConfig config);
	}


}
