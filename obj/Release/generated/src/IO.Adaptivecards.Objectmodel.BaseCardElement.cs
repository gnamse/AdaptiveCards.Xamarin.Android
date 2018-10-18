using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/BaseCardElement", DoNotGenerateAcw=true)]
	public partial class BaseCardElement : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/BaseCardElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseCardElement); }
		}

		protected BaseCardElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/constructor[@name='BaseCardElement' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/BaseCardElement;)V", "")]
		public unsafe BaseCardElement (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseCardElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/BaseCardElement;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/BaseCardElement;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/BaseCardElement;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_BaseCardElement_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_BaseCardElement_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_CardElementType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/constructor[@name='BaseCardElement' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.CardElementType']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/CardElementType;)V", "")]
		public unsafe BaseCardElement (global::IO.Adaptivecards.Objectmodel.CardElementType p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseCardElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/CardElementType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/CardElementType;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_CardElementType_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_CardElementType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/CardElementType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_CardElementType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_CardElementType_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/constructor[@name='BaseCardElement' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.CardElementType'] and parameter[2][@type='io.adaptivecards.objectmodel.Spacing'] and parameter[3][@type='boolean'] and parameter[4][@type='io.adaptivecards.objectmodel.HeightType']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/CardElementType;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HeightType;)V", "")]
		public unsafe BaseCardElement (global::IO.Adaptivecards.Objectmodel.CardElementType p0, global::IO.Adaptivecards.Objectmodel.Spacing p1, bool p2, global::IO.Adaptivecards.Objectmodel.HeightType p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (BaseCardElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/CardElementType;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HeightType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/CardElementType;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HeightType;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/CardElementType;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HeightType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/constructor[@name='BaseCardElement' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe BaseCardElement (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseCardElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JZ)V", __args);
					return;
				}

				if (id_ctor_JZ == IntPtr.Zero)
					id_ctor_JZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JZ, __args);
			} finally {
			}
		}

		static Delegate cb_GetAdditionalProperties;
#pragma warning disable 0169
		static Delegate GetGetAdditionalPropertiesHandler ()
		{
			if (cb_GetAdditionalProperties == null)
				cb_GetAdditionalProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdditionalProperties);
			return cb_GetAdditionalProperties;
		}

		static IntPtr n_GetAdditionalProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdditionalProperties);
		}
#pragma warning restore 0169

		static Delegate cb_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_;
