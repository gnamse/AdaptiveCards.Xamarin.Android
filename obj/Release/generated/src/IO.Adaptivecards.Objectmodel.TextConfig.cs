using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/TextConfig", DoNotGenerateAcw=true)]
	public partial class TextConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/field[@name='swigCMemOwn']"
		[Register ("swigCMemOwn")]
		protected bool SwigCMemOwn {
			get {
				if (swigCMemOwn_jfieldId == IntPtr.Zero)
					swigCMemOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "swigCMemOwn", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, swigCMemOwn_jfieldId);
			}
			set {
				if (swigCMemOwn_jfieldId == IntPtr.Zero)
					swigCMemOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "swigCMemOwn", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, swigCMemOwn_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/TextConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextConfig); }
		}

		protected TextConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/constructor[@name='TextConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TextConfig)) {
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

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/constructor[@name='TextConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe TextConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (TextConfig)) {
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

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColor);
			return cb_getColor;
		}

		static IntPtr n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Color);
		}
#pragma warning restore 0169

		static Delegate cb_setColor_Lio_adaptivecards_objectmodel_ForegroundColor_;
#pragma warning disable 0169
		static Delegate GetSetColor_Lio_adaptivecards_objectmodel_ForegroundColor_Handler ()
		{
			if (cb_setColor_Lio_adaptivecards_objectmodel_ForegroundColor_ == null)
				cb_setColor_Lio_adaptivecards_objectmodel_ForegroundColor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColor_Lio_adaptivecards_objectmodel_ForegroundColor_);
			return cb_setColor_Lio_adaptivecards_objectmodel_ForegroundColor_;
		}

		static void n_SetColor_Lio_adaptivecards_objectmodel_ForegroundColor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ForegroundColor p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Color = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		static IntPtr id_setColor_Lio_adaptivecards_objectmodel_ForegroundColor_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ForegroundColor Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()Lio/adaptivecards/objectmodel/ForegroundColor;", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()Lio/adaptivecards/objectmodel/ForegroundColor;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()Lio/adaptivecards/objectmodel/ForegroundColor;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ForegroundColor']]"
			[Register ("setColor", "(Lio/adaptivecards/objectmodel/ForegroundColor;)V", "GetSetColor_Lio_adaptivecards_objectmodel_ForegroundColor_Handler")]
			set {
				if (id_setColor_Lio_adaptivecards_objectmodel_ForegroundColor_ == IntPtr.Zero)
					id_setColor_Lio_adaptivecards_objectmodel_ForegroundColor_ = JNIEnv.GetMethodID (class_ref, "setColor", "(Lio/adaptivecards/objectmodel/ForegroundColor;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColor_Lio_adaptivecards_objectmodel_ForegroundColor_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(Lio/adaptivecards/objectmodel/ForegroundColor;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIsSubtle;
#pragma warning disable 0169
		static Delegate GetGetIsSubtleHandler ()
		{
			if (cb_getIsSubtle == null)
				cb_getIsSubtle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsSubtle);
			return cb_getIsSubtle;
		}

		static bool n_GetIsSubtle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSubtle;
		}
#pragma warning restore 0169

		static Delegate cb_setIsSubtle_Z;
#pragma warning disable 0169
		static Delegate GetSetIsSubtle_ZHandler ()
		{
			if (cb_setIsSubtle_Z == null)
				cb_setIsSubtle_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsSubtle_Z);
			return cb_setIsSubtle_Z;
		}

		static void n_SetIsSubtle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsSubtle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsSubtle;
		static IntPtr id_setIsSubtle_Z;
		public virtual unsafe bool IsSubtle {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='getIsSubtle' and count(parameter)=0]"
			[Register ("getIsSubtle", "()Z", "GetGetIsSubtleHandler")]
			get {
				if (id_getIsSubtle == IntPtr.Zero)
					id_getIsSubtle = JNIEnv.GetMethodID (class_ref, "getIsSubtle", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getIsSubtle);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsSubtle", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='setIsSubtle' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsSubtle", "(Z)V", "GetSetIsSubtle_ZHandler")]
			set {
				if (id_setIsSubtle_Z == IntPtr.Zero)
					id_setIsSubtle_Z = JNIEnv.GetMethodID (class_ref, "setIsSubtle", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsSubtle_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsSubtle", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxWidth;
#pragma warning disable 0169
		static Delegate GetGetMaxWidthHandler ()
		{
			if (cb_getMaxWidth == null)
				cb_getMaxWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxWidth);
			return cb_getMaxWidth;
		}

		static long n_GetMaxWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxWidth_J;
#pragma warning disable 0169
		static Delegate GetSetMaxWidth_JHandler ()
		{
			if (cb_setMaxWidth_J == null)
				cb_setMaxWidth_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMaxWidth_J);
			return cb_setMaxWidth_J;
		}

		static void n_SetMaxWidth_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxWidth;
		static IntPtr id_setMaxWidth_J;
		public virtual unsafe long MaxWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='getMaxWidth' and count(parameter)=0]"
			[Register ("getMaxWidth", "()J", "GetGetMaxWidthHandler")]
			get {
				if (id_getMaxWidth == IntPtr.Zero)
					id_getMaxWidth = JNIEnv.GetMethodID (class_ref, "getMaxWidth", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxWidth);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxWidth", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='setMaxWidth' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxWidth", "(J)V", "GetSetMaxWidth_JHandler")]
			set {
				if (id_setMaxWidth_J == IntPtr.Zero)
					id_setMaxWidth_J = JNIEnv.GetMethodID (class_ref, "setMaxWidth", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxWidth_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxWidth", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSize);
			return cb_getSize;
		}

		static IntPtr n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size);
		}
