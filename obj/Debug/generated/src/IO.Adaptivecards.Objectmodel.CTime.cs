using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/CTime", DoNotGenerateAcw=true)]
	public partial class CTime : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/CTime", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CTime); }
		}

		protected CTime (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/constructor[@name='CTime' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTime ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CTime)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/constructor[@name='CTime' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe CTime (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (CTime)) {
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

		static Delegate cb_getHour;
#pragma warning disable 0169
		static Delegate GetGetHourHandler ()
		{
			if (cb_getHour == null)
				cb_getHour = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHour);
			return cb_getHour;
		}

		static int n_GetHour (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Hour;
		}
#pragma warning restore 0169

		static Delegate cb_setHour_I;
#pragma warning disable 0169
		static Delegate GetSetHour_IHandler ()
		{
			if (cb_setHour_I == null)
				cb_setHour_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHour_I);
			return cb_setHour_I;
		}

		static void n_SetHour_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hour = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHour;
		static IntPtr id_setHour_I;
		public virtual unsafe int Hour {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getHour' and count(parameter)=0]"
			[Register ("getHour", "()I", "GetGetHourHandler")]
			get {
				if (id_getHour == IntPtr.Zero)
					id_getHour = JNIEnv.GetMethodID (class_ref, "getHour", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHour);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHour", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='setHour' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHour", "(I)V", "GetSetHour_IHandler")]
			set {
				if (id_setHour_I == IntPtr.Zero)
					id_setHour_I = JNIEnv.GetMethodID (class_ref, "setHour", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHour_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHour", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIsDst;
#pragma warning disable 0169
		static Delegate GetGetIsDstHandler ()
		{
			if (cb_getIsDst == null)
				cb_getIsDst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIsDst);
			return cb_getIsDst;
		}

		static int n_GetIsDst (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDst;
		}
#pragma warning restore 0169

		static Delegate cb_setIsDst_I;
#pragma warning disable 0169
		static Delegate GetSetIsDst_IHandler ()
		{
			if (cb_setIsDst_I == null)
				cb_setIsDst_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIsDst_I);
			return cb_setIsDst_I;
		}

		static void n_SetIsDst_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsDst = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsDst;
		static IntPtr id_setIsDst_I;
		public virtual unsafe int IsDst {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getIsDst' and count(parameter)=0]"
			[Register ("getIsDst", "()I", "GetGetIsDstHandler")]
			get {
				if (id_getIsDst == IntPtr.Zero)
					id_getIsDst = JNIEnv.GetMethodID (class_ref, "getIsDst", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIsDst);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsDst", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='setIsDst' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIsDst", "(I)V", "GetSetIsDst_IHandler")]
			set {
				if (id_setIsDst_I == IntPtr.Zero)
					id_setIsDst_I = JNIEnv.GetMethodID (class_ref, "setIsDst", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsDst_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsDst", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMDay;
#pragma warning disable 0169
		static Delegate GetGetMDayHandler ()
		{
			if (cb_getMDay == null)
				cb_getMDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMDay);
			return cb_getMDay;
		}

		static int n_GetMDay (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MDay;
		}
#pragma warning restore 0169

		static Delegate cb_setMDay_I;
#pragma warning disable 0169
		static Delegate GetSetMDay_IHandler ()
		{
			if (cb_setMDay_I == null)
				cb_setMDay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMDay_I);
			return cb_setMDay_I;
		}

		static void n_SetMDay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MDay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMDay;
		static IntPtr id_setMDay_I;
		public virtual unsafe int MDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getMDay' and count(parameter)=0]"
			[Register ("getMDay", "()I", "GetGetMDayHandler")]
			get {
				if (id_getMDay == IntPtr.Zero)
					id_getMDay = JNIEnv.GetMethodID (class_ref, "getMDay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMDay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMDay", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='setMDay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMDay", "(I)V", "GetSetMDay_IHandler")]
			set {
				if (id_setMDay_I == IntPtr.Zero)
					id_setMDay_I = JNIEnv.GetMethodID (class_ref, "setMDay", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMDay_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMDay", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMin;
#pragma warning disable 0169
		static Delegate GetGetMinHandler ()
		{
			if (cb_getMin == null)
				cb_getMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMin);
			return cb_getMin;
		}

		static int n_GetMin (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Min;
		}
#pragma warning restore 0169

		static Delegate cb_setMin_I;
#pragma warning disable 0169
		static Delegate GetSetMin_IHandler ()
		{
			if (cb_setMin_I == null)
				cb_setMin_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMin_I);
			return cb_setMin_I;
		}

		static void n_SetMin_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Min = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMin;
		static IntPtr id_setMin_I;
		public virtual unsafe int Min {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getMin' and count(parameter)=0]"
			[Register ("getMin", "()I", "GetGetMinHandler")]
			get {
				if (id_getMin == IntPtr.Zero)
					id_getMin = JNIEnv.GetMethodID (class_ref, "getMin", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMin);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMin", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='setMin' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMin", "(I)V", "GetSetMin_IHandler")]
			set {
				if (id_setMin_I == IntPtr.Zero)
					id_setMin_I = JNIEnv.GetMethodID (class_ref, "setMin", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMin_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMin", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMon;
#pragma warning disable 0169
		static Delegate GetGetMonHandler ()
		{
			if (cb_getMon == null)
				cb_getMon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMon);
			return cb_getMon;
		}

		static int n_GetMon (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mon;
		}
#pragma warning restore 0169

		static Delegate cb_setMon_I;
#pragma warning disable 0169
		static Delegate GetSetMon_IHandler ()
		{
			if (cb_setMon_I == null)
				cb_setMon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMon_I);
			return cb_setMon_I;
		}

		static void n_SetMon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mon = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMon;
		static IntPtr id_setMon_I;
		public virtual unsafe int Mon {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getMon' and count(parameter)=0]"
			[Register ("getMon", "()I", "GetGetMonHandler")]
			get {
				if (id_getMon == IntPtr.Zero)
					id_getMon = JNIEnv.GetMethodID (class_ref, "getMon", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMon);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMon", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='setMon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMon", "(I)V", "GetSetMon_IHandler")]
			set {
				if (id_setMon_I == IntPtr.Zero)
					id_setMon_I = JNIEnv.GetMethodID (class_ref, "setMon", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMon_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMon", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSec;
#pragma warning disable 0169
		static Delegate GetGetSecHandler ()
		{
			if (cb_getSec == null)
				cb_getSec = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSec);
			return cb_getSec;
		}

		static int n_GetSec (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sec;
		}
#pragma warning restore 0169

		static Delegate cb_setSec_I;
#pragma warning disable 0169
		static Delegate GetSetSec_IHandler ()
		{
			if (cb_setSec_I == null)
				cb_setSec_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSec_I);
			return cb_setSec_I;
		}

		static void n_SetSec_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sec = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSec;
		static IntPtr id_setSec_I;
		public virtual unsafe int Sec {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getSec' and count(parameter)=0]"
			[Register ("getSec", "()I", "GetGetSecHandler")]
			get {
				if (id_getSec == IntPtr.Zero)
					id_getSec = JNIEnv.GetMethodID (class_ref, "getSec", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSec);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSec", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='setSec' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSec", "(I)V", "GetSetSec_IHandler")]
			set {
				if (id_setSec_I == IntPtr.Zero)
					id_setSec_I = JNIEnv.GetMethodID (class_ref, "setSec", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSec_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSec", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWDay;
#pragma warning disable 0169
		static Delegate GetGetWDayHandler ()
		{
			if (cb_getWDay == null)
				cb_getWDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWDay);
			return cb_getWDay;
		}

		static int n_GetWDay (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WDay;
		}
#pragma warning restore 0169

		static Delegate cb_setWDay_I;
#pragma warning disable 0169
		static Delegate GetSetWDay_IHandler ()
		{
			if (cb_setWDay_I == null)
				cb_setWDay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWDay_I);
			return cb_setWDay_I;
		}

		static void n_SetWDay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WDay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWDay;
		static IntPtr id_setWDay_I;
		public virtual unsafe int WDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getWDay' and count(parameter)=0]"
			[Register ("getWDay", "()I", "GetGetWDayHandler")]
			get {
				if (id_getWDay == IntPtr.Zero)
					id_getWDay = JNIEnv.GetMethodID (class_ref, "getWDay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWDay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWDay", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='setWDay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWDay", "(I)V", "GetSetWDay_IHandler")]
			set {
				if (id_setWDay_I == IntPtr.Zero)
					id_setWDay_I = JNIEnv.GetMethodID (class_ref, "setWDay", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWDay_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWDay", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getYDay;
#pragma warning disable 0169
		static Delegate GetGetYDayHandler ()
		{
			if (cb_getYDay == null)
				cb_getYDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYDay);
			return cb_getYDay;
		}

		static int n_GetYDay (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YDay;
		}
#pragma warning restore 0169

		static Delegate cb_setYDay_I;
#pragma warning disable 0169
		static Delegate GetSetYDay_IHandler ()
		{
			if (cb_setYDay_I == null)
				cb_setYDay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetYDay_I);
			return cb_setYDay_I;
		}

		static void n_SetYDay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YDay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYDay;
		static IntPtr id_setYDay_I;
		public virtual unsafe int YDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getYDay' and count(parameter)=0]"
			[Register ("getYDay", "()I", "GetGetYDayHandler")]
			get {
				if (id_getYDay == IntPtr.Zero)
					id_getYDay = JNIEnv.GetMethodID (class_ref, "getYDay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYDay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYDay", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='setYDay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYDay", "(I)V", "GetSetYDay_IHandler")]
			set {
				if (id_setYDay_I == IntPtr.Zero)
					id_setYDay_I = JNIEnv.GetMethodID (class_ref, "setYDay", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYDay_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYDay", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getYear;
#pragma warning disable 0169
		static Delegate GetGetYearHandler ()
		{
			if (cb_getYear == null)
				cb_getYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYear);
			return cb_getYear;
		}

		static int n_GetYear (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Year;
		}
#pragma warning restore 0169

		static Delegate cb_setYear_I;
#pragma warning disable 0169
		static Delegate GetSetYear_IHandler ()
		{
			if (cb_setYear_I == null)
				cb_setYear_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetYear_I);
			return cb_setYear_I;
		}

		static void n_SetYear_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Year = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYear;
		static IntPtr id_setYear_I;
		public virtual unsafe int Year {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getYear' and count(parameter)=0]"
			[Register ("getYear", "()I", "GetGetYearHandler")]
			get {
				if (id_getYear == IntPtr.Zero)
					id_getYear = JNIEnv.GetMethodID (class_ref, "getYear", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYear);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYear", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='setYear' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYear", "(I)V", "GetSetYear_IHandler")]
			set {
				if (id_setYear_I == IntPtr.Zero)
					id_setYear_I = JNIEnv.GetMethodID (class_ref, "setYear", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYear_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYear", "(I)V"), __args);
				} finally {
				}
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
			global::IO.Adaptivecards.Objectmodel.CTime __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_CTime_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CTime']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.CTime']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/CTime;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.CTime p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_CTime_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_CTime_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/CTime;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_CTime_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
