using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Input {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='SummingFunction']"
	[global::Android.Runtime.Register ("org/neuroph/core/input/SummingFunction", DoNotGenerateAcw=true)]
	public abstract partial class SummingFunction : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/input/SummingFunction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SummingFunction); }
		}

		protected SummingFunction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='SummingFunction']/constructor[@name='SummingFunction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SummingFunction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SummingFunction)) {
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

		static Delegate cb_getOutput_arrayD;
#pragma warning disable 0169
		static Delegate GetGetOutput_arrayDHandler ()
		{
			if (cb_getOutput_arrayD == null)
				cb_getOutput_arrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_GetOutput_arrayD);
			return cb_getOutput_arrayD;
		}

		static double n_GetOutput_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Input.SummingFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.SummingFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double __ret = __this.GetOutput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='SummingFunction']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("getOutput", "([D)D", "GetGetOutput_arrayDHandler")]
		public abstract double GetOutput (double[] p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/core/input/SummingFunction", DoNotGenerateAcw=true)]
	internal partial class SummingFunctionInvoker : SummingFunction {

		public SummingFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SummingFunctionInvoker); }
		}

		static IntPtr id_getOutput_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='SummingFunction']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("getOutput", "([D)D", "GetGetOutput_arrayDHandler")]
		public override unsafe double GetOutput (double[] p0)
		{
			if (id_getOutput_arrayD == IntPtr.Zero)
				id_getOutput_arrayD = JNIEnv.GetMethodID (class_ref, "getOutput", "([D)D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double __ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getOutput_arrayD, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
