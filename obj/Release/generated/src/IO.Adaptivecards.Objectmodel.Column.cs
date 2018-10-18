using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/Column", DoNotGenerateAcw=true)]
	public partial class Column : global::IO.Adaptivecards.Objectmodel.BaseCardElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/Column", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Column); }
		}

		protected Column (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/constructor[@name='Column' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Column (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Column)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/constructor[@name='Column' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Column ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Column)) {
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

		static Delegate cb_GetItems;
#pragma warning disable 0169
		static Delegate GetGetItemsHandler ()
		{
			if (cb_GetItems == null)
				cb_GetItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItems);
			return cb_GetItems;
		}

		static IntPtr n_GetItems (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Items);
		}
#pragma warning restore 0169

		static IntPtr id_GetItems;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseCardElementVector Items {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='GetItems' and count(parameter)=0]"
			[Register ("GetItems", "()Lio/adaptivecards/objectmodel/BaseCardElementVector;", "GetGetItemsHandler")]
			get {
				if (id_GetItems == IntPtr.Zero)
					id_GetItems = JNIEnv.GetMethodID (class_ref, "GetItems", "()Lio/adaptivecards/objectmodel/BaseCardElementVector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElementVector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetItems), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElementVector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetItems", "()Lio/adaptivecards/objectmodel/BaseCardElementVector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetPixelWidth;
#pragma warning disable 0169
		static Delegate GetGetPixelWidthHandler ()
		{
			if (cb_GetPixelWidth == null)
				cb_GetPixelWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPixelWidth);
			return cb_GetPixelWidth;
		}

		static int n_GetPixelWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelWidth;
		}
#pragma warning restore 0169

		static Delegate cb_SetPixelWidth_I;
#pragma warning disable 0169
		static Delegate GetSetPixelWidth_IHandler ()
		{
			if (cb_SetPixelWidth_I == null)
				cb_SetPixelWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPixelWidth_I);
			return cb_SetPixelWidth_I;
		}

		static void n_SetPixelWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PixelWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetPixelWidth;
		static IntPtr id_SetPixelWidth_I;
		public virtual unsafe int PixelWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='GetPixelWidth' and count(parameter)=0]"
			[Register ("GetPixelWidth", "()I", "GetGetPixelWidthHandler")]
			get {
				if (id_GetPixelWidth == IntPtr.Zero)
					id_GetPixelWidth = JNIEnv.GetMethodID (class_ref, "GetPixelWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetPixelWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPixelWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='SetPixelWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetPixelWidth", "(I)V", "GetSetPixelWidth_IHandler")]
			set {
				if (id_SetPixelWidth_I == IntPtr.Zero)
					id_SetPixelWidth_I = JNIEnv.GetMethodID (class_ref, "SetPixelWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetPixelWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPixelWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetSelectAction;
#pragma warning disable 0169
		static Delegate GetGetSelectActionHandler ()
		{
			if (cb_GetSelectAction == null)
				cb_GetSelectAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectAction);
			return cb_GetSelectAction;
		}

		static IntPtr n_GetSelectAction (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectAction);
		}
#pragma warning restore 0169

		static Delegate cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