#pragma warning disable 0169
		static Delegate GetSetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_Handler ()
		{
			if (cb_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_ == null)
				cb_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_);
			return cb_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_;
		}

		static void n_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.JsonValue p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdditionalProperties = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetAdditionalProperties;
		static IntPtr id_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.JsonValue AdditionalProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='GetAdditionalProperties' and count(parameter)=0]"
			[Register ("GetAdditionalProperties", "()Lio/adaptivecards/objectmodel/JsonValue;", "GetGetAdditionalPropertiesHandler")]
			get {
				if (id_GetAdditionalProperties == IntPtr.Zero)
					id_GetAdditionalProperties = JNIEnv.GetMethodID (class_ref, "GetAdditionalProperties", "()Lio/adaptivecards/objectmodel/JsonValue;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetAdditionalProperties), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAdditionalProperties", "()Lio/adaptivecards/objectmodel/JsonValue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='SetAdditionalProperties' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue']]"
			[Register ("SetAdditionalProperties", "(Lio/adaptivecards/objectmodel/JsonValue;)V", "GetSetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_Handler")]
			set {
				if (id_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_ == IntPtr.Zero)
					id_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_ = JNIEnv.GetMethodID (class_ref, "SetAdditionalProperties", "(Lio/adaptivecards/objectmodel/JsonValue;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetAdditionalProperties_Lio_adaptivecards_objectmodel_JsonValue_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetAdditionalProperties", "(Lio/adaptivecards/objectmodel/JsonValue;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetElementType;
#pragma warning disable 0169
		static Delegate GetGetElementTypeHandler ()
		{
			if (cb_GetElementType == null)
				cb_GetElementType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElementType);
			return cb_GetElementType;
		}

		static IntPtr n_GetElementType (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ElementType);
		}
#pragma warning restore 0169

		static IntPtr id_GetElementType;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.CardElementType ElementType {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='GetElementType' and count(parameter)=0]"
			[Register ("GetElementType", "()Lio/adaptivecards/objectmodel/CardElementType;", "GetGetElementTypeHandler")]
			get {
				if (id_GetElementType == IntPtr.Zero)
					id_GetElementType = JNIEnv.GetMethodID (class_ref, "GetElementType", "()Lio/adaptivecards/objectmodel/CardElementType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetElementType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetElementType", "()Lio/adaptivecards/objectmodel/CardElementType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetElementTypeString;
#pragma warning disable 0169
		static Delegate GetGetElementTypeStringHandler ()
		{
			if (cb_GetElementTypeString == null)
				cb_GetElementTypeString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElementTypeString);
			return cb_GetElementTypeString;
		}

		static IntPtr n_GetElementTypeString (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ElementTypeString);
		}
#pragma warning restore 0169

		static Delegate cb_SetElementTypeString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetElementTypeString_Ljava_lang_String_Handler ()
		{
			if (cb_SetElementTypeString_Ljava_lang_String_ == null)
				cb_SetElementTypeString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetElementTypeString_Ljava_lang_String_);
			return cb_SetElementTypeString_Ljava_lang_String_;
		}

		static void n_SetElementTypeString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ElementTypeString = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetElementTypeString;
		static IntPtr id_SetElementTypeString_Ljava_lang_String_;
		public virtual unsafe string ElementTypeString {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='GetElementTypeString' and count(parameter)=0]"
			[Register ("GetElementTypeString", "()Ljava/lang/String;", "GetGetElementTypeStringHandler")]
			get {
				if (id_GetElementTypeString == IntPtr.Zero)
					id_GetElementTypeString = JNIEnv.GetMethodID (class_ref, "GetElementTypeString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetElementTypeString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetElementTypeString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='SetElementTypeString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetElementTypeString", "(Ljava/lang/String;)V", "GetSetElementTypeString_Ljava_lang_String_Handler")]
			set {
				if (id_SetElementTypeString_Ljava_lang_String_ == IntPtr.Zero)
					id_SetElementTypeString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetElementTypeString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetElementTypeString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetElementTypeString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_GetHeight == null)
				cb_GetHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeight);
			return cb_GetHeight;
		}

		static IntPtr n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Height);
		}
#pragma warning restore 0169

		static Delegate cb_SetHeight_Lio_adaptivecards_objectmodel_HeightType_;
