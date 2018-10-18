using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/AdaptiveCardObjectModel", DoNotGenerateAcw=true)]
	public partial class AdaptiveCardObjectModel : global::Java.Lang.Object {


		public static class InterfaceConsts {

			// The following are fields from: io.adaptivecards.objectmodel.AdaptiveCardObjectModelConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/interface[@name='AdaptiveCardObjectModelConstants']/field[@name='__ANDROID__']"
			[Register ("__ANDROID__")]
			public const int Android = (int) 1;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/AdaptiveCardObjectModel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdaptiveCardObjectModel); }
		}

		protected AdaptiveCardObjectModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/constructor[@name='AdaptiveCardObjectModel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdaptiveCardObjectModel ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AdaptiveCardObjectModel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ActionAlignmentFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ActionAlignmentFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ActionAlignmentFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionAlignment;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ActionAlignment ActionAlignmentFromString (string p0)
		{
			if (id_ActionAlignmentFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_ActionAlignmentFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ActionAlignmentFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionAlignment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ActionAlignment __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionAlignment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ActionAlignmentFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ActionAlignmentToString_Lio_adaptivecards_objectmodel_ActionAlignment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ActionAlignmentToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionAlignment']]"
		[Register ("ActionAlignmentToString", "(Lio/adaptivecards/objectmodel/ActionAlignment;)Ljava/lang/String;", "")]
		public static unsafe string ActionAlignmentToString (global::IO.Adaptivecards.Objectmodel.ActionAlignment p0)
		{
			if (id_ActionAlignmentToString_Lio_adaptivecards_objectmodel_ActionAlignment_ == IntPtr.Zero)
				id_ActionAlignmentToString_Lio_adaptivecards_objectmodel_ActionAlignment_ = JNIEnv.GetStaticMethodID (class_ref, "ActionAlignmentToString", "(Lio/adaptivecards/objectmodel/ActionAlignment;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ActionAlignmentToString_Lio_adaptivecards_objectmodel_ActionAlignment_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ActionModeFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ActionModeFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ActionModeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionMode;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ActionMode ActionModeFromString (string p0)
		{
			if (id_ActionModeFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_ActionModeFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ActionModeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ActionMode __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ActionModeFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ActionModeToString_Lio_adaptivecards_objectmodel_ActionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ActionModeToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionMode']]"
		[Register ("ActionModeToString", "(Lio/adaptivecards/objectmodel/ActionMode;)Ljava/lang/String;", "")]
		public static unsafe string ActionModeToString (global::IO.Adaptivecards.Objectmodel.ActionMode p0)
		{
			if (id_ActionModeToString_Lio_adaptivecards_objectmodel_ActionMode_ == IntPtr.Zero)
				id_ActionModeToString_Lio_adaptivecards_objectmodel_ActionMode_ = JNIEnv.GetStaticMethodID (class_ref, "ActionModeToString", "(Lio/adaptivecards/objectmodel/ActionMode;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ActionModeToString_Lio_adaptivecards_objectmodel_ActionMode_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ActionTypeFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ActionTypeFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ActionTypeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionType;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ActionType ActionTypeFromString (string p0)
		{
			if (id_ActionTypeFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_ActionTypeFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ActionTypeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ActionType __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ActionTypeFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ActionTypeToString_Lio_adaptivecards_objectmodel_ActionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ActionTypeToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionType']]"
		[Register ("ActionTypeToString", "(Lio/adaptivecards/objectmodel/ActionType;)Ljava/lang/String;", "")]
		public static unsafe string ActionTypeToString (global::IO.Adaptivecards.Objectmodel.ActionType p0)
		{
			if (id_ActionTypeToString_Lio_adaptivecards_objectmodel_ActionType_ == IntPtr.Zero)
				id_ActionTypeToString_Lio_adaptivecards_objectmodel_ActionType_ = JNIEnv.GetStaticMethodID (class_ref, "ActionTypeToString", "(Lio/adaptivecards/objectmodel/ActionType;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ActionTypeToString_Lio_adaptivecards_objectmodel_ActionType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ActionsOrientationFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ActionsOrientationFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ActionsOrientationFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionsOrientation;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ActionsOrientation ActionsOrientationFromString (string p0)
		{
			if (id_ActionsOrientationFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_ActionsOrientationFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ActionsOrientationFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionsOrientation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ActionsOrientation __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsOrientation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ActionsOrientationFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ActionsOrientationToString_Lio_adaptivecards_objectmodel_ActionsOrientation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ActionsOrientationToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionsOrientation']]"
		[Register ("ActionsOrientationToString", "(Lio/adaptivecards/objectmodel/ActionsOrientation;)Ljava/lang/String;", "")]
		public static unsafe string ActionsOrientationToString (global::IO.Adaptivecards.Objectmodel.ActionsOrientation p0)
		{
			if (id_ActionsOrientationToString_Lio_adaptivecards_objectmodel_ActionsOrientation_ == IntPtr.Zero)
				id_ActionsOrientationToString_Lio_adaptivecards_objectmodel_ActionsOrientation_ = JNIEnv.GetStaticMethodID (class_ref, "ActionsOrientationToString", "(Lio/adaptivecards/objectmodel/ActionsOrientation;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ActionsOrientationToString_Lio_adaptivecards_objectmodel_ActionsOrientation_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_AdaptiveCardSchemaKeyFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='AdaptiveCardSchemaKeyFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("AdaptiveCardSchemaKeyFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/AdaptiveCardSchemaKey;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.AdaptiveCardSchemaKey AdaptiveCardSchemaKeyFromString (string p0)
		{
			if (id_AdaptiveCardSchemaKeyFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_AdaptiveCardSchemaKeyFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "AdaptiveCardSchemaKeyFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/AdaptiveCardSchemaKey;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.AdaptiveCardSchemaKey __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardSchemaKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_AdaptiveCardSchemaKeyFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_AdaptiveCardSchemaKeyToString_Lio_adaptivecards_objectmodel_AdaptiveCardSchemaKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='AdaptiveCardSchemaKeyToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.AdaptiveCardSchemaKey']]"
		[Register ("AdaptiveCardSchemaKeyToString", "(Lio/adaptivecards/objectmodel/AdaptiveCardSchemaKey;)Ljava/lang/String;", "")]
		public static unsafe string AdaptiveCardSchemaKeyToString (global::IO.Adaptivecards.Objectmodel.AdaptiveCardSchemaKey p0)
		{
			if (id_AdaptiveCardSchemaKeyToString_Lio_adaptivecards_objectmodel_AdaptiveCardSchemaKey_ == IntPtr.Zero)
				id_AdaptiveCardSchemaKeyToString_Lio_adaptivecards_objectmodel_AdaptiveCardSchemaKey_ = JNIEnv.GetStaticMethodID (class_ref, "AdaptiveCardSchemaKeyToString", "(Lio/adaptivecards/objectmodel/AdaptiveCardSchemaKey;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_AdaptiveCardSchemaKeyToString_Lio_adaptivecards_objectmodel_AdaptiveCardSchemaKey_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_CardElementTypeFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='CardElementTypeFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("CardElementTypeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/CardElementType;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.CardElementType CardElementTypeFromString (string p0)
		{
			if (id_CardElementTypeFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_CardElementTypeFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "CardElementTypeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/CardElementType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.CardElementType __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_CardElementTypeFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_CardElementTypeToString_Lio_adaptivecards_objectmodel_CardElementType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='CardElementTypeToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.CardElementType']]"
		[Register ("CardElementTypeToString", "(Lio/adaptivecards/objectmodel/CardElementType;)Ljava/lang/String;", "")]
		public static unsafe string CardElementTypeToString (global::IO.Adaptivecards.Objectmodel.CardElementType p0)
		{
			if (id_CardElementTypeToString_Lio_adaptivecards_objectmodel_CardElementType_ == IntPtr.Zero)
				id_CardElementTypeToString_Lio_adaptivecards_objectmodel_CardElementType_ = JNIEnv.GetStaticMethodID (class_ref, "CardElementTypeToString", "(Lio/adaptivecards/objectmodel/CardElementType;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_CardElementTypeToString_Lio_adaptivecards_objectmodel_CardElementType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ChoiceSetStyleFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ChoiceSetStyleFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ChoiceSetStyleFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ChoiceSetStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle ChoiceSetStyleFromString (string p0)
		{
			if (id_ChoiceSetStyleFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_ChoiceSetStyleFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ChoiceSetStyleFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ChoiceSetStyle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ChoiceSetStyleFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ChoiceSetStyleToString_Lio_adaptivecards_objectmodel_ChoiceSetStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ChoiceSetStyleToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ChoiceSetStyle']]"
		[Register ("ChoiceSetStyleToString", "(Lio/adaptivecards/objectmodel/ChoiceSetStyle;)Ljava/lang/String;", "")]
		public static unsafe string ChoiceSetStyleToString (global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle p0)
		{
			if (id_ChoiceSetStyleToString_Lio_adaptivecards_objectmodel_ChoiceSetStyle_ == IntPtr.Zero)
				id_ChoiceSetStyleToString_Lio_adaptivecards_objectmodel_ChoiceSetStyle_ = JNIEnv.GetStaticMethodID (class_ref, "ChoiceSetStyleToString", "(Lio/adaptivecards/objectmodel/ChoiceSetStyle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ChoiceSetStyleToString_Lio_adaptivecards_objectmodel_ChoiceSetStyle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ContainerStyleFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ContainerStyleFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ContainerStyleFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ContainerStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ContainerStyle ContainerStyleFromString (string p0)
		{
			if (id_ContainerStyleFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_ContainerStyleFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ContainerStyleFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ContainerStyle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ContainerStyle __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ContainerStyleFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ContainerStyleToString_Lio_adaptivecards_objectmodel_ContainerStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ContainerStyleToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ContainerStyle']]"
		[Register ("ContainerStyleToString", "(Lio/adaptivecards/objectmodel/ContainerStyle;)Ljava/lang/String;", "")]
		public static unsafe string ContainerStyleToString (global::IO.Adaptivecards.Objectmodel.ContainerStyle p0)
		{
			if (id_ContainerStyleToString_Lio_adaptivecards_objectmodel_ContainerStyle_ == IntPtr.Zero)
				id_ContainerStyleToString_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNIEnv.GetStaticMethodID (class_ref, "ContainerStyleToString", "(Lio/adaptivecards/objectmodel/ContainerStyle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ContainerStyleToString_Lio_adaptivecards_objectmodel_ContainerStyle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ForegroundColorFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ForegroundColorFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ForegroundColorFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ForegroundColor;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ForegroundColor ForegroundColorFromString (string p0)
		{
			if (id_ForegroundColorFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_ForegroundColorFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ForegroundColorFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ForegroundColor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ForegroundColor __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ForegroundColorFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ForegroundColorToString_Lio_adaptivecards_objectmodel_ForegroundColor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ForegroundColorToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ForegroundColor']]"
		[Register ("ForegroundColorToString", "(Lio/adaptivecards/objectmodel/ForegroundColor;)Ljava/lang/String;", "")]
		public static unsafe string ForegroundColorToString (global::IO.Adaptivecards.Objectmodel.ForegroundColor p0)
		{
			if (id_ForegroundColorToString_Lio_adaptivecards_objectmodel_ForegroundColor_ == IntPtr.Zero)
				id_ForegroundColorToString_Lio_adaptivecards_objectmodel_ForegroundColor_ = JNIEnv.GetStaticMethodID (class_ref, "ForegroundColorToString", "(Lio/adaptivecards/objectmodel/ForegroundColor;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ForegroundColorToString_Lio_adaptivecards_objectmodel_ForegroundColor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_HeightTypeFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='HeightTypeFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("HeightTypeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/HeightType;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.HeightType HeightTypeFromString (string p0)
		{
			if (id_HeightTypeFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_HeightTypeFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "HeightTypeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/HeightType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.HeightType __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HeightType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_HeightTypeFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_HeightTypeToString_Lio_adaptivecards_objectmodel_HeightType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='HeightTypeToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.HeightType']]"
		[Register ("HeightTypeToString", "(Lio/adaptivecards/objectmodel/HeightType;)Ljava/lang/String;", "")]
		public static unsafe string HeightTypeToString (global::IO.Adaptivecards.Objectmodel.HeightType p0)
		{
			if (id_HeightTypeToString_Lio_adaptivecards_objectmodel_HeightType_ == IntPtr.Zero)
				id_HeightTypeToString_Lio_adaptivecards_objectmodel_HeightType_ = JNIEnv.GetStaticMethodID (class_ref, "HeightTypeToString", "(Lio/adaptivecards/objectmodel/HeightType;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_HeightTypeToString_Lio_adaptivecards_objectmodel_HeightType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_HorizontalAlignmentFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='HorizontalAlignmentFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("HorizontalAlignmentFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/HorizontalAlignment;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.HorizontalAlignment HorizontalAlignmentFromString (string p0)
		{
			if (id_HorizontalAlignmentFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_HorizontalAlignmentFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "HorizontalAlignmentFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/HorizontalAlignment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.HorizontalAlignment __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_HorizontalAlignmentFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_HorizontalAlignmentToString_Lio_adaptivecards_objectmodel_HorizontalAlignment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='HorizontalAlignmentToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.HorizontalAlignment']]"
		[Register ("HorizontalAlignmentToString", "(Lio/adaptivecards/objectmodel/HorizontalAlignment;)Ljava/lang/String;", "")]
		public static unsafe string HorizontalAlignmentToString (global::IO.Adaptivecards.Objectmodel.HorizontalAlignment p0)
		{
			if (id_HorizontalAlignmentToString_Lio_adaptivecards_objectmodel_HorizontalAlignment_ == IntPtr.Zero)
				id_HorizontalAlignmentToString_Lio_adaptivecards_objectmodel_HorizontalAlignment_ = JNIEnv.GetStaticMethodID (class_ref, "HorizontalAlignmentToString", "(Lio/adaptivecards/objectmodel/HorizontalAlignment;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_HorizontalAlignmentToString_Lio_adaptivecards_objectmodel_HorizontalAlignment_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_IconPlacementFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='IconPlacementFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("IconPlacementFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/IconPlacement;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.IconPlacement IconPlacementFromString (string p0)
		{
			if (id_IconPlacementFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_IconPlacementFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "IconPlacementFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/IconPlacement;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.IconPlacement __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.IconPlacement> (JNIEnv.CallStaticObjectMethod  (class_ref, id_IconPlacementFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_IconPlacementToString_Lio_adaptivecards_objectmodel_IconPlacement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='IconPlacementToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.IconPlacement']]"
		[Register ("IconPlacementToString", "(Lio/adaptivecards/objectmodel/IconPlacement;)Ljava/lang/String;", "")]
		public static unsafe string IconPlacementToString (global::IO.Adaptivecards.Objectmodel.IconPlacement p0)
		{
			if (id_IconPlacementToString_Lio_adaptivecards_objectmodel_IconPlacement_ == IntPtr.Zero)
				id_IconPlacementToString_Lio_adaptivecards_objectmodel_IconPlacement_ = JNIEnv.GetStaticMethodID (class_ref, "IconPlacementToString", "(Lio/adaptivecards/objectmodel/IconPlacement;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_IconPlacementToString_Lio_adaptivecards_objectmodel_IconPlacement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ImageSizeFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ImageSizeFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ImageSizeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ImageSize;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ImageSize ImageSizeFromString (string p0)
		{
			if (id_ImageSizeFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_ImageSizeFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ImageSizeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ImageSize;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ImageSize __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ImageSizeFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ImageSizeToString_Lio_adaptivecards_objectmodel_ImageSize_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ImageSizeToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageSize']]"
		[Register ("ImageSizeToString", "(Lio/adaptivecards/objectmodel/ImageSize;)Ljava/lang/String;", "")]
		public static unsafe string ImageSizeToString (global::IO.Adaptivecards.Objectmodel.ImageSize p0)
		{
			if (id_ImageSizeToString_Lio_adaptivecards_objectmodel_ImageSize_ == IntPtr.Zero)
				id_ImageSizeToString_Lio_adaptivecards_objectmodel_ImageSize_ = JNIEnv.GetStaticMethodID (class_ref, "ImageSizeToString", "(Lio/adaptivecards/objectmodel/ImageSize;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ImageSizeToString_Lio_adaptivecards_objectmodel_ImageSize_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ImageStyleFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ImageStyleFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ImageStyleFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ImageStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ImageStyle ImageStyleFromString (string p0)
		{
			if (id_ImageStyleFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_ImageStyleFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ImageStyleFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ImageStyle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ImageStyle __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ImageStyleFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ImageStyleToString_Lio_adaptivecards_objectmodel_ImageStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='ImageStyleToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageStyle']]"
		[Register ("ImageStyleToString", "(Lio/adaptivecards/objectmodel/ImageStyle;)Ljava/lang/String;", "")]
		public static unsafe string ImageStyleToString (global::IO.Adaptivecards.Objectmodel.ImageStyle p0)
		{
			if (id_ImageStyleToString_Lio_adaptivecards_objectmodel_ImageStyle_ == IntPtr.Zero)
				id_ImageStyleToString_Lio_adaptivecards_objectmodel_ImageStyle_ = JNIEnv.GetStaticMethodID (class_ref, "ImageStyleToString", "(Lio/adaptivecards/objectmodel/ImageStyle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ImageStyleToString_Lio_adaptivecards_objectmodel_ImageStyle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_SeparatorThicknessFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='SeparatorThicknessFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SeparatorThicknessFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/SeparatorThickness;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.SeparatorThickness SeparatorThicknessFromString (string p0)
		{
			if (id_SeparatorThicknessFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_SeparatorThicknessFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SeparatorThicknessFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/SeparatorThickness;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.SeparatorThickness __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorThickness> (JNIEnv.CallStaticObjectMethod  (class_ref, id_SeparatorThicknessFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_SeparatorThicknessToString_Lio_adaptivecards_objectmodel_SeparatorThickness_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='SeparatorThicknessToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.SeparatorThickness']]"
		[Register ("SeparatorThicknessToString", "(Lio/adaptivecards/objectmodel/SeparatorThickness;)Ljava/lang/String;", "")]
		public static unsafe string SeparatorThicknessToString (global::IO.Adaptivecards.Objectmodel.SeparatorThickness p0)
		{
			if (id_SeparatorThicknessToString_Lio_adaptivecards_objectmodel_SeparatorThickness_ == IntPtr.Zero)
				id_SeparatorThicknessToString_Lio_adaptivecards_objectmodel_SeparatorThickness_ = JNIEnv.GetStaticMethodID (class_ref, "SeparatorThicknessToString", "(Lio/adaptivecards/objectmodel/SeparatorThickness;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_SeparatorThicknessToString_Lio_adaptivecards_objectmodel_SeparatorThickness_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_SpacingFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='SpacingFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SpacingFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/Spacing;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Spacing SpacingFromString (string p0)
		{
			if (id_SpacingFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_SpacingFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SpacingFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/Spacing;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.Spacing __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (JNIEnv.CallStaticObjectMethod  (class_ref, id_SpacingFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_SpacingToString_Lio_adaptivecards_objectmodel_Spacing_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='SpacingToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.Spacing']]"
		[Register ("SpacingToString", "(Lio/adaptivecards/objectmodel/Spacing;)Ljava/lang/String;", "")]
		public static unsafe string SpacingToString (global::IO.Adaptivecards.Objectmodel.Spacing p0)
		{
			if (id_SpacingToString_Lio_adaptivecards_objectmodel_Spacing_ == IntPtr.Zero)
				id_SpacingToString_Lio_adaptivecards_objectmodel_Spacing_ = JNIEnv.GetStaticMethodID (class_ref, "SpacingToString", "(Lio/adaptivecards/objectmodel/Spacing;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_SpacingToString_Lio_adaptivecards_objectmodel_Spacing_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_TextInputStyleFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='TextInputStyleFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("TextInputStyleFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextInputStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextInputStyle TextInputStyleFromString (string p0)
		{
			if (id_TextInputStyleFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_TextInputStyleFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "TextInputStyleFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextInputStyle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.TextInputStyle __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_TextInputStyleFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_TextInputStyleToString_Lio_adaptivecards_objectmodel_TextInputStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='TextInputStyleToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextInputStyle']]"
		[Register ("TextInputStyleToString", "(Lio/adaptivecards/objectmodel/TextInputStyle;)Ljava/lang/String;", "")]
		public static unsafe string TextInputStyleToString (global::IO.Adaptivecards.Objectmodel.TextInputStyle p0)
		{
			if (id_TextInputStyleToString_Lio_adaptivecards_objectmodel_TextInputStyle_ == IntPtr.Zero)
				id_TextInputStyleToString_Lio_adaptivecards_objectmodel_TextInputStyle_ = JNIEnv.GetStaticMethodID (class_ref, "TextInputStyleToString", "(Lio/adaptivecards/objectmodel/TextInputStyle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_TextInputStyleToString_Lio_adaptivecards_objectmodel_TextInputStyle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_TextSizeFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='TextSizeFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("TextSizeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextSize;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextSize TextSizeFromString (string p0)
		{
			if (id_TextSizeFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_TextSizeFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "TextSizeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextSize;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.TextSize __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextSize> (JNIEnv.CallStaticObjectMethod  (class_ref, id_TextSizeFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_TextSizeToString_Lio_adaptivecards_objectmodel_TextSize_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='TextSizeToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextSize']]"
		[Register ("TextSizeToString", "(Lio/adaptivecards/objectmodel/TextSize;)Ljava/lang/String;", "")]
		public static unsafe string TextSizeToString (global::IO.Adaptivecards.Objectmodel.TextSize p0)
		{
			if (id_TextSizeToString_Lio_adaptivecards_objectmodel_TextSize_ == IntPtr.Zero)
				id_TextSizeToString_Lio_adaptivecards_objectmodel_TextSize_ = JNIEnv.GetStaticMethodID (class_ref, "TextSizeToString", "(Lio/adaptivecards/objectmodel/TextSize;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_TextSizeToString_Lio_adaptivecards_objectmodel_TextSize_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_TextWeightFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='TextWeightFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("TextWeightFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextWeight;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextWeight TextWeightFromString (string p0)
		{
			if (id_TextWeightFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_TextWeightFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "TextWeightFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextWeight;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.TextWeight __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (JNIEnv.CallStaticObjectMethod  (class_ref, id_TextWeightFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_TextWeightToString_Lio_adaptivecards_objectmodel_TextWeight_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='TextWeightToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextWeight']]"
		[Register ("TextWeightToString", "(Lio/adaptivecards/objectmodel/TextWeight;)Ljava/lang/String;", "")]
		public static unsafe string TextWeightToString (global::IO.Adaptivecards.Objectmodel.TextWeight p0)
		{
			if (id_TextWeightToString_Lio_adaptivecards_objectmodel_TextWeight_ == IntPtr.Zero)
				id_TextWeightToString_Lio_adaptivecards_objectmodel_TextWeight_ = JNIEnv.GetStaticMethodID (class_ref, "TextWeightToString", "(Lio/adaptivecards/objectmodel/TextWeight;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_TextWeightToString_Lio_adaptivecards_objectmodel_TextWeight_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_VerticalContentAlignmentFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='VerticalContentAlignmentFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("VerticalContentAlignmentFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/VerticalContentAlignment;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment VerticalContentAlignmentFromString (string p0)
		{
			if (id_VerticalContentAlignmentFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_VerticalContentAlignmentFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "VerticalContentAlignmentFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/VerticalContentAlignment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_VerticalContentAlignmentFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_VerticalContentAlignmentToString_Lio_adaptivecards_objectmodel_VerticalContentAlignment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardObjectModel']/method[@name='VerticalContentAlignmentToString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.VerticalContentAlignment']]"
		[Register ("VerticalContentAlignmentToString", "(Lio/adaptivecards/objectmodel/VerticalContentAlignment;)Ljava/lang/String;", "")]
		public static unsafe string VerticalContentAlignmentToString (global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment p0)
		{
			if (id_VerticalContentAlignmentToString_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ == IntPtr.Zero)
				id_VerticalContentAlignmentToString_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ = JNIEnv.GetStaticMethodID (class_ref, "VerticalContentAlignmentToString", "(Lio/adaptivecards/objectmodel/VerticalContentAlignment;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_VerticalContentAlignmentToString_Lio_adaptivecards_objectmodel_VerticalContentAlignment_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
