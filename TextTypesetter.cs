// Copyright (c) 2012, Joshua Burke  
// All rights reserved.
// 
// See LICENSE for more information.

using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Frost.Formatting
{
	public sealed class TextTypesetter
	{
		private Paragraph _Paragraph;

		private float _Leading;
		private float _Tracking;
		private float _Spacing;

		private readonly List<Rectangle> _Figures;
		
		public TextTypesetter()
		{
			_Figures = new List<Rectangle>();
		}

		public Paragraph Paragraph
		{
			get { return _Paragraph; }
		}
		
		public void Begin(
			ITypesetText outputSink, Rectangle layoutRegion, IShapedText inputSink)
		{
			Contract.Requires(outputSink != null);
			Contract.Requires(inputSink != null);
			Contract.Requires(Paragraph == null);
			
			_Figures.Clear();

			_Paragraph = inputSink.Paragraph;
		}

		public void AddStaticFigure(Rectangle region)
		{
			Contract.Requires(Paragraph != null);

			_Figures.Add(region);
		}

		public float Leading
		{
			get
			{
				Contract.Requires(Paragraph != null);

				return _Leading;
			}
			set
			{
				Contract.Requires(Paragraph != null);

				_Leading = value;
			}
		}

		public float Tracking
		{
			get
			{
				Contract.Requires(Paragraph != null);

				return _Tracking;
			}
			set
			{
				Contract.Requires(Paragraph != null);

				_Tracking = value;
			}
		}

		/* TODO: 
		 * 
		 * public float Spacing
		{
			get
			{
				Contract.Requires(Paragraph != null);

				return _Spacing;
			}
			set
			{
				Contract.Requires(Paragraph != null);

				_Spacing = value;
			}
		}*/

		public void End()
		{
			Contract.Requires(Paragraph != null);
		}
	}
}