using System;
using Xamarin.Forms;
namespace SabsGetsAbs.Utilities
{
    public class RelativeLayoutUtil
    {
        public RelativeLayoutUtil(){}

        /// <summary>
        /// Positions the view inside relative layout
        /// </summary>
        /// <param name="CurrentView">Current view.</param>
        /// <param name="XFactor">XF actor.</param>
        /// <param name="YFactor">YF actor.</param>
        /// <param name="WidthFactor">Width factor.</param>
        /// <param name="HeightFactor">Height factor.</param>
        public static void ViewPositioning(View CurrentView, double XFactor, double YFactor, double WidthFactor, double HeightFactor)
        {
            RelativeLayout.SetWidthConstraint(CurrentView, Constraint.RelativeToParent(Parent =>
            {
                return (Parent.Width * WidthFactor);
            }));
            RelativeLayout.SetHeightConstraint(CurrentView, Constraint.RelativeToParent(Parent =>
            {
                return (Parent.Height * HeightFactor);
            }));
            RelativeLayout.SetXConstraint(CurrentView, Constraint.RelativeToParent(Parent =>
            {
                return (Parent.Width * XFactor);
            }));
            RelativeLayout.SetYConstraint(CurrentView, Constraint.RelativeToParent(Parent =>
            {
                return (Parent.Height * YFactor);
            }));
        }

        /// <summary>
        /// Adds and positions the view on the relative layout
        /// </summary>
        /// <param name="ContentLayout">Content layout.</param>
        /// <param name="CurrentView">Current view.</param>
        /// <param name="XFactor">XF actor.</param>
        /// <param name="YFactor">YF actor.</param>
        /// <param name="WidthFactor">Width factor.</param>
        /// <param name="HeightFactor">Height factor.</param>
        public static void AddViewToLayout(RelativeLayout ContentLayout, View CurrentView, double XFactor, double YFactor, double WidthFactor, double HeightFactor)
        {
            ContentLayout.Children.Add(CurrentView,
            Constraint.RelativeToParent(Parent =>
            {
                return (Parent.Width * XFactor);
            }),
            Constraint.RelativeToParent(Parent =>
            {
                return (Parent.Height * YFactor);
            }),
            Constraint.RelativeToParent(Parent =>
            {
                return (Parent.Width * WidthFactor);
            }),
            Constraint.RelativeToParent(Parent =>
            {
                return (Parent.Height * HeightFactor);
            }));
        }

        /// <summary>
        /// Sets the safe insets of an iOS app
        /// </summary>
        /// <returns>The safe insets.</returns>
        /// <param name="Width">Width.</param>
        /// <param name="Height">Height.</param>
        /// <param name="SafeInsets">Safe insets.</param>
        public static Thickness SetSafeInsets(double Width, double Height, Thickness SafeInsets)
        {
            Thickness Padding;
            //Determines the orientation and sets the insets accordingly each zeroed value removes the inset.
            if(Width < Height)
            {
                SafeInsets.Left = 0;
                SafeInsets.Right = 0;
                SafeInsets.Bottom = 20;
                if (SafeInsets.Top == 20)
                {
                    SafeInsets.Bottom = 0;
                }
            }
            else
            {
                SafeInsets.Bottom = 0;
                SafeInsets.Top = 0;
                SafeInsets.Right = 20;
                SafeInsets.Left = 20;
            }



            Padding = SafeInsets;

            return Padding;
        }
    }
}
