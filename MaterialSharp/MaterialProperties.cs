﻿// MaterialProperties.tt: Repetitive properties that are used on all Material UI elements
//
// Authors: 
//    LeVan Nghia (original Swift code)
//    Miguel de Icaza (C# port)
//
//
// This file is generated from the MaterialProperties.tt file
// Do not edit this file, edit MaterialProperties.tt instead
//
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Foundation;
using System;
using System.ComponentModel;

namespace MaterialSharp {

    public partial class MaterialButton {
        public MaterialButton (NSCoder coder) : base (coder)
		{
			SetupLayer ();
		}

        protected MaterialButton (IntPtr handle) : base (handle)
		{
			SetupLayer ();
		}

		MaterialLayer materialLayer;
	
		public override CGRect Bounds {
			get {
				return base.Bounds;
			}
			set {
				base.Bounds = value;
				materialLayer.SuperLayerDidResize ();
			}
		}

		bool maskEnabled = true;
		[Browsable(true)]
		public bool MaskEnabled {
			get { return maskEnabled; }
			set {
				maskEnabled = value;
				materialLayer.EnableMask (value);
			}
		}

		RippleLocation rippleLocation = RippleLocation.TapLocation;
		[Browsable(true)]
		public RippleLocation RippleLocation {
			get { return rippleLocation; }
			set { 
				rippleLocation = value;
				materialLayer.RippleLocation = value;
			}
		}

		public float MaterialAnimationDuration = 0.65f;
		public CAMediaTimingFunction CircleAnimationTimingFunction = MaterialLayer.LinearTiming;
		public CAMediaTimingFunction BackgroundAnimationTimingFunction = MaterialLayer.LinearTiming;

		bool backgroundAnimationEnabled = true;
		[Browsable(true)]
		public bool BackgroundAnimationEnabled {
			get { return backgroundAnimationEnabled; }
			set { 
				if (backgroundAnimationEnabled == value)
					return;
				backgroundAnimationEnabled = value; 
				if (!value)
					materialLayer.EnableOnlyCircleLayer ();
			}
		}
			
		float circleGrowRatioMask = 0.9f;
		[Browsable(true)]
		public float CircleGrowRatioMask { 
			get { return circleGrowRatioMask; }
			set {
				circleGrowRatioMask = value;
				materialLayer.CircleGrowRatioMax = value;
			}
		}

		nfloat cornerRadius = 2.5f;
		[Browsable(true)]
		public nfloat CornerRadius { 
			get { return cornerRadius; }
			set { 
				cornerRadius = value;
				Layer.CornerRadius = value;
				materialLayer.SetMaskLayerCornerRadius (cornerRadius);
			}
		}

		UIColor circleLayerColor = UIColor.FromWhiteAlpha (0.45f, 0.5f);
		[Browsable(true)]
		public UIColor CircleLayerColor {
			get { return circleLayerColor; }
			set { 
				circleLayerColor = value;
				materialLayer.SetCircleLayerColor (value);
			}
		}

		UIColor backgroundLayerColor = UIColor.FromWhiteAlpha (0.75f, 0.5f);
		[Browsable(true)]
		public UIColor BackgroundLayerColor {
			get { return backgroundLayerColor; }
			set { 
				value = backgroundLayerColor;
				materialLayer.SetBackgroundLayerColor (value);
			}
		}
    }


    public partial class MaterialImageView {
        public MaterialImageView (NSCoder coder) : base (coder)
		{
			SetupLayer ();
		}

        protected MaterialImageView (IntPtr handle) : base (handle)
		{
			SetupLayer ();
		}

		MaterialLayer materialLayer;
	
		public override CGRect Bounds {
			get {
				return base.Bounds;
			}
			set {
				base.Bounds = value;
				materialLayer.SuperLayerDidResize ();
			}
		}

		bool maskEnabled = true;
		[Browsable(true)]
		public bool MaskEnabled {
			get { return maskEnabled; }
			set {
				maskEnabled = value;
				materialLayer.EnableMask (value);
			}
		}

		RippleLocation rippleLocation = RippleLocation.TapLocation;
		[Browsable(true)]
		public RippleLocation RippleLocation {
			get { return rippleLocation; }
			set { 
				rippleLocation = value;
				materialLayer.RippleLocation = value;
			}
		}

		public float MaterialAnimationDuration = 0.65f;
		public CAMediaTimingFunction CircleAnimationTimingFunction = MaterialLayer.LinearTiming;
		public CAMediaTimingFunction BackgroundAnimationTimingFunction = MaterialLayer.LinearTiming;

		bool backgroundAnimationEnabled = true;
		[Browsable(true)]
		public bool BackgroundAnimationEnabled {
			get { return backgroundAnimationEnabled; }
			set { 
				if (backgroundAnimationEnabled == value)
					return;
				backgroundAnimationEnabled = value; 
				if (!value)
					materialLayer.EnableOnlyCircleLayer ();
			}
		}
			
