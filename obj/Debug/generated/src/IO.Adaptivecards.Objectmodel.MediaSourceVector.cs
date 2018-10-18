using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/MediaSourceVector", DoNotGenerateAcw=true)]
	public partial class MediaSourceVector : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/MediaSourceVector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaSourceVector); }
		}

		protected MediaSourceVector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/constructor[@name='MediaSourceVector' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MediaSourceVector (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MediaSourceVector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/constructor[@name='MediaSourceVector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaSourceVector ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MediaSourceVector)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/constructor[@name='MediaSourceVector' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe MediaSourceVector (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MediaSourceVector)) {
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

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSourceVector __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_add_Lio_adaptivecards_objectmodel_MediaSource_;
#pragma warning disable 0169
		static Delegate GetAdd_Lio_adaptivecards_objectmodel_MediaSource_Handler ()
		{
			if (cb_add_Lio_adaptivecards_objectmodel_MediaSource_ == null)
				cb_add_Lio_adaptivecards_objectmodel_MediaSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lio_adaptivecards_objectmodel_MediaSource_);
			return cb_add_Lio_adaptivecards_objectmodel_MediaSource_;
		}

		static void n_Add_Lio_adaptivecards_objectmodel_MediaSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSourceVector __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.MediaSource p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lio_adaptivecards_objectmodel_MediaSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='add' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.MediaSource']]"
		[Register ("add", "(Lio/adaptivecards/objectmodel/MediaSource;)V", "GetAdd_Lio_adaptivecards_objectmodel_MediaSource_Handler")]
		public virtual unsafe void Add (global::IO.Adaptivecards.Objectmodel.MediaSource p0)
		{
			if (id_add_Lio_adaptivecards_objectmodel_MediaSource_ == IntPtr.Zero)
				id_add_Lio_adaptivecards_objectmodel_MediaSource_ = JNIEnv.GetMethodID (class_ref, "add", "(Lio/adaptivecards/objectmodel/MediaSource;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lio_adaptivecards_objectmodel_MediaSource_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lio/adaptivecards/objectmodel/MediaSource;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_capacity;
#pragma warning disable 0169
		static Delegate GetCapacityHandler ()
		{
			if (cb_capacity == null)
				cb_capacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Capacity);
			return cb_capacity;
		}

		static long n_Capacity (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSourceVector __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Capacity ();
		}
#pragma warning restore 0169

		static IntPtr id_capacity;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='capacity' and count(parameter)=0]"
		[Register ("capacity", "()J", "GetCapacityHandler")]
		public virtual unsafe long Capacity ()
		{
			if (id_capacity == IntPtr.Zero)
				id_capacity = JNIEnv.GetMethodID (class_ref, "capacity", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_capacity);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "capacity", "()J"));
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSourceVector __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
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
			global::IO.Adaptivecards.Objectmodel.MediaSourceVector __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='delete' and count(parameter)=0]"
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

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSourceVector __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lio/adaptivecards/objectmodel/MediaSource;", "GetGet_IHandler")]
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.MediaSource Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lio/adaptivecards/objectmodel/MediaSource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/MediaSource;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_MediaSourceVector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.MediaSourceVector']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/MediaSourceVector;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.MediaSourceVector p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_MediaSourceVector_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_MediaSourceVector_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/MediaSourceVector;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_MediaSourceVector_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_reserve_J;
#pragma warning disable 0169
		static Delegate GetReserve_JHandler ()
		{
			if (cb_reserve_J == null)
				cb_reserve_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Reserve_J);
			return cb_reserve_J;
		}

		static void n_Reserve_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSourceVector __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reserve (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reserve_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='reserve' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("reserve", "(J)V", "GetReserve_JHandler")]
		public virtual unsafe void Reserve (long p0)
		{
			if (id_reserve_J == IntPtr.Zero)
				id_reserve_J = JNIEnv.GetMethodID (class_ref, "reserve", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reserve_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reserve", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_ILio_adaptivecards_objectmodel_MediaSource_;
#pragma warning disable 0169
		static Delegate GetSet_ILio_adaptivecards_objectmodel_MediaSource_Handler ()
		{
			if (cb_set_ILio_adaptivecards_objectmodel_MediaSource_ == null)
				cb_set_ILio_adaptivecards_objectmodel_MediaSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Set_ILio_adaptivecards_objectmodel_MediaSource_);
			return cb_set_ILio_adaptivecards_objectmodel_MediaSource_;
		}

		static void n_Set_ILio_adaptivecards_objectmodel_MediaSource_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSourceVector __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.MediaSource p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_ILio_adaptivecards_objectmodel_MediaSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='io.adaptivecards.objectmodel.MediaSource']]"
		[Register ("set", "(ILio/adaptivecards/objectmodel/MediaSource;)V", "GetSet_ILio_adaptivecards_objectmodel_MediaSource_Handler")]
		public virtual unsafe void Set (int p0, global::IO.Adaptivecards.Objectmodel.MediaSource p1)
		{
			if (id_set_ILio_adaptivecards_objectmodel_MediaSource_ == IntPtr.Zero)
				id_set_ILio_adaptivecards_objectmodel_MediaSource_ = JNIEnv.GetMethodID (class_ref, "set", "(ILio/adaptivecards/objectmodel/MediaSource;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_ILio_adaptivecards_objectmodel_MediaSource_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(ILio/adaptivecards/objectmodel/MediaSource;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Size);
			return cb_size;
		}

		static long n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSourceVector __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "GetSizeHandler")]
		public virtual unsafe long Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()J"));
			} finally {
			}
		}

	}
}