#pragma warning disable 0169
		static Delegate GetSetHeight_Lio_adaptivecards_objectmodel_HeightType_Handler ()
		{
			if (cb_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ == null)
				cb_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeight_Lio_adaptivecards_objectmodel_HeightType_);
			return cb_SetHeight_Lio_adaptivecards_objectmodel_HeightType_;
		}

		static void n_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HeightType p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HeightType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetHeight;
		static IntPtr id_SetHeight_Lio_adaptivecards_objectmodel_HeightType_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.HeightType Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='GetHeight' and count(parameter)=0]"
			[Register ("GetHeight", "()Lio/adaptivecards/objectmodel/HeightType;", "GetGetHeightHandler")]
			get {
				if (id_GetHeight == IntPtr.Zero)
					id_GetHeight = JNIEnv.GetMethodID (class_ref, "GetHeight", "()Lio/adaptivecards/objectmodel/HeightType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HeightType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetHeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HeightType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetHeight", "()Lio/adaptivecards/objectmodel/HeightType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='SetHeight' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.HeightType']]"
			[Register ("SetHeight", "(Lio/adaptivecards/objectmodel/HeightType;)V", "GetSetHeight_Lio_adaptivecards_objectmodel_HeightType_Handler")]
			set {
				if (id_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ == IntPtr.Zero)
					id_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ = JNIEnv.GetMethodID (class_ref, "SetHeight", "(Lio/adaptivecards/objectmodel/HeightType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetHeight_Lio_adaptivecards_objectmodel_HeightType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetHeight", "(Lio/adaptivecards/objectmodel/HeightType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_GetId == null)
				cb_GetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_GetId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_SetId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_SetId_Ljava_lang_String_ == null)
				cb_SetId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_SetId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetId;
		static IntPtr id_SetId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='GetId' and count(parameter)=0]"
			[Register ("GetId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_GetId == IntPtr.Zero)
					id_GetId = JNIEnv.GetMethodID (class_ref, "GetId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='SetId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_SetId_Ljava_lang_String_ == IntPtr.Zero)
					id_SetId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetSeparator;
#pragma warning disable 0169
		static Delegate GetGetSeparatorHandler ()
		{
			if (cb_GetSeparator == null)
				cb_GetSeparator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSeparator);
			return cb_GetSeparator;
		}

		static bool n_GetSeparator (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Separator;
		}
#pragma warning restore 0169

		static Delegate cb_SetSeparator_Z;
#pragma warning disable 0169
		static Delegate GetSetSeparator_ZHandler ()
		{
			if (cb_SetSeparator_Z == null)
				cb_SetSeparator_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSeparator_Z);
			return cb_SetSeparator_Z;
		}

		static void n_SetSeparator_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Separator = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetSeparator;
		static IntPtr id_SetSeparator_Z;
		public virtual unsafe bool Separator {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='GetSeparator' and count(parameter)=0]"
			[Register ("GetSeparator", "()Z", "GetGetSeparatorHandler")]
			get {
				if (id_GetSeparator == IntPtr.Zero)
					id_GetSeparator = JNIEnv.GetMethodID (class_ref, "GetSeparator", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetSeparator);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSeparator", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='SetSeparator' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetSeparator", "(Z)V", "GetSetSeparator_ZHandler")]
			set {
				if (id_SetSeparator_Z == IntPtr.Zero)
					id_SetSeparator_Z = JNIEnv.GetMethodID (class_ref, "SetSeparator", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetSeparator_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSeparator", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetSpacing;
#pragma warning disable 0169
		static Delegate GetGetSpacingHandler ()
		{
			if (cb_GetSpacing == null)
				cb_GetSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpacing);
			return cb_GetSpacing;
		}

		static IntPtr n_GetSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Spacing);
		}
#pragma warning restore 0169

		static Delegate cb_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_;
#pragma warning disable 0169
		static Delegate GetSetSpacing_Lio_adaptivecards_objectmodel_Spacing_Handler ()
		{
			if (cb_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_ == null)
				cb_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_);
			return cb_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_;
		}

		static void n_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.Spacing p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Spacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetSpacing;
		static IntPtr id_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.Spacing Spacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='GetSpacing' and count(parameter)=0]"
			[Register ("GetSpacing", "()Lio/adaptivecards/objectmodel/Spacing;", "GetGetSpacingHandler")]
			get {
				if (id_GetSpacing == IntPtr.Zero)
					id_GetSpacing = JNIEnv.GetMethodID (class_ref, "GetSpacing", "()Lio/adaptivecards/objectmodel/Spacing;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetSpacing), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSpacing", "()Lio/adaptivecards/objectmodel/Spacing;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='SetSpacing' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.Spacing']]"
			[Register ("SetSpacing", "(Lio/adaptivecards/objectmodel/Spacing;)V", "GetSetSpacing_Lio_adaptivecards_objectmodel_Spacing_Handler")]
			set {
				if (id_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_ == IntPtr.Zero)
					id_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_ = JNIEnv.GetMethodID (class_ref, "SetSpacing", "(Lio/adaptivecards/objectmodel/Spacing;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSpacing", "(Lio/adaptivecards/objectmodel/Spacing;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_;
#pragma warning disable 0169
		static Delegate GetGetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_Handler ()
		{
			if (cb_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ == null)
				cb_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_);
			return cb_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_;
		}

		static void n_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.RemoteResourceInformationVector p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.RemoteResourceInformationVector> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetResourceInformation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='GetResourceInformation' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.RemoteResourceInformationVector']]"
		[Register ("GetResourceInformation", "(Lio/adaptivecards/objectmodel/RemoteResourceInformationVector;)V", "GetGetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_Handler")]
		public virtual unsafe void GetResourceInformation (global::IO.Adaptivecards.Objectmodel.RemoteResourceInformationVector p0)
		{
			if (id_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ == IntPtr.Zero)
				id_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ = JNIEnv.GetMethodID (class_ref, "GetResourceInformation", "(Lio/adaptivecards/objectmodel/RemoteResourceInformationVector;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetResourceInformation", "(Lio/adaptivecards/objectmodel/RemoteResourceInformationVector;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_Serialize;
#pragma warning disable 0169
		static Delegate GetSerializeHandler ()
		{
			if (cb_Serialize == null)
				cb_Serialize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Serialize);
			return cb_Serialize;
		}

		static IntPtr n_Serialize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Serialize ());
		}
#pragma warning restore 0169

		static IntPtr id_Serialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='Serialize' and count(parameter)=0]"
		[Register ("Serialize", "()Ljava/lang/String;", "GetSerializeHandler")]
		public virtual unsafe string Serialize ()
		{
			if (id_Serialize == IntPtr.Zero)
				id_Serialize = JNIEnv.GetMethodID (class_ref, "Serialize", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_Serialize), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Serialize", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_SerializeToJsonValue;
#pragma warning disable 0169
		static Delegate GetSerializeToJsonValueHandler ()
		{
			if (cb_SerializeToJsonValue == null)
				cb_SerializeToJsonValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SerializeToJsonValue);
			return cb_SerializeToJsonValue;
		}

		static IntPtr n_SerializeToJsonValue (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerializeToJsonValue ());
		}
