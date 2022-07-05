using System;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using Foundation;
using iOS.AMap._3D;
using iOS.AMap.Foundation;
using ObjCRuntime;
using UIKit;

namespace iOS.AMap._3D
{

	[Static]
	//  [Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const MAMapKitVersion;
		[Field ("MAMapKitVersion", "__Internal")]
		NSString MAMapKitVersion { get; }

		// extern NSString *const MAMapKitName;
		[Field ("MAMapKitName", "__Internal")]
		NSString MAMapKitName { get; }
		// extern const MAMapSize MAMapSizeWorld;
		[Field ("MAMapSizeWorld", "__Internal")]
		IntPtr MAMapSizeWorld { get; }

		// extern const MAMapRect MAMapRectWorld;
		[Field ("MAMapRectWorld", "__Internal")]
		IntPtr MAMapRectWorld { get; }

		// extern const MAMapRect MAMapRectNull;
		[Field ("MAMapRectNull", "__Internal")]
		IntPtr MAMapRectNull { get; }

		// extern const MAMapRect MAMapRectZero;
		[Field ("MAMapRectZero", "__Internal")]
		IntPtr MAMapRectZero { get; }
		// extern NSString *const kMAMapLayerCenterMapPointKey;
		[Field ("kMAMapLayerCenterMapPointKey", "__Internal")]
		NSString kMAMapLayerCenterMapPointKey { get; }

		// extern NSString *const kMAMapLayerZoomLevelKey;
		[Field ("kMAMapLayerZoomLevelKey", "__Internal")]
		NSString kMAMapLayerZoomLevelKey { get; }

		// extern NSString *const kMAMapLayerRotationDegreeKey;
		[Field ("kMAMapLayerRotationDegreeKey", "__Internal")]
		NSString kMAMapLayerRotationDegreeKey { get; }

		// extern NSString *const kMAMapLayerCameraDegreeKey;
		[Field ("kMAMapLayerCameraDegreeKey", "__Internal")]
		NSString kMAMapLayerCameraDegreeKey { get; }
		// extern NSString *const MAOfflineMapErrorDomain;
		[Field ("MAOfflineMapErrorDomain", "__Internal")]
		NSString MAOfflineMapErrorDomain { get; }
		// extern NSString *const MAOfflineMapDownloadReceivedSizeKey;
		[Field ("MAOfflineMapDownloadReceivedSizeKey", "__Internal")]
		NSString MAOfflineMapDownloadReceivedSizeKey { get; }