#pragma warning disable 0169
		static Delegate GetSetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_Handler ()
		{
			if (cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ == null)
				cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_);
			return cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
		}

		static void n_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseActionElement p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectAction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectAction;
		static IntPtr id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseActionElement SelectAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='GetSelectAction' and count(parameter)=0]"
			[Register ("GetSelectAction", "()Lio/adaptivecards/objectmodel/BaseActionElement;", "GetGetSelectActionHandler")]
			get {
				if (id_GetSelectAction == IntPtr.Zero)
					id_GetSelectAction = JNIEnv.GetMethodID (class_ref, "GetSelectAction", "()Lio/adaptivecards/objectmodel/BaseActionElement;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetSelectAction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelectAction", "()Lio/adaptivecards/objectmodel/BaseActionElement;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='SetSelectAction' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseActionElement']]"
			[Register ("SetSelectAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;)V", "GetSetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_Handler")]
			set {
				if (id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ == IntPtr.Zero)
					id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ = JNIEnv.GetMethodID (class_ref, "SetSelectAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSelectAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetStyle;
#pragma warning disable 0169
		static Delegate GetGetStyleHandler ()
		{
			if (cb_GetStyle == null)
				cb_GetStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStyle);
			return cb_GetStyle;
		}

		static IntPtr n_GetStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Style);
		}
#pragma warning restore 0169

		static Delegate cb_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_;
#pragma warning disable 0169
		static Delegate GetSetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_Handler ()
		{
			if (cb_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ == null)
				cb_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_);
			return cb_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_;
		}

		static void n_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ContainerStyle p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Style = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetStyle;
		static IntPtr id_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ContainerStyle Style {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='GetStyle' and count(parameter)=0]"
			[Register ("GetStyle", "()Lio/adaptivecards/objectmodel/ContainerStyle;", "GetGetStyleHandler")]
			get {
				if (id_GetStyle == IntPtr.Zero)
					id_GetStyle = JNIEnv.GetMethodID (class_ref, "GetStyle", "()Lio/adaptivecards/objectmodel/ContainerStyle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStyle", "()Lio/adaptivecards/objectmodel/ContainerStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='SetStyle' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ContainerStyle']]"
			[Register ("SetStyle", "(Lio/adaptivecards/objectmodel/ContainerStyle;)V", "GetSetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_Handler")]
			set {
				if (id_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ == IntPtr.Zero)
					id_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNIEnv.GetMethodID (class_ref, "SetStyle", "(Lio/adaptivecards/objectmodel/ContainerStyle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStyle", "(Lio/adaptivecards/objectmodel/ContainerStyle;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetVerticalContentAlignment;
#pragma warning disable 0169
		static Delegate GetGetVerticalContentAlignmentHandler ()
		{
			if (cb_GetVerticalContentAlignment == null)
				cb_GetVerticalContentAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerticalContentAlignment);
			return cb_GetVerticalContentAlignment;
		}

		static IntPtr n_GetVerticalContentAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VerticalContentAlignment);
		}
#pragma warning restore 0169

		static Delegate cb_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_;
#pragma warning disable 0169
		static Delegate GetSetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Handler ()
		{
			if (cb_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ == null)
				cb_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_);
			return cb_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_;
		}

		static void n_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VerticalContentAlignment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetVerticalContentAlignment;
		static IntPtr id_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment VerticalContentAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='GetVerticalContentAlignment' and count(parameter)=0]"
			[Register ("GetVerticalContentAlignment", "()Lio/adaptivecards/objectmodel/VerticalContentAlignment;", "GetGetVerticalContentAlignmentHandler")]
			get {
				if (id_GetVerticalContentAlignment == IntPtr.Zero)
					id_GetVerticalContentAlignment = JNIEnv.GetMethodID (class_ref, "GetVerticalContentAlignment", "()Lio/adaptivecards/objectmodel/VerticalContentAlignment;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetVerticalContentAlignment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetVerticalContentAlignment", "()Lio/adaptivecards/objectmodel/VerticalContentAlignment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='SetVerticalContentAlignment' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.VerticalContentAlignment']]"
			[Register ("SetVerticalContentAlignment", "(Lio/adaptivecards/objectmodel/VerticalContentAlignment;)V", "GetSetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Handler")]
			set {
				if (id_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ == IntPtr.Zero)
					id_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ = JNIEnv.GetMethodID (class_ref, "SetVerticalContentAlignment", "(Lio/adaptivecards/objectmodel/VerticalContentAlignment;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetVerticalContentAlignment", "(Lio/adaptivecards/objectmodel/VerticalContentAlignment;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_GetWidth == null)
				cb_GetWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWidth);
			return cb_GetWidth;
		}

		static IntPtr n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Width);
		}
#pragma warning restore 0169

		static Delegate cb_SetWidth_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWidth_Ljava_lang_String_Handler ()
		{
			if (cb_SetWidth_Ljava_lang_String_ == null)
				cb_SetWidth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWidth_Ljava_lang_String_);
			return cb_SetWidth_Ljava_lang_String_;
		}

		static void n_SetWidth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetWidth;
		static IntPtr id_SetWidth_Ljava_lang_String_;
		public virtual unsafe string Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='GetWidth' and count(parameter)=0]"
			[Register ("GetWidth", "()Ljava/lang/String;", "GetGetWidthHandler")]
			get {
				if (id_GetWidth == IntPtr.Zero)
					id_GetWidth = JNIEnv.GetMethodID (class_ref, "GetWidth", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetWidth), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetWidth", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='SetWidth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetWidth", "(Ljava/lang/String;)V", "GetSetWidth_Ljava_lang_String_Handler")]
			set {
				if (id_SetWidth_Ljava_lang_String_ == IntPtr.Zero)
					id_SetWidth_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetWidth", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetWidth_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetWidth", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='Deserialize' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionParserRegistration'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCardParseWarningVector'] and parameter[4][@type='io.adaptivecards.objectmodel.JsonValue']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/Column;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Column Deserialize (global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2, global::IO.Adaptivecards.Objectmodel.JsonValue p3)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/Column;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::IO.Adaptivecards.Objectmodel.Column __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='DeserializeFromString' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionParserRegistration'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCardParseWarningVector'] and parameter[4][@type='java.lang.String']]"
		[Register ("DeserializeFromString", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Ljava/lang/String;)Lio/adaptivecards/objectmodel/Column;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Column DeserializeFromString (global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2, string p3)
		{
			if (id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ == IntPtr.Zero)
				id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromString", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Ljava/lang/String;)Lio/adaptivecards/objectmodel/Column;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::IO.Adaptivecards.Objectmodel.Column __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_SetLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_SetLanguage_Ljava_lang_String_ == null)
				cb_SetLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLanguage_Ljava_lang_String_);
			return cb_SetLanguage_Ljava_lang_String_;
		}

		static void n_SetLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Column __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLanguage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetLanguage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='SetLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLanguage (string p0)
		{
			if (id_SetLanguage_Ljava_lang_String_ == IntPtr.Zero)
				id_SetLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetLanguage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetLanguage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetLanguage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/Column;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Column Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/Column;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.Column __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_Column_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Column']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.Column']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/Column;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.Column p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_Column_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_Column_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/Column;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_Column_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