#pragma warning restore 0169

		static IntPtr id_SerializeToJsonValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='SerializeToJsonValue' and count(parameter)=0]"
		[Register ("SerializeToJsonValue", "()Lio/adaptivecards/objectmodel/JsonValue;", "GetSerializeToJsonValueHandler")]
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.JsonValue SerializeToJsonValue ()
		{
			if (id_SerializeToJsonValue == IntPtr.Zero)
				id_SerializeToJsonValue = JNIEnv.GetMethodID (class_ref, "SerializeToJsonValue", "()Lio/adaptivecards/objectmodel/JsonValue;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_SerializeToJsonValue), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SerializeToJsonValue", "()Lio/adaptivecards/objectmodel/JsonValue;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "()V"));
			} finally {
			}
		}

		static Delegate cb_findImplObj;
#pragma warning disable 0169
		static Delegate GetFindImplObjHandler ()
		{
			if (cb_findImplObj == null)
				cb_findImplObj = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindImplObj);
			return cb_findImplObj;
		}

		static IntPtr n_FindImplObj (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindImplObj ());
		}
#pragma warning restore 0169

		static IntPtr id_findImplObj;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='findImplObj' and count(parameter)=0]"
		[Register ("findImplObj", "()Lio/adaptivecards/objectmodel/BaseCardElement;", "GetFindImplObjHandler")]
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseCardElement FindImplObj ()
		{
			if (id_findImplObj == IntPtr.Zero)
				id_findImplObj = JNIEnv.GetMethodID (class_ref, "findImplObj", "()Lio/adaptivecards/objectmodel/BaseCardElement;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_findImplObj), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findImplObj", "()Lio/adaptivecards/objectmodel/BaseCardElement;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/BaseCardElement;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/BaseCardElement;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_BaseCardElement_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_swigDirectorDisconnect;
#pragma warning disable 0169
		static Delegate GetSwigDirectorDisconnectHandler ()
		{
			if (cb_swigDirectorDisconnect == null)
				cb_swigDirectorDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigDirectorDisconnect);
			return cb_swigDirectorDisconnect;
		}

		static void n_SwigDirectorDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigDirectorDisconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_swigDirectorDisconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='swigDirectorDisconnect' and count(parameter)=0]"
		[Register ("swigDirectorDisconnect", "()V", "GetSwigDirectorDisconnectHandler")]
		protected virtual unsafe void SwigDirectorDisconnect ()
		{
			if (id_swigDirectorDisconnect == IntPtr.Zero)
				id_swigDirectorDisconnect = JNIEnv.GetMethodID (class_ref, "swigDirectorDisconnect", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swigDirectorDisconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigDirectorDisconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_swigOriginalObject;
#pragma warning disable 0169
		static Delegate GetSwigOriginalObjectHandler ()
		{
			if (cb_swigOriginalObject == null)
				cb_swigOriginalObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SwigOriginalObject);
			return cb_swigOriginalObject;
		}

		static IntPtr n_SwigOriginalObject (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SwigOriginalObject ());
		}
