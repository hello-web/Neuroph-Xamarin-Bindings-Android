using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Input {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='WeightsFunction']"
	[global::Android.Runtime.Register ("org/neuroph/core/input/WeightsFunction", DoNotGenerateAcw=true)]
	public abstract partial class WeightsFunction : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/input/WeightsFunction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeightsFunction); }
		}

		protected WeightsFunction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='WeightsFunction']/constructor[@name='WeightsFunction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WeightsFunction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WeightsFunction)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static Delegate cb_getOutput_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetGetOutput_arrayDarrayDHandler ()
		{
			if (cb_getOutput_arrayDarrayD == null)
				cb_getOutput_arrayDarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOutput_arrayDarrayD);
			return cb_getOutput_arrayDarrayD;
		}

		static IntPtr n_GetOutput_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.Input.WeightsFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.WeightsFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.NewArray (__this.GetOutput (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='WeightsFunction']/method[@name='getOutput' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("getOutput", "([D[D)[D", "GetGetOutput_arrayDarrayDHandler")]
		public abstract double[] GetOutput (double[] p0, double[] p1);

		static Delegate cb_getOutput_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetOutput_Ljava_util_List_Handler ()
		{
			if (cb_getOutput_Ljava_util_List_ == null)
				cb_getOutput_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOutput_Ljava_util_List_);
			return cb_getOutput_Ljava_util_List_;
		}

		static IntPtr n_GetOutput_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Input.WeightsFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.WeightsFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Connection>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetOutput (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='WeightsFunction']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.neuroph.core.Connection&gt;']]"
		[Register ("getOutput", "(Ljava/util/List;)[D", "GetGetOutput_Ljava_util_List_Handler")]
		public abstract double[] GetOutput (global::System.Collections.Generic.IList<global::Org.Neuroph.Core.Connection> p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/core/input/WeightsFunction", DoNotGenerateAcw=true)]
	internal partial class WeightsFunctionInvoker : WeightsFunction {

		public WeightsFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeightsFunctionInvoker); }
		}

		static IntPtr id_getOutput_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='WeightsFunction']/method[@name='getOutput' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("getOutput", "([D[D)[D", "GetGetOutput_arrayDarrayDHandler")]
		public override unsafe double[] GetOutput (double[] p0, double[] p1)
		{
			if (id_getOutput_arrayDarrayD == IntPtr.Zero)
				id_getOutput_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "getOutput", "([D[D)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutput_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_getOutput_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='WeightsFunction']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.neuroph.core.Connection&gt;']]"
		[Register ("getOutput", "(Ljava/util/List;)[D", "GetGetOutput_Ljava_util_List_Handler")]
		public override unsafe double[] GetOutput (global::System.Collections.Generic.IList<global::Org.Neuroph.Core.Connection> p0)
		{
			if (id_getOutput_Ljava_util_List_ == IntPtr.Zero)
				id_getOutput_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getOutput", "(Ljava/util/List;)[D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Connection>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutput_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