		// extern NSString *const MAOfflineMapDownloadExpectedSizeKey;
		[Field ("MAOfflineMapDownloadExpectedSizeKey", "__Internal")]
		NSString MAOfflineMapDownloadExpectedSizeKey { get; }
	}

	// typedef void (^AMapTileProjectionBlock)(int, int, int, int, int, int);
	// delegate void AMapTileProjectionBlock (int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

	// @interface NSValueMAGeometryExtensions (NSValue)
	[Protocol]
	[BaseType (typeof(NSValue))]
	interface NSValue_NSValueMAGeometryExtensions
	{
		// +(NSValue *)valueWithMAMapPoint:(MAMapPoint)mapPoint;
		[Static]
		[Export ("valueWithMAMapPoint:")]
		NSValue ValueWithMAMapPoint (MAMapPoint mapPoint);

		// +(NSValue *)valueWithMAMapSize:(MAMapSize)mapSize;
		[Static]
		[Export ("valueWithMAMapSize:")]
		NSValue ValueWithMAMapSize (MAMapSize mapSize);

		// +(NSValue *)valueWithMAMapRect:(MAMapRect)mapRect;
		[Static]
		[Export ("valueWithMAMapRect:")]
		NSValue ValueWithMAMapRect (MAMapRect mapRect);

		// +(NSValue *)valueWithMACoordinate:(CLLocationCoordinate2D)coordinate;
		[Static]
		[Export ("valueWithMACoordinate:")]
		NSValue ValueWithMACoordinate (CLLocationCoordinate2D coordinate);

		// -(MAMapPoint)MAMapPointValue;
		[Export ("MAMapPointValue")]
		// [Verify (MethodToProperty)]
		MAMapPoint MAMapPointValue { get; }

		// -(MAMapSize)MAMapSizeValue;
		[Export ("MAMapSizeValue")]
		// [Verify (MethodToProperty)]
		MAMapSize MAMapSizeValue { get; }

		// -(MAMapRect)MAMapRectValue;
		[Export ("MAMapRectValue")]
		// [Verify (MethodToProperty)]
		MAMapRect MAMapRectValue { get; }

		// -(CLLocationCoordinate2D)MACoordinateValue;
		[Export ("MACoordinateValue")]
		// [Verify (MethodToProperty)]
		CLLocationCoordinate2D MACoordinateValue { get; }
	}

	// @protocol MAAnnotation <NSObject>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/
	[Protocol,Model]
	[BaseType (typeof(NSObject))]
	interface MAAnnotation
	{
		// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
		[Abstract]
		[Export ("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }

		// @optional @property (copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; set; }

		// @optional @property (copy, nonatomic) NSString * subtitle;
		[Export ("subtitle")]
		string Subtitle { get; set; }

		// @optional -(void)setCoordinate:(CLLocationCoordinate2D)newCoordinate;
		// [Export ("setCoordinate:")]
		// void SetCoordinate1 (CLLocationCoordinate2D newCoordinate);
	}

	// @protocol MAAnimatableAnnotation <NSObject>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface MAAnimatableAnnotation
	{
		// @required -(void)step:(CGFloat)timeDelta;
		[Abstract]
		[Export ("step:")]
		void Step (nfloat timeDelta);

		// @required -(BOOL)isAnimationFinished;
		[Abstract]
		[Export ("isAnimationFinished")]
		// [Verify (MethodToProperty)]
		bool IsAnimationFinished { get; }

		// @required -(BOOL)shouldAnimationStart;
		[Abstract]
		[Export ("shouldAnimationStart")]
		// [Verify (MethodToProperty)]
		bool ShouldAnimationStart { get; }

		// @optional -(CLLocationDirection)rotateDegree;
		[Export ("rotateDegree")]
		// [Verify (MethodToProperty)]
		double RotateDegree { get; }
	}

	// @protocol MAOverlay <MAAnnotation>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/[Protocol,Model]
	[BaseType(typeof(MAAnnotation))]
	interface MAOverlay 
	{
		// @required -(CLLocationCoordinate2D)coordinate;
		[Abstract]
		[Export ("coordinate")]
		// [Verify (MethodToProperty)]
		CLLocationCoordinate2D Coordinate { get; }

		// @required -(MAMapRect)boundingMapRect;
		[Abstract]
		[Export ("boundingMapRect")]
		// [Verify (MethodToProperty)]
		MAMapRect BoundingMapRect { get; }
	}

	// @interface MAOverlayRenderer : NSObject
	[BaseType (typeof(NSObject))]
	interface MAOverlayRenderer
	{
		[Wrap ("WeakRendererDelegate")]
		IntPtr RendererDelegate { get; set; }

		// @property (nonatomic, weak) id<MAOverlayRenderDelegate> rendererDelegate;
		[NullAllowed, Export ("rendererDelegate", ArgumentSemantic.Weak)]
        IntPtr WeakRendererDelegate { get; set; }

		// @property (readonly, retain, nonatomic) id<MAOverlay> overlay;
		[Export ("overlay", ArgumentSemantic.Retain)]
		MAOverlay Overlay { get; }

		// @property (nonatomic, strong) UIImage * strokeImage;
		[Export ("strokeImage", ArgumentSemantic.Strong)]
		UIImage StrokeImage { get; set; }

		// @property (readonly, nonatomic) GLuint strokeTextureID __attribute__((deprecated("已废弃，since 7.9.0")));
		[Export ("strokeTextureID")]
		uint StrokeTextureID { get; }

		// @property (assign, nonatomic) CGFloat alpha;
		[Export ("alpha")]
		nfloat Alpha { get; set; }

		// @property (readonly, nonatomic) CGFloat contentScale;
		[Export ("contentScale")]
		nfloat ContentScale { get; }

		// -(instancetype)initWithOverlay:(id<MAOverlay>)overlay;
		[Export ("initWithOverlay:")]
		NativeHandle Constructor (MAOverlay overlay);

		// -(float *)getViewMatrix;
		[Export ("getViewMatrix")]
		// [Verify (MethodToProperty)]
		unsafe IntPtr ViewMatrix { get; }

		// -(float *)getProjectionMatrix;
		[Export ("getProjectionMatrix")]
		// [Verify (MethodToProperty)]
		unsafe IntPtr ProjectionMatrix { get; }

		// -(MAMapPoint)getOffsetPoint;
		[Export ("getOffsetPoint")]
		// [Verify (MethodToProperty)]
		MAMapPoint OffsetPoint { get; }

		// -(id<MTLRenderCommandEncoder>)getCommandEncoder;
		[Export ("getCommandEncoder")]
		// [Verify (MethodToProperty)]
		IntPtr CommandEncoder { get; }

		// -(CGFloat)getMapZoomLevel;
		[Export ("getMapZoomLevel")]
		// [Verify (MethodToProperty)]
		nfloat MapZoomLevel { get; }

		// -(CGPoint)glPointForMapPoint:(MAMapPoint)mapPoint;
		[Export ("glPointForMapPoint:")]
		CGPoint GlPointForMapPoint (MAMapPoint mapPoint);

		// -(CGPoint *)glPointsForMapPoints:(MAMapPoint *)mapPoints count:(NSUInteger)count;
		[Export ("glPointsForMapPoints:count:")]
		unsafe CGPoint GlPointsForMapPoints (MAMapPoint mapPoints, nuint count);

		// -(CGFloat)glWidthForWindowWidth:(CGFloat)windowWidth;
		[Export ("glWidthForWindowWidth:")]
		nfloat GlWidthForWindowWidth (nfloat windowWidth);

		// -(void)glRender;
		[Export ("glRender")]
		void GlRender ();

		// -(GLuint)loadTexture:(UIImage *)textureImage __attribute__((deprecated("已废弃，since 7.9.0")));
		[Export ("loadTexture:")]
		uint LoadTexture (UIImage textureImage);

		// -(void)deleteTexture:(GLuint)textureId __attribute__((deprecated("已废弃，since 7.9.0")));
		[Export ("deleteTexture:")]
		void DeleteTexture (uint textureId);

		// -(void)setNeedsUpdate;
		[Export ("setNeedsUpdate")]
		void SetNeedsUpdate ();
	}

	// @interface MACustomCalloutView : UIView
	[BaseType (typeof(UIView))]
	interface MACustomCalloutView
	{
		// @property (readonly, nonatomic, strong) UIView * customView;
		[Export ("customView", ArgumentSemantic.Strong)]
		UIView CustomView { get; }

		// @property (nonatomic, strong) id userData;
		[Export ("userData", ArgumentSemantic.Strong)]
		NSObject UserData { get; set; }

		// -(id)initWithCustomView:(UIView *)customView;
		[Export ("initWithCustomView:")]
		NativeHandle Constructor (UIView customView);
	}

	// @interface MAAnnotationView : UIView
	[BaseType (typeof(UIView))]
	interface MAAnnotationView
	{
		// @property (readonly, copy, nonatomic) NSString * reuseIdentifier;
		[Export ("reuseIdentifier")]
		string ReuseIdentifier { get; }

		// @property (assign, nonatomic) NSInteger zIndex;
		[Export ("zIndex")]
		nint ZIndex { get; set; }

		// @property (nonatomic, strong) id<MAAnnotation> annotation;
		[Export ("annotation", ArgumentSemantic.Strong)]
		MAAnnotation Annotation { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (readonly, nonatomic, strong) UIImageView * imageView;
		[Export ("imageView", ArgumentSemantic.Strong)]
		UIImageView ImageView { get; }

		// @property (nonatomic, strong) MACustomCalloutView * customCalloutView;
		[Export ("customCalloutView", ArgumentSemantic.Strong)]
		MACustomCalloutView CustomCalloutView { get; set; }

		// @property (nonatomic) CGPoint centerOffset;
		[Export ("centerOffset", ArgumentSemantic.Assign)]
		CGPoint CenterOffset { get; set; }

		// @property (nonatomic) CGPoint calloutOffset;
		[Export ("calloutOffset", ArgumentSemantic.Assign)]
		CGPoint CalloutOffset { get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }

		// @property (nonatomic) BOOL canShowCallout;
		[Export ("canShowCallout")]
		bool CanShowCallout { get; set; }

		// @property (nonatomic, strong) UIView * leftCalloutAccessoryView;
		[Export ("leftCalloutAccessoryView", ArgumentSemantic.Strong)]
		UIView LeftCalloutAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * rightCalloutAccessoryView;
		[Export ("rightCalloutAccessoryView", ArgumentSemantic.Strong)]
		UIView RightCalloutAccessoryView { get; set; }

		// @property (getter = isDraggable, nonatomic) BOOL draggable;
		[Export ("draggable")]
		bool Draggable { [Bind ("isDraggable")] get; set; }

		// @property (nonatomic) MAAnnotationViewDragState dragState;
		[Export ("dragState", ArgumentSemantic.Assign)]
		MAAnnotationViewDragState DragState { get; set; }

		// @property (nonatomic) BOOL canAdjustPositon;
		[Export ("canAdjustPositon")]
		bool CanAdjustPositon { get; set; }

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);

		// -(id)initWithAnnotation:(id<MAAnnotation>)annotation reuseIdentifier:(NSString *)reuseIdentifier;
		[Export ("initWithAnnotation:reuseIdentifier:")]
		NativeHandle Constructor (MAAnnotation annotation, string reuseIdentifier);

		// -(void)prepareForReuse;
		[Export ("prepareForReuse")]
		void PrepareForReuse ();

		// -(void)setDragState:(MAAnnotationViewDragState)newDragState animated:(BOOL)animated;
		[Export ("setDragState:animated:")]
		void SetDragState (MAAnnotationViewDragState newDragState, bool animated);
	}

	// @interface MABaseOverlay : NSObject <MAOverlay>
	[BaseType (typeof(NSObject))]
	interface MABaseOverlay : MAOverlay
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) MAMapRect boundingMapRect;
		[Export ("boundingMapRect", ArgumentSemantic.Assign)]
		MAMapRect BoundingMapRect { get; set; }
	}

	// @interface MAShape : MABaseOverlay <MAAnnotation>
	[BaseType (typeof(MABaseOverlay))]
	interface MAShape : MAAnnotation
	{
		// @property (copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * subtitle;
		[Export ("subtitle")]
		string Subtitle { get; set; }
	}

	// @interface MACircle : MAShape <MAOverlay>
	[BaseType (typeof(MAShape))]
	interface MACircle : MAOverlay
	{
		// @property (nonatomic, strong) NSArray<id<MAOverlay>> * hollowShapes;
		[Export ("hollowShapes", ArgumentSemantic.Strong)]
		MAOverlay[] HollowShapes { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) CLLocationDistance radius;
		[Export ("radius")]
		double Radius { get; set; }

		// +(instancetype)circleWithCenterCoordinate:(CLLocationCoordinate2D)coord radius:(CLLocationDistance)radius;
		[Static]
		[Export ("circleWithCenterCoordinate:radius:")]
		MACircle CircleWithCenterCoordinate (CLLocationCoordinate2D coord, double radius);

		// +(instancetype)circleWithMapRect:(MAMapRect)mapRect;
		[Static]
		[Export ("circleWithMapRect:")]
		MACircle CircleWithMapRect (MAMapRect mapRect);

		// -(BOOL)setCircleWithCenterCoordinate:(CLLocationCoordinate2D)coord radius:(CLLocationDistance)radius;
		[Export ("setCircleWithCenterCoordinate:radius:")]
		bool SetCircleWithCenterCoordinate (CLLocationCoordinate2D coord, double radius);
	}

	// @interface MAPointAnnotation : MAShape
	[BaseType (typeof(MAShape))]
	interface MAPointAnnotation
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (getter = isLockedToScreen, assign, nonatomic) BOOL lockedToScreen;
		[Export ("lockedToScreen")]
		bool LockedToScreen { [Bind ("isLockedToScreen")] get; set; }

		// @property (assign, nonatomic) CGPoint lockedScreenPoint;
		[Export ("lockedScreenPoint", ArgumentSemantic.Assign)]
		CGPoint LockedScreenPoint { get; set; }
	}

	// @interface MAAnnotationMoveAnimation : NSObject
	[BaseType (typeof(NSObject))]
	interface MAAnnotationMoveAnimation
	{
		// -(NSString *)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }

		// -(CLLocationCoordinate2D *)coordinates;
		[Export ("coordinates")]
		// [Verify (MethodToProperty)]
		unsafe CLLocationCoordinate2D Coordinates { get; }

		// -(NSUInteger)count;
		[Export ("count")]
		// [Verify (MethodToProperty)]
		nuint Count { get; }

		// -(CGFloat)duration;
		[Export ("duration")]
		// [Verify (MethodToProperty)]
		nfloat Duration { get; }

		// -(CGFloat)elapsedTime;
		[Export ("elapsedTime")]
		// [Verify (MethodToProperty)]
		nfloat ElapsedTime { get; }

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// -(BOOL)isCancelled;
		[Export ("isCancelled")]
		// [Verify (MethodToProperty)]
		bool IsCancelled { get; }

		// -(NSInteger)passedPointCount;
		[Export ("passedPointCount")]
		// [Verify (MethodToProperty)]
		nint PassedPointCount { get; }
	}

	// @interface MAAnimatedAnnotation : MAPointAnnotation <MAAnimatableAnnotation>
	[BaseType (typeof(MAPointAnnotation))]
	interface MAAnimatedAnnotation : MAAnimatableAnnotation
	{
		// @property (assign, nonatomic) CLLocationDirection movingDirection;
		[Export ("movingDirection")]
		double MovingDirection { get; set; }

		// -(MAAnnotationMoveAnimation *)addMoveAnimationWithKeyCoordinates:(CLLocationCoordinate2D *)coordinates count:(NSUInteger)count withDuration:(CGFloat)duration withName:(NSString *)name completeCallback:(void (^)(BOOL))completeCallback;
		[Export ("addMoveAnimationWithKeyCoordinates:count:withDuration:withName:completeCallback:")]
		unsafe MAAnnotationMoveAnimation AddMoveAnimationWithKeyCoordinates (CLLocationCoordinate2D coordinates, nuint count, nfloat duration, string name, Action<bool> completeCallback);

		// -(MAAnnotationMoveAnimation *)addMoveAnimationWithKeyCoordinates:(CLLocationCoordinate2D *)coordinates count:(NSUInteger)count withDuration:(CGFloat)duration withName:(NSString *)name completeCallback:(void (^)(BOOL))completeCallback stepCallback:(void (^)(MAAnnotationMoveAnimation *))stepCallback;
		[Export ("addMoveAnimationWithKeyCoordinates:count:withDuration:withName:completeCallback:stepCallback:")]
		unsafe MAAnnotationMoveAnimation AddMoveAnimationWithKeyCoordinates (CLLocationCoordinate2D coordinates, nuint count, nfloat duration, string name, Action<bool> completeCallback, Action<MAAnnotationMoveAnimation> stepCallback);

		// -(NSArray<MAAnnotationMoveAnimation *> *)allMoveAnimations;
		[Export ("allMoveAnimations")]
		// [Verify (MethodToProperty)]
		MAAnnotationMoveAnimation[] AllMoveAnimations { get; }

		// -(void)setNeedsStart;
		[Export ("setNeedsStart")]
		void SetNeedsStart ();
	}

	// @interface MAUserLocation : MAAnimatedAnnotation
	[BaseType (typeof(MAAnimatedAnnotation))]
	interface MAUserLocation
	{
		// @property (readonly, getter = isUpdating, nonatomic) BOOL updating;
		[Export ("updating")]
		bool Updating { [Bind ("isUpdating")] get; }

		// @property (readonly, nonatomic, strong) CLLocation * location;
		[Export ("location", ArgumentSemantic.Strong)]
		CLLocation Location { get; }

		// @property (readonly, nonatomic, strong) CLHeading * heading;
		[Export ("heading", ArgumentSemantic.Strong)]
		CLHeading Heading { get; }
	}

	// @interface MAMapStatus : NSObject
	[BaseType (typeof(NSObject))]
	interface MAMapStatus
	{
		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export ("centerCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D CenterCoordinate { get; set; }

		// @property (nonatomic) CGFloat zoomLevel;
		[Export ("zoomLevel")]
		nfloat ZoomLevel { get; set; }

		// @property (nonatomic) CGFloat rotationDegree;
		[Export ("rotationDegree")]
		nfloat RotationDegree { get; set; }

		// @property (nonatomic) CGFloat cameraDegree;
		[Export ("cameraDegree")]
		nfloat CameraDegree { get; set; }

		// @property (nonatomic) CGPoint screenAnchor;
		[Export ("screenAnchor", ArgumentSemantic.Assign)]
		CGPoint ScreenAnchor { get; set; }

		// +(instancetype)statusWithCenterCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel rotationDegree:(CGFloat)rotationDegree cameraDegree:(CGFloat)cameraDegree screenAnchor:(CGPoint)screenAnchor;
		[Static]
		[Export ("statusWithCenterCoordinate:zoomLevel:rotationDegree:cameraDegree:screenAnchor:")]
		MAMapStatus StatusWithCenterCoordinate (CLLocationCoordinate2D coordinate, nfloat zoomLevel, nfloat rotationDegree, nfloat cameraDegree, CGPoint screenAnchor);

		// -(id)initWithCenterCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel rotationDegree:(CGFloat)rotationDegree cameraDegree:(CGFloat)cameraDegree screenAnchor:(CGPoint)screenAnchor;
		[Export ("initWithCenterCoordinate:zoomLevel:rotationDegree:cameraDegree:screenAnchor:")]
		NativeHandle Constructor (CLLocationCoordinate2D coordinate, nfloat zoomLevel, nfloat rotationDegree, nfloat cameraDegree, CGPoint screenAnchor);
	}

	// @interface MAIndoorFloorInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface MAIndoorFloorInfo
	{
		// @property (readonly, nonatomic) NSString * floorName;
		[Export ("floorName")]
		string FloorName { get; }

		// @property (readonly, nonatomic) int floorIndex;
		[Export ("floorIndex")]
		int FloorIndex { get; }

		// @property (readonly, nonatomic) NSString * floorNona;
		[Export ("floorNona")]
		string FloorNona { get; }

		// @property (readonly, nonatomic) BOOL isPark;
		[Export ("isPark")]
		bool IsPark { get; }
	}

	// @interface MAIndoorInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface MAIndoorInfo
	{
		// @property (readonly, nonatomic) NSString * cnName;
		[Export ("cnName")]
		string CnName { get; }

		// @property (readonly, nonatomic) NSString * enName;
		[Export ("enName")]
		string EnName { get; }

		// @property (readonly, nonatomic) NSString * poiID;
		[Export ("poiID")]
		string PoiID { get; }

		// @property (readonly, nonatomic) NSString * buildingType;
		[Export ("buildingType")]
		string BuildingType { get; }

		// @property (readonly, nonatomic) int activeFloorIndex;
		[Export ("activeFloorIndex")]
		int ActiveFloorIndex { get; }

		// @property (readonly, nonatomic) int activeFloorInfoIndex;
		[Export ("activeFloorInfoIndex")]
		int ActiveFloorInfoIndex { get; }

		// @property (readonly, nonatomic) NSArray * floorInfo;
		[Export ("floorInfo")]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] FloorInfo { get; }

		// @property (readonly, nonatomic) int numberOfFloor;
		[Export ("numberOfFloor")]
		int NumberOfFloor { get; }

		// @property (readonly, nonatomic) int numberOfParkFloor;
		[Export ("numberOfParkFloor")]
		int NumberOfParkFloor { get; }
	}

	// @interface MAUserLocationRepresentation : NSObject
	[BaseType (typeof(NSObject))]
	interface MAUserLocationRepresentation
	{
		// @property (assign, nonatomic) BOOL showsAccuracyRing;
		[Export ("showsAccuracyRing")]
		bool ShowsAccuracyRing { get; set; }

		// @property (assign, nonatomic) BOOL showsHeadingIndicator;
		[Export ("showsHeadingIndicator")]
		bool ShowsHeadingIndicator { get; set; }

		// @property (nonatomic, strong) UIColor * fillColor;
		[Export ("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @property (nonatomic, strong) UIColor * strokeColor;
		[Export ("strokeColor", ArgumentSemantic.Strong)]
		UIColor StrokeColor { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (nonatomic, strong) UIColor * locationDotBgColor;
		[Export ("locationDotBgColor", ArgumentSemantic.Strong)]
		UIColor LocationDotBgColor { get; set; }

		// @property (nonatomic, strong) UIColor * locationDotFillColor;
		[Export ("locationDotFillColor", ArgumentSemantic.Strong)]
		UIColor LocationDotFillColor { get; set; }

		// @property (assign, nonatomic) BOOL enablePulseAnnimation;
		[Export ("enablePulseAnnimation")]
		bool EnablePulseAnnimation { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }
	}

	// @interface MAMapCustomStyleOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface MAMapCustomStyleOptions
	{
		// @property (nonatomic, strong) NSData * styleData;
		[Export ("styleData", ArgumentSemantic.Strong)]
		NSData StyleData { get; set; }

		// @property (nonatomic, strong) NSString * styleDataOverseaPath;
		[Export ("styleDataOverseaPath", ArgumentSemantic.Strong)]
		string StyleDataOverseaPath { get; set; }

		// @property (nonatomic, strong) NSString * styleId;
		[Export ("styleId", ArgumentSemantic.Strong)]
		string StyleId { get; set; }

		// @property (nonatomic, strong) NSData * styleTextureData;
		[Export ("styleTextureData", ArgumentSemantic.Strong)]
		NSData StyleTextureData { get; set; }

		// @property (nonatomic, strong) NSData * styleExtraData;
		[Export ("styleExtraData", ArgumentSemantic.Strong)]
		NSData StyleExtraData { get; set; }
	}


	// @interface MAMapView : UIView
	[BaseType (typeof(UIView))]
	interface MAMapView
	{
		// @property (assign, nonatomic, class) BOOL metalEnabled;
		[Static]
		[Export ("metalEnabled")]
		bool MetalEnabled { get; set; }

		// @property (assign, nonatomic, class) BOOL terrainEnabled;
		[Static]
		[Export ("terrainEnabled")]
		bool TerrainEnabled { get; set; }

		[Wrap ("WeakDelegate")]
		MAMapViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MAMapViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) MAMapType mapType;
		[Export ("mapType", ArgumentSemantic.Assign)]
		MAMapType MapType { get; set; }

		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export ("centerCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D CenterCoordinate { get; set; }

		// @property (nonatomic) MACoordinateRegion region;
		[Export ("region", ArgumentSemantic.Assign)]
		MACoordinateRegion Region { get; set; }

		// @property (nonatomic) MAMapRect visibleMapRect;
		[Export ("visibleMapRect", ArgumentSemantic.Assign)]
		MAMapRect VisibleMapRect { get; set; }

		// @property (assign, nonatomic) MACoordinateRegion limitRegion;
		[Export ("limitRegion", ArgumentSemantic.Assign)]
		MACoordinateRegion LimitRegion { get; set; }

		// @property (assign, nonatomic) MAMapRect limitMapRect;
		[Export ("limitMapRect", ArgumentSemantic.Assign)]
		MAMapRect LimitMapRect { get; set; }

		// @property (nonatomic) CGFloat zoomLevel;
		[Export ("zoomLevel")]
		nfloat ZoomLevel { get; set; }

		// @property (nonatomic) CGFloat minZoomLevel;
		[Export ("minZoomLevel")]
		nfloat MinZoomLevel { get; set; }

		// @property (nonatomic) CGFloat maxZoomLevel;
		[Export ("maxZoomLevel")]
		nfloat MaxZoomLevel { get; set; }

		// @property (nonatomic) CGFloat rotationDegree;
		[Export ("rotationDegree")]
		nfloat RotationDegree { get; set; }

		// @property (nonatomic) CGFloat cameraDegree;
		[Export ("cameraDegree")]
		nfloat CameraDegree { get; set; }

		// @property (assign, nonatomic) BOOL zoomingInPivotsAroundAnchorPoint;
		[Export ("zoomingInPivotsAroundAnchorPoint")]
		bool ZoomingInPivotsAroundAnchorPoint { get; set; }

		// @property (getter = isZoomEnabled, nonatomic) BOOL zoomEnabled;
		[Export ("zoomEnabled")]
		bool ZoomEnabled { [Bind ("isZoomEnabled")] get; set; }

		// @property (getter = isScrollEnabled, nonatomic) BOOL scrollEnabled;
		[Export ("scrollEnabled")]
		bool ScrollEnabled { [Bind ("isScrollEnabled")] get; set; }

		// @property (getter = isRotateEnabled, nonatomic) BOOL rotateEnabled;
		[Export ("rotateEnabled")]
		bool RotateEnabled { [Bind ("isRotateEnabled")] get; set; }

		// @property (getter = isRotateCameraEnabled, nonatomic) BOOL rotateCameraEnabled;
		[Export ("rotateCameraEnabled")]
		bool RotateCameraEnabled { [Bind ("isRotateCameraEnabled")] get; set; }

		// @property (getter = isShowsBuildings, nonatomic) BOOL showsBuildings;
		[Export ("showsBuildings")]
		bool ShowsBuildings { [Bind ("isShowsBuildings")] get; set; }

		// @property (getter = isShowsLabels, assign, nonatomic) BOOL showsLabels;
		[Export ("showsLabels")]
		bool ShowsLabels { [Bind ("isShowsLabels")] get; set; }

		// @property (getter = isShowTraffic, nonatomic) BOOL showTraffic;
		[Export ("showTraffic")]
		bool ShowTraffic { [Bind ("isShowTraffic")] get; set; }

		// @property (copy, nonatomic) NSDictionary<NSNumber *,UIColor *> * trafficStatus __attribute__((deprecated("已废弃 since 7.8.0")));
		[Export ("trafficStatus", ArgumentSemantic.Copy)]
		NSDictionary<NSNumber, UIColor> TrafficStatus { get; set; }

		// @property (assign, nonatomic) BOOL touchPOIEnabled;
		[Export ("touchPOIEnabled")]
		bool TouchPOIEnabled { get; set; }

		// @property (assign, nonatomic) BOOL showsCompass;
		[Export ("showsCompass")]
		bool ShowsCompass { get; set; }

		// @property (assign, nonatomic) CGPoint compassOrigin;
		[Export ("compassOrigin", ArgumentSemantic.Assign)]
		CGPoint CompassOrigin { get; set; }

		// @property (readonly, nonatomic) CGSize compassSize;
		[Export ("compassSize")]
		CGSize CompassSize { get; }

		// @property (assign, nonatomic) BOOL showsScale;
		[Export ("showsScale")]
		bool ShowsScale { get; set; }

		// @property (assign, nonatomic) CGPoint scaleOrigin;
		[Export ("scaleOrigin", ArgumentSemantic.Assign)]
		CGPoint ScaleOrigin { get; set; }

		// @property (readonly, nonatomic) CGSize scaleSize;
		[Export ("scaleSize")]
		CGSize ScaleSize { get; }

		// @property (assign, nonatomic) CGPoint logoCenter;
		[Export ("logoCenter", ArgumentSemantic.Assign)]
		CGPoint LogoCenter { get; set; }

		// @property (readonly, nonatomic) CGSize logoSize;
		[Export ("logoSize")]
		CGSize LogoSize { get; }

		// @property (readonly, nonatomic) double metersPerPointForCurrentZoom;
		[Export ("metersPerPointForCurrentZoom")]
		double MetersPerPointForCurrentZoom { get; }

		// @property (readonly, nonatomic) BOOL isAbroad;
		[Export ("isAbroad")]
		bool IsAbroad { get; }

		// @property (assign, nonatomic) NSUInteger maxRenderFrame;
		[Export ("maxRenderFrame")]
		nuint MaxRenderFrame { get; set; }

		// @property (assign, nonatomic) BOOL isAllowDecreaseFrame;
		[Export ("isAllowDecreaseFrame")]
		bool IsAllowDecreaseFrame { get; set; }

		// @property (assign, nonatomic) BOOL openGLESDisabled __attribute__((deprecated("已废弃，since 7.9.0，请使用renderringDisabled属性")));
		[Export ("openGLESDisabled")]
		bool OpenGLESDisabled { get; set; }

		// @property (assign, nonatomic) BOOL renderringDisabled;
		[Export ("renderringDisabled")]
		bool RenderringDisabled { get; set; }

		// @property (assign, nonatomic) CGPoint screenAnchor;
		[Export ("screenAnchor", ArgumentSemantic.Assign)]
		CGPoint ScreenAnchor { get; set; }

		// @property (copy, nonatomic) NSRunLoopMode runLoopMode;
		[Export ("runLoopMode")]
		string RunLoopMode { get; set; }

		// @property (getter = isShowsWorldMap, nonatomic) NSNumber * showsWorldMap;
		[Export ("showsWorldMap", ArgumentSemantic.Assign)]
		NSNumber ShowsWorldMap { [Bind ("isShowsWorldMap")] get; set; }

		// @property (nonatomic, strong) NSNumber * mapLanguage;
		[Export ("mapLanguage", ArgumentSemantic.Strong)]
		NSNumber MapLanguage { get; set; }

		// -(void)setRegion:(MACoordinateRegion)region animated:(BOOL)animated;
		[Export ("setRegion:animated:")]
		void SetRegion (MACoordinateRegion region, bool animated);

		// -(MACoordinateRegion)regionThatFits:(MACoordinateRegion)region;
		[Export ("regionThatFits:")]
		MACoordinateRegion RegionThatFits (MACoordinateRegion region);

		// -(void)setVisibleMapRect:(MAMapRect)mapRect animated:(BOOL)animated;
		[Export ("setVisibleMapRect:animated:")]
		void SetVisibleMapRect (MAMapRect mapRect, bool animated);

		// -(MAMapRect)mapRectThatFits:(MAMapRect)mapRect;
		[Export ("mapRectThatFits:")]
		MAMapRect MapRectThatFits (MAMapRect mapRect);

		// -(MAMapRect)mapRectThatFits:(MAMapRect)mapRect edgePadding:(UIEdgeInsets)insets;
		[Export ("mapRectThatFits:edgePadding:")]
		MAMapRect MapRectThatFits (MAMapRect mapRect, UIEdgeInsets insets);

		// -(void)setVisibleMapRect:(MAMapRect)mapRect edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export ("setVisibleMapRect:edgePadding:animated:")]
		void SetVisibleMapRect (MAMapRect mapRect, UIEdgeInsets insets, bool animated);

		// -(void)setVisibleMapRect:(MAMapRect)mapRect edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export ("setVisibleMapRect:edgePadding:animated:duration:")]
		void SetVisibleMapRect (MAMapRect mapRect, UIEdgeInsets insets, bool animated, double duration);

		// -(void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
		[Export ("setCenterCoordinate:animated:")]
		void SetCenterCoordinate (CLLocationCoordinate2D coordinate, bool animated);

		// -(void)setZoomLevel:(CGFloat)zoomLevel animated:(BOOL)animated;
		[Export ("setZoomLevel:animated:")]
		void SetZoomLevel (nfloat zoomLevel, bool animated);

		// -(void)setZoomLevel:(CGFloat)zoomLevel atPivot:(CGPoint)pivot animated:(BOOL)animated;
		[Export ("setZoomLevel:atPivot:animated:")]
		void SetZoomLevel (nfloat zoomLevel, CGPoint pivot, bool animated);

		// -(void)setRotationDegree:(CGFloat)rotationDegree animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export ("setRotationDegree:animated:duration:")]
		void SetRotationDegree (nfloat rotationDegree, bool animated, double duration);

		// -(void)setCameraDegree:(CGFloat)cameraDegree animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export ("setCameraDegree:animated:duration:")]
		void SetCameraDegree (nfloat cameraDegree, bool animated, double duration);

		// -(MAMapStatus *)getMapStatus;
		[Export ("getMapStatus")]
		// [Verify (MethodToProperty)]
		MAMapStatus MapStatus { get; }

		// -(void)setMapStatus:(MAMapStatus *)status animated:(BOOL)animated;
		[Export ("setMapStatus:animated:")]
		void SetMapStatus (MAMapStatus status, bool animated);

		// -(void)setMapStatus:(MAMapStatus *)status animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export ("setMapStatus:animated:duration:")]
		void SetMapStatus (MAMapStatus status, bool animated, double duration);

		// -(void)setCompassImage:(UIImage *)image;
		[Export ("setCompassImage:")]
		void SetCompassImage (UIImage image);

		// -(UIImage *)takeSnapshotInRect:(CGRect)rect __attribute__((deprecated("已废弃，请使用takeSnapshotInRect:withCompletionBlock:方法 since 6.0.0")));
		[Export ("takeSnapshotInRect:")]
		UIImage TakeSnapshotInRect (CGRect rect);

		// -(void)takeSnapshotInRect:(CGRect)rect withCompletionBlock:(void (^)(UIImage *, NSInteger))block;
		[Export ("takeSnapshotInRect:withCompletionBlock:")]
		void TakeSnapshotInRect (CGRect rect, Action<UIImage, nint> block);

		// -(void)takeSnapshotInRect:(CGRect)rect timeoutInterval:(NSTimeInterval)timeout completionBlock:(void (^)(UIImage *, NSInteger))block;
		[Export ("takeSnapshotInRect:timeoutInterval:completionBlock:")]
		void TakeSnapshotInRect (CGRect rect, double timeout, Action<UIImage, nint> block);

		// -(double)metersPerPointForZoomLevel:(CGFloat)zoomLevel;
		[Export ("metersPerPointForZoomLevel:")]
		double MetersPerPointForZoomLevel (nfloat zoomLevel);

		// -(CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(UIView *)view;
		[Export ("convertCoordinate:toPointToView:")]
		CGPoint ConvertCoordinate (CLLocationCoordinate2D coordinate, UIView view);

		// -(CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(UIView *)view;
		[Export ("convertPoint:toCoordinateFromView:")]
		CLLocationCoordinate2D ConvertPoint (CGPoint point, UIView view);

		// -(CGRect)convertRegion:(MACoordinateRegion)region toRectToView:(UIView *)view;
		[Export ("convertRegion:toRectToView:")]
		CGRect ConvertRegion (MACoordinateRegion region, UIView view);

		// -(MACoordinateRegion)convertRect:(CGRect)rect toRegionFromView:(UIView *)view;
		[Export ("convertRect:toRegionFromView:")]
		MACoordinateRegion ConvertRect (CGRect rect, UIView view);

		// -(void)reloadMap;
		[Export ("reloadMap")]
		void ReloadMap ();

		// -(void)clearDisk;
		[Export ("clearDisk")]
		void ClearDisk ();

		// -(void)reloadInternalTexture;
		[Export ("reloadInternalTexture")]
		void ReloadInternalTexture ();

		// -(NSString *)mapContentApprovalNumber;
		[Export ("mapContentApprovalNumber")]
		// [Verify (MethodToProperty)]
		string MapContentApprovalNumber { get; }

		// -(NSString *)satelliteImageApprovalNumber;
		[Export ("satelliteImageApprovalNumber")]
		// [Verify (MethodToProperty)]
		string SatelliteImageApprovalNumber { get; }

		// -(NSString *)terrainApprovalNumber;
		[Export ("terrainApprovalNumber")]
		// [Verify (MethodToProperty)]
		string TerrainApprovalNumber { get; }

		// -(void)addAnimationWith:(CAKeyframeAnimation *)mapCenterAnimation zoomAnimation:(CAKeyframeAnimation *)zoomAnimation rotateAnimation:(CAKeyframeAnimation *)rotateAnimation cameraDegreeAnimation:(CAKeyframeAnimation *)cameraDegreeAnimation;
		[Export ("addAnimationWith:zoomAnimation:rotateAnimation:cameraDegreeAnimation:")]
		void AddAnimationWith (CAKeyFrameAnimation mapCenterAnimation, CAKeyFrameAnimation zoomAnimation, CAKeyFrameAnimation rotateAnimation, CAKeyFrameAnimation cameraDegreeAnimation);

		// -(void)forceRefresh;
		[Export ("forceRefresh")]
		void ForceRefresh ();

		// -(void)setConstructingRoadEnable:(BOOL)enabled;
		[Export ("setConstructingRoadEnable:")]
		void SetConstructingRoadEnable (bool enabled);

		// +(void)updatePrivacyShow:(AMapPrivacyShowStatus)showStatus privacyInfo:(AMapPrivacyInfoStatus)containStatus;
		[Static]
		[Export ("updatePrivacyShow:privacyInfo:")]
		void UpdatePrivacyShow (AMapPrivacyShowStatus showStatus, AMapPrivacyInfoStatus containStatus);

		// +(void)updatePrivacyAgree:(AMapPrivacyAgreeStatus)agreeStatus;
		[Static]
		[Export ("updatePrivacyAgree:")]
		void UpdatePrivacyAgree (AMapPrivacyAgreeStatus agreeStatus);
	}

	// @interface Annotation (MAMapView)
	[Category]
	[BaseType (typeof(MAMapView))]
	interface MAMapView_Annotation
	{
		// @property (readonly, nonatomic) NSArray * annotations;
		[Export ("annotations")]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Annotations();

		// @property (copy, nonatomic) NSArray * selectedAnnotations;
		[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] SelectedAnnotations();

		// @property (readonly, nonatomic) CGRect annotationVisibleRect;
		[Export ("annotationVisibleRect")]
		CGRect AnnotationVisibleRect();

		// -(void)addAnnotation:(id<MAAnnotation>)annotation;
		[Export ("addAnnotation:")]
		void AddAnnotation (MAAnnotation annotation);

		// -(void)addAnnotations:(NSArray *)annotations;
		[Export ("addAnnotations:")]
		// [Verify (StronglyTypedNSArray)]
		void AddAnnotations (NSObject[] annotations);

		// -(void)removeAnnotation:(id<MAAnnotation>)annotation;
		[Export ("removeAnnotation:")]
		void RemoveAnnotation (MAAnnotation annotation);

		// -(void)removeAnnotations:(NSArray *)annotations;
		[Export ("removeAnnotations:")]
		// [Verify (StronglyTypedNSArray)]
		void RemoveAnnotations (NSObject[] annotations);

		// -(NSSet *)annotationsInMapRect:(MAMapRect)mapRect;
		[Export ("annotationsInMapRect:")]
		NSSet AnnotationsInMapRect (MAMapRect mapRect);

		// -(MAAnnotationView *)viewForAnnotation:(id<MAAnnotation>)annotation;
		[Export ("viewForAnnotation:")]
		MAAnnotationView ViewForAnnotation (MAAnnotation annotation);

		// -(MAAnnotationView *)dequeueReusableAnnotationViewWithIdentifier:(NSString *)identifier;
		[Export ("dequeueReusableAnnotationViewWithIdentifier:")]
		MAAnnotationView DequeueReusableAnnotationViewWithIdentifier (string identifier);

		// -(void)selectAnnotation:(id<MAAnnotation>)annotation animated:(BOOL)animated;
		[Export ("selectAnnotation:animated:")]
		void SelectAnnotation (MAAnnotation annotation, bool animated);

		// -(void)deselectAnnotation:(id<MAAnnotation>)annotation animated:(BOOL)animated;
		[Export ("deselectAnnotation:animated:")]
		void DeselectAnnotation (MAAnnotation annotation, bool animated);

		// -(void)showAnnotations:(NSArray *)annotations animated:(BOOL)animated;
		[Export ("showAnnotations:animated:")]
		// [Verify (StronglyTypedNSArray)]
		void ShowAnnotations (NSObject[] annotations, bool animated);

		// -(void)showAnnotations:(NSArray *)annotations edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export ("showAnnotations:edgePadding:animated:")]
		// [Verify (StronglyTypedNSArray)]
		void ShowAnnotations (NSObject[] annotations, UIEdgeInsets insets, bool animated);
	}

	// @interface UserLocation (MAMapView)
	[Category]
	[BaseType (typeof(MAMapView))]
	interface MAMapView_UserLocation
	{
		// @property (nonatomic) BOOL showsUserLocation;
		[Export ("showsUserLocation")]
		bool ShowsUserLocation();

		[Export("setShowsUserLocation:")]
		void SetShowsUserLocation(bool showsUserLocation);

		// @property (readonly, nonatomic) MAUserLocation * userLocation;
		[Export ("userLocation")]
		MAUserLocation UserLocation();

		// @property (nonatomic) BOOL customizeUserLocationAccuracyCircleRepresentation;
		[Export("customizeUserLocationAccuracyCircleRepresentation")]
		//bool CustomizeUserLocationAccuracyCircleRepresentation { get; set; }
		bool CustomizeUserLocationAccuracyCircleRepresentation();

		[Export("setCustomizeUserLocationAccuracyCircleRepresentation:")]
		void SetCustomizeUserLocationAccuracyCircleRepresentation(bool customizeUserLocationAccuracyCircleRepresentation);

		// @property (readonly, nonatomic) MACircle * userLocationAccuracyCircle;
		[Export ("userLocationAccuracyCircle")]
		MACircle UserLocationAccuracyCircle();

		// @property (nonatomic) MAUserTrackingMode userTrackingMode;
		[Export ("userTrackingMode", ArgumentSemantic.Assign)]
		MAUserTrackingMode UserTrackingMode();

		// @property (readonly, getter = isUserLocationVisible, nonatomic) BOOL userLocationVisible;
		[Export ("userLocationVisible")]
		bool UserLocationVisible();

		// @property (nonatomic) CLLocationDistance distanceFilter;
		[Export ("distanceFilter")]
		double DistanceFilter();

		// @property (nonatomic) CLLocationAccuracy desiredAccuracy;
		[Export ("desiredAccuracy")]
		double DesiredAccuracy();

		// @property (nonatomic) CLLocationDegrees headingFilter;
		[Export ("headingFilter")]
		double HeadingFilter();

		// @property (nonatomic) BOOL pausesLocationUpdatesAutomatically;
		[Export ("pausesLocationUpdatesAutomatically")]
		bool PausesLocationUpdatesAutomatically();

		// @property (nonatomic) BOOL allowsBackgroundLocationUpdates;
		[Export ("allowsBackgroundLocationUpdates")]
		bool AllowsBackgroundLocationUpdates();

		// -(void)setUserTrackingMode:(MAUserTrackingMode)mode animated:(BOOL)animated;
		[Export ("setUserTrackingMode:animated:")]
		void SetUserTrackingMode(MAUserTrackingMode mode, bool animated);

		// -(void)updateUserLocationRepresentation:(MAUserLocationRepresentation *)representation;
		[Export ("updateUserLocationRepresentation:")]
		void UpdateUserLocationRepresentation (MAUserLocationRepresentation representation);
	}

	// @interface Overlay (MAMapView)
	[Protocol]
	[BaseType (typeof(MAMapView))]
	interface MAMapView_Overlay
	{
		// @property (readonly, nonatomic) NSArray * overlays;
		[Export ("overlays")]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Overlays { get; }

		// -(NSArray *)overlaysInLevel:(MAOverlayLevel)level;
		[Export ("overlaysInLevel:")]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] OverlaysInLevel (MAOverlayLevel level);

		// -(void)addOverlay:(id<MAOverlay>)overlay;
		[Export ("addOverlay:")]
		void AddOverlay (MAOverlay overlay);

		// -(void)addOverlays:(NSArray *)overlays;
		[Export ("addOverlays:")]
		// [Verify (StronglyTypedNSArray)]
		void AddOverlays (NSObject[] overlays);

		// -(void)addOverlay:(id<MAOverlay>)overlay level:(MAOverlayLevel)level;
		[Export ("addOverlay:level:")]
		void AddOverlay (MAOverlay overlay, MAOverlayLevel level);

		// -(void)addOverlays:(NSArray *)overlays level:(MAOverlayLevel)level;
		[Export ("addOverlays:level:")]
		// [Verify (StronglyTypedNSArray)]
		void AddOverlays (NSObject[] overlays, MAOverlayLevel level);

		// -(void)removeOverlay:(id<MAOverlay>)overlay;
		[Export ("removeOverlay:")]
		void RemoveOverlay (MAOverlay overlay);

		// -(void)removeOverlays:(NSArray *)overlays;
		[Export ("removeOverlays:")]
		// [Verify (StronglyTypedNSArray)]
		void RemoveOverlays (NSObject[] overlays);

		// -(void)insertOverlay:(id<MAOverlay>)overlay atIndex:(NSUInteger)index level:(MAOverlayLevel)level;
		[Export ("insertOverlay:atIndex:level:")]
		void InsertOverlay (MAOverlay overlay, nuint index, MAOverlayLevel level);

		// -(void)insertOverlay:(id<MAOverlay>)overlay aboveOverlay:(id<MAOverlay>)sibling;
		[Export ("insertOverlay:aboveOverlay:")]
		void InsertOverlay (MAOverlay overlay, MAOverlay sibling);

		// -(void)insertOverlay:(id<MAOverlay>)overlay belowOverlay:(id<MAOverlay>)sibling;
		[Export ("insertOverlay:belowOverlay:")]
		void InsertOverlayBelowOverlay (MAOverlay overlay, MAOverlay sibling);

		// -(void)insertOverlay:(id<MAOverlay>)overlay atIndex:(NSUInteger)index;
		[Export ("insertOverlay:atIndex:")]
		void InsertOverlayAtIndex (MAOverlay overlay, nuint index);

		// -(void)exchangeOverlayAtIndex:(NSUInteger)index1 withOverlayAtIndex:(NSUInteger)index2;
		[Export ("exchangeOverlayAtIndex:withOverlayAtIndex:")]
		void ExchangeOverlayAtIndex (nuint index1, nuint index2);

		// -(void)exchangeOverlayAtIndex:(NSUInteger)index1 withOverlayAtIndex:(NSUInteger)index2 atLevel:(MAOverlayLevel)level;
		[Export ("exchangeOverlayAtIndex:withOverlayAtIndex:atLevel:")]
		void ExchangeOverlayAtIndex (nuint index1, nuint index2, MAOverlayLevel level);

		// -(void)exchangeOverlay:(id<MAOverlay>)overlay1 withOverlay:(id<MAOverlay>)overlay2;
		[Export ("exchangeOverlay:withOverlay:")]
		void ExchangeOverlay (MAOverlay overlay1, MAOverlay overlay2);

		// -(MAOverlayRenderer *)rendererForOverlay:(id<MAOverlay>)overlay;
		[Export ("rendererForOverlay:")]
		MAOverlayRenderer RendererForOverlay (MAOverlay overlay);

		// -(void)showOverlays:(NSArray *)overlays animated:(BOOL)animated;
		[Export ("showOverlays:animated:")]
		// [Verify (StronglyTypedNSArray)]
		void ShowOverlays (NSObject[] overlays, bool animated);

		// -(void)showOverlays:(NSArray *)overlays edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export ("showOverlays:edgePadding:animated:")]
		// [Verify (StronglyTypedNSArray)]
		void ShowOverlays (NSObject[] overlays, UIEdgeInsets insets, bool animated);

		// -(NSArray *)getHittedPolylinesWith:(CLLocationCoordinate2D)tappedCoord traverseAll:(BOOL)traverseAll;
		[Export ("getHittedPolylinesWith:traverseAll:")]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] GetHittedPolylinesWith (CLLocationCoordinate2D tappedCoord, bool traverseAll);
	}

	// @interface Indoor (MAMapView)
	[Category]
	[BaseType (typeof(MAMapView))]
	interface MAMapView_Indoor
	{
		// @property (getter = isShowsIndoorMap, nonatomic) BOOL showsIndoorMap;
		[Export ("showsIndoorMap")]
		bool ShowsIndoorMap();

		// @property (getter = isShowsIndoorMapControl, nonatomic) BOOL showsIndoorMapControl;
		[Export ("showsIndoorMapControl")]
		bool ShowsIndoorMapControl ();

		// @property (readonly, nonatomic) CGSize indoorMapControlSize;
		[Export ("indoorMapControlSize")]
		CGSize IndoorMapControlSize ();

		// -(void)setIndoorMapControlOrigin:(CGPoint)origin;
		[Export ("setIndoorMapControlOrigin:")]
		void SetIndoorMapControlOrigin (CGPoint origin);

		// -(void)setCurrentIndoorMapFloorIndex:(NSInteger)floorIndex;
		[Export ("setCurrentIndoorMapFloorIndex:")]
		void SetCurrentIndoorMapFloorIndex (nint floorIndex);

		// -(void)clearIndoorMapCache;
		[Export ("clearIndoorMapCache")]
		void ClearIndoorMapCache ();
	}

	// @interface CustomMapStyle (MAMapView)
	[Protocol]
	[BaseType (typeof(MAMapView))]
	interface MAMapView_CustomMapStyle
	{
		// @property (assign, nonatomic) BOOL customMapStyleEnabled;
		[Export ("customMapStyleEnabled")]
		bool CustomMapStyleEnabled { get; set; }

		// -(void)setCustomMapStyleOptions:(MAMapCustomStyleOptions *)styleOptions;
		[Export ("setCustomMapStyleOptions:")]
		void SetCustomMapStyleOptions (MAMapCustomStyleOptions styleOptions);
	}

	// @protocol MAMapViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MAMapViewDelegate
	{
		// @optional -(void)mapViewRegionChanged:(MAMapView *)mapView;
		[Export ("mapViewRegionChanged:")]
		void MapViewRegionChanged (MAMapView mapView);

		// @optional -(void)mapView:(MAMapView *)mapView regionWillChangeAnimated:(BOOL)animated;
		[Export ("mapView:regionWillChangeAnimated:")]
		void MapViewRegionWillChangeAnimated (MAMapView mapView, bool animated);

		// @optional -(void)mapView:(MAMapView *)mapView regionDidChangeAnimated:(BOOL)animated;
		[Export ("mapView:regionDidChangeAnimated:")]
		void MapViewRegionDidChangeAnimated (MAMapView mapView, bool animated);

		// @optional -(void)mapView:(MAMapView *)mapView regionWillChangeAnimated:(BOOL)animated wasUserAction:(BOOL)wasUserAction;
		[Export ("mapView:regionWillChangeAnimated:wasUserAction:")]
		void MapViewRegionWillChangeAnimatedWasUserAction (MAMapView mapView, bool animated, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView regionDidChangeAnimated:(BOOL)animated wasUserAction:(BOOL)wasUserAction;
		[Export ("mapView:regionDidChangeAnimated:wasUserAction:")]
		void MapViewRegionDidChangeAnimated (MAMapView mapView, bool animated, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapWillMoveByUser:(BOOL)wasUserAction;
		[Export ("mapView:mapWillMoveByUser:")]
		void MapViewMapWillMoveByUser (MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapDidMoveByUser:(BOOL)wasUserAction;
		[Export ("mapView:mapDidMoveByUser:")]
		void MapViewMapDidMoveByUser (MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapWillZoomByUser:(BOOL)wasUserAction;
		[Export ("mapView:mapWillZoomByUser:")]
		void MapViewMapWillZoomByUser (MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapDidZoomByUser:(BOOL)wasUserAction;
		[Export ("mapView:mapDidZoomByUser:")]
		void MapViewMapDidZoomByUser (MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapViewWillStartLoadingMap:(MAMapView *)mapView;
		[Export ("mapViewWillStartLoadingMap:")]
		void MapViewWillStartLoadingMap (MAMapView mapView);

		// @optional -(void)mapViewDidFinishLoadingMap:(MAMapView *)mapView;
		[Export ("mapViewDidFinishLoadingMap:")]
		void MapViewDidFinishLoadingMap (MAMapView mapView);

		// @optional -(void)mapViewDidFailLoadingMap:(MAMapView *)mapView withError:(NSError *)error;
		[Export ("mapViewDidFailLoadingMap:withError:")]
		void MapViewDidFailLoadingMapWithError (MAMapView mapView, NSError error);

		// @optional -(MAAnnotationView *)mapView:(MAMapView *)mapView viewForAnnotation:(id<MAAnnotation>)annotation;
		[Export ("mapView:viewForAnnotation:")]
		MAAnnotationView MapViewViewForAnnotation (MAMapView mapView, MAAnnotation annotation);

		// @optional -(void)mapView:(MAMapView *)mapView didAddAnnotationViews:(NSArray *)views;
		[Export ("mapView:didAddAnnotationViews:")]
		// [Verify (StronglyTypedNSArray)]
		void MapViewDidAddAnnotationViews (MAMapView mapView, NSObject[] views);

		// @optional -(void)mapView:(MAMapView *)mapView didSelectAnnotationView:(MAAnnotationView *)view;
		[Export ("mapView:didSelectAnnotationView:")]
		void MapViewDidSelectAnnotationView (MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapView:(MAMapView *)mapView didDeselectAnnotationView:(MAAnnotationView *)view;
		[Export ("mapView:didDeselectAnnotationView:")]
		void MapViewDidDeselectAnnotationView (MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapViewWillStartLocatingUser:(MAMapView *)mapView;
		[Export ("mapViewWillStartLocatingUser:")]
		void MapViewWillStartLocatingUser (MAMapView mapView);

		// @optional -(void)mapViewDidStopLocatingUser:(MAMapView *)mapView;
		[Export ("mapViewDidStopLocatingUser:")]
		void MapViewDidStopLocatingUser (MAMapView mapView);

		// @optional -(void)mapView:(MAMapView *)mapView didUpdateUserLocation:(MAUserLocation *)userLocation updatingLocation:(BOOL)updatingLocation;
		[Export ("mapView:didUpdateUserLocation:updatingLocation:")]
		void MapView (MAMapView mapView, MAUserLocation userLocation, bool updatingLocation);

		// @optional -(void)mapViewRequireLocationAuth:(CLLocationManager *)locationManager;
		[Export ("mapViewRequireLocationAuth:")]
		void MapViewRequireLocationAuth (CLLocationManager locationManager);

		// @optional -(void)mapView:(MAMapView *)mapView didFailToLocateUserWithError:(NSError *)error;
		[Export ("mapView:didFailToLocateUserWithError:")]
		void MapViewDidFailToLocateUserWithError (MAMapView mapView, NSError error);

		// @optional -(void)mapView:(MAMapView *)mapView annotationView:(MAAnnotationView *)view didChangeDragState:(MAAnnotationViewDragState)newState fromOldState:(MAAnnotationViewDragState)oldState;
		[Export ("mapView:annotationView:didChangeDragState:fromOldState:")]
		void MapViewDidChangeDragState (MAMapView mapView, MAAnnotationView view, MAAnnotationViewDragState newState, MAAnnotationViewDragState oldState);

		// @optional -(MAOverlayRenderer *)mapView:(MAMapView *)mapView rendererForOverlay:(id<MAOverlay>)overlay;
		[Export ("mapView:rendererForOverlay:")]
		MAOverlayRenderer MapViewRendererForOverlay (MAMapView mapView, MAOverlay overlay);

		// @optional -(void)mapView:(MAMapView *)mapView didAddOverlayRenderers:(NSArray *)overlayRenderers;
		[Export ("mapView:didAddOverlayRenderers:")]
		// [Verify (StronglyTypedNSArray)]
		void MapViewDidAddOverlayRenderers (MAMapView mapView, NSObject[] overlayRenderers);

		// @optional -(void)mapView:(MAMapView *)mapView annotationView:(MAAnnotationView *)view calloutAccessoryControlTapped:(UIControl *)control;
		[Export ("mapView:annotationView:calloutAccessoryControlTapped:")]
		void MapViewAnnotationViewCalloutAccessoryControlTapped (MAMapView mapView, MAAnnotationView view, UIControl control);

		// @optional -(void)mapView:(MAMapView *)mapView didAnnotationViewCalloutTapped:(MAAnnotationView *)view;
		[Export ("mapView:didAnnotationViewCalloutTapped:")]
		void MapViewDidAnnotationViewCalloutTapped (MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapView:(MAMapView *)mapView didAnnotationViewTapped:(MAAnnotationView *)view;
		[Export ("mapView:didAnnotationViewTapped:")]
		void MapViewDidAnnotationViewTapped (MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapView:(MAMapView *)mapView didChangeUserTrackingMode:(MAUserTrackingMode)mode animated:(BOOL)animated;
		[Export ("mapView:didChangeUserTrackingMode:animated:")]
		void MapViewDidChangeUserTrackingMode (MAMapView mapView, MAUserTrackingMode mode, bool animated);

		// @optional -(void)mapView:(MAMapView *)mapView didChangeOpenGLESDisabled:(BOOL)openGLESDisabled __attribute__((deprecated("已废弃，since 7.9.0")));
		[Export ("mapView:didChangeOpenGLESDisabled:")]
		void MapViewDidChangeOpenGLESDisabled (MAMapView mapView, bool openGLESDisabled);

		// @optional -(void)mapView:(MAMapView *)mapView didTouchPois:(NSArray *)pois;
		[Export ("mapView:didTouchPois:")]
		// [Verify (StronglyTypedNSArray)]
		void MapViewDidTouchPois (MAMapView mapView, NSObject[] pois);

		// @optional -(void)mapView:(MAMapView *)mapView didSingleTappedAtCoordinate:(CLLocationCoordinate2D)coordinate;
		[Export ("mapView:didSingleTappedAtCoordinate:")]
		void MapViewDidSingleTappedAtCoordinate(MAMapView mapView, CLLocationCoordinate2D coordinate);

		// @optional -(void)mapView:(MAMapView *)mapView didLongPressedAtCoordinate:(CLLocationCoordinate2D)coordinate;
		[Export ("mapView:didLongPressedAtCoordinate:")]
		void MapViewDidLongPressedAtCoordinate (MAMapView mapView, CLLocationCoordinate2D coordinate);

		// @optional -(void)mapInitComplete:(MAMapView *)mapView;
		[Export ("mapInitComplete:")]
		void MapInitComplete (MAMapView mapView);

		// @optional -(void)mapView:(MAMapView *)mapView didIndoorMapShowed:(MAIndoorInfo *)indoorInfo;
		[Export ("mapView:didIndoorMapShowed:")]
		void MapView (MAMapView mapView, MAIndoorInfo indoorInfo);

		// @optional -(void)mapView:(MAMapView *)mapView didIndoorMapFloorIndexChanged:(MAIndoorInfo *)indoorInfo;
		[Export ("mapView:didIndoorMapFloorIndexChanged:")]
		void MapViewDidIndoorMapFloorIndexChanged (MAMapView mapView, MAIndoorInfo indoorInfo);

		// @optional -(void)mapView:(MAMapView *)mapView didIndoorMapHidden:(MAIndoorInfo *)indoorInfo;
		[Export ("mapView:didIndoorMapHidden:")]
		void MapViewDidIndoorMapHidden (MAMapView mapView, MAIndoorInfo indoorInfo);

		// @optional -(void)offlineDataWillReload:(MAMapView *)mapView;
		[Export ("offlineDataWillReload:")]
		void OfflineDataWillReload (MAMapView mapView);

		// @optional -(void)offlineDataDidReload:(MAMapView *)mapView;
		[Export ("offlineDataDidReload:")]
		void OfflineDataDidReload (MAMapView mapView);
	}

	// @interface MAPinAnnotationView : MAAnnotationView
	[BaseType (typeof(MAAnnotationView))]
	interface MAPinAnnotationView
	{
		// @property (nonatomic) MAPinAnnotationColor pinColor;
		[Export ("pinColor", ArgumentSemantic.Assign)]
		MAPinAnnotationColor PinColor { get; set; }

		// @property (nonatomic) BOOL animatesDrop;
		[Export ("animatesDrop")]
		bool AnimatesDrop { get; set; }
	}

	// @interface MAOverlayPathRenderer : MAOverlayRenderer
	[BaseType (typeof(MAOverlayRenderer))]
	interface MAOverlayPathRenderer
	{
		// @property (retain, nonatomic) UIColor * fillColor;
		[Export ("fillColor", ArgumentSemantic.Retain)]
		UIColor FillColor { get; set; }

		// @property (retain, nonatomic) UIColor * strokeColor;
		[Export ("strokeColor", ArgumentSemantic.Retain)]
		UIColor StrokeColor { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (assign, nonatomic) MALineJoinType lineJoinType;
		[Export ("lineJoinType", ArgumentSemantic.Assign)]
		MALineJoinType LineJoinType { get; set; }

		// @property (assign, nonatomic) MALineCapType lineCapType;
		[Export ("lineCapType", ArgumentSemantic.Assign)]
		MALineCapType LineCapType { get; set; }

		// @property (assign, nonatomic) CGFloat miterLimit;
		[Export ("miterLimit")]
		nfloat MiterLimit { get; set; }

		// @property (assign, nonatomic) MALineDashType lineDashType;
		[Export ("lineDashType", ArgumentSemantic.Assign)]
		MALineDashType LineDashType { get; set; }
	}

	// @interface MACircleRenderer : MAOverlayPathRenderer
	[BaseType (typeof(MAOverlayPathRenderer))]
	interface MACircleRenderer
	{
		// @property (readonly, nonatomic) MACircle * circle;
		[Export ("circle")]
		MACircle Circle { get; }

		// -(instancetype)initWithCircle:(MACircle *)circle;
		[Export ("initWithCircle:")]
		NativeHandle Constructor (MACircle circle);
	}

	// @interface MAArc : MAShape <MAOverlay>
	[BaseType (typeof(MAShape))]
	interface MAArc : MAOverlay
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D startCoordinate;
		[Export ("startCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D StartCoordinate { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D passedCoordinate;
		[Export ("passedCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D PassedCoordinate { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D endCoordinate;
		[Export ("endCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D EndCoordinate { get; set; }

		// +(instancetype)arcWithStartCoordinate:(CLLocationCoordinate2D)startCoordinate passedCoordinate:(CLLocationCoordinate2D)passedCoordinate endCoordinate:(CLLocationCoordinate2D)endCoordinate;
		[Static]
		[Export ("arcWithStartCoordinate:passedCoordinate:endCoordinate:")]
		MAArc ArcWithStartCoordinate (CLLocationCoordinate2D startCoordinate, CLLocationCoordinate2D passedCoordinate, CLLocationCoordinate2D endCoordinate);
	}

	// @interface MAArcRenderer : MAOverlayPathRenderer
	[BaseType (typeof(MAOverlayPathRenderer))]
	interface MAArcRenderer
	{
		// @property (readonly, nonatomic) MAArc * arc;
		[Export ("arc")]
		MAArc Arc { get; }

		// -(instancetype)initWithArc:(MAArc *)arc;
		[Export ("initWithArc:")]
		NativeHandle Constructor (MAArc arc);
	}

	// @interface MAMultiPoint : MAShape
	[BaseType (typeof(MAShape))]
	interface MAMultiPoint
	{
		// @property (readonly, nonatomic) MAMapPoint * points;
		[Export ("points")]
		unsafe MAMapPoint Points { get; }

		// @property (readonly, nonatomic) NSUInteger pointCount;
		[Export ("pointCount")]
		nuint PointCount { get; }

		// @property (readonly, assign, nonatomic) BOOL cross180Longitude;
		[Export ("cross180Longitude")]
		bool Cross180Longitude { get; }

		// -(void)getCoordinates:(CLLocationCoordinate2D *)coords range:(NSRange)range;
		[Export ("getCoordinates:range:")]
		unsafe void GetCoordinates (CLLocationCoordinate2D coords, NSRange range);
	}

	// @interface MAPolygon : MAMultiPoint <MAOverlay>
	[BaseType (typeof(MAMultiPoint))]
	interface MAPolygon : MAOverlay
	{
		// @property (nonatomic, strong) NSArray<id<MAOverlay>> * hollowShapes;
		[Export ("hollowShapes", ArgumentSemantic.Strong)]
		MAOverlay[] HollowShapes { get; set; }

		// +(instancetype)polygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export ("polygonWithCoordinates:count:")]
		unsafe MAPolygon PolygonWithCoordinates (CLLocationCoordinate2D coords, nuint count);

		// +(instancetype)polygonWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
		[Static]
		[Export ("polygonWithPoints:count:")]
		unsafe MAPolygon PolygonWithPoints (MAMapPoint points, nuint count);

		// -(BOOL)setPolygonWithPoints:(MAMapPoint *)points count:(NSInteger)count;
		[Export ("setPolygonWithPoints:count:")]
		unsafe bool SetPolygonWithPoints (MAMapPoint points, nint count);

		// -(BOOL)setPolygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSInteger)count;
		[Export ("setPolygonWithCoordinates:count:")]
		unsafe bool SetPolygonWithCoordinates (CLLocationCoordinate2D coords, nint count);
	}

	// @interface MAPolygonRenderer : MAOverlayPathRenderer
	[BaseType (typeof(MAOverlayPathRenderer))]
	interface MAPolygonRenderer
	{
		// @property (readonly, nonatomic) MAPolygon * polygon;
		[Export ("polygon")]
		MAPolygon Polygon { get; }

		// -(instancetype)initWithPolygon:(MAPolygon *)polygon;
		[Export ("initWithPolygon:")]
		NativeHandle Constructor (MAPolygon polygon);
	}

	// @interface MAPolyline : MAMultiPoint <MAOverlay>
	[BaseType (typeof(MAMultiPoint))]
	interface MAPolyline : MAOverlay
	{
		// +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
		[Static]
		[Export ("polylineWithPoints:count:")]
		unsafe MAPolyline PolylineWithPoints (MAMapPoint points, nuint count);

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export ("polylineWithCoordinates:count:")]
		unsafe MAPolyline PolylineWithCoordinates (CLLocationCoordinate2D coords, nuint count);

		// -(BOOL)setPolylineWithPoints:(MAMapPoint *)points count:(NSInteger)count;
		[Export ("setPolylineWithPoints:count:")]
		unsafe bool SetPolylineWithPoints (MAMapPoint points, nint count);

		// -(BOOL)setPolylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSInteger)count;
		[Export ("setPolylineWithCoordinates:count:")]
		unsafe bool SetPolylineWithCoordinates (CLLocationCoordinate2D coords, nint count);
	}

	// @interface MAPolylineRenderer : MAOverlayPathRenderer
	[BaseType (typeof(MAOverlayPathRenderer))]
	interface MAPolylineRenderer
	{
		// @property (readonly, nonatomic) MAPolyline * polyline;
		[Export ("polyline")]
		MAPolyline Polyline { get; }

		// @property (assign, nonatomic) BOOL is3DArrowLine;
		[Export ("is3DArrowLine")]
		bool Is3DArrowLine { get; set; }

		// @property (nonatomic, strong) UIColor * sideColor;
		[Export ("sideColor", ArgumentSemantic.Strong)]
		UIColor SideColor { get; set; }

		// @property (assign, nonatomic) BOOL userInteractionEnabled;
		[Export ("userInteractionEnabled")]
		bool UserInteractionEnabled { get; set; }

		// @property (assign, nonatomic) CGFloat hitTestInset;
		[Export ("hitTestInset")]
		nfloat HitTestInset { get; set; }

		// @property (assign, nonatomic) BOOL showRangeEnabled;
		[Export ("showRangeEnabled")]
		bool ShowRangeEnabled { get; set; }

		// @property (assign, nonatomic) MAPathShowRange showRange;
		[Export ("showRange", ArgumentSemantic.Assign)]
		MAPathShowRange ShowRange { get; set; }

		// -(instancetype)initWithPolyline:(MAPolyline *)polyline;
		[Export ("initWithPolyline:")]
		NativeHandle Constructor (MAPolyline polyline);
	}

	// @interface MAGeodesicPolyline : MAPolyline
	[BaseType (typeof(MAPolyline))]
	interface MAGeodesicPolyline
	{
		// +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
		[Static]
		[Export ("polylineWithPoints:count:")]
		unsafe MAGeodesicPolyline PolylineWithPoints (MAMapPoint points, nuint count);

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export ("polylineWithCoordinates:count:")]
		unsafe MAGeodesicPolyline PolylineWithCoordinates (CLLocationCoordinate2D coords, nuint count);

		// -(BOOL)setPolylineWithPoints:(MAMapPoint *)points count:(NSInteger)count;
		[Export ("setPolylineWithPoints:count:")]
		unsafe bool SetPolylineWithPoints (MAMapPoint points, nint count);

		// -(BOOL)setPolylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSInteger)count;
		[Export ("setPolylineWithCoordinates:count:")]
		unsafe bool SetPolylineWithCoordinates (CLLocationCoordinate2D coords, nint count);
	}

	// @interface MAMultiPolyline : MAPolyline
	[BaseType (typeof(MAPolyline))]
	interface MAMultiPolyline
	{
		// @property (nonatomic, strong) NSArray<NSNumber *> * drawStyleIndexes;
		[Export ("drawStyleIndexes", ArgumentSemantic.Strong)]
		NSNumber[] DrawStyleIndexes { get; set; }

		// +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count drawStyleIndexes:(NSArray<NSNumber *> *)drawStyleIndexes;
		[Static]
		[Export ("polylineWithPoints:count:drawStyleIndexes:")]
		unsafe MAMultiPolyline PolylineWithPoints (MAMapPoint points, nuint count, NSNumber[] drawStyleIndexes);

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count drawStyleIndexes:(NSArray<NSNumber *> *)drawStyleIndexes;
		[Static]
		[Export ("polylineWithCoordinates:count:drawStyleIndexes:")]
		unsafe MAMultiPolyline PolylineWithCoordinates (CLLocationCoordinate2D coords, nuint count, NSNumber[] drawStyleIndexes);

		// -(BOOL)setPolylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count drawStyleIndexes:(NSArray<NSNumber *> *)drawStyleIndexes;
		[Export ("setPolylineWithPoints:count:drawStyleIndexes:")]
		unsafe bool SetPolylineWithPoints (MAMapPoint points, nuint count, NSNumber[] drawStyleIndexes);

		// -(BOOL)setPolylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count drawStyleIndexes:(NSArray<NSNumber *> *)drawStyleIndexes;
		[Export ("setPolylineWithCoordinates:count:drawStyleIndexes:")]
		unsafe bool SetPolylineWithCoordinates (CLLocationCoordinate2D coords, nuint count, NSNumber[] drawStyleIndexes);
	}

	// @interface MAMultiTexturePolylineRenderer : MAPolylineRenderer
	[BaseType (typeof(MAPolylineRenderer))]
	interface MAMultiTexturePolylineRenderer
	{
		// @property (readonly, nonatomic) MAMultiPolyline * multiPolyline;
		[Export ("multiPolyline")]
		MAMultiPolyline MultiPolyline { get; }

		// @property (nonatomic, strong) NSArray<UIImage *> * strokeTextureImages;
		[Export ("strokeTextureImages", ArgumentSemantic.Strong)]
		UIImage[] StrokeTextureImages { get; set; }

		// -(instancetype)initWithMultiPolyline:(MAMultiPolyline *)multiPolyline;
		[Export ("initWithMultiPolyline:")]
		NativeHandle Constructor (MAMultiPolyline multiPolyline);
	}

	// @interface MAMultiColoredPolylineRenderer : MAPolylineRenderer
	[BaseType (typeof(MAPolylineRenderer))]
	interface MAMultiColoredPolylineRenderer
	{
		// @property (readonly, nonatomic) MAMultiPolyline * multiPolyline;
		[Export ("multiPolyline")]
		MAMultiPolyline MultiPolyline { get; }

		// @property (nonatomic, strong) NSArray<UIColor *> * strokeColors;
		[Export ("strokeColors", ArgumentSemantic.Strong)]
		UIColor[] StrokeColors { get; set; }

		// @property (getter = isGradient, nonatomic) BOOL gradient;
		[Export ("gradient")]
		bool Gradient { [Bind ("isGradient")] get; set; }

		// -(instancetype)initWithMultiPolyline:(MAMultiPolyline *)multiPolyline;
		[Export ("initWithMultiPolyline:")]
		NativeHandle Constructor (MAMultiPolyline multiPolyline);
	}

	// @interface MAGroundOverlay : MAShape <MAOverlay>
	[BaseType (typeof(MAShape))]
	interface MAGroundOverlay : MAOverlay
	{
		// @property (readonly, nonatomic) UIImage * icon;
		[Export ("icon")]
		UIImage Icon { get; }

		// @property (assign, nonatomic) CGFloat alpha __attribute__((deprecated("已废弃，since 7.7.0，请使用MAGroundOverlayRenderer中的alpha")));
		[Export ("alpha")]
		nfloat Alpha { get; set; }

		// @property (readonly, nonatomic) CGFloat zoomLevel;
		[Export ("zoomLevel")]
		nfloat ZoomLevel { get; }

		// @property (readonly, nonatomic) MACoordinateBounds bounds;
		[Export ("bounds")]
		MACoordinateBounds Bounds { get; }

		// +(instancetype)groundOverlayWithBounds:(MACoordinateBounds)bounds icon:(UIImage *)icon;
		[Static]
		[Export ("groundOverlayWithBounds:icon:")]
		MAGroundOverlay GroundOverlayWithBounds (MACoordinateBounds bounds, UIImage icon);

		// +(instancetype)groundOverlayWithCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel icon:(UIImage *)icon;
		[Static]
		[Export ("groundOverlayWithCoordinate:zoomLevel:icon:")]
		MAGroundOverlay GroundOverlayWithCoordinate (CLLocationCoordinate2D coordinate, nfloat zoomLevel, UIImage icon);

		// -(BOOL)setGroundOverlayWithBounds:(MACoordinateBounds)bounds icon:(UIImage *)icon;
		[Export ("setGroundOverlayWithBounds:icon:")]
		bool SetGroundOverlayWithBounds (MACoordinateBounds bounds, UIImage icon);

		// -(BOOL)setGroundOverlayWithCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel icon:(UIImage *)icon;
		[Export ("setGroundOverlayWithCoordinate:zoomLevel:icon:")]
		bool SetGroundOverlayWithCoordinate (CLLocationCoordinate2D coordinate, nfloat zoomLevel, UIImage icon);
	}

	// @interface MAGroundOverlayRenderer : MAOverlayRenderer
	[BaseType (typeof(MAOverlayRenderer))]
	interface MAGroundOverlayRenderer
	{
		// @property (readonly, nonatomic) MAGroundOverlay * groundOverlay;
		[Export ("groundOverlay")]
		MAGroundOverlay GroundOverlay { get; }

		// -(instancetype)initWithGroundOverlay:(MAGroundOverlay *)groundOverlay;
		[Export ("initWithGroundOverlay:")]
		NativeHandle Constructor (MAGroundOverlay groundOverlay);
	}

	// @interface MATileOverlay : MABaseOverlay
	[BaseType (typeof(MABaseOverlay))]
	interface MATileOverlay
	{
		// @property (assign, nonatomic) CGSize tileSize;
		[Export ("tileSize", ArgumentSemantic.Assign)]
		CGSize TileSize { get; set; }

		// @property NSInteger minimumZ;
		[Export ("minimumZ")]
		nint MinimumZ { get; set; }

		// @property NSInteger maximumZ;
		[Export ("maximumZ")]
		nint MaximumZ { get; set; }

		// @property (readonly) NSString * URLTemplate;
		[Export ("URLTemplate")]
		string URLTemplate { get; }

		// @property (nonatomic) BOOL canReplaceMapContent;
		[Export ("canReplaceMapContent")]
		bool CanReplaceMapContent { get; set; }

		// @property (assign, nonatomic) BOOL disableOffScreenTileLoading;
		[Export ("disableOffScreenTileLoading")]
		bool DisableOffScreenTileLoading { get; set; }

		// -(id)initWithURLTemplate:(NSString *)URLTemplate;
		[Export ("initWithURLTemplate:")]
		NativeHandle Constructor (string URLTemplate);
	}

	// @interface CustomLoading (MATileOverlay)
	[Category]
	[BaseType (typeof(MATileOverlay))]
	interface MATileOverlay_CustomLoading
	{
		// -(NSURL *)URLForTilePath:(MATileOverlayPath)path;
		[Export ("URLForTilePath:")]
		NSUrl URLForTilePath (MATileOverlayPath path);

		// -(void)loadTileAtPath:(MATileOverlayPath)path result:(void (^)(NSData *, NSError *))result;
		[Export ("loadTileAtPath:result:")]
		void LoadTileAtPath (MATileOverlayPath path, Action<NSData, NSError> result);

		// -(void)cancelLoadOfTileAtPath:(MATileOverlayPath)path;
		[Export ("cancelLoadOfTileAtPath:")]
		void CancelLoadOfTileAtPath (MATileOverlayPath path);
	}

	// @interface MATileOverlayRenderer : MAOverlayRenderer
	[BaseType (typeof(MAOverlayRenderer))]
	interface MATileOverlayRenderer
	{
		// @property (readonly, nonatomic) MATileOverlay * tileOverlay;
		[Export ("tileOverlay")]
		MATileOverlay TileOverlay { get; }

		// -(instancetype)initWithTileOverlay:(MATileOverlay *)tileOverlay;
		[Export ("initWithTileOverlay:")]
		NativeHandle Constructor (MATileOverlay tileOverlay);

		// -(void)reloadData;
		[Export ("reloadData")]
		void ReloadData ();
	}

	// @interface MACustomBuildingOverlayOption : MAMultiPoint
	[BaseType (typeof(MAMultiPoint))]
	interface MACustomBuildingOverlayOption
	{
		// @property (assign, nonatomic) CGFloat height;
		[Export ("height")]
		nfloat Height { get; set; }

		// @property (assign, nonatomic) CGFloat heightScale;
		[Export ("heightScale")]
		nfloat HeightScale { get; set; }

		// @property (nonatomic, strong) UIColor * topColor;
		[Export ("topColor", ArgumentSemantic.Strong)]
		UIColor TopColor { get; set; }

		// @property (nonatomic, strong) UIColor * sideColor;
		[Export ("sideColor", ArgumentSemantic.Strong)]
		UIColor SideColor { get; set; }

		// @property (assign, nonatomic) BOOL visibile;
		[Export ("visibile")]
		bool Visibile { get; set; }

		// +(instancetype)optionWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export ("optionWithCoordinates:count:")]
		unsafe MACustomBuildingOverlayOption OptionWithCoordinates (CLLocationCoordinate2D coords, nuint count);

		// -(BOOL)setOptionWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Export ("setOptionWithCoordinates:count:")]
		unsafe bool SetOptionWithCoordinates (CLLocationCoordinate2D coords, nuint count);
	}

	// @interface MACustomBuildingOverlay : MAShape <MAOverlay>
	[BaseType (typeof(MAShape))]
	interface MACustomBuildingOverlay : MAOverlay
	{
		// @property (readonly, nonatomic) MACustomBuildingOverlayOption * defaultOption;
		[Export ("defaultOption")]
		MACustomBuildingOverlayOption DefaultOption { get; }

		// @property (readonly, nonatomic) NSArray<MACustomBuildingOverlayOption *> * customOptions;
		[Export ("customOptions")]
		MACustomBuildingOverlayOption[] CustomOptions { get; }

		// -(void)addCustomOption:(MACustomBuildingOverlayOption *)option;
		[Export ("addCustomOption:")]
		void AddCustomOption (MACustomBuildingOverlayOption option);

		// -(void)removeCustomOption:(MACustomBuildingOverlayOption *)option;
		[Export ("removeCustomOption:")]
		void RemoveCustomOption (MACustomBuildingOverlayOption option);
	}

	// @interface MACustomBuildingOverlayRenderer : MAOverlayRenderer
	[BaseType (typeof(MAOverlayRenderer))]
	interface MACustomBuildingOverlayRenderer
	{
		// @property (readonly, nonatomic) MACustomBuildingOverlay * customBuildingOverlay;
		[Export ("customBuildingOverlay")]
		MACustomBuildingOverlay CustomBuildingOverlay { get; }

		// -(instancetype)initWithCustomBuildingOverlay:(MACustomBuildingOverlay *)customBuildingOverlay;
		[Export ("initWithCustomBuildingOverlay:")]
		NativeHandle Constructor (MACustomBuildingOverlay customBuildingOverlay);
	}

	// @protocol MAParticleVelocityGenerate <NSObject>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface MAParticleVelocityGenerate
	{
		// @required -(CGFloat)getX;
		[Abstract]
		[Export ("getX")]
		// [Verify (MethodToProperty)]
		nfloat X { get; }

		// @required -(CGFloat)getY;
		[Abstract]
		[Export ("getY")]
		// [Verify (MethodToProperty)]
		nfloat Y { get; }

		// @required -(CGFloat)getZ;
		[Abstract]
		[Export ("getZ")]
		// [Verify (MethodToProperty)]
		nfloat Z { get; }
	}

	// @interface MAParticleRandomVelocityGenerate : NSObject <MAParticleVelocityGenerate>
	[BaseType (typeof(NSObject))]
	interface MAParticleRandomVelocityGenerate : MAParticleVelocityGenerate
	{
		// -(instancetype)initWithBoundaryValueX1:(float)x1 Y1:(float)y1 Z1:(float)z1 X2:(float)x2 Y2:(float)y2 Z2:(float)z2;
		[Export ("initWithBoundaryValueX1:Y1:Z1:X2:Y2:Z2:")]
		NativeHandle Constructor (float x1, float y1, float z1, float x2, float y2, float z2);
	}

	// @protocol MAParticleColorGenerate <NSObject>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface MAParticleColorGenerate
	{
		// @required -(float *)getColor;
		[Abstract]
		[Export ("getColor")]
		// [Verify (MethodToProperty)]
		unsafe float Color { get; }
	}

	// @interface MAParticleRandomColorGenerate : NSObject <MAParticleColorGenerate>
	[BaseType (typeof(NSObject))]
	interface MAParticleRandomColorGenerate : MAParticleColorGenerate
	{
		// -(instancetype)initWithBoundaryColorR1:(float)r1 G1:(float)g1 B1:(float)b1 A1:(float)a1 R2:(float)r2 G2:(float)g2 B2:(float)b2 A2:(float)a2;
		[Export ("initWithBoundaryColorR1:G1:B1:A1:R2:G2:B2:A2:")]
		NativeHandle Constructor (float r1, float g1, float b1, float a1, float r2, float g2, float b2, float a2);
	}

	// @protocol MAParticleRotationGenerate <NSObject>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface MAParticleRotationGenerate
	{
		// @required -(float)getRotate;
		[Abstract]
		[Export ("getRotate")]
		// [Verify (MethodToProperty)]
		float Rotate { get; }
	}

	// @interface MAParticleConstantRotationGenerate : NSObject <MAParticleRotationGenerate>
	[BaseType (typeof(NSObject))]
	interface MAParticleConstantRotationGenerate : MAParticleRotationGenerate
	{
		// -(instancetype)initWithRotate:(float)rotate;
		[Export ("initWithRotate:")]
		NativeHandle Constructor (float rotate);
	}

	// @protocol MAParticleSizeGenerate <NSObject>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface MAParticleSizeGenerate
	{
		// @required -(float)getSizeX:(float)timeFrame;
		[Abstract]
		[Export ("getSizeX:")]
		float GetSizeX (float timeFrame);

		// @required -(float)getSizeY:(float)timeFrame;
		[Abstract]
		[Export ("getSizeY:")]
		float GetSizeY (float timeFrame);

		// @required -(float)getSizeZ:(float)timeFrame;
		[Abstract]
		[Export ("getSizeZ:")]
		float GetSizeZ (float timeFrame);
	}

	// @interface MAParticleCurveSizeGenerate : NSObject <MAParticleSizeGenerate>
	[BaseType (typeof(NSObject))]
	interface MAParticleCurveSizeGenerate : MAParticleSizeGenerate
	{
		// -(instancetype)initWithCurveX:(float)x Y:(float)y Z:(float)z;
		[Export ("initWithCurveX:Y:Z:")]
		NativeHandle Constructor (float x, float y, float z);
	}

	// @interface MAParticleEmissionModuleOC : NSObject
	[BaseType (typeof(NSObject))]
	interface MAParticleEmissionModuleOC
	{
		// -(instancetype)initWithEmissionRate:(int)rate rateTime:(int)rateTime;
		[Export ("initWithEmissionRate:rateTime:")]
		NativeHandle Constructor (int rate, int rateTime);
	}

	// @protocol MAParticleShapeModule <NSObject>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface MAParticleShapeModule
	{
		// @required -(float *)getPoint;
		[Abstract]
		[Export ("getPoint")]
		// [Verify (MethodToProperty)]
		unsafe float Point { get; }

		// @required -(BOOL)isRatioEnable;
		[Abstract]
		[Export ("isRatioEnable")]
		// [Verify (MethodToProperty)]
		bool IsRatioEnable { get; }
	}

	// @interface MAParticleSinglePointShapeModule : NSObject <MAParticleShapeModule>
	[BaseType (typeof(NSObject))]
	interface MAParticleSinglePointShapeModule : MAParticleShapeModule
	{
		// -(instancetype)initWithShapeX:(float)x Y:(float)y Z:(float)z useRatio:(BOOL)isUseRatio;
		[Export ("initWithShapeX:Y:Z:useRatio:")]
		NativeHandle Constructor (float x, float y, float z, bool isUseRatio);
	}

	// @interface MAParticleRectShapeModule : NSObject <MAParticleShapeModule>
	[BaseType (typeof(NSObject))]
	interface MAParticleRectShapeModule : MAParticleShapeModule
	{
		// -(instancetype)initWithLeft:(float)left top:(float)top right:(float)right bottom:(float)bottom useRatio:(BOOL)isUseRatio;
		[Export ("initWithLeft:top:right:bottom:useRatio:")]
		NativeHandle Constructor (float left, float top, float right, float bottom, bool isUseRatio);
	}

	// @interface MAParticleOverLifeModuleOC : NSObject
	[BaseType (typeof(NSObject))]
	interface MAParticleOverLifeModuleOC
	{
		// -(void)setVelocityOverLife:(id<MAParticleVelocityGenerate>)velocity;
		[Export ("setVelocityOverLife:")]
		void SetVelocityOverLife (MAParticleVelocityGenerate velocity);

		// -(void)setRotationOverLife:(id<MAParticleRotationGenerate>)rotation;
		[Export ("setRotationOverLife:")]
		void SetRotationOverLife (MAParticleRotationGenerate rotation);

		// -(void)setSizeOverLife:(id<MAParticleSizeGenerate>)size;
		[Export ("setSizeOverLife:")]
		void SetSizeOverLife (MAParticleSizeGenerate size);

		// -(void)setColorOverLife:(id<MAParticleColorGenerate>)color;
		[Export ("setColorOverLife:")]
		void SetColorOverLife (MAParticleColorGenerate color);
	}

	// @interface MAParticleOverlayOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface MAParticleOverlayOptions
	{
		// @property (assign, nonatomic) BOOL visibile;
		[Export ("visibile")]
		bool Visibile { get; set; }

		// @property (assign, nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; set; }

		// @property (assign, nonatomic) BOOL loop;
		[Export ("loop")]
		bool Loop { get; set; }

		// @property (assign, nonatomic) NSInteger maxParticles;
		[Export ("maxParticles")]
		nint MaxParticles { get; set; }

		// @property (nonatomic, strong) UIImage * icon;
		[Export ("icon", ArgumentSemantic.Strong)]
		UIImage Icon { get; set; }

		// @property (assign, nonatomic) CGSize startParticleSize;
		[Export ("startParticleSize", ArgumentSemantic.Assign)]
		CGSize StartParticleSize { get; set; }

		// @property (assign, nonatomic) NSTimeInterval particleLifeTime;
		[Export ("particleLifeTime")]
		double ParticleLifeTime { get; set; }

		// @property (nonatomic, strong) id<MAParticleColorGenerate> particleStartColor;
		[Export ("particleStartColor", ArgumentSemantic.Strong)]
		MAParticleColorGenerate ParticleStartColor { get; set; }

		// @property (nonatomic, strong) id<MAParticleVelocityGenerate> particleStartSpeed;
		[Export ("particleStartSpeed", ArgumentSemantic.Strong)]
		MAParticleVelocityGenerate ParticleStartSpeed { get; set; }

		// @property (nonatomic, strong) MAParticleEmissionModuleOC * particleEmissionModule;
		[Export ("particleEmissionModule", ArgumentSemantic.Strong)]
		MAParticleEmissionModuleOC ParticleEmissionModule { get; set; }

		// @property (nonatomic, strong) id<MAParticleShapeModule> particleShapeModule;
		[Export ("particleShapeModule", ArgumentSemantic.Strong)]
		MAParticleShapeModule ParticleShapeModule { get; set; }

		// @property (nonatomic, strong) MAParticleOverLifeModuleOC * particleOverLifeModule;
		[Export ("particleOverLifeModule", ArgumentSemantic.Strong)]
		MAParticleOverLifeModuleOC ParticleOverLifeModule { get; set; }
	}

	// @interface MAParticleOverlayOptionsFactory : NSObject
	[BaseType (typeof(NSObject))]
	interface MAParticleOverlayOptionsFactory
	{
		// +(NSArray<MAParticleOverlayOptions *> *)particleOverlayOptionsWithType:(MAParticleOverlayType)particleType;
		[Static]
		[Export ("particleOverlayOptionsWithType:")]
		MAParticleOverlayOptions[] ParticleOverlayOptionsWithType (MAParticleOverlayType particleType);
	}

	// @interface MAParticleOverlay : MAShape <MAOverlay>
	[BaseType (typeof(MAShape))]
	interface MAParticleOverlay : MAOverlay
	{
		// +(instancetype)particleOverlayWithOption:(MAParticleOverlayOptions *)option;
		[Static]
		[Export ("particleOverlayWithOption:")]
		MAParticleOverlay ParticleOverlayWithOption (MAParticleOverlayOptions option);

		// @property (readonly, nonatomic, strong) MAParticleOverlayOptions * overlayOption;
		[Export ("overlayOption", ArgumentSemantic.Strong)]
		MAParticleOverlayOptions OverlayOption { get; }

		// -(void)updateOverlayOption:(MAParticleOverlayOptions *)overlayOption;
		[Export ("updateOverlayOption:")]
		void UpdateOverlayOption (MAParticleOverlayOptions overlayOption);
	}

	// @interface MAParticleOverlayRenderer : MAOverlayRenderer
	[BaseType (typeof(MAOverlayRenderer))]
	interface MAParticleOverlayRenderer
	{
		// @property (readonly, nonatomic) MAParticleOverlay * particleOverlay;
		[Export ("particleOverlay")]
		MAParticleOverlay ParticleOverlay { get; }

		// -(instancetype)initWithParticleOverlay:(MAParticleOverlay *)particleOverlay;
		[Export ("initWithParticleOverlay:")]
		NativeHandle Constructor (MAParticleOverlay particleOverlay);
	}

	// @interface MAHeatMapVectorNode : NSObject
	[BaseType (typeof(NSObject))]
	interface MAHeatMapVectorNode
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) float weight;
		[Export ("weight")]
		float Weight { get; set; }
	}

	// @interface MAHeatMapVectorItem : NSObject
	[BaseType (typeof(NSObject))]
	interface MAHeatMapVectorItem
	{
		// @property (readonly, nonatomic) MAMapPoint center;
		[Export ("center")]
		MAMapPoint Center { get; }

		// @property (readonly, nonatomic) float intensity;
		[Export ("intensity")]
		float Intensity { get; }

		// @property (readonly, nonatomic) NSArray<NSNumber *> * nodeIndices;
		[Export ("nodeIndices")]
		NSNumber[] NodeIndices { get; }
	}

	// @interface MAHeatMapVectorOverlayOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface MAHeatMapVectorOverlayOptions
	{
		// @property (assign, nonatomic) MAHeatMapType type;
		[Export ("type", ArgumentSemantic.Assign)]
		MAHeatMapType Type { get; set; }

		// @property (assign, nonatomic) BOOL visible;
		[Export ("visible")]
		bool Visible { get; set; }

		// @property (nonatomic, strong) NSArray<MAHeatMapVectorNode *> * inputNodes;
		[Export ("inputNodes", ArgumentSemantic.Strong)]
		MAHeatMapVectorNode[] InputNodes { get; set; }

		// @property (assign, nonatomic) CLLocationDistance size;
		[Export ("size")]
		double Size { get; set; }

		// @property (assign, nonatomic) CGFloat gap;
		[Export ("gap")]
		nfloat Gap { get; set; }

		// @property (nonatomic, strong) NSArray<UIColor *> * colors;
		[Export ("colors", ArgumentSemantic.Strong)]
		UIColor[] Colors { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * startPoints;
		[Export ("startPoints", ArgumentSemantic.Strong)]
		NSNumber[] StartPoints { get; set; }

		// @property (assign, nonatomic) CGFloat opacity __attribute__((deprecated("已废弃，since 7.9.0，请使用MAHeatMapVectorOverlayRender中的alpha")));
		[Export ("opacity")]
		nfloat Opacity { get; set; }

		// @property (assign, nonatomic) int maxIntensity;
		[Export ("maxIntensity")]
		int MaxIntensity { get; set; }

		// @property (assign, nonatomic) CGFloat minZoom;
		[Export ("minZoom")]
		nfloat MinZoom { get; set; }

		// @property (assign, nonatomic) CGFloat maxZoom;
		[Export ("maxZoom")]
		nfloat MaxZoom { get; set; }
	}

	// @interface MAHeatMapVectorOverlay : MAShape <MAOverlay>
	[BaseType (typeof(MAShape))]
	interface MAHeatMapVectorOverlay : MAOverlay
	{
		// @property (nonatomic, strong) MAHeatMapVectorOverlayOptions * option;
		[Export ("option", ArgumentSemantic.Strong)]
		MAHeatMapVectorOverlayOptions Option { get; set; }

		// +(instancetype)heatMapOverlayWithOption:(MAHeatMapVectorOverlayOptions *)option;
		[Static]
		[Export ("heatMapOverlayWithOption:")]
		MAHeatMapVectorOverlay HeatMapOverlayWithOption (MAHeatMapVectorOverlayOptions option);
	}

	// @interface MAHeatMapVectorOverlayRender : MAOverlayRenderer
	[BaseType (typeof(MAOverlayRenderer))]
	interface MAHeatMapVectorOverlayRender
	{
		// @property (readonly, nonatomic) MAHeatMapVectorOverlay * heatOverlay;
		[Export ("heatOverlay")]
		MAHeatMapVectorOverlay HeatOverlay { get; }

		// -(instancetype)initWithHeatOverlay:(MAHeatMapVectorOverlay *)heatOverlay;
		[Export ("initWithHeatOverlay:")]
		NativeHandle Constructor (MAHeatMapVectorOverlay heatOverlay);

		// -(MAHeatMapVectorItem *)getHeatMapItem:(CLLocationCoordinate2D)coordinate;
		[Export ("getHeatMapItem:")]
		MAHeatMapVectorItem GetHeatMapItem (CLLocationCoordinate2D coordinate);
	}

	// @interface MAMultiPointItem : NSObject <NSCopying, MAAnnotation>
	[BaseType (typeof(NSObject))]
	interface MAMultiPointItem : INSCopying, MAAnnotation
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (copy, nonatomic) NSString * customID;
		[Export ("customID")]
		string CustomID { get; set; }

		// @property (copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * subtitle;
		[Export ("subtitle")]
		string Subtitle { get; set; }
	}

	// @interface MAMultiPointOverlay : MAShape <MAOverlay>
	[BaseType (typeof(MAShape))]
	interface MAMultiPointOverlay : MAOverlay
	{
		// @property (readonly, nonatomic) NSArray<MAMultiPointItem *> * items;
		[Export ("items")]
		MAMultiPointItem[] Items { get; }

		// -(instancetype)initWithMultiPointItems:(NSArray<MAMultiPointItem *> *)items;
		[Export ("initWithMultiPointItems:")]
		NativeHandle Constructor (MAMultiPointItem[] items);
	}

	// @protocol MAMultiPointOverlayRendererDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MAMultiPointOverlayRendererDelegate
	{
		// @optional -(void)multiPointOverlayRenderer:(MAMultiPointOverlayRenderer *)renderer didItemTapped:(MAMultiPointItem *)item;
		[Export ("multiPointOverlayRenderer:didItemTapped:")]
		void DidItemTapped (MAMultiPointOverlayRenderer renderer, MAMultiPointItem item);
	}

	// @interface MAMultiPointOverlayRenderer : MAOverlayRenderer
	[BaseType (typeof(MAOverlayRenderer))]
	interface MAMultiPointOverlayRenderer
	{
		[Wrap ("WeakDelegate")]
		MAMultiPointOverlayRendererDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MAMultiPointOverlayRendererDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) UIImage * icon;
		[Export ("icon", ArgumentSemantic.Strong)]
		UIImage Icon { get; set; }

		// @property (assign, nonatomic) CGSize pointSize;
		[Export ("pointSize", ArgumentSemantic.Assign)]
		CGSize PointSize { get; set; }

		// @property (assign, nonatomic) CGPoint anchor;
		[Export ("anchor", ArgumentSemantic.Assign)]
		CGPoint Anchor { get; set; }

		// @property (readonly, nonatomic) MAMultiPointOverlay * multiPointOverlay;
		[Export ("multiPointOverlay")]
		MAMultiPointOverlay MultiPointOverlay { get; }

		// -(instancetype)initWithMultiPointOverlay:(MAMultiPointOverlay *)multiPointOverlay;
		[Export ("initWithMultiPointOverlay:")]
		NativeHandle Constructor (MAMultiPointOverlay multiPointOverlay);
	}

	// @interface MAHeatMapNode : NSObject
	[BaseType (typeof(NSObject))]
	interface MAHeatMapNode
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) float intensity;
		[Export ("intensity")]
		float Intensity { get; set; }
	}

	// @interface MAHeatMapGradient : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface MAHeatMapGradient : INSCopying
	{
		// @property (readonly, nonatomic) NSArray<UIColor *> * colors;
		[Export ("colors")]
		UIColor[] Colors { get; }

		// @property (readonly, nonatomic) NSArray<NSNumber *> * startPoints;
		[Export ("startPoints")]
		NSNumber[] StartPoints { get; }

		// -(instancetype)initWithColor:(NSArray<UIColor *> *)colors andWithStartPoints:(NSArray<NSNumber *> *)startPoints;
		[Export ("initWithColor:andWithStartPoints:")]
		NativeHandle Constructor (UIColor[] colors, NSNumber[] startPoints);
	}

	// @interface MAHeatMapTileOverlay : MATileOverlay
	[BaseType (typeof(MATileOverlay))]
	interface MAHeatMapTileOverlay
	{
		// @property (nonatomic, strong) NSArray<MAHeatMapNode *> * data;
		[Export ("data", ArgumentSemantic.Strong)]
		MAHeatMapNode[] Data { get; set; }

		// @property (assign, nonatomic) NSInteger radius;
		[Export ("radius")]
		nint Radius { get; set; }

		// @property (assign, nonatomic) CGFloat opacity;
		[Export ("opacity")]
		nfloat Opacity { get; set; }

		// @property (nonatomic, strong) MAHeatMapGradient * gradient;
		[Export ("gradient", ArgumentSemantic.Strong)]
		MAHeatMapGradient Gradient { get; set; }

		// @property (assign, nonatomic) BOOL allowRetinaAdapting;
		[Export ("allowRetinaAdapting")]
		bool AllowRetinaAdapting { get; set; }
	}

	// @interface MATouchPoi : NSObject
	[BaseType (typeof(NSObject))]
	interface MATouchPoi
	{
		// @property (readonly, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; }

		// @property (readonly, copy, nonatomic) NSString * uid;
		[Export ("uid")]
		string Uid { get; }
	}

	// @interface MAOfflineItem : NSObject
	[BaseType (typeof(NSObject))]
	interface MAOfflineItem
	{
		// @property (readonly, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * jianpin;
		[Export ("jianpin")]
		string Jianpin { get; }

		// @property (readonly, copy, nonatomic) NSString * pinyin;
		[Export ("pinyin")]
		string Pinyin { get; }

		// @property (readonly, copy, nonatomic) NSString * adcode;
		[Export ("adcode")]
		string Adcode { get; }

		// @property (readonly, assign, nonatomic) long long size;
		[Export ("size")]
		long Size { get; }

		// @property (readonly, assign, nonatomic) MAOfflineItemStatus itemStatus;
		[Export ("itemStatus", ArgumentSemantic.Assign)]
		MAOfflineItemStatus ItemStatus { get; }

		// @property (readonly, assign, nonatomic) long long downloadedSize;
		[Export ("downloadedSize")]
		long DownloadedSize { get; }
	}

	// @interface MAOfflineCity : MAOfflineItem
	[BaseType (typeof(MAOfflineItem))]
	interface MAOfflineCity
	{
		// @property (readonly, copy, nonatomic) NSString * cityCode;
		[Export ("cityCode")]
		string CityCode { get; }
	}

	// @interface MAOfflineItemCommonCity : MAOfflineCity
	[BaseType (typeof(MAOfflineCity))]
	interface MAOfflineItemCommonCity
	{
		// @property (nonatomic, weak) MAOfflineItem * province;
		[Export ("province", ArgumentSemantic.Weak)]
		MAOfflineItem Province { get; set; }
	}

	// @interface MAOfflineProvince : MAOfflineItem
	[BaseType (typeof(MAOfflineItem))]
	interface MAOfflineProvince
	{
		// @property (readonly, nonatomic, strong) NSArray * cities;
		[Export ("cities", ArgumentSemantic.Strong)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Cities { get; }
	}

	// @interface MAOfflineItemNationWide : MAOfflineCity
	[BaseType (typeof(MAOfflineCity))]
	interface MAOfflineItemNationWide
	{
	}

	// @interface MAOfflineItemMunicipality : MAOfflineCity
	[BaseType (typeof(MAOfflineCity))]
	interface MAOfflineItemMunicipality
	{
	}


	// typedef void (^MAOfflineMapDownloadBlock)(MAOfflineItem *, MAOfflineMapDownloadStatus, id);
	delegate void MAOfflineMapDownloadBlock (MAOfflineItem arg0, MAOfflineMapDownloadStatus arg1, NSObject arg2);

	// typedef void (^MAOfflineMapNewestVersionBlock)(BOOL);
	delegate void MAOfflineMapNewestVersionBlock (bool arg0);

	// @interface MAOfflineMap : NSObject
	[BaseType (typeof(NSObject))]
	interface MAOfflineMap
	{
		// +(MAOfflineMap *)sharedOfflineMap;
		[Static]
		[Export ("sharedOfflineMap")]
		// [Verify (MethodToProperty)]
		MAOfflineMap SharedOfflineMap { get; }

		// @property (readonly, nonatomic) NSArray<MAOfflineProvince *> * provinces;
		[Export ("provinces")]
		MAOfflineProvince[] Provinces { get; }

		// @property (readonly, nonatomic) NSArray<MAOfflineItemMunicipality *> * municipalities;
		[Export ("municipalities")]
		MAOfflineItemMunicipality[] Municipalities { get; }

		// @property (readonly, nonatomic) MAOfflineItemNationWide * nationWide;
		[Export ("nationWide")]
		MAOfflineItemNationWide NationWide { get; }

		// @property (readonly, nonatomic) NSArray<MAOfflineCity *> * cities;
		[Export ("cities")]
		MAOfflineCity[] Cities { get; }

		// @property (readonly, nonatomic) NSString * version;
		[Export ("version")]
		string Version { get; }

		// -(void)setupWithCompletionBlock:(void (^)(BOOL))block;
		[Export ("setupWithCompletionBlock:")]
		void SetupWithCompletionBlock (Action<bool> block);

		// -(void)downloadItem:(MAOfflineItem *)item shouldContinueWhenAppEntersBackground:(BOOL)shouldContinueWhenAppEntersBackground downloadBlock:(MAOfflineMapDownloadBlock)downloadBlock;
		[Export ("downloadItem:shouldContinueWhenAppEntersBackground:downloadBlock:")]
		void DownloadItem (MAOfflineItem item, bool shouldContinueWhenAppEntersBackground, MAOfflineMapDownloadBlock downloadBlock);

		// -(BOOL)isDownloadingForItem:(MAOfflineItem *)item;
		[Export ("isDownloadingForItem:")]
		bool IsDownloadingForItem (MAOfflineItem item);

		// -(BOOL)pauseItem:(MAOfflineItem *)item;
		[Export ("pauseItem:")]
		bool PauseItem (MAOfflineItem item);

		// -(void)deleteItem:(MAOfflineItem *)item;
		[Export ("deleteItem:")]
		void DeleteItem (MAOfflineItem item);

		// -(void)cancelAll;
		[Export ("cancelAll")]
		void CancelAll ();

		// -(void)clearDisk;
		[Export ("clearDisk")]
		void ClearDisk ();

		// -(void)checkNewestVersion:(MAOfflineMapNewestVersionBlock)newestVersionBlock;
		[Export ("checkNewestVersion:")]
		void CheckNewestVersion (MAOfflineMapNewestVersionBlock newestVersionBlock);
	}

	// @interface MAOfflineMapViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface MAOfflineMapViewController
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		MAOfflineMapViewController SharedInstance ();

		// @property (readonly, nonatomic) MAOfflineMap * offlineMap;
		[Export ("offlineMap")]
		MAOfflineMap OfflineMap { get; }
	}

	// @interface MATracePoint : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface MATracePoint : INSCoding
	{
		// @property (assign, nonatomic) CLLocationDegrees latitude;
		[Export ("latitude")]
		double Latitude { get; set; }

		// @property (assign, nonatomic) CLLocationDegrees longitude;
		[Export ("longitude")]
		double Longitude { get; set; }
	}

	// @interface MATraceLocation : NSObject
	[BaseType (typeof(NSObject))]
	interface MATraceLocation
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D loc;
		[Export ("loc", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Loc { get; set; }

		// @property (assign, nonatomic) double angle;
		[Export ("angle")]
		double Angle { get; set; }

		// @property (assign, nonatomic) double speed;
		[Export ("speed")]
		double Speed { get; set; }

		// @property (assign, nonatomic) double time;
		[Export ("time")]
		double Time { get; set; }
	}

	// typedef void (^MAProcessingCallback)(int, NSArray<MATracePoint *> *);
	delegate void MAProcessingCallback (int arg0, MATracePoint[] arg1);

	// typedef void (^MAFinishCallback)(NSArray<MATracePoint *> *, double);
	delegate void MAFinishCallback (MATracePoint[] arg0, double arg1);

	// typedef void (^MAFailedCallback)(int, NSString *);
	delegate void MAFailedCallback (int arg0, string arg1);

	// typedef void (^MATraceLocationCallback)(NSArray<CLLocation *> *, NSArray<MATracePoint *> *, double, NSError *);
	delegate void MATraceLocationCallback (CLLocation[] arg0, MATracePoint[] arg1, double arg2, NSError arg3);

	// @protocol MATraceDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MATraceDelegate
	{
		// @required -(void)traceManager:(MATraceManager *)manager didTrace:(NSArray<CLLocation *> *)locations correct:(NSArray<MATracePoint *> *)tracePoints distance:(double)distance withError:(NSError *)error;
		[Abstract]
		[Export ("traceManager:didTrace:correct:distance:withError:")]
		void TraceManager (MATraceManager manager, CLLocation[] locations, MATracePoint[] tracePoints, double distance, NSError error);

		// @optional -(void)mapViewRequireLocationAuth:(CLLocationManager *)locationManager;
		[Export ("mapViewRequireLocationAuth:")]
		void MapViewRequireLocationAuth (CLLocationManager locationManager);
	}

	// @interface MATraceManager : NSObject
	[BaseType (typeof(NSObject))]
	interface MATraceManager
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		MATraceManager SharedInstance ();

		// -(NSOperation *)queryProcessedTraceWith:(NSArray<MATraceLocation *> *)locations type:(AMapCoordinateType)type processingCallback:(MAProcessingCallback)processingCallback finishCallback:(MAFinishCallback)finishCallback failedCallback:(MAFailedCallback)failedCallback;
		[Export ("queryProcessedTraceWith:type:processingCallback:finishCallback:failedCallback:")]
		NSOperation QueryProcessedTraceWith (MATraceLocation[] locations, AMapCoordinateType type, MAProcessingCallback processingCallback, MAFinishCallback finishCallback, MAFailedCallback failedCallback);

		[Wrap ("WeakDelegate")]
		MATraceDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MATraceDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}

	// @interface MAHeatMapVectorGridNode : NSObject
	[BaseType (typeof(NSObject))]
	interface MAHeatMapVectorGridNode
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }
	}

	// @interface MAHeatMapVectorGrid : NSObject
	[BaseType (typeof(NSObject))]
	interface MAHeatMapVectorGrid
	{
		// @property (copy, nonatomic) NSArray<MAHeatMapVectorGridNode *> * inputNodes;
		[Export ("inputNodes", ArgumentSemantic.Copy)]
		MAHeatMapVectorGridNode[] InputNodes { get; set; }

		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }
	}

	// @interface MAHeatMapVectorGridOverlayOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface MAHeatMapVectorGridOverlayOptions
	{
		// @property (assign, nonatomic) MAHeatMapType type;
		[Export ("type", ArgumentSemantic.Assign)]
		MAHeatMapType Type { get; set; }

		// @property (assign, nonatomic) BOOL visible;
		[Export ("visible")]
		bool Visible { get; set; }

		// @property (copy, nonatomic) NSArray<MAHeatMapVectorGrid *> * inputGrids;
		[Export ("inputGrids", ArgumentSemantic.Copy)]
		MAHeatMapVectorGrid[] InputGrids { get; set; }

		// @property (assign, nonatomic) CGFloat minZoom;
		[Export ("minZoom")]
		nfloat MinZoom { get; set; }

		// @property (assign, nonatomic) CGFloat maxZoom;
		[Export ("maxZoom")]
		nfloat MaxZoom { get; set; }
	}

	// @interface MAHeatMapVectorGridOverlay : MAShape <MAOverlay>
	[BaseType (typeof(MAShape))]
	interface MAHeatMapVectorGridOverlay : MAOverlay
	{
		// @property (nonatomic, strong) MAHeatMapVectorGridOverlayOptions * option;
		[Export ("option", ArgumentSemantic.Strong)]
		MAHeatMapVectorGridOverlayOptions Option { get; set; }

		// +(instancetype)heatMapOverlayWithOption:(MAHeatMapVectorGridOverlayOptions *)option;
		[Static]
		[Export ("heatMapOverlayWithOption:")]
		MAHeatMapVectorGridOverlay HeatMapOverlayWithOption (MAHeatMapVectorGridOverlayOptions option);
	}

	// @interface MAHeatMapVectorGridOverlayRenderer : MAOverlayRenderer
	[BaseType (typeof(MAOverlayRenderer))]
	interface MAHeatMapVectorGridOverlayRenderer
	{
		// @property (readonly, nonatomic) MAHeatMapVectorGridOverlay * heatOverlay;
		[Export ("heatOverlay")]
		MAHeatMapVectorGridOverlay HeatOverlay { get; }

		// -(instancetype)initWithHeatOverlay:(MAHeatMapVectorGridOverlay *)heatOverlay;
		[Export ("initWithHeatOverlay:")]
		NativeHandle Constructor (MAHeatMapVectorGridOverlay heatOverlay);
	}

	// @interface MAMVTTileOverlayOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface MAMVTTileOverlayOptions
	{
		// @property (copy, nonatomic) NSString * url;
		[Export ("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSString * key;
		[Export ("key")]
		string Key { get; set; }

		// @property (copy, nonatomic) NSString * Id;
		[Export ("Id")]
		string Id { get; set; }

		// @property (assign, nonatomic) BOOL visible;
		[Export ("visible")]
		bool Visible { get; set; }
	}

	// @interface MAMVTTileOverlay : MATileOverlay
	[BaseType (typeof(MATileOverlay))]
	interface MAMVTTileOverlay
	{
		// @property (readonly, nonatomic, strong) MAMVTTileOverlayOptions * option;
		[Export ("option", ArgumentSemantic.Strong)]
		MAMVTTileOverlayOptions Option { get; }

		// +(instancetype)mvtTileOverlayWithOption:(MAMVTTileOverlayOptions *)option;
		[Static]
		[Export ("mvtTileOverlayWithOption:")]
		MAMVTTileOverlay MvtTileOverlayWithOption (MAMVTTileOverlayOptions option);
	}

	// @interface MAMVTTileOverlayRenderer : MATileOverlayRenderer
	[BaseType (typeof(MATileOverlayRenderer))]
	interface MAMVTTileOverlayRenderer
	{
	}

}