#pragma warning restore 0169

		static IntPtr id_swigOriginalObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='swigOriginalObject' and count(parameter)=0]"
		[Register ("swigOriginalObject", "()Ljava/lang/Object;", "GetSwigOriginalObjectHandler")]
		public virtual unsafe global::Java.Lang.Object SwigOriginalObject ()
		{
			if (id_swigOriginalObject == IntPtr.Zero)
				id_swigOriginalObject = JNIEnv.GetMethodID (class_ref, "swigOriginalObject", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_swigOriginalObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigOriginalObject", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_swigReleaseOwnership;
#pragma warning disable 0169
		static Delegate GetSwigReleaseOwnershipHandler ()
		{
			if (cb_swigReleaseOwnership == null)
				cb_swigReleaseOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigReleaseOwnership);
			return cb_swigReleaseOwnership;
		}

		static void n_SwigReleaseOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigReleaseOwnership ();
		}
#pragma warning restore 0169

		static IntPtr id_swigReleaseOwnership;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='swigReleaseOwnership' and count(parameter)=0]"
		[Register ("swigReleaseOwnership", "()V", "GetSwigReleaseOwnershipHandler")]
		public virtual unsafe void SwigReleaseOwnership ()
		{
			if (id_swigReleaseOwnership == IntPtr.Zero)
				id_swigReleaseOwnership = JNIEnv.GetMethodID (class_ref, "swigReleaseOwnership", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swigReleaseOwnership);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigReleaseOwnership", "()V"));
			} finally {
			}
		}

		static Delegate cb_swigTakeOwnership;
#pragma warning disable 0169
		static Delegate GetSwigTakeOwnershipHandler ()
		{
			if (cb_swigTakeOwnership == null)
				cb_swigTakeOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigTakeOwnership);
			return cb_swigTakeOwnership;
		}

		static void n_SwigTakeOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseCardElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigTakeOwnership ();
		}
#pragma warning restore 0169

		static IntPtr id_swigTakeOwnership;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElement']/method[@name='swigTakeOwnership' and count(parameter)=0]"
		[Register ("swigTakeOwnership", "()V", "GetSwigTakeOwnershipHandler")]
		public virtual unsafe void SwigTakeOwnership ()
		{
			if (id_swigTakeOwnership == IntPtr.Zero)
				id_swigTakeOwnership = JNIEnv.GetMethodID (class_ref, "swigTakeOwnership", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swigTakeOwnership);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigTakeOwnership", "()V"));
			} finally {
			}
		}

	}
}