		float circleGrowRatioMask = 0.9f;
		[Browsable(true)]
		public float CircleGrowRatioMask { 
			get { return circleGrowRatioMask; }
			set {
				circleGrowRatioMask = value;
				materialLayer.CircleGrowRatioMax = value;
			}
		}

		nfloat cornerRadius = 2.5f;
		[Browsable(true)]
		public nfloat CornerRadius { 
			get { return cornerRadius; }
			set { 
				cornerRadius = value;
				materialLayer.SetMaskLayerCornerRadius (cornerRadius);
			}
		}

		UIColor circleLayerColor = UIColor.FromWhiteAlpha (0.45f, 0.5f);
		[Browsable(true)]
		public UIColor CircleLayerColor {
			get { return circleLayerColor; }
			set { 
				value = circleLayerColor;
				materialLayer.SetCircleLayerColor (value);
			}
		}

		UIColor backgroundLayerColor = UIColor.FromWhiteAlpha (0.75f, 0.5f);
		[Browsable(true)]
		public UIColor BackgroundLayerColor {
			get { return backgroundLayerColor; }
			set { 
				value = backgroundLayerColor;
				materialLayer.SetBackgroundLayerColor (value);
			}
		}
    }


    public partial class MaterialLabel {
        public MaterialLabel (NSCoder coder) : base (coder)
		{
			SetupLayer ();
		}

        protected MaterialLabel (IntPtr handle) : base (handle)
		{
			SetupLayer ();
		}

		MaterialLayer materialLayer;
	
		public override CGRect Bounds {
			get {
				return base.Bounds;
			}
			set {
				base.Bounds = value;
				materialLayer.SuperLayerDidResize ();
			}
		}

		bool maskEnabled = true;
		[Browsable(true)]
		public bool MaskEnabled {
			get { return maskEnabled; }
			set {
				maskEnabled = value;
				materialLayer.EnableMask (value);
			}
		}

		RippleLocation rippleLocation = RippleLocation.TapLocation;
		[Browsable(true)]
		public RippleLocation RippleLocation {
			get { return rippleLocation; }
			set { 
				rippleLocation = value;
				materialLayer.RippleLocation = value;
			}
		}

		public float MaterialAnimationDuration = 0.65f;
		public CAMediaTimingFunction CircleAnimationTimingFunction = MaterialLayer.LinearTiming;
		public CAMediaTimingFunction BackgroundAnimationTimingFunction = MaterialLayer.LinearTiming;

		bool backgroundAnimationEnabled = true;
		[Browsable(true)]
		public bool BackgroundAnimationEnabled {
			get { return backgroundAnimationEnabled; }
			set { 
				if (backgroundAnimationEnabled == value)
					return;
				backgroundAnimationEnabled = value; 
				if (!value)
					materialLayer.EnableOnlyCircleLayer ();
			}
		}
			
		float circleGrowRatioMask = 0.9f;
		[Browsable(true)]
		public float CircleGrowRatioMask { 
			get { return circleGrowRatioMask; }
			set {
				circleGrowRatioMask = value;
				materialLayer.CircleGrowRatioMax = value;
			}
		}

		nfloat cornerRadius = 2.5f;
		[Browsable(true)]
		public nfloat CornerRadius { 
			get { return cornerRadius; }
			set { 
				cornerRadius = value;
				materialLayer.SetMaskLayerCornerRadius (cornerRadius);
			}
		}

		UIColor circleLayerColor = UIColor.FromWhiteAlpha (0.45f, 0.5f);
		[Browsable(true)]
		public UIColor CircleLayerColor {
			get { return circleLayerColor; }
			set { 
				value = circleLayerColor;
				materialLayer.SetCircleLayerColor (value);
			}
		}

		UIColor backgroundLayerColor = UIColor.FromWhiteAlpha (0.75f, 0.5f);
		[Browsable(true)]
		public UIColor BackgroundLayerColor {
			get { return backgroundLayerColor; }
			set { 
				value = backgroundLayerColor;
				materialLayer.SetBackgroundLayerColor (value);
			}
		}
    }


    public partial class MaterialTextField {
        public MaterialTextField (NSCoder coder) : base (coder)
		{
			SetupLayer ();
		}

        protected MaterialTextField (IntPtr handle) : base (handle)
		{
			SetupLayer ();
		}

		MaterialLayer materialLayer;
	
		public override CGRect Bounds {
			get {
				return base.Bounds;
			}
			set {
				base.Bounds = value;
				materialLayer.SuperLayerDidResize ();
			}
		}

		bool maskEnabled = true;
		[Browsable(true)]
		public bool MaskEnabled {
			get { return maskEnabled; }
			set {
				maskEnabled = value;
				materialLayer.EnableMask (value);
			}
		}