#pragma warning restore 0169

		static Delegate cb_setSize_Lio_adaptivecards_objectmodel_TextSize_;
#pragma warning disable 0169
		static Delegate GetSetSize_Lio_adaptivecards_objectmodel_TextSize_Handler ()
		{
			if (cb_setSize_Lio_adaptivecards_objectmodel_TextSize_ == null)
				cb_setSize_Lio_adaptivecards_objectmodel_TextSize_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSize_Lio_adaptivecards_objectmodel_TextSize_);
			return cb_setSize_Lio_adaptivecards_objectmodel_TextSize_;
		}

		static void n_SetSize_Lio_adaptivecards_objectmodel_TextSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.TextSize p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextSize> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Size = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		static IntPtr id_setSize_Lio_adaptivecards_objectmodel_TextSize_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.TextSize Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()Lio/adaptivecards/objectmodel/TextSize;", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()Lio/adaptivecards/objectmodel/TextSize;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextSize> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextSize> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()Lio/adaptivecards/objectmodel/TextSize;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextSize']]"
			[Register ("setSize", "(Lio/adaptivecards/objectmodel/TextSize;)V", "GetSetSize_Lio_adaptivecards_objectmodel_TextSize_Handler")]
			set {
				if (id_setSize_Lio_adaptivecards_objectmodel_TextSize_ == IntPtr.Zero)
					id_setSize_Lio_adaptivecards_objectmodel_TextSize_ = JNIEnv.GetMethodID (class_ref, "setSize", "(Lio/adaptivecards/objectmodel/TextSize;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSize_Lio_adaptivecards_objectmodel_TextSize_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSize", "(Lio/adaptivecards/objectmodel/TextSize;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWeight;
#pragma warning disable 0169
		static Delegate GetGetWeightHandler ()
		{
			if (cb_getWeight == null)
				cb_getWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeight);
			return cb_getWeight;
		}

		static IntPtr n_GetWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Weight);
		}
#pragma warning restore 0169

		static Delegate cb_setWeight_Lio_adaptivecards_objectmodel_TextWeight_;
#pragma warning disable 0169
		static Delegate GetSetWeight_Lio_adaptivecards_objectmodel_TextWeight_Handler ()
		{
			if (cb_setWeight_Lio_adaptivecards_objectmodel_TextWeight_ == null)
				cb_setWeight_Lio_adaptivecards_objectmodel_TextWeight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWeight_Lio_adaptivecards_objectmodel_TextWeight_);
			return cb_setWeight_Lio_adaptivecards_objectmodel_TextWeight_;
		}

		static void n_SetWeight_Lio_adaptivecards_objectmodel_TextWeight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.TextWeight p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Weight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWeight;
		static IntPtr id_setWeight_Lio_adaptivecards_objectmodel_TextWeight_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.TextWeight Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()Lio/adaptivecards/objectmodel/TextWeight;", "GetGetWeightHandler")]
			get {
				if (id_getWeight == IntPtr.Zero)
					id_getWeight = JNIEnv.GetMethodID (class_ref, "getWeight", "()Lio/adaptivecards/objectmodel/TextWeight;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeight", "()Lio/adaptivecards/objectmodel/TextWeight;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='setWeight' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextWeight']]"
			[Register ("setWeight", "(Lio/adaptivecards/objectmodel/TextWeight;)V", "GetSetWeight_Lio_adaptivecards_objectmodel_TextWeight_Handler")]
			set {
				if (id_setWeight_Lio_adaptivecards_objectmodel_TextWeight_ == IntPtr.Zero)
					id_setWeight_Lio_adaptivecards_objectmodel_TextWeight_ = JNIEnv.GetMethodID (class_ref, "setWeight", "(Lio/adaptivecards/objectmodel/TextWeight;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWeight_Lio_adaptivecards_objectmodel_TextWeight_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWeight", "(Lio/adaptivecards/objectmodel/TextWeight;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWrap;
#pragma warning disable 0169
		static Delegate GetGetWrapHandler ()
		{
			if (cb_getWrap == null)
				cb_getWrap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWrap);
			return cb_getWrap;
		}

		static bool n_GetWrap (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Wrap;
		}
#pragma warning restore 0169

		static Delegate cb_setWrap_Z;
#pragma warning disable 0169
		static Delegate GetSetWrap_ZHandler ()
		{
			if (cb_setWrap_Z == null)
				cb_setWrap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWrap_Z);
			return cb_setWrap_Z;
		}

		static void n_SetWrap_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Wrap = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWrap;
		static IntPtr id_setWrap_Z;
		public virtual unsafe bool Wrap {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='getWrap' and count(parameter)=0]"
			[Register ("getWrap", "()Z", "GetGetWrapHandler")]
			get {
				if (id_getWrap == IntPtr.Zero)
					id_getWrap = JNIEnv.GetMethodID (class_ref, "getWrap", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getWrap);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWrap", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='setWrap' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWrap", "(Z)V", "GetSetWrap_ZHandler")]
			set {
				if (id_setWrap_Z == IntPtr.Zero)
					id_setWrap_Z = JNIEnv.GetMethodID (class_ref, "setWrap", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWrap_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWrap", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_TextConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.TextConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/TextConfig;)Lio/adaptivecards/objectmodel/TextConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.TextConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_TextConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_TextConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/TextConfig;)Lio/adaptivecards/objectmodel/TextConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.TextConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_TextConfig_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::IO.Adaptivecards.Objectmodel.TextConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_TextConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/TextConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.TextConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_TextConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_TextConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/TextConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_TextConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
