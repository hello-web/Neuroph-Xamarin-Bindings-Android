using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningStoppedEvent']"
	[global::Android.Runtime.Register ("org/neuroph/core/events/LearningStoppedEvent", DoNotGenerateAcw=true)]
	public partial class LearningStoppedEvent : global::Org.Neuroph.Core.Events.LearningEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/events/LearningStoppedEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LearningStoppedEvent); }
		}

		protected LearningStoppedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_learning_LearningRule_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningStoppedEvent']/constructor[@name='LearningStoppedEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.LearningRule']]"
		[Register (".ctor", "(Lorg/neuroph/core/learning/LearningRule;)V", "")]
		public unsafe LearningStoppedEvent (global::Org.Neuroph.Core.Learning.LearningRule p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LearningStoppedEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/learning/LearningRule;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/learning/LearningRule;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_learning_LearningRule_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_learning_LearningRule_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/learning/LearningRule;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_learning_LearningRule_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_learning_LearningRule_, __args);
			} finally {
			}
		}

	}
}