		RippleLocation rippleLocation = RippleLocation.TapLocation;
		[Browsable(true)]
		public RippleLocation RippleLocation {
			get { return rippleLocation; }
			set { 
				rippleLocation = value;
				materialLayer.RippleLocation = value;
			}
		}

		public float MaterialAnimationDuration = 0.65f;
		public CAMediaTimingFunction CircleAnimationTimingFunction = MaterialLayer.LinearTiming;
		public CAMediaTimingFunction BackgroundAnimationTimingFunction = MaterialLayer.LinearTiming;

		bool backgroundAnimationEnabled = true;
		[Browsable(true)]
		public bool BackgroundAnimationEnabled {
			get { return backgroundAnimationEnabled; }
			set { 
				if (backgroundAnimationEnabled == value)
					return;
				backgroundAnimationEnabled = value; 
				if (!value)
					materialLayer.EnableOnlyCircleLayer ();
			}
		}
			
		float circleGrowRatioMask = 0.9f;
		[Browsable(true)]
		public float CircleGrowRatioMask { 
			get { return circleGrowRatioMask; }
			set {
				circleGrowRatioMask = value;
				materialLayer.CircleGrowRatioMax = value;
			}
		}

		nfloat cornerRadius = 2.5f;
		[Browsable(true)]
		public nfloat CornerRadius { 
			get { return cornerRadius; }
			set { 
				cornerRadius = value;
				materialLayer.SetMaskLayerCornerRadius (cornerRadius);
			}
		}

		UIColor circleLayerColor = UIColor.FromWhiteAlpha (0.45f, 0.5f);
		[Browsable(true)]
		public UIColor CircleLayerColor {
			get { return circleLayerColor; }
			set { 
				value = circleLayerColor;
				materialLayer.SetCircleLayerColor (value);
			}
		}

		UIColor backgroundLayerColor = UIColor.FromWhiteAlpha (0.75f, 0.5f);
		[Browsable(true)]
		public UIColor BackgroundLayerColor {
			get { return backgroundLayerColor; }
			set { 
				value = backgroundLayerColor;
				materialLayer.SetBackgroundLayerColor (value);
			}
		}
    }


    public partial class MaterialTableViewCell {
        public MaterialTableViewCell (NSCoder coder) : base (coder)
		{
			SetupLayer ();
		}

        protected MaterialTableViewCell (IntPtr handle) : base (handle)
		{
			SetupLayer ();
		}

		MaterialLayer materialLayer;
	
		public override CGRect Bounds {
			get {
				return base.Bounds;
			}
			set {
				base.Bounds = value;
				materialLayer.SuperLayerDidResize ();
			}
		}

		bool maskEnabled = true;
		[Browsable(true)]
		public bool MaskEnabled {
			get { return maskEnabled; }
			set {
				maskEnabled = value;
				materialLayer.EnableMask (value);
			}
		}

		RippleLocation rippleLocation = RippleLocation.TapLocation;
		[Browsable(true)]
		public RippleLocation RippleLocation {
			get { return rippleLocation; }
			set { 
				rippleLocation = value;
				materialLayer.RippleLocation = value;
			}
		}

		public float MaterialAnimationDuration = 0.65f;
		public CAMediaTimingFunction CircleAnimationTimingFunction = MaterialLayer.LinearTiming;
		public CAMediaTimingFunction BackgroundAnimationTimingFunction = MaterialLayer.LinearTiming;

		bool backgroundAnimationEnabled = true;
		[Browsable(true)]
		public bool BackgroundAnimationEnabled {
			get { return backgroundAnimationEnabled; }
			set { 
				if (backgroundAnimationEnabled == value)
					return;
				backgroundAnimationEnabled = value; 
				if (!value)
					materialLayer.EnableOnlyCircleLayer ();
			}
		}
			
		float circleGrowRatioMask = 0.9f;
		[Browsable(true)]
		public float CircleGrowRatioMask { 
			get { return circleGrowRatioMask; }
			set {
				circleGrowRatioMask = value;
				materialLayer.CircleGrowRatioMax = value;
			}
		}

		nfloat cornerRadius = 2.5f;
		[Browsable(true)]
		public nfloat CornerRadius { 
			get { return cornerRadius; }
			set { 
				cornerRadius = value;
				materialLayer.SetMaskLayerCornerRadius (cornerRadius);
			}
		}

		UIColor circleLayerColor = UIColor.FromWhiteAlpha (0.45f, 0.5f);
		[Browsable(true)]
		public UIColor CircleLayerColor {
			get { return circleLayerColor; }
			set { 
				value = circleLayerColor;
				materialLayer.SetCircleLayerColor (value);
			}
		}

		UIColor backgroundLayerColor = UIColor.FromWhiteAlpha (0.75f, 0.5f);
		[Browsable(true)]
		public UIColor BackgroundLayerColor {
			get { return backgroundLayerColor; }
			set { 
				value = backgroundLayerColor;
				materialLayer.SetBackgroundLayerColor (value);
			}
		}
    }


}