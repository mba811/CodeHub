// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace CodeHub.iOS.Cells
{
	[Register ("FeedbackCellView")]
	partial class FeedbackCellView
	{
		[Outlet]
		MonoTouch.UIKit.NSLayoutConstraint DetailsConstraint { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel DetailsLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView MainImageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DetailsLabel != null) {
				DetailsLabel.Dispose ();
				DetailsLabel = null;
			}

			if (MainImageView != null) {
				MainImageView.Dispose ();
				MainImageView = null;
			}

			if (TitleLabel != null) {
				TitleLabel.Dispose ();
				TitleLabel = null;
			}

			if (DetailsConstraint != null) {
				DetailsConstraint.Dispose ();
				DetailsConstraint = null;
			}
		}
	}
}
