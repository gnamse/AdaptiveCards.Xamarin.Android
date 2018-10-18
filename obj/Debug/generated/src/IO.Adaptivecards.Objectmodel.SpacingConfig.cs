using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/SpacingConfig", DoNotGenerateAcw=true)]
	public partial class SpacingConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/SpacingConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpacingConfig); }
		}

		protected SpacingConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/constructor[@name='SpacingConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpacingConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SpacingConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/constructor[@name='SpacingConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe SpacingConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SpacingConfig)) {
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

		static Delegate cb_getDefaultSpacing;
#pragma warning disable 0169
		static Delegate GetGetDefaultSpacingHandler ()
		{
			if (cb_getDefaultSpacing == null)
				cb_getDefaultSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDefaultSpacing);
			return cb_getDefaultSpacing;
		}

		static long n_GetDefaultSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultSpacing_J;
#pragma warning disable 0169
		static Delegate GetSetDefaultSpacing_JHandler ()
		{
			if (cb_setDefaultSpacing_J == null)
				cb_setDefaultSpacing_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetDefaultSpacing_J);
			return cb_setDefaultSpacing_J;
		}

		static void n_SetDefaultSpacing_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DefaultSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultSpacing;
		static IntPtr id_setDefaultSpacing_J;
		public virtual unsafe long DefaultSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='getDefaultSpacing' and count(parameter)=0]"
			[Register ("getDefaultSpacing", "()J", "GetGetDefaultSpacingHandler")]
			get {
				if (id_getDefaultSpacing == IntPtr.Zero)
					id_getDefaultSpacing = JNIEnv.GetMethodID (class_ref, "getDefaultSpacing", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultSpacing);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultSpacing", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='setDefaultSpacing' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDefaultSpacing", "(J)V", "GetSetDefaultSpacing_JHandler")]
			set {
				if (id_setDefaultSpacing_J == IntPtr.Zero)
					id_setDefaultSpacing_J = JNIEnv.GetMethodID (class_ref, "setDefaultSpacing", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultSpacing_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultSpacing", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraLargeSpacing;
#pragma warning disable 0169
		static Delegate GetGetExtraLargeSpacingHandler ()
		{
			if (cb_getExtraLargeSpacing == null)
				cb_getExtraLargeSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExtraLargeSpacing);
			return cb_getExtraLargeSpacing;
		}

		static long n_GetExtraLargeSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtraLargeSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setExtraLargeSpacing_J;
#pragma warning disable 0169
		static Delegate GetSetExtraLargeSpacing_JHandler ()
		{
			if (cb_setExtraLargeSpacing_J == null)
				cb_setExtraLargeSpacing_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetExtraLargeSpacing_J);
			return cb_setExtraLargeSpacing_J;
		}

		static void n_SetExtraLargeSpacing_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExtraLargeSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtraLargeSpacing;
		static IntPtr id_setExtraLargeSpacing_J;
		public virtual unsafe long ExtraLargeSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='getExtraLargeSpacing' and count(parameter)=0]"
			[Register ("getExtraLargeSpacing", "()J", "GetGetExtraLargeSpacingHandler")]
			get {
				if (id_getExtraLargeSpacing == IntPtr.Zero)
					id_getExtraLargeSpacing = JNIEnv.GetMethodID (class_ref, "getExtraLargeSpacing", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getExtraLargeSpacing);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtraLargeSpacing", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='setExtraLargeSpacing' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setExtraLargeSpacing", "(J)V", "GetSetExtraLargeSpacing_JHandler")]
			set {
				if (id_setExtraLargeSpacing_J == IntPtr.Zero)
					id_setExtraLargeSpacing_J = JNIEnv.GetMethodID (class_ref, "setExtraLargeSpacing", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtraLargeSpacing_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtraLargeSpacing", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLargeSpacing;
#pragma warning disable 0169
		static Delegate GetGetLargeSpacingHandler ()
		{
			if (cb_getLargeSpacing == null)
				cb_getLargeSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLargeSpacing);
			return cb_getLargeSpacing;
		}

		static long n_GetLargeSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LargeSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setLargeSpacing_J;
#pragma warning disable 0169
		static Delegate GetSetLargeSpacing_JHandler ()
		{
			if (cb_setLargeSpacing_J == null)
				cb_setLargeSpacing_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLargeSpacing_J);
			return cb_setLargeSpacing_J;
		}

		static void n_SetLargeSpacing_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LargeSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLargeSpacing;
		static IntPtr id_setLargeSpacing_J;
		public virtual unsafe long LargeSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='getLargeSpacing' and count(parameter)=0]"
			[Register ("getLargeSpacing", "()J", "GetGetLargeSpacingHandler")]
			get {
				if (id_getLargeSpacing == IntPtr.Zero)
					id_getLargeSpacing = JNIEnv.GetMethodID (class_ref, "getLargeSpacing", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLargeSpacing);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLargeSpacing", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='setLargeSpacing' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLargeSpacing", "(J)V", "GetSetLargeSpacing_JHandler")]
			set {
				if (id_setLargeSpacing_J == IntPtr.Zero)
					id_setLargeSpacing_J = JNIEnv.GetMethodID (class_ref, "setLargeSpacing", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLargeSpacing_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLargeSpacing", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMediumSpacing;
#pragma warning disable 0169
		static Delegate GetGetMediumSpacingHandler ()
		{
			if (cb_getMediumSpacing == null)
				cb_getMediumSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMediumSpacing);
			return cb_getMediumSpacing;
		}

		static long n_GetMediumSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediumSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setMediumSpacing_J;
#pragma warning disable 0169
		static Delegate GetSetMediumSpacing_JHandler ()
		{
			if (cb_setMediumSpacing_J == null)
				cb_setMediumSpacing_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMediumSpacing_J);
			return cb_setMediumSpacing_J;
		}

		static void n_SetMediumSpacing_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MediumSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMediumSpacing;
		static IntPtr id_setMediumSpacing_J;
		public virtual unsafe long MediumSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='getMediumSpacing' and count(parameter)=0]"
			[Register ("getMediumSpacing", "()J", "GetGetMediumSpacingHandler")]
			get {
				if (id_getMediumSpacing == IntPtr.Zero)
					id_getMediumSpacing = JNIEnv.GetMethodID (class_ref, "getMediumSpacing", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMediumSpacing);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediumSpacing", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='setMediumSpacing' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMediumSpacing", "(J)V", "GetSetMediumSpacing_JHandler")]
			set {
				if (id_setMediumSpacing_J == IntPtr.Zero)
					id_setMediumSpacing_J = JNIEnv.GetMethodID (class_ref, "setMediumSpacing", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMediumSpacing_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediumSpacing", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPaddingSpacing;
#pragma warning disable 0169
		static Delegate GetGetPaddingSpacingHandler ()
		{
			if (cb_getPaddingSpacing == null)
				cb_getPaddingSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPaddingSpacing);
			return cb_getPaddingSpacing;
		}

		static long n_GetPaddingSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PaddingSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setPaddingSpacing_J;
#pragma warning disable 0169
		static Delegate GetSetPaddingSpacing_JHandler ()
		{
			if (cb_setPaddingSpacing_J == null)
				cb_setPaddingSpacing_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetPaddingSpacing_J);
			return cb_setPaddingSpacing_J;
		}

		static void n_SetPaddingSpacing_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PaddingSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPaddingSpacing;
		static IntPtr id_setPaddingSpacing_J;
		public virtual unsafe long PaddingSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='getPaddingSpacing' and count(parameter)=0]"
			[Register ("getPaddingSpacing", "()J", "GetGetPaddingSpacingHandler")]
			get {
				if (id_getPaddingSpacing == IntPtr.Zero)
					id_getPaddingSpacing = JNIEnv.GetMethodID (class_ref, "getPaddingSpacing", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPaddingSpacing);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaddingSpacing", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='setPaddingSpacing' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setPaddingSpacing", "(J)V", "GetSetPaddingSpacing_JHandler")]
			set {
				if (id_setPaddingSpacing_J == IntPtr.Zero)
					id_setPaddingSpacing_J = JNIEnv.GetMethodID (class_ref, "setPaddingSpacing", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPaddingSpacing_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPaddingSpacing", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSmallSpacing;
#pragma warning disable 0169
		static Delegate GetGetSmallSpacingHandler ()
		{
			if (cb_getSmallSpacing == null)
				cb_getSmallSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSmallSpacing);
			return cb_getSmallSpacing;
		}

		static long n_GetSmallSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SmallSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setSmallSpacing_J;
#pragma warning disable 0169
		static Delegate GetSetSmallSpacing_JHandler ()
		{
			if (cb_setSmallSpacing_J == null)
				cb_setSmallSpacing_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSmallSpacing_J);
			return cb_setSmallSpacing_J;
		}

		static void n_SetSmallSpacing_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmallSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSmallSpacing;
		static IntPtr id_setSmallSpacing_J;
		public virtual unsafe long SmallSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='getSmallSpacing' and count(parameter)=0]"
			[Register ("getSmallSpacing", "()J", "GetGetSmallSpacingHandler")]
			get {
				if (id_getSmallSpacing == IntPtr.Zero)
					id_getSmallSpacing = JNIEnv.GetMethodID (class_ref, "getSmallSpacing", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSmallSpacing);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSmallSpacing", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='setSmallSpacing' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSmallSpacing", "(J)V", "GetSetSmallSpacing_JHandler")]
			set {
				if (id_setSmallSpacing_J == IntPtr.Zero)
					id_setSmallSpacing_J = JNIEnv.GetMethodID (class_ref, "setSmallSpacing", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSmallSpacing_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmallSpacing", "(J)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_SpacingConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.SpacingConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/SpacingConfig;)Lio/adaptivecards/objectmodel/SpacingConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.SpacingConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.SpacingConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_SpacingConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_SpacingConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/SpacingConfig;)Lio/adaptivecards/objectmodel/SpacingConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.SpacingConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_SpacingConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.SpacingConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_SpacingConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SpacingConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.SpacingConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/SpacingConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.SpacingConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_SpacingConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_SpacingConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/SpacingConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_SpacingConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
